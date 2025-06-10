using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Interfaces
{
    internal interface IBLLPuja
    {
        bool Insert(Subasta pSubasta, Usuario pCliente, decimal pMonto, DateTime pFecha);
        Task<List<Puja>> GetAllPujasAsync(string pIdSubasta);
    }
}
