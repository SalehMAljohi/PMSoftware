Imports System.Data.SqlClient
Public Class Clr_SubItemsInfo
    Dim dal As New DataAccessLayer()
    Public Sub insSubItemInfo(ByVal SubItem_no As Integer,
                              ByVal SubItem_Desc As String,
                           ByVal SubItem_UDesc As String,
                          ByVal SubItem_UPrice As Double,
                            ByVal SubContractor_No As Integer)


        dal.Open()

        Dim parm(4) As SqlParameter
        parm(0) = New SqlParameter("@SubItem_no", SqlDbType.Int)
        parm(0).Value = SubItem_no

        parm(1) = New SqlParameter("@SubItem_Desc", SqlDbType.NVarChar, 50)
        parm(1).Value = SubItem_Desc

        parm(2) = New SqlParameter("@SubItem_UDesc", SqlDbType.NVarChar, 50)
        parm(2).Value = SubItem_UDesc

        parm(3) = New SqlParameter("@SubItem_UPrice", SqlDbType.Float)
        parm(3).Value = SubItem_UPrice
        parm(4) = New SqlParameter("@SubContractor_No", SqlDbType.Int)
        parm(4).Value = SubContractor_No
        dal.executedata("sp_insSubItemInfo", parm)
        dal.Close()
    End Sub
    Public Function Get_SubItem_No() As DataTable
        dal.Open()
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_SubItem_No", Nothing)
        dal.Close()
        Return dt
    End Function



End Class
