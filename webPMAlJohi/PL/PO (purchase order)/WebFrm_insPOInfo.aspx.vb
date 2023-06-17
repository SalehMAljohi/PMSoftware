Imports System.IO
Imports System.Configuration
Public Class WebFrm_insPOInfo
    Inherits System.Web.UI.Page
    Dim bl1 As New Clr_projcInfo
    Dim bl As New Clr_POINFO

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dt As New DataTable
        If Not IsPostBack Then
            DDLOPPInfoNo.DataSource = bl1.Get_Projectname()
            DDLOPPInfoNo.DataTextField = "Project_name"
            DDLOPPInfoNo.DataBind()
            Dim li1 As ListItem = New ListItem("اختار اسم المشروع", "-1")
            DDLOPPInfoNo.Items.Insert(0, li1)
            DDLOPPInfoNo.Focus()
        End If
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Calendar_Date.Visible = True
    End Sub

    Protected Sub Calendar_Date_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar_Date.SelectionChanged
        txt_Date.Text = Calendar_Date.SelectedDate.Date.ToString("d")
        Calendar_Date.Visible = False
    End Sub

    Protected Sub ImageButton2_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton2.Click
        Calendar_S_Date.Visible = True
    End Sub

    Protected Sub Calendar_S_Date_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar_S_Date.SelectionChanged
        txtS_Date.Text = Calendar_S_Date.SelectedDate.Date.ToString("d")
        Calendar_S_Date.Visible = False
    End Sub

    Protected Sub ImageButton3_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton3.Click
        Calendar_E_Date.Visible = True
    End Sub

    Protected Sub Calendar_E_Date_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar_E_Date.SelectionChanged
        txtE_Date.Text = Calendar_E_Date.SelectedDate.Date.ToString("d")
        Calendar_E_Date.Visible = False
    End Sub
    Protected Sub DDLOPPInfoNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDLOPPInfoNo.SelectedIndexChanged
        'If DDLOPPInfoNo.SelectedValue = True Then
        '    txt_Date.Focus()
        'End If
    End Sub



    Protected Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim filename As String = (FileUpload1.FileName)
        Dim pat As String = Path.GetFileName(filename)
        Dim fs As Stream = FileUpload1.PostedFile.InputStream
        Dim br As BinaryReader = New BinaryReader(fs) 'reads the binary files  
        Dim bytes() As Byte = br.ReadBytes(fs.Length) 'counting the file length into bytes 
        FileUpload1.SaveAs(Server.MapPath("~/FUpload/projInfo" + Session.SessionID + pat))
        Dim dt1 As New DataTable
        Dim Project_no As Integer

        If DDLOPPInfoNo.SelectedItem.Text <> "اختار اسم المشروع" Then
            dt1 = bl1.Get_ProjectInfNo(DDLOPPInfoNo.SelectedItem.Text)
            Project_no = Convert.ToInt64(dt1.Rows(0)(0))
            If pat = "" Then
                bl.POInfNoImage(txt_Date.Text,
                txtS_Date.Text, txtE_Date.Text,
                Convert.ToDouble(txtPO_Value.Text),
               Project_no)
                Label1.Text = "تم الاضافة بنجاح"
                Label1.BackColor = System.Drawing.Color.Green
                Label1.ForeColor = System.Drawing.Color.White

                'txtPO_no.Text = ""
                txt_Date.Text = ""
                txtS_Date.Text = ""
                txtE_Date.Text = ""
                txtPO_Value.Text = ""
                DDLOPPInfoNo.SelectedIndex = -1
                DDLOPPInfoNo.Focus()
            Else
                bl.POInf(txt_Date.Text,
                          txtS_Date.Text, txtE_Date.Text,
                          Convert.ToDouble(txtPO_Value.Text), pat,
                         Project_no)
                Label1.Text = "تم الاضافة بنجاح"
                Label1.BackColor = System.Drawing.Color.Green
                Label1.ForeColor = System.Drawing.Color.White
                'txtPO_no.Text = ""
                txt_Date.Text = ""
                txtS_Date.Text = ""
                txtE_Date.Text = ""
                txtPO_Value.Text = ""
                DDLOPPInfoNo.SelectedIndex = -1
                DDLOPPInfoNo.Focus()
            End If
        Else
            DDLOPPInfoNo.Focus()
        End If
        Response.Redirect("../PO (purchase order)/PO_Items.aspx")
    End Sub


End Class