Imports System.Data.SqlClient
Public Class Clr_Main_contractors
    Dim dal As New DataAccessLayer()
    '[sp_insTBLcompanyNOFU]
    Public Sub Main_contractorNoImage(ByVal Main_contractor_name As String,
                           ByVal Main_contractor_address As String,
                           ByVal Main_contractor_Mobile As String,
                          ByVal Main_contractor_RP As String,
                          ByVal project_no As Integer,
                          ByVal company_no As Integer)


        dal.Open()

        Dim parm(5) As SqlParameter
        'parm(0) = New SqlParameter("@Main_contractor_no", SqlDbType.Int)
        'parm(0).Value = Main_contractor_no

        parm(0) = New SqlParameter("@Main_contractor_name", SqlDbType.NVarChar, 50)
        parm(0).Value = Main_contractor_name

        parm(1) = New SqlParameter("@Main_contractor_address", SqlDbType.NVarChar, 50)
        parm(1).Value = Main_contractor_address
        parm(2) = New SqlParameter("@Main_contractor_Mobile", SqlDbType.NVarChar, 50)
        parm(2).Value = Main_contractor_Mobile
        parm(3) = New SqlParameter("@Main_contractor_RP", SqlDbType.NVarChar, 50)
        parm(3).Value = Main_contractor_RP
        parm(4) = New SqlParameter("@project_no", SqlDbType.Int)
        parm(4).Value = project_no
        parm(5) = New SqlParameter("@company_no", SqlDbType.Int)
        parm(5).Value = company_no
        dal.executedata("ps_Main_contractorNoImage", parm)
        dal.Close()
    End Sub
    Public Sub Main_contractor(ByVal Main_contractor_name As String,
                           ByVal Main_contractor_address As String,
                           ByVal Main_contractor_Mobile As String,
                          ByVal Main_contractor_RP As String,
                          ByVal project_no As Integer,
                          ByVal company_no As Integer,
                        ByVal FileN As String)


        dal.Open()

        Dim parm(6) As SqlParameter
        'parm(0) = New SqlParameter("@Main_contractor_no", SqlDbType.Int)
        'parm(0).Value = Main_contractor_no

        parm(0) = New SqlParameter("@Main_contractor_name", SqlDbType.NVarChar, 50)
        parm(0).Value = Main_contractor_name

        parm(1) = New SqlParameter("@Main_contractor_address", SqlDbType.NVarChar, 50)
        parm(1).Value = Main_contractor_address
        parm(2) = New SqlParameter("@Main_contractor_Mobile", SqlDbType.NVarChar, 50)
        parm(2).Value = Main_contractor_Mobile
        parm(3) = New SqlParameter("@Main_contractor_RP", SqlDbType.NVarChar, 50)
        parm(3).Value = Main_contractor_RP
        parm(4) = New SqlParameter("@project_no", SqlDbType.Int)
        parm(4).Value = project_no
        parm(5) = New SqlParameter("@company_no", SqlDbType.Int)
        parm(5).Value = company_no
        parm(6) = New SqlParameter("@FileN", SqlDbType.NVarChar, 50)
        parm(6).Value = FileN
        'parm(7) = New SqlParameter("@FileD", SqlDbType.Binary)
        'parm(7).Value = FileD

        dal.executedata("ps_Main_contractor", parm)
        dal.Close()
    End Sub


End Class
