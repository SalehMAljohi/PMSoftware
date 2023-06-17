Imports System.Data.SqlClient
Public Class Clr_SubConContract
    Dim dal As New DataAccessLayer()
    Public Sub insSubConContract_WNoImage(ByVal SubConC_no As Integer, ByVal SubConC_Date As String,
                               ByVal SubConCS_Date As String, ByVal SubConCE_Date As String,
                               ByVal SubConC_Value As Double, ByVal SubCon_no As Integer,
                            ByVal PO_no As Integer, ByVal Project_no As Integer)


        dal.Open()

        Dim parm(7) As SqlParameter
        parm(0) = New SqlParameter("@SubConC_no", SqlDbType.Int)
        parm(0).Value = SubConC_no

        parm(1) = New SqlParameter("@SubConC_Date", SqlDbType.NVarChar, 50)
        parm(1).Value = SubConC_Date

        parm(2) = New SqlParameter("@SubConCS_Date", SqlDbType.NVarChar, 50)
        parm(2).Value = SubConCS_Date
        parm(3) = New SqlParameter("@SubConCE_Date", SqlDbType.NVarChar, 50)
        parm(3).Value = SubConCE_Date

        parm(4) = New SqlParameter("@SubConC_Value", SqlDbType.Float)
        parm(4).Value = SubConC_Value
        parm(5) = New SqlParameter("@SubCon_no", SqlDbType.Int)
        parm(5).Value = SubCon_no
        parm(6) = New SqlParameter("@PO_no", SqlDbType.Int)
        parm(6).Value = PO_no
        parm(7) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(7).Value = Project_no


        dal.executedata("sp_insSubConContract_WNoImage", parm)
        dal.Close()
    End Sub
    Public Sub insSubConContract(ByVal SubConC_no As Integer, ByVal SubConC_Date As String,
                               ByVal SubConCS_Date As String, ByVal SubConCE_Date As String,
                               ByVal SubConC_Value As Double, ByVal SubCon_no As Integer,
                            ByVal PO_no As Integer, ByVal Project_no As Integer, ByVal FileN As String,
                              ByVal FileD As Byte())


        dal.Open()

        Dim parm(9) As SqlParameter
        parm(0) = New SqlParameter("@SubConC_no", SqlDbType.Int)
        parm(0).Value = SubConC_no

        parm(1) = New SqlParameter("@SubConC_Date", SqlDbType.NVarChar, 50)
        parm(1).Value = SubConC_Date

        parm(2) = New SqlParameter("@SubConCS_Date", SqlDbType.NVarChar, 50)
        parm(2).Value = SubConCS_Date
        parm(3) = New SqlParameter("@SubConCE_Date", SqlDbType.NVarChar, 50)
        parm(3).Value = SubConCE_Date

        parm(4) = New SqlParameter("@SubConC_Value", SqlDbType.Float)
        parm(4).Value = SubConC_Value
        parm(5) = New SqlParameter("@SubCon_no", SqlDbType.Int)
        parm(5).Value = SubCon_no
        parm(6) = New SqlParameter("@PO_no", SqlDbType.Int)
        parm(6).Value = PO_no
        parm(7) = New SqlParameter("@Project_no", SqlDbType.Int)
        parm(7).Value = Project_no

        parm(8) = New SqlParameter("@FileN", SqlDbType.NVarChar, 50)
        parm(8).Value = FileN
        parm(9) = New SqlParameter("@FileD", SqlDbType.Binary)
        parm(9).Value = FileD
        dal.executedata("sp_insSubConContract", parm)
        dal.Close()
    End Sub

End Class
