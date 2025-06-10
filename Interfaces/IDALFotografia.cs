using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Interfaces
{
    internal interface IDALFotografia
    {
        void Insert(Fotografia pFotografia, int pIdBien);
        List<Fotografia> GetAllFotografia (int pIdBien);
        void Delete (int pIdBien, Fotografia pFotografia);
    }
}

