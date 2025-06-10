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
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Util;
using log4net;
using System.Drawing;

namespace winShootForItAuctions.Layers.DAL
{
    internal class DALFotografia : IDALFotografia
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        /// <summary>
        /// Borra la fotografia segun el id del bien.
        /// </summary>
        /// <param name="pIdBien"></param>
        /// <param name="pFotografia"></param>
        public void Delete(int pIdBien, Fotografia pFotografia)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspDeleteFotografia";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdBien", pIdBien);
                    command.Parameters.AddWithValue("@pIdFotografia", pFotografia.IdFotografia);

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
        /// Retorna todas las fotografias filtradas por el id del bien.
        /// </summary>
        /// <param name="pIdBien"></param>
        /// <returns></returns>
        public List<Fotografia> GetAllFotografia(int pIdBien)
        {
            var command = new SqlCommand();
            string msg = "";
            List<Fotografia> fotos = new List<Fotografia>();
            Fotografia oFoto;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetFotosByIdBien";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdBien", pIdBien);


                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet =  db.ExecuteReader(command, "Fotos");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oFoto = new Fotografia();

                        oFoto.IdFotografia = Convert.ToInt32(row["idFotografia"]);
                        oFoto.Imagen = (byte[])row["imagen"];
                        fotos.Add(oFoto);
                    }
                }

                return fotos;
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
        /// Inserta una nueva fotografia.
        /// </summary>
        /// <param name="pFotografia"></param>
        /// <param name="pIdBien"></param>
        public void Insert(Fotografia pFotografia, int pIdBien)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspInsertFotografia";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdBien", pIdBien);
                    command.Parameters.AddWithValue("@pImagen", pFotografia.Imagen.ToArray());

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
