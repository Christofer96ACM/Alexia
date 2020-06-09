using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessEntities
{
    public class BEParameters
    {
        public BEParameters()
        {
            Permisos = new List<BEParameters>();
        }
        public string Proyecto { get; set; }
        public string cuenta { get; set; }
        public int Number { get; set; }
        public string BaseRef { get; set; }
        public string U_DXP_NOMBRE_PARAMET { get; set; }
        public string U_DXP_VALOR_PARAMETR { get; set; }
        public string Socied { get; set; }
        public string Project { get; set; }
        public string U_DXP_SEDE { get; set; }
        public string DscpLocal { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string Id_Dire { get; set; }
        public string Code { get; set; }
        public string Actives { get; set; }
        public Int16 PriceList { get; set; }
        public string WhsCode { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
        public decimal Total2 { get; set; }
        public decimal Total3 { get; set; }
        public decimal Total4 { get; set; }
        public decimal Total5 { get; set; }
        public decimal Total6 { get; set; }
        public decimal TotalFC { get; set; }
        public int Linea { get; set; }
        public int TransId { get; set; }
        public decimal RateEur { get; set; }
        public string U_BF_EMID { get; set; }
        public string CompanyAddress { get; set; }
        public string Phone { get; set; }
        public string SerieMaqr { get; set; }
        public int U_BF_ADMIN { get; set; }
        public int Sw { get; set; }
        public int año { get; set; }
        public int mes { get; set; }
        public int ObjType { get; set; }
        public int AbsEntryUpdt { get; set; }
        
        public string ParValue { get; set; }
        public int ColumnIndex { get; set; }
        public string Msg { get; set; }
        public string CompanyDB { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public object objSapSbo { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? DateFi { get; set; }
        public DateTime? FechaUpdt { get; set; }
        public string FechaUpdt2 { get; set; }
        public string NumAtCard { get; set; }
        public string Descripcion { get; set; }
        public int DraftEntry { get; set; }
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public bool Kit { get; set; }
        public string Internal { get; set; }
        public string Reserve { get; set; }
        public string TypeFilter { get; set; }
        public string Permition { get; set; }
        public string ItemCode { get; set; }
        public string Prov { get; set; }
        public string dni { get; set; }
        public string departamento { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }
        public int accion { get; set; }
        public string RUC { get; set; }
        public string RAZON_SOCIAL { get; set; }
        public string NOMBRE_BD { get; set; }
        public string INDEX { get; set; }
        public string VALOR { get; set; }
        public string DEFECTO { get; set; }
        public string CLAVE { get; set; }
        public bool Band { get; set; }
        public string Currency { get; set; }
        public string Moneda { get; set; }
        public string SRV { get; set; }
        public string DBUSERNAME { get; set; }
        public string DBPASSWORD { get; set; }
        public string SAPUSERNAME { get; set; }
        public string SAPPASSWORD { get; set; }
        public string GRUPO_MENU { get; set; }
        public string PARTICULAR_MENU { get; set; }
        public int PERMISO { get; set; }
        public string PERMISOR { get; set; }
        public string LOCAL { get; set; }
        public string NOMBRE_OFICIAL { get; set; }
        public List<BEParameters> Permisos { get; set; }
    }
}
