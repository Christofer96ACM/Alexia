var _vld = [8];
var DIRECCIONES = "";
var _dcs = [];
var _vld = [8];
var ult = 0;
$(document).ready(function () {
    //pestañascrearclie();
    try {
        Set_VisibleOption();
        Get_InitialData();
    } catch (e) {
        alert(e.Message);
    }
});
function Get_Tecnico1(s, e) {
    gdvTecnicosrch.PerformCallback();
    if (e.htmlEvent.keyCode === 13) {
        gdvTecnicosrch.SetFocusedRowIndex(0);
        OkTecnico();
        ASPxClientUtils.PreventEventAndBubble(e.htmlEvent);
    }
}
function Get_Tecnico() {
    gdvTecnicosrch.PerformCallback();
}
function OkTecnico() {
    var rowc = gdvTecnicosrch.GetVisibleRowsOnPage();
    if (rowc === 0) {
        alert("No existen registros para realizar esta operación.");
    }
    else if (gdvTecnicos.GetVisibleRowsOnPage() == 6) {
        alert("Solo se permiten  6 técnicos Auxiliares.")
    }
    else if (gdvTecnicosrch.GetFocusedRowIndex() === -1) {
        alert("Seleccione un registro para realizar esta operación.");
    }
    else {
        gdvTecnicosrch.GetRowValues(gdvTecnicosrch.GetFocusedRowIndex(), "ID;Tecnico", OnGetRowValuesTecnico);
    }
}
function OnGetRowValuesTecnico(values) {

    gdvTecnicos.PerformCallback("ADD:" + values[0] + ":" + values[1]);

    ppcTecnicoSearch.Hide();
}
function CancelTecnico() {
    ppcTecnicoSearch.Hide();
}
function Show_TecnicoSearch() {
    ppcTecnicoSearch.Show();
}
function Get_Service() {
    gdvServicio.PerformCallback("GET");
}
function Get_Service1() {

}
function Get_Service2(s, e) {

}
function okServicio() {
    var rowc = gdvServicio.GetVisibleRowsOnPage();
    if (rowc === 0) {
        alert("No existen registros para realizar esta operación.")
    }
    else if (gdvServicio.GetFocusedRowIndex() === -1) {
        alert("Seleccione un registro para realizar esta operación.")
    }
    else {
        gdvServicio.GetRowValues(gdvServicio.GetFocusedRowIndex(), "CallId;ItemCode;ItemName;CardCode;CardName;SerieFab;SerieInt;ItmsGrpCod;IdDireccion;Street;State;U_DXP_BIZ_PROV;U_DXP_BIZ_DIST;Asunto;Estado;Prioridad;Creacion;Cerrado;NroContrato;Origen;TipoProblema;Tecnico;DetalleServicio;Comentario;Resolucion;Cellular;ContactPerson;AddressType;U_GOS_TECN1;U_GOS_TECN2;U_GOS_TECN3;U_GOS_TECN4;U_GOS_TECN5;U_GOS_TECN6", OnGetRowValuesServicio);
    }
}
function OnGetRowValuesServicio(values) {
    txtcontctCode1.PerformCallback("INICIAR:" + values[3]);
    //cbbAddress.PerformCallback("GET:" + values[3]);
    bteCustomer.SetText(values[3]);
    txtCustomerName.SetText(values[4]);
    hdfTemp.Set("adrtype", values[27]);
    cbStatus.SetValue(values[14])
    txttelf.SetText(values[25]);
    cbbPriority.SetValue(values[15]);
    txtcontctCode1.SetText(values[26]);
    txtidllamada.SetText(values[0]);
    
    txtDepartamento1.SetText(values[10]);
    txtProvincia1.SetText(values[11]);
    txtDistrito1.SetText(values[12]);
    txtStreets1.SetText(values[9]);
    txtmanufSN1.SetText(values[5]);
    txtinternalSN.SetText(values[6]);
    txtcreateDate1.SetText(values[16]);
    txtcloseDate1.SetText(values[17]);
    txtitemCode.SetText(values[1]);
    txtItemName.SetText(values[2]);
    txtnumContrato.SetText("");
    //txtcntrctDate
    //txtItemGroup.SetText(values[7]);
    txtSubject.SetText(values[13]);
    cbbOrigin.SetValue(values[19])
    cbbProblemTyp.SetValue(values[20])
    cbbCallType.SetValue(values[22])
    cbbTecnico.SetValue(values[21])
    mmoResolution.SetText(values[24]);
    mmoComments.SetText(values[23]);
    cbbAddress.SetText(values[8]);
    gdvTecnicos.PerformCallback("GET:" + values[28] + ":" + values[29] + ":" + values[30] + ":" + values[31] + ":" + values[32] + ":" + values[33]);
    mnuOper.GetItemByName("Save").SetText("Modificar");
    ppcServicioSearch.Hide();
}
function CancelServicio() {
    ppcServicioSearch.Hide();
}
function Get_InitialData() {
    var socied = hdfTemp.Get("_soci");
    $.ajax(
    {
        type: "POST",
        url: "../Servicio/LlamadaServicio.aspx/GET_VALORES_SERVICIO",
        data: '{"socied":"' + socied + '"}',
        contentType: "application/json; charset=uft-8",
        dataType: "json",
        success: function (result) {
            Set_InitialData(result);
        },
        error: function (result) {
            alert(result);
        }
    });
}
function Set_InitialData(result) {
    dteFecha.SetDate(new Date());
    txtcreateDate1.SetDate(new Date());
    txtcloseDate1.SetDate(new Date());
    txtnumContrato.SetText("-");
    //bteCustomer.SetEnabled(false);
    //txtCustomerName.SetEnabled(false);
    //txttelf.SetEnabled(false);
    //txtidllamada.SetEnabled(false);

    //txtDepartamento1.SetEnabled(false);
    //txtProvincia1.SetEnabled(false);
    //txtDistrito1.SetEnabled(false);
    //txtStreets1.SetEnabled(false);
    //txtmanufSN1.SetEnabled(false);
    //txtinternalSN.SetEnabled(false);
    //txtcreateDate1.SetEnabled(false);
    //txtcloseDate1.SetEnabled(false);
    //txtitemCode.SetEnabled(false);
    //txtItemName.SetEnabled(false);
    //txtnumContrato.SetEnabled(false);
    var _rs1 = result.d.where(function (item) { return (item.CLAVE === "OS"); });
    cbbOrigin.BeginUpdate();
    cbbOrigin.ClearItems();
    _rs1.forEach(function (item) {
        cbbOrigin.AddItem(item.VALOR, item.INDEX);
    });
    cbbOrigin.EndUpdate();
    cbbOrigin.SetValue(-1);

    var _rs = result.d.where(function (item) { return (item.CLAVE === "CT"); });
    cbbCallType.BeginUpdate();
    cbbCallType.ClearItems();
    _rs.forEach(function (item) {
        cbbCallType.AddItem(item.VALOR, item.INDEX);
    });
    cbbCallType.EndUpdate();
    cbbCallType.SetSelectedIndex(0);

    var _rs2 = result.d.where(function (item) { return (item.CLAVE === "TE"); });
    cbbProblemTyp.BeginUpdate();
    cbbProblemTyp.ClearItems();
    _rs2.forEach(function (item) {
        cbbProblemTyp.AddItem(item.VALOR, item.INDEX);
    });
    cbbProblemTyp.EndUpdate();
    cbbProblemTyp.SetSelectedIndex(0);

    var _rs3 = result.d.where(function (item) { return (item.CLAVE === "UM"); });
    cbbTecnico.BeginUpdate();
    cbbTecnico.ClearItems();
    _rs3.forEach(function (item) {
        cbbTecnico.AddItem(item.VALOR, item.INDEX);
    });
    cbbTecnico.EndUpdate();
    cbbTecnico.SetSelectedIndex(0);


    var _rs4 = result.d.where(function (item) { return (item.CLAVE === "SC"); });
    cbStatus.BeginUpdate();
    cbStatus.ClearItems();
    _rs4.forEach(function (item) {
        cbStatus.AddItem(item.VALOR, item.INDEX);
    });
    cbStatus.EndUpdate();
    cbStatus.SetValue(-3);
}
function cambio_direccion() {
    var val = cbbAddress.GetValue();
    if (val != 0) {
        var spl = val.split("$");
        txtStreets1.SetText(spl[0]);
        txtDepartamento1.SetText(spl[1]);
        txtProvincia1.SetText(spl[2]);
        txtDistrito1.SetText(spl[3]);
    }
    else {
        txtStreets1.SetText("");
        txtDepartamento1.SetText("");
        txtProvincia1.SetText("");
        txtDistrito1.SetText("");
    }
}
function Set_VisibleOption() {
    mnuOper.GetItemByName("Cancel").SetVisible(false);
    mnuOper.GetItemByName("Duplicate").SetVisible(false);
    mnuOper.GetItemByName("Export").SetVisible(false);
    mnuOper.GetItemByName("PaymentIn").SetVisible(false);
    mnuOper.GetItemByName("Print").SetVisible(false);
    mnuOper.GetItemByName("CopyFrom").SetVisible(false);
    mnuOper.GetItemByName("CopyTo").SetVisible(false);

    mnuOper.GetItemByName("Export").SetEnabled(false);
    mnuOper.GetItemByName("PaymentIn").SetEnabled(false);
    mnuOper.GetItemByName("Print").SetEnabled(false);
    mnuOper.GetItemByName("CopyFrom").SetEnabled(false);
    mnuOper.GetItemByName("CopyTo").SetEnabled(false);
}
function Get_Product1(s, e) {
    gdvCards.PerformCallback("GET");
    if (e.htmlEvent.keyCode === 13) {
        gdvCards.SetFocusedRowIndex(0);
        OkCards();
        ASPxClientUtils.PreventEventAndBubble(e.htmlEvent);
    }
}
function Get_Product() {
    //gdvProductSearch.SetFocusedRowIndex(-1);
    gdvCards.PerformCallback("GET");
}

