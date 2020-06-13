using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.Services;
using BusinessEntities;
using BusinessRules;
using System.Web.Script.Services;
using DevExpress.Web.ASPxGridView;
using BusinessServices;
using DevExpress.Web.ASPxEditors;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using System.Web;
using DevExpress.Web.ASPxCallback;
using DevExpress.Web.Data;
using DevExpress.Web.ASPxClasses;
using System.Drawing;
using DevExpress.Web.ASPxNavBar;

namespace OneCommerce.Servicio
{
    public partial class LlamadaServicio : Page
    {
        public static List<BEClientAddress> ListaDirecciones = new List<BEClientAddress>();
        protected void Application_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            var page = HttpContext.Current.CurrentHandler as Page;
            if (page != null)
            {
                page.PreInit += Page_PreInit;
            }
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                ASPxWebControl.GlobalTheme = "Aqua";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                FormsAuthentication.SignOut();
                FormsAuthentication.RedirectToLoginPage();  
            }
            else
            {
                if (!IsPostBack && !IsCallback)
                {
                    var obec = ((BEParameters)Session["InitPar"]);
                    /*if (obec.Permition == "001")
                    {
                        FormsAuthentication.SignOut();
                        FormsAuthentication.RedirectToLoginPage();  
                    }
                    else
                    {*/
                        Init_VarSessions();
                        Set_Permissions();
                        var mmp = ((ASPxNavBar)Master.FindControl("nvbMain"));
                        var _sd = obec.RAZON_SOCIAL;
                        ((HtmlAnchor)BSFindControl.FindControlRecursive(Master, "Socied")).InnerText = _sd;
                        ((HtmlAnchor)BSFindControl.FindControlRecursive(Master, "Local")).InnerText = obec.DscpLocal;
                        ((ASPxLabel)BSFindControl.FindControlRecursive(Master, "lblTypeChange")).Text = "Tipo de Cambio: " + obec.Rate.ToString("c3");
                    //}                 
                }
            }
        }
        public T FindControl<T>(string id) where T : Control
        {
            return FindChildControl<T>(Page, id);
        }
        public T FindControl<T>(Control startingControl, string id) where T : Control
        {
            return BSControlFinder.FindControl<T>(startingControl, id);
        }

        public T FindChildControl<T>(Control startingControl, string id) where T : Control
        {
            return BSControlFinder.FindChildControl<T>(startingControl, id);
        }
        private void Set_Permissions()
        {
            var obec = ((BEParameters)Session["InitPar"]);

            obec.Permisos.ForEach(item => {
                FindControl<ASPxNavBar>(Master, "nvbMain").Groups.FindByName(item.GRUPO_MENU).Items.FindByName(item.PARTICULAR_MENU).Enabled = Convert.ToBoolean(item.PERMISO);
            });
        }
        private void Init_VarSessions()
        {
            var obec = ((BEParameters)Session["InitPar"]);

            Session["oitm"] = new List<BEProduct>();
            Session["oscl"] = new List<BELlamadaServicio>();
            Session["ocrd"] = new List<BEBusinessPartner>();
            Session["tcns"] = new List<BEBusinessPartner>();
            Session["tecn"] = new List<BEBusinessPartner>();
            hdfTemp.Add("_soci", obec.Socied);
            hdfTemp.Add("adrtype", string.Empty);
        }
        //!+ RUTINAS AJAX
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<BEParameters> GET_VALORES_SERVICIO(string socied)
        {
            var obep = new BEParameters()
            {
                Socied = socied
            };
            var obrd = new BRDocument();
            var olst = obrd.GET_VALORES_SERVICIO(obep);
            return (olst);
        }
        private void Set_LineNum()
        {
            var i = 1;
            ((List<BEBusinessPartner>)Session["tecn"]).ForEach(item =>
            {
                item.LineNum = i;
                i += 1;
            });
        }
        private string SaveServicio()
        {
            var obec = ((BEParameters)Session["InitPar"]);
            var obj = new BELlamadaServicio();

            obj.CardCode = bteCustomer.Text;
            obj.CardName = txtCustomerName.Text;
            obj.ContactPerson = Convert.ToString(txtcontctCode1.Value);
            obj.Estado = Convert.ToString(cbStatus.Value);
            obj.Prioridad = Convert.ToString(cbbPriority.Value);
            obj.SerieFab = txtmanufSN1.Text;
            obj.SerieInt = txtinternalSN.Text;
            obj.ItemCode = txtitemCode.Text;
            obj.ItemName = txtItemName.Text;
            obj.Asunto = txtSubject.Text;
            obj.IdDireccion = cbbAddress.Text;
            obj.Origen = Convert.ToString(cbbOrigin.Value);
            obj.TipoProblema = Convert.ToString(cbbProblemTyp.Value);
            obj.DetalleServicio = Convert.ToString(cbbCallType.Value);
            obj.Tecnico = Convert.ToString(cbbTecnico.Value);
            //obj.HoraInicio = Convert.ToString(dteDocDateInit.Value);
            //obj.HoraFin = Convert.ToString(dteDocDateFin.Value);
            //obj.Duracion = txtDuration.Text;
            obj.Resolucion = mmoResolution.Text;
            obj.Comentario = mmoComments.Text;
            obj.lineatecnicos = ((List<BEBusinessPartner>)Session["tecn"]);
            var x = Convert.ToString(cbbAddress.Value).Split('$');
            obj.AddressType = x[4];
            using (var obrd = new BRDocument())
            {
                obrd.SaveService(obj, ((BEParameters)Session["InitPar"]).objSapSbo);
            }
            var _err = !string.IsNullOrWhiteSpace(obj.Msg) ? obj.Msg : string.Format("OKBP#{0}", obj.CallId);
            //Init_VarSessions();
            return (_err);
        }
        private string UpdtServicio()
        {
            var obec = ((BEParameters)Session["InitPar"]);
            var obj = new BELlamadaServicio();

            obj.CallId = Convert.ToInt32(txtidllamada.Text);
            obj.CardCode = bteCustomer.Text;
            obj.CardName = txtCustomerName.Text;
            obj.ContactPerson = Convert.ToString(txtcontctCode1.Value);
            obj.Estado = Convert.ToString(cbStatus.Value);
            obj.Prioridad = Convert.ToString(cbbPriority.Value);
            obj.SerieFab = txtmanufSN1.Text;
            obj.SerieInt = txtinternalSN.Text;
            obj.ItemCode = txtitemCode.Text;
            obj.ItemName = txtItemName.Text;
            obj.Asunto = txtSubject.Text;
            obj.IdDireccion = cbbAddress.Text;
            obj.Origen = Convert.ToString(cbbOrigin.Value);
            obj.TipoProblema = Convert.ToString(cbbProblemTyp.Value);
            obj.DetalleServicio = Convert.ToString(cbbCallType.Value);
            obj.Tecnico = Convert.ToString(cbbTecnico.Value);
            //obj.HoraInicio = Convert.ToString(dteDocDateInit.Value);
            //obj.HoraFin = Convert.ToString(dteDocDateFin.Value);
            //obj.Duracion = txtDuration.Text;
            obj.Resolucion = mmoResolution.Text;
            obj.Comentario = mmoComments.Text;
            obj.AddressType = Convert.ToString(hdfTemp.Get("adrtype"));
            using (var obrd = new BRDocument())
            {
                obrd.UpdtService(obj, ((BEParameters)Session["InitPar"]).objSapSbo);
            }
            var _err = !string.IsNullOrWhiteSpace(obj.Msg) ? obj.Msg : "IKCC";
            //Init_VarSessions();
            return (_err);
        }
        protected void clbOperation_Callback(object source, CallbackEventArgs e)
        {
            try
            {
                if (e.Parameter.Contains("SaveServicio"))
                {
                    e.Result = SaveServicio();
                }
                else if (e.Parameter.Contains("UpdtServicio"))
                {
                    e.Result = UpdtServicio();
                }
                else
                {
                    e.Result = string.Empty;
                }
            }
            catch (Exception ex)
            {
                e.Result = ex.Message;
            }
        }
        protected void gdvClientSearch_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var obec = ((BEParameters)Session["InitPar"]);
            var obj = new BEParameters()
            {
                Socied = obec.Socied,
                ParValue = txtParClient.Text.Trim(),
                CardName = txtRazonS.Text,
                ColumnIndex = ((GridViewDataColumn)gdvClientSearch.GetSortedColumns().ElementAt(0)).VisibleIndex
            };
            var obrd = new BRDocument();
            var olst = obrd.Get_OSCSP_OCRD(obj);
            Session["ocrd"] = olst;
            gdvClientSearch.DataSource = olst;
            gdvClientSearch.DataBind();
        }
        protected void gdvClientSearch_DataBinding(object sender, EventArgs e)
        {
            gdvClientSearch.DataSource = Session["ocrd"];
        }

        protected void txtcontctCode1_Callback(object sender, CallbackEventArgsBase e)
        {
            var obec = ((BEParameters)Session["InitPar"]);
            if (e.Parameter.Contains("INICIAR"))
            {
                var x = e.Parameter.Split(':');
                var olst = new List<BEContactLines>();
                var obj = new BEParameters()
                {
                    Socied = obec.Socied,
                    CardCode = x[1],
                };
                var obrd = new BRDocument();
                olst = obrd.Get_Contact_Person(obj);
                if (olst.Count != 0)
                {
                    olst.ForEach(ite =>
                    {
                        txtcontctCode1.Items.Add(ite.Name, ite.CntctCode);
                    });
                    txtcontctCode1.SelectedIndex = 0;
                }
                else
                {
                    txtcontctCode1.Items.Add("", 0);
                    txtcontctCode1.SelectedIndex = 0;
                }
            }
        
        }

        protected void cbbAddress_Callback(object sender, CallbackEventArgsBase e)
        {
            var obec = ((BEParameters)Session["InitPar"]);

            if (e.Parameter.Contains("GET"))
            {
                var splv = e.Parameter.Split(':');
                var obj = new BEParameters()
                {
                    Socied = obec.Socied,
                    CardCode = splv[1],
                    accion = 3,
                };
                var obrd = new BRDocument();
                var olst = obrd.GET_CLIENTES_DIRECCIONES(obj);
                if (olst.Count != 0)
                {
                    cbbAddress.Items.Add("", 0);
                    olst.Where(i => i.AdresType != "B").ToList().ForEach(ite =>
                    {
                        cbbAddress.Items.Add(ite.Address, ite.Street + "$" + ite.StateName + "$" + ite.U_DXP_BIZ_PROV + "$" + ite.U_DXP_BIZ_DIST + "$" + ite.AdresType);
                    });
                    //cbbAddress.SelectedIndex = 0;
                }
                else
                {
                    cbbAddress.Items.Add("", 0);
                    cbbAddress.SelectedIndex = 0;
                }
            }
        }

        protected void gdvCards_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var obec = ((BEParameters)Session["InitPar"]);

            if (e.Parameters.Contains("GET"))
            {
                var splv = e.Parameters.Split(':');
                var obj = new BEParameters()
                {
                    Socied = obec.Socied,
                    CardCode = bteCustomer.Text,
                    ItemCode = txtitemCode.Text,
                };
                var obrd = new BRDocument();
                var olst = obrd.DXP_GET_CARDS(obj);
                Session["oitm"] = olst;
                gdvCards.DataSource = olst;
                gdvCards.DataBind();
            }
        }

        protected void gdvCards_DataBinding(object sender, EventArgs e)
        {
            gdvCards.DataSource = Session["oitm"];
        }

        protected void gdvServicio_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var obec = ((BEParameters)Session["InitPar"]);

            if (e.Parameters.Contains("GET"))
            {
                var splv = e.Parameters.Split(':');
                var obj = new BEParameters()
                {
                    Socied = obec.Socied,
                    CardCode = txtCliente.Text,
                    ItemCode = txtProducto.Text,
                    DateIn = Convert.ToDateTime(dteFecha.Text),
                    DateFi = Convert.ToDateTime(dteFecha2.Text),
                };
                var obrd = new BRDocument();
                var olst = obrd.DXP_GET_SERVICIO(obj);
                Session["oscl"] = olst;
                gdvServicio.DataSource = olst;
                gdvServicio.DataBind();
            }
        }

        protected void gdvServicio_DataBinding(object sender, EventArgs e)
        {
            gdvServicio.DataSource = Session["oscl"];
        }
        protected void gdvTecnicos_CommandButtonInitialize(object sender, ASPxGridViewCommandButtonEventArgs e)
        {

        }
        protected void gdvTecnicos_RowUpdating(object sender, ASPxDataUpdatingEventArgs e)
        {

        }
        protected void gdvTecnicos_DataBinding(object sender, EventArgs e)
        {
            gdvTecnicos.DataSource = Session["tecn"];
        }
        protected void gdvTecnicos_RowDeleting(object sender, ASPxDataDeletingEventArgs e)
        {
            e.Cancel = true;
            int i = gdvTecnicos.FindVisibleIndexByKeyValue(e.Keys[gdvTecnicos.KeyFieldName]);
            var _lnm = (i + 1);

            ((List<BEBusinessPartner>)Session["tecn"]).RemoveAll(item => item.LineNum == _lnm);
            Set_LineNum();

            gdvTecnicos.DataSource = ((List<BEBusinessPartner>)Session["tecn"]);
            gdvTecnicos.DataBind();
        }
        protected void gdvTecnicos_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {

        }
        protected void gdvTecnicos_RowInserting(object sender, ASPxDataInsertingEventArgs e)
        {

        }
        protected void gdvTecnicos_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var obec = ((BEParameters)Session["InitPar"]);
            if (e.Parameters.Contains("ADD"))
            {
                var spl = e.Parameters.Split(':');
                var tecnico = new BEBusinessPartner();

                tecnico.ID = spl[1];
                tecnico.Tecnico = spl[2];

                ((List<BEBusinessPartner>)Session["tecn"]).Add(tecnico);
            }
            else if (e.Parameters.Contains("GET"))
            {
                var spl = e.Parameters.Split(':');
                var tecnico = new BEBusinessPartner();
                ((List<BEBusinessPartner>)Session["tecn"]).Clear();

                var obj = new BEParameters()
                {
                    Socied = obec.Socied,
                    CardName = "",
                };
                var obrd = new BRDocument();
                var olst = obrd.DXP_GET_TECNICOAUX(obj);

                for(var i = 1; i<spl.Length; i++)
                {
                    olst.Where(item => item.ID == spl[i]).ToList().ForEach(x =>
                    {
                        ((List<BEBusinessPartner>)Session["tecn"]).Add(x);
                    });
                }
            }
            else if (e.Parameters.Contains("GET"))
            {
                ((List<BEBusinessPartner>)Session["tecn"]).Clear();
            }
            Set_LineNum();
            gdvTecnicos.DataSource = Session["tecn"];
            gdvTecnicos.DataBind();
        }
        protected void gdvTecnicosrch_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var obec = ((BEParameters)Session["InitPar"]);
            var obj = new BEParameters()
            {
                Socied = obec.Socied,
                CardName = txttec.Text,
            };
            var obrd = new BRDocument();
            var olst = obrd.DXP_GET_TECNICOAUX(obj);
            Session["tcns"] = olst;
            gdvTecnicosrch.DataSource = olst;
            gdvTecnicosrch.DataBind();
        }

        protected void gdvTecnicosrch_DataBinding(object sender, EventArgs e)
        {
            gdvTecnicosrch.DataSource = Session["tcns"];
        }
    }
}