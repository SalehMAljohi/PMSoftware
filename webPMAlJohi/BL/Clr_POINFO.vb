Imports System.Data
Imports System.Data.SqlClient
Public Class Clr_POINFO
    Dim dal As New DataAccessLayer()
    Public Function Get_POInfo_No() As DataTable
        dal.Open()
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_POInfo_No", Nothing)
        dal.Close()
        Return dt
    End Function
    Public Function Get_POAndProjInfo_No(ByVal id As Integer) As DataTable
        dal.Open()
        Dim parm(0) As SqlParameter
        parm(0) = New SqlParameter("@id", SqlDbType.Int)
        parm(0).Value = id
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_POAndProjInfo_No", parm)
        dal.Close()
        Return dt
    End Function
    'sp_insLetterOfIntendWNoImage
    Public Sub POInfNoImage(ByVal PO_Date As String,
                               ByVal PO_StartDate As String, ByVal PO_EndDate As String,
                               ByVal PO_Value As Double,
                            ByVal Project_no As Integer)


        dal.Open()

        Dim parm(4) As SqlParameter
        'parm(0) = New SqlParameter("@PO_No", SqlDbType.Int)
        'parm(0).Value = PO_No

        parm(0) = New SqlParameter("@PO_Date", SqlDbType.NVarChar, 50)
        parm(0).Value = PO_Date

        parm(1) = New SqlParameter("@PO_StartDate", SqlDbType.NVarChar, 50)
        parm(1).Value = PO_StartDate
        parm(2) = New SqlParameter("@PO_EndDate", SqlDbType.NVarChar, 50)
        parm(2).Value = PO_EndDate

        parm(3) = New SqlParameter("@PO_Value", SqlDbType.Float)
        parm(3).Value = PO_Value
        parm(4) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(4).Value = Project_no


        dal.executedata("ps_POInfNoImage", parm)
        dal.Close()
    End Sub
    Public Sub POInf(ByVal PO_Date As String,
                               ByVal PO_StartDate As String, ByVal PO_EndDate As String,
                               ByVal PO_Value As Double, ByVal FileN As String,
                            ByVal Project_no As Integer)


        dal.Open()

        Dim parm(5) As SqlParameter
        'parm(0) = New SqlParameter("@PO_No", SqlDbType.Int)
        'parm(0).Value = PO_No

        parm(0) = New SqlParameter("@PO_Date", SqlDbType.NVarChar, 50)
        parm(0).Value = PO_Date

        parm(1) = New SqlParameter("@PO_StartDate", SqlDbType.NVarChar, 50)
        parm(1).Value = PO_StartDate
        parm(2) = New SqlParameter("@PO_EndDate", SqlDbType.NVarChar, 50)
        parm(2).Value = PO_EndDate

        parm(3) = New SqlParameter("@PO_Value", SqlDbType.Float)
        parm(3).Value = PO_Value
        parm(4) = New SqlParameter("@FileN", SqlDbType.NVarChar, 50)
        parm(4).Value = FileN
        'parm(5) = New SqlParameter("@FileD", SqlDbType.Binary)
        'parm(6).Value = FileD
        parm(5) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(5).Value = Project_no



        dal.executedata("ps_POInf", parm)
        dal.Close()
    End Sub


End Class
