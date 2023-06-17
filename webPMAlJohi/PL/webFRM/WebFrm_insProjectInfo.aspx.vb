Imports System.IO


Public Class WebFrm_insProjectInfo
    Inherits System.Web.UI.Page
    Private strCon As String = "Data Source=.;Integrated Security=true;Initial Catalog=PMSoftware"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtP_Name.Focus()
            Calendar_E_Date.Visible = False
            Calendar_S_Date.Visible = False
        End If
    End Sub


    Dim bl As New Clr_projcInfo
    Protected Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

        Dim filename As String = (FileUpload1.FileName)
        Dim pat As String = path.GetFileName(filename)
        Dim fs As Stream = FileUpload1.PostedFile.InputStream
        Dim br As BinaryReader = New BinaryReader(fs) 'reads the binary files  
        Dim bytes() As Byte = br.ReadBytes(fs.Length) 'counting the file length into bytes 
        FileUpload1.SaveAs(Server.MapPath("~/FUpload/projInfo/" + Session.SessionID + pat))
        If pat = "" Then
            bl.ProjectInfNoImage(txtS_Date.Text,
                         txtE_Date.Text, Convert.ToInt32(txt_P_Period.Text),
                          txtP_Name.Text, txtP_M_Name.Text,
                          txtP_M_Phone.Text)
            'Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
            Label1.Text = "تم الاضافة بنجاح"
            Label1.BackColor = System.Drawing.Color.Purple
            Label1.ForeColor = System.Drawing.Color.White
            txtP_Name.Text = ""
            txtP_M_Name.Text = ""
            txtP_M_Phone.Text = ""
            txtE_Date.Text = ""
            txtS_Date.Text = ""
            txt_P_Period.Text = ""
            txtP_Name.Focus()
        Else
            bl.ProjectInf(txtS_Date.Text,
                         txtE_Date.Text, Convert.ToInt32(txt_P_Period.Text),
                          txtP_Name.Text, txtP_M_Name.Text,
                          txtP_M_Phone.Text, pat)
            'Response.Write("<script type=""text/javascript"">alert(""تم الاضافة بنجاح"");</script")
            Label1.Text = "تم الاضافة بنجاح"
            Label1.BackColor = System.Drawing.Color.Purple
            Label1.ForeColor = System.Drawing.Color.White
            txtP_Name.Text = ""
            txtP_M_Name.Text = ""
            txtP_M_Phone.Text = ""
            txtE_Date.Text = ""
            txtS_Date.Text = ""
            txt_P_Period.Text = ""
            txtP_Name.Focus()
        End If
    End Sub
    'Public Sub txtP_no_TextChanged(sender As Object, e As EventArgs) Handles txtP_no.TextChanged
    '    If txtP_no.Text = "" Then
    '        txtP_no.Focus()
    '    Else
    '    End If
    'End Sub
    Public Sub txtP_Name_TextChanged(sender As Object, e As EventArgs) Handles txtP_Name.TextChanged
        If txtP_Name IsNot Nothing Then
            txtP_M_Name.Focus()
        Else
            txtP_Name.Focus()
        End If
    End Sub
    Protected Sub txtP_M_Name_TextChanged(sender As Object, e As EventArgs) Handles txtP_M_Name.TextChanged
        If txtP_M_Name IsNot Nothing Then
            txtP_M_Phone.Focus()
        Else
            txtP_M_Name.Focus()
        End If
    End Sub
    Protected Sub txtP_M_Phone_TextChanged(sender As Object, e As EventArgs) Handles txtP_M_Phone.TextChanged
        If txtP_M_Phone IsNot Nothing Then
            'Threading.Thread.Sleep(500000)
        Else
            txtP_M_Phone.Focus()
        End If
    End Sub
    Protected Sub txtE_Date_TextChanged(sender As Object, e As EventArgs) Handles txtE_Date.TextChanged
        If txtE_Date IsNot Nothing Then
            ImageButton2.Focus()
        Else
            txtE_Date.Focus()
        End If
    End Sub
    Protected Sub txtS_Date_TextChanged(sender As Object, e As EventArgs) Handles txtS_Date.TextChanged
        If txtS_Date IsNot Nothing Then
            txt_P_Period.Focus()
        Else
            txtS_Date.Focus()
        End If
    End Sub
    Protected Sub txt_P_Period_TextChanged(sender As Object, e As EventArgs) Handles txt_P_Period.TextChanged
        If txt_P_Period IsNot Nothing Then
            FileUpload1.Focus()
        Else
            txt_P_Period.Focus()
        End If

    End Sub
    Protected Sub Calendar_S_Date_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar_S_Date.SelectionChanged
        txtS_Date.Text = Calendar_S_Date.SelectedDate.ToString("d")
        Calendar_S_Date.Visible = False
    End Sub
    Protected Sub Calendar_E_Date_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar_E_Date.SelectionChanged
        txtE_Date.Text = Calendar_E_Date.SelectedDate.ToString("d")
        Calendar_E_Date.Visible = False
    End Sub
    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Calendar_E_Date.Visible = True
    End Sub
    Protected Sub ImageButton2_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton2.Click
        Calendar_S_Date.Visible = True
    End Sub
End Class