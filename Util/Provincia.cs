using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winShootForItAuctions.Util
{
    internal class Provincia
    {
        [JsonProperty(PropertyName = "IdProvincia")]
        public int IdProvincia { get; set; }
        [JsonProperty(PropertyName = "Descripcion")]
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
