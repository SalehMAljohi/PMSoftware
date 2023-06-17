<%@ Page Title="" Language="vb" AutoEventWireup="false" MaintainScrollPositionOnPostback ="true"  MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_SubItems.aspx.vb" Inherits="webPMAlJohi.WebFrm_SubItems" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
              <div class="container " style ="background-image :url(../../images/alj1.jpeg) ;direction :rtl;"  id="InsPInfo">
            <div class="row " style="direction:rtl;margin-right:auto;">
       <b>اضافة معلومات البند الباطن الجديد</b>
            </div>
            <div class ="row">
                 <div class="col">
<b>ادخل  رقم البند الباطن :</b>
                 </div>
                 <div class="col"> 
                    <asp:TextBox ID="txtSubItem_NO" required="true"
                   onchange="return txtSubItem_NO()" runat="server"
                   AutoPostBack="True" ></asp:TextBox> 

                </div>
           </div>
            <div class ="row">
                <div class="col">
<b>ادخل  وصف البند الباطن  :</b>
                </div>
                <div class="col"> 
           <asp:TextBox ID="txtSubItem_Descr" required="true"
                   onchange="txtSubItem_Descr()"
                   runat="server"
                 AutoPostBack="True"></asp:TextBox>        
                </div>
            </div>
            <div class ="row">
                <div class="col">
<b>ادخل وحده البند الباطن:</b>
                </div>
                <div class="col">
                    <asp:TextBox ID="txtSubItemUnit" required="true" 
                    onchange="txtSubItemUnit()" runat="server"
                     AutoPostBack="True"></asp:TextBox>
                </div>
            </div>
            <div class ="row">
                <div class="col">
<b>سعر الوحده :</b>
                </div>
                <div class="col"> 
               <asp:TextBox ID="txtSubI_UPrice" required="true" 
                    onchange="return txtSubI_UPrice()" runat="server"
                     AutoPostBack="True"></asp:TextBox>
       
                </div>
            </div>
            <div class ="row">
                <div class="col">
<b> اختار اسم مقاول الباطن :</b>
                </div>
                <div class="col"> 
                      <asp:DropDownList ID="DDLSubCon" required="true" 
                    onchange="DDLSubCon()" Width ="320px" runat="server"
                     AutoPostBack="True"></asp:DropDownList>
              </div>
            </div>
            <div class ="row">
                <div class="col">
           <asp:Button ID="btn_Add" Class="btn btn-success"   runat="server" Text="اضافة" Width="200px" />
            </div>
                <div class="col"> 
                         <asp:Button ID="btn_Close" Class="btn btn-success"
                             OnClientClick="LogOut()"
                             runat="server" Text="خروج" Width="200px" />

                </div>
               <div class="col"> 
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
            </div>       
    </div>

   
        <script >
            function txtSubItem_NO() {
                document.getElementById("txtSubItem_Descr").focus();
        }
            function txtSubItem_Descr() {
                document.getElementById("txtSubItemUnit").focus();
        }
            function txtSubItemUnit() {
                document.getElementById("txtSubI_UPrice").focus();
        }
            function txtSubI_UPrice() {
            document.getElementById("DDLSubCon").focus();
        }
            function DDLSubCon() {
            document.getElementById("btn_Add").focus();
        }
            function LogOut() {
            window.location.replace("../webFRM/WebFRM_TEST.aspx");
        }
    </script>


</asp:Content>
