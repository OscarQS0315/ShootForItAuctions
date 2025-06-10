using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.DAL;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Layers.BLL
{
    internal class BLLCategoriaBien : IBLLCategoriaBien
    {
        IDALCategoriaBien oDALCategoriaBien = new DALCategoriaBien();

        public void DeleteById(int idTipoBien)
        {
            this.oDALCategoriaBien.DeleteById(idTipoBien);
        }

        public async Task<List<TipoBien>> GetAllCategoriasAsync()
        {
            List<TipoBien> tipos = new List<TipoBien>();
            tipos = await oDALCategoriaBien.GetAllCategoriasAsync();
            return tipos;
        }

        public TipoBien GetCategoriaById(int pIdTipoBien)
        {
            throw new NotImplementedException();
        }

        public void InsertarCategoriaBien(TipoBien pCategoria)
        {
            if (pCategoria == null)
            {
                MessageBox.Show("La categoría no puede estar vacía.");
                return;
            }
            if (pCategoria.Nombre == null)
            {
                MessageBox.Show("El nombre de la categoría es requerido.");
                return;
            }
            if (pCategoria.Descripcion == null) {
                MessageBox.Show("La descripción de la categoría es requerida.");
                return;
            }

            oDALCategoriaBien.InsertarCategoriaBien(pCategoria);
        }
    }
}
