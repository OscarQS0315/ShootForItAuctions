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
using log4net;
using winShootForItAuctions.Util;

namespace winShootForItAuctions.Layers.DAL
{
    internal class DALBien : IDALBien
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        IDALFotografia oDALFotografia = new DALFotografia();
        public void Delete(Bien pBien, string pIdDuenno)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Retorna un bien filtrado por el id del bien y el del dueño
        /// </summary>
        /// <param name="pIdBien"></param>
        /// <param name="pIdDuenno"></param>
        /// <returns></returns>
        public Bien GetByIdBien(int pIdBien, string pIdDuenno)
        {
            IDALCategoriaBien oDALCategoriaBien = new DALCategoriaBien();
            var command = new SqlCommand();
            string msg = "";

            Bien oBien = new Bien();
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspBienGetByIdDuenno";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdDuenno", pIdDuenno);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Bien");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oBien = new Bien();
                        oBien.IdBien = Convert.ToInt32(row["idBien"]);
                        oBien.Descripcion = row["descripcion"].ToString();
                        oBien.Tipo = oDALCategoriaBien.GetCategoriaById(Convert.ToInt32(row["idTipo"].ToString()));
                        oBien.PrecioBaseDolares = Convert.ToDecimal(row["precioBaseDolares"]);
                        oBien.PrecioVentaDirectaDolares = Convert.ToDecimal(row["precioVentaDirectaDolares"]);

                        

                        foreach (ETipoEstadoBien oTipo in Enum.GetValues(typeof(ETipoEstadoBien)))
                        {
                            if (row["estado"].ToString() == oTipo.ToString())
                            {
                                oBien.Estado = oTipo;
                            }
                        }

