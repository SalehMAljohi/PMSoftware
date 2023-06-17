<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_insProfSubItem.aspx.vb" Inherits="webPMAlJohi.WebFrm_insProfSubItem" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="container " id="InsPInfo">
             <table class="table ">
        <thead >
            <tr>
            <td> <b>اضافة بنود الباطن للبروفيل جديد</b>

            </td>
        </tr>
        </thead>
       <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>اختار رقم البروفيل  :</b></td>
            <td class="col-md-3">
                <asp:DropDownList ID="DDLProfNo" runat="server" Width="400px" AutoPostBack="True"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>اختار وصف البند الرئيسي :</b></td>
            <td class="col-md-3">
                <asp:dropdownlist id="DDLProfItemsDes" runat="server" width="400px" autopostback="True"></asp:dropdownlist>
            </td>
        </tr>
       <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>اختار وصف البند الباطن :</b></td>
            <td class="col-md-3">
                <asp:DropDownList ID="DDLProfSubIDes" runat="server" Width="400px" AutoPostBack="True"></asp:DropDownList>
            </td>
        </tr>
       <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>اختار وحده البند :</b></td>
            <td class="col-md-3">
                <asp:DropDownList ID="DDLProfUnit" runat="server" Width="400px" AutoPostBack="True"></asp:DropDownList>
            </td>
        </tr>
       <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>سعر الوحده :</b></td>
            <td class="col-md-3">
                <asp:TextBox ID="txtProf_UPrice" runat="server"
                     AutoPostBack="True" Width="400px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td class="col-md-3" >
           <asp:Button ID="btn_Add" Class="btn btn-success" runat="server" Text="اضافة" Width="400px" />

            </td>
        <td class="col-md-9 " >
                <asp:Button ID="btn_Close" Class="btn btn-success" runat="server" Text="خروج" Width="400px" /></td>
        </tr>        
    </table>
    </div>

</asp:Content>
