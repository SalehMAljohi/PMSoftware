<%@ Page Title="" Language="vb" MaintainScrollPositionOnPostback="true"   AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_insSubConContract.aspx.vb" Inherits="webPMAlJohi.WebFrm_insSubConContract" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
               <div class="container " style ="background-image :url(../../images/alj1.jpeg) ;direction :rtl;"  id="InsPInfo">
            <div class="row " style="direction:rtl;margin-right:auto;">
 <b>اضافة شاشة التعاقد مع مقاول الباطن </b>

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
<b>اختار رقم مقاول الباطن :</b>

                </div>
                <div class="col"> 
               <asp:DropDownList ID="DDLSubCon_No" Width ="200px" runat="server"
                       AutoPostBack="True"></asp:DropDownList>
              </div>
            </div>
            <div class ="row">
                <div class="col">
<b>ادخل قيمة التعميد مقاول الباطن :</b>

                </div>
                <div class="col"> 
           <asp:TextBox ID="txtsubconC_no"  placeholder="قيمة التعميد" runat="server"></asp:TextBox>

     </div>
            </div>
            <div class ="row">
                <div class="col">
<b>تاريخ اتفاق العقد :</b>

                </div>
                <div class="col"> 
                <asp:TextBox ID="txtDate"  placeholder="تاريخ اتفاق العقد" runat="server">
                </asp:TextBox><asp:ImageButton ID="Imagebut1"  runat="server" 
                    ImageUrl="~/images/calendarlogo1.png" Width="25px" />
              <asp:Calendar ID="Calendar_Date"  runat="server" Visible="False"></asp:Calendar>   
                </div>
            </div>
                   <div class ="row">
                <div class="col">
<b>تاريخ بداية العقد :</b>
                </div>
                <div class="col"> 
                <asp:TextBox ID="txtS_Date"  placeholder="تاريخ بداية العقد" runat="server">
                </asp:TextBox><asp:ImageButton ID="ImageBut2"  runat="server" 
                    ImageUrl="~/images/calendarlogo1.png" Width="25px" />
                <asp:Calendar ID="Calendar_S_Date"  runat="server" Visible="False"></asp:Calendar>   
                </div>
            </div>
                                  <div class ="row">
                <div class="col">
<b>تاريخ نهاية العقد :</b>

                </div>
                <div class="col"> 
                 <asp:TextBox ID="txtE_Date" placeholder="تاريخ نهاية العقد :" runat="server"></asp:TextBox>
                <asp:ImageButton ID="ImageBut3" runat="server" Height="25px"
                    ImageUrl="~/images/calendarlogo1.png" />
                <asp:Calendar ID="Calendar_E_Date" runat="server" Visible="False"></asp:Calendar>  
                </div>
            </div>
               <div class ="row">
                <div class="col">
<b>ادخل قيمة التعميد مقاول الباطن :</b>
                </div>
                <div class="col"> 
                <asp:TextBox ID="txtSubCon_Value"  onchange="txtPO_Value()" placeholder="قيمة التعميد"
                    runat="server"></asp:TextBox>
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
    </script>

</asp:Content>
