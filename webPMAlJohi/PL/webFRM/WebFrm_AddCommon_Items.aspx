<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_AddCommon_Items.aspx.vb" Inherits="webPMAlJohi.WebFrm_AddCommon_Items" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container " id="InsPInfo">
             <table class="table ">
        <thead >
            <tr>
            <td> <b>اضافة معلومات البند الشائع الجديد</b>

            </td>
        </tr>
        </thead>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>ادخل  رقم البند الشائع :</b></td>
            <td class="col-md-3">
               <asp:TextBox ID="txtItem_NO" runat="server"
                   AutoPostBack="True" Width="400px"></asp:TextBox>            </td>
        </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>ادخل  وصف البند الشائع  :</b></td>
            <td class="col-md-3">
              <asp:TextBox ID="txtItem_Descr" runat="server"
                 AutoPostBack="True" Width="400px"></asp:TextBox>            </td>
        </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>ادخل  رقم (stc)البند الشائع :</b></td>
            <td class="col-md-3">
                <asp:TextBox ID="txtitem_STCNo" runat="server"
                     AutoPostBack="True" Width="400px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td class="col-md-3 "></td>
             <td class="col-md-3"><b>ادخل وحده القياس :</b></td>
            <td class="col-md-3">
                <asp:TextBox ID="txtitem_unit" runat="server"
                     AutoPostBack="True" Width="400px"></asp:TextBox>

            </td>

        </tr>
        <tr>
            <td class="col-md-3 "></td>
          <td class="col-md-3"><b>ادخل سعر البند الشائع الاساسي :</b></td>
            <td class="col-md-3">
                <asp:TextBox ID="txtItem_mainPrice" runat="server"
                     AutoPostBack="True" Width="400px"></asp:TextBox>

            </td>

        </tr>
        <tr>
            <td class="col-md-3 "></td>
    <td class="col-md-3"><b>ادخل ملاحظة عن البند الشائع  :</b></td>
            <td class="col-md-3">
                <asp:TextBox ID="txtItem_Note" runat="server"
                     AutoPostBack="True" Width="400px"></asp:TextBox>

            </td>    
        </tr>
        <tr>
            <td class="col-md-3" >
           <asp:Button ID="btn_Add" runat="server" Text="اضافة" Width="400px" />

            </td>
        <td class="col-md-9 " >
                <asp:Button ID="btn_Close" runat="server" Text="خروج" Width="400px" /></td>
        </tr>        
    </table>
    </div>

</asp:Content>
