using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Layers.DAL
{
    internal interface IDALCategoriaBien
    {
        void InsertarCategoriaBien(TipoBien pCategoria);
        TipoBien GetCategoriaById(int pIdTipoBien);
        Task<List<TipoBien>> GetAllCategoriasAsync();
        void DeleteById (int idTipoBien);
    }
}
