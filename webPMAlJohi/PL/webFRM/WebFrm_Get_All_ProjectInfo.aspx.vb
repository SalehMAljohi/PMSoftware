Imports System.Windows
Imports System.Data.SqlClient
Imports System.Data
Public Class WebFrm_Get_All_ProjectInfo
    Inherits System.Web.UI.Page
    Dim bl As New Clr_projcInfo
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not IsPostBack Or txtPInfoSearch.Text <> "" Then
        '    txtPInfoSearch.Focus()
        '    GrdVGAProjectInfo.DataSource = bl.Get_All_ProjectInfo()
        '    GrdVGAProjectInfo.DataBind()
        '    Calendar_S_Date.Visible = False
        '    Calendar_E_Date.Visible = False
        'End If
    End Sub

    Protected Sub txtPInfoSearch_TextChanged(sender As Object, e As EventArgs) Handles txtPInfoSearch.TextChanged
        GrdVGAProjectInfo.DataSource = bl.searchProjectInfo(txtPInfoSearch.Text)
        GrdVGAProjectInfo.DataBind()
    End Sub
    Protected Sub btnins1_Click(sender As Object, e As EventArgs) Handles btnins1.Click
        Response.Redirect("../webFRM/WebFrm_insProjectInfo.aspx")
    End Sub

    Protected Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Response.Redirect("../webFRM/WebFRM_TEST.aspx")
    End Sub
    Protected Sub btnupdatePInfo_Click(sender As Object, e As EventArgs) Handles btnupdatePInfo.Click
        If Panel1.Visible = True Then
            bl.updateProjectInfo(Convert.ToInt32(txtP_no.Text), Calendar_S_Date.SelectedDate.Date,
                        Calendar_E_Date.SelectedDate.Date, Convert.ToInt32(txt_P_Period.Text),
                         txtP_Name.Text, txtP_M_Name.Text)
            Response.Write("<script type=""text/javascript"">alert(""تم التعديل بنجاح"");</script")
            txtP_no.Text = ""
            txtP_Name.Text = ""
            txtP_M_Name.Text = ""
            txt_P_Period.Text = ""
            Panel1.Visible = False
            txtPInfoSearch.Focus()
            GrdVGAProjectInfo.DataSource = bl.Get_All_ProjectInfo()
            GrdVGAProjectInfo.DataBind()
        Else
            Response.Write("<script type=""text/javascript"">alert(""رجاء حدد المشروع المراد تعديله"");</script")
        End If

    End Sub

    Protected Sub GrdVGAProjectInfo_SelectedIndexChanged1(sender As Object, e As EventArgs) Handles GrdVGAProjectInfo.SelectedIndexChanged
        txtP_Name.Focus()
        Panel1.Visible = True
        txtP_no.Text = GrdVGAProjectInfo.SelectedRow.Cells(1).Text
        txtPNo.Text = GrdVGAProjectInfo.SelectedRow.Cells(1).Text 'for delete
        ' Calendar_S_Date.SelectedDate = Convert.ToDateTime(GrdVGAProjectInfo.SelectedRow.Cells(1))
        ' Calendar_E_Date.SelectedDate = Convert.ToDateTime(GrdVGAProjectInfo.SelectedRow.Cells(2))
        txtP_Name.Text = GrdVGAProjectInfo.SelectedRow.Cells(5).Text
        txtP_M_Name.Text = GrdVGAProjectInfo.SelectedRow.Cells(6).Text
        txt_P_Period.Text = GrdVGAProjectInfo.SelectedRow.Cells(4).Text
    End Sub

    Protected Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        bl.updateProjectInfo(Convert.ToInt32(txtP_no.Text), Calendar_S_Date.SelectedDate.Date,
                       Calendar_E_Date.SelectedDate.Date, Convert.ToInt32(txt_P_Period.Text),
                        txtP_Name.Text, txtP_M_Name.Text)
        Response.Write("<script type=""text/javascript"">alert(""تم التعديل بنجاح"");</script")
        txtP_no.Text = ""
        txtP_Name.Text = ""
        txtP_M_Name.Text = ""
        txt_P_Period.Text = ""
        Panel1.Visible = False
        txtPInfoSearch.Focus()
        GrdVGAProjectInfo.DataSource = bl.Get_All_ProjectInfo()
        GrdVGAProjectInfo.DataBind()
    End Sub

    Protected Sub btndeletePInfo_Click(sender As Object, e As EventArgs) Handles btndeletePInfo.Click
        If txtPNo.Text <> "" Then
            bl.deleteProjectInfo(Convert.ToInt32(txtPNo.Text))
            txtPInfoSearch.Focus()
            GrdVGAProjectInfo.DataSource = bl.Get_All_ProjectInfo()
            GrdVGAProjectInfo.DataBind()
            txtPNo.Text = ""
            Panel1.Visible = False
        Else
            Response.Write("<script type=""text/javascript"">alert(""رجاء ادخل حدد المشروع الذي تريد مسحه"");</script")
            Response.Redirect("../webFRM/WebFrm_Get_All_ProjectInfo.aspx")

        End If

    End Sub
    Protected Sub lnkDownload_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim ld As Integer = Convert.ToInt32(GrdVGAProjectInfo.SelectedRow.Cells(0).Text)
        'Dim dt As New DataTable
        'dt = bl.Get_SFileN_ProjectInfo(ID)
        'Dim name As String
        'Dim str As String = dt.Select("FileD").ToString
        'Dim Bytes() As Byte = System.Text.Encoding.ASCII.GetBytes(str)
        '        Dim lnkbtn As LinkButton = BYVAL sender AS LinkButton
        '        Dim gvrow As GridViewRow = (BYVAL lnkbtn.NamingContainer AS GridViewRow)
        'Dim fileid As Integer = Convert.ToInt32(GrdVGAProjectInfo.DataKeys(gvrow.RowIndex).Value.ToString())
        '        String name, Type;


    End Sub

    Protected Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Response.Redirect("../webFRM/WebFRM_TEST.aspx")

    End Sub

    Protected Sub txtP_Name_TextChanged(sender As Object, e As EventArgs) Handles txtP_Name.TextChanged
        txtP_M_Name.Focus()
    End Sub

    Protected Sub txtP_M_Name_TextChanged(sender As Object, e As EventArgs) Handles txtP_M_Name.TextChanged
        txtPNo.Focus()
    End Sub

    Protected Sub Calendar_S_Date_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar_S_Date.SelectionChanged
        Calendar_E_Date.Focus()
        Calendar_S_Date.Visible = False
    End Sub

    Protected Sub Calendar_E_Date_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar_E_Date.SelectionChanged
        txt_P_Period.Focus()
        Calendar_E_Date.Visible = False
    End Sub

    Protected Sub txt_P_Period_TextChanged(sender As Object, e As EventArgs) Handles txt_P_Period.TextChanged
        btnupdatePInfo.Focus()
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Calendar_S_Date.Visible = True
    End Sub

    Protected Sub ImageButton2_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton2.Click
        Calendar_E_Date.Visible = True
    End Sub

    Protected Sub txtS_Date_TextChanged(sender As Object, e As EventArgs) Handles txtS_Date.TextChanged
        txtE_Date.Focus()

    End Sub

    Protected Sub txtP_no_TextChanged(sender As Object, e As EventArgs) Handles txtP_no.TextChanged
        txtP_M_Name.Focus()
    End Sub
End Class