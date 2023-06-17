<%@ Page Title="" Language="vb" AutoEventWireup="false" MaintainScrollPositionOnPostback ="true"  MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_MainItems.aspx.vb" Inherits="webPMAlJohi.WebFrm_MainItems" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <div class="container " style ="background-image :url(../../images/alj1.jpeg) ;direction :rtl;"  id="InsPInfo">
            <div class="row " style="direction:rtl;margin-right:auto;">
<b>اضافة معلومات البند الرئيسية الجديد</b>
            </div>
      <%-- <div class ="row">
                 <div class="col">
<b>اختار رقم التعميد :</b>

                 </div>
                <div class="col"> 
                    <asp:DropDownList ID="DDLPONO" onchange="return DDLPONO()" 
                        REQUIRED="true"  Width ="200px" runat="server"
                       AutoPostBack="True"></asp:DropDownList>

                </div>
           </div>--%>
<%--            <div class ="row">
                <div class="col">
        <b>ادخل  رقم البند الرئيسي :</b>
                </div>
                <div class="col"> 
           <asp:TextBox ID="txtItem_NO" onchange="return txtItem_NO()" runat="server" required="true"
                   AutoPostBack="True" ></asp:TextBox>      
                </div>
            </div>--%>
            <div class ="row">
                <div class="col">
<b>ادخل  رقم (stc)البند الرئيسي :</b>
                </div>
                <div class="col"> 
         <asp:TextBox ID="txtitem_STCNo" onchange="return txtitem_STCNo()" runat="server" required="true"
                     AutoPostBack="True"></asp:TextBox>
                </div>
            </div>
            <div class ="row">
                <div class="col">
<b>ادخل  وصف البند الرئيسي  :</b>

                </div>
                <div class="col"> 
              <asp:TextBox ID="txtItem_Descr" onchange="return txtItem_Descr()"  runat="server" 
                  required="true"  AutoPostBack="True"></asp:TextBox> 
       
                </div>
            </div>
            <div class ="row">
                <div class="col">
<b>ادخل  وحده البند :</b>

                </div>
                <div class="col"> 
                    <asp:TextBox ID="txtUnit" onchange="return txtUnit()" runat="server"
                        required="true" AutoPostBack="True"></asp:TextBox>
              </div>
            </div>
           <%-- <div class ="row">
                <div class="col">
           <b>سعر الوحده :</b>

                </div>
                <div class="col"> 
           <asp:TextBox ID="txtI_UPrice" onchange="return txtI_UPrice()" runat="server"
               required="true"  AutoPostBack="True"></asp:TextBox>
     </div>
            </div>--%>
           <%-- <div class ="row">
                <div class="col">
                    <b>ادخل ملف عقد المشروع :</b>
               </div>
                <div class="col"> 
                <asp:FileUpload ID="FileUpload1" runat="server" />
                </div>
            </div>--%>
               <div class ="row">
               <div class="col">
           <asp:Button ID="btnAddFRomExcil" Class="btn btn-success" runat="server"
               Text="اضغط هنا لاضافة البنود الجديدة من اكسل"  onClientclick="return btnAddFRomExcil()"  />
            </div>
            </div>       
            <div class ="row">
               <div class="col">
           <asp:Button ID="btn_Add" Class="btn btn-success" runat="server" Text="اضافة" Width="200px" />
            </div>
               <div class="col"> 
         <asp:Button ID="btn_Close"  Class="btn btn-success" runat="server"
                     onClientclick="return LogOut()"
                     Text="خروج" Width="200px" />
                </div>
               <div class="col"> 
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
            </div>       
    </div>
          <script >
        //function DDLPONO() {
        //    document.getElementById("txtitem_STCNo").focus();
        //    return false;
        //}
        //function txtItem_NO() {
        //    document.getElementById("txtitem_STCNo").focus();
        //}
        function txtitem_STCNo() {
            document.getElementById("txtItem_Descr").focus();
            return false;
        }
        function txtItem_Descr() {
            document.getElementById("txtUnit").focus();
            return false;
        }
        function txtUnit() {
            document.getElementById("btn_Add").focus();
            return false;
        }
        //function txtUnit() {
        //    document.getElementById("btn_Add").focus();
        //}
        function LogOut() {
            window.location.replace("../webFRM/WebFRM_TEST.aspx");
            return false;
              }
              function btnAddFRomExcil(){
                  window.location.replace("../items/ImportItems.aspx");
                  return false;
              }
          </script>
</asp:Content>
