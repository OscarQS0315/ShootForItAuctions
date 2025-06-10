using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winShootForItAuctions.Util
{
    internal class Distrito
    {
        public int IdDistrito { get; set; }
        public int IdCanton { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
