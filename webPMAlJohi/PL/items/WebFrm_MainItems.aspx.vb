Public Class WebFrm_MainItems
    Inherits System.Web.UI.Page
    Dim bl As New Clr_Items
    Dim bl1 As New Clr_POINFO
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            '        DDLPONO.DataSource = bl1.Get_POInfo_NO()
            '        DDLPONO.DataTextField = "PO_no"
            '        DDLPONO.DataBind()
            '        Dim li1 As ListItem = New ListItem("اختار رقم التعميد", "-1")
            '        DDLPONO.Items.Insert(0, li1)
            txtitem_STCNo.Focus()
        End If
        'End Sub

        'Protected Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        '    bl.insItemsInfo(Convert.ToInt32(txtItem_NO.Text), txtitem_STCNo.Text,
        '                    txtItem_Descr.Text, txtUnit.Text,
        '                    Convert.ToDouble(txtI_UPrice.Text),
        '                    Convert.ToInt32(DDLPONO.SelectedItem.Selected))
        '    Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
        '    txtItem_NO.Text = ""
        '    txtitem_STCNo.Text = ""
        '    txtItem_Descr.Text = ""
        '    txtUnit.Text = ""
        '    txtI_UPrice.Text = ""
        '    DDLPONO.SelectedIndex = -1
        '    DDLPONO.Focus()
    End Sub


End Class