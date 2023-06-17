<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="ImportItems.aspx.vb" Inherits="webPMAlJohi.ImportItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container " style ="background-image :url(../../images/alj1.jpeg) ;
           direction :rtl;"  id="InsPInfo">
             <div class="row " style="direction:rtl;margin-right:auto;">
                                       <b>اضافة البنود  الجديدة من ملف اكسل</b>
             </div>
             <div class ="row">
                <div class="col">
             <b>اختار ملف البنود :</b>

            </div>
                <div class="col"> 
                             <asp:FileUpload ID="FileUpload1" runat="server" />

                </div>
            </div>
             <div class ="row">
                <div class="col">
           <asp:Button ID="btn_Add" Class="btn btn-success"  runat="server" Text=" اضافة البنود الى قاعدة البيانات "  />

            </div>
                <div class="col"> 
                <asp:Button ID="btn_Close" OnClientClick ="return LogOut();" Class="btn btn-success" runat="server" Text="خروج" Width="200px" />
                </div>
            <div class="col"> 
                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
            </div>       
    </div>
            <script >
            function LogOut() {
                window.location.replace("../webFRM/WebFRM_TEST.aspx");
                return false;
                               }
    </script>
</asp:Content>
