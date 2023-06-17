<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="register.aspx.vb" Inherits="webPMAlJohi.register" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <div class="container " style ="background-image :url(../images/alj1.jpeg) ;direction :rtl;"  id="InsPInfo">
            <div class="row " style="direction:rtl;margin-right:auto;">
                                      <b>اضافة مستخدم جديد</b>
             </div>
            <div class ="row">
                 <div class="col">
                    <b>ادخل اسم المستخدم :</b>
                  </div>
                <div class="col"> 
                    <asp:TextBox ID="txtU_Name" onchange="return txtU_Name()" required="true"
                        placeholder="اسم المستخدم"  class="" runat="server" AutoPostBack="True"></asp:TextBox>
                </div>
           </div>
            <div class ="row">
                <div class="col">
                   <b>ادخل كلمة السر:</b>
                </div>
                <div class="col"> 
           <asp:TextBox ID="txtPWRD" onchange="return txtPWRD()" required="true"
               placeholder="ادخل كلمة السر" onkeypress="return validatenumerics(event);" 
               class="" runat="server" AutoPostBack="True"></asp:TextBox>
         
                </div>
            </div>
            <div class ="row">
                <div class="col">
                <b>تاكيد كلمة السر:</b>
            </div>
                <div class="col"> 
              
                <asp:TextBox  ID="txtUPWRD_CONF" onchange="return txtUPWRD_CONF()" placeholder="تاكيد كلمة السر" runat="server"></asp:TextBox>
       
                </div>
            </div>
           
            <div class ="row">
                <div class="col">
           <asp:Button ID="btn_Add" Class="btn btn-success" runat="server" Text="اضافة" />
            </div>
                <div class="col"> 
          <asp:Button ID="btn_Close" onClientclick="return LogOut()" runat ="server"  
           Class="btn btn-success" 
            Text ="خروج" />
                </div>
            <div class="col"> 
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
            </div>       
    </div>
    <script >
        function txtU_Name() {
            document.getElementById("txtPWRD").focus();
            return false;
        }
        function txtPWRD()
        {
            var str = document.getElementById("txtPWRD").VALUE
            if(str.count < 6)
                   {
                document.getElementById("txtUPWRD_CONF").focus();
                return false;
                   }
            else
            {
                alert("يجب ان يكون اكثرمن 6")
                document.getElementById("txtPWRD").focus();
                return false;
            }
        }
        function txtUPWRD_CONF()
        {
            if (document.getElementById("txtUPWRD_CONF").value == document.getElementById("txtPWRD").value)
            {
                document.getElementById("btn_Add").focus();
                return false;
            }
            else
            {
                alert("تاكيد كلمة المرور")
                document.getElementById("txtUPWRD_CONF").focus();
                return false;
            }
        }
        function LogOut() {
            window.location.replace("~/webFRM/WebFRM_TEST.aspx");
            return false;
        }
    </script>

</asp:Content>
