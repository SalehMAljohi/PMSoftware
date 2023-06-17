<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_insCompanyInfo.aspx.vb" Inherits="webPMAlJohi.WebFrm_insCompanyInfo" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container " style ="background-image :url(../../images/alj1.jpeg) ;direction :rtl;"  id="InsPInfo">
            <div class="row " style="direction:rtl;margin-right:auto;">
<b>اضافة معلومات المؤسسة </b>

            </div>
            <div class ="row">
                <div class="col">
          <b>ادخل اسم المؤسسة :</b>
                 </div>
                <div class="col">            
                  <asp:TextBox ID="txtCom_Name"  onchange="return txtCom_Name()" 
                      placeholder="اسم المؤسسة"    runat="server" AutoPostBack="True" 
                      required="true"></asp:TextBox>

                </div>
           </div>
            <div class ="row">
                <div class="col">
<b>ادخل عنوان المؤسسة :</b>
                </div>
                <div class="col"> 
              <asp:TextBox ID="txtCom_Address" onchange="return txtCom_Address()" 
                  placeholder="عنوان المؤسسة"   runat="server" AutoPostBack="True" 
                  required="true"></asp:TextBox>
                </div>
            </div>
            <div class ="row">
                <div class="col">
<b>ادخل ملفات و مستندات المؤسسة :</b>

                </div>
                <div class="col"> 
                <asp:FileUpload ID="FileUpload1" runat="server" />
                </div>
            </div>
            <div class ="row">
                <div class="col">
           <asp:Button ID="btn_Add" Class="btn btn-success" runat="server" Text="اضافة" />
            </div>
                <div class="col"> 
                     <asp:Button ID="btn_Close" Class="btn btn-success" runat="server" 
                         onClientclick="return LogOut()" Text="خروج"   />

                </div>
            <div class="col"> 
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
            </div>       
    </div>
    <script>
        function txtCom_Name() {
            document.getElementById("txtCom_Address").focus();
            return false;
        }
        function txtCom_Address() {
            document.getElementById("FileUpload1").focus();
            return false;
        }
        function LogOut() {
            window.location.replace("../webFRM/WebFRM_TEST.aspx");
            return false;
        }
    </script> 
</asp:Content>
