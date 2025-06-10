using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Enums;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Util;

namespace winShootForItAuctions.Layers.DAL
{
    internal class DALFactura : IDALFactura
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private IBLLSubasta oBLLSubasta = new BLLSubasta();
        private IBLLUsuario oBLLUsuario = new BLLUsuario();

        /// <summary>
        /// Retorna todas las facturas actuales.
        /// </summary>
        /// <returns></returns>
        public List<Factura> GetAll() 
        {
            var command = new SqlCommand();
            string msg = "";
            List<Factura> facturas = new List<Factura>();
            Factura oFactura;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetAllFacturas";
                    command = new SqlCommand(sql);
                   
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oFactura = new Factura();
                        oFactura.IdFactura = row["idFactura"].ToString();
                        oFactura.Subasta = this.oBLLSubasta.GetByIdSubasta(row["idSubasta"].ToString());
                        oFactura.Cliente = this.oBLLUsuario.GetById(row["idCliente"].ToString());
                        oFactura.Duenno = this.oBLLUsuario.GetById(row["idDuenno"].ToString());
                        oFactura.MontoDolares = Convert.ToDecimal(row["montoDolares"]);
                        oFactura.MontoColones = Convert.ToDecimal(row["montoColones"]);
                        oFactura.Total = Convert.ToDecimal(row["total"]);
                        oFactura.Comision = Convert.ToDouble(row["comision"]);
                        oFactura.IVA = Convert.ToDouble(row["IVA"]);
                        foreach (ETipoEstadoFactura oTipo in Enum.GetValues(typeof(ETipoEstadoFactura)))
                        {
                            if (oTipo.ToString() == row["estado"].ToString())
                            {
                                oFactura.Estado = oTipo;
                            }
                        }
                        oFactura.Fecha = Convert.ToDateTime(row["fecha"]);
                        if(oFactura.Estado == ETipoEstadoFactura.PENDIENTE)
                        {
                            oFactura.Banco = "N/A";
                            oFactura.MetodoPago = "N/A";
                        }
                        else
                        {
                            oFactura.Banco = row["banco"].ToString();
                            oFactura.MetodoPago = row["metodoPago"].ToString();
                        }
                        oFactura.idBienRep = oFactura.Subasta.Bien.IdBien.ToString();
                        oFactura.idSubastasRep = oFactura.Subasta.IdSubasta.ToString();
                        oFactura.idClienteRep = oFactura.Cliente.IdUsuario.ToString();
                        oFactura.idDuennoRep = oFactura.Duenno.IdUsuario.ToString(); 
                        oFactura.descripcionBienRep = oFactura.Subasta.Bien.Descripcion.ToString();
                        oFactura.estadoRep = oFactura.Estado.ToString();
                        facturas.Add(oFactura);
                    }
                }
                return facturas;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                MessageBox.Show(msg.ToSqlServerDetailError(er));
                return null;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return null;
            }
        }
        /// <summary>
        /// Retorna todas las facturas filtradas por un rango de fechas.
        /// </summary>
        /// <param name="pFechaInicio"></param>
        /// <param name="pFechaFinal"></param>
        /// <returns></returns>
        public List<Factura> GetAllFacturasByFecha(DateTime pFechaInicio, DateTime pFechaFinal)
        {
            var command = new SqlCommand();
            string msg = "";
            List<Factura> facturas = new List<Factura>();
            Factura oFactura;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetAllFacturasByFecha";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pFechaInicio", pFechaInicio);
                    command.Parameters.AddWithValue("@pFechaFinal", pFechaFinal);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oFactura = new Factura();
                        oFactura.IdFactura = row["idFactura"].ToString();
                        oFactura.Subasta = this.oBLLSubasta.GetByIdSubasta(row["idSubasta"].ToString());
                        oFactura.Cliente = this.oBLLUsuario.GetById(row["idCliente"].ToString());
                        oFactura.Duenno = this.oBLLUsuario.GetById(row["idDuenno"].ToString());
                        oFactura.MontoDolares = Convert.ToDecimal(row["montoDolares"]);
                        oFactura.MontoColones = Convert.ToDecimal(row["montoColones"]);
                        oFactura.Total = Convert.ToDecimal(row["total"]);
                        oFactura.Comision = Convert.ToDouble(row["comision"]);
                        oFactura.IVA = Convert.ToDouble(row["IVA"]);
                        foreach (ETipoEstadoFactura oTipo in Enum.GetValues(typeof(ETipoEstadoFactura)))
                        {
                            if (oTipo.ToString() == row["estado"].ToString())
                            {
                                oFactura.Estado = oTipo;
                            }
                        }
                        oFactura.Fecha = Convert.ToDateTime(row["fecha"]);
                        if (oFactura.Estado == ETipoEstadoFactura.PENDIENTE)
                        {
                            oFactura.Banco = "N/A";
                            oFactura.MetodoPago = "N/A";
                        }
                        else
                        {
                            oFactura.Banco = row["banco"].ToString();
                            oFactura.MetodoPago = row["metodoPago"].ToString();
                        }
                        oFactura.idBienRep = oFactura.Subasta.Bien.IdBien.ToString();
                        oFactura.idSubastasRep = oFactura.Subasta.IdSubasta.ToString();
                        oFactura.idClienteRep = oFactura.Cliente.IdUsuario.ToString();
                        oFactura.idDuennoRep = oFactura.Duenno.IdUsuario.ToString();
                        oFactura.descripcionBienRep = oFactura.Subasta.Bien.Descripcion.ToString();
                        oFactura.estadoRep = oFactura.Estado.ToString();    
                        facturas.Add(oFactura);
                    }
                }
                return facturas;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                MessageBox.Show(msg.ToSqlServerDetailError(er));
                return null;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return null;
            }
        }
        /// <summary>
        /// Retorna las facturas pendientes filtradas por el id del cliente.
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <returns></returns>
        public List<Factura> GetFacturasPendientesByCliente(string pIdCliente)
        {
            var command = new SqlCommand();
            string msg = "";
            List<Factura> facturas = new List<Factura>();
            Factura oFactura;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetFacturasPendientesByCliente";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdCliente", pIdCliente);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oFactura = new Factura();
                        oFactura.IdFactura = row["idFactura"].ToString();
                        oFactura.Subasta = this.oBLLSubasta.GetByIdSubasta(row["idSubasta"].ToString());
                        oFactura.Cliente = this.oBLLUsuario.GetById(row["idCliente"].ToString());
                        oFactura.Duenno = this.oBLLUsuario.GetById(row["idDuenno"].ToString());
                        oFactura.MontoDolares = Convert.ToDecimal(row["montoDolares"]);
                        oFactura.MontoColones = Convert.ToDecimal(row["montoColones"]);
                        oFactura.Total = Convert.ToDecimal(row["total"]);
                        oFactura.Comision = Convert.ToDouble(row["comision"]);
                        oFactura.IVA = Convert.ToDouble(row["IVA"]);
                        foreach(ETipoEstadoFactura oTipo in Enum.GetValues(typeof(ETipoEstadoFactura)))
                        {
                            if (oTipo.ToString() == row["estado"].ToString())
                            {
                                oFactura.Estado = oTipo;
                            }
                        }
                        oFactura.Fecha = Convert.ToDateTime(row["fecha"]);
                        facturas.Add(oFactura);
                    }
                }
                return facturas;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                MessageBox.Show(msg.ToSqlServerDetailError(er));
                return null;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return null;
            }
        }
        /// <summary>
        /// Retorna las facturas pendientes de un cliente filtrada por un rango de fechas.
        /// </summary>
        /// <param name="pFechaInicio"></param>
        /// <param name="pFechaFinal"></param>
        /// <param name="pIdCliente"></param>
        /// <returns></returns>
        public List<Factura> GetFacturasPendientesByFecha(DateTime pFechaInicio, DateTime pFechaFinal, string pIdCliente)
        {
            var command = new SqlCommand();
            string msg = "";
            List<Factura> facturas = new List<Factura>();
            Factura oFactura;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetFacturasPendientesByFecha";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pFechaInicio", pFechaInicio);
                    command.Parameters.AddWithValue("@pFechaFinal", pFechaFinal);
                    command.Parameters.AddWithValue("@pIdCliente", pIdCliente);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oFactura = new Factura();
                        oFactura.IdFactura = row["idFactura"].ToString();
                        oFactura.Subasta = this.oBLLSubasta.GetByIdSubasta(row["idSubasta"].ToString());
                        oFactura.Cliente = this.oBLLUsuario.GetById(row["idCliente"].ToString());
                        oFactura.Duenno = this.oBLLUsuario.GetById(row["idDuenno"].ToString());
                        oFactura.MontoDolares = Convert.ToDecimal(row["montoDolares"]);
                        oFactura.MontoColones = Convert.ToDecimal(row["montoColones"]);
                        oFactura.Total = Convert.ToDecimal(row["total"]);
                        oFactura.Comision = Convert.ToDouble(row["comision"]);
                        oFactura.IVA = Convert.ToDouble(row["IVA"]);
                        foreach (ETipoEstadoFactura oTipo in Enum.GetValues(typeof(ETipoEstadoFactura)))
                        {
                            if (oTipo.ToString() == row["estado"].ToString())
                            {
                                oFactura.Estado = oTipo;
                            }
                        }
                        oFactura.Fecha = Convert.ToDateTime(row["fecha"]);
                        facturas.Add(oFactura);
                    }
                }
                return facturas;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                MessageBox.Show(msg.ToSqlServerDetailError(er));
                return null;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return null;
            }
        }
        /// <summary>
        /// Inserta una nueva factura pendiente.
        /// </summary>
        /// <param name="pFactura"></param>
        public void InsertFacturaPendiente(Factura pFactura)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspInsertarFacturaPendiente";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdFactura", pFactura.IdFactura);
                    command.Parameters.AddWithValue("@pIdSubasta", pFactura.Subasta.IdSubasta);
                    command.Parameters.AddWithValue("@pIdCliente", pFactura.Cliente.IdUsuario);
                    command.Parameters.AddWithValue("@pIdDuenno", pFactura.Duenno.IdUsuario);
                    command.Parameters.AddWithValue("@pFecha", pFactura.Fecha);
                    command.Parameters.AddWithValue("@pMontoDolares", pFactura.MontoDolares);
                    command.Parameters.AddWithValue("@pMontoColones", pFactura.MontoColones);
                    command.Parameters.AddWithValue("@pTotal", pFactura.Total);
                    command.Parameters.AddWithValue("@pComision", pFactura.Comision);
                    command.Parameters.AddWithValue("@pIVA", pFactura.IVA);
                    command.Parameters.AddWithValue("@pEstado", pFactura.Estado.ToString());

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = sql;
                    db.ExecuteNonQuery(command);


                }
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                MessageBox.Show(msg.ToSqlServerDetailError(er));
                return;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
        }
        /// <summary>
        /// Actualiza una factura a cancelada.
        /// </summary>
        /// <param name="pFactura"></param>
        public void UpdateFacturaCancelada(Factura pFactura)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspUpdateFacturaCancelada";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdFactura", pFactura.IdFactura);
                    command.Parameters.AddWithValue("@pBanco", pFactura.Banco);
                    command.Parameters.AddWithValue("@pMetodoPago", pFactura.MetodoPago);
                    command.Parameters.AddWithValue("@pXmlFactura", Utilitarios.ConvertirXML(pFactura.XMLFactura));
                    command.Parameters.AddWithValue("@pEstado", pFactura.Estado.ToString());

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = sql;
                    db.ExecuteNonQuery(command);


                }
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                MessageBox.Show(msg.ToSqlServerDetailError(er));
                return;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
        }
    }
}
