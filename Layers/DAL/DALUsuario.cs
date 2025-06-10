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
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS;
using winShootForItAuctions.Util;

namespace winShootForItAuctions.Layers.DAL
{
    internal class DALUsuario : IDALUsuario
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        /// <summary>
        /// Elimina un Usuario de la base de datos.
        /// </summary>
        /// <param name="pIdUsuario"></param>
        public void DeleteById(string pIdUsuario)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspUsuarioDeleteById";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdUsuario", pIdUsuario);

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
        /// Devuelve la lista de todos los Usuarios en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Usuario> GetAll()
        {
            var command = new SqlCommand();
            string msg = "";
            List<Usuario> usuarios = new List<Usuario>();
            Usuario oUsuario;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspUsuarioGetAll";
                    command = new SqlCommand(sql);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Usuario");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oUsuario = new Usuario();
                        oUsuario.IdUsuario = row["idUsuario"].ToString();
                        oUsuario.Contrasenna = row["contrasenna"].ToString();
                        oUsuario.Nombre = row["nombre"].ToString();
                        oUsuario.Apellido_1 = row["apellido_1"].ToString();
                        oUsuario.Apellido_2 = row["apellido_2"].ToString();
                        oUsuario.Sexo = Convert.ToChar(row["sexo"].ToString());
                        oUsuario.Nacionalidad = row["nacionalidad"].ToString();
                        oUsuario.Telefono = Convert.ToInt32(row["telefono"].ToString());
                        oUsuario.Correo = row["correo"].ToString();
                        oUsuario.SetEstadoUsuario(row["estado"].ToString());
                        oUsuario.CodigoPostal = Convert.ToInt32(row["codigoPostal"]);
                        oUsuario.Sennas = row["sennas"].ToString();
                        if (this.AdminGetById(oUsuario.IdUsuario) != ETipoUsuario.NULL)
                        {
                            oUsuario.Roles.Add(ETipoUsuario.ADMIN);
                        }
                        if (this.ClienteGetById(oUsuario.IdUsuario) != ETipoUsuario.NULL)
                        {
                            oUsuario.Roles.Add(ETipoUsuario.CLIENTE);
                        }
                        if (this.DuennoGetById(oUsuario.IdUsuario) != ETipoUsuario.NULL)
                        {
                            oUsuario.Roles.Add(ETipoUsuario.DUENNO);
                        }
                        usuarios.Add(oUsuario);
                    }
                }

                return usuarios;
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
        /// Retorna un usuario filtrado por su número de identificación
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Usuario GetById(string id)
        {
            var command = new SqlCommand();
            string msg = "";
            Usuario oUsuario = null;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspUsuarioGetById";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdUsuario", id);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Usuario");
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oUsuario = new Usuario();
                        oUsuario.IdUsuario = row["idUsuario"].ToString();
                        oUsuario.Contrasenna = row["contrasenna"].ToString();
                        oUsuario.Nombre = row["nombre"].ToString();
                        oUsuario.Apellido_1 = row["apellido_1"].ToString();
                        oUsuario.Apellido_2 = row["apellido_2"].ToString();
                        oUsuario.Sexo = Convert.ToChar(row["sexo"].ToString());
                        oUsuario.Nacionalidad = row["nacionalidad"].ToString();
                        oUsuario.Telefono = Convert.ToInt32(row["telefono"].ToString());
                        oUsuario.Correo = row["correo"].ToString();
                        oUsuario.SetEstadoUsuario(row["estado"].ToString());
                        oUsuario.CodigoPostal = Convert.ToInt32(row["codigoPostal"]);
                        oUsuario.Sennas = row["sennas"].ToString();
                        if (this.AdminGetById(oUsuario.IdUsuario) != ETipoUsuario.NULL)
                        {
                            oUsuario.Roles.Add(ETipoUsuario.ADMIN);
                        }
                        if (this.ClienteGetById(oUsuario.IdUsuario) != ETipoUsuario.NULL)
                        {
                            oUsuario.Roles.Add(ETipoUsuario.CLIENTE);
                        }
                        if (this.DuennoGetById(oUsuario.IdUsuario) != ETipoUsuario.NULL)
                        {
                            oUsuario.Roles.Add(ETipoUsuario.DUENNO);
                        }
                    }
                }
                return oUsuario;
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
        /// Inserta en la base de datos un usuario nuevo.
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Insert(Usuario pUsuario)
        {

            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspUsuarioInsert";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdUsuario", pUsuario.IdUsuario);
                    command.Parameters.AddWithValue("@pContrasenna", Util.Utilitarios.EncriptarContrasenna(pUsuario.Contrasenna));
                    command.Parameters.AddWithValue("@pNombre", pUsuario.Nombre);
                    command.Parameters.AddWithValue("@pApellido_1", pUsuario.Apellido_1);
                    command.Parameters.AddWithValue("@pApellido_2", pUsuario.Apellido_2);
                    command.Parameters.AddWithValue("@pSexo", pUsuario.Sexo);
                    command.Parameters.AddWithValue("@pNacionalidad", pUsuario.Nacionalidad);
                    command.Parameters.AddWithValue("@pTelefono", pUsuario.Telefono);
                    command.Parameters.AddWithValue("@pCorreo", pUsuario.Correo);
                    command.Parameters.AddWithValue("@pEstado", pUsuario.Estado.ToString());
                    command.Parameters.AddWithValue("@pCodigoPostal", pUsuario.CodigoPostal);
                    command.Parameters.AddWithValue("@pSennas", pUsuario.Sennas);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = sql;
                    db.ExecuteNonQuery(command);

                    if (pUsuario.Roles.Count > 0)
                    {
                        if (pUsuario.Roles.Contains(ETipoUsuario.ADMIN))
                        {
                            this.InsertAdmin(pUsuario.IdUsuario);
                        }
                        if (pUsuario.Roles.Contains(ETipoUsuario.CLIENTE))
                        {
                            this.InsertCliente(pUsuario.IdUsuario);
                        }
                        if (pUsuario.Roles.Contains(ETipoUsuario.DUENNO))
                        {
                            this.InsertDuenno(pUsuario.IdUsuario);
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
        /// Inserta el Usuario si este posee el rol ADMIN
        /// </summary>
        /// <param name="pIdUsuario"></param>
        public void InsertAdmin(string pIdUsuario)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspInsertAdmin";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdUsuario", pIdUsuario);
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
        /// Inserta el usuario si este posee el rol Cliente
        /// </summary>
        /// <param name="pIdUsuario"></param>
        public void InsertCliente(string pIdUsuario)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspInsertCliente";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdUsuario", pIdUsuario);
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
        /// Inserta el usuario si este posee el rol Duenno
        /// </summary>
        /// <param name="pIdUsuario"></param>
        public void InsertDuenno(string pIdUsuario)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspInsertDuenno";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdUsuario", pIdUsuario);
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
        /// Actualiza la información del Usuario según su número de Identificación.
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Update(Usuario pUsuario)
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"uspUsuarioUpdate";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdUsuario", pUsuario.IdUsuario);
                    command.Parameters.AddWithValue("@pContrasenna", pUsuario.Contrasenna);
                    command.Parameters.AddWithValue("@pNombre", pUsuario.Nombre);
                    command.Parameters.AddWithValue("@pApellido_1", pUsuario.Apellido_1);
                    command.Parameters.AddWithValue("@pApellido_2", pUsuario.Apellido_2);
                    command.Parameters.AddWithValue("@pSexo", pUsuario.Sexo);
                    command.Parameters.AddWithValue("@pNacionalidad", pUsuario.Nacionalidad);
                    command.Parameters.AddWithValue("@pTelefono", pUsuario.Telefono);
                    command.Parameters.AddWithValue("@pCorreo", pUsuario.Correo);
                    command.Parameters.AddWithValue("@pEstado", pUsuario.Estado.ToString());
                    command.Parameters.AddWithValue("@pCodigoPostal", pUsuario.CodigoPostal);
                    command.Parameters.AddWithValue("@pSennas", pUsuario.Sennas);
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
        /// Devulve un Tipo de Usuario si existe el Usuario posee el roll
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <returns></returns>
        public ETipoUsuario ClienteGetById(string pIdUsuario)
        {
            var command = new SqlCommand();
            string msg = "";
            ETipoUsuario oTipoUsuario = ETipoUsuario.NULL;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspClienteGetById";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdUsuario", pIdUsuario);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Cliente");
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oTipoUsuario = ETipoUsuario.CLIENTE;
                    }
                }
                return oTipoUsuario;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                MessageBox.Show(msg.ToSqlServerDetailError(er));
                return ETipoUsuario.NULL;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ETipoUsuario.NULL;
            }
        }

        /// <summary>
        /// Devulve un Tipo de Usuario si existe el Usuario posee el roll
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <returns></returns>
        public ETipoUsuario AdminGetById(string pIdUsuario)
        {
            var command = new SqlCommand();
            string msg = "";
            ETipoUsuario oTipoUsuario = ETipoUsuario.NULL;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspAdminGetById";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdUsuario", pIdUsuario);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Admin");
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oTipoUsuario = ETipoUsuario.ADMIN;
                    }
                }
                return oTipoUsuario;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                MessageBox.Show(msg.ToSqlServerDetailError(er));
                return ETipoUsuario.NULL;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ETipoUsuario.NULL;
            }
        }

        /// <summary>
        /// Devulve un Tipo de Usuario si existe el Usuario posee el roll
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <returns></returns>
        public ETipoUsuario DuennoGetById(string pIdUsuario)
        {
            var command = new SqlCommand();
            string msg = "";
            ETipoUsuario oTipoUsuario = ETipoUsuario.NULL;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspDuennoGetById";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdUsuario", pIdUsuario);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Duenno");
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oTipoUsuario = ETipoUsuario.DUENNO;
                    }
                }
                return oTipoUsuario;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                MessageBox.Show(msg.ToSqlServerDetailError(er));
                return ETipoUsuario.NULL;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ETipoUsuario.NULL;
            }
        }
        /// <summary>
        /// Encargado de realizar el login.
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <param name="pContrasenna"></param>
        /// <returns></returns>
        public bool LogIn(string pIdUsuario, string pContrasenna)
        {
            bool credencialesCorrectas = false;
            string contraEncriptada = Utilitarios.EncriptarContrasenna(pContrasenna.Trim());
            
            var command = new SqlCommand();
            string msg = "";
            Usuario oUsuario = null;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspUsuarioGetById";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdUsuario", pIdUsuario);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Usuario");
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oUsuario = new Usuario();
                        oUsuario.IdUsuario = row["idUsuario"].ToString().Trim();
                        oUsuario.Contrasenna = row["contrasenna"].ToString().Trim();
                        oUsuario.Nombre = row["nombre"].ToString();
                        oUsuario.Apellido_1 = row["apellido_1"].ToString();
                        oUsuario.Apellido_2 = row["apellido_2"].ToString();
                        oUsuario.Sexo = Convert.ToChar(row["sexo"].ToString());
                        oUsuario.Nacionalidad = row["nacionalidad"].ToString();
                        oUsuario.Telefono = Convert.ToInt32(row["telefono"].ToString());
                        oUsuario.Correo = row["correo"].ToString();
                        oUsuario.SetEstadoUsuario(row["estado"].ToString());
                        oUsuario.CodigoPostal = Convert.ToInt32(row["codigoPostal"]);
                        oUsuario.Sennas = row["sennas"].ToString();
                        if (this.AdminGetById(oUsuario.IdUsuario) != ETipoUsuario.NULL)
                        {
                            oUsuario.Roles.Add(ETipoUsuario.ADMIN);
                        }
                        if (this.ClienteGetById(oUsuario.IdUsuario) != ETipoUsuario.NULL)
                        {
                            oUsuario.Roles.Add(ETipoUsuario.CLIENTE);
                        }
                        if (this.DuennoGetById(oUsuario.IdUsuario) != ETipoUsuario.NULL)
                        {
                            oUsuario.Roles.Add(ETipoUsuario.DUENNO);
                        }
                    }
                    if (oUsuario != null && oUsuario.Contrasenna.Trim() == contraEncriptada.Trim())
                    {
                        credencialesCorrectas = true;
                        UsuarioLogeado.LogearUsuario(oUsuario);
                    }
                }
                return credencialesCorrectas;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                MessageBox.Show(msg.ToSqlServerDetailError(er));
                return false;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return false;
            }
        }
        /// <summary>
        /// Retorna los usuarios filtrados por la subasta.
        /// </summary>
        /// <param name="pIdSubasta"></param>
        /// <returns></returns>
        public List<Usuario> GetAllUsuariosSubastas(string pIdSubasta)
        {
            var command = new SqlCommand();
            string msg = "";
            List<Usuario> usuarios = new List<Usuario>();
            Usuario oUsuario;
            try
            {
                string connexion = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(connexion))
                {
                    string sql = @"uspGetClientesSubasta";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@pIdSubasta", pIdSubasta);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var dataSet = db.ExecuteReader(command, "Usuario");

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        oUsuario = new Usuario();
                        string idUsuario = row["idCliente"].ToString();
                        oUsuario = this.GetById(idUsuario);
                        usuarios.Add(oUsuario);
                    }
                }

                return usuarios;
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
