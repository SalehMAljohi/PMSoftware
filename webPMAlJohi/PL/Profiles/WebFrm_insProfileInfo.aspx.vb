Public Class WebFrm_insProfileInfo
    Inherits System.Web.UI.Page
    Dim bl As New Clr_Profile
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtProf_NO.Focus()
        End If
    End Sub

    Protected Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If txtProf_NO.Text <> "" And txtProf_Des.Text <> "" Then
            ' bl.insProfileInfo(Convert.ToInt32(txtProf_NO.Text), txtProf_Des.Text)
            Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
            txtProf_NO.Text = ""
            txtProf_Des.Text = ""
            txtProf_NO.Focus()
        Else
            Response.Write("<script type=""text/javascript"">alert(""رجاء ادخل المعلومات الصحيحة!"");</script")
            txtProf_NO.Focus()
        End If
    End Sub



    Protected Sub txtProf_NO_TextChanged(sender As Object, e As EventArgs) Handles txtProf_NO.TextChanged
        txtProf_Des.Focus()
    End Sub

    Protected Sub txtProf_Des_TextChanged(sender As Object, e As EventArgs) Handles txtProf_Des.TextChanged
        ' txtProf_Notes.Focus()
    End Sub
    Protected Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Response.Redirect("../webFRM/WebFRM_TEST.aspx")
    End Sub
End Class