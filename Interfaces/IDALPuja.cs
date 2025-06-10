using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Interfaces
{
    internal interface IDALPuja
    {
        void Insert(string pIdSubasta, string pIdCliente, decimal pMonto, DateTime pFecha);
        Task<List<Puja>> GetAllPujas(string pIdSubasta);
        Puja GetUltimaPuja(string pIdSubasta);
    }
}
