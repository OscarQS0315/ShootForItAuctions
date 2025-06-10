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

namespace winShootForItAuctions.Layers.DAL
{
    internal class DALSubasta : IDALSubasta
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private IBLLUsuario oBLLUsuario = new BLLUsuario();
        private IBLLBien oBLLBien = new BLLBien();
        private IDALUsuario oDALUsuario = new DALUsuario();

        /// <summary>
        /// Retorna todas las subastas actuales.
        /// </summary>
        /// <returns></returns>
        public List<Subasta> GetAllSubastas()
        {
            var command = new SqlCommand();
            string msg = "";
            List<Subasta> subastas = new List<Subasta>();
            Subasta oSubasta;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetAllSubastas";
                    command = new SqlCommand(sql);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oSubasta = new Subasta();
                        oSubasta.IdSubasta = row["idSubasta"].ToString();
                        oSubasta.Duenno = this.oBLLUsuario.GetById(row["idDuenno"].ToString());
                        oSubasta.Bien = this.oBLLBien.GetByIdBien(Convert.ToInt32(row["idBien"]), oSubasta.Duenno.IdUsuario);
                        oSubasta.FechaApertura = Convert.ToDateTime(row["fechaApertura"]);
                        oSubasta.HoraApertura = (TimeSpan)row["horaApertura"];
                        oSubasta.FechaCierre = Convert.ToDateTime(row["fechaCierre"]);
                        oSubasta.HoraCierre = (TimeSpan)row["horaCierre"];
                        oSubasta.Comision = Convert.ToDecimal(row["comision"]);
                        oSubasta.Incremento = Convert.ToDecimal(row["incremento"]);
                        if (row["ganador"] != null)
                        {
                            oSubasta.Ganador = this.oBLLUsuario.GetById(row["ganador"].ToString());
                        }
                        if (decimal.TryParse(row["totalOfertado"].ToString(), out decimal i))
                        {
                            oSubasta.TotalOfertado = i;
                        }
                        else
                        {
                            oSubasta.TotalOfertado = 0;
                        }
                        foreach (ETipoEstadoSubasta oEstado in Enum.GetValues(typeof(ETipoEstadoSubasta)))
                        {
                            if (oEstado.ToString() == row["estado"].ToString())
                            {
                                oSubasta.Estado = oEstado;
                            }
                        }
                        oSubasta.PrecioBase = Convert.ToDecimal(row["precioBase"]);
                        oSubasta.Clientes = this.oDALUsuario.GetAllUsuariosSubastas(oSubasta.IdSubasta);
                        oSubasta.PrecioBase = Convert.ToDecimal(row["precioBase"]);
                        oSubasta.Clientes = this.oDALUsuario.GetAllUsuariosSubastas(oSubasta.IdSubasta);
                        oSubasta.idDuenorRep = oSubasta.Duenno.IdUsuario;
                        oSubasta.idBienRep = oSubasta.Bien.IdBien.ToString();
                        oSubasta.descripcionBienRep = oSubasta.Bien.Descripcion;
                        oSubasta.estadoRep = oSubasta.Estado.ToString();
                        subastas.Add(oSubasta);
                    }
                }
                return subastas;
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
        /// Elimina un cliente de una subasta.
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <param name="pIdSubasta"></param>
        public void DeleteSubastaCliente(string pIdCliente, string pIdSubasta)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspDeleteSubasaCliente";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdSubasta", pIdSubasta);
                    command.Parameters.AddWithValue("@pIdCliente", pIdCliente);

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
        /// Retorna todas las subastas activas.
        /// </summary>
        /// <returns></returns>
        public List<Subasta> GetAllSubastasActivas()
        {
            var command = new SqlCommand();
            string msg = "";
            List<Subasta> subastas = new List<Subasta>();
            Subasta oSubasta;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetAllSubastasActivas";
                    command = new SqlCommand(sql);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oSubasta = new Subasta();
                        oSubasta.IdSubasta = row["idSubasta"].ToString();
                        oSubasta.Duenno = this.oBLLUsuario.GetById(row["idDuenno"].ToString());
                        oSubasta.Bien = this.oBLLBien.GetByIdBien(Convert.ToInt32(row["idBien"]), oSubasta.Duenno.IdUsuario);
                        oSubasta.FechaApertura = Convert.ToDateTime(row["fechaApertura"]);
                        oSubasta.HoraApertura = (TimeSpan)row["horaApertura"];
                        oSubasta.FechaCierre = Convert.ToDateTime(row["fechaCierre"]);
                        oSubasta.HoraCierre = (TimeSpan)row["horaCierre"];
                        oSubasta.Comision = Convert.ToDecimal(row["comision"]);
                        oSubasta.Incremento = Convert.ToDecimal(row["incremento"]);
                        if (row["ganador"] != null)
                        {
                            oSubasta.Ganador = this.oBLLUsuario.GetById(row["ganador"].ToString());
                        }
                        if (decimal.TryParse(row["totalOfertado"].ToString(), out decimal i))
                        {
                            oSubasta.TotalOfertado = i;
                        }
                        else
                        {
                            oSubasta.TotalOfertado = 0;
                        }
                        foreach (ETipoEstadoSubasta oEstado in Enum.GetValues(typeof(ETipoEstadoSubasta)))
                        {
                            if (oEstado.ToString() == row["estado"].ToString())
                            {
                                oSubasta.Estado = oEstado;
                            }
                        }
                        oSubasta.PrecioBase = Convert.ToDecimal(row["precioBase"]);
                        oSubasta.Clientes = this.oDALUsuario.GetAllUsuariosSubastas(oSubasta.IdSubasta);
                        subastas.Add(oSubasta);
                    }
                }
                return subastas;
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
        /// Retorna todas las subastas activas de manera asincronica.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Subasta>> GetAllSubastasAsync()
        {
            var command = new SqlCommand();
            string msg = "";
            List<Subasta> subastas = new List<Subasta>();
            Subasta oSubasta;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetAllSubastas";
                    command = new SqlCommand(sql);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oSubasta = new Subasta();
                        oSubasta.IdSubasta = row["idSubasta"].ToString();
                        oSubasta.Duenno = this.oBLLUsuario.GetById(row["idDuenno"].ToString());
                        oSubasta.Bien = await this.oBLLBien.GetByIdBienAsync(Convert.ToInt32(row["idBien"]), oSubasta.Duenno.IdUsuario);
                        oSubasta.FechaApertura = Convert.ToDateTime(row["fechaApertura"]);
                        oSubasta.HoraApertura = (TimeSpan)row["horaApertura"];
                        oSubasta.FechaCierre = Convert.ToDateTime(row["fechaCierre"]);
                        oSubasta.HoraCierre = (TimeSpan)row["horaCierre"];
                        oSubasta.Comision = Convert.ToDecimal(row["comision"]);
                        oSubasta.Incremento = Convert.ToDecimal(row["incremento"]);
                        if (row["ganador"] != null)
                        {
                            oSubasta.Ganador = this.oBLLUsuario.GetById(row["ganador"].ToString());
                        }
                        if (decimal.TryParse(row["totalOfertado"].ToString(), out decimal i))
                        {
                            oSubasta.TotalOfertado = i;
                        }
                        else
                        {
                            oSubasta.TotalOfertado = 0;
                        }
                        foreach (ETipoEstadoSubasta oEstado in Enum.GetValues(typeof(ETipoEstadoSubasta)))
                        {
                            if (oEstado.ToString() == row["estado"].ToString())
                            {
                                oSubasta.Estado = oEstado;
                            }
                        }
                        oSubasta.PrecioBase = Convert.ToDecimal(row["precioBase"]);
                        oSubasta.Clientes = this.oDALUsuario.GetAllUsuariosSubastas(oSubasta.IdSubasta);
                        subastas.Add(oSubasta);
                    }
                }
                return subastas;
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
        /// Retorna la subasta filtrada por el id de la subasta.
        /// </summary>
        /// <param name="pIdSubasta"></param>
        /// <returns></returns>
        public Subasta GetByIdSubasta(string pIdSubasta)
        {
            var command = new SqlCommand();
            string msg = "";

            Subasta oSubasta = null;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetSubastaByIdSubasta";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdSubasta", pIdSubasta);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oSubasta = new Subasta();
                        oSubasta.IdSubasta = row["idSubasta"].ToString();
                        oSubasta.Duenno = this.oBLLUsuario.GetById(row["idDuenno"].ToString());
                        oSubasta.Bien = this.oBLLBien.GetByIdBien(Convert.ToInt32(row["idBien"]), oSubasta.Duenno.IdUsuario);
                        oSubasta.FechaApertura = Convert.ToDateTime(row["fechaApertura"]);
                        oSubasta.HoraApertura = (TimeSpan)row["horaApertura"];
                        oSubasta.FechaCierre = Convert.ToDateTime(row["fechaCierre"]);
                        oSubasta.HoraCierre = (TimeSpan)row["horaCierre"];
                        oSubasta.Comision = Convert.ToDecimal(row["comision"]);
                        oSubasta.Incremento = Convert.ToDecimal(row["incremento"]);
                        if (row["ganador"] != null)
                        {
                            oSubasta.Ganador = this.oBLLUsuario.GetById(row["ganador"].ToString());
                        }
                        if (decimal.TryParse(row["totalOfertado"].ToString(), out decimal i))
                        {
                            oSubasta.TotalOfertado = i;
                        }
                        else
                        {
                            oSubasta.TotalOfertado = 0;
                        }
                        foreach (ETipoEstadoSubasta oEstado in Enum.GetValues(typeof(ETipoEstadoSubasta)))
                        {
                            if (oEstado.ToString() == row["estado"].ToString())
                            {
                                oSubasta.Estado = oEstado;
                            }
                        }
                        oSubasta.PrecioBase = Convert.ToDecimal(row["precioBase"]);
                        oSubasta.Clientes = this.oDALUsuario.GetAllUsuariosSubastas(oSubasta.IdSubasta);

                    }
                }
                return oSubasta;
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
        /// Retorna una subasta filtrada por el id de manera asincrónica.
        /// </summary>
        /// <param name="pIdSubasta"></param>
        /// <returns></returns>
        public async Task<Subasta> GetByIdSubastaAsync(string pIdSubasta)
        {
            var command = new SqlCommand();
            string msg = "";

            Subasta oSubasta = null;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetSubastaByIdSubasta";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdSubasta", pIdSubasta);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oSubasta = new Subasta();
                        oSubasta.IdSubasta = row["idSubasta"].ToString();
                        oSubasta.Duenno = this.oBLLUsuario.GetById(row["idDuenno"].ToString());
                        oSubasta.Bien = await this.oBLLBien.GetByIdBienAsync(Convert.ToInt32(row["idBien"]), oSubasta.Duenno.IdUsuario);
                        oSubasta.FechaApertura = Convert.ToDateTime(row["fechaApertura"]);
                        oSubasta.HoraApertura = (TimeSpan)row["horaApertura"];
                        oSubasta.FechaCierre = Convert.ToDateTime(row["fechaCierre"]);
                        oSubasta.HoraCierre = (TimeSpan)row["horaCierre"];
                        oSubasta.Comision = Convert.ToDecimal(row["comision"]);
                        oSubasta.Incremento = Convert.ToDecimal(row["incremento"]);
                        if (row["ganador"] != null)
                        {
                            oSubasta.Ganador = this.oBLLUsuario.GetById(row["ganador"].ToString());
                        }
                        if (decimal.TryParse(row["totalOfertado"].ToString(), out decimal i))
                        {
                            oSubasta.TotalOfertado = i;
                        }
                        else
                        {
                            oSubasta.TotalOfertado = 0;
                        }
                        foreach (ETipoEstadoSubasta oEstado in Enum.GetValues(typeof(ETipoEstadoSubasta)))
                        {
                            if (oEstado.ToString() == row["estado"].ToString())
                            {
                                oSubasta.Estado = oEstado;
                            }
                        }
                        oSubasta.PrecioBase = Convert.ToDecimal(row["precioBase"]);
                        oSubasta.Clientes = this.oDALUsuario.GetAllUsuariosSubastas(oSubasta.IdSubasta);

                    }
                }
                return oSubasta;
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
        /// Retorna todas las subastas activas de un cliente.
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <returns></returns>
        public List<Subasta> GetSubastaActivasByCliente(string pIdCliente)
        {
            var command = new SqlCommand();
            string msg = "";
            List<Subasta> subastas = new List<Subasta>();
            Subasta oSubasta;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetSubastaByCliente";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdCliente", pIdCliente);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oSubasta = new Subasta();
                        string idSubasta = row["idSubasta"].ToString();
                        oSubasta = this.GetByIdSubasta(idSubasta);
                        if (oSubasta.Estado == ETipoEstadoSubasta.ACTIVA)
                        {
                            subastas.Add(oSubasta);
                        }

                    }
                }
                return subastas;
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
        /// Retorna las subastas activas de un cliente de manera asincrónica.
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <returns></returns>
        public async Task<List<Subasta>> GetSubastaActivasByClienteAsync(string pIdCliente)
        {
            var command = new SqlCommand();
            string msg = "";
            List<Subasta> subastas = new List<Subasta>();
            Subasta oSubasta;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetSubastaByCliente";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdCliente", pIdCliente);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oSubasta = new Subasta();
                        string idSubasta = row["idSubasta"].ToString();
                        oSubasta = await this.GetByIdSubastaAsync(idSubasta);
                        if (oSubasta.Estado == ETipoEstadoSubasta.ACTIVA)
                        {
                            subastas.Add(oSubasta);
                        }

                    }
                }
                return subastas;
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
        /// Retorna una lista de subastas de un cliente.
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <returns></returns>
        public List<Subasta> GetSubastaByCliente(string pIdCliente)
        {
            var command = new SqlCommand();
            string msg = "";
            List<Subasta> subastas = new List<Subasta>();
            Subasta oSubasta;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetSubastaByCliente";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdCliente", pIdCliente);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oSubasta = new Subasta();
                        string idSubasta = row["idSubasta"].ToString();
                        oSubasta = this.GetByIdSubasta(idSubasta);
                        subastas.Add(oSubasta);
                    }
                }
                return subastas;
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
        /// Retorna una lista de subastas de un cliente de manera asincrónica.
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <returns></returns>
        public async Task<List<Subasta>> GetSubastaByClienteAsync(string pIdCliente)
        {
            var command = new SqlCommand();
            string msg = "";
            List<Subasta> subastas = new List<Subasta>();
            Subasta oSubasta;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetSubastaByCliente";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdCliente", pIdCliente);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oSubasta = new Subasta();
                        string idSubasta = row["idSubasta"].ToString();
                        oSubasta = await this.GetByIdSubastaAsync(idSubasta);
                        subastas.Add(oSubasta);
                    }
                }
                return subastas;
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
        /// Retorna la lista de subastas filtradas por el dueño.
        /// </summary>
        /// <param name="pIdDuenno"></param>
        /// <returns></returns>
        public List<Subasta> GetSubastaByDuenno(string pIdDuenno)
        {
            var command = new SqlCommand();
            string msg = "";
            List<Subasta> subastas = new List<Subasta>();
            Subasta oSubasta;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetSubastaByDuenno";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pDuenno", pIdDuenno);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oSubasta = new Subasta();
                        oSubasta.IdSubasta = row["idSubasta"].ToString();
                        oSubasta.Duenno = this.oBLLUsuario.GetById(row["idDuenno"].ToString());
                        oSubasta.Bien = this.oBLLBien.GetByIdBien(Convert.ToInt32(row["idBien"]), oSubasta.Duenno.IdUsuario);
                        oSubasta.FechaApertura = Convert.ToDateTime(row["fechaApertura"]);
                        oSubasta.HoraApertura = (TimeSpan)row["horaApertura"];
                        oSubasta.FechaCierre = Convert.ToDateTime(row["fechaCierre"]);
                        oSubasta.HoraCierre = (TimeSpan)row["horaCierre"];
                        oSubasta.Comision = Convert.ToDecimal(row["comision"]);
                        oSubasta.Incremento = Convert.ToDecimal(row["incremento"]);
                        if (row["ganador"] != null)
                        {
                            oSubasta.Ganador = this.oBLLUsuario.GetById(row["ganador"].ToString());
                        }
                        if (decimal.TryParse(row["totalOfertado"].ToString(), out decimal i))
                        {
                            oSubasta.TotalOfertado = i;
                        }
                        else
                        {
                            oSubasta.TotalOfertado = 0;
                        }

                        oSubasta.PrecioBase = Convert.ToDecimal(row["precioBase"]);
                        foreach (ETipoEstadoSubasta oEstado in Enum.GetValues(typeof(ETipoEstadoSubasta)))
                        {
                            if (oEstado.ToString() == row["estado"].ToString())
                            {
                                oSubasta.Estado = oEstado;
                            }
                        }
                        subastas.Add(oSubasta);
                    }
                }
                return subastas;
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
        /// Retorna una lista de subasta filtrada por dueño de manera asincrónica.
        /// </summary>
        /// <param name="pIdDuenno"></param>
        /// <returns></returns>
        public async Task<List<Subasta>> GetSubastaByDuennoAsync(string pIdDuenno)
        {
            var command = new SqlCommand();
            string msg = "";
            List<Subasta> subastas = new List<Subasta>();
            Subasta oSubasta;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetSubastaByDuenno";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pDuenno", pIdDuenno);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = await db.ExecuteReaderAsync(command, "Subastas");

                    foreach (DataRow row in dataSet.Rows)
                    {
                        oSubasta = new Subasta();
                        oSubasta.IdSubasta = row["idSubasta"].ToString();
                        oSubasta.Duenno = this.oBLLUsuario.GetById(row["idDuenno"].ToString());
                        oSubasta.Bien = await this.oBLLBien.GetByIdBienAsync(Convert.ToInt32(row["idBien"]), oSubasta.Duenno.IdUsuario);
                        oSubasta.FechaApertura = Convert.ToDateTime(row["fechaApertura"]);
                        oSubasta.HoraApertura = (TimeSpan)row["horaApertura"];
                        oSubasta.FechaCierre = Convert.ToDateTime(row["fechaCierre"]);
                        oSubasta.HoraCierre = (TimeSpan)row["horaCierre"];
                        oSubasta.Comision = Convert.ToDecimal(row["comision"]);
                        oSubasta.Incremento = Convert.ToDecimal(row["incremento"]);
                        if (row["ganador"] != null)
                        {
                            oSubasta.Ganador = this.oBLLUsuario.GetById(row["ganador"].ToString());
                        }
                        if (decimal.TryParse(row["totalOfertado"].ToString(), out decimal i))
                        {
                            oSubasta.TotalOfertado = i;
                        }
                        else
                        {
                            oSubasta.TotalOfertado = 0;
                        }

                        oSubasta.PrecioBase = Convert.ToDecimal(row["precioBase"]);
                        foreach (ETipoEstadoSubasta oEstado in Enum.GetValues(typeof(ETipoEstadoSubasta)))
                        {
                            if (oEstado.ToString() == row["estado"].ToString())
                            {
                                oSubasta.Estado = oEstado;
                            }
                        }
                        subastas.Add(oSubasta);
                    }
                }
                return subastas;
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
        /// Inserta una nueva subasta.
        /// </summary>
        /// <param name="pSubasta"></param>
        public void Insert(Subasta pSubasta)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspInsertSubasta";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdSubasta", pSubasta.IdSubasta);
                    command.Parameters.AddWithValue("@pIdDuenno", pSubasta.Duenno.IdUsuario);
                    command.Parameters.AddWithValue("@pIdBien", pSubasta.Bien.IdBien);
                    command.Parameters.AddWithValue("@pFechaApertura", pSubasta.FechaApertura);
                    command.Parameters.AddWithValue("@pHoraApertura", pSubasta.HoraApertura);
                    command.Parameters.AddWithValue("@pFechaCierre", pSubasta.FechaCierre);
                    command.Parameters.AddWithValue("@pHoraCierre", pSubasta.HoraCierre);
                    command.Parameters.AddWithValue("@pComision", pSubasta.Comision);
                    command.Parameters.AddWithValue("@pIncremento", pSubasta.Incremento);
                    command.Parameters.AddWithValue("@pPrecioBase", pSubasta.Bien.PrecioBaseDolares);
                    command.Parameters.AddWithValue("@pEstado", pSubasta.Estado.ToString());

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
        /// Inserta un cliente cuando participa en una subasta.
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <param name="pIdSubasta"></param>
        public void InsertClienteSubasta(string pIdCliente, string pIdSubasta)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspInsertSubastaCliente";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdSubasta", pIdSubasta);
                    command.Parameters.AddWithValue("@pIdCliente", pIdCliente);

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
        /// Actualiza la subasta.
        /// </summary>
        /// <param name="pSubasta"></param>
        public void Update(Subasta pSubasta)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspUpdateSubasta";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdSubasta", pSubasta.IdSubasta);
                    command.Parameters.AddWithValue("@pIdDuenno", pSubasta.Duenno.IdUsuario);
                    command.Parameters.AddWithValue("@pIdBien", pSubasta.Bien.IdBien);
                    command.Parameters.AddWithValue("@pFechaApertura", pSubasta.FechaApertura);
                    command.Parameters.AddWithValue("@pHoraApertura", pSubasta.HoraApertura);
                    command.Parameters.AddWithValue("@pFechaCierre", pSubasta.FechaCierre);
                    command.Parameters.AddWithValue("@pHoraCierre", pSubasta.HoraCierre);
                    command.Parameters.AddWithValue("@pComision", pSubasta.Comision);
                    command.Parameters.AddWithValue("@pIncremento", pSubasta.Incremento);
                    command.Parameters.AddWithValue("@pTotalOfertado", pSubasta.TotalOfertado);
                    command.Parameters.AddWithValue("@pPrecioBase", pSubasta.Bien.PrecioBaseDolares);
                    command.Parameters.AddWithValue("@pEstado", pSubasta.Estado.ToString());
                    if (pSubasta.Ganador != null)
                    {
                        command.Parameters.AddWithValue("@pGanador", pSubasta.Ganador.IdUsuario);

                    }
                    else
                    {
                        command.Parameters.AddWithValue("@pGanador", DBNull.Value);
                    }
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
        /// Retorna la subasta filtrada por el id del bien.
        /// </summary>
        /// <param name="pIdBien"></param>
        /// <returns></returns>
        public Subasta GetSubastaByBien(int pIdBien)
        {
            var command = new SqlCommand();
            string msg = "";

            Subasta oSubasta = null;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetSubastaByBien";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdBien", pIdBien);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Subastas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oSubasta = new Subasta();
                        oSubasta.IdSubasta = row["idSubasta"].ToString();
                        oSubasta.Duenno = this.oBLLUsuario.GetById(row["idDuenno"].ToString());
                        oSubasta.Bien = this.oBLLBien.GetByIdBien(Convert.ToInt32(row["idBien"]), oSubasta.Duenno.IdUsuario);
                        oSubasta.FechaApertura = Convert.ToDateTime(row["fechaApertura"]);
                        oSubasta.HoraApertura = (TimeSpan)row["horaApertura"];
                        oSubasta.FechaCierre = Convert.ToDateTime(row["fechaCierre"]);
                        oSubasta.HoraCierre = (TimeSpan)row["horaCierre"];
                        oSubasta.Comision = Convert.ToDecimal(row["comision"]);
                        oSubasta.Incremento = Convert.ToDecimal(row["incremento"]);
                        if (row["ganador"] != null)
                        {
                            oSubasta.Ganador = this.oBLLUsuario.GetById(row["ganador"].ToString());
                        }
                        if (decimal.TryParse(row["totalOfertado"].ToString(), out decimal i))
                        {
                            oSubasta.TotalOfertado = i;
                        }
                        else
                        {
                            oSubasta.TotalOfertado = 0;
                        }
                        foreach (ETipoEstadoSubasta oEstado in Enum.GetValues(typeof(ETipoEstadoSubasta)))
                        {
                            if (oEstado.ToString() == row["estado"].ToString())
                            {
                                oSubasta.Estado = oEstado;
                            }
                        }
                        oSubasta.PrecioBase = Convert.ToDecimal(row["precioBase"]);
                        oSubasta.Clientes = this.oDALUsuario.GetAllUsuariosSubastas(oSubasta.IdSubasta);
                        oSubasta.PrecioBase = Convert.ToDecimal(row["precioBase"]);
                        oSubasta.Clientes = this.oDALUsuario.GetAllUsuariosSubastas(oSubasta.IdSubasta);
                        oSubasta.idDuenorRep = oSubasta.Duenno.IdUsuario;
                        oSubasta.idBienRep = oSubasta.Bien.IdBien.ToString();
                        oSubasta.descripcionBienRep = oSubasta.Bien.Descripcion;
                        oSubasta.estadoRep = oSubasta.Estado.ToString();

                    }
                }
                return oSubasta;
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
    }
}