function OkCards() {
    var rowc = gdvCards.GetVisibleRowsOnPage();
    if (rowc === 0) {
        alert("No existen registros para realizar esta operación.")
    }
    else if (gdvCards.GetFocusedRowIndex() === -1) {
        alert("Seleccione un registro para realizar esta operación.")
    }
    else {
        gdvCards.GetRowValues(gdvCards.GetFocusedRowIndex(), "ItemCode;ItemName;Seriefabricante;SerieInterna;ItmsGrpCod;instLction", OnGetRowValuesCards);
    }
}

function OnGetRowValuesCards(values) {
    //alert("" + values);
    txtitemCode.SetText(values[0]);
    txtItemName.SetText(values[1]);
    txtmanufSN1.SetText(values[2]);
    txtinternalSN.SetText(values[3]);
    //txtItemGroup.SetText(values[4]);
    cbbAddress.SetText(values[5]);
    var dire = cbbAddress.GetValue();
    if (dire != 0) {
        var spl = dire.split("$");
        txtStreets1.SetText(spl[0]);
        txtDepartamento1.SetText(spl[1]);
        txtProvincia1.SetText(spl[2]);
        txtDistrito1.SetText(spl[3]);
    }
    else {
        txtStreets1.SetText("");
        txtDepartamento1.SetText("");
        txtProvincia1.SetText("");
        txtDistrito1.SetText("");
    }
    
    ppcCardsSearch.Hide();
}

