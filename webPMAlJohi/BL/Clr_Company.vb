Imports System.Data.SqlClient
Public Class Clr_Company
    Dim dal As New DataAccessLayer()
    '[sp_insTBLcompanyNOFU]
    Public Sub companyInfNoImage(ByVal company_name As String,
                           ByVal company_address As String)


        dal.Open()

        Dim parm(1) As SqlParameter
        parm(0) = New SqlParameter("@company_name", SqlDbType.NVarChar, 50)
        parm(0).Value = company_name

        parm(1) = New SqlParameter("@company_address", SqlDbType.NVarChar, 50)
        parm(1).Value = company_address

        dal.executedata("ps_companyInfNoImage", parm)
        dal.Close()
    End Sub

    Public Sub companyInf(ByVal company_name As String,
                           ByVal company_address As String,
                              ByVal FileN As String)


        dal.Open()

        Dim parm(2) As SqlParameter
        parm(0) = New SqlParameter("@company_name", SqlDbType.NVarChar, 50)
        parm(0).Value = company_name

        parm(1) = New SqlParameter("@company_address", SqlDbType.NVarChar, 50)
        parm(1).Value = company_address

        parm(2) = New SqlParameter("@FileN", SqlDbType.NVarChar, 50)
        parm(2).Value = FileN
        'parm(3) = New SqlParameter("@FileD", SqlDbType.VarBinary)
        'parm(3).Value = FileD
        dal.executedata("ps_companyInf", parm)
        dal.Close()
    End Sub
    Public Function Get_Companyname() As DataTable
        dal.Open()
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_Companyname", Nothing)
        dal.Close()
        Return dt
    End Function
    Public Function Get_companyInfNo(ByVal company_name As String) As DataTable
        dal.Open()
        Dim dt As New DataTable()
        Dim parm(0) As SqlParameter
        parm(0) = New SqlParameter("@company_name", SqlDbType.NVarChar, 50)
        parm(0).Value = company_name
        dt = dal.selectdata("ps_Get_companyInfNo", parm)
        dal.Close()
        Return dt
    End Function

End Class
