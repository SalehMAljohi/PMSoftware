Imports System.IO
Public Class WebFrm_insCompanyInfo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtCom_Name.Focus()
        End If
    End Sub
    Dim bl As New Clr_Company
    Protected Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim filename As String = (FileUpload1.FileName)
        Dim pat As String = path.GetFileName(filename)
        Dim fs As Stream = FileUpload1.PostedFile.InputStream
        Dim br As BinaryReader = New BinaryReader(fs) 'reads the binary files  
        Dim bytes() As Byte = br.ReadBytes(fs.Length) 'counting the file length into bytes 
        FileUpload1.SaveAs(Server.MapPath("~/FUpload/CompanyInfo/" + Session.SessionID + pat))
        If pat = "" Then
            bl.companyInfNoImage(txtCom_Name.Text,
                         txtCom_Address.Text)
            '  Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
            Label1.Text = "تم الاضافة بنجاح"
            Label1.BackColor = System.Drawing.Color.Purple
            Label1.ForeColor = System.Drawing.Color.White
            txtCom_Name.Text = ""
            txtCom_Address.Text = ""
            txtCom_Name.Focus()
        Else
            bl.companyInf(txtCom_Name.Text,
                         txtCom_Address.Text, pat)
            Label1.Text = "تم الاضافة بنجاح"
            Label1.BackColor = System.Drawing.Color.Purple
            Label1.ForeColor = System.Drawing.Color.White
            '  Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
            txtCom_Name.Text = ""
            txtCom_Address.Text = ""
            txtCom_Name.Focus()
        End If

    End Sub




    Protected Sub txtCom_Name_TextChanged(sender As Object, e As EventArgs) Handles txtCom_Name.TextChanged
        txtCom_Address.Focus()
    End Sub

    Protected Sub txtCom_Address_TextChanged(sender As Object, e As EventArgs) Handles txtCom_Address.TextChanged
        FileUpload1.Focus()
    End Sub


End Class