function CancelCards() {
    ppcCardsSearch.Hide();
}
function ShowCardSearch() {
    gdvCards.PerformCallback("GET");
    ppcCardsSearch.Show();
}
function ShowClientSearch() {
    ppcClientSearch.Show();
}
function Get_Client1(s, e) {
    //gdvClientSearch.SetFocusedRowIndex(-1);
    gdvClientSearch.PerformCallback();
    if (e.htmlEvent.keyCode === 13) {
        gdvClientSearch.SetFocusedRowIndex(0);
        OkClient();
        ASPxClientUtils.PreventEventAndBubble(e.htmlEvent);
    }
}
function Get_Client() {
    gdvClientSearch.SetFocusedRowIndex(-1);
    gdvClientSearch.PerformCallback();
}

function OkClient() {
    var rowc = gdvClientSearch.GetVisibleRowsOnPage();
    if (rowc === 0) {
        alert("No existen registros para realizar esta operación.")
    }
    else if (gdvClientSearch.GetFocusedRowIndex() === -1) {
        alert("Seleccione un registro para realizar esta operación.")
    }
    else {
        gdvClientSearch.GetRowValues(gdvClientSearch.GetFocusedRowIndex(), "CardCode;CardName;LicTradNum;Cellular", OnGetRowValuesClient);
    }
}

function OnGetRowValuesClient(values) {
    bteCustomer.SetText(values[0]);
    txtCustomerName.SetText(values[1]);
    txttelf.SetText(values[3]);
    txtcontctCode1.PerformCallback("INICIAR:" + values[0]);
    cbbAddress.PerformCallback("GET:" + values[0]);
    gdvClientSearch.SetFocusedRowIndex(-1);
    ppcClientSearch.Hide();
}

function CancelClient() {
    ppcClientSearch.Hide();
}

function EndClientSearch() {
    gdvClientSearch.SetFocusedRowIndex(0);
    //ppcClientSearch.UpdatePosition();
}
function isNullOrWhiteSpace(str) {
    return str === null || str.match(/^ *$/) !== null;
}
function uniqueBy(arr, fn) {
    var unique = {};
    var distinct = [];
    arr.forEach(function (x) {
        var key = fn(x);
        if (!unique[key]) {
            distinct.push(key);
            unique[key] = true;
        }
    });
    return distinct;
}
function ClearControl() {
    InitControls();
    
}

