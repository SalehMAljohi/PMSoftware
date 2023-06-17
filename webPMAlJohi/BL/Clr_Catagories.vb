Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient
Public Class Clr_Catagories
    Dim dal As New DataAccessLayer()

    Public Sub insCatagoriesInfo(ByVal cat_desc As Integer, ByVal cat_Name As String)


        dal.Open()

        Dim parm(1) As SqlParameter
        parm(0) = New SqlParameter("@cat_desc", SqlDbType.Int)
        parm(0).Value = cat_desc
        parm(1) = New SqlParameter("@cat_Name", SqlDbType.NVarChar, 50)
        parm(1).Value = cat_Name
        dal.executedata("sp_insCatagoriesInfo", parm)
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
