using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Enums;

namespace winShootForItAuctions.Layers.ENTITIES
{
    internal class Subasta
    {
        public string IdSubasta { get; set; }
        public List<Usuario> Clientes { get; set; }
        public Usuario Duenno { get; set; }
        public Bien Bien { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime FechaCierre { get; set; }
        public TimeSpan HoraApertura { get; set; }
        public TimeSpan HoraCierre { get; set; }
        public Usuario Ganador { get; set; }
        public decimal Comision { get; set; }
        public List<Puja> Pujas { get; set; }
        public decimal Incremento { get; set; }
        public decimal TotalOfertado { get; set; }
        public decimal PrecioBase { get; set; }
        public ETipoEstadoSubasta Estado { get; set; }

        public string idDuenorRep { get; set; }
        public string idBienRep { get; set; }
        public string descripcionBienRep { get; set; }
        public string estadoRep { get; set; }



        public Subasta()
        {
            this.Clientes = new List<Usuario>();
            this.Duenno = new Usuario();
            this.Bien = new Bien();
            this.FechaApertura = DateTime.Now;
            this.FechaCierre = new DateTime();
            this.HoraApertura = this.FechaApertura.TimeOfDay;
            this.HoraCierre = new TimeSpan();
            this.Ganador = new Usuario();
            this.Pujas = new List<Puja>();
            this.Estado = ETipoEstadoSubasta.ACTIVA;
        }

        public override string ToString()
        {
            return this.IdSubasta.ToString() + " " + this.Duenno.ToString() + " " + this.Bien.ToString();
        }
    }
}
