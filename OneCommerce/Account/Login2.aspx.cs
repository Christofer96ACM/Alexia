using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using BusinessEntities;
using BusinessRules;
using DevExpress.Web.ASPxEditors;
using BusinessServices;
namespace OneCommerce.Account
{
    public partial class Login2 : System.Web.UI.Page
    {
        private readonly BRLogin obrl;
        static string valor_sociedad = "";
        static string NOMBRE_BD = "";
        static string SRV = "";
        static string DBUSERNAME = "";
        static string DBPASSWORD = "";
        static string SAPUSERNAME = "";
        static string SAPPASSWORD = "";
        public static List<BELogin> proyectos;
        public Login2()
        {
            obrl = new BRLogin();
        }
        /// <summary>
        /// LISTA LOS LOCALES
        /// </summary>
        /// <returns></returns>

        private void Get_Locals()
        {
            var obep = new BEParameters()
            {
                Socied = "ApplicationServices",
                RUC = txtruc.Text,
            };
            var olst = obrl.Get_SCSP_LSPJ_OPRJ(obep);
            bool band = true;
            proyectos = olst;

            olst.ForEach(item =>
            {
                if (band)
                {
                    valor_sociedad = item.alf_soci;
                    NOMBRE_BD = item.NOMBRE_BD;
                    SRV = item.SRV;
                    DBUSERNAME = item.DBUSERNAME;
                    DBPASSWORD = item.DBPASSWORD;
                    SAPUSERNAME = item.SAPUSERNAME;
                    SAPPASSWORD = item.SAPPASSWORD;

                    band = false;
                }
            });

            hdfLocal.Set("_proyc", "");
            olst.Where(i => i.RUC == txtruc.Text)
                .ToList()
                .ForEach(item =>
                {
                    cbbProject.Items.Add(item.PrjName, item.PrjCode);
                });
            cbbProject.SelectedIndex = 0;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !IsCallback)
            {
                Session["InitPar"] = new BEParameters();
            }
        }
        protected void clbSession_Callback(object source, DevExpress.Web.ASPxCallback.CallbackEventArgs e)
        {
            try
            {
                e.Result = string.Empty;

                if (Membership.ValidateUser(UserName.Text.Trim(), Password.Text))
                {
                    string proyect = Convert.ToString(hdfLocal.Get("_proyc"));
                    List<BEParameters> lval = obrl.Get_val_usu(UserName.Text.Trim(), valor_sociedad, proyect);
                    if (lval.Count == 0 || lval[0].Permition == "0")
                    {
                        e.Result = "Val#";
                        FormsAuthentication.SignOut();
                    }
                    else
                    {
                        var _par = e.Parameter.Split(';');
                        ((BEParameters)Session["InitPar"]).UserName = UserName.Text.Trim();
                        ((BEParameters)Session["InitPar"]).Socied = valor_sociedad;
                        ((BEParameters)Session["InitPar"]).Project = _par[0];
                        ((BEParameters)Session["InitPar"]).DscpLocal = " - Local: " + _par[1];
                        ((BEParameters)Session["InitPar"]).U_DXP_SEDE = _par[1];


                        proyectos.ToList().ForEach(item =>
                        {
                            if (item.alf_soci == valor_sociedad && item.PrjCode == _par[0])
                            {
                                ((BEParameters)Session["InitPar"]).WhsCode = item.WhsCode;
                                ((BEParameters)Session["InitPar"]).SRV = item.SRV;
                                ((BEParameters)Session["InitPar"]).DBUSERNAME = item.DBUSERNAME;
                                ((BEParameters)Session["InitPar"]).DBPASSWORD = item.DBPASSWORD;
                                ((BEParameters)Session["InitPar"]).SAPUSERNAME = item.SAPUSERNAME;
                                ((BEParameters)Session["InitPar"]).SAPPASSWORD = item.SAPPASSWORD;
                                ((BEParameters)Session["InitPar"]).Permition = item.Permition;
                                ((BEParameters)Session["InitPar"]).CompanyAddress = item.CompanyAddress;
                                ((BEParameters)Session["InitPar"]).U_BF_ADMIN = lval[0].U_BF_ADMIN;
                                ((BEParameters)Session["InitPar"]).Band = false;
                                ((BEParameters)Session["InitPar"]).Currency = "";
                            }
                        });

                        var obep = new BEParameters();
                        obep.Socied = valor_sociedad;
                        obep.UserName = UserName.Text.Trim();
                        ((BEParameters)Session["InitPar"]).U_BF_EMID = obrl.Get_OSCSP_IDOH(obep);
                        ((BEParameters)Session["InitPar"]).CompanyDB = NOMBRE_BD;
                        ((BEParameters)Session["InitPar"]).Permisos = obrl.GET_PERMISOS(((BEParameters)Session["InitPar"]));
                        obep.CompanyDB = NOMBRE_BD;
                        obep.SRV = SRV;
                        obep.DBUSERNAME = DBUSERNAME;
                        obep.DBPASSWORD = DBPASSWORD;
                        obep.SAPUSERNAME = SAPUSERNAME;
                        obep.SAPPASSWORD = SAPPASSWORD;
                        var osbo = new BRSboConnect();
                        ((BEParameters)Session["InitPar"]).objSapSbo = osbo.Get_ComConnect(obep);
                        var rates = obrl.DXP_GET_RATE(obep);
                        if (rates.Count != 0)
                        {
                            rates.ForEach(i =>
                            {
                                if(i.Currency == "USD")
                                    ((BEParameters)Session["InitPar"]).Rate = i.Rate;
                                else if (i.Currency == "EUR")
                                    ((BEParameters)Session["InitPar"]).RateEur = i.Rate;

                            });
                        } else;
                            
                        if (!string.IsNullOrWhiteSpace(obep.Msg))
                        {
                            Session["InitPar"] = new BEParameters();
                            e.Result = obep.Msg;
                            FormsAuthentication.SignOut();
                        }
                        else
                        {
                            e.Result = "PERM#" + ((BEParameters)Session["InitPar"]).Permition;
                            FormsAuthentication.SetAuthCookie(UserName.Text.Trim(), false);
                        }
                    }
                }
                else
                {
                    e.Result = "USI#";
                }
            }
            catch (KeyNotFoundException ex)
            {
                e.Result = ex.Message;
            }
        }
        protected void cbbProject_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            var obec = ((BEParameters)Session["InitPar"]);
            if (e.Parameter.Contains("Locales"))
            {
                Get_Locals();
            }
        }
    }
}