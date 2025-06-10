using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.DAL;

namespace winShootForItAuctions.Layers.BLL
{
    internal class BLLParametro : IBLLParametro
    {
        IDALParametro oDALParametro = new DALParametro();
        public double GetIVA()
        {
            double IVA = this.oDALParametro.GetIVA();
            return IVA;
        }

        public double GetPorcentajeComision()
        {
            double porcentaje = this.oDALParametro.GetPorcentajeComision();
            return porcentaje;
        }

        public void UpdateComision(double pNuevaComision)
        {
            this.oDALParametro.UpdateComision(pNuevaComision);
        }

        public void UpdateIVA(double pNuevoIVA)
        {
            this.oDALParametro.UpdateIVA(pNuevoIVA);
        }
    }
}
