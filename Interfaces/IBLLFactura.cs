using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Interfaces
{
    internal interface IBLLFactura
    {
        void InsertFacturaPendiente(Factura pFactura);
        void UpdateFacturaCancelada(Factura pFactura);
        List<Factura> GetFacturasPendientesByCliente(string pIdCliente);
        List<Factura> GetFacturasPendientesByFecha(DateTime pFechaInicio, DateTime pFechaFinal, string pIdCliente);
        List<Factura> GetAllFacturasByFecha(DateTime pFechaInicio, DateTime pFechaFinal);
        List<Factura> GetAll();
    }
}
