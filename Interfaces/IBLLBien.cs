using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Interfaces
{
    internal interface IBLLBien
    {
        Task <List<Bien>> GetByIdDuennoAsync(string idDuenno, decimal pTipoCambio);
        void Insert(Bien pBien, string pIdDuenno);
        Task<Bien> GetByIdBienAsync(int pIdBien, string pIdDuenno);
        void Update(Bien pBien, string pIdDuenno);
        void Delete(Bien pBien, string pIdDuenno);
        void Update(Bien pBien, string pIdDuenno, List<Fotografia> pBorrar, List<Fotografia> pInsertar);
        Bien GetByIdBien(int pIdBien, string pIdDuenno);
        List<int> GetIdsBien();
        List<Bien> GetAll();
        List<Bien> GetByIdTipo(int pIdTipo);
    }
}

