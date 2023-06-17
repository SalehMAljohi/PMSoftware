<%@ Page Title="" Language="vb" MaintainScrollPositionOnPostback ="true"  UnobtrusiveValidationMode="None" AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_Get_All_ProjectInfo.aspx.vb" Inherits="webPMAlJohi.WebFrm_Get_All_ProjectInfo" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container " id="GAPROJINFO">
     <div class ="row">
         <h1 id="GAPROJINFOH"> ادارة وعرض جميع المشاريع</h1>
     </div>
     <div class="row" id="rowSearchProjInfo">
         <div class ="col-lg-3 ">

         </div>
         <div class ="col-lg-6 ">
            <b>بحث عن مشروع</b> <asp:Button ID="Button1" Class="btn btn-success"  runat="server" Text="بحث" />
             <asp:TextBox ID="txtPInfoSearch" runat="server" AutoPostBack="True"></asp:TextBox>
         </div>
         <div class ="col-lg-3 "></div>

     </div>
     <div class ="row ">
         <div class="col-lg-4 ">
             <div class ="row " id ="btnCPInfo">
                 <div class="col-sm-6" >
               <asp:Button ID="btnins1" runat="server" Class="btn btn-success"  Text="اضافة مشروع" />
                 </div>
                 <div class="col-sm-6" >
               <asp:Button ID="btnupdatePInfo" Class="btn btn-success" runat="server"  Text="تعديل مشروع" />
                 </div>
                 <div class="col-sm-6" >
               <asp:Button ID="btndeletePInfo" Class="btn btn-success" runat="server"  Text="مسح مشروع" />
                 </div>
                 <div class="col-sm-6" >
               <asp:Button ID="btnexit" Class="btn btn-success" runat="server"  Text="خروج" />
                 </div>
             </div>
         </div>
        <div class="col-lg-7">  
         <asp:GridView ID="GrdVGAProjectInfo" runat="server" AllowCustomPaging="True" AutoGenerateSelectButton="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" >
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
             <Columns >
                 <asp:TemplateField >
                     <ItemTemplate>
<asp:LinkButton ID="lnkDownload" runat="server" Text="تحميل"></asp:LinkButton>
</ItemTemplate>
                 </asp:TemplateField>
                 
             </Columns>
            </asp:GridView>
        </div>
         <div class="col-lg-1 ">
         </div>
         <div class="row panelrowGAPInfo">
            <asp:Panel ID="Panel1"  runat="server" Visible ="false" >
             <table class="table table-dark table-hover">
        <thead >
            <tr>
            <td> <b>تعديل مشروع </b>

            </td>
        </tr>
        </thead>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b> رقم المشروع :</b></td>
            <td class="col-md-3">
                <asp:TextBox ID="txtP_no" runat="server" ReadOnly="true"   AutoPostBack="True"></asp:TextBox>

            </td>
            <%-- <td class ="col-md-3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                             runat="server" 
                            ErrorMessage="ادخل رقم المشروع"
                            ControlToValidate="txtP_no"
                            Text="*" 
                            forecolor="Red">
                        </asp:RequiredFieldValidator>
                    </td>--%>
        </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>تعديل اسم المشروع :</b></td>
            <td class="col-md-3">
            <asp:TextBox ID="txtP_Name" runat="server" AutoPostBack="True"></asp:TextBox>
            </td>
           <%-- <td class ="col-md-3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                             runat="server" 
                            ErrorMessage="ادخل اسم المشروع"
                            ControlToValidate="txtP_Name"
                            Text="*" 
                            forecolor="Red">
                        </asp:RequiredFieldValidator>
                    </td>--%>
       
             </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>تعديل اسم مدير المشروع :</b></td>
            <td class="col-md-3">
           <asp:TextBox ID="txtP_M_Name" runat="server" AutoPostBack="True"></asp:TextBox>
            </td>
          <%--  <td class ="col-md-3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                             runat="server" 
                            ErrorMessage="ادخل اسم مدير المشروع"
                            ControlToValidate="txtP_M_Name"
                            Text="*" 
                            forecolor="Red">
                        </asp:RequiredFieldValidator>
                    </td>--%>
        </tr>
        <tr>
            <td class="col-md-2 "></td>
            <td class="col-md"><b>تاريخ بداية المشروع :</b></td>
            <td class="col-md-4">
                <asp:TextBox ID="txtS_Date" runat="server">
                </asp:TextBox><asp:ImageButton ID="ImageButton1"  runat="server" ImageUrl="~/images/calendarlogo1.png" Width="25px" />
                <asp:Calendar ID="Calendar_S_Date"  runat="server"></asp:Calendar>
                </td> 

        </tr>
               <tr>
            <td class="col-md-2 "></td>
            <td class="col-md"><b>تاريخ اتفاقية المشروع :</b></td>
            <td class="col-md-4">
                <asp:TextBox ID="txtE_Date" runat="server"></asp:TextBox>
                <asp:ImageButton ID="ImageButton2" runat="server" Height="25px" ImageUrl="~/images/calendarlogo1.png" />
                <asp:Calendar ID="Calendar_E_Date" runat="server"></asp:Calendar>
            </td>
        </tr>

        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>ادخل فترة المشروع :</b></td>
            <td class="col-md-3">
                <asp:TextBox ID="txt_P_Period" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="col-md-3" >
           <asp:Button ID="btn_Add" runat="server" Text="تعديل" />

            </td>
        <td class="col-md-9 " >
                <asp:Button ID="btn_Close" runat="server" Text="خروج" /></td>
        </tr>        
    </table>
  
                        </asp:Panel>
  </div>

         </div>
                  <div class="row panelrowGAPInfo">
            <asp:Panel ID="Panel2"  runat="server" Visible ="false" >
             <table class="table table-dark table-hover">
        <thead >
            <tr>
            <td> <b>مسح مشروع </b>

            </td>
        </tr>
        </thead>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b> رقم المشروع :</b></td>
            <td class="col-md-3">
                <asp:TextBox ID="txtPNo" runat="server" ReadOnly="true"   AutoPostBack="True"></asp:TextBox>

            </td>
        </tr>     
    </table>

        </asp:Panel>
         </div>


     </div>
</asp:Content>
