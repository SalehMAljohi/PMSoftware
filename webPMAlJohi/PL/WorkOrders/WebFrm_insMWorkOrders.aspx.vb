Public Class WebFrm_insMWorkOrders
    Inherits System.Web.UI.Page
    Dim bl As New Clr_POINFO
    Dim bl1 As New Clr_Profile
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            DDLPONO.DataSource = bl.Get_POInfo_No()
            DDLPONO.DataTextField = "PO_no"
            DDLPONO.DataBind()
            Dim li1 As ListItem = New ListItem("اختار رقم التعميد", "-1")
            DDLPONO.Items.Insert(0, li1)
        End If
    End Sub

    Protected Sub ImageBut2_Click(sender As Object, e As ImageClickEventArgs) Handles ImageBut2.Click
        Calendar_S_Date.Visible = True
    End Sub

    Protected Sub Calendar_E_Date_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar_E_Date.SelectionChanged
        txtE_Date.Text = Calendar_E_Date.SelectedDate.ToString("d")
        Calendar_E_Date.Visible = False
    End Sub

    Protected Sub ImageBut3_Click(sender As Object, e As ImageClickEventArgs) Handles ImageBut3.Click
        Calendar_E_Date.Visible = True
    End Sub

    Protected Sub Calendar_S_Date_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar_S_Date.SelectionChanged
        txtS_Date.Text = Calendar_S_Date.SelectedDate.ToString("d")
        Calendar_S_Date.Visible = False
    End Sub
End Class