function InitControls() {
    //------------------------------------
    bteCustomer.SetEnabled(false);
    txtCustomerName.SetEnabled(false);
    txttelf.SetEnabled(false);
    txtidllamada.SetEnabled(false);

    txtDepartamento1.SetEnabled(false);
    txtProvincia1.SetEnabled(false);
    txtDistrito1.SetEnabled(false);
    txtStreets1.SetEnabled(false);
    txtmanufSN1.SetEnabled(false);
    txtinternalSN.SetEnabled(false);
    txtcreateDate1.SetEnabled(false);
    txtcloseDate1.SetEnabled(false);
    txtitemCode.SetEnabled(false);
    txtItemName.SetEnabled(false);
    txtnumContrato.SetEnabled(false);
    //------------------------------------
    bteCustomer.SetText("");
    txtCustomerName.SetText("");
    hdfTemp.Set("adrtype", "");
    cbStatus.SetText("Abierto");
    txttelf.SetText("");
    cbbPriority.SetSelectedIndex(0);
    txtcontctCode1.SetText("");
    txtidllamada.SetText("");

    txtDepartamento1.SetText("");
    txtProvincia1.SetText("");
    txtDistrito1.SetText("");
    txtStreets1.SetText("");
    txtmanufSN1.SetText("");
    txtinternalSN.SetText("");
    txtcreateDate1.SetText("");
    txtcloseDate1.SetText("");
    txtitemCode.SetText("");
    txtItemName.SetText("");
    txtnumContrato.SetText("-");
    //txtcntrctDate
    //txtItemGroup.SetText("");
    txtSubject.SetText("");
    cbbOrigin.SetSelectedIndex(0);
    cbbProblemTyp.SetSelectedIndex(0);
    cbbCallType.SetSelectedIndex(0);
    cbbTecnico.SetSelectedIndex(0);
    mmoResolution.SetText("");
    mmoComments.SetText("");
    cbbAddress.SetText("");
    gdvTecnicos.PerformCallback("CLR");
    mnuOper.GetItemByName("Save").SetText("Crear");
}

function SaveServicio() {
    
    clbOperation.PerformCallback("SaveServicio");
}
function Save() {
    SaveServicio();
}
function Modificar() {
    clbOperation.PerformCallback("UpdtServicio");
}
function Set_Operation(s, e) {
    // GUARDAR
    if (e.item.name === "Save" && e.item.GetText() === "Crear") {
        Save();
    }
        // NUEVO
    else if (e.item.name === "New") {
        ClearControl();
    }
        // BUSCAR
    else if (e.item.name === "Search") {
        showsearchserv();
    }
    else if (e.item.name === "Save" && e.item.GetText() === "Modificar") {
        Modificar();
    }
}
function showsearchserv() {
    ppcServicioSearch.Show();
}

function ProcessKeyPress(s, e) {
    var charCode = (e.htmlEvent.which) ? e.htmlEvent.which : event.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        _aspxPreventEvent(e.htmlEvent);
}

function Com_Operation(s, e) {
    ldpProcess.Hide();
    var _spd = "";
    if (e.result.indexOf("OKBP") !== -1) {
        _spd = e.result.split("#");
        txtidllamada.SetText(_spd[1]);
        alert("¡Servicio creado con éxito!");
    }
    else if (e.result.indexOf("IKCC") !== -1) {
        //_spd = e.result.split("#");
        //txtidllamada.SetText(_spd[1]);
        alert("¡Servicio Modificado con éxito!");
    }
    else {
        alert(e.result);
    }
}
function CancelClientCr() {
    ppcClientCr.Hide();
}
function ClearControlsClient() {
    
}

function fincallback(s, e) {
    alert(e.result);
}
function pestañascrearclie() {

    $(".amenucrearclie:first").css("background-color", "#44619E");
    $(".amenucrearclie:first").css("color", "white");
    $("section.sectablas").hide();
    $("section.sectablas:first").show();

    $(".amenucrearclie").click(function () {
        $(".amenucrearclie").css("background-color", "white");
        $(".amenucrearclie").css("color", "#44619E");
        $(this).css("background-color", "#44619E");
        $(this).css("color", "white");
        $("section.sectablas").hide();

        var activartabla = $(this).attr("href");
        $(activartabla).show();
        return false;
    });
}
