using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.DAL;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Util;

namespace winShootForItAuctions.Layers.BLL
{
    internal class BLLUsuario : IBLLUsuario
    {
        public DALUsuario oDALUsuario = new DALUsuario();

        /// <summary>
        /// Elimina un usuario de la base de Datos si este existe.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteById(string id)
        {
            Usuario oUsuario = oDALUsuario.GetById(id);
            if (oUsuario != null)
            {
                oDALUsuario.DeleteById(id);
            }
        }

        /// <summary>
        /// Retorna la lista del total de Usuarios.
        /// </summary>
        /// <returns></returns>
        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = oDALUsuario.GetAll();    
            return usuarios;
        }

        /// <summary>
        /// Retorna el usuario solicitado filtrado por la Identificación.
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public Usuario GetById(string idUsuario)
        {
            Usuario oUsuario = new Usuario();
            oUsuario = oDALUsuario.GetById(idUsuario);
            return oUsuario;
        }

        /// <summary>
        /// Inserta en la base de datos un nuevo Usuario.
        /// </summary>
        /// <param name="pUsuario"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Insert(Usuario pUsuario)
        {
            if (pUsuario == null)
            {
                MessageBox.Show("El Usuario tiene que contener la información necesario.");
                return;
            }
            if (pUsuario.IdUsuario == null)
            {
                MessageBox.Show("La contraseña del Usuario es necesaria.");
                return;
            }
            if(pUsuario.Nombre == null)
            {
                MessageBox.Show("El nombre del Usuario es necesario.");
                return;
            }
            if (pUsuario.Apellido_1 == null)
            {
                MessageBox.Show("El primer apellido del Usuario es necesario.");
                return;
            }
            if (pUsuario.Sexo.ToString() == null)
            {
                MessageBox.Show("El sexo del Usuario es necesario.");
                return;

            }
            if (pUsuario.Nacionalidad == null)
            {
                MessageBox.Show("La nacionalidad del Usuario es necesaria.");
                return;
            }
            int i;
            if (!int.TryParse(pUsuario.Telefono.ToString(), out i))
            {
                MessageBox.Show("El número telefónico del Usuario debe ser numérico");
                return;
            }
            if (pUsuario.Correo == null)
            {
                MessageBox.Show("El correo electrónico del Usuario es necesario.");
                return;
            }
            if (!Utilitarios.ValidarCorreo(pUsuario.Correo))
            {
                MessageBox.Show("El correo electrónico no posee el formato correcto.");
                return;
            }
            if (pUsuario.Estado.ToString() == null)
            {
                MessageBox.Show("El estado del Usuario es necesario.");
                return;
            }
            if (!int.TryParse(pUsuario.CodigoPostal.ToString(), out i))
            {
                MessageBox.Show("El código postal del Usuario debe ser numérico.");
                return;
            }
            if (pUsuario.Sennas == null)
            {
                MessageBox.Show("Las señas de la dirección del Usuario son necesarias.");
                return;
            }

            oDALUsuario.Insert(pUsuario);
        }

        public bool LogIn(string pIdUsuario, string pContrasenna)
        {
            bool credencialesCorrectas = false;
            if(oDALUsuario.LogIn(pIdUsuario, pContrasenna))
            {
                credencialesCorrectas = true;
            }
            return credencialesCorrectas;
        }

        /// <summary>
        /// Actualiza la información del Usuario.
        /// </summary>
        /// <param name="pUsuario"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Update(Usuario pUsuario)
        {
            if (pUsuario == null)
            {
                MessageBox.Show("El Usuario tiene que contener la información necesario.");
                return;
            }
            if (pUsuario.IdUsuario == null)
            {
                MessageBox.Show("La contraseña del Usuario es necesaria.");
                return;
            }
            if (pUsuario.Nombre == null)
            {
                MessageBox.Show("El nombre del Usuario es necesario.");
                return;
            }
            if (pUsuario.Apellido_1 == null)
            {
                MessageBox.Show("El primer apellido del Usuario es necesario.");
                return;
            }
            if (pUsuario.Sexo.ToString() == null)
            {
                MessageBox.Show("El sexo del Usuario es necesario.");
                return;

            }
            if (pUsuario.Nacionalidad == null)
            {
                MessageBox.Show("La nacionalidad del Usuario es necesaria.");
                return;
            }
            int i;
            if (!int.TryParse(pUsuario.Telefono.ToString(), out i))
            {
                MessageBox.Show("El número telefónico del Usuario debe ser numérico");
                return;
            }
            if (pUsuario.Correo == null)
            {
                MessageBox.Show("El correo electrónico del Usuario es necesario.");
                return;
            }
            if (pUsuario.Estado.ToString() == null)
            {
                MessageBox.Show("El estado del Usuario es necesario.");
                return;
            }
            if (!int.TryParse(pUsuario.CodigoPostal.ToString(), out i))
            {
                MessageBox.Show("El código postal del Usuario debe ser numérico.");
                return;
            }
            if (pUsuario.Sennas == null)
            {
                MessageBox.Show("Las señas de la dirección del Usuario son necesarias.");
                return;
            }

            oDALUsuario.Update(pUsuario);
        }
    }
}
