<%@ Page Title="" Language="vb" MaintainScrollPositionOnPostback ="true"  AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_insProfItems.aspx.vb" Inherits="webPMAlJohi.WebFrm_insProfItems" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container " id="InsPInfo">
             <table class="table ">
        <thead >
            <tr>
            <td> <b>اضافة بنود البروفيل جديد</b>

            </td>
        </tr>
        </thead>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>اختار رقم البند :</b></td>
            <td class="col-md-3">
                <asp:DropDownList ID="DDLProfItemsNo" runat="server" Width="400px" AutoPostBack="True"></asp:DropDownList>
            </td>
        </tr>
       <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>ادخل رقم البند البروفيل :</b></td>
            <td class="col-md-3">
               <asp:TextBox ID="txtMProItem_no" runat="server"
                     AutoPostBack="True" Width="400px"></asp:TextBox>         

            </td>
        </tr>
       <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>ادخل سعر البند البروفيل :</b></td>
            <td class="col-md-3">
               <asp:TextBox ID="txtMPPrice" runat="server"
                     AutoPostBack="True" Width="400px"></asp:TextBox>  

            </td>
        </tr>
       <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>ادخل كمية البند :</b></td>
            <td class="col-md-3">
                <asp:TextBox ID="txtQty" runat="server"
                     AutoPostBack="True" Width="400px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td class="col-md-3" >
           <asp:Button ID="btn_Add" Class="btn btn-success" runat="server" Text="اضافة" Width="200px" />

            </td>
        <td class="col-md-9 " >
                <asp:Button ID="btn_Close" Class="btn btn-success" runat="server" Text="خروج" Width="200px" /></td>
        </tr>        
    </table>
    </div>

</asp:Content>
