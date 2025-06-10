using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winShootForItAuctions.Interfaces
{
    internal interface IBLLParametro
    {
        double GetIVA();
        double GetPorcentajeComision();
        void UpdateIVA(double pNuevoIVA);
        void UpdateComision(double pNuevaComision);
    }
}
