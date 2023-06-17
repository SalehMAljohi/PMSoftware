Imports System.Data.SqlClient
Public Class Clr_Items
    Dim dal As New DataAccessLayer()
    '[sp_insTBLcompanyNOFU]
    Public Sub insItemsInfo(ByVal Item_no As Integer,
                              ByVal STC_Item_no As String,
                           ByVal Item_Des As String,
                           ByVal Item_Unit As String,
                          ByVal Item_UPrice As Double,
                            ByVal PO_NO As Integer)


        dal.Open()

        Dim parm(5) As SqlParameter
        parm(0) = New SqlParameter("@Item_no", SqlDbType.Int)
        parm(0).Value = Item_no

        parm(1) = New SqlParameter("@STC_Item_no", SqlDbType.NVarChar, 50)
        parm(1).Value = STC_Item_no

        parm(2) = New SqlParameter("@Item_Des", SqlDbType.NVarChar, 50)
        parm(2).Value = Item_Des
        parm(3) = New SqlParameter("@Item_Unit", SqlDbType.NVarChar, 50)
        parm(3).Value = Item_Unit
        parm(4) = New SqlParameter("@Item_UPrice", SqlDbType.Float)
        parm(4).Value = Item_UPrice
        parm(5) = New SqlParameter("@PO_NO", SqlDbType.Int)
        parm(5).Value = PO_NO
        dal.executedata("sp_insItemsInfo", parm)
        dal.Close()
    End Sub
    Public Sub insTBLMain_contractor(ByVal Main_contractor_no As Integer,
                              ByVal Main_contractor_name As String,
                           ByVal Main_contractor_address As String,
                           ByVal Main_contractor_Mobile As String,
                           ByVal Main_contractor_profileF As String,
                          ByVal Main_contractor_RP As String,
                          ByVal project_no As Integer,
                          ByVal company_no As Integer,
                          ByVal Main_contractor_profileD As Byte())


        dal.Open()

        Dim parm(8) As SqlParameter
        parm(0) = New SqlParameter("@Main_contractor_no", SqlDbType.Int)
        parm(0).Value = Main_contractor_no

        parm(1) = New SqlParameter("@Main_contractor_name", SqlDbType.NVarChar, 50)
        parm(1).Value = Main_contractor_name

        parm(2) = New SqlParameter("@Main_contractor_address", SqlDbType.NVarChar, 50)
        parm(2).Value = Main_contractor_address
        parm(3) = New SqlParameter("@Main_contractor_Mobile", SqlDbType.NVarChar, 50)
        parm(3).Value = Main_contractor_Mobile
        parm(4) = New SqlParameter("@Main_contractor_profileF", SqlDbType.NVarChar, 50)
        parm(4).Value = Main_contractor_profileF
        parm(5) = New SqlParameter("@Main_contractor_RP", SqlDbType.NVarChar, 50)
        parm(5).Value = Main_contractor_RP
        parm(6) = New SqlParameter("@project_no", SqlDbType.Int)
        parm(6).Value = project_no
        parm(7) = New SqlParameter("@company_no", SqlDbType.Int)
        parm(7).Value = company_no
        parm(8) = New SqlParameter("@Main_contractor_profileD", SqlDbType.Binary)
        parm(8).Value = Main_contractor_profileD

        dal.executedata("sp_instblMainContractors", parm)
        dal.Close()
    End Sub
    Public Function Get_Item_no() As DataTable
        dal.Open()
        Dim dt As New DataTable()
        dt = dal.selectdata("sp_Get_Item_no", Nothing)
        dal.Close()
        Return dt
    End Function
    Public Sub insTbl_MItem_Profile(ByVal MainItem_profileNo As Integer,
                              ByVal MainItem_ProfileUnitPrice As Double,
                           ByVal MainItem_Qty As Integer,
                          ByVal MainItem_TotalM As Double,
                            ByVal Item_no As Integer)


        dal.Open()

        Dim parm(4) As SqlParameter
        parm(0) = New SqlParameter("@MainItem_profileNo", SqlDbType.Int)
        parm(0).Value = MainItem_profileNo

        parm(1) = New SqlParameter("@MainItem_ProfileUnitPrice", SqlDbType.Float)
        parm(1).Value = MainItem_ProfileUnitPrice

        parm(2) = New SqlParameter("@MainItem_Qty", SqlDbType.Int)
        parm(2).Value = MainItem_Qty
        parm(3) = New SqlParameter("@MainItem_TotalM", SqlDbType.Float)
        parm(3).Value = MainItem_TotalM

        parm(4) = New SqlParameter("@Item_no", SqlDbType.Int)
        parm(4).Value = Item_no
        dal.executedata("sp_insTbl_MItem_Profile", parm)
        dal.Close()
    End Sub


End Class
