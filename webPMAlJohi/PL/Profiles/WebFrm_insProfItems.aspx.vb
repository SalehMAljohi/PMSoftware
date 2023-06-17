Public Class WebFrm_insProfItems
    Inherits System.Web.UI.Page
    Dim bl As New Clr_Items
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not IsPostBack Then
        '    DDLProfItemsNo.DataSource = bl.Get_Item_no()
        '    DDLProfItemsNo.DataTextField = "Item_no"
        '    DDLProfItemsNo.DataBind()
        '    Dim li1 As ListItem = New ListItem("اختار رقم البند الرئيسي", "-1")
        '    DDLProfItemsNo.Items.Insert(0, li1)
        'End If
    End Sub

    Protected Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim MITotalAmout As Double
        MITotalAmout = Convert.ToDouble(txtMPPrice.Text) * Convert.ToDouble(txtQty.Text)
        bl.insTbl_MItem_Profile(Convert.ToInt32(txtMProItem_no.Text),
                                Convert.ToDouble(txtMPPrice.Text),
                                Convert.ToInt32(txtQty.Text), MITotalAmout,
                                Convert.ToInt32(DDLProfItemsNo.SelectedItem.Text))
        Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
        DDLProfItemsNo.SelectedIndex = -1
        txtMProItem_no.Text = ""
        txtMPPrice.Text = ""
        txtQty.Text = ""
        DDLProfItemsNo.Focus()
    End Sub
End Class