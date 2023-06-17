<%@ Page Title="" Language="vb" MaintainScrollPositionOnPostback ="true"  AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_insPOInfo.aspx.vb" Inherits="webPMAlJohi.WebFrm_insPOInfo" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <div class="container " style ="background-image :url(../../images/alj1.jpeg) ;direction :rtl;"  id="InsPInfo">
            <div class="row " style="direction:rtl;margin-right:auto;">
<b>اضافة تعميد جديد</b>
            </div>
            <div class ="row">
                 <div class="col">
<b>اختار رقم المشروع :</b>
                 </div>
                 <div class="col"> 
                    <asp:DropDownList ID="DDLOPPInfoNo"  onchange="return DDLOPPInfoNo()" 
                        required="true" Width ="200px" runat="server"
                       AutoPostBack="True"></asp:DropDownList>   
                </div>
           </div>
            <div class ="row">
                <div class="col">
<b>تاريخ اتفاقية التعميد :</b>
                </div>
                <div class="col"> 
                 <asp:TextBox ID="txt_Date"  onchange="txt_Date()" placeholder=" اتفاقية التعميد" runat="server">
                </asp:TextBox><asp:ImageButton ID="ImageButton1"  runat="server"
                    ImageUrl="~/images/calendarlogo1.png" Width="25px" />
                <asp:Calendar ID="Calendar_Date"  runat="server" Visible="False"></asp:Calendar>
       
                </div>
            </div>
            <div class ="row">
                <div class="col">
<b>تاريخ بداية التعميد :</b>
                </div>
                <div class="col"> 
                <asp:TextBox ID="txtS_Date"  onchange="txtS_Date()" placeholder=" بداية التعميد" runat="server">
                </asp:TextBox><asp:ImageButton ID="ImageButton2"  runat="server" ImageUrl="~/images/calendarlogo1.png" Width="25px" />
                <asp:Calendar ID="Calendar_S_Date"  runat="server" Visible="False"></asp:Calendar>
              </div>
            </div>
            <div class ="row">
                <div class="col">
<b>تاريخ نهاية التعميد :</b>
                </div>
                <div class="col"> 
             <asp:TextBox ID="txtE_Date"  onchange="txtE_Date()" placeholder=" نهاية التعميد" runat="server">
                </asp:TextBox><asp:ImageButton ID="ImageButton3"  runat="server" ImageUrl="~/images/calendarlogo1.png" Width="25px" />
                <asp:Calendar ID="Calendar_E_Date"  runat="server" Visible="False"></asp:Calendar>
     </div>
            </div>

            <div class ="row">
                <div class="col">
<b>ادخل قيمة التعميد :</b>
                </div>
                <div class="col"> 
                <asp:TextBox ID="txtPO_Value"  onchange="txtPO_Value()"  
                    onkeypress="return validatenumerics(event);" placeholder="قيمة التعميد" 
                    runat="server"></asp:TextBox>
                </div>
            </div>
               <div class ="row">
                <div class="col">
<b>ادخل ملفات وسندات التعميد :</b>

                </div>
                <div class="col"> 
                         <asp:FileUpload ID="FileUpload1" runat="server" />
                </div>
            </div>
               <%--<div class ="row">
               <div class="col">
           <asp:Button ID="btnAddFRomExcil" Class="btn btn-success" runat="server"
               Text="اضغط هنا لربط البنود بتعميد من اكسل"  onClientclick="return btnAddFRomExcil();"/>
            </div>
            </div>    --%>
            <div class ="row">
                <div class="col">
           <asp:Button ID="btn_Add" Class="btn btn-success" runat="server" Text="اضافة" Width="200px"  />
            </div>
                <div class="col"> 
                         <asp:Button ID="btn_Close" OnClientClick ="return LogOut();"
                             Class="btn btn-success" runat="server"
                             Text="خروج" Width="200px" />

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
                
                //function txtPO_no() {
                //    document.getElementById("txt_Date").focus();
                //                   }
                function txt_Date() {
                    document.getElementById("txtS_Date").focus();
                    return false;
                }
                function txtS_Date() {
                //document.getElementById("txtE_Date").required =true;
                    document.getElementById("txtE_Date").focus();
                    return false;
                              }
                function txtE_Date() {
                //document.getElementById("txtPO_Value").required = true;
                    document.getElementById("txtPO_Value").focus();
                    return false;
                                  }
            function txtPO_Value() {
                document.getElementById("FileUpload1").focus();
                return false;
                                 }       
            function LogOut() {
                window.location.replace("../webFRM/WebFRM_TEST.aspx");
                return false;
                }
                function btnAddFRomExcil() {
                    window.location.replace("../PO (purchase order)/PO_Items.aspx");
                   //document.getElementById("btn_Add").Enable = true;
                    return false;
                }
    </script>

</asp:Content>