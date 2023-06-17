<%@ Page Title="" Language="vb" MaintainScrollPositionOnPostback ="true"  AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_SubContractorInfo.aspx.vb" Inherits="webPMAlJohi.WebFrm_SubContractorInfo" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
               <div class="container " style ="background-image :url(../../images/alj1.jpeg) ;direction :rtl;"  id="InsPInfo">
            <div class="row " style="direction:rtl;margin-right:auto;">
<b>اضافة معلومات عن مقاول الباطن جديد</b>

            </div>
            <div class ="row">
                 <div class="col">
<b>ادخل  اسم مقاول الباطن :</b> 
    </div>
                 <div class="col"> <asp:TextBox ID="txtSubCon_Name" required="true" 
                   onchange="return txtSubCon_Name()" runat="server"
                 AutoPostBack="True" ></asp:TextBox>                      
                </div>
           </div>
            <div class ="row">
                <div class="col">
<b>ادخل  رقم هاتف مقاول الباطن :</b> 
    </div>
                <div class="col"> 
                 <asp:TextBox ID="txtSubCon_PhoneNo" required="true" onkeypress="return validatenumerics(event);" 
                     onchange="return txtSubCon_PhoneNo()" runat="server"
                     AutoPostBack="True" ></asp:TextBox>
       
                </div>
            </div>
            <div class ="row">
                <div class="col">
<b>ادخل عنوان مقاول الباطن  :</b>
    </div>
                <div class="col"> 
               <asp:TextBox ID="txtSubCon_P_Address" required="true" onchange="return txtSubCon_P_Address()" runat="server"
                     AutoPostBack="True" ></asp:TextBox>
              </div>
            </div>
            <div class ="row">
                <div class="col">
<b>ادخل رقم اقامة مقاول الباطن   :</b>

                </div>
                <div class="col"> <asp:TextBox ID="txtSubCon_RP_No" required="true" 
                    onchange="return txtSubCon_RP_No()" runat="server"
                     AutoPostBack="True" ></asp:TextBox>
     </div>
            </div>

            <div class ="row">
                <div class="col">
<b>ادخل عنوان مؤسسة مقاول الباطن  :</b>
                </div>
                <div class="col"> 
                <asp:TextBox ID="txtcom_address" required="true"
                    onchange="return txtcom_address()" runat="server"
                     AutoPostBack="True" ></asp:TextBox>
                </div>
            </div>
            <div class ="row">
                <div class="col">
<b>اختار رقم البند الرئيسي :</b>
                </div>
                <div class="col"> 
 <asp:DropDownList ID="DDLItem" required="true" 
     Width ="200px" runat="server"
                       AutoPostBack="True">
                </asp:DropDownList>           

                </div>
            </div>

               <div class ="row">
                <div class="col">
<b>ادخل ملفات وسندات مقاول الباطن :</b>
                </div>
                <div class="col"> 
                <asp:FileUpload ID="FileUpload1" runat="server" />
                </div>
            </div>
            <div class ="row">
                <div class="col">
           <asp:Button ID="btn_Add" Class="btn btn-success" runat="server" Text="اضافة" Width="200px" />
            </div>
                <div class="col"> 
             <asp:Button ID="btn_Close" Class="btn btn-success" OnClientClick ="LogOut()" 
                 runat="server" Text="خروج" Width="200px" />


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
          function txtSubCon_NO() {
             document.getElementById("txtSubCon_Name").focus();

        }
          function txtSubCon_Name() {
              document.getElementById("txtSubCon_PhoneNo").focus();
        }
          function txtSubCon_PhoneNo() {
              document.getElementById("txtSubCon_P_Address").focus();
        }
          function txtSubCon_P_Address() {
              document.getElementById("txtSubCon_RP_No").focus();
        }
          function txtSubCon_RP_No() {
              document.getElementById("txtcom_address").focus();
          }
          function txtcom_address() {
              document.getElementById("DDLItem").focus();
          }
          function DDLItem() {
              document.getElementById("FileUpload1").focus();
          }
          function LogOut() {
            window.location.replace("../webFRM/WebFRM_TEST.aspx");
        }
    </script>
</asp:Content>

