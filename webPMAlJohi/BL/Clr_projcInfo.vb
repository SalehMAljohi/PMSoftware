Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient

Public Class Clr_projcInfo

    Dim dal As New DataAccessLayer()
    'sp_Get_All_ProjectInfo
    Public Function Get_All_ProjectInfo() As DataTable
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_All_ProjectInfo", Nothing)
        dal.Close()
        Return dt
    End Function
    Public Function Get_SFileN_ProjectInfo(ByVal id As Integer) As DataTable
        Dim dt As New DataTable()
        Dim pram(0) As SqlParameter
        pram(0) = New SqlParameter("@id", SqlDbType.Int)
        pram(0).Value = id
        dt = dal.selectdata("sp_Get_SFileN_ProjectInfo", pram)
        dal.Close()
        Return dt
    End Function
    'sp_insProjectInfoNoUF
    Public Sub ProjectInfNoImage(ByVal Project_StartDate As String,
                           ByVal Project_Date As String, ByVal Project_Period As Integer,
                           ByVal Project_name As String, ByVal Project_ManagerName As String,
                              ByVal PManagerPHNo As String)


        dal.Open()

        Dim parm(5) As SqlParameter
        'parm(0) = New SqlParameter("@Project_no", SqlDbType.Int)
        'parm(0).Value = Project_no

        parm(0) = New SqlParameter("@Project_StartDate", SqlDbType.NVarChar, 50)
        parm(0).Value = Project_StartDate

        parm(1) = New SqlParameter("@Project_EndDate", SqlDbType.NVarChar, 50)
        parm(1).Value = Project_Date

        parm(2) = New SqlParameter("@Project_Period", SqlDbType.Int)
        parm(2).Value = Project_Period

        parm(3) = New SqlParameter("@Project_name", SqlDbType.NVarChar, 50)
        parm(3).Value = Project_name

        parm(4) = New SqlParameter("@Project_ManagerName", SqlDbType.NChar, 10)
        parm(4).Value = Project_ManagerName
        parm(5) = New SqlParameter("@PManagerPHNo", SqlDbType.NVarChar, 50)
        parm(5).Value = PManagerPHNo

        dal.executedata("ps_ProjectInfNoImage", parm)
        dal.Close()
    End Sub
    Public Sub ProjectInf(ByVal Project_StartDate As String,
                           ByVal Project_Date As String, ByVal Project_Period As Integer,
                           ByVal Project_name As String, ByVal Project_ManagerName As String,
                              ByVal PManagerPHNo As String, ByVal FileN As String
                              )


        dal.Open()

        Dim parm(6) As SqlParameter
        'parm(0) = New SqlParameter("@Project_no", SqlDbType.Int)
        'parm(0).Value = Project_no

        parm(0) = New SqlParameter("@Project_StartDate", SqlDbType.NVarChar, 50)
        parm(0).Value = Project_StartDate

        parm(1) = New SqlParameter("@Project_EndDate", SqlDbType.NVarChar, 50)
        parm(1).Value = Project_Date

        parm(2) = New SqlParameter("@Project_Period", SqlDbType.Int)
        parm(2).Value = Project_Period

        parm(3) = New SqlParameter("@Project_name", SqlDbType.NVarChar, 50)
        parm(3).Value = Project_name

        parm(4) = New SqlParameter("@Project_ManagerName", SqlDbType.NVarChar, 50)
        parm(4).Value = Project_ManagerName
        parm(5) = New SqlParameter("@PManagerPHNo", SqlDbType.NVarChar, 50)
        parm(5).Value = PManagerPHNo
        parm(6) = New SqlParameter("@FileN", SqlDbType.NVarChar, 50)
        parm(6).Value = FileN

        dal.executedata("ps_ProjectInf", parm)
        dal.Close()
    End Sub
    Public Function Get_ProjectInfNo(ByVal Project_name As String) As DataTable
        dal.Open()
        Dim dt As New DataTable()
        Dim parm(0) As SqlParameter
        parm(0) = New SqlParameter("@Project_name", SqlDbType.NVarChar, 50)
        parm(0).Value = Project_name
        dt = dal.selectdata("ps_Get_ProjectInfNo", parm)
        dal.Close()
        Return dt
    End Function

    Public Sub instblProjectInfo(ByVal Project_no As Integer, ByVal Project_StartDate As String,
                           ByVal Project_Date As String, ByVal Project_Period As Integer,
                           ByVal Project_name As String, ByVal Project_ManagerName As String,
                              ByVal PManagerPHNo As String, ByVal FileN As String)


        dal.Open()

        Dim parm(7) As SqlParameter
        parm(0) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(0).Value = Project_no

        parm(1) = New SqlParameter("@Project_StartDate", SqlDbType.NVarChar, 50)
        parm(1).Value = Project_StartDate

        parm(2) = New SqlParameter("@Project_EndDate", SqlDbType.NVarChar, 50)
        parm(2).Value = Project_Date

        parm(3) = New SqlParameter("@Project_Period", SqlDbType.Int)
        parm(3).Value = Project_Period

        parm(4) = New SqlParameter("@Project_name", SqlDbType.NVarChar, 50)
        parm(4).Value = Project_name

        parm(5) = New SqlParameter("@Project_ManagerName", SqlDbType.NChar, 10)
        parm(5).Value = Project_ManagerName
        parm(6) = New SqlParameter("@PManagerPHNo", SqlDbType.NVarChar, 50)
        parm(6).Value = PManagerPHNo
        parm(7) = New SqlParameter("@FileN", SqlDbType.NVarChar, 50)
        parm(7).Value = FileN


        dal.executedata("sp_insTBLProjectInfo", parm)
        dal.Close()
    End Sub
    Public Sub updateProjectInfo(ByVal Project_no As Integer, ByVal Project_StartDate As String,
                           ByVal Project_Date As String, ByVal Project_Period As Integer,
                           ByVal Project_name As String, ByVal Project_ManagerName As String)


        dal.Open()

        Dim parm(5) As SqlParameter
        parm(0) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(0).Value = Project_no

        parm(1) = New SqlParameter("@Project_StartDate", SqlDbType.NVarChar, 50)
        parm(1).Value = Project_StartDate

        parm(2) = New SqlParameter("@Project_Date", SqlDbType.NVarChar, 50)
        parm(2).Value = Project_Date

        parm(3) = New SqlParameter("@Project_Period", SqlDbType.Int)
        parm(3).Value = Project_Period

        parm(4) = New SqlParameter("@Project_name", SqlDbType.NVarChar, 50)
        parm(4).Value = Project_name

        parm(5) = New SqlParameter("@Project_ManagerName", SqlDbType.NChar, 10)
        parm(5).Value = Project_ManagerName


        dal.executedata("sp_updateTBLProjectInfo", parm)
        dal.Close()
    End Sub
    Public Function verifyProjectInfo(ByVal Project_no As Integer) As DataTable
        dal.open()
        Dim parm(1) As SqlParameter
        parm(0) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(0).Value = Project_no

        Dim dt As New DataTable()
        dt = dal.selectdata("sp_verifyProjectInfo", parm)
        dal.Close()
        Return dt
    End Function
    Public Function searchProjectInfo(ByVal id As String) As DataTable
        dal.Open()
        Dim parm(0) As SqlParameter
        parm(0) = New SqlParameter("@id", SqlDbType.NVarChar, 25)
        parm(0).Value = id
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_searchProjectInfo", parm)
        dal.Close()
        Return dt
    End Function

    Public Sub deleteProjectInfo(ByVal Project_no As Integer)
        dal.open()
        Dim parm(0) As SqlParameter
        parm(0) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(0).Value = Project_no

        dal.executedata("sp_deleteProjectInfo", parm)
        dal.Close()
    End Sub
    Public Function Get_Single_ProjectInfo(ByVal Project_no As Integer) As DataTable
        dal.open()
        Dim parm(1) As SqlParameter
        parm(0) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(0).Value = Project_no

        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_All_ProjectInfo", parm)
        dal.Close()
        Return dt
    End Function
    'sp_Get_Single_LetterOfIntend_ProjNo
    Public Function Get_Single_LetterOfIntend_ProjNo(ByVal project_no As Integer) As DataTable
        dal.Open()
        Dim parm(0) As SqlParameter
        parm(0) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(0).Value = project_no
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_Single_LetterOfIntend_ProjNo", parm)
        dal.Close()
        Return dt
    End Function

    Public Function Get_Project_name(ByVal project_no As Integer) As DataTable
        dal.Open()
        Dim parm(0) As SqlParameter
        parm(0) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(0).Value = project_no
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_Project_name", parm)
        dal.Close()
        Return dt
    End Function
    Public Function Get_Projectname() As DataTable
        dal.Open()
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_Projectname", Nothing)
        dal.Close()
        Return dt
    End Function
    Public Function Get_Project_no() As DataTable
        dal.Open()
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_Project_no", Nothing)
        dal.Close()
        Return dt
    End Function

End Class


