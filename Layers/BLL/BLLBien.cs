using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.DAL;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Layers.BLL
{
    internal class BLLBien : IBLLBien
    {
        IDALBien oDALBien = new DALBien();
        public void Delete(Bien pBien, string pIdDuenno)
        {
            throw new NotImplementedException();
        }

        public List<Bien> GetAll()
        {
            List<Bien> bienes = new List<Bien>();
            bienes = oDALBien.GetAll();
            return bienes;
        }

        public Bien GetByIdBien(int pIdBien, string pIdDuenno)
        {
            Bien oBien = new Bien();
            oBien = this.oDALBien.GetByIdBien(pIdBien, pIdDuenno);
            return oBien;   
        }

        public async Task<Bien> GetByIdBienAsync(int pIdBien, string pIdDuenno)
        {
            Bien oBien = new Bien();
            oBien = await this.oDALBien.GetByIdBienAsync(pIdBien, pIdDuenno);
            return oBien;
        }

        public async Task<List<Bien>> GetByIdDuennoAsync(string idDuenno, decimal pTipoCambio)
        {
            List<Bien> bienes = new List<Bien>();
            bienes = await oDALBien.GetByIdDuennoAsync(idDuenno, pTipoCambio);
            return bienes;
        }

        public List<Bien> GetByIdTipo(int pIdTipo)
        {
            List<Bien> bienes = new List<Bien>();
            bienes = this.oDALBien.GetByIdTipo(pIdTipo);
            return bienes;
        }

        public List<int> GetIdsBien()
        {
            List<int> idsBienes = new List<int>();
            idsBienes = this.oDALBien.GetIdsBien();
            return idsBienes;
        }

        public void Insert(Bien pBien, string pIdDuenno)
        {
            if (pIdDuenno == null)
            {
                MessageBox.Show("La identificación del duenño es necesaria.");
                return;
            }
            if (pBien == null)
            {
                MessageBox.Show("El Bien debe poseer la infromación completa.");
                return;
            }
            if (pBien.Descripcion == null)
            {
                MessageBox.Show("La descripción del Bien es necesaria.");
                return;
            }
            if (pBien.Tipo == null)
            {
                MessageBox.Show("La categoría del bien es necesaria.");
                return;
            }
            if (!decimal.TryParse(pBien.PrecioBaseDolares.ToString(), out decimal i))
            {
                MessageBox.Show("El precio base debe ser numérico.");
                return;
            }
            if (!decimal.TryParse(pBien.PrecioVentaDirectaDolares.ToString(), out decimal j))
            {
                MessageBox.Show("El precio de venta directo debe ser numérico.");
                return;
            }
            oDALBien.Insert(pBien, pIdDuenno);
        }

        public void Update(Bien pBien, string pIdDuenno)
        {
            if (pIdDuenno == null)
            {
                MessageBox.Show("La identificación del duenño es necesaria.");
                return;
            }
            if (pBien == null)
            {
                MessageBox.Show("El Bien debe poseer la infromación completa.");
                return;
            }
            if (pBien.Descripcion == null)
            {
                MessageBox.Show("La descripción del Bien es necesaria.");
                return;
            }
            if (pBien.Tipo == null)
            {
                MessageBox.Show("La categoría del bien es necesaria.");
                return;
            }
            if (!decimal.TryParse(pBien.PrecioBaseDolares.ToString(), out decimal i))
            {
                MessageBox.Show("El precio base debe ser numérico.");
                return;
            }
            if (!decimal.TryParse(pBien.PrecioVentaDirectaDolares.ToString(), out decimal j))
            {
                MessageBox.Show("El precio de venta directo debe ser numérico.");
                return;
            }
            this.oDALBien.Update(pBien, pIdDuenno);
        }

        public void Update(Bien pBien, string pIdDuenno, List<Fotografia> pBorrar, List<Fotografia> pInsertar)
        {
            if (pIdDuenno == null)
            {
                MessageBox.Show("La identificación del duenño es necesaria.");
                return;
            }
            if (pBien == null)
            {
                MessageBox.Show("El Bien debe poseer la infromación completa.");
                return;
            }
            if (pBien.Descripcion == null)
            {
                MessageBox.Show("La descripción del Bien es necesaria.");
                return;
            }
            if (pBien.Tipo == null)
            {
                MessageBox.Show("La categoría del bien es necesaria.");
                return;
            }
            if (!decimal.TryParse(pBien.PrecioBaseDolares.ToString(), out decimal i))
            {
                MessageBox.Show("El precio base debe ser numérico.");
                return;
            }
            if (!decimal.TryParse(pBien.PrecioVentaDirectaDolares.ToString(), out decimal j))
            {
                MessageBox.Show("El precio de venta directo debe ser numérico.");
                return;
            }
            this.oDALBien.Update(pBien, pIdDuenno, pBorrar, pInsertar);
        }
    }
}
