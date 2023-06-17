Public Class WebFrm_SubItems
    Inherits System.Web.UI.Page
    Dim bl1 As New Clr_SubConInfo
    Dim bl As New Clr_SubItemsInfo

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not IsPostBack Then
        '    txtSubItem_NO.Focus()
        '    DDLSubCon.DataSource = bl1.Get_SubContractor_No()
        '    DDLSubCon.DataTextField = "SubContractor_No"
        '    DDLSubCon.DataBind()
        '    Dim li1 As ListItem = New ListItem("اختار رقم مقاول الباطن", "-1")
        '    DDLSubCon.Items.Insert(0, li1)
        'End If
        ' Dim marks() As Integer

    End Sub

    Protected Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        bl.insSubItemInfo(Convert.ToInt32(txtSubItem_NO.Text), txtSubItem_Descr.Text,
                      txtSubItemUnit.Text, Convert.ToDouble(txtSubI_UPrice.Text),
                          Convert.ToInt32(DDLSubCon.SelectedItem.Text))
        Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
        txtSubItem_NO.Text = ""
        txtSubItem_Descr.Text = ""
        txtSubItemUnit.Text = ""
        txtSubI_UPrice.Text = ""
        DDLSubCon.SelectedIndex = -1
        txtSubItem_NO.Focus()
    End Sub
End Class