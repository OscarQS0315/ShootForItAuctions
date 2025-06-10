using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Enums;

namespace winShootForItAuctions.Layers.ENTITIES
{
    internal class Usuario
    {
        public string IdUsuario { get; set; }
        public string Contrasenna { get; set; }
        public string Nombre { get; set; }
        public string Apellido_1 { get; set; }
        public string Apellido_2 { get; set; }
        public char Sexo { get; set; }
        public string Nacionalidad { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }

        public List<ETipoUsuario> Roles { get; set; }
        public List<Bien> BienesProppios { get; set; }
        public List<Bien> BienesComprados { get; set; }
        public ETipoEstadoCliente Estado { get; set; }
        public int CodigoPostal { get; set; }
        public string Sennas { get; set; }


        public Usuario()
        {

            this.Roles = new List<ETipoUsuario>();
            this.BienesComprados = new List<Bien>();
            this.BienesProppios = new List<Bien>();
        }

        /// <summary>
        /// Agrega un bien propio a la lista
        /// </summary>
        /// <param name="pBien"></param>
        public void AgregarBienPropio(Bien pBien)
        {
            this.BienesProppios.Add(pBien);
        }

        /// <summary>
        /// Se utiliza para agregar un bien a los comprados
        /// </summary>
        /// <param name="pBien"></param>
        public void ComprarBien(Bien pBien)
        {
            this.BienesComprados.Add(pBien);
        }
        public void ActualizarInformacion(Usuario pUsuario)
        {
            this.Contrasenna = pUsuario.Contrasenna;
            this.Nombre = pUsuario.Nombre;
            this.Apellido_1 = pUsuario.Apellido_1;
            this.Apellido_2 = pUsuario.Apellido_2;
            this.Sexo = pUsuario.Sexo;
            this.Nacionalidad = pUsuario.Nacionalidad;
            this.Telefono = pUsuario.Telefono;
            this.Correo = pUsuario.Correo;

        }

        /// <summary>
        /// Agrega los diferentes roles e inicializa el estado del usuario.
        /// </summary>
        /// <param name="pAdmin"></param>
        /// <param name="pDuenno"></param>
        /// <param name="pCliente"></param>
        public void AgregarRoles(bool pDuenno, bool pCliente, bool pAdmin)
        {
            if (pAdmin)
            {
                this.Roles.Add(ETipoUsuario.ADMIN);
                this.Roles.Add(ETipoUsuario.DUENNO);
                this.Roles.Add(ETipoUsuario.CLIENTE);
                this.Estado = ETipoEstadoCliente.APROBADO;
                return;
            }
            if (pDuenno)
            {
                this.Roles.Add(ETipoUsuario.DUENNO);
                this.Estado = ETipoEstadoCliente.APROBADO;
            }
            if (pCliente)
            {
                this.Roles.Add(ETipoUsuario.CLIENTE);
                this.Estado = ETipoEstadoCliente.PENDIENTE;
            }
        }

        /// <summary>
        /// Agrega los diferentes roles e inicializa el estado del usuario.
        /// </summary>
        /// <param name="pAdmin"></param>
        /// <param name="pDuenno"></param>
        /// <param name="pCliente"></param>
        public void AgregarRoles(bool pDuenno, bool pCliente)
        {
            if (pDuenno)
            {
                this.Roles.Add(ETipoUsuario.DUENNO);
                this.Estado = ETipoEstadoCliente.APROBADO;
            }
            if (pCliente)
            {
                this.Roles.Add(ETipoUsuario.CLIENTE);
                this.Estado = ETipoEstadoCliente.PENDIENTE;
            }
        }

        public void AgregarSexo(bool pMasculino, bool pFemenino)
        {
            if (pMasculino)
            {
                this.Sexo = 'M';
            }
            if (pFemenino)
            {
                this.Sexo = 'F';
            }
        }

        /// <summary>
        /// Establece el estado del Usuario
        /// </summary>
        /// <param name="pEstado"></param>
        public void SetEstadoUsuario(string pEstado)
        {
            if (pEstado == ETipoEstadoCliente.DECLINADO.ToString())
            {
                this.Estado = ETipoEstadoCliente.DECLINADO;
            }
            else if (pEstado == ETipoEstadoCliente.APROBADO.ToString())
            {
                this.Estado = ETipoEstadoCliente.APROBADO;
            }
            else if (pEstado == ETipoEstadoCliente.PENDIENTE.ToString())
            {
                this.Estado = ETipoEstadoCliente.PENDIENTE;
            }
        }

        /// <summary>
        /// Retorna el id de la provincia seleccionada.
        /// </summary>
        /// <returns></returns>
        public int GetIdProvincia()
        {
            int idProvincia = 0;
            string codPostal = this.CodigoPostal.ToString();
            idProvincia = Convert.ToInt32(codPostal.Remove(codPostal.Length - 4));
            return idProvincia;
        }

        /// <summary>
        /// Retorna el id del cantón seleccionado
        /// </summary>
        /// <returns></returns>
        public int GetIdCanton()
        {
            int idCanton = 0;
            string codPostal = this.CodigoPostal.ToString();
            idCanton = Convert.ToInt32(codPostal.Remove(codPostal.Length - 2));
            return idCanton;
        }

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido_1 + " " + this.Apellido_2;
        }
    }
}
