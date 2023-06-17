<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_AddCatagories.aspx.vb" Inherits="webPMAlJohi.WebFrm_AddCatagories" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div class="container " id="InsPInfo">
             <table class="table ">
        <thead >
            <tr>
            <td> <b>اضافة معلومات الصنف  الجديد</b>

            </td>
        </tr>
        </thead>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>ادخل  وصف الصنف  :</b></td>
            <td class="col-md-3">
               <asp:TextBox ID="txtCat_Desc" runat="server"
                   AutoPostBack="True" Width="400px"></asp:TextBox>            </td>
        </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>ادخل  اسم الصنف   :</b></td>
            <td class="col-md-3">
              <asp:TextBox ID="txtCat_Name" runat="server"
                 AutoPostBack="True" Width="400px"></asp:TextBox>            </td>
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
