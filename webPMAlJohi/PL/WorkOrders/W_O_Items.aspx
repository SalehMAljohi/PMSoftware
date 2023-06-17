<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PL/shared/_MainLayout.Master" CodeBehind="W_O_Items.aspx.vb" Inherits="webPMAlJohi.W_O_Items" %>

<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container ">
        <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Settings ShowFilterRow="True" />
<SettingsCommandButton>
<ShowAdaptiveDetailButton ButtonType="Image"></ShowAdaptiveDetailButton>

<HideAdaptiveDetailButton ButtonType="Image"></HideAdaptiveDetailButton>
</SettingsCommandButton>
            <Columns>
                <dx:GridViewCommandColumn SelectAllCheckboxMode="Page" ShowClearFilterButton="True" ShowSelectCheckbox="True" VisibleIndex="0">
                </dx:GridViewCommandColumn>
                <dx:GridViewDataTextColumn FieldName="Item_no" VisibleIndex="1">
                    <SettingsHeaderFilter>
                        <DateRangePickerSettings EditFormatString="" />
                    </SettingsHeaderFilter>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="STC_Item_no" VisibleIndex="2">
                    <SettingsHeaderFilter>
                        <DateRangePickerSettings EditFormatString="" />
                    </SettingsHeaderFilter>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Item_Des" VisibleIndex="3">
                    <SettingsHeaderFilter>
                        <DateRangePickerSettings EditFormatString="" />
                    </SettingsHeaderFilter>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Item_Unit" VisibleIndex="4">
                    <SettingsHeaderFilter>
                        <DateRangePickerSettings EditFormatString="" />
                    </SettingsHeaderFilter>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Item_UPrice" VisibleIndex="5">
                    <SettingsHeaderFilter>
                        <DateRangePickerSettings EditFormatString="" />
                    </SettingsHeaderFilter>
                </dx:GridViewDataTextColumn>
            </Columns>
        </dx:ASPxGridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PMSoftwareConnectionString %>" SelectCommand="SP_GetItemsToWOrder" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    </div>
</asp:Content>
