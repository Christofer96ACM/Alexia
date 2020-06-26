﻿<%@ Page Title="Guia de Remisión Compra" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="CompraGuiaRemision.aspx.cs" Inherits="OneCommerce.Purchase.CompraGuiaRemision" %>
<asp:Content ID="cttMain" ContentPlaceHolderID="MainContent" runat="server">
<%--<script type="text/javascript" src="../Scripts/Jquerys/jquery-1.10.2.js"></script>--%>
<script type="text/javascript" src="../Scripts/Jquerys/jquery-2.1.4.js"></script>
<script type="text/javascript" src="../Scripts/Linq/linq.js"></script>
<script type="text/javascript" src="../Scripts/Linq/linq-min.js"></script>
<script type="text/javascript" src="../Scripts/Purchase/EntregaCompra.js"></script>
<script type="text/javascript" src="../Scripts/JSExcel/xlsx.full.min.js"></script>
<script type="text/javascript" src="../Scripts/JSExcel/shim.js"></script>

    <dx:ASPxFormLayout runat="server" ID="frlMain" 
        RequiredMarkDisplayMode="None" EnableViewState="False">
        <Items>
            <dx:LayoutGroup Caption="Guia de Remision Compra" GroupBoxStyle-Caption-Font-Size="X-Large"
                SettingsItemHelpTexts-Position="Bottom" 
                GroupBoxDecoration="HeadingLine">
                <Items>
                    <dx:LayoutItem Caption="Datos Generales" ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="licMain" runat="server" 
                                SupportsDisabledAttribute="True">
                                    <table class="tablespace">
                                        <tr>
                                            <td style="width:160px">
                                                Cliente:</td>
                                            <td colspan="2" style="width:500px">
					                            <table style="width:500px" border="0" cellpadding="0" cellspacing="0">
                                                    <tr>
                                                        <td style="width:150px">
                                                            <dx:ASPxTextBox ID="txtCardCode" runat="server" Width="150px"
                                                                ClientInstanceName="txtCardCode" ReadOnly="true">
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td style="width:350px">
                                                            <dx:ASPxButtonEdit ID="bteCardName" runat="server" 
                                                                ClientInstanceName="bteCardName" Width="350px">
                                                                <Buttons>
                                                                    <dx:EditButton ToolTip="Buscar Cliente">
                                                                    </dx:EditButton>
                                                                </Buttons>
                                                                <ClientSideEvents ButtonClick="ShowClientSearch" />
                                                            </dx:ASPxButtonEdit>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td style="width:5px">
                                            </td>
                                            <td style="width:150px" class="FormatLabel">
                                                Nro. Interno:</td>
                                            <td style="width:217px">
                                                <table style="width:197px" border="0" cellpadding="0" cellspacing="0">
                                                    <tr>
                                                        <td style="width:80px">
                                                            <dx:ASPxTextBox ID="txtDocEntry" runat="server" ClientInstanceName="txtDocEntry" ReadOnly="true" Width="80px">
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td style="text-align:left;width:117px">
                                                            <dx:ASPxTextBox ID="txtDocNum" runat="server" Width="117px" ClientInstanceName="txtDocNum" ReadOnly="true">
                                                                <ReadOnlyStyle Font-Bold="true"></ReadOnlyStyle>
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>                                        
                                        <tr>
                                            <td style="width:160px">
                                                RUC/DNI:</td>
                                            <td colspan="1" style="width:150px">
                                                <dx:ASPxButtonEdit ID="bteLicTradNum" runat="server" Width="150px"
                                                ClientInstanceName="bteLicTradNum" ReadOnly="true">
                                                    <Buttons>
                                                        <dx:EditButton Text="Verficar Cliente" Width="100px" Visible="false">
                                                        </dx:EditButton>
                                                    </Buttons>                                                    
                                                    <ButtonStyle Font-Bold="True">
                                                    </ButtonStyle>
                                                </dx:ASPxButtonEdit>
                                            </td>
                                            <td style="width:350px">
                                                <table>
                                                    <tr>
                                                        <td style="width:150px; text-align:center">
                                                            Contacto:</td>
                                                        <td style="width:200px">
                                                            <dx:ASPxComboBox ID="cbbPersonContact" runat="server" EnableSynchronization="False"
                                                                ClientInstanceName="cbbPersonContact" Width="195px" OnCallback="cbbPersonContact_Callback">
                                                            </dx:ASPxComboBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td style="width:5px">
                                                &nbsp;</td>
                                            <td style="width:150px" class="FormatLabel">
                                                Estado:</td>
                                            <td style="width:217px" class="FormatLabel">
                                                <dx:ASPxTextBox ID="txtDocStatus" runat="server" Width="197px"
                                                    ClientInstanceName="txtDocStatus" ReadOnly="true">
                                                <ReadOnlyStyle Font-Bold="true"></ReadOnlyStyle>
                                                </dx:ASPxTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width:160px">
                                                Lista de Precios:</td>
                                            <td colspan="2" style="width:500px">
                                                <table style="width:500px" border="0" cellpadding="0" cellspacing="0">
                                                    <tr>
                                                        <td style="width:150px">
                                                            <dx:ASPxComboBox ID="cbbListNum" runat="server" Width="150px" EnableSynchronization="False"
                                                                ClientInstanceName="cbbListNum">
                                                            </dx:ASPxComboBox>
                                                        </td>
                                                        <td style="width:150px; text-align:center; font-weight: bold;">
                                                            Moneda:
                                                        </td>
                                                        <td style="width:200px">
                                                            <dx:ASPxComboBox ID="cbbDocCur" runat="server" Width="200px" EnableSynchronization="False"
                                                                ClientInstanceName="cbbDocCur" SelectedIndex="0" Visible="true" 
                                                                ClientSideEvents-SelectedIndexChanged="cambio_moneda"
                                                                AutoPostBack="false">
                                                                <Items>
                                                                    <dx:ListEditItem Selected="True" Text="SOL" Value="SOL" />
                                                                    <dx:ListEditItem Text="Dolar Americano" Value="USD" />
                                                                    <dx:ListEditItem Text="Euro" Value="EUR" />
                                                                    <%--<dx:ListEditItem Text="Transferencia Gratuita" Value="05" />--%>
                                                                </Items>
                                                            </dx:ASPxComboBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td style="width:5px">
                                                &nbsp;</td>
                                            <td style="width:150px" class="FormatLabel">
                                                Fecha Contable:</td>
                                            <td style="width:217px">
                                                <dx:ASPxDateEdit ID="dteDocDate" runat="server" Width="197px"
                                                    ClientInstanceName="dteDocDate" Font-Bold="true">
                                                </dx:ASPxDateEdit>
                                            </td>
                                        </tr>                                        
                                        <tr>
                                            <td style="width:160px">
                                                Nro. de Documento:</td>
                                            <td colspan="2" style="width:500px">
					                            <table style="width:500px" border="0" cellpadding:"0" cellspacing:"0">
                                                    <tr>
                                                        <td style="width:200px">
                                                            <dx:ASPxComboBox ID="cbbU_BPP_MDTD" runat="server" Width="200px" EnableSynchronization="False"
                                                                ClientInstanceName="cbbU_BPP_MDTD">
                                                                <ClientSideEvents SelectedIndexChanged="Get_DocumentSerie" />
                                                                <ClientSideEvents SelectedIndexChanged="Get_DocumentCorrelative" />
                                                            </dx:ASPxComboBox>
                                                        </td>
                                                        <td style="width:100px">
                                                            <dx:ASPxTextBox ID="txtU_BPP_MDSD" runat="server" EnableSynchronization="False"
                                                                ClientInstanceName="txtU_BPP_MDSD" Width="100px" Text="Serie">
                                                                <ClientSideEvents KeyUp="Get_DocumentCorrelative" />
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td style="width:100px">
                                                            <dx:ASPxTextBox ID="txtU_BPP_MDCD" runat="server" ClientInstanceName="txtU_BPP_MDCD" 
                                                                Width="100px" ReadOnly="false" Text="Correlativo">
                                                                <ClientSideEvents KeyUp="Get_DocumentCorrelative" />
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td style="width:100px">
                                                            <dx:ASPxTextBox ID="NumAtCard" runat="server" ClientInstanceName="NumAtCard" 
                                                                Width="100px" ReadOnly="false" Text="">
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td style="width:5px">
                                                &nbsp;</td>
                                            <td style="width:150px" class="FormatLabel">
                                                Fecha Documento:</td>
                                            <td style="width:217px">
                                                <dx:ASPxDateEdit ID="dteDocumentoDate" runat="server" Width="197px"
                                                    ClientInstanceName="dteDocumentoDate" Font-Bold="true">
                                                </dx:ASPxDateEdit>
                                            </td>
                                        </tr>                                        
                                        <tr>
                                            <td colspan="6">
                                                <dx:ASPxGridView ID="gdvdln1" runat="server" AutoGenerateColumns="False" Width="1022px"
                                                    ClientInstanceName="gdvdln1" KeyFieldName="LineNum"
                                                    OnCellEditorInitialize="gdvdln1_CellEditorInitialize" 
                                                    OnRowInserting="gdvdln1_RowInserting"                                                    
                                                    OnRowValidating="gdvdln1_RowValidating" 
                                                    OnRowDeleting="gdvdln1_RowDeleting" 
                                                    OnCustomCallback="gdvdln1_CustomCallback"
                                                    OnCommandButtonInitialize="gdvdln1_CommandButtonInitialize"
                                                    OnHtmlRowPrepared="gdvdln1_HtmlRowPrepared" 
                                                    OnRowUpdating="gdvdln1_RowUpdating"
                                                    OnAfterPerformCallback="gdvdln1_AfterPerformCallback"
                                                    OnHtmlCommandCellPrepared="gdvdln1_HtmlCommandCellPrepared">
                                                    <Columns>
                                                        <dx:GridViewCommandColumn Caption="Operación" ShowInCustomizationForm="True" 
                                                            VisibleIndex="0" Width="120px">
                                                            <EditButton Visible="True">
                                                            </EditButton>
                                                            <NewButton Visible="True">
                                                            </NewButton>
                                                            <DeleteButton Visible="True">
                                                            </DeleteButton>
                                                            <CellStyle Font-Size="8pt">
                                                            </CellStyle>
                                                        </dx:GridViewCommandColumn>
                                                        <dx:GridViewDataTextColumn Caption="Línea" ShowInCustomizationForm="True" 
                                                            VisibleIndex="1" Width="50px" FieldName="LineNum">
                                                            <PropertiesTextEdit ClientInstanceName="txtLineNum">
                                                                <Style HorizontalAlign="Center" VerticalAlign="Middle" Font-Size="8pt">
                                                                </Style>
                                                            </PropertiesTextEdit>
                                                            <EditCellStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Size="8pt">
                                                            </EditCellStyle>
                                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                            <CellStyle ForeColor="Black" HorizontalAlign="Center" VerticalAlign="Middle" Font-Size="8pt">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataButtonEditColumn Caption="Código" FieldName="ItemCode" 
                                                            ShowInCustomizationForm="True" VisibleIndex="2" Width="90px">
                                                            <PropertiesButtonEdit ClientInstanceName="bteItemCode">
                                                                <Buttons>
                                                                    <dx:EditButton ToolTip="Agregar Artículo" Visible="true">
                                                                    </dx:EditButton>
                                                                </Buttons>
                                                                <Style Font-Size="8pt">
                                                                </Style>
                                                                <ClientSideEvents ButtonClick="Add_Product" KeyPress="Key_Product"/>
                                                            </PropertiesButtonEdit>
                                                            <EditCellStyle Font-Size="8pt">
                                                            </EditCellStyle>
                                                            <CellStyle VerticalAlign="Middle" ForeColor="Black">
                                                            </CellStyle>
                                                        </dx:GridViewDataButtonEditColumn>
                                                        <dx:GridViewDataButtonEditColumn Caption="Descripción" FieldName="ItemName" 
                                                            ShowInCustomizationForm="True" VisibleIndex="3" Width="260px">
                                                            <PropertiesButtonEdit ClientInstanceName="bteItemName">
                                                                <Buttons>
                                                                    <dx:EditButton ToolTip="Buscar Artículo" Visible="true">
                                                                    </dx:EditButton>
                                                                </Buttons>
                                                                <Style Font-Size="8pt">
                                                                </Style>
                                                                <ClientSideEvents ButtonClick="ShowProductSearch" />
                                                            </PropertiesButtonEdit>
                                                            <EditCellStyle Font-Size="8pt">
                                                            </EditCellStyle>
                                                            <CellStyle VerticalAlign="Middle" ForeColor="Black">
                                                            </CellStyle>
                                                        </dx:GridViewDataButtonEditColumn>
                                                        <dx:GridViewDataTextColumn Caption="Cantidad" ShowInCustomizationForm="True" 
                                                            VisibleIndex="4" Width="70px" FieldName="Quantity">
                                                            <PropertiesTextEdit ClientInstanceName="txtQuantity" Width="100%" DisplayFormatInEditMode="true">
                                                            
                                                                <Style HorizontalAlign="Center" VerticalAlign="Middle" Font-Size="8pt">
                                                                </Style>                                                                
                                                                <ValidationSettings ErrorDisplayMode="None">
                                                                    <ErrorFrameStyle>
                                                                        <Paddings Padding="0px" />
                                                                        <Border BorderWidth="0px" />
                                                                    </ErrorFrameStyle>
                                                                </ValidationSettings>
                                                                <ClientSideEvents KeyUp="Cal_LineTotals" /> 
                                                            </PropertiesTextEdit>
                                                            <EditCellStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Size="8pt">
                                                            </EditCellStyle>
                                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                            <CellStyle ForeColor="Black" HorizontalAlign="Center" VerticalAlign="Middle" Font-Size="8pt">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Precio Unitario" ShowInCustomizationForm="True" 
                                                            VisibleIndex="5" Width="100px" FieldName="PriceBefDi">
                                                            <PropertiesTextEdit ClientInstanceName="txtPriceBefDi" DisplayFormatString="n4"
                                                                DisplayFormatInEditMode="true">
                                                                <ClientSideEvents KeyUp="Cal_PriceUpdate" />
                                                                <Style HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                                </Style>
                                                            </PropertiesTextEdit>
                                                            <EditCellStyle HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                            </EditCellStyle>
                                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                            <CellStyle ForeColor="Black" HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="% Desc." ShowInCustomizationForm="True" 
                                                            VisibleIndex="6" Width="60px" FieldName="DiscPrcnt">
                                                            <PropertiesTextEdit ClientInstanceName="txtDiscPrcnt" Width="100%" DisplayFormatString="0.00#"
                                                                    DisplayFormatInEditMode="true">
                                                            <MaskSettings Mask="&lt;0..999&gt;.&lt;00..999&gt;" />
                                                                <Style HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                                </Style>
                                                                <ValidationSettings ErrorDisplayMode="None">
                                                                    <ErrorFrameStyle>
                                                                        <Paddings Padding="0px" />
                                                                        <Border BorderWidth="0px" />
                                                                    </ErrorFrameStyle>
                                                                </ValidationSettings>
                                                                <ClientSideEvents KeyUp="Cal_LineDescTotals" />
                                                            </PropertiesTextEdit>
                                                            <EditCellStyle HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                            </EditCellStyle>
                                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                            <CellStyle ForeColor="Black" HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Precio C/Desc." FieldName="Price"
                                                            ShowInCustomizationForm="True" VisibleIndex="7" Width="90px" ReadOnly="true">
                                                            <PropertiesTextEdit ClientInstanceName="txtPrice" DisplayFormatString="{0:n4}"
                                                                DisplayFormatInEditMode="true">
                                                                <Style HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                                </Style>
                                                            </PropertiesTextEdit>
                                                            <EditCellStyle HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                            </EditCellStyle>
                                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                            <CellStyle ForeColor="Black" HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Total S/IGV" FieldName="LineTotal"
                                                            ShowInCustomizationForm="True" VisibleIndex="8" Width="90px" ReadOnly="true">
                                                            <PropertiesTextEdit ClientInstanceName="txtLineTotal" DisplayFormatString="{0:n4}"
                                                                DisplayFormatInEditMode="true">
                                                                <Style HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                                </Style>
                                                            </PropertiesTextEdit>
                                                            <EditCellStyle HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                            </EditCellStyle>
                                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                            <CellStyle ForeColor="Black" HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn ShowInCustomizationForm="True" Width="90px" 
                                                            Caption="Total C/IGV" VisibleIndex="9" FieldName="GTotal" ReadOnly="true">
                                                            <PropertiesTextEdit ClientInstanceName="txtGTotal" DisplayFormatString="{0:n4}"
                                                                DisplayFormatInEditMode="true">
                                                                <Style HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                                </Style>
                                                            </PropertiesTextEdit>
                                                            <EditCellStyle HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                            </EditCellStyle>
                                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                            <CellStyle ForeColor="Black" HorizontalAlign="Right" VerticalAlign="Middle" Font-Size="8pt">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Gestion de Articulo" FieldName="IssueMthd"
                                                            ShowInCustomizationForm="True" VisibleIndex="10" Width="80px">
                                                                <PropertiesTextEdit ClientInstanceName="txtIssueMthd"
                                                                    DisplayFormatInEditMode="true">
                                                                    <Style VerticalAlign="Middle" Font-Size="8pt">
                                                                    </Style>
                                                                </PropertiesTextEdit>
                                                                <EditCellStyle VerticalAlign="Middle" Font-Size="8pt">
                                                                </EditCellStyle>
                                                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                                <CellStyle ForeColor="Black"  VerticalAlign="Middle" Font-Size="8pt">
                                                                </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataButtonEditColumn Caption="Serie a Seleccionar" FieldName="Serie" 
                                                            ShowInCustomizationForm="True" VisibleIndex="11" Width="260px">
                                                            <PropertiesButtonEdit ClientInstanceName="bteSerialNumber">
                                                                <Buttons>
                                                                    <dx:EditButton ToolTip="Seleccionar Serie" Visible="true">
                                                                    </dx:EditButton>
                                                                </Buttons>
                                                                <Style Font-Size="8pt">
                                                                </Style>
                                                                <ClientSideEvents ButtonClick="ShowPoput"/>
                                                            </PropertiesButtonEdit>
                                                            <EditCellStyle Font-Size="8pt">
                                                            </EditCellStyle>
                                                            <CellStyle VerticalAlign="Middle" ForeColor="Black">
                                                            </CellStyle>
                                                        </dx:GridViewDataButtonEditColumn>
                                                        <dx:GridViewDataButtonEditColumn Caption="Almacén" ShowInCustomizationForm="True" ReadOnly="true" 
                                                            VisibleIndex="12" Width="100px" FieldName="WhsCode">
                                                                <PropertiesButtonEdit ClientInstanceName="WhsCode">
                                                                <Buttons>
                                                                    <dx:EditButton ToolTip="Agregar Almacén">
                                                                    </dx:EditButton>
                                                                </Buttons>
                                                                <Style Font-Size="8pt">
                                                                </Style>
                                                                <ClientSideEvents ButtonClick="Show_AlmacenSearch"/>
                                                            </PropertiesButtonEdit>
                                                            <EditCellStyle Font-Size="8pt">
                                                            </EditCellStyle>
                                                            <CellStyle VerticalAlign="Middle" ForeColor="Black">
                                                            </CellStyle>
                                                        </dx:GridViewDataButtonEditColumn>
                                                        <%--<dx:GridViewDataTextColumn Caption="Moneda" FieldName="LastPurCur"
                                                            ShowInCustomizationForm="True" VisibleIndex="12" Width="40px">
                                                                <PropertiesTextEdit ClientInstanceName="LastPurCur"
                                                                    DisplayFormatInEditMode="true">
                                                                    <Style VerticalAlign="Middle" Font-Size="8pt">
                                                                    </Style>
                                                                </PropertiesTextEdit>
                                                                <EditCellStyle VerticalAlign="Middle" Font-Size="8pt">
                                                                </EditCellStyle>
                                                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                                <CellStyle ForeColor="Black"  VerticalAlign="Middle" Font-Size="8pt">
                                                                </CellStyle>
                                                        </dx:GridViewDataTextColumn>--%>
                                                        <%--<dx:GridViewDataTextColumn  ShowInCustomizationForm="True" VisibleIndex="11" 
                                                            FieldName="U_BF_CodKit" Width="0px" Visible="False">
                                                            <PropertiesTextEdit ClientInstanceName="txtU_BF_CodKit" Width="0px">
                                                            <Style CssClass="DisplayNone"></Style>
                                                            </PropertiesTextEdit>
                                                            <HeaderStyle CssClass="DisplayNone" />
                                                            <EditCellStyle CssClass="DisplayNone" />
                                                            <CellStyle CssClass="DisplayNone" />
                                                            <FilterCellStyle CssClass="DisplayNone" />
                                                            <FooterCellStyle CssClass="DisplayNone" />
                                                            <GroupFooterCellStyle CssClass="DisplayNone" />
                                                        </dx:GridViewDataTextColumn>--%>
                                                    </Columns>
                                                    <SettingsBehavior AllowSort="False" ColumnResizeMode="Disabled"
                                                        ConfirmDelete="True" />
                                                    <SettingsPager Visible="False" Mode="ShowAllRecords">
                                                    </SettingsPager>
                                                    <SettingsEditing Mode="Inline" NewItemRowPosition="Bottom" />
                                                    <Settings ShowFooter="True" ShowTitlePanel="True" />
                                                    <SettingsText Title="ARTÍCULOS" />
                                                    <Styles>
                                                        <Row Font-Size="7pt">
                                                        </Row>
                                                        <Footer Font-Size="1pt">
                                                        </Footer>
                                                        <TitlePanel Font-Bold="True" Font-Size="7pt" HorizontalAlign="Center">
                                                        </TitlePanel>
                                                    </Styles>
                                                    <ClientSideEvents BeginCallback="Beg_CallbackLines" EndCallback="End_CallbackLines" />
                                                </dx:ASPxGridView>
                                            </td>
                                        </tr>
                                            <tr>
                                                <td style="width:160px">
                                                    Encargado de Compras:</td>
                                                <td colspan="2" style="width:500px">
                                                    <dx:ASPxComboBox ID="cbeSalesPerson" runat="server" EnableSynchronization="False"
                                                        ClientInstanceName="cbeSalesPerson" Width="500px"
                                                        IncrementalFilteringMode="Contains">
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td style="width:5px">
                                                </td>
                                                <td style="width:150px" class="FormatLabel">
                                                    SubTotal:</td>
                                                <td style="width:217px">
                                                    <dx:ASPxTextBox ID="txtLineSum" runat="server" Width="197px" HorizontalAlign="Right"
                                                        ClientInstanceName="txtLineSum" ReadOnly="True" DisplayFormatString="c2">
                                                        <ReadOnlyStyle Font-Bold="true"></ReadOnlyStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width:160px">
                                                    Responsable Compra:</td>
                                                <td colspan="2" style="width:500px">
                                                    <dx:ASPxComboBox ID="cbeOwnerCode" runat="server" EnableSynchronization="False"
                                                        ClientInstanceName="cbeOwnerCode" Width="500px"
                                                        IncrementalFilteringMode="Contains">
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td style="width:5px">
                                                    &nbsp;</td>
                                                <td style="width:150px" class="FormatLabel">
                                                    Descuento:</td>
                                                <td style="width:217px">
                                                    <table style="width:197px" border="0" cellpadding="0" cellspacing="0">
                                                        <tr>
                                                            <td style="width:80px">
                                                                <dx:ASPxTextBox ID="txtDiscPrcntTotal" runat="server" ClientInstanceName="txtDiscPrcntTotal" 
                                                                    HorizontalAlign="Right" Width="80px" Text="0.00" Font-Bold="true">
                                                                   <%--<MaskSettings Mask="&lt;0..999&gt;.&lt;00..999&gt;" />  --%>                                                                 
                                                                    <ValidationSettings ErrorDisplayMode="None">
                                                                        <ErrorFrameStyle>
                                                                            <Paddings Padding="0px" />
                                                                            <Border BorderWidth="0px" />
                                                                        </ErrorFrameStyle>
                                                                    </ValidationSettings>
                                                                    <ClientSideEvents KeyUp="Set_Discount" />
                                                                </dx:ASPxTextBox>
                                                            </td>
                                                            <td style="text-align:left;width:117px">
                                                                <dx:ASPxTextBox ID="txtDiscSum" runat="server" ClientInstanceName="txtDiscSum" 
                                                                    HorizontalAlign="Right" Width="117px" DisplayFormatString="c2" ReadOnly="true">
                                                                    <ReadOnlyStyle Font-Bold="true"></ReadOnlyStyle>
                                                                </dx:ASPxTextBox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width:160px">
                                                    Condición de Pago:</td>
                                                <td colspan="2" style="width:500px">
                                                    <dx:ASPxComboBox ID="cbbGroupNum" runat="server" EnableSynchronization="False"
                                                        ClientInstanceName="cbbGroupNum" Width="500px">
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td style="width:5px">
                                                    &nbsp;</td>
                                                <td style="width:150px" class="FormatLabel">
                                                    Gasto Adicional:</td>
                                                <td style="width:217px">
                                                    <dx:ASPxTextBox ID="txtTotalExpns" runat="server" Width="197px" ClientInstanceName="txtTotalExpns"
                                                    HorizontalAlign="Right" DisplayFormatString="c2" Font-Bold="true">
                                                    <%--<MaskSettings Mask="&lt;0..99999999&gt;.&lt;00..99&gt;" />--%>

                                                    <ClientSideEvents KeyUp="Set_TotalExpns" />
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                        <tr>
                                            <td style="vertical-align:text-top;width:160px" rowspan="2">
                                                Comentario:</td>
                                            <td colspan="2" rowspan="2" style="width:500px">
                                                <dx:ASPxMemo ID="mmoComments" runat="server" ClientInstanceName="mmoComments" 
                                                    Height="40px" Width="500px">
                                                </dx:ASPxMemo>
                                            </td>
                                            <td style="width:5px">
                                                &nbsp;</td>
                                            <td style="width:150px" class="FormatLabel">
                                                Impuesto:</td>
                                            <td style="width:217px">
                                                <dx:ASPxTextBox ID="txtVatSum" runat="server" HorizontalAlign="Right"
                                                    ClientInstanceName="txtVatSum" ReadOnly="True" Width="197px" 
                                                    DisplayFormatString="c2">
                                                    <ReadOnlyStyle Font-Bold="true"></ReadOnlyStyle>
                                                </dx:ASPxTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width:5px">
                                                &nbsp;</td>
                                            <td style="width:150px" class="FormatLabel">
                                                Total Documento:</td>
                                            <td style="width:217px">
                                                <dx:ASPxTextBox ID="txtDocTotal" runat="server" HorizontalAlign="Right"
                                                    ClientInstanceName="txtDocTotal" ReadOnly="True" Width="197px" 
                                                    DisplayFormatString="c2">
                                                    <ReadOnlyStyle Font-Bold="true"></ReadOnlyStyle>
                                                </dx:ASPxTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width:160px">
                                                Dirección de Entrega:</td>
                                            <td style="width:150px">
                                                <dx:ASPxTextBox ID="txtShipToCode" runat="server" ClientInstanceName="txtShipToCode" ReadOnly="true"
                                                    Width="150px">
                                                </dx:ASPxTextBox>
                                            </td>
                                            <td style="width:350px">
                                                <dx:ASPxButtonEdit ID="bteShipToCode" runat="server" ClientInstanceName="bteShipToCode" ReadOnly="true"
                                                    Width="350px">
                                                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True" Display="Dynamic"
                                                        ValidationGroup="ValEditors">
                                                        <RequiredField ErrorText="Dirección de entrega incorrecta."/>
                                                        <ErrorFrameStyle>
                                                            <Paddings Padding="0px" />
                                                            <Border BorderWidth="0px" />
                                                        </ErrorFrameStyle>
                                                    </ValidationSettings>
                                                    <Buttons>
                                                        <dx:EditButton>
                                                        </dx:EditButton>
                                                    </Buttons>
                                                    <ClientSideEvents ButtonClick="Show_AddreListDestino" />
                                                </dx:ASPxButtonEdit>
                                            </td>
                                            <%--<td style="width:160px">
                                                Pedido Origen:</td>
                                            <td style="width:150px">
                                                <dx:ASPxTextBox ID="txtU_BF_PED_ORIG0" runat="server" 
                                                    ClientInstanceName="txtU_BF_PED_ORIG" Width="150px">
                                                </dx:ASPxTextBox>
                                            </td>
                                            <td style="width:350px">
                                                &nbsp;</td>--%>
                                            <td style="width:5px">
                                                &nbsp;</td>
                                            <td class="FormatLabel" style="width:150px">
                                                Importe Aplicado:</td>
                                            <td style="width:217px">
                                                <dx:ASPxTextBox ID="txtPaidToDate" runat="server" HorizontalAlign="Right"
                                                    ClientInstanceName="txtPaidToDate" ReadOnly="True" Width="197px" 
                                                    DisplayFormatString="c2">
                                                    <ReadOnlyStyle Font-Bold="true"></ReadOnlyStyle>
                                                </dx:ASPxTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width:160px">
                                                Dirección de Factura:</td>
                                            <td style="width:150px">
                                                <dx:ASPxTextBox ID="txtBillToCode" runat="server" ClientInstanceName="txtBillToCode" ReadOnly="true"
                                                    Width="150px">
                                                </dx:ASPxTextBox>
                                            </td>
                                            <td style="width:350px">
                                                <dx:ASPxButtonEdit ID="bteBillToCode" runat="server" ClientInstanceName="bteBillToCode" ReadOnly="true" 
                                                    Width="350px">
                                                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True" Display="Dynamic"
                                                        ValidationGroup="ValEditors">
                                                        <RequiredField ErrorText="Dirección de facturación incorrecta."/>
                                                        <ErrorFrameStyle>
                                                            <Paddings Padding="0px" />
                                                            <Border BorderWidth="0px" />
                                                        </ErrorFrameStyle>
                                                    </ValidationSettings>
                                                    <Buttons>
                                                        <dx:EditButton>
                                                        </dx:EditButton>
                                                    </Buttons>
                                                    <ClientSideEvents ButtonClick="Show_AddreListFactura" />
                                                </dx:ASPxButtonEdit>
                                            </td>   
                                            <%--<td style="width:160px">
                                                &nbsp;</td>
                                            <td style="width:150px">
                                                &nbsp;</td>
                                            <td style="width:350px">
                                                &nbsp;</td>--%>
                                            <td style="width:5px">
                                                &nbsp;</td>
                                            <td class="FormatLabel" style="width:150px">
                                                Saldo Pendiente:</td>
                                            <td style="width:217px">
                                                <dx:ASPxTextBox ID="txtPendingBal" runat="server" HorizontalAlign="Right" 
                                                    ClientInstanceName="txtPendingBal" ReadOnly="True" Width="197px" 
                                                    DisplayFormatString="c2">
                                                    <ReadOnlyStyle Font-Bold="true"></ReadOnlyStyle>
                                                </dx:ASPxTextBox>
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
    <dx:ASPxFormLayout ID="frlMenu" runat="server">
        <Items>
            <dx:LayoutItem ShowCaption="False">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer ID="licMenu" runat="server" 
                        SupportsDisabledAttribute="True">
                            <div class="MenuFloat">
                                <dx:ASPxMenu ID="mnuOper" runat="server" RenderMode="Lightweight" Width="100%"
                                    DataSourceID="XmlDataSourceFooter" ClientInstanceName="mnuOper"> 
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
    <dx:ASPxPopupControl ID="ppcAlmacenSearch" runat="server" 
        ClientInstanceName="ppcAlmacenSearch" FooterText=" " HeaderText="Buscar Almacén" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" 
        RenderMode="Lightweight" ShowFooter="True" Width="500px" Modal="true"
        AllowDragging="True" PopupAnimationType="Fade">
        <ContentStyle>
            <Paddings PaddingBottom="0px" />
        </ContentStyle>
        <ContentCollection>
            <dx:PopupControlContentControl runat="server" SupportsDisabledAttribute="True">
                <table border="0" style="width:100%">
                    <tr>
                        <td>
                            <table style="width:100%;" class="tablespace">
                                <tr>
                                    <td id="Client3" style="width:105px">
                                        Filtro:</td>
                                    <td style="width:280px">
                                        <dx:ASPxTextBox ID="txtParAlmacen" runat="server" Width="100%" 
                                            ClientInstanceName="txtParAlmacen">
                                        </dx:ASPxTextBox>
                                    </td>
                                    <td>
                                        <dx:ASPxButton ID="bteAlmacenSearch" runat="server" Text="Buscar" Width="100%" 
                                            ClientInstanceName="bteAlmacenSearch" AutoPostBack="False">
                                            <ClientSideEvents Click="Get_Almacen" />
                                        </dx:ASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxGridView ID="gdvWhsCodeSearch" runat="server" Width="100%" 
                                AutoGenerateColumns="False" ClientInstanceName="gdvWhsCodeSearch" 
                                KeyFieldName="WhsCode" OnCustomCallback="gdvWhsCodeSearch_CustomCallback" 
                                KeyboardSupport="True" OnDataBinding="gdvWhsCodeSearch_DataBinding">
                                <Columns>
                                    <dx:GridViewDataTextColumn Caption="Código Almacén" FieldName="WhsCode" 
                                        ShowInCustomizationForm="True" SortIndex="0" SortOrder="Ascending" 
                                        VisibleIndex="0" Width="150px">
                                        <Settings AllowSort="True" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Nombre Almacén" FieldName="WhsName" 
                                        ShowInCustomizationForm="True" VisibleIndex="1">
                                    </dx:GridViewDataTextColumn>
                                </Columns>
                                <SettingsBehavior AllowSelectByRowClick="True" 
                                    AllowSelectSingleRowOnly="True" />
                                <ClientSideEvents RowDblClick="OkAlmacen"/>
                                <Styles>
                                    <Row Font-Size="7pt">
                                    </Row>
                                </Styles>
                            </dx:ASPxGridView>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width:100%;" class="tablespace">
                                <tr>
                                    <td style="width:340px">
                                        &nbsp;</td>
                                    <td>
                                        <dx:ASPxButton ID="ASPxButton3" runat="server" Text="Ok" Width="100%" 
                                            ClientInstanceName="btnClientOk" AutoPostBack="False">
                                            <ClientSideEvents Click="OkAlmacen" />
                                        </dx:ASPxButton>
                                    </td>
                                    <td>
                                        <dx:ASPxButton ID="ASPxButton4" runat="server" Text="Cancelar" Width="100%" 
                                            ClientInstanceName="btnClientCancel" AutoPostBack="False">
                                            <ClientSideEvents Click="CancelAlmacen" />
                                        </dx:ASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl> 
        <dx:ASPxPopupControl ID="ppcOrdrSearch" runat="server" 
        ClientInstanceName="ppcOrdrSearch" FooterText=" " HeaderText="Buscar Orden de Compra" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" 
        RenderMode="Lightweight" ShowFooter="True" Width="800px" Modal="true"
        AllowDragging="True" PopupAnimationType="Fade">
        <ContentStyle>
            <Paddings PaddingBottom="0px" />
        </ContentStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="pccOrdrSearch" runat="server" SupportsDisabledAttribute="True">
                <table border="0"  style="width:100%">
                    <tr>
                        <td>
                            <table class="tablespace" style="width:100%">
                                <tr>
                                    <td style="width:105px">
                                        Rango Fechas:</td>
                                    <td style="width:130px">
                                        <dx:ASPxDateEdit ID="dterdDateIn" runat="server" Width="130px" 
                                            ClientInstanceName="dterdDateIn">
                                        </dx:ASPxDateEdit>
                                    </td>
                                    <td style="width:130px">
                                        <dx:ASPxDateEdit ID="dterdDateFi" runat="server" Width="130px" 
                                            ClientInstanceName="dterdDateFi">
                                        </dx:ASPxDateEdit>
                                    </td>
                                    <td style="width:5px">
                                    </td>
                                    <td style="width:130px">
                                        Nro. Orden:</td>
                                    <td style="width:170px">
                                        <dx:ASPxTextBox ID="txtrdDocNum" runat="server" 
                                            ClientInstanceName="txtrdDocNum" Width="170px">
                                        </dx:ASPxTextBox>
                                    </td>
                                    <td style="width:50px">
                                        <dx:ASPxButton ID="btnOrdrSearch" runat="server" AutoPostBack="False" 
                                            ClientInstanceName="btnOrdtSearch" Text="Buscar" Width="100%">
                                            <ClientSideEvents Click="Get_Ordr" />
                                        </dx:ASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxGridView ID="gdvOrdrSearch" runat="server" Width="100%" 
                                AutoGenerateColumns="False" ClientInstanceName="gdvOrdrSearch" 
                                KeyFieldName="DocEntry" OnCustomCallback="gdvOrdrSearch_CustomCallback" 
                                KeyboardSupport="True" OnDataBinding="gdvOrdrSearch_DataBinding">
                                <Columns>
                                    <dx:GridViewDataTextColumn Caption="Nro. Orden" FieldName="DocNum" 
                                        ShowInCustomizationForm="True" VisibleIndex="0" Width="70px">
                                        <Settings AllowSort="False" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Fecha" FieldName="DocDate"
                                        ShowInCustomizationForm="True" VisibleIndex="1" Width="70px">
                                        <PropertiesTextEdit DisplayFormatString="d">
                                        </PropertiesTextEdit>
                                        <Settings AllowSort="False" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Cód. Cliente" FieldName="CardCode" 
                                        ShowInCustomizationForm="True" VisibleIndex="2" Width="70px">
                                        <Settings AllowSort="False" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Razón Social" FieldName="CardName" 
                                        ShowInCustomizationForm="True" VisibleIndex="3" Width="200px">
                                        <Settings AllowSort="False" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Total" FieldName="DocTotalSrch" 
                                        ShowInCustomizationForm="True" VisibleIndex="4" Width="80px">
                                        <PropertiesTextEdit DisplayFormatString="c2">
                                            <Style HorizontalAlign="Right"></Style>
                                        </PropertiesTextEdit>
                                        <Settings AllowSort="False" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="DocEntry" FieldName="DocEntry" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="5" Width="0px">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="GroupNum" FieldName="GroupNum" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="6" Width="0px">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="SlpCode" FieldName="SlpCode" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="7" Width="0px">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Comments" FieldName="Comments" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="8" Width="0px">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="DocCur" FieldName="DocCur" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="9" Width="0px">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="OwnerCode" FieldName="OwnerCode" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="10" Width="0px">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="DiscPrcntTotal" FieldName="DiscPrcntTotal" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="11" Width="0px">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="DiscSum" FieldName="DiscSum" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="12" Width="0px">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="ListNumSrch" FieldName="ListNumSrch" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="13" Width="0px">
                                    </dx:GridViewDataTextColumn>
                                </Columns>
                                <SettingsBehavior AllowSelectByRowClick="True" 
                                    AllowSelectSingleRowOnly="True" />
                                <ClientSideEvents RowDblClick="OkOrdr" EndCallback="EndOrdrSearch"/>
                                <Styles>
                                    <Row Font-Size="7pt">
                                    </Row>
                                </Styles>
                            </dx:ASPxGridView>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width:100%;" class="tablespace">
                                <tr>
                                    <td style="width:650px">
                                        &nbsp;</td>
                                    <td>
                                        <dx:ASPxButton ID="btnOqutOk" runat="server" Text="Ok" Width="100%" 
                                            ClientInstanceName="btnOqutOk" AutoPostBack="False">
                                            <ClientSideEvents Click="OkOrdr" />
                                        </dx:ASPxButton>
                                    </td>
                                    <td>
                                        <dx:ASPxButton ID="btnOqutCancel" runat="server" Text="Cancelar" Width="100%" 
                                            ClientInstanceName="btnOqutCancel" AutoPostBack="False">
                                            <ClientSideEvents Click="CancelOrdr" />
                                        </dx:ASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    <dx:ASPxHiddenField ID="hdfTemp" runat="server" ClientInstanceName="hdfTemp" OnCustomCallback="hdfTemp_CustomCallback" SyncWithServer="true">
    </dx:ASPxHiddenField>
    <dx:ASPxLoadingPanel ID="ldpProcess" runat="server" ClientInstanceName="ldpProcess" Modal="true" >
    </dx:ASPxLoadingPanel>
    <dx:ASPxPopupControl ID="ppcClientSearch" runat="server" 
        ClientInstanceName="ppcClientSearch" FooterText=" " HeaderText="Buscar Proveedor" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" 
        RenderMode="Lightweight" ShowFooter="True" Width="500px" Modal="true"
        AllowDragging="True" PopupAnimationType="Fade">
        <ContentStyle>
            <Paddings PaddingBottom="0px" />
        </ContentStyle>
        <ContentCollection>
            <dx:PopupControlContentControl runat="server" SupportsDisabledAttribute="True">
                <table border="0" style="width:100%">
                    <tr>
                        <td>
                            <table style="width:100%;" class="tablespace">
                                <tr>
                                    <td id="Client" style="width:105px">
                                        Código:</td>
                                    <td style="width:280px">
                                        <dx:ASPxTextBox ID="txtParClient" runat="server" Width="100%" 
                                            ClientInstanceName="txtParClient">
                                            <ClientSideEvents KeyUp="Get_Client" />
                                        </dx:ASPxTextBox>
                                    </td>
                                    <td>
                                        <dx:ASPxButton ID="bteClientSearch" runat="server" Text="Buscar" Width="100%" 
                                            ClientInstanceName="bteClientSearch" AutoPostBack="False">
                                            <ClientSideEvents Click="Get_Client" />
                                        </dx:ASPxButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td id="ClientParCaptin" style="width:105px">
                                        Razón Social:</td>
                                    <td style="width:280px">
                                        <dx:ASPxTextBox ID="txtRazonS" runat="server" Width="100%" 
                                            ClientInstanceName="txtRazonS">
                                            <ClientSideEvents KeyPress="Get_Client" />
                                        </dx:ASPxTextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxGridView ID="gdvClientSearch" runat="server" Width="100%" 
                                AutoGenerateColumns="False" ClientInstanceName="gdvClientSearch" 
                                KeyFieldName="CardCode" OnCustomCallback="gdvClientSearch_CustomCallback" 
                                KeyboardSupport="True" OnDataBinding="gdvClientSearch_DataBinding">
                                <Columns>
                                    <dx:GridViewDataTextColumn Caption="Código" FieldName="CardCode" 
                                        ShowInCustomizationForm="True" SortIndex="0" SortOrder="Ascending" 
                                        VisibleIndex="0" Width="150px">
                                        <Settings AllowSort="True" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Razón Social" FieldName="CardName" 
                                        ShowInCustomizationForm="True" VisibleIndex="1">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="RUC/DNI" FieldName="LicTradNum" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="2">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Lista de Precios" FieldName="ListNum" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="3">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Vendedor Asignado" FieldName="SlpCode" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="4">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="GroupNum" FieldName="GroupNum" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="5">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="CDR Defecto" FieldName="ShipToDef" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="6">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="DDR Defecto" FieldName="ShipStreet" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="7">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="CDF Defecto" FieldName="BillToDef" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="8">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="DDF Defecto" FieldName="BillStreet" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="9">
                                    </dx:GridViewDataTextColumn>
                                </Columns>
                                <SettingsBehavior AllowSelectByRowClick="True" 
                                    AllowSelectSingleRowOnly="True" />
                                <ClientSideEvents ColumnSorting="SetParName" RowDblClick="OkClient" EndCallback="EndClientSearch"/>
                                <Styles>
                                    <Row Font-Size="7pt">
                                    </Row>
                                </Styles>
                            </dx:ASPxGridView>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width:100%;" class="tablespace">
                                <tr>
                                    <td style="width:340px">
                                        &nbsp;</td>
                                    <td>
                                        <dx:ASPxButton ID="btnClientOk" runat="server" Text="Ok" Width="100%" 
                                            ClientInstanceName="btnClientOk" AutoPostBack="False">
                                            <ClientSideEvents Click="OkClient" />
                                        </dx:ASPxButton>
                                    </td>
                                    <td>
                                        <dx:ASPxButton ID="btnClientCancel" runat="server" Text="Cancelar" Width="100%" 
                                            ClientInstanceName="btnClientCancel" AutoPostBack="False">
                                            <ClientSideEvents Click="CancelClient" />
                                        </dx:ASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    <dx:ASPxPopupControl ID="ppcClientAddress" runat="server" 
        ClientInstanceName="ppcClientAddress" FooterText=" " HeaderText="Direcciones del Cliente Seleccionado" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" 
        RenderMode="Lightweight" ShowFooter="True" Width="500px" Modal="true"
        AllowDragging="True" PopupAnimationType="Fade">
        <ContentStyle>
            <Paddings PaddingBottom="0px" />
        </ContentStyle>
        <ContentCollection>
            <dx:PopupControlContentControl runat="server" SupportsDisabledAttribute="True">
                <table border="0" style="width:100%">
                    <tr>
                        <td>
                            <dx:ASPxGridView ID="gdvAddress" runat="server" Width="100%" 
                                AutoGenerateColumns="False" ClientInstanceName="gdvAddress" 
                                KeyFieldName="Address" OnCustomCallback="gdvAddress_CustomCallback" 
                                OnDataBinding="gdvAddress_DataBinding"
                                KeyboardSupport="True">
                                <Columns>
                                    <dx:GridViewCommandColumn ShowInCustomizationForm="True" ShowSelectCheckbox="True" VisibleIndex="0" Width="25px">
                                    </dx:GridViewCommandColumn>
                                    <dx:GridViewDataTextColumn Caption="Tipo" FieldName="Address" 
                                        ShowInCustomizationForm="True"
                                        VisibleIndex="1" Width="100px">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Dirección" FieldName="Street" 
                                        ShowInCustomizationForm="True" VisibleIndex="2">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="AdresType" FieldName="AdresType" 
                                        ShowInCustomizationForm="True" Visible="true" VisibleIndex="0">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="InDef" FieldName="InDef" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="1">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="U_BIZ_ZONA" FieldName="U_BIZ_ZONA" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="1">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="U_BIZ_CODI" FieldName="U_BIZ_CODI" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="1">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="U_BIZ_MOV" FieldName="U_BIZ_MOV" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="1">
                                    </dx:GridViewDataTextColumn>
                                </Columns>
                                <SettingsBehavior AllowSort="False" />
                                <SettingsPager Visible="False">
                                </SettingsPager>
                                <Styles>
                                    <Row Font-Size="7pt">
                                    </Row>
                                </Styles>
                                <ClientSideEvents EndCallback="End_AddrCallback" />
                            </dx:ASPxGridView>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width:100%;" class="tablespace">
                                <tr>
                                    <td style="width:340px">
                                        &nbsp;</td>
                                    <td>
                                        <dx:ASPxButton ID="btnClientAddressOk" runat="server" Text="Ok" Width="100%" 
                                            ClientInstanceName="btnClientAddressOk" AutoPostBack="False">
                                            <ClientSideEvents Click="OkClientAddress" />
                                        </dx:ASPxButton>
                                    </td>
                                    <td>
                                        <dx:ASPxButton ID="btnClientAddressCancel" runat="server" Text="Cancelar" Width="100%" 
                                            ClientInstanceName="btnClientAddressCancel" AutoPostBack="False">
                                            <ClientSideEvents Click="CancelClientAddress" />
                                        </dx:ASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    <dx:ASPxPopupControl ID="ppcLotesNumber" runat="server" 
        ClientInstanceName="ppcLotesNumber" FooterText=" " HeaderText="Seleccionar Lotes" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" 
        RenderMode="Lightweight" ShowFooter="True" Width="420px" Modal="true" Height="200px"
        AllowDragging="True" PopupAnimationType="Fade">
        <ContentStyle>
            <Paddings PaddingBottom="0px" />
        </ContentStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server" SupportsDisabledAttribute="True">
                <table border="0" style="width:100%">
                    <tr>
                        <td>
                            <table style="width:100%;" class="tablespace">
                                <tr>
                                    <td id="Td10" style="width:105px">
                                        </td>
                                    <td style="width:280px">
                                        <dx:ASPxTextBox ID="ASPxTextBox2" runat="server" Width="100%" 
                                            ClientInstanceName="txtParClient" Visible="false">
                                        </dx:ASPxTextBox>
                                    </td>
                                    <td>
                                        <%--<dx:ASPxButton ID="ASPxButton1" runat="server" Text="Buscar" Width="100%" 
                                            ClientInstanceName="bteClientSearch" AutoPostBack="False">
                                            <ClientSideEvents Click="Get_Client"/>
                                        </dx:ASPxButton>--%>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxGridView ID="gdvLotes" runat="server" Width="400px" 
                                    AutoGenerateColumns="False" ClientInstanceName="gdvLotes" 
                                    KeyFieldName="Lote" OnCustomCallback="gdvLotes_CustomCallback" 
                                    KeyboardSupport="True" OnDataBinding="gdvLotes_DataBinding" 
                                    OnCellEditorInitialize="gdvLotes_CellEditorInitialize" 
                                    OnCommandButtonInitialize="gdvLotes_CommandButtonInitialize"
                                    OnRowUpdating="gdvLotes_RowUpdating" OnRowInserting="gdvLotes_RowInserting">
                                    <Columns>
                                        <dx:GridViewCommandColumn Caption="Operación" ShowInCustomizationForm="True" 
                                            VisibleIndex="0" Width="60px">
                                            <NewButton Visible="True">
                                            </NewButton>
                                            <EditButton Visible="True">
                                            </EditButton>
                                            <CellStyle Font-Size="8pt">
                                            </CellStyle>
                                        </dx:GridViewCommandColumn>
                                        <dx:GridViewDataTextColumn Caption="Lote" FieldName="Lote" 
                                            ShowInCustomizationForm="True" SortIndex="0" SortOrder="Ascending" 
                                            VisibleIndex="0" Width="60px" PropertiesTextEdit-ClientInstanceName="Lote">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataDateColumn Caption="Fecha Venc." FieldName="DueDate" 
                                            ShowInCustomizationForm="True" VisibleIndex="3" Width="40px" PropertiesDateEdit-ClientInstanceName="DueDate">
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataTextColumn Caption="Cantidad" FieldName="Cantidad" 
                                            ShowInCustomizationForm="True" VisibleIndex="4" Width="30px" PropertiesTextEdit-ClientInstanceName="Cantidad">
                                        </dx:GridViewDataTextColumn>
                                    </Columns>
                                    <SettingsBehavior AllowSelectByRowClick="True" 
                                        AllowSelectSingleRowOnly="True" />
                                    <ClientSideEvents />
                                    <Styles>
                                        <Row Font-Size="7pt">
                                        </Row>
                                    </Styles>
                                </dx:ASPxGridView>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width:100%;" class="tablespace">
                                <tr>
                                    <td style="width:340px">
                                        &nbsp;</td>
                                    <td style="text-align:center;">
                                        <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Ok" Width="100%" 
                                            ClientInstanceName="btnClientOk" AutoPostBack="False">
                                            <ClientSideEvents Click="OK_Lotes" />
                                        </dx:ASPxButton>
                                    </td>
                                    <td style="text-align:center;">
                                        <dx:ASPxButton ID="ASPxButton2" runat="server" Text="Cancelar" Width="100%" 
                                            ClientInstanceName="btnClientCancel" AutoPostBack="False">
                                            <ClientSideEvents Click="CancelLotes" />
                                        </dx:ASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
     <dx:ASPxPopupControl ID="ASPxSerialNumber" runat="server" 
        ClientInstanceName="ppcSerialNumber" FooterText=" " HeaderText="Seleccionar Serie" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" 
        RenderMode="Lightweight" ShowFooter="True" Width="320px" Modal="true" Height="200px"
        AllowDragging="True" PopupAnimationType="Fade">
        <ContentStyle>
            <Paddings PaddingBottom="0px" />
        </ContentStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" SupportsDisabledAttribute="True">
                <table border="0" style="width:100%">
                    <tr>
                        <td>
                            <table style="width:100%;" class="tablespace">
                                <tr>
                                    
                                    <td style="width:280px">
                                        <dx:ASPxTextBox ID="txtSerie" runat="server" Width="100%" 
                                            ClientInstanceName="txtSerie" Visible="true">
                                        </dx:ASPxTextBox>
                                    </td>
                                    <td>
                                        <dx:ASPxButton ID="btnSerieAdd" runat="server" Text="Agregar" Width="100%" 
                                            ClientInstanceName="btnSerieAdd" AutoPostBack="False">
                                            <ClientSideEvents Click="Agregar_Serie"/>
                                        </dx:ASPxButton>
                                    </td>
                                    <td>
                                        <dx:ASPxButton ID="btnSerieQuitar" runat="server" Text="Quitar" Width="100%" 
                                            ClientInstanceName="btnSerieQuitar" AutoPostBack="False">
                                            <ClientSideEvents Click="Quitar_Serie"/>
                                        </dx:ASPxButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width:320px">
                                        <input type="file" name="xlfile" id="xlf" /> <input type="checkbox" name="useworker" checked="checked" />
                                        <input type="checkbox" name="userabs" checked="checked"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width:320px">
                                        <div id="drop"> </div>
                                        <pre id="out"></pre>
                                        <p id="htmlout"></p>
                                        
                                        <br />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxListBox  ID="ListSeries" runat="server" KeyFieldName="SysNumber"
                                ValueType="System.String" ClientInstanceName="ListSeries" 
                                Height="320px" Width="300px" SelectionMode="CheckColumn">
                                <Columns>
                                    <%--<dx:ListBoxColumn Caption="Codigo" FieldName="ItemCode"/>--%>
                                    <dx:ListBoxColumn Caption="Serie" FieldName="Serie" />
                                    <%--<dx:ListBoxColumn Caption="SysNumber" FieldName="SysNumber" />--%>
                                </Columns>
                            </dx:ASPxListBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width:100%;" class="tablespace">
                                <tr>
                                    <td style="width:340px">
                                        &nbsp;</td>
                                    <td>
                                        <dx:ASPxButton ID="ASPxAceptarSerie" runat="server" Text="Ok" Width="100%" 
                                            ClientInstanceName="btnClientOk" AutoPostBack="False">
                                            <ClientSideEvents Click="OK_Series" />
                                        </dx:ASPxButton>
                                    </td>
                                    <td>
                                        <dx:ASPxButton ID="ASPxCancelarSerie" runat="server" Text="Cancelar" Width="100%" 
                                            ClientInstanceName="btnClientCancel" AutoPostBack="False">
                                            <ClientSideEvents Click="CancelSeries" />
                                        </dx:ASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    <dx:ASPxPopupControl ID="ppcPrecio" runat="server" 
        ClientInstanceName="ppcPrecio" FooterText=" " HeaderText="Buscar Proveedor" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" 
        RenderMode="Lightweight" ShowFooter="True" Width="200px" Modal="true"
        AllowDragging="True" PopupAnimationType="Fade">
        <ContentStyle>
            <Paddings PaddingBottom="0px" />
        </ContentStyle>
        <ContentCollection>
            <dx:PopupControlContentControl runat="server" SupportsDisabledAttribute="True">
                <table border="0" style="width:100%">
                    <tr>
                        <td>
                            <table style="width:100%;" class="tablespace">
                                <tr>
                                    <td id="" style="width:180px">
                                        <dx:ASPxRadioButtonList ID="rbtnPrecio" runat="server" Height="20px" 
                                                    RepeatDirection="Vertical" Width="100%" SelectedIndex="0" 
                                                    ClientInstanceName="rbtnPrecio" Border-BorderStyle="None">
                                            <Items>
                                                <dx:ListEditItem Text="C/ IGV" Value="Y" Selected="True" />
                                                <dx:ListEditItem Text="S/ IGV" Value="N" />
                                            </Items>
                                        </dx:ASPxRadioButtonList>
                                    </td>
                                </tr>
                                <tr>
                                    <td id="" style="width:80px">
                                        Ingresar Precio: </td>
                                    <td style="width:100px">
                                        <dx:ASPxTextBox ID="AddPrecio" runat="server" Width="100%" 
                                            ClientInstanceName="AddPrecio" DisplayFormatString="{0:n4}" Text="0">
                                            <ClientSideEvents KeyUp="OkPrecio" />
                                        </dx:ASPxTextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width:100%;" class="tablespace">
                                <tr>
                                    <td style="width:340px">
                                        &nbsp;</td>
                                    <td>
                                        <dx:ASPxButton ID="btnOkPrecio" runat="server" Text="Ok" Width="100%" 
                                            ClientInstanceName="btnOkPrecio" AutoPostBack="False">
                                            <ClientSideEvents Click="OkPrecio" />
                                        </dx:ASPxButton>
                                    </td>
                                    <td>
                                        <dx:ASPxButton ID="btnCancelPrecio" runat="server" Text="Cancelar" Width="100%" 
                                            ClientInstanceName="btnCancelPrecio" AutoPostBack="False">
                                            <ClientSideEvents Click="CancelPrecio" />
                                        </dx:ASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    <dx:ASPxPopupControl ID="ppcProductSearch" runat="server" 
            ClientInstanceName="ppcProductSearch" FooterText=" " HeaderText="Buscar Producto" 
            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" 
            RenderMode="Lightweight" ShowFooter="True" Width="800px" Modal="true"
            AllowDragging="True" PopupAnimationType="Fade">
            <ContentStyle>
                <Paddings PaddingBottom="0px" />
            </ContentStyle>
            <ContentCollection>
                <dx:PopupControlContentControl ID="pccProductSearch" runat="server" SupportsDisabledAttribute="True">
                    <table border="0" style="width:100%">
                        <tr>
                            <td>
                                <table class="tablespace" style="width:100%">
                                    <tr>
                                        <td id="Product" style="width:105px">
                                            Código:</td>
                                        <td style="width:300px">
                                            <dx:ASPxTextBox ID="txtParProduct" runat="server" Width="100px" 
                                                ClientInstanceName="txtParProduct">
                                                <ClientSideEvents KeyPress="Get_Product" />
                                            </dx:ASPxTextBox>
                                        </td>
                                        
                                        <td id="Product2" style="width:105px">
                                            Descripción:</td>
                                        <td style="width:300px">
                                            <dx:ASPxTextBox ID="txtDescription" runat="server" Width="400px" 
                                                ClientInstanceName="txtDescription">
                                                <ClientSideEvents KeyUp="Get_Product" />
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td id="Product3" style="width:105px">
                                            Marca:</td>
                                        <td style="width:300px">
                                            <dx:ASPxTextBox ID="txtMarca" runat="server" Width="100px" 
                                                ClientInstanceName="txtMarca">
                                                <ClientSideEvents KeyUp="Get_Product" />
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td>
                                            <dx:ASPxButton ID="btnProductSearch" runat="server" Text="Buscar" Width="100%" 
                                                ClientInstanceName="btnProductSearch" AutoPostBack="False">
                                                <ClientSideEvents Click="Get_Product" />
                                            </dx:ASPxButton>
                                        </td>
                                        <td style="width:5px">
                                        </td>
                                        <td style="width:80px">
                                        Almacén:
                                        <%--<dx:ASPxTextBox ID="txtWareHouse" runat="server"
                                            ClientInstanceName="txtWareHouse" Text="Almacén: " TextAlign="Left" Visible="true">
                                        </dx:ASPxTextBox>--%>
                                        </td>
                                        <td style="width:200px">
                                            <dx:ASPxComboBox ID="cbbWareHouse" runat="server" Width="100%" 
                                                ClientInstanceName="cbbWareHouse" ClientVisible="true" Visible="true">
                                                <ClientSideEvents SelectedIndexChanged="search_warehouse" />
                                            </dx:ASPxComboBox>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dx:ASPxGridView ID="gdvProductSearch" runat="server" Width="100%" 
                                    AutoGenerateColumns="False" ClientInstanceName="gdvProductSearch" 
                                    KeyFieldName="ItemCode" OnCustomCallback="gdvProductSearch_CustomCallback" 
                                    KeyboardSupport="True" OnDataBinding="gdvProductSearch_DataBinding">
                                    <Columns>
                                        <dx:GridViewDataTextColumn Caption="Código" FieldName="ItemCode" 
                                            ShowInCustomizationForm="True" SortIndex="0" SortOrder="Ascending" 
                                            VisibleIndex="0" Width="60px">
                                            <Settings AllowSort="True" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Descripción" FieldName="ItemName" 
                                            ShowInCustomizationForm="True" VisibleIndex="1" Width="290px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Stock" FieldName="OnHand" 
                                            ShowInCustomizationForm="True" VisibleIndex="2" Width="50px">
                                            <Settings AllowSort="False" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Precio Unit." FieldName="PriceBefDi" 
                                            ShowInCustomizationForm="True" VisibleIndex="3" Width="80px">
                                            <PropertiesTextEdit DisplayFormatString="n4"></PropertiesTextEdit>
                                            <Settings AllowSort="False" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="% Desc." FieldName="DiscPrcnt" 
                                            ShowInCustomizationForm="True" VisibleIndex="4" Width="50px">
                                            <Settings AllowSort="False" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Precio S/IGV" FieldName="Price" 
                                            ShowInCustomizationForm="True" VisibleIndex="5" Width="80px">
                                            <PropertiesTextEdit DisplayFormatString="n4"></PropertiesTextEdit>
                                            <Settings AllowSort="False" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Precio C/IGV" FieldName="PriceVat" 
                                            ShowInCustomizationForm="True" VisibleIndex="6" Width="80px">
                                            <PropertiesTextEdit DisplayFormatString="n4"></PropertiesTextEdit>
                                            <Settings AllowSort="False" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Numero de Serie" FieldName="IssueMthd" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="7" Width="80px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Cantidad de Compra" FieldName="NumInBuy" 
                                            ShowInCustomizationForm="True" Visible="true" VisibleIndex="8" Width="80px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="ActivoC" FieldName="ActivoC" 
                                        ShowInCustomizationForm="True" Visible="true" VisibleIndex="9" 
                                        Width="80px">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="ActivoS" FieldName="ActivoS" 
                                        ShowInCustomizationForm="True" Visible="true" VisibleIndex="10" 
                                        Width="80px">
                                    </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="InvntItem" FieldName="InvntItem" 
                                        ShowInCustomizationForm="True" Visible="true" VisibleIndex="11" 
                                        Width="80px">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="LastPurCur" FieldName="LastPurCur" 
                                        ShowInCustomizationForm="True" Visible="true" VisibleIndex="12" 
                                        Width="80px">
                                    </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Marca" FieldName="U_GOS_MARCA" 
                                            ShowInCustomizationForm="True" Visible="true" VisibleIndex="13" 
                                            Width="80px">
                                        </dx:GridViewDataTextColumn>
                                        <%--<dx:GridViewDataTextColumn Caption="Kit" FieldName="U_BF_CodKit" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="7" Width="80px">
                                        </dx:GridViewDataTextColumn>--%>
                                    </Columns>
                                    <SettingsBehavior AllowSelectByRowClick="True" 
                                        AllowSelectSingleRowOnly="True" />
                                    <ClientSideEvents ColumnSorting="SetParName" RowDblClick="OkProduct" EndCallback="EndProductSearch"/>
                                    <Styles>
                                        <Row Font-Size="7pt">
                                        </Row>
                                    </Styles>
                                </dx:ASPxGridView>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table style="width:100%;" class="tablespace">
                                    <tr>
                                        <td style="width:650px">
                                            &nbsp;</td>
                                        <td>
                                            <dx:ASPxButton ID="btnProductOk" runat="server" Text="Ok" Width="100%" 
                                                ClientInstanceName="btnProductOk" AutoPostBack="False">
                                                <ClientSideEvents Click="OkProduct" />
                                            </dx:ASPxButton>
                                        </td>
                                        <td>
                                            <dx:ASPxButton ID="btnProductCancel" runat="server" Text="Cancelar" Width="100%" 
                                                ClientInstanceName="btnProductCancel" AutoPostBack="False">
                                                <ClientSideEvents Click="CancelProduct" />
                                            </dx:ASPxButton>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </dx:PopupControlContentControl>
            </ContentCollection>
        </dx:ASPxPopupControl>
        <dx:ASPxPopupControl ID="ppcQKit" runat="server" 
            ClientInstanceName="ppcQKit" FooterText=" " HeaderText="Unidades del Kit" 
            RenderMode="Lightweight" ShowFooter="True" Width="170px"
            AllowDragging="True" PopupAnimationType="Fade" 
            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter">
            <ContentStyle>
                <Paddings PaddingBottom="0px" />
            </ContentStyle>
            <ContentCollection>
                <dx:PopupControlContentControl ID="pccQKit" runat="server" SupportsDisabledAttribute="True">                    
                    <table class="tablespace" style="width:100%">
                        <tr>
                            <td style="width:100px">
                                Cantidad:</td>
                            <td style="width:100%">
                                <dx:ASPxTextBox ID="txtQKit" runat="server" Width="100%" ClientInstanceName="txtQKit"
                                 DisplayFormatString="f0" HorizontalAlign="Center">
                                <MaskSettings Mask="&lt;0..99999999&gt;" />
                                <ValidationSettings ErrorDisplayMode="None">
                                    <ErrorFrameStyle>
                                        <Paddings Padding="0px" />
                                        <Border BorderWidth="0px" />
                                    </ErrorFrameStyle>
                                </ValidationSettings>
                                </dx:ASPxTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:100px">
                                &nbsp;</td>
                            <td style="text-align:right;width:100%">
                                <dx:ASPxButton ID="btnOKQKit" runat="server" AutoPostBack="False" Text="OK" 
                                    Width="50px" ClientInstanceName="btnOKQKit">
                                    <ClientSideEvents Click="Add_Kits" />
                                </dx:ASPxButton>
                            </td>
                        </tr>
                    </table>                    
                </dx:PopupControlContentControl>
            </ContentCollection>
        </dx:ASPxPopupControl>
    <dx:ASPxPopupControl ID="ppcOdlnSearch" runat="server" 
            ClientInstanceName="ppcOdlnSearch" FooterText=" " HeaderText="Buscar Documento de Entrega" 
            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" 
            RenderMode="Lightweight" ShowFooter="True" Width="800px" Modal="true"
            AllowDragging="True" PopupAnimationType="Fade">
            <ContentStyle>
                <Paddings PaddingBottom="0px" />
            </ContentStyle>
            <ContentCollection>
                <dx:PopupControlContentControl ID="pccOdlnSearch" runat="server" SupportsDisabledAttribute="True">
                    <table border="0" style="width:100%">
                        <tr>
                            <td>
                                <table class="tablespace" style="width:100%">
                                    <tr>
                                        <td style="width:105px">
                                            <dx:ASPxCheckBox ID="chkRangeDate" runat="server" Checked="True" 
                                                CheckState="Checked" ClientInstanceName="chkRangeDate"
                                                Text="Rango Fechas:" Width="105px">
                                                <ClientSideEvents CheckedChanged="Clear_RangeDate" />
                                            </dx:ASPxCheckBox>
                                        </td>
                                        <td style="width:130px">
                                            <dx:ASPxDateEdit ID="dteDateIn" runat="server" Width="130px" 
                                                ClientInstanceName="dteDateIn">
                                            </dx:ASPxDateEdit>
                                        </td>
                                        <td style="width:130px">
                                            <dx:ASPxDateEdit ID="dteDateFi" runat="server" Width="130px" 
                                                ClientInstanceName="dteDateFi">
                                            </dx:ASPxDateEdit>
                                        </td>
                                        <td style="width:5px">
                                        </td>
                                        <td style="width:130px">
                                            Serie:</td>
                                        <td style="width:170px">
                                            <dx:ASPxTextBox ID="txtNumAtCards" runat="server"
                                                ClientInstanceName="txtNumAtCards" Width="170px">
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td style="width:130px">
                                            Correlativo:</td>
                                        <td style="width:100px">
                                            <dx:ASPxTextBox ID="txtCorrelativo" runat="server"
                                                ClientInstanceName="txtCorrelativo" Width="100px">
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td style="width:50px">
                                            <dx:ASPxButton ID="btnOdlnSearch" runat="server" AutoPostBack="False" 
                                                ClientInstanceName="btnOdlnSearch" Text="Buscar" Width="100%">
                                                <ClientSideEvents Click="Get_Odln" />
                                            </dx:ASPxButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width:105px">
                                            Razón Social:</td>
                                        <td colspan="2">
                                            <dx:ASPxTextBox ID="txtsCardName" runat="server" 
                                                ClientInstanceName="txtsCardName" Width="260px">
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td style="width:5px">
                                            </td>
                                        <td style="width:130px">
                                            Código Cliente:</td>
                                        <td style="width:170px">
                                            <dx:ASPxTextBox ID="txtsCardCode" runat="server" 
                                                ClientInstanceName="txtsCardCode" Width="170px">
                                            </dx:ASPxTextBox>
                                        </td>
                       
                                    </tr>
                                    <tr>
                                    <td style="width:105px">
                                        Dirección:</td>
                                    <td colspan="2">
                                        <dx:ASPxTextBox ID="txtdirec" runat="server" 
                                            ClientInstanceName="txtdirec" Width="260px">
                                        </dx:ASPxTextBox>
                                    </td>
                                    <td style="width:5px">
                                    </td>
                                        <td style="width:40px"></td>
                                        <td>
                                             <dx:ASPxButton ID="btnExport" runat="server" AutoPostBack="False" 
                                                OnClick="btnExport_Click" Text="Exportar" Width="100%">
                                            </dx:ASPxButton>
                                        </td>
                                    
                                </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dx:ASPxGridView ID="gdvodlnSearch" runat="server" Width="100%" 
                                    AutoGenerateColumns="False" ClientInstanceName="gdvodlnSearch" 
                                    KeyFieldName="DocEntry" OnCustomCallback="gdvodlnSearch_CustomCallback" 
                                    KeyboardSupport="True" OnDataBinding="gdvodlnSearch_DataBinding">
                                    <Columns>
                                        <dx:GridViewDataTextColumn Caption="Nro. Documento" FieldName="NumAtCard" 
                                            ShowInCustomizationForm="True" VisibleIndex="0" Width="70px">
                                            <Settings AllowSort="False" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Fecha" FieldName="DocDate"
                                            ShowInCustomizationForm="True" VisibleIndex="1" Width="70px">
                                            <PropertiesTextEdit DisplayFormatString="d">
                                            </PropertiesTextEdit>
                                            <Settings AllowSort="False" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Estado" FieldName="DocStatus" 
                                            ShowInCustomizationForm="True" VisibleIndex="2" Width="60px">
                                            <Settings AllowSort="False" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Cód. Cliente" FieldName="CardCode" 
                                            ShowInCustomizationForm="True" VisibleIndex="3" Width="70px">
                                            <Settings AllowSort="False" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Razón Social" FieldName="CardName" 
                                            ShowInCustomizationForm="True" VisibleIndex="4" Width="200px">
                                            <Settings AllowSort="False" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Total" FieldName="DocTotalSrch" 
                                            ShowInCustomizationForm="True" VisibleIndex="5" Width="80px">
                                            <PropertiesTextEdit DisplayFormatString="c2">
                                                <Style HorizontalAlign="Right"></Style>
                                            </PropertiesTextEdit>
                                            <Settings AllowSort="False" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="DocEntry" FieldName="DocEntry" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="6" Width="0px">                                           
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="DocNum" FieldName="DocNum" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="7" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="LicTradNum" FieldName="LicTradNum" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="8" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="U_BPP_MDTD" FieldName="U_BPP_MDTD" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="9" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="U_BPP_MDSD" FieldName="U_BPP_MDSD" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="10" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="U_BPP_MDCD" FieldName="U_BPP_MDCD" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="11" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="SlpCode" FieldName="SlpCode" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="12" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="OwnerCode" FieldName="OwnerCode" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="13" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="GroupNum" FieldName="GroupNum" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="14" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Comments" FieldName="Comments" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="15" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="U_BF_PED_ORIG" FieldName="U_BF_PED_ORIG" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="16" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="DiscPrcntTotal" FieldName="DiscPrcntTotal" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="17" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="DiscSum" FieldName="DiscSum" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="18" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="TotalExpns" FieldName="TotalExpns" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="19" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="PaidToDate" FieldName="PaidToDate" 
                                        ShowInCustomizationForm="True" Visible="false" VisibleIndex="20" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="ShipToCode" FieldName="ShipToCode" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="21" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="PayToCode" FieldName="PayToCode" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="22" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="BillStreet" FieldName="BillStreet" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="23" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="ShipStreet" FieldName="ShipStreet" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="24" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="DocCur" FieldName="DocCur" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="25" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="ListNumSrch" FieldName="ListNumSrch" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="26" Width="0px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="TaxDate" FieldName="TaxDate" 
                                            ShowInCustomizationForm="True" Visible="false" VisibleIndex="27" Width="0px">
                                        </dx:GridViewDataTextColumn>

                                    </Columns>
                                    <SettingsBehavior AllowSelectByRowClick="True" 
                                        AllowSelectSingleRowOnly="True" />
                                    <ClientSideEvents RowDblClick="OkOdln" EndCallback="EndOdlnSearch"/>
                                    <Styles>
                                        <Row Font-Size="7pt">
                                        </Row>
                                    </Styles>
                                         <SettingsPager Visible="False" Mode="ShowAllRecords">
                                                    </SettingsPager>
                                                    <SettingsEditing Mode="Inline" NewItemRowPosition="Bottom" />
                                                    <Settings ShowFooter="True" ShowTitlePanel="True" />
                                                    <SettingsText Title="Guia de Remision - Compras" />
                                                    <Styles>
                                                        <Row Font-Size="7pt">
                                                        </Row>
                                                        <Footer Font-Size="1pt">
                                                        </Footer>
                                                        <TitlePanel Font-Bold="True" Font-Size="7pt" HorizontalAlign="Center">
                                                        </TitlePanel>
                                                    </Styles>
                                </dx:ASPxGridView>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table style="width:100%;" class="tablespace">
                                    <tr>
                                        <td style="width:650px">
                                            &nbsp;</td>
                                        <td>
                                            <dx:ASPxButton ID="btnOdlnOk" runat="server" Text="Ok" Width="100%" 
                                                ClientInstanceName="btnOdlnOk" AutoPostBack="False">
                                                <ClientSideEvents Click="OkOdln" />
                                            </dx:ASPxButton>
                                        </td>
                                        <td>
                                            <dx:ASPxButton ID="btnOdlnCancel" runat="server" Text="Cancelar" Width="100%" 
                                                ClientInstanceName="btnOdlnCancel" AutoPostBack="False">
                                                <ClientSideEvents Click="CancelOdln" />
                                            </dx:ASPxButton>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </dx:PopupControlContentControl>
            </ContentCollection>
        </dx:ASPxPopupControl>
     <dx:ASPxGridViewExporter ID="gexData" runat="server" GridViewID="gdvodlnSearch">
    </dx:ASPxGridViewExporter>
        <dx:ASPxCallback ID="clbOperation" runat="server" 
        ClientInstanceName="clbOperation" oncallback="clbOperation_Callback">
        <ClientSideEvents CallbackComplete="Com_Operation" />
        </dx:ASPxCallback>
    <script type="text/javascript" src="../Scripts/JSExcel/ExcelGuiaCompra.js"></script>
</asp:Content>

