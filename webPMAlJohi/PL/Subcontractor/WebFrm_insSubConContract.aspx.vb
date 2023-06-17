Imports System.IO
Imports System.Configuration
Public Class WebFrm_insSubConContract
    Inherits System.Web.UI.Page
    Dim bl As New Clr_SubConInfo
    Dim bl1 As New Clr_projcInfo
    Dim bl2 As New Clr_POINFO
    Dim bl3 As New Clr_SubConContract
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not IsPostBack Then
        '    DDLOPPInfoNo.DataSource = bl1.Get_tblProject_no()
        '    DDLOPPInfoNo.DataTextField = "Project_no"
        '    DDLOPPInfoNo.DataBind()
        '    Dim li1 As ListItem = New ListItem("اختار رقم المشروع", "-1")
        '    DDLOPPInfoNo.Items.Insert(0, li1)
        '    DDLPONO.Enabled = False
        '    Dim li As ListItem = New ListItem("اختار رقم التعميد", "-1")
        '    DDLPONO.Items.Insert(0, li)
        '    DDLSubCon_No.Enabled = False
        '    Dim li2 As ListItem = New ListItem("اختار رقم مقاول الباطن", "-1")
        '    DDLSubCon_No.Items.Insert(0, li2)
        '    DDLOPPInfoNo.Focus()
        'End If
    End Sub
    Protected Sub DDLOPPInfoNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDLOPPInfoNo.SelectedIndexChanged
        If DDLOPPInfoNo.SelectedIndex <> 0 Then
            DDLPONO.Enabled = True
            DDLPONO.DataSource = bl2.Get_POAndProjInfo_No(Convert.ToInt32(DDLOPPInfoNo.SelectedItem.Text))
            DDLPONO.DataTextField = "PO_no"
            DDLPONO.DataBind()
            Dim li As ListItem = New ListItem("اختار رقم التعميد", "-1")
            DDLPONO.Items.Insert(0, li)
        Else
            Dim li As ListItem = New ListItem("اختار رقم التعميد", "-1")
            DDLPONO.Items.Insert(0, li)
            DDLPONO.Enabled = False
            Dim li2 As ListItem = New ListItem("اختار رقم مقاول الباطن", "-1")
            DDLSubCon_No.Items.Insert(0, li2)
            DDLSubCon_No.Enabled = False
        End If

    End Sub
    Protected Sub DDLPONO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDLPONO.SelectedIndexChanged
        If DDLPONO.SelectedIndex <> 0 Then
            DDLSubCon_No.Enabled = True
            DDLSubCon_No.DataSource = bl.Get_SubConAndPO_No(Convert.ToInt32(DDLPONO.SelectedItem.Text))
            DDLSubCon_No.DataTextField = "SubContractor_No"
            DDLSubCon_No.DataBind()
            Dim li2 As ListItem = New ListItem("اختار رقم مقاول الباطن", "-1")
            DDLSubCon_No.Items.Insert(0, li2)
        Else
            Dim li2 As ListItem = New ListItem("اختار رقم مقاول الباطن", "-1")
            DDLSubCon_No.Items.Insert(0, li2)
            DDLSubCon_No.Enabled = False
        End If

    End Sub
    Protected Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim filename As String = (FileUpload1.FileName)
        Dim pat As String = Path.GetFileName(filename)
        Dim fs As Stream = FileUpload1.PostedFile.InputStream
        Dim br As BinaryReader = New BinaryReader(fs) 'reads the binary files  
        Dim bytes() As Byte = br.ReadBytes(fs.Length) 'counting the file length into bytes 
        FileUpload1.SaveAs(Server.MapPath("~/FUpload/projInfo" + Session.SessionID + pat))
        If pat = "" Then
            bl3.insSubConContract_WNoImage(Int32.Parse(txtsubconC_no.Text), txtDate.Text,
            txtS_Date.Text, txtE_Date.Text,
            Convert.ToDouble(txtSubCon_Value.Text),
           Convert.ToInt32(DDLSubCon_No.SelectedValue),
           Convert.ToInt32(DDLPONO.SelectedItem.Text),
           Convert.ToInt32(DDLOPPInfoNo.SelectedValue))
            Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
            txtsubconC_no.Text = ""
            txtDate.Text = ""
            txtS_Date.Text = ""
            txtE_Date.Text = ""
            txtSubCon_Value.Text = ""
            DDLSubCon_No.SelectedIndex = -1
            DDLPONO.SelectedIndex = -1
            DDLOPPInfoNo.SelectedIndex = -1
            DDLPONO.Enabled = False
            DDLSubCon_No.Enabled = False
            DDLOPPInfoNo.Focus()
        Else
            bl3.insSubConContract(Int32.Parse(txtsubconC_no.Text), txtDate.Text,
            txtS_Date.Text, txtE_Date.Text,
            Convert.ToDouble(txtSubCon_Value.Text),
           Convert.ToInt32(DDLSubCon_No.SelectedItem.Text),
           Convert.ToInt32(DDLPONO.SelectedValue),
           Convert.ToInt32(DDLOPPInfoNo.SelectedItem.Text), pat, bytes)
            Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
            txtsubconC_no.Text = ""
            txtDate.Text = ""
            txtS_Date.Text = ""
            txtE_Date.Text = ""
            txtSubCon_Value.Text = ""
            DDLSubCon_No.SelectedIndex = -1
            DDLPONO.SelectedIndex = -1
            DDLPONO.Enabled = False
            DDLSubCon_No.Enabled = False
            DDLOPPInfoNo.SelectedIndex = -1
            DDLOPPInfoNo.Focus()
        End If
    End Sub
    Protected Sub ImageButton3_Click(sender As Object, e As ImageClickEventArgs) Handles Imagebut1.Click
        Calendar_Date.Visible = True
    End Sub

    Protected Sub Calendar_Date_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar_Date.SelectionChanged
        txtDate.Text = Calendar_Date.SelectedDate.Date.ToString("d")
        Calendar_Date.Visible = False
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageBut2.Click
        Calendar_S_Date.Visible = True
    End Sub

    Protected Sub Calendar_S_Date_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar_S_Date.SelectionChanged
        txtS_Date.Text = Calendar_S_Date.SelectedDate.Date.ToString("d")
        Calendar_S_Date.Visible = False
    End Sub

    Protected Sub ImageButton2_Click(sender As Object, e As ImageClickEventArgs) Handles ImageBut3.Click
        Calendar_E_Date.Visible = True
    End Sub

    Protected Sub Calendar_E_Date_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar_E_Date.SelectionChanged
        txtE_Date.Text = Calendar_E_Date.SelectedDate.Date.ToString("d")
        Calendar_E_Date.Visible = False
    End Sub


End Class