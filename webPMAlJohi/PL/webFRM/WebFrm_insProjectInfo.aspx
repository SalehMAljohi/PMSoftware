<%@ Page Title="" Language="vb" MaintainScrollPositionOnPostback ="true"  AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_insProjectInfo.aspx.vb" Inherits="webPMAlJohi.WebFrm_insProjectInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container " style ="background-image :url(../../images/alj1.jpeg) ;direction :rtl;"  id="InsPInfo">
            <div class="row " style="direction:rtl;margin-right:auto;">
                                      <b>اضافة مشروع جديد</b>
             </div>
            <div class ="row">
                 <div class="col">
                    <b>ادخل اسم المشروع :</b>
                  </div>
                <div class="col"> 
                    <asp:TextBox ID="txtP_Name" onchange="return txtP_Name()" required="true"
                        placeholder="اسم المشروع"  class="" runat="server" AutoPostBack="True"></asp:TextBox>
                </div>
           </div>
            <div class ="row">
                <div class="col">
                  <b>ادخل اسم مدير المشروع(STC) :</b>
               </div>
                <div class="col"> 
          <asp:TextBox ID="txtP_M_Name" onchange="return txtP_M_Name()" required="true" 
            placeholder="اسم مدير المشروع(STC)"  class="" runat="server" AutoPostBack="True"></asp:TextBox>

                </div>
            </div>
            <div class ="row">
                <div class="col">
                   <b>ادخل جوال مدير المشروع(STC) :</b>
                </div>
                <div class="col"> 
           <asp:TextBox ID="txtP_M_Phone" onchange="return txtP_M_Phone()" required="true"
               placeholder="جوال مدير المشروع(STC)" onkeypress="return validatenumerics(event);" 
               class="" runat="server" AutoPostBack="True"></asp:TextBox>
         
                </div>
            </div>
            <div class ="row">
                <div class="col">
                <b>تاريخ اتفاقية المشروع :</b>
            </div>
                <div class="col"> 
              
                <asp:TextBox  ID="txtE_Date" onchange="return txtE_Date()" placeholder="تاريخ اتفاقية المشروع" runat="server"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1"  Height="25px" runat="server" ImageUrl="~/images/calendarlogo1.png" Width="25px"  />
                <asp:Calendar ID="Calendar_E_Date" Visible="false"   runat="server"></asp:Calendar>
       
                </div>
            </div>
            <div class ="row">
                <div class="col">
                  <b>تاريخ بداية المشروع :</b>
                </div>
                <div class="col"> 
               <asp:TextBox ID="txtS_Date" onchange="return txtS_Date()"  placeholder="تاريخ بداية المشروع" runat="server">
                </asp:TextBox><asp:ImageButton ID="ImageButton2"  runat="server" ImageUrl="~/images/calendarlogo1.png" Width="25px" />
                <asp:Calendar ID="Calendar_S_Date"  runat="server"></asp:Calendar>
              </div>
            </div>
            <div class ="row">
                <div class="col">
                    <b>ادخل فترة المشروع :</b>
                </div>
                <div class="col"> 
            <asp:TextBox ID="txt_P_Period" onchange="return txt_P_Period()" 
           onkeypress="return validatenumerics(event);" 
                placeholder="فترة المشروع" class="" runat="server"></asp:TextBox>شهر
     </div>
            </div>
            <div class ="row">
                <div class="col">
                    <b>ادخل ملف عقد المشروع :</b>
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
        function txtP_NO() {
            document.getElementById("txtP_Name").focus();
            return false;
        }
        function txtP_Name() {
            document.getElementById("txtP_M_Name").focus();
            return false;
        }
        function txtP_M_Name() {
            document.getElementById("txtP_M_Phone").focus();
            return false;
        }
        function txtP_M_Phone() {
            document.getElementById("txtE_Date").focus();
            return false;
        }
        function txtE_Date() {
            document.getElementById("txtS_Date").focus();
            return false;
          }
        function txtS_Date() {
            document.getElementById("txt_P_Period").focus();
            return false;
          }
        function txt_P_Period() {
            document.getElementById("FileUpload1").focus();
            return false;
          }
        function LogOut() {
            window.location.replace("../webFRM/WebFRM_TEST.aspx");
            return false;
        }
    </script>
</asp:Content>
