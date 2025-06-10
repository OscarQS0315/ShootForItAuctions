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
    internal class BLLPuja : IBLLPuja
    {
        private IDALPuja oDALPuja = new DALPuja();
        private IDALSubasta oDALSubasta = new DALSubasta();
        public async Task<List<Puja>> GetAllPujasAsync(string pIdSubasta)
        {
            List<Puja> pujas = new List<Puja>();
            pujas = await this.oDALPuja.GetAllPujas(pIdSubasta);
            return pujas;
        }

        public bool Insert(Subasta pSubasta, Usuario pCliente, decimal pMonto, DateTime pFecha)
        {
            if (pCliente == null)
            {
                MessageBox.Show("Debe proporcionar un id de Cliente válido.", "ID INCORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (pSubasta == null)
            {
                MessageBox.Show("Debe proporcionar un id de Subasta válido.", "ID INCORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(pMonto < pSubasta.Bien.PrecioBaseDolares)
            {
                MessageBox.Show("Debe proporcionar un monto de puja mayor o igual al precio base.", "MONTO INCORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (pMonto < pSubasta.Incremento)
            {
                MessageBox.Show("Debe proporcionar un monto de puja mayor o igual al monto de incremento mínimo.", "MONTO INCORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (pMonto - pSubasta.TotalOfertado < pSubasta.Incremento)
            {
                MessageBox.Show("Debe proporcionar un monto de puja mayor que el anterior y correspondiendo al monto mínimo de puja.", "MONTO INCORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (pFecha == null)
            {
                MessageBox.Show("Debe proporcionar una fecha de válida.", "FECHA INCORRECTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            Puja oUltimaPuja = this.oDALPuja.GetUltimaPuja(pSubasta.IdSubasta);
            if (oUltimaPuja != null)
            {
                pSubasta.Ganador = oUltimaPuja.Cliente;
                if (pMonto <= oUltimaPuja.Monto)
                {
                    MessageBox.Show("Debe proporcionar un monto de puja mayor al monto de la útlima puja.", "MONTO INCORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
            {
                pSubasta.Ganador = pCliente;
            }
            pSubasta.Ganador = pCliente;
            pSubasta.TotalOfertado = pMonto;
            
            this.oDALSubasta.Update(pSubasta);
            this.oDALPuja.Insert(pSubasta.IdSubasta, pCliente.IdUsuario, pMonto, pFecha);
            
            return true;
        }
    }
}
