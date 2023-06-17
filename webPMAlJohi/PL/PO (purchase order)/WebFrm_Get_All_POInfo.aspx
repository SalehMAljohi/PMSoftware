<%@ Page Title="" Language="vb" MaintainScrollPositionOnPostback ="true"  AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="WebFrm_Get_All_POInfo.aspx.vb" Inherits="webPMAlJohi.WebFrm_Get_All_POInfo" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container " id="GAPROJINFO">
     <div class ="row">
         <h1 id="GAPROJINFOH"> ادارة وعرض جميع التعميد</h1>
     </div>
     <div class="row" id="rowSearchProjInfo">
         <div class ="col-lg-3 ">

         </div>
         <div class ="col-lg-6 ">
            <b>بحث عن تعميد</b> <asp:Button ID="Button1" Class="btn btn-danger glyphicon glyphicon-search" runat="server" Text="بحث" />
             <asp:TextBox ID="txtPInfoSearch"  runat="server" AutoPostBack="True"></asp:TextBox>
         </div>
         <div class ="col-lg-3 "></div>

     </div>
     <div class ="row" >
         <div class="col-lg-4 ">
         </div>
        <div class="col-lg-7 form-group ">
          <div class="row " >
              <div class ="col-lg-1"></div>
              <div class ="col-lg-10">
         <div class="row " >
               <div class="col-md-3 "></div>
            <div class="col-md-3"><b>اختار رقم المشروع :</b></div>
            <div class="col-md-3">
                <asp:DropDownList ID="DDLOPPInfoNo" runat="server" Width="400px" AutoPostBack="True"></asp:DropDownList>
            </div>

                     </div> 
         <div class="row " >
              <div class="col-md-3 "></div>
            <div class="col-md-3"><b>اختار رقم التعميد :</b></div>
            <div class="col-md-3">
                <asp:DropDownList ID="DDLPONO"  runat="server" Width="400px" AutoPostBack="True"></asp:DropDownList>
            </div>

                     </div> 

              </div>
              <div class ="col-lg-1"></div>

          
        </div>
        </div>
         <div class="col-lg-1 ">
         </div>

     </DIV>
     <div class ="row" >
          <div class="col-lg-3 ">
             <div class ="row " id ="btnCPOInfo">
                 <div class="col-sm-6 " >
               <asp:Button ID="btnins1" Class="btn btn-success" runat="server"  Text="اضافة تعميد" />
                 </div>
                 <div class="col-sm-6" >
               <asp:Button ID="btnupdatePOInfo" Class="btn btn-success" runat="server"  Text="تعديل تعميد" />
                 </div>
                 <div class="col-sm-6" >
               <asp:Button ID="btndeletePOInfo" Class="btn btn-success" runat="server"  Text="مسح تعميد" />
                 </div>
                 <div class="col-sm-6" >
               <asp:Button ID="btnexit" Class="btn btn-success" runat="server"  Text="خروج" />
                 </div>
             </div>
         </div>
          <div class="col-lg-8">
    <asp:GridView ID="GrdVGAPOInfo" runat="server" AllowCustomPaging="True" AutoGenerateSelectButton="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" >
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
         <Columns >
         <asp:TemplateField HeaderText="صوره التعميد">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
            </asp:GridView>
        </div>
         <div class="col-lg-1 ">
         </div>

     </DIV>

<%--     <DIV class="row panelrowGAPInfo">
            <asp:Panel ID="Panel1"  runat="server" Visible ="false" >
                <table class="table table-dark table-hover">
        <thead >
            <tr>
            <td> <b>تعديل اعتمد جديد</b>

            </td>
        </tr>
        </thead>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>تعديل رقم المشروع :</b></td>
            <td class="col-md-3">
                <asp:DropDownList ID="DDLOPPInfoNo" runat="server" Width="400px" AutoPostBack="True"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>تعديل اسم المشروع :</b></td>
            <td class="col-md-3">
                <asp:DropDownList ID="DDLOPPInfoName" runat="server" Width="400px" AutoPostBack="True"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b> رقم العتمد :</b></td>
            <td class="col-md-3">
                <asp:TextBox ID="txtPO_no" ReadOnly ="true" runat="server"
                     AutoPostBack="True" Width="400px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md"><b>تاريخ اتفاقية العتمد :</b></td>
            <td class="col-md-3">
                <asp:Calendar ID="Calendar_Date" runat="server"></asp:Calendar>
                </td> 

        </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md"><b>تاريخ بداية العتمد :</b></td>
            <td class="col-md-3">
                <asp:Calendar ID="Calendar_S_Date" runat="server"></asp:Calendar>
                </td> 

        </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>تاريخ نهاية العتمد :</b></td>
            <td class="col-md-3">
                <asp:Calendar ID="Calendar_E_Date" runat="server"></asp:Calendar>

            </td>
        </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>تعديل قيمة العتمد :</b></td>
            <td class="col-md-3">
                <asp:TextBox ID="txtPO_Value" runat="server" Width="400px"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>تعديل رئيس المشروع :</b></td>
            <td class="col-md-3">
            <asp:TextBox ID="txtPoB_Name" runat="server" AutoPostBack="True" Width="400px"></asp:TextBox>
            </td>       
             </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>تعديل استشاري المشروع :</b></td>
            <td class="col-md-3">
           <asp:TextBox ID="txtPO_C_Name" runat="server" AutoPostBack="True" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b>تعديل صور العتمد :</b></td>
            <td class="col-md-3">
                <asp:FileUpload ID="FileUpload1" runat="server" />
<asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" Width="119px" />
                <asp:Image ID="Image1" runat="server" Width="252px" Height="197px" />
            </td>
        </tr>
        <tr>
            <td class="col-md-3" >
           <asp:Button ID="btn_EDITPO" runat="server" Text="تعديل" Width="400px" />

            </td>
        <td class="col-md-9 " >
                <asp:Button ID="btn_Close" runat="server" Text="خروج" Width="400px" /></td>
        </tr>        
    </table>
        </asp:Panel>
         </div>--%>
<%--     <div class="row panelrowGAPInfo">
       <asp:Panel ID="Panel2"  runat="server" Visible ="false" >
         <table class="table table-dark table-hover">
        <thead >
            <tr>
            <td> <b>مسح التعميد </b>

            </td>
        </tr>
        </thead>
        <tr>
            <td class="col-md-3 "></td>
            <td class="col-md-3"><b> رقم التعميد :</b></td>
            <td class="col-md-3">
                <asp:TextBox ID="txtPNo" runat="server" ReadOnly="true"   AutoPostBack="True"></asp:TextBox>

            </td>
        </tr>     
    </table>

        </asp:Panel>
         </div>--%>


     </div>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/Style.css" rel="stylesheet" />
        <script src="../../Scripts/jquery.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            right: 0px;
            top: 0px;
        }
    </style>
</asp:Content>

