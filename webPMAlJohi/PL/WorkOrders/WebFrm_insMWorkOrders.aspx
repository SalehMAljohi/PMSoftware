<%@ Page Title="" Language="vb" AutoEventWireup="false" MaintainScrollPositionOnPostback ="true"  MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_insMWorkOrders.aspx.vb" Inherits="webPMAlJohi.WebFrm_insMWorkOrders" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container " style ="background-image :url(../../images/alj1.jpeg) ;direction :rtl;"  id="InsPInfo">
            <div class="row " style="direction:rtl;margin-right:auto;">
                <b>اضافة شاشة اومر العمل الرئيسية </b>
            </div>
            <div class ="row">
                 <div class="col">
<b>اختار رقم التعميد :</b>
                 </div>
                 <div class="col"> 
                     <asp:DropDownList ID="DDLPONO" Width ="200px" runat="server"
                       AutoPostBack="True"></asp:DropDownList>   
                </div>
           </div>
            <div class ="row">
                <div class="col">
<b>تاريخ بداية امر العمل :</b>
                </div>
                <div class="col"> 
                <asp:TextBox ID="txtS_Date"  placeholder="تاريخ بداية امر العمل" runat="server">
                </asp:TextBox><asp:ImageButton ID="ImageBut2"  runat="server" ImageUrl="~/images/calendarlogo1.png" Width="25px" />
                <asp:Calendar ID="Calendar_S_Date"  runat="server" Visible="False"></asp:Calendar>
                </div>
            </div>
            <div class ="row">
                <div class="col">
<b>تاريخ نهاية امر العمل :</b>
                </div>
                <div class="col"> 
                    <asp:TextBox ID="txtE_Date" placeholder="تاريخ نهاية امر العمل :" runat="server"></asp:TextBox>
                <asp:ImageButton ID="ImageBut3" runat="server" Height="25px" ImageUrl="~/images/calendarlogo1.png" />
                <asp:Calendar ID="Calendar_E_Date" runat="server" Visible="False"></asp:Calendar>
              </div>
            </div>
            <div class ="row">
                <div class="col">
<b>ادخل ملفات وسندات العقد :</b>
                </div>
                <div class="col"> 
                      <asp:FileUpload ID="FileUpload1" runat="server" />

     </div>
            </div>
               <div class ="row">
               <div class="col">
           <asp:Button ID="btnAddFRomExcil" Class="btn btn-success" runat="server"
               Text="اضغط هنالاختيار بنود امر العمل "  onClientclick="return btnAddFRomExcil();"/>
            </div>
            </div>    
            <div class ="row">
                <div class="col">
           <asp:Button ID="btn_Add" Class="btn btn-success" runat="server" Text="اضافة" Width="200px" />
            </div>
                <div class="col"> 
                          <asp:Button ID="btn_Close"  Class="btn btn-success" runat="server"
                     onClientclick="LogOut()"
                     Text="خروج" Width="200px" />

                </div>
                <div class="col"> 
              <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
            </div>       
    </div>
    <script >
        function LogOut() {
            window.location.replace("../webFRM/WebFRM_TEST.aspx");
        }
        function btnAddFRomExcil() {
            window.location.replace("../WorkOrders/W_O_Items.aspx");
            return false;
        }
    </script>
</asp:Content>
