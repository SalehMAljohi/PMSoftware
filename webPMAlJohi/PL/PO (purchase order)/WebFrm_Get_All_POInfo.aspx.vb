Public Class WebFrm_Get_All_POInfo
    Inherits System.Web.UI.Page
    Dim bl As New Clr_LetterOfIntend
    Dim bl1 As New Clr_projcInfo
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not IsPostBack Or txtPInfoSearch.Text <> "" Then
        '    txtPInfoSearch.Focus()
        '    GrdVGAPOInfo.DataSource = bl.Get_All_LetterOfIntend()
        '    GrdVGAPOInfo.DataBind()
        '    '   DDLOPPInfoNo.DataSource = bl1.Get_Project_no()
        '    DDLOPPInfoNo.DataTextField = "Project_no"
        '    DDLOPPInfoNo.DataBind()
        '    Dim li As ListItem = New ListItem("اختار رقم المشروع", "-1")
        '    DDLOPPInfoNo.Items.Insert(0, li)
        '    Dim li1 As ListItem = New ListItem("اختار رقم التعميد", "-1")
        '    DDLPONO.Items.Insert(0, li1)
        '    DDLPONO.Enabled = False
        'End If
    End Sub
    Protected Sub OnRowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs) Handles GrdVGAPOInfo.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim dr As DataRowView = CType(e.Row.DataItem, DataRowView)
            Dim byt() As Byte = (CType(dr("LetterOfIntend_Picture"), Byte()))
            Dim base64s As String = Convert.ToBase64String(byt)
            Dim imageUrl As String = "data:image/ico;base64," + base64s
            '   Dim imageUrl As String = "data:image/ico;base64," & Convert.ToBase64String(CType(dr("Data"), Byte()))
            CType(e.Row.FindControl("Image1"), Image).ImageUrl = imageUrl
        End If
    End Sub

    Protected Sub DDLOPPInfoNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDLOPPInfoNo.SelectedIndexChanged
        If DDLOPPInfoNo.SelectedValue = True And DDLOPPInfoNo.SelectedValue <> "-1" Then
            If txtPInfoSearch.Text = "" Then
                DDLPONO.Enabled = True
                DDLPONO.DataSource = bl.Get_Single_LetterOfIntend_ProjNo(Convert.ToInt32(DDLOPPInfoNo.SelectedValue))
                DDLPONO.DataTextField = "LetterOfIntend_No"
                DDLPONO.DataBind()
                Dim li1 As ListItem = New ListItem("اختار رقم التعميد", "-1")
                DDLPONO.Items.Insert(0, li1)
                GrdVGAPOInfo.DataSource = bl.All_LetterOfIntendOfSProject(Convert.ToInt32(DDLOPPInfoNo.SelectedValue))
                GrdVGAPOInfo.DataBind()
            Else
                Dim li As ListItem = New ListItem("اختار رقم المشروع", "-1")
                DDLOPPInfoNo.Items.Insert(0, li)
                Dim li1 As ListItem = New ListItem("اختار رقم التعميد", "-1")
                DDLPONO.Items.Insert(0, li1)
                DDLPONO.Enabled = False
                GrdVGAPOInfo.DataSource = bl.Get_All_LetterOfIntend()
                GrdVGAPOInfo.DataBind()
            End If

        ElseIf DDLOPPInfoNo.SelectedIndex = -1 Then
            Dim li1 As ListItem = New ListItem("اختار رقم التعميد", "-1")
            DDLPONO.Items.Insert(0, li1)
            DDLPONO.Enabled = False
            GrdVGAPOInfo.DataSource = bl.Get_All_LetterOfIntend()
            GrdVGAPOInfo.DataBind()
        End If
    End Sub

    Protected Sub DDLPONO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDLPONO.SelectedIndexChanged
        If DDLPONO.SelectedValue = True And DDLPONO.SelectedIndex <> -1 Then
            'Dim li1 As ListItem = New ListItem("اختار رقم التعميد", "-1")
            'DDLPONO.Items.Insert(0, li1)
            GrdVGAPOInfo.DataSource = bl.Get_Single_LetterOfIntend(Convert.ToInt32(DDLPONO.SelectedValue))
            GrdVGAPOInfo.DataBind()
        End If
    End Sub

    Protected Sub txtPInfoSearch_TextChanged(sender As Object, e As EventArgs) Handles txtPInfoSearch.TextChanged
        If txtPInfoSearch.Text IsNot Nothing And DDLOPPInfoNo.SelectedIndex <> -1 Then
            Dim li As ListItem = New ListItem("اختار رقم المشروع", "-1")
            DDLOPPInfoNo.Items.Insert(0, li)
            Dim li1 As ListItem = New ListItem("اختار رقم التعميد", "-1")
            DDLPONO.Items.Insert(0, li1)
            GrdVGAPOInfo.DataSource = bl.Search_LetterOfIntend(txtPInfoSearch.Text)
            GrdVGAPOInfo.DataBind()
            DDLPONO.Enabled = False
        Else
            DDLPONO.Enabled = True
            Dim li1 As ListItem = New ListItem("اختار رقم التعميد", "-1")
            DDLPONO.Items.Insert(0, li1)
            GrdVGAPOInfo.DataSource = bl.Search_LetterOfIntend(txtPInfoSearch.Text)
            GrdVGAPOInfo.DataBind()
            DDLPONO.Enabled = False
        End If

    End Sub

    Protected Sub GrdVGAPOInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GrdVGAPOInfo.SelectedIndexChanged

    End Sub
End Class