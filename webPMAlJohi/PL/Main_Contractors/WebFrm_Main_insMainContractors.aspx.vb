Imports System.IO
Public Class WebFrm_Main_insMainContractors
    Inherits System.Web.UI.Page
    Dim bl As New Clr_Main_contractors
    Dim bl1 As New Clr_projcInfo
    Dim bl2 As New Clr_Company
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            DDLPInfoNo.DataSource = bl1.Get_Projectname()
            DDLPInfoNo.DataTextField = "Project_name"
            DDLPInfoNo.DataBind()
            Dim li1 As ListItem = New ListItem("اختار اسم المشروع", "-1")
            DDLPInfoNo.Items.Insert(0, li1)
            DDLComNo.DataSource = bl2.Get_Companyname()
            DDLComNo.DataTextField = "company_name"
            DDLComNo.DataBind()
            Dim li As ListItem = New ListItem("اختار اسم المؤسسة", "-1")
            DDLComNo.Items.Insert(0, li)
            DDLPInfoNo.Focus()
        End If
    End Sub

    Protected Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim filename As String = (FileUpload1.FileName)
        Dim pat As String = path.GetFileName(filename)
        Dim fs As Stream = FileUpload1.PostedFile.InputStream
        Dim br As BinaryReader = New BinaryReader(fs) 'reads the binary files  
        Dim bytes() As Byte = br.ReadBytes(fs.Length) 'counting the file length into bytes 
        FileUpload1.SaveAs(Server.MapPath("~/FUpload/projInfo" + Session.SessionID + pat))
        Dim dt As New DataTable
        Dim dt1 As New DataTable
        Dim company_no As Integer
        Dim Project_no As Integer
        If DDLComNo.SelectedValue <> "0" & DDLPInfoNo.SelectedValue <> "0" Then
            dt = bl2.Get_companyInfNo(DDLComNo.SelectedItem.Text)
            dt1 = bl1.Get_ProjectInfNo(DDLPInfoNo.SelectedItem.Text)
            company_no = Convert.ToInt32(dt.Rows(0)(0))
            Project_no = Convert.ToInt64(dt1.Rows(0)(0))
            If pat = "" Then
                bl.Main_contractorNoImage(txtMCon_Name.Text,
                             txtMCon_Address.Text, txtMCon_Mobile.Text, txtMCon_RP.Text,
                             Project_no, company_no)
                Label1.Text = "تم الاضافة بنجاح"
                Label1.BackColor = System.Drawing.Color.Purple
                Label1.ForeColor = System.Drawing.Color.White
                ' Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
                txtMCon_Name.Text = ""
                txtMCon_Address.Text = ""
                txtMCon_Mobile.Text = ""
                txtMCon_RP.Text = ""
                DDLPInfoNo.SelectedIndex = -1
                DDLComNo.SelectedIndex = -1
                DDLPInfoNo.Focus()
            Else
                bl.Main_contractor(txtMCon_Name.Text,
                             txtMCon_Address.Text, txtMCon_Mobile.Text, pat, txtMCon_RP.Text,
                              DDLPInfoNo.SelectedItem.Text, DDLComNo.SelectedItem.Text)
                Label1.Text = "تم الاضافة بنجاح"
                Label1.BackColor = System.Drawing.Color.Purple
                Label1.ForeColor = System.Drawing.Color.White
                'Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
                txtMCon_Name.Text = ""
                txtMCon_Address.Text = ""
                txtMCon_Mobile.Text = ""
                txtMCon_RP.Text = ""
                DDLPInfoNo.SelectedIndex = -1
                DDLComNo.SelectedIndex = -1
                DDLPInfoNo.Focus()
            End If
        Else
            DDLComNo.Focus()
        End If



    End Sub

    Protected Sub DDLPInfoNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDLPInfoNo.SelectedIndexChanged
        DDLComNo.Focus()
    End Sub

    Protected Sub DDLComNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDLComNo.SelectedIndexChanged
        txtMCon_Name.Focus()
    End Sub



    Protected Sub txtMCon_Name_TextChanged(sender As Object, e As EventArgs) Handles txtMCon_Name.TextChanged
        txtMCon_Address.Focus()
    End Sub

    Protected Sub txtMCon_Address_TextChanged(sender As Object, e As EventArgs) Handles txtMCon_Address.TextChanged
        txtMCon_Mobile.Focus()
    End Sub

    Protected Sub txtMCon_Mobile_TextChanged(sender As Object, e As EventArgs) Handles txtMCon_Mobile.TextChanged
        txtMCon_RP.Focus()
    End Sub

    Protected Sub txtMCon_RP_TextChanged(sender As Object, e As EventArgs) Handles txtMCon_RP.TextChanged
        FileUpload1.Focus()
    End Sub

    Protected Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Response.Redirect("../webFRM/WebFRM_TEST.aspx")
    End Sub
End Class