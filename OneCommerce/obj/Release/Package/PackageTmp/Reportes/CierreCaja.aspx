﻿<%@ Page Title="Cierre de Caja" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="CierreCaja.aspx.cs" Inherits="OneCommerce.Reportes.CierreCaja" %>
<asp:Content ID="cttMain" ContentPlaceHolderID="MainContent" runat="server">
<%--<script type="text/javascript" src="../Scripts/Jquerys/jquery-1.10.2.js"></script>
<script type="text/javascript" src="../Scripts/Jquerys/jquery-1.10.2.min.js"></script>--%>
<script type="text/javascript" src="../Scripts/Jquerys/jquery-2.1.4.js"></script>
<script type="text/javascript" src="../Scripts/Linq/linq.js"></script>
<script type="text/javascript" src="../Scripts/Linq/linq-min.js"></script>
<script type="text/javascript" src="../Scripts/Reports/JSGeneral.js"></script>
<script type="text/javascript" src="../Scripts/Reports/Report.js"></script>
<script type="text/javascript" src="../Scripts/Jquerys/Sunat.js"></script>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.1/css/all.css" integrity:"sha384-50oBUHEmvpQ+1lW4y57PTFmhCaXp0ML5d60M1M7uH2+nqUivzIebhndOJK28anvf" crossorigin:"anonymous">

    <dx:ASPxFormLayout runat="server" ID="frlMain" 
        RequiredMarkDisplayMode="None" EnableViewState="False" EnableTabScrolling="true">
        <Items>
            <dx:LayoutGroup Caption="Cierre de Caja" 
                SettingsItemHelpTexts-Position="Bottom" 
                GroupBoxDecoration="HeadingLine">
                <Items>
                    <dx:LayoutItem Caption="Datos Generales" ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="licMain" runat="server" 
                                SupportsDisabledAttribute="True">
                                <table class="tablespace" style="width:100%;">
                                    <tr>
                                        <td style="width:150px">
                                            Fecha Contable:</td>
                                        <td style="width:150px">
                                            <dx:ASPxDateEdit ID="dteDateIn" runat="server" Width="100%" ClientInstanceName="dteDateIn">
                                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" 
                                                    ErrorText="Fecha Incorrecta" SetFocusOnError="True" ValidationGroup="ValEdit">
                                                    <RegularExpression ErrorText="" />
                                                    <RequiredField IsRequired="True" />
                                                </ValidationSettings>
                                                <ClientSideEvents DateChanged="Set_DateChange" />
                                            </dx:ASPxDateEdit>
                                        </td>
                                        <td style="width:150px">
                                            <dx:ASPxDateEdit ID="dteDateFi" runat="server" Width="100%" ClientInstanceName="dteDateFi">
                                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" 
                                                    ErrorText="Fecha Incorrecta" SetFocusOnError="True" ValidationGroup="ValEdit">
                                                    <RequiredField IsRequired="True" />
                                                </ValidationSettings>
                                            </dx:ASPxDateEdit>
                                        </td>
                                        <td style="width:100px">
                                            <dx:ASPxButton ID="btnSearch" runat="server" AutoPostBack="False" Text="Buscar" 
                                                Width="100%" >
                                                <ClientSideEvents Click="SearchCloseBox" />
                                            </dx:ASPxButton>
                                        </td>
                                        <td style="width:100px">
                                            <dx:ASPxButton ID="btnExport" runat="server" AutoPostBack="False" Text="Exportar" 
                                                Width="100%" OnClick="btnExport_Click">
                                            </dx:ASPxButton>
                                        </td>
                                        <td style="width:400px">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <table cellpadding:"0" cellspacing:"0" style="width:100%;">
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="gdvData" runat="server" AutoGenerateColumns="False" 
                                                            ClientInstanceName="gdvData" Width="1060px" 
                                                            OnCustomCallback="gdvData_CustomCallback" OnDataBinding="gdvData_DataBinding">
                                                            <TotalSummary>
                                                                <dx:ASPxSummaryItem DisplayFormat="c2" FieldName="FT_TOTAL" 
                                                                    ShowInGroupFooterColumn="TOTAL DOCUMENTO" SummaryType="Sum" />
                                                                <dx:ASPxSummaryItem DisplayFormat="c2" FieldName="MontoPagado" 
                                                                    ShowInGroupFooterColumn="TOTAL PAGADO" SummaryType="Sum" />
                                                                <dx:ASPxSummaryItem DisplayFormat="c2" FieldName="EFECTIVO" 
                                                                    ShowInGroupFooterColumn="PAGO EFECTIVO" SummaryType="Sum" />
                                                                <dx:ASPxSummaryItem DisplayFormat="c2" FieldName="T_CREDITO" 
                                                                    ShowInGroupFooterColumn="PAGO TARJETA" SummaryType="Sum" />
                                                                <dx:ASPxSummaryItem DisplayFormat="c2" FieldName="NC_TOTAL" 
                                                                    ShowInGroupFooterColumn="TOTAL NOTA CREDITO" SummaryType="Sum" />
                                                            </TotalSummary>
                                                            <Columns>
                                                                <dx:GridViewDataTextColumn Caption="NRO. DOCUMENTO" FieldName="FT_NRO" 
                                                                    ShowInCustomizationForm="True" VisibleIndex="0" Width="110px">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="NRO. NOTA CREDITO" FieldName="NC_NRO" 
                                                                    ShowInCustomizationForm="True" VisibleIndex="1" Width="150px">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataDateColumn Caption="FECHA" FieldName="Fecha" 
                                                                    ShowInCustomizationForm="True" VisibleIndex="2" Width="100px">
                                                                </dx:GridViewDataDateColumn>
                                                                <dx:GridViewDataTextColumn Caption="COD. CLIENTE" FieldName="CardCode" 
                                                                    ShowInCustomizationForm="True" VisibleIndex="3" Width="120px">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="RAZON SOCIAL" FieldName="CardName" 
                                                                    ShowInCustomizationForm="True" VisibleIndex="4" Width="300px">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="TOTAL DOCUMENTO" FieldName="FT_TOTAL" 
                                                                    ShowInCustomizationForm="True" VisibleIndex="5" Width="160px">
                                                                    <PropertiesTextEdit DisplayFormatString="c2">
                                                                    </PropertiesTextEdit>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="PAGO EFECTIVO" FieldName="EFECTIVO" 
                                                                    ShowInCustomizationForm="True" VisibleIndex="6" Width="130px">
                                                                    <PropertiesTextEdit DisplayFormatString="c2">
                                                                    </PropertiesTextEdit>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="PAGO TARJETA" FieldName="T_CREDITO" 
                                                                    ShowInCustomizationForm="True" VisibleIndex="7" Width="130px">
                                                                    <PropertiesTextEdit DisplayFormatString="c2">
                                                                    </PropertiesTextEdit>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="TOTAL PAGADO" FieldName="MontoPagado" 
                                                                    ShowInCustomizationForm="True" VisibleIndex="10" Width="130px">
                                                                    <PropertiesTextEdit DisplayFormatString="c2">
                                                                    </PropertiesTextEdit>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="TOTAL NOTA CREDITO" FieldName="NC_TOTAL" 
                                                                    ShowInCustomizationForm="True" VisibleIndex="12" Width="170px">
                                                                    <PropertiesTextEdit DisplayFormatString="c2">
                                                                    </PropertiesTextEdit>
                                                                </dx:GridViewDataTextColumn>
                                                            </Columns>
                                                            <SettingsPager Mode="ShowAllRecords">
                                                            </SettingsPager>
                                                            <Settings HorizontalScrollBarMode="Auto" ShowFooter="True" 
                                                                ShowTitlePanel="True" VerticalScrollableHeight="393" 
                                                                VerticalScrollBarMode="Visible" UseFixedTableLayout="True" 
                                                                VerticalScrollBarStyle="Virtual" />
                                                        </dx:ASPxGridView>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
                <SettingsItemHelpTexts Position="Bottom"></SettingsItemHelpTexts>
            </dx:LayoutGroup> 
        </Items>
    </dx:ASPxFormLayout>
    <dx:ASPxGridViewExporter ID="gexData" runat="server" GridViewID="gdvData">
    </dx:ASPxGridViewExporter>
    <dx:ASPxFormLayout ID="frlMenu" runat="server">
        <Items>
            <dx:LayoutItem ShowCaption="False">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer ID="licMenu" runat="server" 
                        SupportsDisabledAttribute="True">
                            <div class="MenuFloat">
                                <dx:ASPxMenu ID="mnuOper" runat="server" RenderMode="Lightweight" Width="100%"
                                    DataSourceID="XmlDataSourceFooter" ClientInstanceName="mnuOper"
                                    FirstSubMenuDirection="LeftOrTop"> 
                                    <ItemStyle VerticalAlign="Top" />
                                    <Border BorderWidth="0px" />
                                    <BorderTop BorderWidth="1px" />
                                    <ClientSideEvents ItemClick="Set_Operation" />
                                </dx:ASPxMenu>
                            </div>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
        </Items>
    </dx:ASPxFormLayout>
    <asp:XmlDataSource ID="XmlDataSourceFooter" runat="server" DataFile="~/App_Data/BottomOper.xml"
        XPath="/items/*">
    </asp:XmlDataSource>
    <dx:ASPxLoadingPanel ID="ldpProcess" runat="server" ClientInstanceName="ldpProcess" Modal="true" >
    </dx:ASPxLoadingPanel>
    <dx:ASPxHiddenField ID="hdfTemp" runat="server" ClientInstanceName="hdfTemp">
    </dx:ASPxHiddenField>
    <dx:ASPxCallback ID="clbOperation" runat="server" 
            ClientInstanceName="clbOperation" oncallback="clbOperation_Callback">
        <ClientSideEvents CallbackComplete="Com_Operation" />
    </dx:ASPxCallback>
<link type="text/css" rel="stylesheet" href="../Content/EstilosChristofer.css">
</asp:Content>
