using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;
using BusinessEntities;
using SAPbobsCOM;

namespace DataAccess
{
    public class DADocument : IDisposable
    {
        protected Database odb;
        protected DbConnection ocn;
        private bool disposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                ocn.Dispose();
                ((IDisposable)odb).Dispose();
                ocn = null;
                odb = null;
            }
            disposed = true;
        }
        ~DADocument()
        {
            Dispose(false);
        }
        #region Dashboard
        public IDataReader Get_DS_OSCSP_SRCH_OPCH(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DS_OSCSP_SRCH_OPCH", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_DS_OSCSP_SRCH_OINV(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DS_OSCSP_SRCH_OINV", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_DS_OSCSP_SRCH_OSCL(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DS_OSCSP_SRCH_OSCL", obep.DateIn, obep.DateFi, obep.CardCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_DS_OSCSP_SRCH_INV1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DS_OSCSP_SRCH_INV1", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_DS_OSCSP_SRCH_PCH1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DS_OSCSP_SRCH_PCH1", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_DS_OSCSP_SRCH_OQUT(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DS_OSCSP_SRCH_OQUT", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_DS_OSCSP_SRCH_ORDR(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DS_OSCSP_SRCH_ORDR", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_DS_OSCSP_SRCH_OPOR(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DS_OSCSP_SRCH_OPOR", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_DS_OSCSP_SRCH_OPOR2(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DS_OSCSP_SRCH_OPOR2", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_DS_OSCSP_SRCH_OPDN(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DS_OSCSP_SRCH_OPDN", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        #endregion
        //!+ DOCUMENTOS DE VENTA
        /// <summary>
        /// LISTA LOS TIPOS DE DOCUMENTOS DE VENTA
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_TPDOVE(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_TPDOVE", obep.Socied, obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_TPDOVE_2(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_TPDOVE_2", obep.NumAtCard, obep.SerieMaqr);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }

        public IDataReader GET_CUENTAS_PAGO(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_CUENTAS");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_CUENTASGENERAL(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_CUENTASGENERAL", obep.Code, obep.Currency);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader USUARIOS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase("ApplicationServices");
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_USUARIOS", obep.Socied, obep.U_DXP_SEDE);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader VISTAS()
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase("ApplicationServices");
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_VISTAS_GENERALES");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader PERMISOS (BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase("ApplicationServices");
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_PERMISOS_POR_USUARIO", obep.Socied, obep.Project, obep.UserName);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public void Recoverer(BEParameters obep)
        {
            odb = DatabaseFactory.CreateDatabase("ApplicationServices");
            ocn = odb.CreateConnection();
            if (ocn.State == ConnectionState.Closed) ocn.Open();
            var ocmd = odb.GetStoredProcCommand("aspnet_Membership_SetPassword", "/", obep.UserName, obep.Password, obep.Password, DateTime.Today, 0);
            ocmd.CommandTimeout = 2000;
            var ord = odb.ExecuteReader(ocmd);
            Dispose(false);
            
        }
        public IDataReader DXP_GET_CONTRATOS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_CONTRATOS", obep.CardCode, obep.Id_Dire, obep.Code, obep.LOCAL, obep.Descripcion, obep.provincia, obep.distrito, obep.DateIn, obep.DateFi, obep.CompanyDB, obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_TIPOCAMBIO(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_TIPOCAMBIO", obep.mes, obep.año);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_CUENTAS_PAGO(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_OCRC", obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA DATOS INICIALES
        /// </summary>
        /// <param name="obep"></param>
        /// <returns></returns>
        public IDataReader Get_OSCSP_DAIN(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_DAIN");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public int DXP_GETO_BORRADOR_OV(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GETO_BORRADOR_OV", obep.DocNum, obep.CardCode, obep.ObjType);
                ocmd.CommandTimeout = 2000;
                var scl = (int)odb.ExecuteScalar(ocmd);
                Dispose(false);
                return (scl);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_PRICELIST(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_PRICELIST");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// Listar Tipo de Cliente
        /// </summary>
        /// <param name="obep"></param>
        /// <returns></returns>
        public IDataReader GET_SP_TIP_CLIE(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("SP_TIP_CLIE");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA DE CODIGO DE USUARIO
        /// </summary>
        /// <param name="obep"></param>
        /// <returns></returns>
        public IDataReader Get_SP_CODIGO_USUARIO(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("SP_CODIGO_USUARIO", obep.Socied, obep.ItemCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_URL_FORMATOIMPRESION(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_URL_FORMATOIMPRESION");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA SOLO DISTRITO
        /// </summary>
        /// <param name="obep"></param>
        /// <returns></returns>
        public IDataReader Get_SP_LIST_DIST_PROV(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("SP_LIST_DIST_PROV", obep.Prov);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA DEPARTAMENTO,PROVINCIA,DISTRITO
        /// </summary>
        /// <param name="obep"></param>
        /// <returns></returns>
        public IDataReader Get_SP_LIST_DIST(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("SP_LIST_DIST");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LOS CLIENTES
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_OCRD(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_OCRD", obep.ParValue, obep.CardName, obep.ColumnIndex);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_OCRD_P(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_OCRD_P", obep.ParValue, obep.CardName, obep.ColumnIndex);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_CARDS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_CARDS", obep.CardCode, obep.ItemCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_OWHS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_OWHS", obep.ParValue, obep.ColumnIndex);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_OITW(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_OITW",obep.ItemCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LAS DIRECCIONES DEL CLIENTE SELECIONADO
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_CRD1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_CRD1", obep.CardCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_SALDOS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_SALDO_CUENTA", obep.CardCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_FACTURAS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_FACTURAS", obep.CardCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_FACTURAS_PROVEEDORES(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_FACTURAS_PROVEEDORES", obep.CardCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_Contact_Person(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_CONTACTOS", obep.CardCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LOS PRODUCTOS
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_OITM(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_OITM_Stock", obep.Socied, obep.Project, obep.CardCode, obep.PriceList, obep.WhsCode,
                                                                  obep.ParValue, obep.ColumnIndex, obep.Sw, obep.Kit, obep.Moneda, obep.DateIn, obep.Descripcion, obep.SerieMaqr);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_OITM_P(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_OITM_Stock_P", obep.Socied, obep.Project, obep.CardCode, obep.PriceList, obep.WhsCode,
                                                                  obep.ParValue, obep.ColumnIndex, obep.Sw, obep.Kit, obep.Moneda, obep.DateIn, obep.Descripcion, obep.SerieMaqr);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LOS PRODUCTOS
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_OITM_NAIAH(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_OITM_NAIAH", obep.CardCode, obep.PriceList, obep.WhsCode,
                                                                  obep.ParValue, obep.ColumnIndex, obep.Sw, obep.Kit);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LOS KITS
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_KITS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();//OSCSP_KITS_NAIAH
                var ocmd = odb.GetStoredProcCommand("OSCSP_KITS", obep.CardCode, obep.PriceList, obep.WhsCode,
                                                                  obep.ParValue, obep.ColumnIndex, obep.Sw);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_DEPARTAMENTOS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("GET_DEPARTAMENTOS", obep.departamento);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_TECNICOAUX(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_TECNICOAUX", obep.CardName);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_GABINETES(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("GET_GABINETES");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_VALORES_ARTICULOS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_VALORES_ARTICULOS");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_VALORES_GESTIONBANCOS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_VALORES_GESTIONBANCOS");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_VALORES_SERVICIO(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_VALORES_SERVICIO");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_PROVINCIAS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("GET_PROVINCIAS", obep.departamento, obep.provincia);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_SERVICIO(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_SERVICIO", obep.CardCode, obep.ItemCode, obep.DateIn, obep.DateFi);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_TARJETAEQUIPO(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_TARJETAEQUIPO", obep.ItemCode, obep.CardCode, obep.SerieMaqr);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_SERVICIO_TJ(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_SERVICIO_TJ", obep.ItemCode, obep.CardCode, obep.SerieMaqr);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_DISTRITOS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("GET_DISTRITOS", obep.provincia, obep.distrito);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_URBANIZACIONES(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("GET_URBANIZACION", obep.distrito);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_CLIENTES(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("GET_CLIENTE", obep.CardCode, obep.accion);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_KITS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_KITS", obep.ItemCode, obep.WhsCode, obep.VALOR, obep.Descripcion);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_HIJOS_KITS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_HIJOS_KITS", obep.ItemCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_ITEM_SEGUN_ALMACEN(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_ITEM_SEGUN_ALMACEN", obep.ItemCode, obep.WhsCode, obep.VALOR, obep.Descripcion);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_ARTICULOS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_ARTICULO", obep.ItemCode, obep.VALOR, obep.accion, obep.Descripcion);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public void EDIT_PERMISOS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase("ApplicationServices");
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("EDIT_PERMISOS", obep.Socied, obep.Project, obep.UserName, Convert.ToByte(obep.PERMISOR), obep.NOMBRE_OFICIAL);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                //return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public void DXP_INSERT_VISTA_POR_USUARIO(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase("ApplicationServices");
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_INSERT_VISTA_POR_USUARIO", obep.UserName, Convert.ToByte(obep.PERMISO), obep.Socied, obep.Project, obep.GRUPO_MENU , obep.PARTICULAR_MENU, obep.NOMBRE_OFICIAL);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                //return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_CUENTA_MAYOR(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_CUENTA_MAYOR", obep.ItemCode, obep.WhsCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_SERIES_USADAS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_SERIALNUMBER_NC", obep.ItemCode, obep.DocEntry, obep.DocNum, obep.CardCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_LOTES_USADAS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_LOTESNUMBER_NC", obep.ItemCode, obep.DocEntry, obep.DocNum, obep.CardCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_LOTES_USADAS_COMPRAS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_LOTESNUMBER_NC_COMPRAS", obep.ItemCode, obep.DocEntry, obep.DocNum, obep.CardCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_SERIES_USADAS_COMPRAS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_SERIALNUMBER_NC_COMPRAS", obep.ItemCode, obep.DocEntry, obep.DocNum, obep.CardCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LOS KITS_NAIAH
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_KITS_NAIAH(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();//OSCSP_KITS_NAIAH
                var ocmd = odb.GetStoredProcCommand("OSCSP_KITS_NAIAH", obep.CardCode, obep.PriceList, obep.WhsCode,
                                                                  obep.ParValue, obep.ColumnIndex, obep.Sw);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LOS KITS_NAIAH_cod
        /// </summary>
        /// <returns></returns>
        public IDataReader OSCSP_KITS_NAIAH_Cod(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();//OSCSP_KITS_NAIAH
                var ocmd = odb.GetStoredProcCommand("OSCSP_KITS_NAIAH_Cod", obep.CardCode, obep.PriceList, obep.WhsCode,
                                                                  obep.ParValue, obep.ColumnIndex, obep.ItemCode, obep.Sw);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LOS DOCUMENTOS DE VENTA
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_OINV(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_OINV", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.CardCode, obep.CardName, obep.Project, obep.Reserve, obep.Id_Dire, obep.Code);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_TRANSTOCK(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_TRANSTOCK", obep.DateIn, obep.DateFi, obep.DocNum);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_TRANSTOCK_DETALLE(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_TRANSTOCK_DETALLE", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_OINV_RESERVA(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_OINV_RESERVA", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.Project, obep.Reserve);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_ODPI(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_ODPI", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.CardCode, obep.CardName,obep.Project, obep.Reserve, obep.Id_Dire, obep.Code);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_OPCH(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_OPCH", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.CardCode, obep.CardName, obep.Project, obep.Reserve, obep.Id_Dire, obep.Code);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA EL DETALLE DE LOS DOCUMENTOS DE VENTA
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_INV1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_INV1", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_DPI1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_DPI1", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_PCH1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_PCH1", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GETDETALLE_BORRADOR_OV(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GETDETALLE_BORRADOR_OV", obep.DocNum, obep.CardCode, obep.ObjType);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LAS TARJETAS DE CREDITO
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_OCRC(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_OCRC");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LAS NOTAS DE CREDITO
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_ORIN(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_ORIN", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.CardCode, obep.CardName, obep.Project, obep.Id_Dire);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_GET_VALORES_ASIENTO(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_VALORES_ASIENTO");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }

        public void SaveAsiento(BEAsiento obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (JournalEntries)ocp.GetBusinessObject(BoObjectTypes.oJournalEntries);

                    odn.ReferenceDate = obj.RefDate;
                    odn.DueDate = obj.DueDate;
                    odn.TaxDate = obj.TaxDate;
                    odn.Memo = obj.Memo;
                    if (obj.Indicator != "0")
                    {
                        odn.Indicator = obj.Indicator;
                    }

                    odn.ProjectCode = obj.Project;
                    if (obj.TransCode != "0")
                    {
                        odn.TransactionCode = obj.TransCode;
                    }

                    odn.Reference = obj.Ref1;
                    odn.Reference2 = obj.Ref2;
                    odn.Reference3 = obj.Ref3;

                    if (obj.AutoStorno == "Y")
                    {
                        odn.StornoDate = obj.StornoDate;
                        odn.UseAutoStorno = BoYesNoEnum.tYES;
                    }
                    if (obj.AutoVAT == "Y")
                    {
                        odn.AutoVAT = BoYesNoEnum.tYES;
                    }
                    if (obj.AutoWT == "Y")
                    {
                        odn.AutomaticWT = BoYesNoEnum.tYES;
                    }







                    obj.Lines.ForEach(item => {


                        odn.Lines.ShortName = item.ShortName;
                        odn.Lines.Debit = Convert.ToDouble(item.Debit);
                        odn.Lines.Credit = Convert.ToDouble(item.Credit);
                        odn.Lines.LineMemo = item.LineMemo;
                        odn.Lines.Reference1 = item.Ref1d;
                        odn.Lines.Reference2 = item.Ref2d;
                        odn.Lines.AdditionalReference = item.Ref3Line;
                        odn.Lines.DueDate = Convert.ToDateTime(item.DueDated);
                        odn.Lines.ReferenceDate1 = Convert.ToDateTime(item.RefDated);
                        odn.Lines.TaxDate = Convert.ToDateTime(item.TaxDated);
                        odn.Lines.ProjectCode = item.Projectd;

                        odn.Lines.Add();


                    });

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.TransId = Convert.ToInt32(ocp.GetNewObjectKey());
                        //RetVal = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }

        }

        public void UpdtAsiento(BEAsiento obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {

                    var odn = (JournalEntries)ocp.GetBusinessObject(BoObjectTypes.oJournalEntries);

                    odn.GetByKey(obj.TransId);
                    //odn.CustomerCode = obj.CardCode;
                    //odn.CustomerName = obj.CardName;

                    odn.DueDate = obj.DueDate;
                    odn.Memo = obj.Memo;
                    if (obj.Indicator != "")
                    {
                        odn.Indicator = obj.Indicator;
                    }
                    odn.ProjectCode = obj.Project;
                    if (obj.TransCode != "")
                    {
                        odn.TransactionCode = obj.TransCode;
                    }
                    odn.Reference = obj.Ref1;
                    odn.Reference2 = obj.Ref2;
                    odn.Reference3 = obj.Ref3;

                    if (obj.AutoStorno == "Y")
                    {
                        odn.UseAutoStorno = BoYesNoEnum.tYES;
                        odn.StornoDate = obj.StornoDate;

                    }
                    if (obj.AutoStorno == "N")
                    {
                        odn.UseAutoStorno = BoYesNoEnum.tNO;
                    }

                    obj.Lines.ForEach(item => {

                        odn.Lines.SetCurrentLine(item.LineNum - 1);

                        odn.Lines.LineMemo = item.LineMemo;
                        odn.Lines.Reference1 = item.Ref1d;
                        odn.Lines.Reference2 = item.Ref2d;
                        odn.Lines.AdditionalReference = item.Ref3Line;
                        odn.Lines.DueDate = Convert.ToDateTime(item.DueDated);
                        odn.Lines.ProjectCode = item.Projectd;

                        odn.Lines.Add();


                    });


                    ocp.StartTransaction();
                    RetVal = odn.Update();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        //obj.CallId = Convert.ToInt32(ocp.GetNewObjectKey());
                        //RetVal = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }

        }


        public IDataReader Get_OSCSP_SRCH_JDT1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_JDT1", obep.TransId);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }

        public IDataReader DXP_GET_CUENTAS_ASIENTO(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_CUENTAS_ASIENTO", obep.cuenta);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }

        public IDataReader DXP_GET_PROYECTO(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_PROYECTO", obep.Proyecto);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_OJDT(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_OJDT", obep.DateIn, obep.DateFi, obep.BaseRef);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }










        public IDataReader Get_OSCSP_SRCH_ORPC(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_ORPC", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.CardCode, obep.CardName, obep.Project, obep.Id_Dire, obep.Code);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA EL DETALLE DE LAS NOTAS DE CREDITO
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_RIN1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_RIN1", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_RPC1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_RPC1", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_SerialNumber(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_SERIALNUMBER", obep.ItemCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_LotesNumber(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_LOTESNUMBER", obep.ItemCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_ListadeMateriales(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_LISTADEMATERIALES", obep.ItemCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader GET_ANTICIPOS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("GET_ANTICIPOS", obep.DocEntry, obep.ObjType);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public void INSERT_OITR(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_RECON_2", obep.DocEntry, obep.Total, obep.DateIn, obep.Moneda);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                //return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public void INSERT_ITR1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_RECON_3", obep.DocEntry, obep.Total, obep.TotalFC, obep.CardCode, obep.Moneda,
                                                    obep.TransId, obep.DraftEntry, obep.Reserve, obep.SerieMaqr, obep.Linea);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                //return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public void Updt_Tablas_Recon(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_RECON_1", obep.Total, obep.Total2, obep.Total3, obep.Total4, obep.DocEntry,
                                                    obep.CardCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                //return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public void Updt_JDT1_Recon(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_RECON_4", obep.TransId, obep.Total, obep.Total2);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                //return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public void Updt_JDT1_Recon_2(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_RECON_5", obep.TransId, obep.Total, obep.Total2);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                //return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public void Updt_JDT1_Recon_3(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_RECON_6", obep.TransId, obep.Total, obep.Total2);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                //return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LOS DOCUMENTOS DE ENTREGA
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_ODLN(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_ODLN", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.CardCode, obep.CardName, obep.Project, obep.Id_Dire, obep.Code);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_OPDN(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_OPDN", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.CardCode, obep.CardName, obep.Project, obep.Id_Dire, obep.Code);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA EL DETALLE DE LOS DOCUMENTOS DE ENTREGA
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_DLN1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_DLN1", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_PDN1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_PDN1", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// Validar Correlativo
        /// </summary>
        /// <param name="obep"></param>
        /// <returns></returns>
        public IDataReader Get_ValidarCorrelativo(BEParameters obep, string corre)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("Sp_Val_Correlativo", corre);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        private string Val_Almacen(string socied, string tipdoc, string serie) {
            string alm = "";
            switch (tipdoc)
            {
                case "03":
                    if (socied == "BT" && serie == "004" || serie == "016") {
                        alm = "BF_BFARM";
                    }
                    if (socied == "BT" && serie == "015")
                    {
                        alm = "BF_CASON";
                    }
                    if (socied == "BT" && serie == "018")
                    {
                        alm = "BF003";
                    }
                    if (socied == "BM" && serie == "010")
                    {
                        alm = "BL021";//BL014
                    }
                    if (socied == "BM" && serie == "016")
                    {
                        alm = "BL018";
                    }
                    if (socied == "BM" && serie == "028")
                    {
                        alm = "BL025";
                    }
                    if (socied == "BM" && serie == "002")
                    {
                        alm = "BL014";//BL014 BF_ODRIO
                    }
                    break;
                case "01":
                    if (socied == "BT" && serie == "002" || serie == "016") {
                        alm = "BF_BFARM";
                    }
                    if (socied == "BT" && serie == "015")
                    {
                        alm = "BF_CASON";
                    }
                    if (socied == "BT" && serie == "018")
                    {
                        alm = "BF003";
                    }
                    if (socied == "BM" && serie == "010")
                    {
                        alm = "BL021";//BL014
                    }
                    if (socied == "BM" && serie == "016")
                    {
                        alm = "BL018";
                    }
                    if (socied == "BM" && serie == "028")
                    {
                        alm = "BL025";
                    }
                    else
                    {
                        alm = "";
                    }
                    break;
                case "12":
                    if (socied == "BT" && serie == "020") {
                        alm = "BF_BFARM";
                    }
                    if (socied == "BT" && serie == "013")
                    {
                        alm = "BF_CASON";
                    }
                    if (socied == "BT" && serie == "019")
                    {
                        alm = "BF003";
                    }
                    if (socied == "BM" && serie == "030")
                    {
                        alm = "BF_CETE";
                    }
                    if (socied == "BM" && serie == "009")
                    {
                        alm = "BL021";//BL014
                    }
                    if (socied == "BM" && serie == "033")
                    {
                        alm = "BL014";//BL014 //BF_ODRIO
                    }
                    if (socied == "BM" && serie == "017")
                    {
                        alm = "BL018";
                    }
                    if (socied == "BM" && serie == "027")
                    {
                        alm = "BL025";
                    }
                    if (socied == "BT" && serie == "024")
                    {
                        alm = "YOB_ME"; //BF_PLNOR
                    }
                    break;
            }
            return alm;
        }
        public void SavePurchaseDeliveryNote(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);
                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oPurchaseDeliveryNotes);

                    //? CABECERA
                    odn.DocType = BoDocumentTypes.dDocument_Items;
                    odn.DocDate = obj.DocDate;
                    odn.TaxDate = obj.TaxDate;
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.FederalTaxID = obj.LicTradNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.Project = obj.Project;
                    odn.DocCurrency = obj.Currency;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.HandWritten = BoYesNoEnum.tNO;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    odn.UserFields.Fields.Item("U_BPP_MDTD").Value = obj.U_BPP_MDTD;
                    odn.UserFields.Fields.Item("U_BPP_MDSD").Value = obj.U_BPP_MDSD;
                    odn.UserFields.Fields.Item("U_BPP_MDCD").Value = obj.U_BPP_MDCD;
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;
                    
                    obj.Lines.Where(i => i.TreeType != "I").ToList().ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                        odn.Lines.Quantity = Convert.ToDouble(_item.Quantity);
                        if (_item.DiscPrcnt > 0)
                            odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                        odn.Lines.WarehouseCode = _item.WhsCode;

                        //SERIALNUMBER (FOR PARA OBTENER LAS SERIES Y AGREGAR)
                        if (_item.IssueMthd.Substring(0,1) == "M" && !string.IsNullOrWhiteSpace(_item.Serie))
                        {
                            var series = _item.Serie.Split(';');
                            for (var i = 0; i <= Convert.ToDouble(_item.Quantity) - 1; i++)
                            {
                                //odn.Lines.SerialNumbers.SystemSerialNumber = 17;
                                odn.Lines.SerialNumbers.ManufacturerSerialNumber = series[i];
                                odn.Lines.SerialNumbers.InternalSerialNumber = series[i];
                                odn.Lines.SerialNumbers.Add();
                            }
                        }
                        else if (_item.IssueMthd.Substring(0, 1) == "L" && !string.IsNullOrWhiteSpace(_item.Serie))
                        {
                            var series = _item.Serie.Split(';');
                            for (var i = 0; i < series.Count(); i++)
                            {

                                var serialnumber = series[i].Split('-');
                                odn.Lines.BatchNumbers.BatchNumber = serialnumber[0];
                                odn.Lines.BatchNumbers.Quantity = Convert.ToDouble(serialnumber[1]);
                                if (serialnumber[2] != "/")
                                    odn.Lines.BatchNumbers.ExpiryDate = Convert.ToDateTime(serialnumber[2]);
                                else;
                                odn.Lines.BatchNumbers.Add();
                            }
                        }
                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        odn.Lines.TaxCode = (string.IsNullOrWhiteSpace(_item.TaxCode)) ? "IGV" : _item.TaxCode;
                        if (_item.BaseEntry != 0)
                        {
                            odn.Lines.BaseType = _item.BaseType;
                            odn.Lines.BaseEntry = _item.BaseEntry;
                            odn.Lines.BaseLine = _item.BaseLine;
                        }

                        //? LOTES
                        if (!string.IsNullOrWhiteSpace(_item.BatchNums))
                        {
                            var arbt = _item.BatchNums.Split('!');
                            arbt.Where(i => !string.IsNullOrWhiteSpace(i))
                                .ToList()
                                .ForEach(i =>
                                {
                                    var vlbn = i.Split('¡');
                                    odn.Lines.BatchNumbers.BatchNumber = vlbn[0];
                                    odn.Lines.BatchNumbers.Quantity = Convert.ToDouble(vlbn[1]);
                                    odn.Lines.BatchNumbers.Add();
                                });
                        }
                        odn.Lines.Add();
                    });

                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD_PURCHASE";
                        ors.Command.Parameters.Item("@DscTable").Value = "OPDN o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SaveListaMateriales(BEProduct obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);
                if (ocp.Connected)
                {
                    var odn = (ProductTrees)ocp.GetBusinessObject(BoObjectTypes.oProductTrees);

                    odn.TreeCode = obj.ItemCode;
                    odn.TreeType = BoItemTreeTypes.iSalesTree;
                    
                    obj.Hijos.ForEach(item =>
                    {
                        odn.Items.ItemCode = item.Code;
                        odn.Items.Quantity = Convert.ToDouble(item.Quantity2);
                        //odn.Items.InventoryUOM = item.InvntryUom;
                        odn.Items.Warehouse = item.Warehouse;
                        odn.Items.Add();
                    });
                    //odn.Add();

                    
                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                            
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void UpdateKits(BEProduct obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);
                if (ocp.Connected)
                {
                    var odn = (ProductTrees)ocp.GetBusinessObject(BoObjectTypes.oProductTrees);

                    odn.GetByKey(obj.ItemCode);
                    //odn.TreeType = BoItemTreeTypes.iSalesTree;
                    var lines = odn.Items.Count;
                    for (int i = 0; i < lines; i++)
                    {
                        odn.Items.SetCurrentLine(0);
                        odn.Items.Delete();
                    }

                    obj.Hijos.ForEach(item =>
                    {
                        odn.Items.ItemCode = item.Code;
                        odn.Items.Quantity = Convert.ToDouble(item.Quantity2);
                        //odn.Items.InventoryUOM = item.InvntryUom;
                        odn.Items.Warehouse = item.Warehouse;
                        odn.Items.Add();
                    });
                    //odn.Add();


                    ocp.StartTransaction();
                    RetVal = odn.Update();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);

                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SaveCurrencyDates(BETipoCambio obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (SBObob)ocp.GetBusinessObject(BoObjectTypes.BoBridge);

                    if (obj.RateUSD != 0)
                        odn.SetCurrencyRate("USD", obj.RateDate, Convert.ToDouble(obj.RateUSD), true);
                    if (obj.RateEUR != 0)
                        odn.SetCurrencyRate("EUR", obj.RateDate, Convert.ToDouble(obj.RateEUR), true);
                    ocp.StartTransaction();
                    //RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        //obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        //var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        //ors.Command.Name = "OSCSP_OBJD";
                        //ors.Command.Parameters.Item("@DscTable").Value = "OINV o";
                        //ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        //ors.Command.Execute();
                        //ors.MoveFirst();
                        //obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SaveInit(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);

                    odn.DoQuery("exec sp_execute 30,478");
                    odn.MoveFirst();
                    obj.CardCode = Convert.ToInt32(odn.Fields.Item(0).Value);
                    ocp.StartTransaction();

                    //RetVal = odn.;
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SaveRecon(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                    ors.DoQuery("SELECT TOP 1 ReconNum FROM OITR ORDER BY 1 DESC");
                    ors.MoveFirst();
                    obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value)+1;
                    ////////////////////////////////////////////////////////////////////////
                    var obj1 = new BEParameters();
                    obj1.DocEntry = obj.DocNum;
                    obj1.Total = obj.Credit;
                    obj1.DateIn = obj.DocDate;
                    obj1.Moneda = "SOL";
                    obj1.Socied = obj.Socied;
                    INSERT_OITR(obj1);
                    //////////////////////////////////////////////////////////////////////////
                    var x = 0;
                    obj.Lineas.Where(i => i.Active == "Y").ToList().ForEach(item =>
                    {
                        var obj2 = new BEParameters();
                        obj2.Linea = x;
                        x++;
                        obj2.DocEntry = obj.DocNum;
                        if (item.BalScCred == 0)
                        {
                            obj2.Total = item.BalScDeb;
                            obj2.Reserve = "D";
                        }
                        else
                        {
                            obj2.Total = item.BalScCred;
                            obj2.Reserve = "C";
                        }
                        obj2.TotalFC = 0;
                        obj2.CardCode = obj.CardCode;
                        obj2.Moneda = "SOL";
                        obj2.TransId = item.DocEntry;
                        var spl = item.Ref1.Split('-');
                        obj2.DraftEntry = Convert.ToInt32(spl[1]);
                        obj2.SerieMaqr = "121201";
                        obj2.Socied = obj.Socied;
                        INSERT_ITR1(obj2);
                    });
                    //////////////////////////////////////////////////////////////////////////
                    obj.Lineas.Where(j => j.BaseDocEntry == 13).ToList().ForEach(ite =>
                    {
                        var spl = ite.Ref1.Split('-');
                        var ors2 = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors2.DoQuery("SELECT PaidSys, VatSumSy FROM INV6 WHERE DocEntry = " + spl[1]);
                        ors2.MoveFirst();
                        var antitotalpaid = Convert.ToDecimal(ors2.Fields.Item(0).Value);
                        var antitotalvat = Convert.ToDecimal(ors2.Fields.Item(1).Value);

                        var obj3 = new BEParameters();
                        //obj3.Total = antitotalpaid + ite.Debit;
                        obj3.Total2 = decimal.Round((antitotalpaid + ite.BalScDeb),6);
                        obj3.Total = decimal.Round(antitotalpaid + ite.BalScDeb, 6);
                        obj3.Total3 = decimal.Round((obj3.Total * antitotalvat / ite.DocTotal), 6);
                        obj3.Total4 = decimal.Round((obj3.Total * antitotalvat / ite.DocTotal),6);
                        obj3.DocEntry = Convert.ToInt32(spl[1]);
                        obj3.CardCode = obj.CardCode;
                        obj3.Socied = obj.Socied;
                        Updt_Tablas_Recon(obj3);

                        var ors3 = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors3.DoQuery("SELECT BalScDeb FROM JDT1 WHERE Line_ID = 0 AND TransId = " + ite.DocEntry);
                        ors3.MoveFirst();
                        var jdt1fact1 = Convert.ToDecimal(ors3.Fields.Item(0).Value);
                        var obj4 = new BEParameters();
                        obj4.TransId = ite.DocEntry;
                        obj4.Total = decimal.Round((jdt1fact1 - ite.BalScDeb),6);
                        obj4.Total2 = decimal.Round(obj4.Total,6);
                        obj4.Socied = obj.Socied;
                        Updt_JDT1_Recon_2(obj4);
                    });
                    ////////////////////////////////////////////////////////////////////////////////
                    obj.Lineas.Where(j => j.BaseDocEntry == 24).ToList().ForEach(ite =>
                    {
                        var spl = ite.Ref1.Split('-');
                        var ors4 = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors4.DoQuery("SELECT OpenBalSc FROM ORCT WHERE DocEntry = " + spl[1]);
                        ors4.MoveFirst();
                        var openbalcuenta = Convert.ToDecimal(ors4.Fields.Item(0).Value);

                        var obj6 = new BEParameters();
                        obj6.TransId = Convert.ToInt32(spl[1]);
                        obj6.Total = decimal.Round((openbalcuenta - ite.BalScCred),6);
                        obj6.Total2 = decimal.Round(obj6.Total,6);
                        obj6.Socied = obj.Socied;
                        Updt_JDT1_Recon_3(obj6);


                        var ors5 = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors5.DoQuery("SELECT BalScCred FROM JDT1 WHERE Line_ID = 1 AND TransId = " + ite.DocEntry);
                        ors5.MoveFirst();
                        var jdt1cuenta1 = Convert.ToDecimal(ors5.Fields.Item(0).Value);
                        var obj5 = new BEParameters();
                        obj5.TransId = ite.DocEntry;
                        obj5.Total = decimal.Round((jdt1cuenta1 - ite.BalScCred),6);
                        obj5.Total2 = decimal.Round(obj5.Total,6);
                        obj5.Socied = obj.Socied;
                        Updt_JDT1_Recon(obj5);
                    });




                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SaveItems(BEProduct obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Items)ocp.GetBusinessObject(BoObjectTypes.oItems);

                    odn.ItemCode = obj.ItemCode;
                    odn.ItemName = obj.ItemName;
                    odn.IndirectTax = BoYesNoEnum.tYES;
                    //if (obj.ItemType == "I") 
                    odn.ItemType = ItemTypeEnum.itItems;
                    //else if (obj.ItemType == "L") odn.ItemType = ItemTypeEnum.itLabor;
                    //else if (obj.ItemType == "T") odn.ItemType = ItemTypeEnum.itTravel;
                    odn.ItemsGroupCode = Convert.ToInt32(obj.ItmsGrpCod);
                    if (obj.IssueMthd == "N") odn.IssueMethod = BoIssueMethod.im_Backflush;
                    else if (obj.IssueMthd == "S")
                    {
                        odn.IssueMethod = BoIssueMethod.im_Manual;
                        odn.ManageSerialNumbers = BoYesNoEnum.tYES;
                        odn.ManageBatchNumbers = BoYesNoEnum.tNO;
                        if (obj.MngMethod == "A") odn.SRIAndBatchManageMethod = BoManageMethod.bomm_OnEveryTransaction;
                        else if (obj.MngMethod == "R") odn.SRIAndBatchManageMethod = BoManageMethod.bomm_OnReleaseOnly;
                    }
                    else if (obj.IssueMthd == "L")
                    {
                        odn.IssueMethod = BoIssueMethod.im_Manual;
                        odn.ManageSerialNumbers = BoYesNoEnum.tNO;
                        odn.ManageBatchNumbers = BoYesNoEnum.tYES;
                        if (obj.MngMethod == "A") odn.SRIAndBatchManageMethod = BoManageMethod.bomm_OnEveryTransaction;
                        else if (obj.MngMethod == "R") odn.SRIAndBatchManageMethod = BoManageMethod.bomm_OnReleaseOnly;
                    }
                    odn.UserFields.Fields.Item("U_BPP_TIPEXIST").Value = obj.U_BPP_TIPEXIST;
                    odn.UserFields.Fields.Item("U_GOS_MARCA").Value = obj.U_GOS_MARCA;
                    odn.UserFields.Fields.Item("U_GOS_MODELO").Value = obj.U_GOS_MODELO;
                    if (obj.GLMethod == "C") odn.GLMethod = BoGLMethods.glm_ItemClass;
                    else if (obj.GLMethod == "W") odn.GLMethod = BoGLMethods.glm_WH;
                    else if (obj.GLMethod == "L") odn.GLMethod = BoGLMethods.glm_ItemLevel;

                    if (obj.InvntItem == "Y") odn.InventoryItem = BoYesNoEnum.tYES;
                    else if (obj.InvntItem == "N") odn.InventoryItem = BoYesNoEnum.tNO;

                    if (obj.SellItem == "Y") odn.SalesItem = BoYesNoEnum.tYES;
                    else if (obj.SellItem == "N") odn.SalesItem = BoYesNoEnum.tNO;

                    if (obj.PrchseItem == "Y") odn.PurchaseItem = BoYesNoEnum.tYES;
                    else if (obj.PrchseItem == "N") odn.PurchaseItem = BoYesNoEnum.tNO;

                    if (obj.ByWh == "Y") odn.ManageStockByWarehouse = BoYesNoEnum.tYES;
                    else if (obj.ByWh == "N") odn.ManageStockByWarehouse = BoYesNoEnum.tNO;

                    if (obj.ActivoC == "Y") odn.Properties[1] = BoYesNoEnum.tYES;
                    else if (obj.ActivoC == "N") odn.Properties[1] = BoYesNoEnum.tNO;

                    if (obj.ActivoS == "Y") odn.Properties[2] = BoYesNoEnum.tYES;
                    else if (obj.ActivoS == "N") odn.Properties[2] = BoYesNoEnum.tNO;

                    if (obj.NoFacturable == "Y") odn.Properties[3] = BoYesNoEnum.tYES;
                    else if (obj.NoFacturable == "N") odn.Properties[3] = BoYesNoEnum.tNO;

                    if(obj.DetalleServicio != "0" && !string.IsNullOrEmpty(obj.DetalleServicio))
                        odn.UserFields.Fields.Item("U_DXP_DET_SERV").Value = Convert.ToInt32(obj.DetalleServicio);
                    odn.PurchaseUnit = obj.BuyUnitMsr;
                    odn.PurchaseItemsPerUnit = Convert.ToDouble(obj.NumInBuy);
                    odn.PurchasePackagingUnit = obj.PurPackMsr;
                    odn.PurchaseQtyPerPackUnit = Convert.ToInt32(obj.PurPackUn);
                    odn.ApTaxCode = obj.TaxCodeAP;

                    odn.SalesUnit = obj.SalUnitMsr;
                    odn.SalesItemsPerUnit = Convert.ToDouble(obj.NumInSale);
                    odn.SalesPackagingUnit = obj.SalPackMsr;
                    odn.SalesQtyPerPackUnit = Convert.ToInt32(obj.SalPackUn);
                    odn.ArTaxCode = obj.TaxCodeAR;

                    odn.InventoryUOM = obj.InvntryUom;          

                    obj.Almacenes.ForEach(item =>
                    {
                        odn.WhsInfo.WarehouseCode = item.WhsCode;
                        if (item.Locked == "Y") odn.WhsInfo.Locked = BoYesNoEnum.tYES;
                        else if (item.Locked == "N") odn.WhsInfo.Locked = BoYesNoEnum.tNO;
                        odn.WhsInfo.Add();
                    });
                    var i = 0;
                    obj.Precios.ForEach(item =>
                    {
                        odn.PriceList.SetCurrentLine(i);
                        odn.PriceList.Currency = "SOL";
                        odn.PriceList.Price = Convert.ToDouble(item.Price);
                        i++;
                    });

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        //obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        //var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        //ors.Command.Name = "OSCSP_OBJD";
                        //ors.Command.Parameters.Item("@DscTable").Value = "OINV o";
                        //ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        //ors.Command.Execute();
                        //ors.MoveFirst();
                        //obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void UpdateItems(BEProduct obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Items)ocp.GetBusinessObject(BoObjectTypes.oItems);

                    odn.GetByKey(obj.ItemCode);
                    odn.ItemName = obj.ItemName;
                    odn.IndirectTax = BoYesNoEnum.tYES;
                    //if (obj.ItemType == "I") 
                    odn.ItemType = ItemTypeEnum.itItems;
                    //else if (obj.ItemType == "L") odn.ItemType = ItemTypeEnum.itLabor;
                    //else if (obj.ItemType == "T") odn.ItemType = ItemTypeEnum.itTravel;
                    odn.ItemsGroupCode = Convert.ToInt32(obj.ItmsGrpCod);
                    if (obj.IssueMthd == "N") odn.IssueMethod = BoIssueMethod.im_Backflush;
                    else if (obj.IssueMthd == "S")
                    {
                        odn.IssueMethod = BoIssueMethod.im_Manual;
                        odn.ManageSerialNumbers = BoYesNoEnum.tYES;
                        odn.ManageBatchNumbers = BoYesNoEnum.tNO;
                        //if (obj.MngMethod == "A") 
                        odn.SRIAndBatchManageMethod = BoManageMethod.bomm_OnEveryTransaction;
                        //else if (obj.MngMethod == "R") odn.SRIAndBatchManageMethod = BoManageMethod.bomm_OnReleaseOnly;
                    }
                    else if (obj.IssueMthd == "L")
                    {
                        odn.IssueMethod = BoIssueMethod.im_Manual;
                        odn.ManageSerialNumbers = BoYesNoEnum.tNO;
                        odn.ManageBatchNumbers = BoYesNoEnum.tYES;
                        //if (obj.MngMethod == "A") 
                        odn.SRIAndBatchManageMethod = BoManageMethod.bomm_OnEveryTransaction;
                        //else if (obj.MngMethod == "R") odn.SRIAndBatchManageMethod = BoManageMethod.bomm_OnReleaseOnly;
                    }
                    odn.UserFields.Fields.Item("U_BPP_TIPEXIST").Value = obj.U_BPP_TIPEXIST;
                    odn.UserFields.Fields.Item("U_GOS_MARCA").Value = obj.U_GOS_MARCA;
                    odn.UserFields.Fields.Item("U_GOS_MODELO").Value = obj.U_GOS_MODELO;
                    if (obj.GLMethod == "C") odn.GLMethod = BoGLMethods.glm_ItemClass;
                    else if (obj.GLMethod == "W") odn.GLMethod = BoGLMethods.glm_WH;
                    else if (obj.GLMethod == "L") odn.GLMethod = BoGLMethods.glm_ItemLevel;

                    if (obj.InvntItem == "Y") odn.InventoryItem = BoYesNoEnum.tYES;
                    else if (obj.InvntItem == "N") odn.InventoryItem = BoYesNoEnum.tNO;

                    if (obj.SellItem == "Y") odn.SalesItem = BoYesNoEnum.tYES;
                    else if (obj.SellItem == "N") odn.SalesItem = BoYesNoEnum.tNO;

                    if (obj.PrchseItem == "Y") odn.PurchaseItem = BoYesNoEnum.tYES;
                    else if (obj.PrchseItem == "N") odn.PurchaseItem = BoYesNoEnum.tNO;

                    if (obj.ByWh == "Y") odn.ManageStockByWarehouse = BoYesNoEnum.tYES;
                    else if (obj.ByWh == "N") odn.ManageStockByWarehouse = BoYesNoEnum.tNO;

                    if (obj.ActivoC == "Y") odn.Properties[1] = BoYesNoEnum.tYES;
                    else if (obj.ActivoC == "N") odn.Properties[1] = BoYesNoEnum.tNO;

                    if (obj.ActivoS == "Y") odn.Properties[2] = BoYesNoEnum.tYES;
                    else if (obj.ActivoS == "N") odn.Properties[2] = BoYesNoEnum.tNO;

                    if (obj.NoFacturable == "Y") odn.Properties[3] = BoYesNoEnum.tYES;
                    else if (obj.NoFacturable == "N") odn.Properties[3] = BoYesNoEnum.tNO;

                    if (obj.DetalleServicio != "0")
                        odn.UserFields.Fields.Item("U_DXP_DET_SERV").Value = Convert.ToInt32(obj.DetalleServicio);
                    odn.PurchaseUnit = obj.BuyUnitMsr;
                    odn.PurchaseItemsPerUnit = Convert.ToDouble(obj.NumInBuy);
                    odn.PurchasePackagingUnit = obj.PurPackMsr;
                    odn.PurchaseQtyPerPackUnit = Convert.ToInt32(obj.PurPackUn);
                    odn.ApTaxCode = obj.TaxCodeAP;

                    odn.SalesUnit = obj.SalUnitMsr;
                    odn.SalesItemsPerUnit = Convert.ToDouble(obj.NumInSale);
                    odn.SalesPackagingUnit = obj.SalPackMsr;
                    odn.SalesQtyPerPackUnit = Convert.ToInt32(obj.SalPackUn);
                    odn.ArTaxCode = obj.TaxCodeAR;

                    odn.InventoryUOM = obj.InvntryUom;

                    var j = 0;

                    obj.Almacenes/*.Where(m => m.Tiempo == "Nuevo").ToList()*/.ForEach(item =>
                    {
                            odn.WhsInfo.SetCurrentLine(item.Linea);
                            odn.WhsInfo.WarehouseCode = item.WhsCode;
                            if (item.Locked == "Y") odn.WhsInfo.Locked = BoYesNoEnum.tYES;
                            else odn.WhsInfo.Locked = BoYesNoEnum.tNO;
                            odn.WhsInfo.Add();
                            j++;
                    });
                    var i = 0;
                    obj.Precios.ForEach(item =>
                    {
                        odn.PriceList.SetCurrentLine(i);
                        odn.PriceList.Currency = "SOL";
                        odn.PriceList.Price = Convert.ToDouble(item.Price);
                        i++;
                    });

                    ocp.StartTransaction();
                    RetVal = odn.Update();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        //obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        //var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        //ors.Command.Name = "OSCSP_OBJD";
                        //ors.Command.Parameters.Item("@DscTable").Value = "OINV o";
                        //ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        //ors.Command.Execute();
                        //ors.MoveFirst();
                        //obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        /// <summary>
        /// GUARDA DOCUMENTOS DE VENTA
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objs"></param>
        public void SaveInvoice(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                                
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oInvoices);

                    obj.Anticipos.ForEach(entrys =>
                    {
                        if (entrys.Active == "Y")
                        {
                            var pdm = (Documents)ocp.GetBusinessObject(BoObjectTypes.oDownPayments);
                            var anticipo = (DownPaymentsToDraw)odn.DownPaymentsToDraw;
                            pdm.GetByKey(entrys.DocEntry);
                            anticipo.AmountToDraw = pdm.DownPaymentAmount;
                            anticipo.DocEntry = pdm.DocEntry;
                            anticipo.Add();
                        }
                    });


                    //? CABECERA
                    if (obj.Reserve == "N")
                    {
                        odn.ReserveInvoice = BoYesNoEnum.tNO;
                        odn.ShipToCode = obj.ShipToCode;
                        odn.PayToCode = obj.PayToCode;
                    }
                    else
                    {
                        odn.ReserveInvoice = BoYesNoEnum.tYES;
                        odn.ShipToCode = obj.ShipToCode;
                        odn.PayToCode = obj.PayToCode;
                    }             
                    odn.DocType = BoDocumentTypes.dDocument_Items;
                    odn.DocDate = obj.DocDate;
                    odn.TaxDate = obj.TaxDate;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    odn.DocDueDate = obj.DocDate;
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.FederalTaxID = obj.LicTradNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.Project = obj.Project;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.HandWritten = BoYesNoEnum.tNO;
                    odn.DocCurrency = obj.Currency;
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;
                    odn.UserFields.Fields.Item("U_BPP_MDTD").Value = obj.U_BPP_MDTD;
                    odn.UserFields.Fields.Item("U_BPP_MDSD").Value = obj.U_BPP_MDSD;
                    //---------------------------------------------------------------------------
                    //var ors2 = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                    //ors2.Command.Name = "OSCSP_OBJD";
                    //ors2.Command.Parameters.Item("@DscTable").Value = "OINV o";
                    //ors2.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                    //ors2.Command.Execute();
                    //ors2.MoveFirst();
                    //obj.U_BPP_MDCD = Convert.ToInt32(ors2.Fields.Item(0).Value);
                    //---------------------------------------------------------------------------
                    odn.UserFields.Fields.Item("U_BPP_MDCD").Value = obj.U_BPP_MDCD;
                    odn.UserFields.Fields.Item("U_MP_FE_GRR").Value = string.IsNullOrWhiteSpace(obj.U_MP_FE_GRR) ? string.Empty : obj.U_MP_FE_GRR;
                    odn.UserFields.Fields.Item("U_DXP_FE_TO").Value = string.IsNullOrWhiteSpace(obj.U_DXP_FE_TO) ? "0101" : obj.U_DXP_FE_TO;
                    
                    //? DETALLE
                    obj.Lines.Where(i => i.TreeType != "I").ToList().ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                        odn.Lines.Quantity = Convert.ToDouble(_item.Quantity);
                        if (_item.DiscPrcnt > 0)
                            odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                        //odn.Lines.WarehouseCode = Val_Almacen(obj.Socied, obj.U_BPP_MDTD, obj.U_BPP_MDSD); // _item.WhsCode;
                        odn.Lines.WarehouseCode = _item.WhsCode;
                        if (_item.IssueMthd.Substring(0, 1) == "M" && !string.IsNullOrWhiteSpace(_item.Serie))
                        {
                            var series = _item.Serie.Split(';');
                            for (var i = 0; i <= Convert.ToDouble(_item.Quantity) - 1; i++)
                            {
                                var serialnumber = series[i].Split('-');
                                odn.Lines.SerialNumbers.SystemSerialNumber = Convert.ToInt32(serialnumber[1]);
                                odn.Lines.SerialNumbers.Quantity = 1;
                                odn.Lines.SerialNumbers.Add();
                            }
                            //
                        }
                        else if (_item.IssueMthd.Substring(0, 1) == "L" && !string.IsNullOrWhiteSpace(_item.Serie))
                        {
                            var series = _item.Serie.Split(';');
                            for (var i = 0; i < series.Count(); i++)
                            {
                                var serialnumber = series[i].Split('-');
                                //odn.Lines.BatchNumbers.BaseLineNumber = i;
                                odn.Lines.BatchNumbers.BatchNumber = serialnumber[0];
                                odn.Lines.BatchNumbers.Quantity = Convert.ToDouble(serialnumber[1]);
                                odn.Lines.BatchNumbers.Add();
                            }
                        }
                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        odn.Lines.TaxCode = (string.IsNullOrWhiteSpace(_item.TaxCode)) ? "IGV" : _item.TaxCode;
                        //odn.Lines.UserFields.Fields.Item("U_BF_CodKit").Value = string.IsNullOrWhiteSpace(_item.U_BF_CodKit) ? string.Empty : _item.U_BF_CodKit;
                        //odn.Lines.UserFields.Fields.Item("U_BF_LOTE").Value = string.IsNullOrWhiteSpace(_item.U_BF_LOTE) ? string.Empty : _item.U_BF_LOTE;
                        if (_item.BaseEntry != 0)
                        {
                            odn.Lines.BaseType = _item.BaseType;
                            odn.Lines.BaseEntry = _item.BaseEntry;
                            odn.Lines.BaseLine = _item.BaseLine;
                        }

                        if (obj.Reserve == "N")
                        {
                            //? LOTES
                            if (!string.IsNullOrWhiteSpace(_item.BatchNums))
                            {
                                var arbt = _item.BatchNums.Split('!');
                                arbt.Where(i => !string.IsNullOrWhiteSpace(i))
                                    .ToList()
                                    .ForEach(i =>
                                    {
                                        var vlbn = i.Split('¡');
                                        var qins = Convert.ToDouble(vlbn[1]);
                                        if (_item.NumInSale > 1)
                                            qins = Convert.ToDouble(vlbn[1]) * Convert.ToDouble(_item.NumInSale);                                         
                                        odn.Lines.BatchNumbers.BatchNumber = vlbn[0];
                                        odn.Lines.BatchNumbers.Quantity = qins;
                                        odn.Lines.BatchNumbers.Add();
                                    });
                            }
                        }
                        odn.Lines.Add();
                    });

                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    //? GASTO ADICIONAL (MOVILIDAD)
                    if (obj.TotalExpns > 0)
                    {
                        odn.Expenses.ExpenseCode = string.Compare(obj.Socied, "BT", false) == 0 ? 1 : 9;
                        odn.Expenses.TaxCode = "IGV";
                        odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                        odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                        if (obj.BaseDocEntry != 0)
                        {
                            odn.Expenses.BaseDocType = obj.BaseDocType;
                            odn.Expenses.BaseDocLine = 0;
                            odn.Expenses.BaseDocEntry = obj.BaseDocEntry;
                        }
                        odn.Expenses.Add();
                    }

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {                        
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD";
                        ors.Command.Parameters.Item("@DscTable").Value = "OINV o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SaveDownPayment(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oDownPayments);

                    //? CABECERA
                    //if (obj.Reserve == "N")
                    //{
                    //    odn.ReserveInvoice = BoYesNoEnum.tNO;
                    //    odn.ShipToCode = obj.ShipToCode;
                    //    odn.PayToCode = obj.PayToCode;
                    //}
                    //else
                    //    odn.ReserveInvoice = BoYesNoEnum.tYES;
                    odn.DocType = BoDocumentTypes.dDocument_Items;
                    odn.DocDate = obj.DocDate;
                    odn.TaxDate = obj.TaxDate;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    odn.DocDueDate = obj.DocDate;
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.FederalTaxID = obj.LicTradNum;
                    odn.ShipToCode = obj.ShipToCode;
                    odn.PayToCode = obj.PayToCode;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.Project = obj.Project;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.HandWritten = BoYesNoEnum.tNO;
                    odn.DocCurrency = obj.Currency;
                    odn.DownPaymentType = DownPaymentTypeEnum.dptInvoice;
                    odn.DownPaymentPercentage = Convert.ToDouble(obj.DpmPrcnt);
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;
                    odn.UserFields.Fields.Item("U_BPP_MDTD").Value = obj.U_BPP_MDTD;
                    odn.UserFields.Fields.Item("U_BPP_MDSD").Value = obj.U_BPP_MDSD;
                    odn.UserFields.Fields.Item("U_BPP_MDCD").Value = obj.U_BPP_MDCD;
                    odn.UserFields.Fields.Item("U_MP_FE_GRR").Value = string.IsNullOrWhiteSpace(obj.U_MP_FE_GRR) ? string.Empty : obj.U_MP_FE_GRR;
                    odn.UserFields.Fields.Item("U_DXP_FE_TO").Value = string.IsNullOrWhiteSpace(obj.U_DXP_FE_TO) ? "0104" : obj.U_DXP_FE_TO;

                    //? DETALLE
                    obj.Lines.Where(i => i.TreeType != "I").ToList().ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                        odn.Lines.Quantity = Convert.ToDouble(_item.Quantity);
                        odn.Lines.WarehouseCode = _item.WhsCode;
                        if (_item.DiscPrcnt > 0)
                            odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                        
                        //if (_item.IssueMthd.Substring(0, 1) == "M" && !string.IsNullOrWhiteSpace(_item.Serie))
                        //{
                        //    var series = _item.Serie.Split(';');
                        //    for (var i = 0; i <= Convert.ToDouble(_item.Quantity) - 1; i++)
                        //    {
                        //        var serialnumber = series[i].Split('-');
                        //        odn.Lines.SerialNumbers.SystemSerialNumber = Convert.ToInt32(serialnumber[1]);
                        //        odn.Lines.SerialNumbers.Quantity = 1;
                        //        odn.Lines.SerialNumbers.Add();
                        //    }
                        //}
                        //else if (_item.IssueMthd.Substring(0, 1) == "L" && !string.IsNullOrWhiteSpace(_item.Serie))
                        //{
                        //    var series = _item.Serie.Split(';');
                        //    for (var i = 0; i < series.Count(); i++)
                        //    {
                        //        var serialnumber = series[i].Split('-');
                        //        odn.Lines.BatchNumbers.BatchNumber = serialnumber[0];
                        //        odn.Lines.BatchNumbers.Quantity = Convert.ToDouble(serialnumber[1]);
                        //        odn.Lines.BatchNumbers.Add();
                        //    }
                        //}
                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        odn.Lines.TaxCode = (string.IsNullOrWhiteSpace(_item.TaxCode)) ? "IGV" : _item.TaxCode;
                        if (_item.BaseEntry != 0)
                        {
                            odn.Lines.BaseType = _item.BaseType;
                            odn.Lines.BaseEntry = _item.BaseEntry;
                            odn.Lines.BaseLine = _item.BaseLine;
                        }
                        odn.Lines.Add();
                    });

                    //odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    //? GASTO ADICIONAL (MOVILIDAD)
                    if (obj.TotalExpns > 0)
                    {
                        odn.Expenses.ExpenseCode = string.Compare(obj.Socied, "BT", false) == 0 ? 1 : 9;
                        odn.Expenses.TaxCode = "IGV";
                        odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                        odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                        if (obj.BaseDocEntry != 0)
                        {
                            odn.Expenses.BaseDocType = obj.BaseDocType;
                            odn.Expenses.BaseDocLine = 0;
                            odn.Expenses.BaseDocEntry = obj.BaseDocEntry;
                        }
                        odn.Expenses.Add();
                    }

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD";
                        ors.Command.Parameters.Item("@DscTable").Value = "ODPI o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SavePurchaseInvoice(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oPurchaseInvoices);

                    //? CABECERA
                    if (obj.Reserve == "N")
                        odn.ReserveInvoice = BoYesNoEnum.tNO;
                    else
                        odn.ReserveInvoice = BoYesNoEnum.tYES;
                    odn.DocType = BoDocumentTypes.dDocument_Items;
                    odn.DocDate = obj.DocDate;
                    odn.TaxDate = obj.TaxDate;
                    odn.DocDueDate = obj.DocDate;
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.FederalTaxID = obj.LicTradNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.Project = obj.Project;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.HandWritten = BoYesNoEnum.tNO;
                    odn.DocCurrency = obj.Currency;
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;
                    odn.UserFields.Fields.Item("U_BPP_MDTD").Value = obj.U_BPP_MDTD;
                    odn.UserFields.Fields.Item("U_BPP_MDSD").Value = obj.U_BPP_MDSD;
                    odn.UserFields.Fields.Item("U_BPP_MDCD").Value = obj.U_BPP_MDCD;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    //odn.UserFields.Fields.Item("U_BF_PED_ORIG").Value = string.IsNullOrWhiteSpace(obj.U_BF_PED_ORIG) ? 0 : Convert.ToInt32(obj.U_BF_PED_ORIG);
                    //odn.UserFields.Fields.Item("U_BF_PickRmrk").Value = string.IsNullOrWhiteSpace(obj.U_BF_PickRmrk) ? string.Empty : obj.U_BF_PickRmrk;

                    //? DETALLE
                    obj.Lines.Where(i => i.TreeType != "I").ToList().ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                        odn.Lines.Quantity = Convert.ToDouble(_item.Quantity);
                        if (_item.DiscPrcnt > 0)
                            odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                        //odn.Lines.WarehouseCode = Val_Almacen(obj.Socied, obj.U_BPP_MDTD, obj.U_BPP_MDSD); // _item.WhsCode;
                        odn.Lines.WarehouseCode = _item.WhsCode;
                        if (_item.IssueMthd.Substring(0,1) == "M" && !string.IsNullOrWhiteSpace(_item.Serie))
                        {
                            var series = _item.Serie.Split(';');
                            for (var i = 0; i <= Convert.ToDouble(_item.Quantity) - 1; i++)
                            {
                                odn.Lines.SerialNumbers.ManufacturerSerialNumber = series[i];
                                odn.Lines.SerialNumbers.InternalSerialNumber = series[i];
                                odn.Lines.SerialNumbers.Add();
                            }
                            //
                        }
                        else if (_item.IssueMthd.Substring(0, 1) == "L" && !string.IsNullOrWhiteSpace(_item.Serie))
                        {
                            var series = _item.Serie.Split(';');
                            for (var i = 0; i < series.Count(); i++)
                            {

                                var serialnumber = series[i].Split('-');
                                odn.Lines.BatchNumbers.BatchNumber = serialnumber[0];
                                odn.Lines.BatchNumbers.Quantity = Convert.ToDouble(serialnumber[1]);
                                if (serialnumber[2] != "/")
                                    odn.Lines.BatchNumbers.ExpiryDate = Convert.ToDateTime(serialnumber[2]);
                                else;
                                odn.Lines.BatchNumbers.Add();
                            }
                        }
                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        odn.Lines.TaxCode = (string.IsNullOrWhiteSpace(_item.TaxCode)) ? "IGV" : _item.TaxCode;
                        //odn.Lines.UserFields.Fields.Item("U_BF_CodKit").Value = string.IsNullOrWhiteSpace(_item.U_BF_CodKit) ? string.Empty : _item.U_BF_CodKit;
                        //odn.Lines.UserFields.Fields.Item("U_BF_LOTE").Value = string.IsNullOrWhiteSpace(_item.U_BF_LOTE) ? string.Empty : _item.U_BF_LOTE;
                        if (_item.BaseEntry != 0)
                        {
                            odn.Lines.BaseType = _item.BaseType;
                            odn.Lines.BaseEntry = _item.BaseEntry;
                            odn.Lines.BaseLine = _item.BaseLine;
                        }

                        if (obj.Reserve == "N")
                        {
                            //? LOTES
                            if (!string.IsNullOrWhiteSpace(_item.BatchNums))
                            {
                                var arbt = _item.BatchNums.Split('!');
                                arbt.Where(i => !string.IsNullOrWhiteSpace(i))
                                    .ToList()
                                    .ForEach(i =>
                                    {
                                        var vlbn = i.Split('¡');
                                        var qins = Convert.ToDouble(vlbn[1]);
                                        if (_item.NumInSale > 1)
                                            qins = Convert.ToDouble(vlbn[1]) * Convert.ToDouble(_item.NumInSale);
                                        odn.Lines.BatchNumbers.BatchNumber = vlbn[0];
                                        odn.Lines.BatchNumbers.Quantity = qins;
                                        odn.Lines.BatchNumbers.Add();
                                    });
                            }
                        }
                        odn.Lines.Add();
                    });

                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    //? GASTO ADICIONAL (MOVILIDAD)
                    if (obj.TotalExpns > 0)
                    {
                        odn.Expenses.ExpenseCode = string.Compare(obj.Socied, "BT", false) == 0 ? 1 : 9;
                        odn.Expenses.TaxCode = "IGV";
                        odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                        odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                        if (obj.BaseDocEntry != 0)
                        {
                            odn.Expenses.BaseDocType = obj.BaseDocType;
                            odn.Expenses.BaseDocLine = 0;
                            odn.Expenses.BaseDocEntry = obj.BaseDocEntry;
                        }
                        odn.Expenses.Add();
                    }

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD_PURCHASE";
                        ors.Command.Parameters.Item("@DscTable").Value = "OPCH o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        /// <summary>
        /// GUARDA EL CLIENTE
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objs"></param>
        public void SaveBusinessPartner(BEBusinessPartner obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int x = 0;
           
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (BusinessPartners)ocp.GetBusinessObject(BoObjectTypes.oBusinessPartners);

                    odn.CardCode = obj.CardCode;
                    if (obj.Proveedor)
                    {
                        odn.CardType = BoCardTypes.cSupplier;
                    }
                    else
                        odn.CardType = BoCardTypes.cCustomer;
                    odn.CardName = obj.CardName;
                    odn.FederalTaxID = obj.LicTradNum;
                    odn.Phone1 = obj.Phone1;
                    odn.Cellular = obj.Cellular;
                    odn.EmailAddress = obj.E_Mail;
                    odn.PriceListNum = Convert.ToInt32(obj.ListNum);
                    if (obj.Proveedor)
                    {
                        odn.GroupCode = 101;
                    }
                    else
                        odn.GroupCode = 100;
                    odn.Currency = obj.Currency;
                    odn.PayTermsGrpCode = Convert.ToInt32(obj.GroupNum);
                    odn.UserFields.Fields.Item("U_BPP_BPTP").Value = obj.U_BPP_BPTP;
                    odn.UserFields.Fields.Item("U_BPP_BPTD").Value = obj.U_BPP_BPTD;
                    odn.UserFields.Fields.Item("U_DXP_PN_FecNac").Value = obj.U_PN_FecNac;

                    obj.Lines2.Where(j => j.Borrar != "Y").ToList().ForEach(_item =>
                    {
                        odn.Addresses.AddressName = _item.Address;
                        odn.Addresses.Street = _item.Street;
                        odn.Addresses.Country = _item.Country;
                        odn.Addresses.State = _item.State;
                        if (!obj.Proveedor)
                        {
                            odn.Addresses.Block = (!string.IsNullOrWhiteSpace(_item.GlblLocNum)) ? _item.GlblLocNum : "";
                            odn.Addresses.County = (!string.IsNullOrWhiteSpace(_item.Building)) ? _item.Building : "";
                            odn.Addresses.StreetNo = (!string.IsNullOrWhiteSpace(_item.StreetNo)) ? _item.StreetNo : "";
                        }

                        odn.Addresses.AddressType = (_item.AdresType == "B") ? BoAddressType.bo_BillTo : BoAddressType.bo_ShipTo;
                        odn.Addresses.UserFields.Fields.Item("U_DXP_BIZ_COPR").Value = (!string.IsNullOrWhiteSpace(_item.U_DXP_BIZ_COPR)) ? _item.U_DXP_BIZ_COPR : "";
                        odn.Addresses.UserFields.Fields.Item("U_DXP_BIZ_PROV").Value = (!string.IsNullOrWhiteSpace(_item.U_DXP_BIZ_PROV)) ? _item.U_DXP_BIZ_PROV : "";
                        odn.Addresses.UserFields.Fields.Item("U_DXP_BIZ_CODI").Value = (!string.IsNullOrWhiteSpace(_item.U_DXP_BIZ_CODI)) ? _item.U_DXP_BIZ_CODI : "";
                        odn.Addresses.UserFields.Fields.Item("U_DXP_BIZ_DIST").Value = (!string.IsNullOrWhiteSpace(_item.U_DXP_BIZ_DIST)) ? _item.U_DXP_BIZ_DIST : "";
                        odn.Addresses.UserFields.Fields.Item("U_DXP_BIZ_ZONA").Value = (!string.IsNullOrWhiteSpace(_item.U_DXP_BIZ_ZONA)) ? _item.U_DXP_BIZ_ZONA : "";

                        odn.Addresses.Add();
                    });

                    obj.Lines.ForEach(_item =>
                    {
                        odn.ContactEmployees.Name = _item.FirstName+" "+ _item.LastName;
                        odn.ContactEmployees.FirstName = _item.FirstName;
                        odn.ContactEmployees.LastName = _item.LastName;
                        odn.ContactEmployees.MobilePhone = _item.Cellolar;
                        odn.ContactEmployees.E_Mail = _item.E_MailL;

                        odn.ContactEmployees.Add();
                    });

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0 || x != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }

        }
        public void UpdateBusinessPartner(BEBusinessPartner obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int x = 0;

                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (BusinessPartners)ocp.GetBusinessObject(BoObjectTypes.oBusinessPartners);

                    odn.GetByKey(obj.CardCode);
                    if (obj.Proveedor)
                    {
                        odn.CardType = BoCardTypes.cSupplier;
                    }
                    else
                        odn.CardType = BoCardTypes.cCustomer;
                    odn.CardName = obj.CardName;
                    odn.FederalTaxID = obj.LicTradNum;
                    odn.Phone1 = obj.Phone1;
                    odn.Cellular = obj.Cellular;
                    odn.EmailAddress = obj.E_Mail;
                    odn.Currency = obj.Currency;
                    odn.PriceListNum = Convert.ToInt32(obj.ListNum);
                    if (obj.Proveedor)
                    {
                        odn.GroupCode = 101;
                    }
                    else
                        odn.GroupCode = 100;
                    odn.PayTermsGrpCode = Convert.ToInt32(obj.GroupNum);
                    if(obj.Active == "N")
                    {
                        odn.Frozen = BoYesNoEnum.tYES;
                        odn.FrozenFrom = DateTime.Now;
                    }
                    if (obj.Active == "Y")
                    {
                        odn.Frozen = BoYesNoEnum.tNO;
                        odn.Valid = BoYesNoEnum.tYES;
                    }
                    //odn.UserFields.Fields.Item("U_BPP_BPTP").Value = obj.U_BPP_BPTP;
                    //odn.UserFields.Fields.Item("U_BPP_BPTD").Value = obj.U_BPP_BPTD;
                    //odn.UserFields.Fields.Item("U_DXP_PN_FecNac").Value = obj.U_PN_FecNac;
                    var i = 0;
                    obj.Lines2.ForEach(_item =>
                    {
                        odn.Addresses.SetCurrentLine(_item.Linea);

                        if (_item.Borrar != "Y")
                        {

                            odn.Addresses.AddressName = _item.Address;
                            odn.Addresses.Street = _item.Street;
                            odn.Addresses.Country = _item.Country;
                            odn.Addresses.State = _item.State;
                            if (!obj.Proveedor)
                            {
                                odn.Addresses.Block = (!string.IsNullOrWhiteSpace(_item.GlblLocNum)) ? _item.GlblLocNum : "";
                                odn.Addresses.County = (!string.IsNullOrWhiteSpace(_item.Building)) ? _item.Building : "";
                                odn.Addresses.StreetNo = (!string.IsNullOrWhiteSpace(_item.StreetNo)) ? _item.StreetNo : "";
                            }
                            odn.Addresses.AddressType = (_item.AdresType == "B") ? BoAddressType.bo_BillTo : BoAddressType.bo_ShipTo;
                            odn.Addresses.UserFields.Fields.Item("U_DXP_BIZ_COPR").Value = (!string.IsNullOrWhiteSpace(_item.U_DXP_BIZ_COPR)) ? _item.U_DXP_BIZ_COPR : "";
                            odn.Addresses.UserFields.Fields.Item("U_DXP_BIZ_PROV").Value = (!string.IsNullOrWhiteSpace(_item.U_DXP_BIZ_PROV)) ? _item.U_DXP_BIZ_PROV : "";
                            odn.Addresses.UserFields.Fields.Item("U_DXP_BIZ_CODI").Value = (!string.IsNullOrWhiteSpace(_item.U_DXP_BIZ_CODI)) ? _item.U_DXP_BIZ_CODI : "";
                            odn.Addresses.UserFields.Fields.Item("U_DXP_BIZ_DIST").Value = (!string.IsNullOrWhiteSpace(_item.U_DXP_BIZ_DIST)) ? _item.U_DXP_BIZ_DIST : "";
                            odn.Addresses.UserFields.Fields.Item("U_DXP_BIZ_ZONA").Value = (!string.IsNullOrWhiteSpace(_item.U_DXP_BIZ_ZONA)) ? _item.U_DXP_BIZ_ZONA : "";

                            odn.Addresses.UserFields.Fields.Item("U_DXP_ESTADO").Value = _item.Active;
                            odn.Addresses.Add();
                        }
                        //else
                        //{
                        //    odn.Addresses.Delete();
                        //}
                        //i++;
                    });

                    var j = 0;
                    obj.Lines.ForEach(_item =>
                    {
                        //if (_item.UPDT == "SI")
                        //{
                            odn.ContactEmployees.SetCurrentLine(_item.Linea);

                            odn.ContactEmployees.Name = _item.FirstName + " " + _item.LastName;
                            odn.ContactEmployees.FirstName = _item.FirstName;
                            odn.ContactEmployees.LastName = _item.LastName;
                            odn.ContactEmployees.MobilePhone = _item.Cellolar;
                            odn.ContactEmployees.E_Mail = _item.E_MailL;
                            if (_item.Active == "N")
                            {
                                odn.ContactEmployees.Active = BoYesNoEnum.tNO;
                            }
                            else if (_item.Active == "Y")
                            {
                                odn.ContactEmployees.Active = BoYesNoEnum.tYES;
                            }
                        //}
                        //if (_item.UPDT == "ADD")
                        //{
                            odn.ContactEmployees.Add();
                        //}
                        j++;
                    });

                    ocp.StartTransaction();
                    RetVal = odn.Update();
                    if (RetVal != 0 || x != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }

        }
        /// <summary>
        /// Guardar Cliente Naiah
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objs"></param>
        public void SaveBusinessPartnerNaiah(BEBusinessPartner obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (BusinessPartners)ocp.GetBusinessObject(BoObjectTypes.oBusinessPartners);
                   
                    odn.CardCode = obj.CardCode;
                    odn.CardType = BoCardTypes.cCustomer;
                    odn.CardName = obj.CardName;
                    odn.FederalTaxID = obj.LicTradNum;
                    odn.Phone1 = obj.Phone1;
                    odn.Cellular = obj.Cellular;
                    odn.EmailAddress = obj.E_Mail;
                    odn.PriceListNum = (obj.Socied == "BT") ? 3 : 13;
                    odn.GroupCode = 152;//cambiar a 152 cuando esta en produccion
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.Territory = (obj.Socied == "BT") ? 4 : 6;
                    odn.Industry = 3;
                    odn.UserFields.Fields.Item("U_BPP_BPTP").Value = obj.U_BPP_BPTP;
                    odn.UserFields.Fields.Item("U_BPP_BPTD").Value = obj.U_BPP_BPTD;
                    odn.UserFields.Fields.Item("U_BPP_BPAP").Value = obj.U_BPP_BPAP;
                    odn.UserFields.Fields.Item("U_BPP_BPAM").Value = obj.U_BPP_BPAM;
                    if (obj.U_BPP_BPTD == "1")
                    {
                        odn.UserFields.Fields.Item("U_BPP_BPNO").Value = obj.U_BPP_BPNO;
                        odn.UserFields.Fields.Item("U_PN_Vend").Value = obj.U_PN_Vend;
                    }

                    odn.UserFields.Fields.Item("U_PN_Docum").Value = obj.U_PN_Docum;
                    odn.UserFields.Fields.Item("U_PN_DepDirVive").Value = obj.U_PN_DepDirVive;
                    odn.UserFields.Fields.Item("U_PN_ProvDirVive").Value = obj.U_PN_ProvDirVive;
                    odn.UserFields.Fields.Item("U_PN_DistDirVive").Value = obj.U_PN_DistDirVive;
                    odn.UserFields.Fields.Item("U_PN_DirViveRefe").Value = obj.U_PN_DirViveRefe;
                    odn.UserFields.Fields.Item("U_PN_DirVive").Value = obj.U_PN_DirVive;
                    odn.UserFields.Fields.Item("U_PN_CodGrup").Value = obj.U_PN_CodGrup;
                    odn.FreeText = obj.Free_Text;
                    odn.PayTermsGrpCode = (obj.Socied == "BT") ? 10:37;
                    //odn.GetByKey("C70070343");
                    //SAPbobsCOM.BPAddresses addr = odn.Addresses;
                    //addr.SetCurrentLine(0);
                    //addr.AddressName = "JOSE1";
                    //addr.AddressType = SAPbobsCOM.BoAddressType.bo_BillTo;
                    //addr.Street = "STREETJOSE1";
                    //addr.Country = "NZ";
                    ocp.StartTransaction();
                    RetVal = odn.Add();
                      //addr.Add();
                    /////////
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SavePayment(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Payments)ocp.GetBusinessObject(BoObjectTypes.oIncomingPayments);
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.DocCurrency = obj.DocCur;
                    odn.DocDate = obj.DocDate;
                    odn.CashAccount = obj.CashAccount;
                    odn.Invoices.DocEntry = obj.DocEntry;

                    //odn.Invoices.A

                    if (obj.BaseDocType == 13)
                        odn.Invoices.InvoiceType = BoRcptInvTypes.it_Invoice;
                    else if (obj.BaseDocType == 203)
                        odn.Invoices.InvoiceType = BoRcptInvTypes.it_DownPayment;
                    //else if (obj.BaseDocType == 203)
                    //    odn.Invoices.InvoiceType = BoRcptInvTypes.it_PurchaseInvoice;
                    if (obj.MedPayment == "EF")
                    {
                        odn.CashSum = Convert.ToDouble(obj.CashSum);
                        odn.ProjectCode = obj.Project;
                        odn.JournalRemarks = "Pago Recibido - " + obj.CardCode;
                        odn.Remarks = string.Empty;
                    }
                    else if (obj.MedPayment == "TC")
                    {
                        odn.CreditCards.OwnerIdNum = obj.LicTradNum;
                        odn.CreditCards.CreditCard = obj.CreditCard;
                        odn.CreditCards.CreditCardNumber = obj.CreditCardNumber;
                        odn.CreditCards.CardValidUntil = Convert.ToDateTime("2020-12-31");
                        odn.CreditCards.CreditSum = Convert.ToDouble(obj.CashSum);

                    }
                    else
                    {
                        odn.TransferAccount = obj.CashAccount;
                        odn.TransferSum = Convert.ToDouble(obj.CashSum);
                        odn.TransferDate = obj.DocDate;
                        odn.TransferReference = obj.LicTradNum;
                    }
                    odn.Invoices.SumApplied = Convert.ToDouble(obj.CashSum);
                    odn.Invoices.Add();

                    if (obj.MedPayment == "TC")
                    {
                        odn.CreditCards.VoucherNum = obj.VoucherNum;
                        odn.CreditCards.PaymentMethodCode = obj.CreditCard;
                        //DEFINIR CORRECTAMENTE EL METODO DE PAGO
                        odn.ProjectCode = obj.Project;
                        odn.Reference2 = obj.Project;
                        odn.JournalRemarks = "Pago Recibido - " + obj.CardCode;
                        odn.Remarks = string.Empty;
                    }

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.Msg = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }

        /// <summary>
        /// GUARDA EL PAGO DEL DOCUMENTO DE VENTA
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objs"></param>
        /// 
        public void CancelPaymentPagoRecibido(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Payments)ocp.GetBusinessObject(BoObjectTypes.oIncomingPayments);
                        odn.GetByKey(obj.DocEntry);

                        ocp.StartTransaction();
                        RetVal = odn.Cancel();
                        if (RetVal != 0)
                        {
                            ocp.GetLastError(out ErrCode, out ErrMsg);
                            obj.Msg = ErrMsg;
                            if (ocp.InTransaction)
                                ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                            throw new ArgumentException(ErrMsg);
                        }
                        else
                        {
                            if (ocp.InTransaction)
                                ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                            obj.Msg = string.Empty;
                        }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void CancelPaymentPagoEfectuado(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Payments)ocp.GetBusinessObject(BoObjectTypes.oVendorPayments);
                    odn.GetByKey(obj.DocEntry);

                    ocp.StartTransaction();
                    RetVal = odn.Cancel();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.Msg = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SavePaymentPagoRecibido(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {                    
                    var odn = (Payments)ocp.GetBusinessObject(BoObjectTypes.oIncomingPayments);
                    if (obj.Comments == "Y")
                    {
                        
                        odn.CardCode = obj.CardCode;
                        odn.CardName = obj.CardName;
                        odn.DocDate = obj.DocDate;
                        odn.TaxDate = obj.TaxDate;
                        //odn.DocCurrency = obj.DocCur;
                        odn.DueDate = obj.DocDueDate;
                        if (obj.CntctCode != 0)
                            odn.ContactPersonCode = obj.CntctCode;
                        if (obj.Project != "00")
                            odn.ProjectCode = obj.Project;
                        odn.UserFields.Fields.Item("U_BPP_MPPG").Value = string.IsNullOrWhiteSpace(obj.Address2) ? "" : obj.Address2;
                        odn.PayToCode = obj.Address;
                        if (obj.Active == "N")
                        {
                            odn.DocTypte = BoRcptTypes.rCustomer;
                            obj.Lineas.Where(i=>i.Active != "N").ToList().ForEach(item =>
                            {
                                var entrys = item.DDocEntry.Split('-');
                                odn.Invoices.DocEntry = Convert.ToInt32(entrys[1]);
                                if (item.Reserve == "F" || item.Reserve == "R")
                                    odn.Invoices.InvoiceType = BoRcptInvTypes.it_Invoice;
                                else if (item.Reserve == "203")
                                    odn.Invoices.InvoiceType = BoRcptInvTypes.it_DownPayment;
                                if (obj.DocCur == "SOL")
                                    odn.Invoices.SumApplied = Convert.ToDouble(obj.PagoTotal);
                                else
                                    odn.Invoices.AppliedFC = Convert.ToDouble(obj.PagoTotal);
                                odn.Invoices.Add();
                            });
                        }
                        else;

                        if (obj.MedPayment == "EF")
                        {
                            odn.CashAccount = obj.CashAccount;
                            odn.CashSum = Convert.ToDouble(obj.CashSum);
                            //odn.ProjectCode = obj.Project;
                            odn.DocCurrency = obj.DocCur;
                            odn.JournalRemarks = "Pago Recibido - " + obj.CardCode;
                            odn.Remarks = string.Empty;

                        }
                        if (obj.MedPayment2 == "TC")
                        {
                            odn.CreditCards.CreditAcct = obj.CashAccount2;
                            odn.CreditCards.OwnerIdNum = obj.LicTradNum;
                            odn.CreditCards.CreditCard = obj.CreditCard;
                            odn.CreditCards.CreditCardNumber = obj.CreditCardNumber;
                            odn.CreditCards.CardValidUntil = Convert.ToDateTime("2020-12-31");
                            odn.DocCurrency = obj.DocCur2;
                            odn.CreditCards.CreditSum = Convert.ToDouble(obj.CashSum2);
                        }
                        if (obj.MedPayment3 == "TR")
                        {
                            odn.TransferAccount = obj.CashAccount3;
                            odn.TransferSum = Convert.ToDouble(obj.CashSum3);
                            odn.TransferDate = obj.DocDate3;
                            odn.DocCurrency = obj.DocCur3;
                            odn.TransferReference = obj.NumAtCard3;
                        }
                    }
                    else {
                        odn.DocType = BoRcptTypes.rAccount;
                        if (obj.Project != "00")
                            odn.ProjectCode = obj.Project;
                        odn.UserFields.Fields.Item("U_BPP_MPPG").Value = string.IsNullOrWhiteSpace(obj.Address2) ? "" : obj.Address2;
                        obj.CuentasPago.ForEach(it => {
                            odn.AccountPayments.AccountCode = it.AcctCode;
                            odn.DocCurrency = obj.DocCur;
                            odn.AccountPayments.Decription = it.AcctName;
                            odn.AccountPayments.SumPaid = Convert.ToDouble(it.CurrTotal);
                            odn.AccountPayments.Add();
                        });
                        if (obj.MedPayment == "EF")
                        {
                            odn.CashAccount = obj.CashAccount;
                            odn.CashSum = Convert.ToDouble(obj.CashSum);
                            //odn.ProjectCode = obj.Project;
                            odn.DocCurrency = obj.DocCur;
                            odn.JournalRemarks = "Pago Recibido - " + obj.CardCode;
                            odn.Remarks = string.Empty;

                        }
                        if (obj.MedPayment2 == "TC")
                        {
                            odn.CreditCards.CreditAcct = obj.CashAccount2;
                            odn.CreditCards.OwnerIdNum = obj.LicTradNum;
                            odn.CreditCards.CreditCard = obj.CreditCard;
                            odn.DocCurrency = obj.DocCur2;
                            odn.CreditCards.CreditCardNumber = obj.CreditCardNumber;
                            odn.CreditCards.CardValidUntil = Convert.ToDateTime("2020-12-31");
                            odn.CreditCards.CreditSum = Convert.ToDouble(obj.CashSum2);
                        }
                        if (obj.MedPayment3 == "TR")
                        {
                            odn.TransferAccount = obj.CashAccount3;
                            odn.TransferSum = Convert.ToDouble(obj.CashSum3);
                            odn.TransferDate = obj.DocDate3;
                            odn.DocCurrency = obj.DocCur3;
                            odn.TransferReference = obj.NumAtCard3;
                        }
                    }
                    
                    //if (obj.MedPayment == "TC")
                    //{
                    //    odn.CreditCards.VoucherNum = obj.VoucherNum;
                    //    odn.CreditCards.PaymentMethodCode = obj.CreditCard;
                    //    DEFINIR CORRECTAMENTE EL METODO DE PAGO
                    //    odn.ProjectCode = obj.Project;
                    //    odn.Reference2 = obj.Project;
                    //    odn.JournalRemarks = "Pago Recibido - " + obj.CardCode;
                    //    odn.Remarks = string.Empty;
                    //}
                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD";
                        ors.Command.Parameters.Item("@DscTable").Value = "ORCT o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                        obj.Msg = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SavePaymentPagoEfectuado(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Payments)ocp.GetBusinessObject(BoObjectTypes.oVendorPayments);
                    if (obj.Comments == "Y")
                    {

                        odn.CardCode = obj.CardCode;
                        odn.CardName = obj.CardName;
                        odn.DocDate = obj.DocDate;
                        odn.TaxDate = obj.TaxDate;
                        odn.DueDate = obj.DocDueDate;
                        if (obj.CntctCode != 0)
                            odn.ContactPersonCode = obj.CntctCode;
                        if (obj.Project != "00")
                            odn.ProjectCode = obj.Project;
                        odn.UserFields.Fields.Item("U_BPP_MPPG").Value = string.IsNullOrWhiteSpace(obj.Address2) ? "" : obj.Address2;
                        odn.PayToCode = obj.Address;
                        if (obj.Active == "N")
                        {
                            odn.DocTypte = BoRcptTypes.rSupplier;
                            obj.Lineas.Where(i => i.Active != "N").ToList().ForEach(item =>
                            {
                                var entrys = item.DDocEntry.Split('-');
                                odn.Invoices.DocEntry = Convert.ToInt32(entrys[1]);
                                if (item.Reserve == "F" || item.Reserve == "R")
                                    odn.Invoices.InvoiceType = BoRcptInvTypes.it_PurchaseInvoice;
                                else if (item.Reserve == "203")
                                    odn.Invoices.InvoiceType = BoRcptInvTypes.it_PurchaseDownPayment;
                                if(item.DocCur == "SOL")
                                odn.Invoices.SumApplied = Convert.ToDouble(item.PagoTotal);
                                else
                                    odn.Invoices.AppliedFC = Convert.ToDouble(item.PagoTotal);
                                odn.Invoices.Add();
                            });
                        }
                        else;

                        if (obj.MedPayment == "EF")
                        {
                            odn.CashAccount = obj.CashAccount;
                            odn.CashSum = Convert.ToDouble(obj.CashSum);
                            //odn.ProjectCode = obj.Project;
                            odn.DocCurrency = obj.DocCur;
                            odn.JournalRemarks = "Pago Recibido - " + obj.CardCode;
                            odn.Remarks = string.Empty;

                        }
                        if (obj.MedPayment2 == "TC")
                        {
                            odn.CreditCards.CreditAcct = obj.CashAccount2;
                            odn.CreditCards.OwnerIdNum = obj.LicTradNum;
                            odn.DocCurrency = obj.DocCur2;
                            odn.CreditCards.CreditCard = obj.CreditCard;
                            odn.CreditCards.CreditCardNumber = obj.CreditCardNumber;
                            odn.CreditCards.CardValidUntil = Convert.ToDateTime("2020-12-31");
                            odn.CreditCards.CreditSum = Convert.ToDouble(obj.CashSum2);
                        }
                        if (obj.MedPayment3 == "TR")
                        {
                            odn.TransferAccount = obj.CashAccount3;
                            odn.TransferSum = Convert.ToDouble(obj.CashSum3);
                            odn.TransferDate = obj.DocDate3;
                            odn.DocCurrency = obj.DocCur3;
                            odn.TransferReference = obj.NumAtCard3;
                        }
                    }
                    else
                    {
                        odn.DocType = BoRcptTypes.rAccount;
                        if (obj.Project != "00")
                            odn.ProjectCode = obj.Project;
                        odn.UserFields.Fields.Item("U_BPP_MPPG").Value = string.IsNullOrWhiteSpace(obj.Address2) ? "" : obj.Address2;
                        obj.CuentasPago.ForEach(it => {
                            odn.AccountPayments.AccountCode = it.AcctCode;
                            odn.DocCurrency = obj.DocCur;
                            odn.AccountPayments.Decription = it.AcctName;
                            odn.AccountPayments.SumPaid = Convert.ToDouble(it.CurrTotal);
                            odn.AccountPayments.Add();
                        });
                        if (obj.MedPayment == "EF")
                        {
                            odn.CashAccount = obj.CashAccount;
                            odn.CashSum = Convert.ToDouble(obj.CashSum);
                            odn.DocCurrency = obj.DocCur;
                            //odn.ProjectCode = obj.Project;
                            odn.JournalRemarks = "Pago Recibido - " + obj.CardCode;
                            odn.Remarks = string.Empty;

                        }
                        if (obj.MedPayment2 == "TC")
                        {
                            odn.CreditCards.CreditAcct = obj.CashAccount2;
                            odn.CreditCards.OwnerIdNum = obj.LicTradNum;
                            odn.CreditCards.CreditCard = obj.CreditCard;
                            odn.DocCurrency = obj.DocCur2;
                            odn.CreditCards.CreditCardNumber = obj.CreditCardNumber;
                            odn.CreditCards.CardValidUntil = Convert.ToDateTime("2020-12-31");
                            odn.CreditCards.CreditSum = Convert.ToDouble(obj.CashSum2);
                        }
                        if (obj.MedPayment3 == "TR")
                        {
                            odn.TransferAccount = obj.CashAccount3;
                            odn.TransferSum = Convert.ToDouble(obj.CashSum3);
                            odn.TransferDate = obj.DocDate3;
                            odn.DocCurrency = obj.DocCur3;
                            odn.TransferReference = obj.NumAtCard3;
                        }
                    }

                    //if (obj.MedPayment == "TC")
                    //{
                    //    odn.CreditCards.VoucherNum = obj.VoucherNum;
                    //    odn.CreditCards.PaymentMethodCode = obj.CreditCard;
                    //    DEFINIR CORRECTAMENTE EL METODO DE PAGO
                    //    odn.ProjectCode = obj.Project;
                    //    odn.Reference2 = obj.Project;
                    //    odn.JournalRemarks = "Pago Recibido - " + obj.CardCode;
                    //    odn.Remarks = string.Empty;
                    //}
                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD";
                        ors.Command.Parameters.Item("@DscTable").Value = "OVPM o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                        obj.Msg = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SaveVendorPayment(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Payments)ocp.GetBusinessObject(BoObjectTypes.oVendorPayments);
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.DocCurrency = obj.DocCur;
                    odn.BankChargeAmount = Convert.ToDouble(obj.DiscSum);
                    odn.DocDate = obj.DocDate;
                    odn.CashAccount = obj.CashAccount;
                    odn.Invoices.DocEntry = obj.DocEntry;
                    if (obj.BaseDocType == 13)
                        odn.Invoices.InvoiceType = BoRcptInvTypes.it_PurchaseInvoice;
                    else if (obj.BaseDocType == 203)
                        odn.Invoices.InvoiceType = BoRcptInvTypes.it_PurchaseDownPayment;
                    if (obj.DocCur == "SOL")
                        odn.Invoices.SumApplied = Convert.ToDouble(obj.CashSum);
                    else
                        odn.Invoices.AppliedFC = Convert.ToDouble(obj.CashSum);
                    //else if (obj.BaseDocType == 203)
                    //    odn.Invoices.InvoiceType = BoRcptInvTypes.it_PurchaseInvoice;
                    if (obj.MedPayment == "EF")
                    {
                        odn.CashSum = Convert.ToDouble(obj.CashSum);
                        odn.ProjectCode = obj.Project;
                        odn.JournalRemarks = "Pago Recibido - " + obj.CardCode;
                        odn.Remarks = string.Empty;
                        
                    }
                    else if (obj.MedPayment == "TC")
                    {
                        odn.CreditCards.CreditCard = 1;
                        odn.CreditCards.CreditCardNumber = "12345";
                        odn.CreditCards.VoucherNum = "0";
                        odn.CreditCards.CreditSum = 60;
                        odn.CreditCards.Add();
                        //odn.CreditCards.OwnerIdNum = obj.LicTradNum;
                        //odn.CreditCards.CreditCard = obj.CreditCard;
                        //odn.CreditCards.CreditCardNumber = obj.CreditCardNumber;
                        //odn.CreditCards.CardValidUntil = Convert.ToDateTime("2020-12-31");
                        //odn.CreditCards.CreditSum = Convert.ToDouble(obj.CashSum);

                    }
                    else
                    {
                        odn.TransferAccount = obj.CashAccount;
                        odn.TransferSum = Convert.ToDouble(obj.CashSum);
                        odn.TransferDate = obj.DocDate;
                        odn.TransferReference = obj.LicTradNum;
                    }
                    odn.Invoices.SumApplied = Convert.ToDouble(obj.CashSum);
                    odn.Invoices.Add();

                    if (obj.MedPayment == "TC")
                    {
                        //odn.CreditCards.VoucherNum = obj.VoucherNum;
                        //odn.CreditCards.PaymentMethodCode = obj.CreditCard;
                        //DEFINIR CORRECTAMENTE EL METODO DE PAGO
                        //odn.ProjectCode = obj.Project;
                        //odn.Reference2 = obj.Project;
                        //odn.JournalRemarks = "Pago Efectuado - " + obj.CardCode;
                        //odn.Remarks = string.Empty;
                    }

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.Msg = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        /// <summary>
        /// GUARDA LA NOTA DE CREDITO
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objs"></param>
        public void SaveCreditNote(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {                    
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oCreditNotes);

                    //? CABECERA
                    odn.DocType = BoDocumentTypes.dDocument_Items;
                    odn.DocDate = obj.DocDate;
                    odn.TaxDate = obj.DocDate;
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.FederalTaxID = obj.LicTradNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.ShipToCode = obj.ShipToCode;
                    odn.PayToCode = obj.PayToCode;
                    odn.Project = obj.Project;
                    odn.DocCurrency = obj.Currency;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.HandWritten = BoYesNoEnum.tNO;
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;
                    odn.UserFields.Fields.Item("U_BPP_MDTD").Value = obj.U_BPP_MDTD;
                    odn.UserFields.Fields.Item("U_BPP_MDSD").Value = obj.U_BPP_MDSD;
                    odn.UserFields.Fields.Item("U_BPP_MDCD").Value = obj.U_BPP_MDCD;
                    odn.UserFields.Fields.Item("U_DXP_FE_MOT_GEN").Value = string.IsNullOrWhiteSpace(obj.U_DXP_FE_MOT_GEN) ? "01" : obj.U_DXP_FE_MOT_GEN;

                    odn.UserFields.Fields.Item("U_BPP_MDTO").Value = string.IsNullOrWhiteSpace(obj.U_BPP_MDTO) ? "" : obj.U_BPP_MDTO;
                    odn.UserFields.Fields.Item("U_BPP_MDSO").Value = string.IsNullOrWhiteSpace(obj.U_BPP_MDSO) ? "" : obj.U_BPP_MDSO;
                    odn.UserFields.Fields.Item("U_BPP_MDCO").Value = string.IsNullOrWhiteSpace(obj.U_BPP_MDCO) ? "" : obj.U_BPP_MDCO;

                    //? DETALLE
                    obj.Lines.Where(i => i.TreeType != "I").ToList().ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        //odn.Lines.AccountCode = _item.AcctCode;
                        odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                        odn.Lines.Quantity = Convert.ToDouble(_item.Quantity); 
                        if (_item.DiscPrcnt > 0)
                            odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                        odn.Lines.WarehouseCode = _item.WhsCode;
                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        odn.Lines.TaxCode = (string.IsNullOrWhiteSpace(_item.TaxCode)) ? "IGV" : _item.TaxCode;

                        if (_item.IssueMthd.Substring(0,1) == "M" && !string.IsNullOrWhiteSpace(_item.Serie))
                        {
                            var series = _item.Serie.Split(';');
                            for (var i = 0; i <= Convert.ToDouble(_item.Quantity) - 1; i++)
                            {
                                var serialnumber = series[i].Split('-');
                                odn.Lines.SerialNumbers.SystemSerialNumber = Convert.ToInt32(serialnumber[1]);
                                odn.Lines.SerialNumbers.Quantity = 1;
                                odn.Lines.SerialNumbers.Add();
                            }
                        }
                        else if (_item.IssueMthd.Substring(0, 1) == "L" && !string.IsNullOrWhiteSpace(_item.Serie))
                        {
                            var series = _item.Serie.Split(';');
                            for (var i = 0; i < series.Count(); i++)
                            {
                                var serialnumber = series[i].Split('-');
                                odn.Lines.BatchNumbers.BatchNumber = serialnumber[0];
                                odn.Lines.BatchNumbers.Quantity = Convert.ToDouble(serialnumber[1]);
                                odn.Lines.BatchNumbers.Add();
                            }
                        }

                        //odn.Lines.UserFields.Fields.Item("U_BF_CodKit").Value = string.IsNullOrWhiteSpace(_item.U_BF_CodKit) ? string.Empty : _item.U_BF_CodKit;
                        //odn.Lines.UserFields.Fields.Item("U_BF_LOTE").Value = string.IsNullOrWhiteSpace(_item.U_BF_LOTE) ? string.Empty : _item.U_BF_LOTE;
                        if (_item.BaseEntry != 0)
                        {
                            odn.Lines.BaseType = Convert.ToInt32(_item.BaseType);
                            odn.Lines.BaseEntry = Convert.ToInt32(_item.BaseEntry);
                            odn.Lines.BaseLine = Convert.ToInt32(_item.BaseLine);
                        }
                        
                        //if (obj.Reserve == "N")
                        //{
                        //    //? LOTES
                        //    if (!string.IsNullOrWhiteSpace(_item.BatchNums))
                        //    {
                        //        var arbt = _item.BatchNums.Split('!');
                        //        arbt.Where(i => !string.IsNullOrWhiteSpace(i))
                        //            .ToList()
                        //            .ForEach(i =>
                        //            {
                        //                var vlbn = i.Split('¡');
                        //                odn.Lines.BatchNumbers.BatchNumber = vlbn[0];
                        //                odn.Lines.BatchNumbers.Quantity = Convert.ToDouble(vlbn[1]);
                        //                odn.Lines.BatchNumbers.Add();
                        //            });
                        //    }
                        //}
                        odn.Lines.Add();
                    });

                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    //? GASTO ADICIONAL (MOVILIDAD)
                    if (obj.TotalExpns > 0)
                    {
                        odn.Expenses.ExpenseCode = string.Compare(obj.Socied, "BT", false) == 0 ? 1 : 9;
                        odn.Expenses.TaxCode = "IGV";
                        odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                        odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                        if (obj.BaseDocEntry != 0)
                        {
                            odn.Expenses.BaseDocType = obj.BaseDocType;
                            odn.Expenses.BaseDocLine = 0;
                            odn.Expenses.BaseDocEntry = obj.BaseDocEntry;
                        }
                        odn.Expenses.Add();
                    }

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD";
                        ors.Command.Parameters.Item("@DscTable").Value = "ORIN o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SavePurchaseCreditNote(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oPurchaseCreditNotes);

                    //? CABECERA
                    odn.DocType = BoDocumentTypes.dDocument_Items;
                    odn.DocDate = obj.DocDate;
                    odn.TaxDate = obj.DocDate;
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.FederalTaxID = obj.LicTradNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.Project = obj.Project;
                    odn.DocCurrency = obj.Currency;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.HandWritten = BoYesNoEnum.tNO;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    //odn.DocCurrency = "S/";
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;
                    odn.UserFields.Fields.Item("U_BPP_MDTD").Value = obj.U_BPP_MDTD;
                    odn.UserFields.Fields.Item("U_BPP_MDSD").Value = obj.U_BPP_MDSD;
                    odn.UserFields.Fields.Item("U_BPP_MDCD").Value = obj.U_BPP_MDCD;
                    //odn.UserFields.Fields.Item("U_BF_PED_ORIG").Value = string.IsNullOrWhiteSpace(obj.U_BF_PED_ORIG) ? 0 : Convert.ToInt32(obj.U_BF_PED_ORIG);
                    //odn.UserFields.Fields.Item("U_BF_PickRmrk").Value = string.IsNullOrWhiteSpace(obj.U_BF_PickRmrk) ? string.Empty : obj.U_BF_PickRmrk;

                    //? DETALLE
                    obj.Lines.Where(i => i.TreeType != "I").ToList().ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        //odn.Lines.AccountCode = _item.AcctCode;
                        odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                        odn.Lines.Quantity = Convert.ToDouble(_item.Quantity);
                        if (_item.DiscPrcnt > 0)
                            odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                        odn.Lines.WarehouseCode = _item.WhsCode;
                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        odn.Lines.TaxCode = (string.IsNullOrWhiteSpace(_item.TaxCode)) ? "IGV" : _item.TaxCode;

                        if (_item.IssueMthd.Substring(0,1) == "M" && !string.IsNullOrWhiteSpace(_item.Serie))
                        {
                            var series = _item.Serie.Split(';');
                            for (var i = 0; i <= Convert.ToDouble(_item.Quantity) - 1; i++)
                            {
                                var serialnumber = series[i].Split('-');
                                odn.Lines.SerialNumbers.SystemSerialNumber = Convert.ToInt32(serialnumber[1]);
                                odn.Lines.SerialNumbers.Quantity = 1;
                                odn.Lines.SerialNumbers.Add();
                            }
                        }
                        else if (_item.IssueMthd.Substring(0, 1) == "L" && !string.IsNullOrWhiteSpace(_item.Serie))
                        {
                            var series = _item.Serie.Split(';');
                            for (var i = 0; i < series.Count(); i++)
                            {
                                var serialnumber = series[i].Split('-');
                                odn.Lines.BatchNumbers.BatchNumber = serialnumber[0];
                                odn.Lines.BatchNumbers.Quantity = Convert.ToDouble(serialnumber[1]);
                                odn.Lines.BatchNumbers.Add();
                            }
                        }

                        //odn.Lines.UserFields.Fields.Item("U_BF_CodKit").Value = string.IsNullOrWhiteSpace(_item.U_BF_CodKit) ? string.Empty : _item.U_BF_CodKit;
                        //odn.Lines.UserFields.Fields.Item("U_BF_LOTE").Value = string.IsNullOrWhiteSpace(_item.U_BF_LOTE) ? string.Empty : _item.U_BF_LOTE;
                        if (_item.BaseEntry != 0)
                        {
                            odn.Lines.BaseType = Convert.ToInt32(_item.BaseType);
                            odn.Lines.BaseEntry = Convert.ToInt32(_item.BaseEntry);
                            odn.Lines.BaseLine = Convert.ToInt32(_item.BaseLine);
                        }

                        //if (obj.Reserve == "N")
                        //{
                        //    //? LOTES
                        //    if (!string.IsNullOrWhiteSpace(_item.BatchNums))
                        //    {
                        //        var arbt = _item.BatchNums.Split('!');
                        //        arbt.Where(i => !string.IsNullOrWhiteSpace(i))
                        //            .ToList()
                        //            .ForEach(i =>
                        //            {
                        //                var vlbn = i.Split('¡');
                        //                odn.Lines.BatchNumbers.BatchNumber = vlbn[0];
                        //                odn.Lines.BatchNumbers.Quantity = Convert.ToDouble(vlbn[1]);
                        //                odn.Lines.BatchNumbers.Add();
                        //            });
                        //    }
                        //}
                        odn.Lines.Add();
                    });

                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    //? GASTO ADICIONAL (MOVILIDAD)
                    if (obj.TotalExpns > 0)
                    {
                        odn.Expenses.ExpenseCode = string.Compare(obj.Socied, "BT", false) == 0 ? 1 : 9;
                        odn.Expenses.TaxCode = "IGV";
                        odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                        odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                        if (obj.BaseDocEntry != 0)
                        {
                            odn.Expenses.BaseDocType = obj.BaseDocType;
                            odn.Expenses.BaseDocLine = 0;
                            odn.Expenses.BaseDocEntry = obj.BaseDocEntry;
                        }
                        odn.Expenses.Add();
                    }

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD_PURCHASE";
                        ors.Command.Parameters.Item("@DscTable").Value = "ORPC o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void CreateTarjetaEquipo(BEDocument obj, object objs)
        {
            try
            {
                var SerieTarjeta = "";
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    

                    obj.Lines.Where(item => item.InvntItem == "Y" && item.IssueMthd.Substring(0,1) != "M").ToList().ForEach(i =>
                    {
                        for (int m = 0; m < i.Quantity; m++)
                        {
                            var odn = (CustomerEquipmentCards)ocp.GetBusinessObject(BoObjectTypes.oCustomerEquipmentCards);
                            var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                            ors.Command.Name = "DXP_GET_CODTARJETAEQUIPO";
                            ors.Command.Execute();
                            ors.MoveFirst();
                            SerieTarjeta = Convert.ToString(ors.Fields.Item(0).Value);

                            odn.CustomerCode = obj.CardCode;
                            odn.CustomerName = obj.CardName;
                            odn.ManufacturerSerialNum = SerieTarjeta;
                            odn.InternalSerialNum = SerieTarjeta;
                            odn.ItemCode = i.ItemCode;
                            odn.ItemDescription = i.ItemName;

                            odn.DirectCustomerCode = obj.CardCode;
                            odn.DirectCustomerName = obj.CardName;
                            odn.DeliveryCode = obj.DocEntry;
                            odn.InstallLocation = obj.ShipToCode;

                            ocp.StartTransaction();
                            RetVal = odn.Add();
                            if (RetVal != 0)
                            {
                                ocp.GetLastError(out ErrCode, out ErrMsg);
                                obj.Msg = ErrMsg;
                                if (ocp.InTransaction)
                                    ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                                throw new ArgumentException(ErrMsg);
                            }
                            else
                            {
                                if (ocp.InTransaction)
                                    ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                            }
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }

        }
        public void SaveTransferenciaStock(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (StockTransfer)ocp.GetBusinessObject(BoObjectTypes.oStockTransfer);

                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.DocDate = obj.DocDate;
                    //odn.Address = obj.Address;
                    odn.FromWarehouse = obj.AlmacenO;
                    odn.ToWarehouse = obj.AlmacenD;
                    odn.SalesPersonCode = obj.SlpCode;

                    obj.Lines.ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        odn.Lines.Quantity = _item.Quantity;

                        if (_item.IssueMthd.Substring(0, 1) == "M" && !string.IsNullOrWhiteSpace(_item.Serie))
                        {
                            var series = _item.Serie.Split(';');
                            for (var i = 0; i <= Convert.ToDouble(_item.Quantity) - 1; i++)
                            {
                                var serialnumber = series[i].Split('-');
                                odn.Lines.SerialNumbers.SystemSerialNumber = Convert.ToInt32(serialnumber[1]);
                                odn.Lines.SerialNumbers.Quantity = 1;
                                odn.Lines.SerialNumbers.Add();
                            }
                            //
                        }
                        else if (_item.IssueMthd.Substring(0, 1) == "L" && !string.IsNullOrWhiteSpace(_item.Serie))
                        {
                            var series = _item.Serie.Split(';');
                            for (var i = 0; i < series.Count(); i++)
                            {
                                var serialnumber = series[i].Split('-');
                                odn.Lines.BatchNumbers.BatchNumber = serialnumber[0];
                                odn.Lines.BatchNumbers.Quantity = Convert.ToDouble(serialnumber[1]);
                                odn.Lines.BatchNumbers.Add();
                            }
                        }
                    });


                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD";
                        ors.Command.Parameters.Item("@DscTable").Value = "OWTR o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }

        }
        public void SaveTarjeta(BETarjetaEquipo obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (CustomerEquipmentCards)ocp.GetBusinessObject(BoObjectTypes.oCustomerEquipmentCards);
                    if(obj.Status == "A")
                        odn.StatusOfSerialNumber = BoSerialNumberStatus.sns_Active;
                    else if (obj.Status == "R")
                        odn.StatusOfSerialNumber = BoSerialNumberStatus.sns_Returned;
                    else if (obj.Status == "T")
                        odn.StatusOfSerialNumber = BoSerialNumberStatus.sns_Terminated;
                    else if (obj.Status == "L")
                        odn.StatusOfSerialNumber = BoSerialNumberStatus.sns_Loaned;
                    else
                        odn.StatusOfSerialNumber = BoSerialNumberStatus.sns_InLab;
                    odn.CustomerCode = obj.CardCode;
                    odn.CustomerName = obj.CardName;
                    odn.ManufacturerSerialNum = obj.manufSN;
                    odn.InternalSerialNum = obj.internalSN;
                    odn.ItemCode = obj.ItemCode;
                    odn.ItemDescription = obj.ItemName;

                    odn.DirectCustomerCode = obj.CardCode;
                    odn.DirectCustomerName = obj.CardName;
                    //odn.DeliveryCode = obj.DocEntry;
                    odn.InstallLocation = obj.instLction;
                    odn.Street = obj.street;
                    //odn.StateCode = 
                    odn.County = obj.county;
                    odn.UserFields.Fields.Item("U_GOS_MARCA").Value = obj.U_GOS_MARCA;
                    odn.UserFields.Fields.Item("U_GOS_MODELO").Value = obj.U_GOS_MODELO;

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.insID = Convert.ToInt32(ocp.GetNewObjectKey());
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }

        }
        public void UpdtTarjeta(BETarjetaEquipo obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (CustomerEquipmentCards)ocp.GetBusinessObject(BoObjectTypes.oCustomerEquipmentCards);
                    odn.GetByKey(obj.insID);
                    if (obj.Status == "A")
                        odn.StatusOfSerialNumber = BoSerialNumberStatus.sns_Active;
                    else if (obj.Status == "R")
                        odn.StatusOfSerialNumber = BoSerialNumberStatus.sns_Returned;
                    else if (obj.Status == "T")
                        odn.StatusOfSerialNumber = BoSerialNumberStatus.sns_Terminated;
                    else if (obj.Status == "L")
                        odn.StatusOfSerialNumber = BoSerialNumberStatus.sns_Loaned;
                    else
                        odn.StatusOfSerialNumber = BoSerialNumberStatus.sns_InLab;
                    //odn.CustomerCode = obj.CardCode;
                    //odn.CustomerName = obj.CardName;
                    //odn.ManufacturerSerialNum = obj.manufSN;
                    //odn.InternalSerialNum = obj.internalSN;
                    //odn.ItemCode = obj.ItemCode;
                    //odn.ItemDescription = obj.ItemName;

                    //odn.DirectCustomerCode = obj.CardCode;
                    //odn.DirectCustomerName = obj.CardName;
                    //odn.DeliveryCode = obj.DocEntry;
                    //odn.InstallLocation = obj.instLction;
                    //odn.Street = obj.street;
                    //odn.StateCode = 
                    //odn.County = obj.county;
                    //odn.UserFields.Fields.Item("U_GOS_MARCA").Value = obj.U_GOS_MARCA;
                    //odn.UserFields.Fields.Item("U_GOS_MODELO").Value = obj.U_GOS_MODELO;

                    ocp.StartTransaction();
                    RetVal = odn.Update();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }

        }
        public void CreateService(BEDocument obj, object objs)
        {
            try
            {
                var SerieTarjeta = "";
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {


                    obj.Lines.Where(item => item.ActivoS == "Y").ToList().ForEach(i =>
                    {
                        var odn = (ServiceCalls)ocp.GetBusinessObject(BoObjectTypes.oServiceCalls);

                        //if (i.IssueMthd.Substring(0, 1) != "M")
                        //{
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "DXP_GET_SERIE_DE_TARJETA";
                        ors.Command.Parameters.Item("@CARDCODE").Value = obj.CardCode;
                        ors.Command.Parameters.Item("@ITEMCODE").Value = i.ItemCode;
                        ors.Command.Parameters.Item("@DOCENTRY").Value = obj.DocEntry;
                        ors.Command.Parameters.Item("@DOCNUM").Value = obj.DocNum;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        SerieTarjeta = Convert.ToString(ors.Fields.Item(0).Value);
                        //}
                        //else SerieTarjeta = i.Serie;

                        odn.CustomerCode = obj.CardCode;
                        odn.CustomerName = obj.CardName;
                        odn.ManufacturerSerialNum = SerieTarjeta;
                        odn.InternalSerialNum = SerieTarjeta;
                        odn.ItemCode = i.ItemCode;
                        odn.ItemDescription = i.ItemName;
                        odn.Status = -3;
                        odn.Priority = BoSvcCallPriorities.scp_Medium;
                        odn.Subject = i.ItemName;
                        odn.Origin = -1;
                        //odn.ProblemType = 1;
                        odn.CallType = Convert.ToInt32(i.DetalleServicio);

                        var ors2 = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors2.Command.Name = "DXP_GET_USUARIO";
                        ors2.Command.Parameters.Item("@OWNERCODE").Value = obj.OwnerCode;
                        ors2.Command.Execute();
                        ors2.MoveFirst();
                        odn.AssigneeCode = Convert.ToInt32(ors2.Fields.Item(0).Value);

                        //odn.DirectCustomerCode = obj.CardCode;
                        //odn.DirectCustomerName = obj.CardName;
                        //odn.DeliveryCode = obj.DocEntry;

                        ocp.StartTransaction();
                        RetVal = odn.Add();
                        if (RetVal != 0)
                        {
                            ocp.GetLastError(out ErrCode, out ErrMsg);
                            obj.Msg = ErrMsg;
                            if (ocp.InTransaction)
                                ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                            throw new ArgumentException(ErrMsg);
                        }
                        else
                        {
                            if (ocp.InTransaction)
                                ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                            //obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                            //RetVal = 0;
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }

        }
        public void SaveService(BELlamadaServicio obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (ServiceCalls)ocp.GetBusinessObject(BoObjectTypes.oServiceCalls);

                    odn.CustomerCode = obj.CardCode;
                    odn.CustomerName = obj.CardName;
                    if (Convert.ToInt32(obj.ContactPerson) != 0)
                        odn.ContactCode = Convert.ToInt32(obj.ContactPerson);
                    odn.InternalSerialNum = obj.SerieInt;
                    odn.ItemCode = obj.ItemCode;
                    odn.ItemDescription = obj.ItemName;
                    odn.Status = Convert.ToInt32(obj.Estado);
                    if(obj.Prioridad == "L")
                    {
                        odn.Priority = BoSvcCallPriorities.scp_Low;
                    }
                    else if (obj.Prioridad == "M")
                    {
                        odn.Priority = BoSvcCallPriorities.scp_Medium;
                    }
                    else
                    {
                        odn.Priority = BoSvcCallPriorities.scp_High;
                    }
                    
                    odn.Subject = obj.Asunto;
                    odn.Origin = Convert.ToInt32(obj.Origen);
                    if (Convert.ToInt32(obj.TipoProblema) != 0)
                        odn.ProblemType = Convert.ToInt32(obj.TipoProblema);
                    if (Convert.ToInt32(obj.DetalleServicio) != 0)
                        odn.CallType = Convert.ToInt32(obj.DetalleServicio);
                    if (Convert.ToInt32(obj.Tecnico) != 0)
                        odn.TechnicianCode = Convert.ToInt32(obj.Tecnico);
                    odn.Description = obj.Comentario;
                    odn.Resolution = obj.Resolucion;
                    odn.Location = -2;
                    odn.AddressName = obj.IdDireccion;
                    obj.lineatecnicos.ForEach(i =>
                    {
                        odn.UserFields.Fields.Item("U_GOS_TECN"+i.LineNum.ToString()).Value = i.ID;
                    });
                    if(obj.AddressType == "B") 
                        odn.AddressType = BoAddressType.bo_BillTo;
                    else
                        odn.AddressType = BoAddressType.bo_ShipTo;
                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.CallId = Convert.ToInt32(ocp.GetNewObjectKey());
                        //RetVal = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }

        }
        public void UpdtService(BELlamadaServicio obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (ServiceCalls)ocp.GetBusinessObject(BoObjectTypes.oServiceCalls);
                    odn.GetByKey(obj.CallId);
                    //odn.CustomerCode = obj.CardCode;
                    //odn.CustomerName = obj.CardName;
                    if (Convert.ToInt32(obj.ContactPerson) != 0)
                        odn.ContactCode = Convert.ToInt32(obj.ContactPerson);
                    odn.InternalSerialNum = obj.SerieInt;
                    //odn.ItemCode = obj.ItemCode;
                    //odn.ItemDescription = obj.ItemName;
                    odn.Status = Convert.ToInt32(obj.Estado);
                    if (obj.Prioridad == "L")
                    {
                        odn.Priority = BoSvcCallPriorities.scp_Low;
                    }
                    else if (obj.Prioridad == "M")
                    {
                        odn.Priority = BoSvcCallPriorities.scp_Medium;
                    }
                    else
                    {
                        odn.Priority = BoSvcCallPriorities.scp_High;
                    }

                    odn.Subject = obj.Asunto;
                    odn.Origin = Convert.ToInt32(obj.Origen);
                    if (Convert.ToInt32(obj.TipoProblema) != 0)
                        odn.ProblemType = Convert.ToInt32(obj.TipoProblema);
                    if (Convert.ToInt32(obj.DetalleServicio) != 0)
                        odn.CallType = Convert.ToInt32(obj.DetalleServicio);
                    if (Convert.ToInt32(obj.Tecnico) != 0)
                        odn.TechnicianCode = Convert.ToInt32(obj.Tecnico);
                    odn.Description = obj.Comentario;
                    odn.Resolution = obj.Resolucion;
                    odn.Location = -2;
                    odn.AddressName = obj.IdDireccion;
                    if (obj.AddressType == "B")
                        odn.AddressType = BoAddressType.bo_BillTo;
                    else
                        odn.AddressType = BoAddressType.bo_ShipTo;
                    ocp.StartTransaction();
                    RetVal = odn.Update();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        //obj.CallId = Convert.ToInt32(ocp.GetNewObjectKey());
                        //RetVal = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }

        }
        /// <summary>
        /// GUARDA EL DOCUMENTO DE ENTREGA
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objs"></param>
        public void SaveDraft (BEDocument obj, object objs, int objtype)
        {
            try
            {
                var bandC = false;
                var bandS = false;
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);
                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oDrafts);

                    //? CABECERA
                    odn.DocType = BoDocumentTypes.dDocument_Items;
                    odn.DocDate = obj.DocDate;
                    if(objtype  == 15)
                    {
                        odn.DocObjectCode = BoObjectTypes.oDeliveryNotes;
                        odn.UserFields.Fields.Item("U_DXP_FE_MOTIVO_TRAS").Value = obj.U_DXP_FE_MOTIVO_TRAS;
                        odn.UserFields.Fields.Item("U_DXP_FE_MODALIDTRAS").Value = obj.U_DXP_FE_MODALIDTRAS;
                        odn.TaxDate = obj.TaxDate;
                        if (obj.CntctCode != 0)
                            odn.ContactPersonCode = obj.CntctCode;
                    }
                    else if(objtype == 13)
                    {
                        odn.DocObjectCode = BoObjectTypes.oInvoices;
                        obj.Anticipos.ForEach(entrys =>
                        {
                            var pdm = (Documents)ocp.GetBusinessObject(BoObjectTypes.oDownPayments);
                            var anticipo = (DownPaymentsToDraw)odn.DownPaymentsToDraw;
                            pdm.GetByKey(entrys.DocEntry);
                            anticipo.AmountToDraw = pdm.DownPaymentAmount;
                            anticipo.DocEntry = pdm.DocEntry;
                            anticipo.Add();
                        });

                        odn.UserFields.Fields.Item("U_MP_FE_GRR").Value = string.IsNullOrWhiteSpace(obj.U_MP_FE_GRR) ? string.Empty : obj.U_MP_FE_GRR;
                        odn.UserFields.Fields.Item("U_DXP_FE_TO").Value = string.IsNullOrWhiteSpace(obj.U_DXP_FE_TO) ? "0101" : obj.U_DXP_FE_TO;
                        odn.TaxDate = obj.TaxDate;
                        if (obj.CntctCode != 0)
                            odn.ContactPersonCode = obj.CntctCode;
                    }
                    else if (objtype == 14)
                    {
                        odn.DocObjectCode = BoObjectTypes.oCreditNotes;
                        odn.UserFields.Fields.Item("U_DXP_FE_MOT_GEN").Value = string.IsNullOrWhiteSpace(obj.U_DXP_FE_MOT_GEN) ? "01" : obj.U_DXP_FE_MOT_GEN;
                        odn.UserFields.Fields.Item("U_BPP_MDTO").Value = string.IsNullOrWhiteSpace(obj.U_BPP_MDTO) ? "" : obj.U_BPP_MDTO;
                        odn.UserFields.Fields.Item("U_BPP_MDSO").Value = string.IsNullOrWhiteSpace(obj.U_BPP_MDSO) ? "" : obj.U_BPP_MDSO;
                        odn.UserFields.Fields.Item("U_BPP_MDCO").Value = string.IsNullOrWhiteSpace(obj.U_BPP_MDCO) ? "" : obj.U_BPP_MDCO;
                        odn.TaxDate = obj.DocDate;
                    }
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.FederalTaxID = obj.LicTradNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.Project = obj.Project;
                    odn.ShipToCode = obj.ShipToCode;
                    odn.PayToCode = obj.PayToCode;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.HandWritten = BoYesNoEnum.tNO;
                    odn.DocCurrency = obj.Currency;
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;
                    odn.UserFields.Fields.Item("U_BPP_MDTD").Value = obj.U_BPP_MDTD;
                    odn.UserFields.Fields.Item("U_BPP_MDSD").Value = obj.U_BPP_MDSD;
                    odn.UserFields.Fields.Item("U_BPP_MDCD").Value = obj.U_BPP_MDCD;
                    

                    /*VERIFICAR ACTIVO PARA CONTRATO Y SERVICIO*/
                    obj.Lines.ForEach(a =>
                    {
                        if (a.ActivoC == "Y") bandC = true;
                        if (a.ActivoS == "Y") bandS = true;
                    });
                    //? DETALLE
                    obj.Lines.ForEach(_item =>
                    {
                        if (_item.TreeType != "I")
                        {
                            odn.Lines.ItemCode = _item.ItemCode;
                            odn.Lines.ItemDescription = _item.ItemName;
                            odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                            odn.Lines.Quantity = Convert.ToDouble(_item.Quantity);
                            if (_item.DiscPrcnt > 0)
                                odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                            odn.Lines.WarehouseCode = _item.WhsCode;

                            //SERIALNUMBER(FOR PARA OBTENER LAS SERIES Y AGREGAR)

                            odn.Lines.WTLiable = BoYesNoEnum.tNO;
                            odn.Lines.TaxCode = (string.IsNullOrWhiteSpace(_item.TaxCode)) ? "IGV" : _item.TaxCode;
                            if (_item.BaseEntry != 0)
                            {
                                odn.Lines.BaseType = _item.BaseType;
                                odn.Lines.BaseEntry = _item.BaseEntry;
                                odn.Lines.BaseLine = _item.BaseLine;
                            }
                            odn.Lines.Add();
                        }
                    });


                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var odn2 = (Documents)ocp.GetBusinessObject(BoObjectTypes.oDrafts);
                        odn2.GetByKey(obj.DocEntry);

                        if ((objtype == 13 || objtype == 15) && string.IsNullOrWhiteSpace(obj.U_MP_FE_GRR))
                        {

                            obj.Lines.ForEach(item =>
                            {

                                //SERIALNUMBER(FOR PARA OBTENER LAS SERIES Y AGREGAR)
                                if (item.IssueMthd.Substring(0, 1) == "M" && !string.IsNullOrWhiteSpace(item.Serie))
                                {
                                    var series = item.Serie.Split(';');
                                    for (var i = 0; i <= Convert.ToDouble(item.Quantity) - 1; i++)
                                    {
                                        odn2.Lines.SetCurrentLine(item.LineNum - 1);
                                        var serialnumber = series[i].Split('-');
                                        odn2.Lines.SerialNumbers.SystemSerialNumber = Convert.ToInt32(serialnumber[1]);
                                        odn2.Lines.SerialNumbers.Quantity = 1;
                                        odn2.Lines.SerialNumbers.Add();
                                    }
                                }
                                else if (item.IssueMthd.Substring(0, 1) == "L" && !string.IsNullOrWhiteSpace(item.Serie))
                                {
                                    var series = item.Serie.Split(';');
                                    for (var i = 0; i < series.Count(); i++)
                                    {
                                        odn2.Lines.SetCurrentLine(item.LineNum - 1);
                                        var serialnumber = series[i].Split('-');
                                        odn2.Lines.BatchNumbers.BatchNumber = serialnumber[0];
                                        odn2.Lines.BatchNumbers.Quantity = Convert.ToDouble(serialnumber[1]);
                                        odn2.Lines.BatchNumbers.Add();
                                    }
                                }

                            });
                        }
                        else if (objtype == 14)
                        {
                            obj.Lines.ForEach(item =>
                            {

                                //SERIALNUMBER(FOR PARA OBTENER LAS SERIES Y AGREGAR)
                                if (item.IssueMthd.Substring(0, 1) == "M" && !string.IsNullOrWhiteSpace(item.Serie))
                                {
                                    var series = item.Serie.Split(';');
                                    for (var i = 0; i <= Convert.ToDouble(item.Quantity) - 1; i++)
                                    {
                                        odn2.Lines.SetCurrentLine(item.LineNum - 1);
                                        var serialnumber = series[i].Split('-');
                                        odn2.Lines.SerialNumbers.SystemSerialNumber = Convert.ToInt32(serialnumber[1]);
                                        odn2.Lines.SerialNumbers.Quantity = 1;
                                        odn2.Lines.SerialNumbers.Add();
                                    }
                                }
                                else if (item.IssueMthd.Substring(0, 1) == "L" && !string.IsNullOrWhiteSpace(item.Serie))
                                {
                                    var series = item.Serie.Split(';');
                                    for (var i = 0; i < series.Count(); i++)
                                    {
                                        odn2.Lines.SetCurrentLine(item.LineNum - 1);
                                        var serialnumber = series[i].Split('-');
                                        odn2.Lines.BatchNumbers.BatchNumber = serialnumber[0];
                                        odn2.Lines.BatchNumbers.Quantity = Convert.ToDouble(serialnumber[1]);
                                        odn2.Lines.BatchNumbers.Add();
                                    }
                                }

                            });
                        }
                        ocp.StartTransaction();
                        RetVal = odn2.Update();
                        if (RetVal != 0)
                        {
                            ocp.GetLastError(out ErrCode, out ErrMsg);
                            obj.Msg = ErrMsg;
                            if (ocp.InTransaction)
                                ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                            throw new ArgumentException(ErrMsg);
                        }
                        else
                        {

                            if (odn2.SaveDraftToDocument() != 0)
                            {
                                ocp.GetLastError(out ErrCode, out ErrMsg);
                                obj.Msg = ErrMsg;
                                if (ocp.InTransaction)
                                    ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                                throw new ArgumentException(ErrMsg);
                            }
                            else
                            {
                                if (ocp.InTransaction)
                                    ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                                obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());

                                var ors2 = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                                ors2.Command.Name = "OSCSP_OBJD";
                                if (objtype == 15)
                                {
                                    ors2.Command.Parameters.Item("@DscTable").Value = "ODLN o";
                                    if (true) CreateTarjetaEquipo(obj, objs);
                                    if (bandS) CreateService(obj, objs);
                                }
                                else if (objtype == 13)
                                {
                                    ors2.Command.Parameters.Item("@DscTable").Value = "OINV o";
                                }
                                else if (objtype == 14)
                                {
                                    ors2.Command.Parameters.Item("@DscTable").Value = "ORIN o";
                                }
                                
                                ors2.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                                ors2.Command.Execute();
                                ors2.MoveFirst();
                                obj.DocNum = Convert.ToInt32(ors2.Fields.Item(0).Value);
                                
                            }
                        }
                        



                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SaveDeliveryNote(BEDocument obj, object objs)
        {
            try
            {
                var bandC = false;
                var bandS = false;
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);
                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oDeliveryNotes);

                    //? CABECERA
                    odn.DocType = BoDocumentTypes.dDocument_Items;
                    odn.DocDate = obj.DocDate;
                    odn.TaxDate = obj.TaxDate;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.FederalTaxID = obj.LicTradNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.Project = obj.Project;
                    odn.ShipToCode = obj.ShipToCode;
                    odn.PayToCode = obj.PayToCode;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.HandWritten = BoYesNoEnum.tNO;
                    odn.DocCurrency = obj.Currency;
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;
                    odn.UserFields.Fields.Item("U_BPP_MDTD").Value = obj.U_BPP_MDTD;
                    odn.UserFields.Fields.Item("U_BPP_MDSD").Value = obj.U_BPP_MDSD;
                    odn.UserFields.Fields.Item("U_BPP_MDCD").Value = obj.U_BPP_MDCD;
                    odn.UserFields.Fields.Item("U_DXP_FE_MOTIVO_TRAS").Value = obj.U_DXP_FE_MOTIVO_TRAS;
                    odn.UserFields.Fields.Item("U_DXP_FE_MODALIDTRAS").Value = obj.U_DXP_FE_MODALIDTRAS;

                    /*VERIFICAR ACTIVO PARA CONTRATO Y SERVICIO*/
                    obj.Lines.ForEach(a =>  {
                        if (a.ActivoC == "Y") bandC = true;
                        if (a.ActivoS == "Y") bandS = true;
                        if (a.TreeType == "S") return;
                    });
                    //? DETALLE
                    obj.Lines.ForEach(_item =>
                    {
                        if (_item.TreeType == "N")
                        {
                            odn.Lines.ItemCode = _item.ItemCode;
                            odn.Lines.ItemDescription = _item.ItemName;
                            odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                            odn.Lines.Quantity = Convert.ToDouble(_item.Quantity);
                            if (_item.DiscPrcnt > 0)
                                odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                            odn.Lines.WarehouseCode = _item.WhsCode;

                            //SERIALNUMBER(FOR PARA OBTENER LAS SERIES Y AGREGAR)
                            if (_item.IssueMthd.Substring(0, 1) == "M" && !string.IsNullOrWhiteSpace(_item.Serie))
                            {
                                var series = _item.Serie.Split(';');
                                for (var i = 0; i <= Convert.ToDouble(_item.Quantity) - 1; i++)
                                {
                                    var serialnumber = series[i].Split('-');
                                    odn.Lines.SerialNumbers.SystemSerialNumber = Convert.ToInt32(serialnumber[1]);
                                    odn.Lines.SerialNumbers.Quantity = 1;
                                    odn.Lines.SerialNumbers.Add();
                                }
                                //
                            }
                            else if (_item.IssueMthd.Substring(0, 1) == "L" && !string.IsNullOrWhiteSpace(_item.Serie))
                            {
                                var series = _item.Serie.Split(';');
                                for (var i = 0; i < series.Count(); i++)
                                {
                                    var serialnumber = series[i].Split('-');
                                    //odn.Lines.BatchNumbers.BaseLineNumber = i;
                                    odn.Lines.BatchNumbers.BatchNumber = serialnumber[0];
                                    odn.Lines.BatchNumbers.Quantity = Convert.ToDouble(serialnumber[1]);
                                    odn.Lines.BatchNumbers.Add();
                                }
                            }
                            odn.Lines.WTLiable = BoYesNoEnum.tNO;
                            odn.Lines.TaxCode = (string.IsNullOrWhiteSpace(_item.TaxCode)) ? "IGV" : _item.TaxCode;
                            if (_item.BaseEntry != 0)
                            {
                                odn.Lines.BaseType = _item.BaseType;
                                odn.Lines.BaseEntry = _item.BaseEntry;
                                odn.Lines.BaseLine = _item.BaseLine;
                            }
                            odn.Lines.Add();
                        }
                    });


                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD";
                        ors.Command.Parameters.Item("@DscTable").Value = "ODLN o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                        if (true) CreateTarjetaEquipo(obj, objs);
                        if (bandS) CreateService(obj, objs);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void ModifyDeliveryNote(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oDeliveryNotes);

                    //? CABECERA
                    odn.DocType = BoDocumentTypes.dDocument_Items;
                    odn.DocDate = obj.DocDate;
                    odn.TaxDate = obj.DocDate;
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.FederalTaxID = obj.LicTradNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.Project = obj.Project;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.HandWritten = BoYesNoEnum.tNO;
                    //odn.DocCurrency = "S/";
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;
                    odn.UserFields.Fields.Item("U_BPP_MDTD").Value = obj.U_BPP_MDTD;
                    odn.UserFields.Fields.Item("U_BPP_MDSD").Value = obj.U_BPP_MDSD;
                    odn.UserFields.Fields.Item("U_BPP_MDCD").Value = obj.U_BPP_MDCD;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    //odn.UserFields.Fields.Item("U_BF_PED_ORIG").Value = string.IsNullOrWhiteSpace(obj.U_BF_PED_ORIG) ? 0 : Convert.ToInt32(obj.U_BF_PED_ORIG);
                    //odn.UserFields.Fields.Item("U_BF_PickRmrk").Value = string.IsNullOrWhiteSpace(obj.U_BF_PickRmrk) ? string.Empty : obj.U_BF_PickRmrk;

                    //? DETALLE
                    var lines = odn.Lines.Count;
                    for (int i = 0; i < lines; i++)
                    {
                        odn.Lines.SetCurrentLine(0);
                        odn.Lines.Delete();
                    }

                    //? AGREGAR DETALLE
                    obj.Lines.ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                        odn.Lines.Quantity = Convert.ToDouble(_item.Quantity);
                        if (_item.DiscPrcnt > 0)
                            odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                        odn.Lines.WarehouseCode = _item.WhsCode;
                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        odn.Lines.TaxCode = (string.IsNullOrWhiteSpace(_item.TaxCode)) ? "IGV" : _item.TaxCode;
                        //odn.Lines.UserFields.Fields.Item("U_BF_CodKit").Value = string.IsNullOrWhiteSpace(_item.U_BF_CodKit) ? string.Empty : _item.U_BF_CodKit;
                        //odn.Lines.UserFields.Fields.Item("U_BF_LOTE").Value = string.IsNullOrWhiteSpace(_item.U_BF_LOTE) ? string.Empty : _item.U_BF_LOTE;
                        if (_item.BaseEntry != 0)
                        {
                            odn.Lines.BaseType = _item.BaseType;
                            odn.Lines.BaseEntry = _item.BaseEntry;
                            odn.Lines.BaseLine = _item.BaseLine;
                        }

                        //? LOTES
                        //if (!string.IsNullOrWhiteSpace(_item.BatchNums))
                        //{
                        //    var arbt = _item.BatchNums.Split('!');
                        //    arbt.Where(i => !string.IsNullOrWhiteSpace(i))
                        //        .ToList()
                        //        .ForEach(i =>
                        //        {
                        //            var vlbn = i.Split('¡');
                        //            odn.Lines.BatchNumbers.BatchNumber = vlbn[0];
                        //            odn.Lines.BatchNumbers.Quantity = Convert.ToDouble(vlbn[1]);
                        //            odn.Lines.BatchNumbers.Add();
                        //        });
                        //}
                        odn.Lines.Add();
                    });

                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    //? GASTO ADICIONAL (MOVILIDAD)
                    //if (obj.TotalExpns > 0)
                    //{
                    //    odn.Expenses.ExpenseCode = string.Compare(obj.Socied, "BT", false) == 0 ? 1 : 9;
                    //    odn.Expenses.TaxCode = "IGV";
                    //    odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                    //    odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                    //    if (obj.BaseDocEntry != 0)
                    //    {
                    //        odn.Expenses.BaseDocType = obj.BaseDocType;
                    //        odn.Expenses.BaseDocLine = 0;
                    //        odn.Expenses.BaseDocEntry = obj.BaseDocEntry;
                    //    }
                    //    odn.Expenses.Add();
                    //}

                    ocp.StartTransaction();
                    RetVal = odn.Update();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD";
                        ors.Command.Parameters.Item("@DscTable").Value = "ODLN o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }

        //!+ ORDEN DE VENTA Y COTIZACIÓN
        /// <summary>
        /// LISTA MATERIA PRIMA Y ENVASES
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_MAEN(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_MAEN_Stock", obep.ParValue, obep.ColumnIndex, obep.TypeFilter);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// FACTOR DE MULTIPLICACION
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_SCSP_MPFC_OITM(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("SCSP_MPFC_OITM");
                ocmd.CommandTimeout = 2000;
                var scl = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (scl);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LOS COMPONENTES DEL ENVASE PHANTOM
        /// </summary>
        /// <param name="obep"></param>
        /// <returns></returns>
        public IDataReader Get_OSCSP_COPH(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_COPH_Prueba");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// listar el ultimo codigo de naiah
        /// </summary>
        /// <param name="obep"></param>
        /// <returns></returns>
        public IDataReader Get_sp_selCodigoNAIAH(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("sp_selCodigoNAIAH");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// listar el ultimo codigo de ruc naiah
        /// </summary>
        /// <param name="obep"></param>
        /// <returns></returns>
        public IDataReader Get_sp_selCodigoRUCNAIAH(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("sp_selCodigoRUCNAIAH");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// Guardar dni Naiah
        /// </summary>
        /// <param name="obj"></param>
        public void set_dninaiah(BEParameters obj)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obj.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("sp_INS_DOCS_NAIAH", obj.dni);
                ocmd.CommandTimeout = 2000;
                odb.ExecuteNonQuery(ocmd);
                Dispose(false);
              
            }
            finally
            {
                ocn.Close();
            }
        
        }
        /// <summary>
        /// Guardar Ruc Naiah
        /// </summary>
        /// <param name="obj"></param>
        public void set_rucnaiah(BEParameters obj)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obj.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("sp_INS_DOCS_RUCNAIAH", obj.dni);
                ocmd.CommandTimeout = 2000;
                odb.ExecuteNonQuery(ocmd);
                Dispose(false);

            }
            finally
            {
                ocn.Close();
            }

        }
        public void CRUD_CONTRATOS(BEParameters obj)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obj.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_CRUD_CONTRATOS", obj.accion, obj.AbsEntryUpdt,obj.FechaUpdt, obj.Descripcion, obj.DraftEntry);
                ocmd.CommandTimeout = 2000;
                odb.ExecuteNonQuery(ocmd);
                Dispose(false);

            }
            finally
            {
                ocn.Close();
            }

        }
        /// <summary>
        /// GUARDA LA COTIZACION DEL RP
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objs"></param>
        public void SaveQut(BEQuotation obj, object objs)
        {
            try
            {
                int ErrCode = 0;
                string ErrMsg = string.Empty;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var gcs = ocp.GetCompanyService();
                    GeneralService ogs;
                    GeneralData ogd;
                  
                    ogs = gcs.GetGeneralService("BIZ_QUT");
                    ogd = ogs.GetDataInterface(GeneralServiceDataInterfaces.gsGeneralData);
                    ogd.SetProperty("U_BIZ_CODM", obj.U_BIZ_CODM);
                    ogd.SetProperty("U_BIZ_NOMM", obj.U_BIZ_NOMM);
                    ogd.SetProperty("U_BIZ_CNTP", Convert.ToDouble(obj.U_BIZ_CNTP));
                    ogd.SetProperty("U_BIZ_CODR", obj.U_BIZ_CODR);
                    ogd.SetProperty("U_BIZ_NOMR", obj.U_BIZ_NOMR);
                    ogd.SetProperty("U_BIZ_TOTP", Convert.ToDouble(obj.U_BIZ_TOTP));
                    ogd.SetProperty("U_BIZ_COSC", Convert.ToDouble(obj.U_BIZ_COSC));
                    ogd.SetProperty("U_BIZ_COSE", Convert.ToDouble(obj.U_BIZ_COSE));
                    ogd.SetProperty("U_BIZ_COSM", Convert.ToDouble(obj.U_BIZ_COSM));
                    ogd.SetProperty("U_BIZ_TOTC", Convert.ToDouble(obj.U_BIZ_TOTC));
                    ogd.SetProperty("U_BIZ_PMAR", Convert.ToDouble(obj.U_BIZ_PMAR));
                    ogd.SetProperty("U_BIZ_PREV", Convert.ToDouble(obj.U_BIZ_PREV));
                    ogd.SetProperty("U_BIZ_DOCE", obj.U_BIZ_DOCE ?? string.Empty);
                    ogd.SetProperty("U_BIZ_COSN", obj.U_BIZ_COSN);
                    ogd.SetProperty("U_BIZ_TOTM", Convert.ToDouble(obj.U_BIZ_TOTM));
                    ogd.SetProperty("U_BIZ_UNPR", obj.U_BIZ_UNPR);
                    ogd.SetProperty("U_BIZ_MIGV", Math.Round(Convert.ToDouble(obj.U_BIZ_MIGV), 5).ToString());
                    ogd.SetProperty("U_BIZ_PVMI", Convert.ToDouble(obj.U_BIZ_PVMI));
                    ogd.SetProperty("U_BF_DEET", obj.U_BF_DEET);
                    ogd.SetProperty("U_BF_FOFA", obj.U_BF_FOFA);
                    ogd.SetProperty("U_BF_HNCO", obj.U_BF_HNCO);
                    ogd.SetProperty("U_PickRmrk", obj.U_PickRmrk);

                    var ogd17 = ogd.Child("BIZ_QUT17");
                    GeneralData ocld17;
                    obj.qut17.ForEach(lobj =>
                    {
                        ocld17 = ogd17.Add();
                        ocld17.SetProperty("U_BIZ_CCOM", lobj.U_BIZ_CCOM);
                        ocld17.SetProperty("U_BIZ_NCOM", lobj.U_BIZ_NCOM);
                        ocld17.SetProperty("U_BIZ_PCTO", Convert.ToDouble(lobj.U_BIZ_PCTO));
                        ocld17.SetProperty("U_BIZ_COST", Convert.ToDouble(lobj.U_BIZ_COST));
                        ocld17.SetProperty("U_BIZ_RESU", Convert.ToDouble(lobj.U_BIZ_RESU));
                    });

                    var ogd18 = ogd.Child("BIZ_QUT18");
                    GeneralData ocld18;
                    obj.qut18.ForEach(lobj =>
                    {
                        ocld18 = ogd18.Add();
                        ocld18.SetProperty("U_BIZ_CENV", lobj.U_BIZ_CENV);
                        ocld18.SetProperty("U_BIZ_NENV", lobj.U_BIZ_NENV);
                        ocld18.SetProperty("U_BIZ_CANT", Convert.ToDouble(lobj.U_BIZ_CANT));
                        ocld18.SetProperty("U_BIZ_UNME", lobj.U_BIZ_UNME);
                        ocld18.SetProperty("U_BIZ_COST", Convert.ToDouble(lobj.U_BIZ_COST));
                        ocld18.SetProperty("U_BIZ_RESU", Convert.ToDouble(lobj.U_BIZ_RESU));
                    });

                    ocp.StartTransaction();
                    var ogp = ogs.Add(ogd);
                    ocp.GetLastError(out ErrCode, out ErrMsg);
                    if (ErrCode != 0)
                    {
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ogp.GetProperty("DocEntry"));
                        if (obj.DocEntry == 0)
                            obj.Msg = "(DACT) - Error Interno.";
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }     
        }
        /// <summary>
        /// BÚSCA COTIZACIONES DE RP'S SEGÚN FILTRO
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_QUTT(BEParameters obj)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obj.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_QUTT", obj.DocEntry,
                                                                       obj.DateIn,
                                                                       obj.CardCode,
                                                                       obj.CardName,
                                                                       obj.Actives);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA MATERIA PRIMA Y ENVASES DE LA COTIZACION
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_QUTD(BEParameters obj)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obj.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_QUTD", obj.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// PARAMETROS DE MOVILIDAD
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public IDataReader Get_SCSP_LSPR_MOVI(BEParameters obj)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obj.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("SCSP_LSPR_MOVI");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// MOVILIDAD DE BELMAY
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string Get_OSCSP_MVBM(BEParameters obj)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obj.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_MVBM", obj.DocEntry);
                ocmd.CommandTimeout = 2000;
                var osl = odb.ExecuteScalar(ocmd).ToString();
                Dispose(false);
                return (osl);
            }
            finally
            {
                ocn.Close();
            }
        }
        public void SaveOfertaVenta(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oQuotations);

                    //? CABECERA
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.DocDate = obj.DocDate;
                    odn.DocDueDate = obj.DocDueDate;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    odn.DocCurrency = obj.Currency;
                    odn.ShipToCode = obj.ShipToCode;
                    odn.PayToCode = obj.PayToCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.PickRemark = obj.U_BF_PickRmrk;
                    odn.Project = obj.Project;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;



                    /*odn.UserFields.Fields.Item("U_BIZ_LUEN").Value = obj.U_BIZ_LUEN;
                    odn.UserFields.Fields.Item("U_BF_HOEN").Value = obj.U_BF_HOEN;
                    odn.UserFields.Fields.Item("U_BF_HCFI").Value = obj.U_BF_HCFI;
                    odn.UserFields.Fields.Item("U_BF_CODNI").Value = obj.U_BF_CODNI;
                    odn.UserFields.Fields.Item("U_BIZ_SOLI").Value = obj.U_BIZ_SOLI;
                    odn.UserFields.Fields.Item("U_BF_COCIT").Value = obj.U_BF_COCIT;
                    odn.UserFields.Fields.Item("U_BIZ_CONTA").Value = obj.U_BIZ_CONTA;
                    odn.UserFields.Fields.Item("U_BIZ_TPDO").Value = obj.U_BIZ_TPDO;
                    odn.UserFields.Fields.Item("U_BF_PickRmrk").Value = obj.U_BF_PickRmrk;
                    if (string.Compare(obj.Socied, "BT", false) == 0)
                    {                        
                        odn.UserFields.Fields.Item("U_BIZ_DOCG").Value = obj.U_BIZ_DOCG;
                        odn.UserFields.Fields.Item("U_BF_CREDBM").Value = Convert.ToDouble(obj.U_BF_CREDBM);
                        odn.UserFields.Fields.Item("U_BF_NumOV").Value = obj.U_BF_NumOV;
                        odn.UserFields.Fields.Item("U_BIZ_MEDI").Value = obj.U_BIZ_MEDI;
                        odn.UserFields.Fields.Item("U_BIZ_ESP").Value = obj.U_BIZ_ESP;
                        odn.UserFields.Fields.Item("U_BIZ_COLE").Value = obj.U_BIZ_COLE;
                        odn.UserFields.Fields.Item("U_BIZ_DIRE_MED").Value = obj.U_BIZ_DIRE_MED;
                        if (!string.IsNullOrWhiteSpace(obj.U_BIZ_MEDI))
                            odn.UserFields.Fields.Item("U_BF_SELLO").Value = "S";
                    }
                    else
                    {
                        odn.UserFields.Fields.Item("U_BIZ_DOCU").Value = (string.Compare(obj.U_BIZ_DOCG, "01", false) == 0) ? "02" : "01";
                    }*/

                    //? DETALLE
                    obj.Lines.Where(i => i.TreeType != "I").ToList().ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                        odn.Lines.Quantity = _item.Quantity;
                        if (_item.DiscPrcnt > 0)
                            odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                        odn.Lines.WarehouseCode = _item.WhsCode;
                        odn.Lines.TaxCode = "IGV";
                        
                        //if (_item.TreeType == "S") odn.Lines.TreeType = BoItemTreeTypes.iNotATree;
                        /*odn.Lines.UserFields.Fields.Item("U_BF_CodKit").Value = _item.U_BF_CodKit;
                        odn.Lines.UserFields.Fields.Item("U_BF_InGiff").Value = Convert.ToInt16(_item.InGift);
                        odn.Lines.UserFields.Fields.Item("U_BF_InDscOrg").Value = Convert.ToInt16(_item.InDscOrg);
                        if (string.Compare(obj.Socied, "DX", false) == 0)
                        {
                            //odn.Lines.UserFields.Fields.Item("U_BIZ_DREC").Value = _item.U_BIZ_DREC ?? string.Empty;
                            if (string.Compare(_item.ItemCode, "60100000", false) == 0)
                            {
                                odn.Lines.UserFields.Fields.Item("U_BIZ_CORR").Value = _item.DocQut ?? string.Empty;
                                odn.Lines.BaseType = _item.BaseType;
                                odn.Lines.BaseEntry = _item.BaseEntry;
                                odn.Lines.BaseLine = _item.BaseLine;
                            }
                            if (_item.U_BF_FECH_EXPE != null)
                            {
                                odn.Lines.UserFields.Fields.Item("U_BF_FECH_EXPE").Value = Convert.ToDateTime(_item.U_BF_FECH_EXPE);
                                odn.Lines.UserFields.Fields.Item("U_BF_FECH_VENC").Value = Convert.ToDateTime(_item.U_BF_FECH_VENC);
                            }
                            odn.Lines.UserFields.Fields.Item("U_BIZ_CANT").Value = Convert.ToDouble(_item.U_BIZ_CANT);
                            odn.Lines.UserFields.Fields.Item("U_BIZ_UNPR").Value = _item.U_BIZ_UNPR ?? string.Empty;
                            odn.Lines.UserFields.Fields.Item("U_BIZ_FFAR").Value = _item.U_BIZ_FFAR ?? string.Empty;
                            odn.Lines.UserFields.Fields.Item("U_BIZ_GANA").Value = Convert.ToDouble(_item.U_BIZ_GANA);
                            odn.Lines.UserFields.Fields.Item("U_BIZ_ETI").Value = _item.U_BF_ABRE_ETIQ ?? string.Empty;
                        }
                        else
                        {
                            odn.Lines.UserFields.Fields.Item("U_StoDiBE").Value = Convert.ToDouble(_item.U_StoDiBE);
                            odn.Lines.UserFields.Fields.Item("U_BF_StoDiYo").Value = Convert.ToDouble(_item.U_BF_StoDiYo);
                            odn.Lines.UserFields.Fields.Item("U_U_BF_CompTot").Value = Convert.ToDouble(_item.U_U_BF_CompTot);
                        }*/

                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        odn.Lines.Add();
                    });

                    //? GASTO ADICIONAL (MOVILIDAD)
                    if (obj.TotalExpns > 0)
                    {
                        odn.Expenses.ExpenseCode = /*string.Compare(obj.Socied, "BT", false) == 0 ?*/ 1 /*: 9*/;
                        odn.Expenses.TaxCode = "IGV";
                        odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                        odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                        odn.Expenses.Add();
                    }

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD";
                        ors.Command.Parameters.Item("@DscTable").Value = "OQUT o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void CreateBorrador(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oDrafts);

                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.DocDate = obj.DocDate;
                    odn.DocCurrency = obj.Currency;
                    odn.DocDueDate = obj.DocDueDate;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    odn.ShipToCode = obj.ShipToCode;
                    odn.PayToCode = obj.PayToCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.ContactPersonCode = obj.CntctCode;
                    //odn.PickRemark = obj.U_BF_PickRmrk;
                    odn.Project = obj.Project;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    odn.DocObjectCode = BoObjectTypes.oOrders;
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;

                    obj.Lines.Where(i => i.ActivoC == "Y").ToList().ForEach(_item =>
                    {
                        if (_item.TreeType != "I")
                        {
                            odn.Lines.ItemCode = _item.ItemCode;
                            odn.Lines.ItemDescription = _item.ItemName;
                            odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                            odn.Lines.Quantity = _item.Quantity;
                            if (_item.DiscPrcnt > 0)
                                odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                            odn.Lines.WarehouseCode = _item.WhsCode;
                            odn.Lines.TaxCode = "IGV";
                            odn.Lines.WTLiable = BoYesNoEnum.tNO;
                            odn.Lines.Add();
                        }
                    });
                    if (obj.TotalExpns > 0)
                    {
                        odn.Expenses.ExpenseCode = /*string.Compare(obj.Socied, "BT", false) == 0 ?*/ 1 /*: 9*/;
                        odn.Expenses.TaxCode = "IGV";
                        odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                        odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                        odn.Expenses.Add();
                    }

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "DXP_CRUD_CONTRATOS";
                        ors.Command.Parameters.Item("@ACCION").Value = "1";
                        ors.Command.Parameters.Item("@ABSENTRYUPDT").Value = 0;
                        ors.Command.Parameters.Item("@FECHAUPDT").Value = DateTime.Today;
                        ors.Command.Parameters.Item("@DESCRIPCION").Value = "-";
                        ors.Command.Parameters.Item("@DOCENTRYMODELO").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        //obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        
        }
        public void ModifyBorrador(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oDrafts);

                    odn.GetByKey(obj.DocEntryBorrador);

                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.DocDate = obj.DocDate;
                    odn.DocCurrency = obj.Currency;
                    odn.DocDueDate = obj.DocDueDate;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    odn.ShipToCode = obj.ShipToCode;
                    odn.PayToCode = obj.PayToCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.DocumentsOwner = obj.OwnerCode;
                    //odn.PickRemark = obj.U_BF_PickRmrk;
                    odn.Project = obj.Project;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    odn.DocObjectCode = BoObjectTypes.oOrders;
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;

                    //? REMOVER DETALLE
                    var lines = odn.Lines.Count;
                    for (int i = 0; i < lines; i++)
                    {
                        odn.Lines.SetCurrentLine(0);
                        odn.Lines.Delete();
                    }

                    obj.Lines.Where(i => i.ActivoC == "Y").ToList().ForEach(_item =>
                    {
                        if (_item.TreeType != "I")
                        {
                            odn.Lines.ItemCode = _item.ItemCode;
                            odn.Lines.ItemDescription = _item.ItemName;
                            odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                            odn.Lines.Quantity = _item.Quantity;
                            if (_item.DiscPrcnt > 0)
                                odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                            odn.Lines.WarehouseCode = _item.WhsCode;
                            odn.Lines.TaxCode = "IGV";
                            odn.Lines.WTLiable = BoYesNoEnum.tNO;
                            odn.Lines.Add();
                        }
                    });
                    if (obj.TotalExpns > 0)
                    {
                        odn.Expenses.ExpenseCode = /*string.Compare(obj.Socied, "BT", false) == 0 ?*/ 1 /*: 9*/;
                        odn.Expenses.TaxCode = "IGV";
                        odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                        odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                        odn.Expenses.Add();
                    }

                    ocp.StartTransaction();
                    RetVal = odn.Update();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        //obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }

        }
        /// <summary>
        /// GUARDA LA ORDEN DE VENTA
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objs"></param>
        public void SaveOrderSale(BEDocument obj, object objs)
        {
            try
            {
                var bandC = false;
                var bandS = false;
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oOrders);

                    //? CABECERA
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.DocDate = obj.DocDate;
                    odn.DocCurrency = obj.Currency;
                    odn.DocDueDate = obj.DocDueDate;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    odn.ShipToCode = obj.ShipToCode;
                    odn.PayToCode = obj.PayToCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.PickRemark = obj.U_BF_PickRmrk;
                    odn.Project = obj.Project;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;

                    /*VERIFICAR ACTIVO PARA CONTRATO Y SERVICIO*/
                    obj.Lines.ForEach(a => {
                        if (a.ActivoC == "Y") bandC = true;
                        if (a.ActivoS == "Y") bandS = true;
                    });

                    if (bandC) CreateBorrador(obj, objs);
                    

                    obj.Lines.Where(i => i.TreeType!="I").ToList().ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                        odn.Lines.Quantity = _item.Quantity;
                        if (_item.DiscPrcnt > 0)
                            odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);                        
                        odn.Lines.WarehouseCode = _item.WhsCode;
                        odn.Lines.TaxCode = "IGV";

                        if (_item.BaseEntry != 0)
                        {
                            odn.Lines.BaseType = _item.BaseType;
                            odn.Lines.BaseEntry = _item.BaseEntry;
                            odn.Lines.BaseLine = _item.BaseLine;
                        }
                        //if (_item.TreeType == "S") odn.Lines.TreeType = BoItemTreeTypes.iNotATree;
                        /*odn.Lines.UserFields.Fields.Item("U_BF_CodKit").Value = _item.U_BF_CodKit;
                        odn.Lines.UserFields.Fields.Item("U_BF_InGiff").Value = Convert.ToInt16(_item.InGift);
                        odn.Lines.UserFields.Fields.Item("U_BF_InDscOrg").Value = Convert.ToInt16(_item.InDscOrg);
                        if (string.Compare(obj.Socied, "DX", false) == 0)
                        {
                            //odn.Lines.UserFields.Fields.Item("U_BIZ_DREC").Value = _item.U_BIZ_DREC ?? string.Empty;
                            if (string.Compare(_item.ItemCode, "60100000", false) == 0)
                            {
                                odn.Lines.UserFields.Fields.Item("U_BIZ_CORR").Value = _item.DocQut ?? string.Empty;
                                odn.Lines.BaseType = _item.BaseType;
                                odn.Lines.BaseEntry = _item.BaseEntry;
                                odn.Lines.BaseLine = _item.BaseLine;
                            }
                            if (_item.U_BF_FECH_EXPE != null)
                            {
                                odn.Lines.UserFields.Fields.Item("U_BF_FECH_EXPE").Value = Convert.ToDateTime(_item.U_BF_FECH_EXPE);
                                odn.Lines.UserFields.Fields.Item("U_BF_FECH_VENC").Value = Convert.ToDateTime(_item.U_BF_FECH_VENC);
                            }
                            odn.Lines.UserFields.Fields.Item("U_BIZ_CANT").Value = Convert.ToDouble(_item.U_BIZ_CANT);
                            odn.Lines.UserFields.Fields.Item("U_BIZ_UNPR").Value = _item.U_BIZ_UNPR ?? string.Empty;
                            odn.Lines.UserFields.Fields.Item("U_BIZ_FFAR").Value = _item.U_BIZ_FFAR ?? string.Empty;
                            odn.Lines.UserFields.Fields.Item("U_BIZ_GANA").Value = Convert.ToDouble(_item.U_BIZ_GANA);
                            odn.Lines.UserFields.Fields.Item("U_BIZ_ETI").Value = _item.U_BF_ABRE_ETIQ ?? string.Empty;
                        }
                        else
                        {
                            odn.Lines.UserFields.Fields.Item("U_StoDiBE").Value = Convert.ToDouble(_item.U_StoDiBE);
                            odn.Lines.UserFields.Fields.Item("U_BF_StoDiYo").Value = Convert.ToDouble(_item.U_BF_StoDiYo);
                            odn.Lines.UserFields.Fields.Item("U_U_BF_CompTot").Value = Convert.ToDouble(_item.U_U_BF_CompTot);
                        }*/

                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        odn.Lines.Add();
                    });

                    //? GASTO ADICIONAL (MOVILIDAD)
                    if (obj.TotalExpns > 0)
                    {
                        odn.Expenses.ExpenseCode = /*string.Compare(obj.Socied, "BT", false) == 0 ?*/ 1 /*: 9*/;
                        odn.Expenses.TaxCode = "IGV";
                        odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                        odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                        odn.Expenses.Add();
                    }

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD";
                        ors.Command.Parameters.Item("@DscTable").Value = "ORDR o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SaveUdt(BEDocument obj, object objs)
        {
            try
            {
                var bandC = false;
                var bandS = false;
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = ocp.UserTables.Item("DXP_PARAMETROS");

                    odn.Code = "HOLA";
                    odn.Name = "MUNDO";

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);

                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void SavePurchaseOrder(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oPurchaseOrders);

                    //? CABECERA
                    odn.CardCode = obj.CardCode;
                    odn.CardName = obj.CardName;
                    odn.DocDate = obj.DocDate;
                    odn.DocDueDate = obj.DocDueDate;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    odn.ShipToCode = obj.ShipToCode;
                    odn.DocCurrency = obj.Currency;
                    odn.PayToCode = obj.PayToCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.PickRemark = obj.U_BF_PickRmrk;
                    odn.Project = obj.Project;
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;

                    //? DETALLE
                    obj.Lines.Where(i => i.TreeType != "I").ToList().ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                        odn.Lines.Quantity = _item.Quantity;
                        if (_item.DiscPrcnt > 0)
                            odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                        odn.Lines.WarehouseCode = _item.WhsCode;
                        odn.Lines.TaxCode = "IGV";
                        odn.Lines.Currency = obj.Currency;

                        if (_item.BaseEntry != 0)
                        {
                            odn.Lines.BaseType = _item.BaseType;
                            odn.Lines.BaseEntry = _item.BaseEntry;
                            odn.Lines.BaseLine = _item.BaseLine;
                        }
                        //if (_item.TreeType == "S") odn.Lines.TreeType = BoItemTreeTypes.iNotATree;
                        /*odn.Lines.UserFields.Fields.Item("U_BF_CodKit").Value = _item.U_BF_CodKit;
                        odn.Lines.UserFields.Fields.Item("U_BF_InGiff").Value = Convert.ToInt16(_item.InGift);
                        odn.Lines.UserFields.Fields.Item("U_BF_InDscOrg").Value = Convert.ToInt16(_item.InDscOrg);
                        if (string.Compare(obj.Socied, "DX", false) == 0)
                        {
                            //odn.Lines.UserFields.Fields.Item("U_BIZ_DREC").Value = _item.U_BIZ_DREC ?? string.Empty;
                            if (string.Compare(_item.ItemCode, "60100000", false) == 0)
                            {
                                odn.Lines.UserFields.Fields.Item("U_BIZ_CORR").Value = _item.DocQut ?? string.Empty;
                                odn.Lines.BaseType = _item.BaseType;
                                odn.Lines.BaseEntry = _item.BaseEntry;
                                odn.Lines.BaseLine = _item.BaseLine;
                            }
                            if (_item.U_BF_FECH_EXPE != null)
                            {
                                odn.Lines.UserFields.Fields.Item("U_BF_FECH_EXPE").Value = Convert.ToDateTime(_item.U_BF_FECH_EXPE);
                                odn.Lines.UserFields.Fields.Item("U_BF_FECH_VENC").Value = Convert.ToDateTime(_item.U_BF_FECH_VENC);
                            }
                            odn.Lines.UserFields.Fields.Item("U_BIZ_CANT").Value = Convert.ToDouble(_item.U_BIZ_CANT);
                            odn.Lines.UserFields.Fields.Item("U_BIZ_UNPR").Value = _item.U_BIZ_UNPR ?? string.Empty;
                            odn.Lines.UserFields.Fields.Item("U_BIZ_FFAR").Value = _item.U_BIZ_FFAR ?? string.Empty;
                            odn.Lines.UserFields.Fields.Item("U_BIZ_GANA").Value = Convert.ToDouble(_item.U_BIZ_GANA);
                            odn.Lines.UserFields.Fields.Item("U_BIZ_ETI").Value = _item.U_BF_ABRE_ETIQ ?? string.Empty;
                        }
                        else
                        {
                            odn.Lines.UserFields.Fields.Item("U_StoDiBE").Value = Convert.ToDouble(_item.U_StoDiBE);
                            odn.Lines.UserFields.Fields.Item("U_BF_StoDiYo").Value = Convert.ToDouble(_item.U_BF_StoDiYo);
                            odn.Lines.UserFields.Fields.Item("U_U_BF_CompTot").Value = Convert.ToDouble(_item.U_U_BF_CompTot);
                        }*/

                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        odn.Lines.Add();
                    });

                    //? GASTO ADICIONAL (MOVILIDAD)
                    if (obj.TotalExpns > 0)
                    {
                        odn.Expenses.ExpenseCode = /*string.Compare(obj.Socied, "BT", false) == 0 ?*/ 1 /*: 9*/;
                        odn.Expenses.TaxCode = "IGV";
                        odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                        odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                        odn.Expenses.Add();
                    }

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD_PURCHASE";
                        ors.Command.Parameters.Item("@DscTable").Value = "OPOR o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void ModifyOfferSale(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oQuotations);

                    //? CABECERA
                    odn.GetByKey(obj.DocEntry);
                    odn.DocDueDate = obj.DocDueDate;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    odn.ShipToCode = obj.ShipToCode;
                    odn.PayToCode = obj.PayToCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;
                    odn.DocCurrency = obj.Currency;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    //odn.UserFields.Fields.Item("U_BIZ_LUEN").Value = obj.U_BIZ_LUEN;
                    //odn.UserFields.Fields.Item("U_BF_HOEN").Value = obj.U_BF_HOEN;
                    //odn.UserFields.Fields.Item("U_BF_HCFI").Value = obj.U_BF_HCFI;
                    //odn.UserFields.Fields.Item("U_BF_CODNI").Value = obj.U_BF_CODNI;
                    //odn.UserFields.Fields.Item("U_BIZ_SOLI").Value = obj.U_BIZ_SOLI;
                    //odn.UserFields.Fields.Item("U_BF_COCIT").Value = obj.U_BF_COCIT;
                    //odn.UserFields.Fields.Item("U_BIZ_CONTA").Value = obj.U_BIZ_CONTA;
                    //odn.UserFields.Fields.Item("U_BIZ_TPDO").Value = obj.U_BIZ_TPDO;
                    //odn.UserFields.Fields.Item("U_BF_PickRmrk").Value = obj.U_BF_PickRmrk;
                    //odn.UserFields.Fields.Item("U_BIZ_DOCU").Value = (string.Compare(obj.U_BIZ_DOCG, "01", false) == 0) ? "02" : "01";

                    //? REMOVER DETALLE
                    var lines = odn.Lines.Count;
                    for (int i = 0; i < lines; i++)
                    {
                        odn.Lines.SetCurrentLine(0);
                        odn.Lines.Delete();
                    }

                    //? AGREGAR DETALLE
                    obj.Lines.Where(i => i.TreeType != "I").ToList().ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                        odn.Lines.Quantity = _item.Quantity;
                        if (_item.DiscPrcnt > 0)
                            odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                        odn.Lines.WarehouseCode = _item.WhsCode;
                        odn.Lines.TaxCode = "IGV";
                        //odn.Lines.UserFields.Fields.Item("U_BF_CodKit").Value = _item.U_BF_CodKit;
                        //odn.Lines.UserFields.Fields.Item("U_StoDiBE").Value = Convert.ToDouble(_item.U_StoDiBE);
                        //odn.Lines.UserFields.Fields.Item("U_BF_StoDiYo").Value = Convert.ToDouble(_item.U_BF_StoDiYo);
                        //odn.Lines.UserFields.Fields.Item("U_U_BF_CompTot").Value = Convert.ToDouble(_item.U_U_BF_CompTot);
                        //odn.Lines.UserFields.Fields.Item("U_BF_InGiff").Value = Convert.ToInt16(_item.InGift);
                        //odn.Lines.UserFields.Fields.Item("U_BF_InDscOrg").Value = Convert.ToInt16(_item.InDscOrg);
                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        odn.Lines.Add();
                    });

                    //? GASTO ADICIONAL (MOVILIDAD)
                    odn.Expenses.ExpenseCode = /*string.Compare(obj.Socied, "BT", false) == 0 ? */1 /*: 9*/;
                    odn.Expenses.TaxCode = "IGV";
                    odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                    odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                    odn.Expenses.Add();

                    ocp.StartTransaction();
                    RetVal = odn.Update();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        /// <summary>
        /// MODIFICA LA ORDEN DE VENTA
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objs"></param>
        public void ModifyOrderSale(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                var bandC = false;
                var bandS = false;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oOrders);

                    //? CABECERA
                    odn.GetByKey(obj.DocEntry);
                    odn.DocDueDate = obj.DocDueDate;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    odn.ShipToCode = obj.ShipToCode;
                    odn.PayToCode = obj.PayToCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;
                    odn.DocCurrency = obj.Currency;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;
                    //odn.UserFields.Fields.Item("U_BIZ_LUEN").Value = obj.U_BIZ_LUEN;
                    obj.Lines.ForEach(a => {
                        if (a.ActivoC == "Y") bandC = true;
                    });
                    if (bandC) ModifyBorrador(obj, objs);

                    //? REMOVER DETALLE
                    var lines = odn.Lines.Count;
                    for (int i = 0; i < lines; i++)
                    {
                        odn.Lines.SetCurrentLine(0);
                        odn.Lines.Delete();
                    }

                    //? AGREGAR DETALLE
                    obj.Lines.Where(i => i.TreeType != "I").ToList().ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                        odn.Lines.Quantity = _item.Quantity;
                        if (_item.DiscPrcnt > 0)
                            odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);                        
                        odn.Lines.WarehouseCode = _item.WhsCode;
                        odn.Lines.TaxCode = "IGV";
                        //odn.Lines.UserFields.Fields.Item("U_BF_CodKit").Value = _item.U_BF_CodKit;
                        //odn.Lines.UserFields.Fields.Item("U_StoDiBE").Value = Convert.ToDouble(_item.U_StoDiBE);
                        //odn.Lines.UserFields.Fields.Item("U_BF_StoDiYo").Value = Convert.ToDouble(_item.U_BF_StoDiYo);
                        //odn.Lines.UserFields.Fields.Item("U_U_BF_CompTot").Value = Convert.ToDouble(_item.U_U_BF_CompTot);
                        //odn.Lines.UserFields.Fields.Item("U_BF_InGiff").Value = Convert.ToInt16(_item.InGift);
                        //odn.Lines.UserFields.Fields.Item("U_BF_InDscOrg").Value = Convert.ToInt16(_item.InDscOrg);
                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        odn.Lines.Add();
                    });

                    //? GASTO ADICIONAL (MOVILIDAD)
                    odn.Expenses.ExpenseCode = /*string.Compare(obj.Socied, "BT", false) == 0 ? */1 /*: 9*/;
                    odn.Expenses.TaxCode = "IGV";
                    odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                    odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                    odn.Expenses.Add();

                    ocp.StartTransaction();
                    RetVal = odn.Update();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void ModifyPurchaseOrder(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oPurchaseOrders);

                    //? CABECERA
                    odn.GetByKey(obj.DocEntry);
                    odn.DocDueDate = obj.DocDueDate;
                    odn.NumAtCard = obj.NumAtCard;
                    odn.DiscountPercent = Convert.ToDouble(obj.DiscPrcntTotal);
                    odn.ShipToCode = obj.ShipToCode;
                    odn.PayToCode = obj.PayToCode;
                    odn.PaymentGroupCode = obj.GroupNum;
                    odn.DocCurrency = obj.Currency;
                    odn.SalesPersonCode = obj.SlpCode;
                    odn.DocumentsOwner = obj.OwnerCode;
                    odn.Comments = (string.IsNullOrWhiteSpace(obj.Comments)) ? string.Empty : obj.Comments;
                    if (obj.CntctCode != 0)
                        odn.ContactPersonCode = obj.CntctCode;

                    //? REMOVER DETALLE
                    var lines = odn.Lines.Count;
                    for (int i = 0; i < lines; i++)
                    {
                        odn.Lines.SetCurrentLine(0);
                        odn.Lines.Delete();
                    }

                    //? AGREGAR DETALLE
                    obj.Lines.Where(i => i.TreeType != "I").ToList().ForEach(_item =>
                    {
                        odn.Lines.ItemCode = _item.ItemCode;
                        odn.Lines.ItemDescription = _item.ItemName;
                        odn.Lines.UnitPrice = Convert.ToDouble(_item.PriceBefDi);
                        odn.Lines.Quantity = _item.Quantity;
                        if (_item.DiscPrcnt > 0)
                            odn.Lines.DiscountPercent = Convert.ToDouble(_item.DiscPrcnt);
                        odn.Lines.WarehouseCode = _item.WhsCode;
                        odn.Lines.TaxCode = "IGV";
                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        odn.Lines.Add();
                    });

                    //? GASTO ADICIONAL (MOVILIDAD)
                    odn.Expenses.ExpenseCode = /*string.Compare(obj.Socied, "BT", false) == 0 ? */1 /*: 9*/;
                    odn.Expenses.TaxCode = "IGV";
                    odn.Expenses.LineTotal = Convert.ToDouble(obj.TotalExpns);
                    odn.Expenses.WTLiable = BoYesNoEnum.tNO;
                    odn.Expenses.Add();

                    ocp.StartTransaction();
                    RetVal = odn.Update();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        /// <summary>
        /// CANCELA LA ORDEN DE VENTA
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objs"></param>
        public void CancelOrderSale(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oOrders);
                    odn.GetByKey(obj.DocEntry);
                    ocp.StartTransaction();
                    RetVal = odn.Cancel();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void CancelOfferSale(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oQuotations);
                    odn.GetByKey(obj.DocEntry);
                    ocp.StartTransaction();
                    RetVal = odn.Cancel();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void CancelPurchaseOrder(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oPurchaseOrders);
                    odn.GetByKey(obj.DocEntry);
                    ocp.StartTransaction();
                    RetVal = odn.Cancel();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        public void CancelDeliveryNote(BEDocument obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oDeliveryNotes);
                    odn.GetByKey(obj.DocEntry);
                    ocp.StartTransaction();
                    RetVal = odn.Cancel();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        /// <summary>
        /// LISTA LAS ORDENES DE VENTA
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_ORDR(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_ORDR", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.CardCode, obep.CardName, obep.Project, obep.Id_Dire);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_OQUT_OFE(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_OQUT_OFE", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.CardCode, obep.CardName, obep.Project, obep.Id_Dire);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_OPOR(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_OPOR", obep.DateIn, obep.DateFi, obep.NumAtCard, obep.CardCode, obep.CardName, obep.Project, obep.Id_Dire);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// Lista de orden por numped
        /// </summary>
        /// <param name="obep"></param>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_ORDR_POR_NUMPED(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_ORDR_POR_NUMPED", obep.NumAtCard);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA EL DETALLE DE LAS ORDENES DE VENTA
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_RDR1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_RDR1", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_POR1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_POR1", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_QUT1_OFE(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_QUT1_OFE", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LAS COTIZACIONES PARA GENERAR LA OFERTA DE VENTA
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_LGOV(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_LGOV", obep.DateIn, obep.DateFi);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_PAGOSRECIBIDOS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_PAGOR_CLIENTE", obep.Internal, obep.CardCode, obep.DateIn);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader DXP_PAGOSEFECTUADOS(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("DXP_GET_PAGOF_CLIENTE", obep.Internal, obep.CardCode, obep.DateIn);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LAS ORDENES DE VENTA ABIERTAS RP'S
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_BORD(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_BORD", obep.Project, obep.CardCode, obep.NumAtCard, obep.DateIn, obep.DateFi);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA EL DETALLE DE LAS ORDENES DE VENTA ABIERTAS RP'S
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_BOR1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_BOR1", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// GUARDA LA OFERTA DE VENTA DE RPS
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objs"></param>
        public void SaveOfferSale(BEQuotation obj, List<BEQuotation> qlst, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (Documents)ocp.GetBusinessObject(BoObjectTypes.oQuotations);
                    odn.CardCode = obj.U_BIZ_COSN;
                    odn.CardName = obj.CardName;

                    odn.DocDate = obj.CreateDate;
                    odn.DocDueDate = obj.CreateDate;
                    odn.SalesPersonCode = Convert.ToInt32(obj.SlpCode);
                    odn.Comments = string.Empty;
                    //odn.UserFields.Fields.Item("U_BF_PickRmrk").Value = obj.U_PickRmrk;

                    //Detail Document
                    qlst.ForEach(lobj =>
                    {
                        odn.Lines.ItemCode = lobj.U_BIZ_CODR;
                        odn.Lines.ItemDescription = lobj.U_BIZ_NOMR;
                        odn.Lines.UnitPrice = Convert.ToDouble(lobj.U_BIZ_PREV);
                        odn.Lines.Quantity = 1;
                        odn.Lines.WarehouseCode = "YOB_PT";
                        odn.Lines.TaxCode = "IGV";
                        odn.Lines.WTLiable = BoYesNoEnum.tNO;
                        //odn.Lines.UserFields.Fields.Item("U_BIZ_CANT").Value = Convert.ToDouble(lobj.U_BIZ_CNTP);
                        //odn.Lines.UserFields.Fields.Item("U_BIZ_UNPR").Value = lobj.U_BIZ_UNPR;
                        //odn.Lines.UserFields.Fields.Item("U_BIZ_FFAR").Value = lobj.U_BF_FOFA ?? string.Empty;
                        //odn.Lines.UserFields.Fields.Item("U_BIZ_GANA").Value = Convert.ToDouble(lobj.U_BIZ_PMAR);
                        //odn.Lines.UserFields.Fields.Item("U_BIZ_DREC").Value = lobj.U_BF_DEET ?? string.Empty;
                        //odn.Lines.UserFields.Fields.Item("U_BIZ_GENE").Value = lobj.DocEntry.ToString();                        
                        odn.Lines.Add();
                    });

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                        obj.DocEntry = Convert.ToInt32(ocp.GetNewObjectKey());
                        var ors = (Recordset)ocp.GetBusinessObject(BoObjectTypes.BoRecordset);
                        ors.Command.Name = "OSCSP_OBJD";
                        ors.Command.Parameters.Item("@DscTable").Value = "OQUT o";
                        ors.Command.Parameters.Item("@DocEntry").Value = obj.DocEntry;
                        ors.Command.Execute();
                        ors.MoveFirst();
                        obj.DocNum = Convert.ToInt32(ors.Fields.Item(0).Value);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        /// <summary>
        /// LISTA LAS OFERTAS
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_OQUT(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_OQUT", obep.CardCode, obep.NumAtCard, obep.DateIn, obep.DateFi);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_ODLN2(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_ODLN2", obep.CardCode, obep.NumAtCard, obep.DateIn, obep.DateFi);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_OPDN2(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_OPDN2", obep.CardCode, obep.NumAtCard, obep.DateIn, obep.DateFi);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_DLN12(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_DLN12", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_PDN12(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_PDN12", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_ORDR2(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_ORDR2", obep.CardCode, obep.NumAtCard, obep.DateIn, obep.DateFi);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_OPOR2(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_OPOR2", obep.CardCode, obep.NumAtCard, obep.DateIn, obep.DateFi);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_RDR12(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_RDR12", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        public IDataReader Get_OSCSP_SRCH_POR12(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_POR12", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA EL DETALLE DE LAS OFERTAS
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_SRCH_QUT1(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_SRCH_QUT1", obep.DocEntry);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA LOS REGALOS
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_SCSP_LSRG_BFREGA(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("SCSP_LSRG_BFREGA");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }

        //?+ REPORTES
        /// <summary>
        /// CIERRE DE CAJA
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_RPCJ(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_RPCJ", obep.DateIn, obep.DateFi, obep.Project, obep.Socied, obep.Number);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// INVENTARIO
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_RPIN(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("PNPR_LIS_INVE", obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// Retorno de Descuento
        /// </summary>
        /// <param name="obep"></param>
        /// <returns></returns>
        public IDataReader Get_DSCTO(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("Return_Dscto",obep.Rate);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// LISTA DOCUMENTOS PENDIENTES POR PAGAR
        /// </summary>
        /// <returns></returns>
        public IDataReader Get_OSCSP_DVPP(BEParameters obep)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase(obep.Socied);
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("OSCSP_DVPP", obep.Project);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }


        //////Ingresado por Jose
        /// <summary>
        /// LISTA USUARIOS
        /// </summary>
        /// <param name="obep"></param>
        /// <returns></returns>
        public IDataReader Get_list_user_admin()
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase("ApplicationServices");
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("List_Usu");
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
        /// <summary>
        /// GUARDA EL CLIENTE JOSE
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objs"></param>
        public void SaveBusinessPartner_jos(BEBusinessPartner obj, object objs)
        {
            try
            {
                int RetVal = 0;
                int ErrCode = 0;
                string ErrMsg = null;
                var ocp = ((Company)objs);

                if (ocp.Connected)
                {
                    var odn = (BusinessPartners)ocp.GetBusinessObject(BoObjectTypes.oBusinessPartners);
                    odn.CardCode = obj.CardCode;
                    odn.CardType = BoCardTypes.cCustomer;
                    odn.CardName = obj.CardName;
                    odn.FederalTaxID = obj.LicTradNum;
                    odn.Phone1 = obj.Phone1;
                    odn.Cellular = obj.Cellular;
                    odn.EmailAddress = obj.E_Mail;
                    odn.PriceListNum = (obj.Socied == "BT") ? 13 : 11;
                    odn.GroupCode = 139;
                    odn.SalesPersonCode = 38;
                    odn.Territory = (obj.Socied == "BT") ? 4 : 6;
                    odn.Industry = 3;
                    odn.UserFields.Fields.Item("U_BPP_BPTP").Value = obj.U_BPP_BPTP;
                    odn.UserFields.Fields.Item("U_BPP_BPTD").Value = obj.U_BPP_BPTD;
                    odn.UserFields.Fields.Item("U_PN_FecNac").Value = obj.U_PN_FecNac;

                    ocp.StartTransaction();
                    RetVal = odn.Add();
                    if (RetVal != 0)
                    {
                        ocp.GetLastError(out ErrCode, out ErrMsg);
                        obj.Msg = ErrMsg;
                        if (ocp.InTransaction)
                            ocp.EndTransaction(BoWfTransOpt.wf_RollBack);
                        throw new ArgumentException(ErrMsg);
                    }
                    else
                    {
                        if (ocp.InTransaction)
                            ocp.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(obj.Msg))
                    obj.Msg = ex.Message;
            }
            finally
            {
                Dispose(false);
            }
        }
        //Verifica si hay stock en el almacen de muestras
        public IDataReader getStockItemCode(string itemCode)
        {
            try
            {
                odb = DatabaseFactory.CreateDatabase("BM");
                ocn = odb.CreateConnection();
                if (ocn.State == ConnectionState.Closed) ocn.Open();
                var ocmd = odb.GetStoredProcCommand("sp_Buscar_Stock_Prod", itemCode);
                ocmd.CommandTimeout = 2000;
                var ord = odb.ExecuteReader(ocmd);
                Dispose(false);
                return (ord);
            }
            finally
            {
                ocn.Close();
            }
        }
    }
}
