using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Enums;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using log4net;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Layers.DAL
{
    internal class DALParametro : IDALParametro
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        /// <summary>
        /// Devuelve el porcentaje del IVA actual.
        /// </summary>
        /// <returns></returns>
        public double GetIVA()
        {
            var command = new SqlCommand();
            string msg = "";
            double IVA = 0;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetIVA";
                    command = new SqlCommand(sql);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Parametro");
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        IVA = Convert.ToDouble(row["valor"].ToString());
                    }
                }
                return IVA;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                MessageBox.Show(msg.ToSqlServerDetailError(er));
                return -1;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return -1;
            }
        }
        /// <summary>
        /// Retorna el porcentaje de comision actual.
        /// </summary>
        /// <returns></returns>
        public double GetPorcentajeComision()
        {
            var command = new SqlCommand();
            string msg = "";
            double comision = 0;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetComision";
                    command = new SqlCommand(sql);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Parametro");
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        comision = Convert.ToDouble(row["valor"].ToString());
                    }
                }
                return comision;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                MessageBox.Show(msg.ToSqlServerDetailError(er));
                return -1;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return -1;
            }
        }
        /// <summary>
        /// Actualiza el porcentaje de comision.
        /// </summary>
        /// <param name="pNuevaComision"></param>
        public void UpdateComision(double pNuevaComision)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspUpdateComision";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pNuevaComision", pNuevaComision);
                    
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
        /// Actualiza el IVA.
        /// </summary>
        /// <param name="pNuevoIVA"></param>
        public void UpdateIVA(double pNuevoIVA)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspUpdateIVA";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pNuevoIVA", pNuevoIVA);

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
