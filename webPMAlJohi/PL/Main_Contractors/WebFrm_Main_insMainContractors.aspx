<%@ Page Title="" Language="vb" MaintainScrollPositionOnPostback ="true"  AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_Main_insMainContractors.aspx.vb" Inherits="webPMAlJohi.WebFrm_Main_insMainContractors" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <div class="container " style ="background-image :url(../../images/alj1.jpeg) ;
          direction :rtl;"  id="InsPInfo">
            <div class="row " style="direction:rtl;margin-right:auto;">
 <b>اضافة معلومات المقاول الرئيسي </b>        
            </div>
            <div class ="row">
                <div class="col">
<b>اختار اسم المشروع :</b>

                 </div>
                <div class="col">                
                    <asp:DropDownList ID="DDLPInfoNo" runat="server" Width="400px" 
                    AutoPostBack="True" required="true"></asp:DropDownList>

                </div>
           </div>
            <div class ="row">
                <div class="col">
<b>اختار اسم المؤسسة :</b>

                </div>
                <div class="col"> 
                        <asp:DropDownList ID="DDLComNo" runat="server" Width="400px" 
                            AutoPostBack="True" required="true"></asp:DropDownList>
   </div>
            </div>
            <div class ="row">
                <div class="col">
<b>ادخل اسم المقاول الرئيسي :</b>

                </div>
                <div class="col"> 
                      <asp:TextBox ID="txtMCon_Name" OnChanged =" return txtMCon_Name()"
                          placeholder="اسم المقاول الرئيسي"  class=""
                required="true" runat="server" AutoPostBack="True"></asp:TextBox>
            </div>
            </div>
            <div class ="row">
                <div class="col">
<b>ادخل عنوان المقاول الرئيسي :</b>

                </div>
                <div class="col">                   
                   <asp:TextBox ID="txtMCon_Address"  OnChanged ="return txtMCon_Address()" 
                       placeholder="عنوان المقاول الرئيسي"  class="" required="true"  
                       runat="server" AutoPostBack="True"></asp:TextBox>

                </div>
            </div>
            <div class ="row">
                <div class="col">
<b>ادخل جوال المقاول الرئيسي :</b>

                </div>
                <div class="col"> 
               <asp:TextBox ID="txtMCon_Mobile" OnChanged ="return txtMCon_Mobile()" 
                   placeholder="جوال المقاول الرئيسي" 
         required="true" onkeypress="return validatenumerics(event);" 
                   class="" runat="server" AutoPostBack="True"></asp:TextBox>
            </div>
            </div>
            <div class ="row">
                <div class="col">
<b>ادخل رقم اقامة المقاول الرئيسي :</b>

                </div>
                <div class="col"> 
          <asp:TextBox ID="txtMCon_RP" OnChanged =" reterun txtMCon_RP()" placeholder="رقم اقامة المقاول الرئيسي"  
         required="true" onkeypress="return validatenumerics(event);" 
              class="" runat="server" AutoPostBack="True"></asp:TextBox>
        </div>
            </div>
            <div class ="row">
                <div class="col">
<b>ادخل مستندات المقاول الرئيسي :</b>

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
                 <asp:Button ID="btn_Close" Class="btn btn-success" 
                     OnClientClick ="reterun logout()" 
                     runat="server" Text="خروج" />

                </div>
            <div class="col"> 
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
            </div>       
    </div>
     <script >
        function validatenumerics(key) {
            //getting key code of pressed key
            var keycode = (key.which) ? key.which : key.keyCode;
            //comparing pressed keycodes

            if (keycode > 31 && (keycode < 48 || keycode > 57)) {
                alert(" فضلا ادخل ارقام");
                return false;
            }
            else return true;


        }
         function txtMCon_Name() {
             document.getElementById("txtMCon_Address").focus();
             return false;
        }
         function txtMCon_Address() {
             document.getElementById("txtMCon_Mobile").focus();
             return false;
        }
         function txtMCon_Mobile() {
             document.getElementById("txtMCon_RP").focus();
             return false;
        }
 
         function txtMCon_RP() {
             document.getElementById("FileUpload1").focus();
             return false;
          }
        function LogOut() {
            window.location.replace("../webFRM/WebFRM_TEST.aspx");
            return false;
        }
    </script>

</asp:Content>
