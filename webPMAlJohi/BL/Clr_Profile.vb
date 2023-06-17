Imports System.Data.SqlClient
Public Class Clr_Profile
    Dim dal As New DataAccessLayer()
    Public Function Get_MItem_Profile_no() As DataTable
        dal.Open()
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_MItem_Profile_no", Nothing)
        dal.Close()
        Return dt
    End Function

    Public Sub insProfileInfo(ByVal Profile_No As Integer,
                                 ByVal Profile_Desc As String,
                                 ByVal Profile_Notes As String)


        dal.Open()

        Dim parm(2) As SqlParameter
        parm(0) = New SqlParameter("@Profile_No", SqlDbType.Int)
        parm(0).Value = Profile_No
        parm(1) = New SqlParameter("@Profile_Desc", SqlDbType.NVarChar, 50)
        parm(1).Value = Profile_Desc
        parm(2) = New SqlParameter("@Profile_Notes", SqlDbType.NVarChar, 50)
        parm(2).Value = Profile_Notes
        dal.executedata("sp_insProfileInfo", parm)
        dal.Close()
    End Sub
    Public Sub UpdateCatagoriesInfo(ByVal cat_id As Integer, ByVal cat_desc As Integer, ByVal cat_Name As String)


        dal.Open()

        Dim parm(2) As SqlParameter
        parm(0) = New SqlParameter("@cat_id", SqlDbType.Int)
        parm(0).Value = cat_id
        parm(1) = New SqlParameter("@cat_desc", SqlDbType.Int)
        parm(1).Value = cat_desc
        parm(2) = New SqlParameter("@cat_Name", SqlDbType.NVarChar, 50)
        parm(2).Value = cat_Name
        dal.executedata("sp_UpdateCatagoriesInfo", parm)
        dal.Close()
    End Sub
End Class
