<%@ Page Title="" Language="vb" AutoEventWireup="false" MaintainScrollPositionOnPostback="true"  MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_SubConWOrder.aspx.vb" Inherits="webPMAlJohi.WebFrm_SubConWOrder" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container " style ="background-image :url(../../images/alj1.jpeg) ;direction :rtl;"  id="InsPInfo">
            <div class="row " style="direction:rtl;margin-right:auto;">
<b>اضافة شاشة اومر العمل مقاول الباطن </b>
            </div>
            <div class ="row">
                 <div class="col">
<b>اختار رقم المشروع :</b>
                 </div>
                 <div class="col">   
                     <asp:DropDownList ID="DDLOPPInfoNo" Width ="200px" runat="server"
                       AutoPostBack="True"></asp:DropDownList>                     
                </div>
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
<b>اختار رقم امر العمل :</b>
                </div>
                <div class="col"> 
               <asp:DropDownList ID="DDLSubConWOrder" Width ="200px" runat="server"
                       AutoPostBack="True"></asp:DropDownList>
              </div>
            </div>
            <div class ="row">
                <div class="col">
<b>اختار  مقاول الباطن :</b>
                </div>
                <div class="col"> 
                    <asp:DropDownList ID="DDLSubCon" Width ="200px" runat="server"
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
