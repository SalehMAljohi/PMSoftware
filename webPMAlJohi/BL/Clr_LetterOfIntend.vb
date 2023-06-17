Imports System.Data
Imports System.Data.SqlClient
Public Class Clr_LetterOfIntend

    Dim dal As New DataAccessLayer()

    Public Function Get_All_LetterOfIntend() As DataTable
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_All_LetterOfIntend", Nothing)
        dal.Close()
        Return dt
    End Function
    'sp_insLetterOfIntendWNoImage
    Public Sub insLetterOfIntendWNoImage(ByVal LetterOfIntend_No As Integer, ByVal LetterOfIntend_Date As Date,
                               ByVal LetterOfIntend_StartDate As Date, ByVal LetterOfIntend_EndDate As Date,
                               ByVal LetterOfIntend_Value As Double, ByVal LetterOfIntend_OwnerPMName As String,
                              ByVal LetterOfIntend_ContractorPMName As String,
                            ByVal Project_no As Integer, ByVal Project_Name As String)


        dal.Open()

        Dim parm(8) As SqlParameter
        parm(0) = New SqlParameter("@LetterOfIntend_No", SqlDbType.Int)
        parm(0).Value = LetterOfIntend_No

        parm(1) = New SqlParameter("@LetterOfIntend_Date", SqlDbType.Date)
        parm(1).Value = LetterOfIntend_Date

        parm(2) = New SqlParameter("@LetterOfIntend_StartDate", SqlDbType.Date)
        parm(2).Value = LetterOfIntend_StartDate
        parm(3) = New SqlParameter("@LetterOfIntend_EndDate", SqlDbType.Date)
        parm(3).Value = LetterOfIntend_EndDate

        parm(4) = New SqlParameter("@LetterOfIntend_Value", SqlDbType.Float)
        parm(4).Value = LetterOfIntend_Value

        parm(5) = New SqlParameter("@LetterOfIntend_OwnerPMName", SqlDbType.NVarChar, 50)
        parm(5).Value = LetterOfIntend_OwnerPMName
        parm(6) = New SqlParameter("@LetterOfIntend_ContractorPMName", SqlDbType.NVarChar, 50)
        parm(6).Value = LetterOfIntend_ContractorPMName
        parm(7) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(7).Value = Project_no
        parm(8) = New SqlParameter("@Project_Name", SqlDbType.NVarChar, 50)
        parm(8).Value = Project_Name

        dal.executedata("sp_insLetterOfIntendWNoImage", parm)
        dal.Close()
    End Sub
    Public Sub insLetterOfIntend(ByVal LetterOfIntend_No As Integer, ByVal LetterOfIntend_Date As Date,
                               ByVal LetterOfIntend_StartDate As Date, ByVal LetterOfIntend_EndDate As Date,
                               ByVal LetterOfIntend_Value As Double, ByVal LetterOfIntend_OwnerPMName As String,
                              ByVal LetterOfIntend_ContractorPMName As String,
                           ByVal LetterOfIntend_Picture() As Byte, ByVal Project_no As Integer,
                           ByVal Project_Name As String)


        dal.Open()

        Dim parm(9) As SqlParameter
        parm(0) = New SqlParameter("@LetterOfIntend_No", SqlDbType.Int)
        parm(0).Value = LetterOfIntend_No

        parm(1) = New SqlParameter("@LetterOfIntend_Date", SqlDbType.Date)
        parm(1).Value = LetterOfIntend_Date

        parm(2) = New SqlParameter("@LetterOfIntend_StartDate", SqlDbType.Date)
        parm(2).Value = LetterOfIntend_StartDate
        parm(3) = New SqlParameter("@LetterOfIntend_EndDate", SqlDbType.Date)
        parm(3).Value = LetterOfIntend_EndDate

        parm(4) = New SqlParameter("@LetterOfIntend_Value", SqlDbType.Float)
        parm(4).Value = LetterOfIntend_Value

        parm(5) = New SqlParameter("@LetterOfIntend_OwnerPMName", SqlDbType.NVarChar, 50)
        parm(5).Value = LetterOfIntend_OwnerPMName
        parm(6) = New SqlParameter("@LetterOfIntend_ContractorPMName", SqlDbType.NVarChar, 50)
        parm(6).Value = LetterOfIntend_ContractorPMName
        parm(7) = New SqlParameter("@LetterOfIntend_Picture", SqlDbType.VarBinary)
        parm(7).Value = LetterOfIntend_Picture
        parm(8) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(8).Value = Project_no
        parm(9) = New SqlParameter("@Project_Name", SqlDbType.NVarChar, 50)
        parm(9).Value = Project_Name

        dal.executedata("sp_insLetterOfIntend", parm)
        dal.Close()
    End Sub
    Public Sub updateLetterOfIntendWNoIMage(ByVal LetterOfIntend_No As Integer, ByVal LetterOfIntend_Date As Date,
                               ByVal LetterOfIntend_StartDate As Date, ByVal LetterOfIntend_EndDate As Date,
                               ByVal LetterOfIntend_Value As Double, ByVal LetterOfIntend_OwnerPMName As String,
                              ByVal LetterOfIntend_ContractorPMName As String,
                            ByVal Project_no As Integer, ByVal Project_Name As String)


        dal.Open()

        Dim parm(8) As SqlParameter
        parm(0) = New SqlParameter("@LetterOfIntend_No", SqlDbType.Int)
        parm(0).Value = LetterOfIntend_No
        parm(1) = New SqlParameter("@LetterOfIntend_Date", SqlDbType.Date)
        parm(1).Value = LetterOfIntend_Date
        parm(2) = New SqlParameter("@LetterOfIntend_StartDate", SqlDbType.Date)
        parm(2).Value = LetterOfIntend_StartDate
        parm(3) = New SqlParameter("@LetterOfIntend_EndDate", SqlDbType.Date)
        parm(3).Value = LetterOfIntend_EndDate
        parm(4) = New SqlParameter("@LetterOfIntend_Value", SqlDbType.Float)
        parm(4).Value = LetterOfIntend_Value
        parm(5) = New SqlParameter("@LetterOfIntend_OwnerPMName", SqlDbType.NVarChar, 50)
        parm(5).Value = LetterOfIntend_OwnerPMName
        parm(6) = New SqlParameter("@LetterOfIntend_ContractorPMName", SqlDbType.NVarChar, 50)
        parm(6).Value = LetterOfIntend_ContractorPMName
        parm(7) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(7).Value = Project_no
        parm(8) = New SqlParameter("@Project_Name", SqlDbType.Int)
        parm(8).Value = Project_Name

        dal.executedata("sp_updateLetterOfIntendWNoIMage", parm)
        dal.Close()
    End Sub
    Public Sub updateLetterOfIntend(ByVal LetterOfIntend_No As Integer, ByVal LetterOfIntend_Date As Date,
                               ByVal LetterOfIntend_StartDate As Date, ByVal LetterOfIntend_EndDate As Date,
                               ByVal LetterOfIntend_Value As Double, ByVal LetterOfIntend_OwnerPMName As String,
                              ByVal LetterOfIntend_ContractorPMName As String,
                           ByVal LetterOfIntend_Picture As Image, ByVal Project_no As Integer,
                           ByVal Project_Name As String)


        dal.Open()

        Dim parm(9) As SqlParameter
        parm(0) = New SqlParameter("@LetterOfIntend_No", SqlDbType.Int)
        parm(0).Value = LetterOfIntend_No

        parm(1) = New SqlParameter("@LetterOfIntend_Date", SqlDbType.Date)
        parm(1).Value = LetterOfIntend_Date

        parm(2) = New SqlParameter("@LetterOfIntend_StartDate", SqlDbType.Date)
        parm(2).Value = LetterOfIntend_StartDate
        parm(3) = New SqlParameter("@LetterOfIntend_EndDate", SqlDbType.Date)
        parm(3).Value = LetterOfIntend_EndDate

        parm(4) = New SqlParameter("@LetterOfIntend_Value", SqlDbType.Float)
        parm(4).Value = LetterOfIntend_Value

        parm(5) = New SqlParameter("@LetterOfIntend_OwnerPMName", SqlDbType.NVarChar, 50)
        parm(5).Value = LetterOfIntend_OwnerPMName
        parm(6) = New SqlParameter("@LetterOfIntend_ContractorPMName", SqlDbType.NVarChar, 50)
        parm(6).Value = LetterOfIntend_ContractorPMName
        parm(7) = New SqlParameter("@LetterOfIntend_Picture", SqlDbType.Image)
        parm(7).Value = LetterOfIntend_Picture
        parm(8) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(8).Value = Project_no
        parm(9) = New SqlParameter("@Project_Name", SqlDbType.Int)
        parm(9).Value = Project_Name

        dal.executedata("sp_updateLetterOfIntend", parm)
        dal.Close()
    End Sub
    'Public Function verifyProjectInfo(ByVal Project_no As Integer) As DataTable
    '    dal.Open()
    '    Dim parm(1) As SqlParameter
    '    parm(0) = New SqlParameter("@Project_no", SqlDbType.Int)
    '    parm(0).Value = Project_no

    '    Dim dt As New DataTable()
    '    dt = dal.selectdata("sp_verifyProjectInfo", parm)
    '    dal.Close()
    '    Return dt
    'End Function
    Public Function Search_LetterOfIntend(ByVal id As String) As DataTable
        dal.Open()
        Dim parm(0) As SqlParameter
        parm(0) = New SqlParameter("@id", SqlDbType.NVarChar, 25)
        parm(0).Value = id
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Search_LetterOfIntend", parm)
        dal.Close()
        Return dt
    End Function

    Public Sub deleteLetterOfIntend(ByVal LetterOfIntend_No As Integer)
        dal.Open()
        Dim parm(0) As SqlParameter
        parm(0) = New SqlParameter("@LetterOfIntend_No", SqlDbType.Int)
        parm(0).Value = LetterOfIntend_No

        dal.executedata("sp_deleteLetterOfIntend", parm)
        dal.Close()
    End Sub
    'sp_Get_Single_LetterOfIntend_ProjNo
    'sp_Get_All_LetterOfIntendOfSProject
    Public Function All_LetterOfIntendOfSProject(ByVal Project_no As Integer) As DataTable
        dal.Open()
        Dim parm(0) As SqlParameter
        parm(0) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(0).Value = Project_no

        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_All_LetterOfIntendOfSProject", parm)
        dal.Close()
        Return dt
    End Function

    Public Function Get_Single_LetterOfIntend_ProjNo(ByVal Project_no As Integer) As DataTable
        dal.Open()
        Dim parm(0) As SqlParameter
        parm(0) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(0).Value = Project_no

        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_Single_LetterOfIntend_ProjNo", parm)
        dal.Close()
        Return dt
    End Function
    Public Function Get_Single_LetterOfIntend(ByVal LetterOfIntend_No As Integer) As DataTable
        dal.Open()
        Dim parm(0) As SqlParameter
        parm(0) = New SqlParameter("@LetterOfIntend_No", SqlDbType.Int)
        parm(0).Value = LetterOfIntend_No

        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_Single_LetterOfIntend", parm)
        dal.Close()
        Return dt
    End Function
    'Public Function Get_Project_name() As DataTable
    '    dal.Open()
    '    Dim dt As New DataTable()
    '    dt = dal.selectdata("sp_Get_Project_name", Nothing)
    '    dal.Close()
    '    Return dt
    'End Function
    'Public Function Get_Project_no() As DataTable
    '    dal.Open()
    '    Dim dt As New DataTable()
    '    dt = dal.selectdata("sp_Get_Project_no", Nothing)
    '    dal.Close()
    '    Return dt
    'End Function


End Class