                        oBien.Fotografias = oDALFotografia.GetAllFotografia(oBien.IdBien);
                        if (oBien.IdBien == pIdBien)
                        {
                            break;
                        }
                    }
                }

                return oBien;
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
        /// Retorna todos los bienes.
        /// </summary>
        /// <returns></returns>
        public List<Bien> GetAll()
        {
            IDALCategoriaBien oDALCategoriaBien = new DALCategoriaBien();
            var command = new SqlCommand();
            string msg = "";
            List<Bien> bienes = new List<Bien>();
            Bien oBien = new Bien();
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetAllBienes";
                    command = new SqlCommand(sql);
               
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Bien");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oBien = new Bien();
                        oBien.IdBien = Convert.ToInt32(row["idBien"]);
                        oBien.Descripcion = row["descripcion"].ToString();
                        oBien.Tipo = oDALCategoriaBien.GetCategoriaById(Convert.ToInt32(row["idTipo"].ToString()));
                        oBien.PrecioBaseDolares = Convert.ToDecimal(row["precioBaseDolares"]);
                        oBien.PrecioVentaDirectaDolares = Convert.ToDecimal(row["precioVentaDirectaDolares"]);



                        foreach (ETipoEstadoBien oTipo in Enum.GetValues(typeof(ETipoEstadoBien)))
                        {
                            if (row["estado"].ToString() == oTipo.ToString())
                            {
                                oBien.Estado = oTipo;
                            }
                        }

                        oBien.Fotografias = oDALFotografia.GetAllFotografia(oBien.IdBien);

                        oBien.DescripcionTipoRep = oBien.Tipo.Descripcion;
                        oBien.IdTipoRep = oBien.Tipo.IdTipoBien.ToString();
                        oBien.EstadoBienRep = oBien.Estado.ToString();
                        bienes.Add(oBien);
                    }
                }

                return bienes;
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
        /// Retorna un bien asincronicamente.
        /// </summary>
        /// <param name="pIdBien"></param>
        /// <param name="pIdDuenno"></param>
        /// <returns></returns>
        public async Task<Bien> GetByIdBienAsync(int pIdBien, string pIdDuenno)
        {
            IDALCategoriaBien oDALCategoriaBien = new DALCategoriaBien();
            var command = new SqlCommand();
            string msg = "";
            
            Bien oBien = new Bien();
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspBienGetByIdDuenno";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdDuenno", pIdDuenno);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Bien");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oBien = new Bien();
                        oBien.IdBien = Convert.ToInt32(row["idBien"]);
                        oBien.Descripcion = row["descripcion"].ToString();
                        oBien.Tipo = oDALCategoriaBien.GetCategoriaById(Convert.ToInt32(row["idTipo"].ToString()));
                        oBien.PrecioBaseDolares = Convert.ToDecimal(row["precioBaseDolares"]);
                        oBien.PrecioVentaDirectaDolares = Convert.ToDecimal(row["precioVentaDirectaDolares"]);

                        oBien.PrecioBaseColones = oBien.PrecioBaseDolares * await ApiReader.GetTipoCambio();
                        oBien.PrecioVentaDirectaColones = oBien.PrecioVentaDirectaDolares * await ApiReader.GetTipoCambio();

                        foreach (ETipoEstadoBien oTipo in Enum.GetValues(typeof(ETipoEstadoBien)))
                        {
                            if (row["estado"].ToString() == oTipo.ToString())
                            {
                                oBien.Estado = oTipo;
                            }
                        }

                        oBien.Fotografias = oDALFotografia.GetAllFotografia(oBien.IdBien);
                        if(oBien.IdBien == pIdBien)
                        {
                            break;
                        }
                    }
                }

                return oBien;
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
        /// Retorna una lista de Bienes según el dueño.
        /// </summary>
        /// <param name="pIdDuenno"></param>
        /// <returns></returns>
        public async Task<List<Bien>> GetByIdDuennoAsync(string pIdDuenno, decimal pTipoCambio)
        {
            IDALCategoriaBien oDALCategoriaBien = new DALCategoriaBien();
            var command = new SqlCommand();
            string msg = "";
            List<Bien> bienes = new List<Bien>();
            Bien oBien;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspBienGetByIdDuenno";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdDuenno", pIdDuenno);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = await db.ExecuteReaderAsync(command, "Bien");

                    foreach (DataRow row in dataSet.Rows)
                    {
                        oBien = new Bien();
                        oBien.IdBien = Convert.ToInt32(row["idBien"]);
                        oBien.Descripcion = row["descripcion"].ToString();
                        oBien.Tipo = oDALCategoriaBien.GetCategoriaById(Convert.ToInt32(row["idTipo"].ToString()));
                        oBien.PrecioBaseDolares = Convert.ToDecimal(row["precioBaseDolares"]);
                        oBien.PrecioVentaDirectaDolares = Convert.ToDecimal(row["precioVentaDirectaDolares"]);

                        oBien.PrecioBaseColones = oBien.PrecioBaseDolares *  pTipoCambio;
                        oBien.PrecioVentaDirectaColones = oBien.PrecioVentaDirectaDolares * pTipoCambio;

                        foreach (ETipoEstadoBien oTipo in Enum.GetValues(typeof(ETipoEstadoBien)))
                        {
                            if (row["estado"].ToString() == oTipo.ToString())
                            {
                                oBien.Estado = oTipo;
                            }
                        }

                        oBien.Fotografias = oDALFotografia.GetAllFotografia(oBien.IdBien);
                        bienes.Add(oBien);
                    }
                }

                return bienes;
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
        /// Retorna solo una lista con los ids de los bienes.
        /// </summary>
        /// <returns></returns>
        public List<int> GetIdsBien()
        {
            IDALCategoriaBien oDALCategoriaBien = new DALCategoriaBien();
            var command = new SqlCommand();
            string msg = "";
            List<int> bienes = new List<int>();
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetIdBien";
                    command = new SqlCommand(sql);
                    
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Bien");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        int idBien;
                        idBien = Convert.ToInt32(row["idBien"]);
                        
                        bienes.Add(idBien);
                    }
                }

                return bienes;
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
        /// Inserta un nuevo bien asociado a un dueño.
        /// </summary>
        /// <param name="pBien"></param>
        /// <param name="pIdDuenno"></param>
        public void Insert(Bien pBien, string pIdDuenno)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspInsertBien";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdDuenno", pIdDuenno);
                    command.Parameters.AddWithValue("@pDescripcion", pBien.Descripcion);
                    command.Parameters.AddWithValue("@pIdTipo", pBien.Tipo.IdTipoBien);
                    command.Parameters.AddWithValue("@pPrecioBaseDolares", pBien.PrecioBaseDolares);
                    command.Parameters.AddWithValue("@pPrecioVentaDirectaDolares", pBien.PrecioVentaDirectaDolares);
                    command.Parameters.AddWithValue("@pEstado", pBien.Estado.ToString());

                    SqlParameter pIdBienParametro = new SqlParameter();
                    pIdBienParametro.ParameterName = "@pIdBien";
                    pIdBienParametro.DbType = DbType.Int32;
                    pIdBienParametro.Direction = ParameterDirection.Output;
                    command.Parameters.Add(pIdBienParametro);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = sql;
                    db.ExecuteNonQuery(command);

                    int idBien = (int)pIdBienParametro.Value;

                    foreach (Fotografia oFoto in pBien.Fotografias)
                    {
                        oDALFotografia.Insert(oFoto, idBien);
                    }
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
        /// Actualiza solo la información del bien. No las imágenes.
        /// </summary>
        /// <param name="pBien"></param>
        /// <param name="pIdDuenno"></param>
        public void Update(Bien pBien, string pIdDuenno)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspUpdateBien";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdBien", pBien.IdBien);
                    command.Parameters.AddWithValue("@pIdDuenno", pIdDuenno);
                    command.Parameters.AddWithValue("@pDescripcion", pBien.Descripcion);
                    command.Parameters.AddWithValue("@pIdTipo", pBien.Tipo.IdTipoBien);
                    command.Parameters.AddWithValue("@pPrecioBaseDolares", pBien.PrecioBaseDolares);
                    command.Parameters.AddWithValue("@pPrecioVentaDirectaDolares", pBien.PrecioVentaDirectaDolares);
                    command.Parameters.AddWithValue("@pEstado", pBien.Estado.ToString());

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
        /// Actualiza tanto el bien como las imágenes.
        /// </summary>
        /// <param name="pBien"></param>
        /// <param name="pIdDuenno"></param>
        public void Update(Bien pBien, string pIdDuenno, List<Fotografia> pBorrar, List<Fotografia> pInsertar)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspUpdateBien";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdBien", pBien.IdBien);
                    command.Parameters.AddWithValue("@pIdDuenno", pIdDuenno);
                    command.Parameters.AddWithValue("@pDescripcion", pBien.Descripcion);
                    command.Parameters.AddWithValue("@pIdTipo", pBien.Tipo.IdTipoBien);
                    command.Parameters.AddWithValue("@pPrecioBaseDolares", pBien.PrecioBaseDolares);
                    command.Parameters.AddWithValue("@pPrecioVentaDirectaDolares", pBien.PrecioVentaDirectaDolares);
                    command.Parameters.AddWithValue("@pEstado", pBien.Estado.ToString());

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = sql;
                    db.ExecuteNonQuery(command);

                    if (pBorrar.Count > 0)
                    {
                        foreach (var oFoto in pBorrar)
                        {
                            oDALFotografia.Delete(pBien.IdBien, oFoto);
                        }
                    }

                    if(pInsertar.Count > 0)
                    {
                        foreach(var oFoto in pInsertar)
                        {
                            oDALFotografia.Insert(oFoto, pBien.IdBien);
                        }
                    }
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
        /// Retorna un bien filtrado por el id de la categoria.
        /// </summary>
        /// <param name="pIdTipo"></param>
        /// <returns></returns>
        public List<Bien> GetByIdTipo(int pIdTipo)
        {
            IDALCategoriaBien oDALCategoriaBien = new DALCategoriaBien();
            var command = new SqlCommand();
            string msg = "";
            List<Bien> bienes = new List<Bien>();
            Bien oBien = new Bien();
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetBienesByTipo";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdTipo", pIdTipo);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Bien");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oBien = new Bien();
                        oBien.IdBien = Convert.ToInt32(row["idBien"]);
                        oBien.Descripcion = row["descripcion"].ToString();
                        oBien.Tipo = oDALCategoriaBien.GetCategoriaById(Convert.ToInt32(row["idTipo"].ToString()));
                        oBien.PrecioBaseDolares = Convert.ToDecimal(row["precioBaseDolares"]);
                        oBien.PrecioVentaDirectaDolares = Convert.ToDecimal(row["precioVentaDirectaDolares"]);



                        foreach (ETipoEstadoBien oTipo in Enum.GetValues(typeof(ETipoEstadoBien)))
                        {
                            if (row["estado"].ToString() == oTipo.ToString())
                            {
                                oBien.Estado = oTipo;
                            }
                        }
                        
                        oBien.Fotografias = oDALFotografia.GetAllFotografia(oBien.IdBien);

                        oBien.DescripcionTipoRep = oBien.Tipo.Descripcion;
                        oBien.IdTipoRep = oBien.Tipo.IdTipoBien.ToString();
                        oBien.EstadoBienRep = oBien.Estado.ToString();
                        bienes.Add(oBien);
                    }
                }

                return bienes;
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
