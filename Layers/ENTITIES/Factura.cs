using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Xml;
using winShootForItAuctions.Enums;

namespace winShootForItAuctions.Layers.ENTITIES
{
    internal class Factura
    {
        public string IdFactura { get; set; }
        public Subasta Subasta { get; set; }
        public Usuario Cliente { get; set; }
        public Usuario Duenno { get; set; }
        public String Banco { get; set; }
        public string MetodoPago { get; set; }
        public decimal MontoDolares { get; set; }
        public decimal MontoColones { get; set; }
        public decimal Total { get; set; }
        public string CodigoQR { get; set; }
        public XmlDocument XMLFactura { get; set; }
        public double IVA { get; set; }
        public ETipoEstadoFactura Estado { get; set; }
        public double Comision { get; set; }
        public DateTime Fecha { get; set; }

        public string idSubastasRep { get; set; }
        public string idClienteRep { get; set; }
        public string idDuennoRep { get; set; }
        public string idBienRep { get; set; }
        public string descripcionBienRep { get; set; }
        public string estadoRep { get; set; }
        public Factura()
        {
            this.Subasta = new Subasta();
            this.Cliente = new Usuario();
            this.Duenno = new Usuario();
            this.XMLFactura = new XmlDocument();
            this.Estado = ETipoEstadoFactura.PENDIENTE;
            this.Fecha = DateTime.Now;
        }

        public decimal CalcularImpuesto()
        {
            decimal impuesto = (decimal) this.MontoDolares * (decimal)(this.IVA / 100);
            return impuesto;
        }
        public decimal CalcularTotal()
        {
            this.Total = this.CalcularComision() + this.CalcularImpuesto() + this.MontoDolares;
            return this.Total;
        }
        public decimal CalcularComision()
        {
            decimal comision = this.MontoDolares * (decimal)(this.Subasta.Comision / 100);
            return comision;
        }

        
    }
}
