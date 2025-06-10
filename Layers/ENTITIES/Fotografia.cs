using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winShootForItAuctions.Layers.ENTITIES
{
    internal class Fotografia
    {
        public int IdFotografia { get; set; }
        public Byte[] Imagen { get; set; }

        public override string ToString()
        {
            return "FOTO";
        }
    }
}
