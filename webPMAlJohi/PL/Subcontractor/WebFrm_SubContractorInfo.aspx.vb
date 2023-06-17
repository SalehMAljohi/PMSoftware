Imports System.IO
Public Class WebFrm_SubContractorInfo
    Inherits System.Web.UI.Page
    Dim bl As New Clr_SubConInfo
    Dim bl1 As New Clr_Items
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not IsPostBack Then
        '    txtSubCon_NO.Focus()
        '    DDLItem.DataSource = bl1.Get_Item_no()
        '    DDLItem.DataTextField = "Item_no"
        '    DDLItem.DataBind()
        '    Dim li1 As ListItem = New ListItem("اختار رقم البند", "-1")
        '    DDLItem.Items.Insert(0, li1)
        'End If
    End Sub
    Protected Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim filename As String = (FileUpload1.FileName)
        Dim pat As String = path.GetFileName(filename)
        Dim fs As Stream = FileUpload1.PostedFile.InputStream
        Dim br As BinaryReader = New BinaryReader(fs) 'reads the binary files  
        Dim bytes() As Byte = br.ReadBytes(fs.Length) 'counting the file length into bytes 
        FileUpload1.SaveAs(Server.MapPath("~/FUpload/projInfo" + Session.SessionID + pat))
        If pat = "" Then
            bl.insSubConInfoNOFile(txtSubCon_Name.Text,
                         txtSubCon_PhoneNo.Text, txtSubCon_P_Address.Text,
                          txtSubCon_RP_No.Text, txtcom_address.Text,
                          Convert.ToInt32(DDLItem.SelectedItem.Text))
            Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
            '            txtSubCon_Name.Text = ""
            txtSubCon_PhoneNo.Text = ""
            txtSubCon_P_Address.Text = ""
            txtSubCon_RP_No.Text = ""
            txtcom_address.Text = ""
            DDLItem.SelectedIndex = -1
            txtSubCon_Name.Focus()
        Else
            bl.insSubConInfo(txtSubCon_Name.Text,
                         txtSubCon_PhoneNo.Text, txtSubCon_P_Address.Text,
                          txtSubCon_RP_No.Text, txtcom_address.Text,
                           pat, Convert.ToInt32(DDLItem.SelectedItem.Text))
            Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
            txtSubCon_Name.Text = ""
            txtSubCon_PhoneNo.Text = ""
            txtSubCon_P_Address.Text = ""
            txtSubCon_RP_No.Text = ""
            txtcom_address.Text = ""
            DDLItem.SelectedIndex = -1
            txtSubCon_Name.Focus()
        End If
    End Sub
End Class