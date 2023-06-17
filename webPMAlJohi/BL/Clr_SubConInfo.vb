Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient
Public Class Clr_SubConInfo
    Dim dal As New DataAccessLayer()
    'sp_insSubConInfoNOFile
    Public Sub insSubConInfoNOFile(
                                  ByVal SubContractor_Name As String,
                           ByVal SubContractor_Phon As String, ByVal SubContractor_Address As String,
                           ByVal SubContractor_RP As String, ByVal SubContractor_Com_Address As String,
                              ByVal Item_no As Integer)
        dal.Open()
        Dim parm(5) As SqlParameter
        'parm(0) = New SqlParameter("@SubContractor_No", SqlDbType.Int)
        'parm(0).Value = SubContractor_No

        parm(0) = New SqlParameter("@SubContractor_Name", SqlDbType.NVarChar, 50)
        parm(0).Value = SubContractor_Name

        parm(1) = New SqlParameter("@SubContractor_Phon", SqlDbType.NVarChar, 50)
        parm(1).Value = SubContractor_Phon

        parm(2) = New SqlParameter("@SubContractor_Address", SqlDbType.NVarChar, 50)
        parm(2).Value = SubContractor_Address

        parm(3) = New SqlParameter("@SubContractor_RP", SqlDbType.NVarChar, 50)
        parm(3).Value = SubContractor_RP

        parm(4) = New SqlParameter("@SubContractor_Com_Address", SqlDbType.NVarChar, 50)
        parm(4).Value = SubContractor_Com_Address
        parm(5) = New SqlParameter("@Item_no", SqlDbType.Int)
        parm(5).Value = Item_no

        dal.executedata("sp_insSubConInfoNOFile", parm)
        dal.Close()
    End Sub
    Public Sub insSubConInfo(ByVal SubContractor_Name As String,
                           ByVal SubContractor_Phon As String,
                              ByVal SubContractor_Address As String,
                           ByVal SubContractor_RP As String,
                              ByVal SubContractor_Com_Address As String,
                              ByVal FileN As String,
                               ByVal Item_no As Integer)


        dal.Open()

        Dim parm(6) As SqlParameter


        parm(0) = New SqlParameter("@SubContractor_Name", SqlDbType.NVarChar, 50)
        parm(0).Value = SubContractor_Name

        parm(1) = New SqlParameter("@SubContractor_Phon", SqlDbType.NVarChar, 50)
        parm(1).Value = SubContractor_Phon

        parm(2) = New SqlParameter("@SubContractor_Address", SqlDbType.NVarChar, 50)
        parm(2).Value = SubContractor_Address

        parm(3) = New SqlParameter("@SubContractor_RP", SqlDbType.NVarChar, 50)
        parm(3).Value = SubContractor_RP

        parm(4) = New SqlParameter("@SubContractor_Com_Address", SqlDbType.NVarChar, 50)
        parm(4).Value = SubContractor_Com_Address
        parm(5) = New SqlParameter("@FileN", SqlDbType.NVarChar, 50)
        parm(5).Value = FileN

        parm(6) = New SqlParameter("@Item_no", SqlDbType.Int)
        parm(6).Value = Item_no
        dal.executedata("sp_insSubConInfo", parm)
        dal.Close()
    End Sub
    Public Function Get_SubContractor_No() As DataTable
        dal.Open()
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_SubContractor_No", Nothing)
        dal.Close()
        Return dt
    End Function
    Public Function Get_SubConAndPO_No(ByVal ID As Integer) As DataTable
        dal.Open()
        Dim parm(0) As SqlParameter
        parm(0) = New SqlParameter("@id", SqlDbType.Int)
        parm(0).Value = ID
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_SubConAndPO_No", parm)
        dal.Close()
        Return dt
    End Function
End Class
