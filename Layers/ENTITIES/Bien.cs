using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Enums;

namespace winShootForItAuctions.Layers.ENTITIES
{
    internal class Bien
    {
        public int IdBien { get; set; }
        public string Descripcion { get; set; }
        public TipoBien Tipo { get; set; }
        public decimal PrecioBaseDolares { get; set; }
        public decimal PrecioBaseColones { get; set; }
        public decimal PrecioVentaDirectaDolares { get; set; }
        public decimal PrecioVentaDirectaColones { get; set; }
        public List<Fotografia> Fotografias { get; set; }
        public ETipoEstadoBien Estado { get; set; }

        public string DescripcionTipoRep { get; set; }
        public string IdTipoRep { get; set; }
        public string EstadoBienRep { get; set; }
        public Bien()
        {
            this.Tipo = new TipoBien();
            this.Fotografias = new List<Fotografia>();
        }
        public override string ToString()
        {
            return this.Descripcion;
        }
        public string StringXML()
        {
            return this.Descripcion.Replace(' ', '-').Trim();
        }
    }
}
