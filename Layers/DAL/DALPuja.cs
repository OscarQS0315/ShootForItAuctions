using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Layers.BLL;

namespace winShootForItAuctions.Layers.DAL
{
    internal class DALPuja : IDALPuja
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private IBLLSubasta oBLLSubasta = new BLLSubasta();
        private IBLLUsuario oBLLUsuario = new BLLUsuario();
        /// <summary>
        /// Devuelve las pujas de una subasta en específico.
        /// </summary>
        /// <param name="pIdSubasta"></param>
        /// <returns></returns>
        public async Task<List<Puja>> GetAllPujas(string pIdSubasta)
        {
            var command = new SqlCommand();
            string msg = "";
            List<Puja> pujas = new List<Puja>();
            Puja oPuja;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetAllPujas";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdSubasta", pIdSubasta);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = await db.ExecuteReaderAsync(command, "Pujas");

                    foreach (DataRow row in dataSet.Rows)
                    {
                        oPuja = new Puja();
                        oPuja.IdPuja = Convert.ToInt32(row["idPuja"]);
                        oPuja.IdSubasta = row["idSubasta"].ToString();
                        oPuja.Cliente = this.oBLLUsuario.GetById(row["idente"].ToString());
                        oPuja.Monto = Convert.ToDecimal(row["monto"]);
                        oPuja.Fecha = Convert.ToDateTime(row["fecha"]);
                        pujas.Add(oPuja);
                    }
                }
                return pujas;
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
        /// Retorna la última puja realizada.
        /// </summary>
        /// <param name="pIdSubasta"></param>
        /// <returns></returns>
        public Puja GetUltimaPuja(string pIdSubasta)
        {
            var command = new SqlCommand();
            string msg = "";
            
            Puja oPuja = null;  
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetUltimaPuja";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdSubasta", pIdSubasta);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Pujas");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oPuja = new Puja();
                        oPuja.IdPuja = Convert.ToInt32(row["idPuja"]);
                        oPuja.IdSubasta = row["idSubasta"].ToString();
                        oPuja.Cliente = this.oBLLUsuario.GetById(row["idente"].ToString());
                        oPuja.Monto = Convert.ToDecimal(row["monto"]);
                        oPuja.Fecha = Convert.ToDateTime(row["fecha"]);
                  
                    }
                }
                return oPuja;
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
        /// Inserta una puja en la subasta correspondiente.
        /// </summary>
        /// <param name="pIdSubasta"></param>
        /// <param name="pIdCliente"></param>
        /// <param name="pMonto"></param>
        /// <param name="pFecha"></param>
        public void Insert(string pIdSubasta, string pIdCliente, decimal pMonto, DateTime pFecha)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspInsertPuja";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdSubasta", pIdSubasta);
                    command.Parameters.AddWithValue("@pIdCliente", pIdCliente);
                    command.Parameters.AddWithValue("@pMonto", pMonto);
                    command.Parameters.AddWithValue("@pFecha", pFecha);
                  

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = sql;
                    List<IDbCommand> list = new List<IDbCommand>();
                    list.Add(command);
                    db.ExecuteNonQuery(list, IsolationLevel.ReadCommitted);
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
