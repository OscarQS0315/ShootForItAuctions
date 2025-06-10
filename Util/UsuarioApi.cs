using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winShootForItAuctions.Util
{
    internal class UsuarioApi
    {
        public string nombre { get; set; }

        public string GetNombre()
        {
            this.nombre = this.nombre.Replace(' ', ';');
            string primerNombre = "";
            List<String> nombreCompleto = this.nombre.Split(';').ToList();
            primerNombre = nombreCompleto[0];
            return primerNombre;
        }

        public string GetPrimerApellido()
        {
            string primerApellido = "";
            List<String> nombreCompleto = this.nombre.Split(';').ToList();
            int indice = nombreCompleto.Count -2;
            primerApellido = nombreCompleto[indice];
            return primerApellido;
        }
        public string GetSegundoApellido()
        {
            string segundoApellido = "";
            List<String> nombreCompleto = this.nombre.Split(';').ToList();
            segundoApellido = nombreCompleto.Last();
            return segundoApellido;
        }
        public override string ToString()
        {
            return this.nombre;
        }
    }
}
