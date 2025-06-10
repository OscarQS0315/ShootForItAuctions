using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winShootForItAuctions.Layers.ENTITIES
{
    internal class Puja
    {
        public int IdPuja { get; set; }
        public string IdSubasta { get; set; }
        public Usuario Cliente { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public Puja()
        {
            this.Cliente = new Usuario();
            this.Fecha = DateTime.Now;
        }

        public override string ToString()
        {
            return this.IdPuja.ToString() + " " + this.Cliente.ToString() + " " + this.Monto.ToString("N2");
        }
    }
}
