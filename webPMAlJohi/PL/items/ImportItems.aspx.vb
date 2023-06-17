Imports System.IO
Imports System.Data

Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Configuration
Public Class ImportItems
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            FileUpload1.Focus()
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
            Case ".xlsx"    'Excel 07 Or higher
                conString = ConfigurationManager.ConnectionStrings("Excel07+ConString").ConnectionString
        End Select

        conString = String.Format(conString, excelPath)
        Using excel_con As OleDbConnection = New OleDbConnection(conString)



            excel_con.Open()
            Dim sheet1 As String = excel_con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing).Rows(0)("TABLE_NAME").ToString()
            Dim dtExcelData As DataTable = New DataTable()


            '[OPTIONAL] It Is recommended as otherwise the data will be considered as String by default.
            dtExcelData.Columns.AddRange(New DataColumn(2) {New DataColumn("STC_Item_no", GetType(String)),
                                       New DataColumn("Item_Des", GetType(String)),
                                       New DataColumn("Item_Unit", GetType(String))})

            Using oda As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con)

                oda.Fill(dtExcelData)
            End Using

            excel_con.Close()

            Dim consString As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
            Using con As SqlConnection = New SqlConnection(consString)

                Using sqlBulkCopy As SqlBulkCopy = New SqlBulkCopy(con)

                    'Set the database table name
                    sqlBulkCopy.DestinationTableName = "dbo.Tbl_Items"

                    '[OPTIONAL] Map the Excel columns with that of the database table
                    sqlBulkCopy.ColumnMappings.Add("STC_Item_no", "STC_Item_no")
                    sqlBulkCopy.ColumnMappings.Add("Item_Des", "Item_Des")
                    sqlBulkCopy.ColumnMappings.Add("Item_Unit", "Item_Unit")
                    con.Open()
                    sqlBulkCopy.WriteToServer(dtExcelData)
                    con.Close()
                End Using
            End Using
        End Using
        Label1.Text = "تم الاضافة البنود بنجاح"
        Response.Redirect("../items/WebFrm_MainItems.aspx")

    End Sub
End Class