Public Class WebFrm_AddCatagories
    Inherits System.Web.UI.Page
    Dim bl As New Clr_Catagories
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If txtCat_Desc.Text <> "" And txtCat_Name.Text <> "" Then
            bl.insCatagoriesInfo(Convert.ToInt32(txtCat_Desc.Text), txtCat_Name.Text)
            Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
            txtCat_Desc.Text = ""
            txtCat_Name.Text = ""
            txtCat_Desc.Focus()
        Else
            Response.Write("<script type=""text/javascript"">alert(""رجاء ادخل المعلومات الصحيحة!"");</script")
            txtCat_Desc.Focus()
        End If

    End Sub

    Protected Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Response.Redirect("../webFRM/WebFRM_TEST.aspx")
    End Sub
End Class