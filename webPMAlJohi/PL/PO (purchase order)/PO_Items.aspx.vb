Imports System.IO
Imports System.Data

Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Configuration
Imports System
Public Class PO_Items
    Inherits System.Web.UI.Page
    Dim bl As New Clr_POINFO
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            DDLPONo.DataSource = bl.Get_POInfo_No()
            DDLPONo.DataTextField = "PO_No"
            DDLPONo.DataBind()
            Dim li1 As ListItem = New ListItem("اختار رقم التعميد", "-1")
            DDLPONo.Items.Insert(0, li1)
            DDLPONo.Focus()
        End If
    End Sub

    Protected Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

        'Upload And save the file
        Dim excelPath As String = Server.MapPath("~/Files/") + Path.GetFileName(FileUpload1.PostedFile.FileName)
        FileUpload1.SaveAs(excelPath)

        Dim conString As String = String.Empty
        Dim extension As String = Path.GetExtension(FileUpload1.PostedFile.FileName)
        Select Case extension
            Case ".xls"    'Excel 97-03
                conString = ConfigurationManager.ConnectionStrings("Excel03ConString").ConnectionString
                Exit Select
            Case ".xlsx"    'Excel 07 Or higher
                conString = ConfigurationManager.ConnectionStrings("Excel07+ConString").ConnectionString
                Exit Select
        End Select

        conString = String.Format(conString, excelPath)
        Using excel_con As OleDbConnection = New OleDbConnection(conString)



            excel_con.Open()
            Dim sheet1 As String = excel_con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing).Rows(0)("TABLE_NAME").ToString()
            Dim dtExcelData As DataTable = New DataTable()


            '[OPTIONAL] It Is recommended as otherwise the data will be considered as String by default.
            dtExcelData.Columns.AddRange(New DataColumn() {New DataColumn("Item_Uprice", GetType(Decimal)),
                                       New DataColumn("Item_no", GetType(Integer)),
                                       New DataColumn("PO_no", GetType(Integer))})

            Using oda As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con)

                oda.Fill(dtExcelData)
            End Using

            excel_con.Close()

            Dim consString As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
            Using con As SqlConnection = New SqlConnection(consString)

                Using sqlBulkCopy As SqlBulkCopy = New SqlBulkCopy(con)

                    'Set the database table name
                    sqlBulkCopy.DestinationTableName = "dbo.Tbl_R_PO_I_Inf"

                    '[OPTIONAL] Map the Excel columns with that of the database table
                    sqlBulkCopy.ColumnMappings.Add("Item_Uprice", "Item_UPrice")
                    sqlBulkCopy.ColumnMappings.Add("Item_no", "Item_no")
                    sqlBulkCopy.ColumnMappings.Add("PO_no", "PO_no")

                    con.Open()
                    sqlBulkCopy.WriteToServer(dtExcelData)
                    con.Close()
                End Using
            End Using
        End Using
        Label1.Text = "تم الاضافة البنود بنجاح"
        Response.Redirect("../PO (purchase order)/WebFrm_insPOInfo.aspx")
    End Sub

End Class