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
using winShootForItAuctions.Layers.ENTITIES;
using log4net;

namespace winShootForItAuctions.Layers.DAL
{
    internal class DALCategoriaBien : IDALCategoriaBien
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        
        /// <summary>
        /// Elimina una categoría de bien.
        /// </summary>
        /// <param name="idTipoBien"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void DeleteById(int idTipoBien)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspDeleteById";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdCategoria", idTipoBien);
                  
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
        /// Retorna todas las categorías de Bien registradas.
        /// </summary>
        /// <returns></returns>
        public async Task<List<TipoBien>> GetAllCategoriasAsync()
        {
            var command = new SqlCommand();
            string msg = "";
            List<TipoBien> categorias = new List<TipoBien>();
            TipoBien oTipoBien;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetAllCategoriaBien";
                    command = new SqlCommand(sql);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = await db.ExecuteReaderAsync(command, "TipoBien");

                    foreach (DataRow row in dataSet.Rows)
                    {
                        oTipoBien = new TipoBien();
                        oTipoBien.IdTipoBien = Convert.ToInt32(row["idTipo"]);
                        oTipoBien.Nombre = row["nombre"].ToString();
                        oTipoBien.Descripcion = row["descripcion"].ToString();

                        categorias.Add(oTipoBien);
                    }
                }

                return categorias;
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
        /// Retorna la categoría filtrada por el id.
        /// </summary>
        /// <param name="pIdTipoBien"></param>
        /// <returns></returns>
        public TipoBien GetCategoriaById(int pIdTipoBien)
        {
            var command = new SqlCommand();
            string msg = "";
            TipoBien oTipoBien = null;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetByIdCategoriaBien";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdTipoBien", pIdTipoBien);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "TipoBien");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oTipoBien = new TipoBien();
                        oTipoBien.IdTipoBien = Convert.ToInt32(row["idTipo"]);
                        oTipoBien.Nombre = row["nombre"].ToString();
                        oTipoBien.Descripcion = row["descripcion"].ToString();
                    }
                }

                return oTipoBien;
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
        /// Inserta una nueva categoría de bien.
        /// </summary>
        /// <param name="pCategoriaBien"></param>
        public void InsertarCategoriaBien(TipoBien pCategoriaBien)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspInsertarCategoriaBien";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pNombre", pCategoriaBien.Nombre);
                    command.Parameters.AddWithValue("@pDescripcion", pCategoriaBien.Descripcion);
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
