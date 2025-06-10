using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS
{
    internal class FacturaFactory
    {

        /// <summary>
        /// Utilizado para crear una nueva factura.
        /// </summary>
        /// <param name="pSubasta"></param>
        /// <param name="pCliente"></param>
        /// <param name="pDuenno"></param>
        /// <param name="pBanco"></param>
        /// <param name="pMetodoPago"></param>
        /// <param name="pMontoDorales"></param>
        /// <param name="pMontoColones"></param>
        /// <returns></returns>
        public static Factura CrearFactura(string pIdFactura,
                                           Subasta pSubasta,
                                           Usuario pCliente,
                                           Usuario pDuenno,
                                           DateTime pFecha,
                                           decimal pMontoDorales,
                                           decimal pMontoColones,
                                           double pComision,
                                           double pIVA)
        {
            Factura oFactura = new Factura();
            oFactura.IdFactura = pIdFactura;
            oFactura.Subasta = pSubasta;
            oFactura.Cliente = pCliente;
            oFactura.Duenno = pDuenno;
            oFactura.MontoDolares = pMontoDorales;
            oFactura.MontoColones = pMontoColones;
            oFactura.Comision = pComision;
            oFactura.IVA = pIVA;    
            oFactura.Fecha = pFecha;
            oFactura.CalcularComision();
            oFactura.CalcularImpuesto();
            oFactura.CalcularTotal();
            return oFactura;
        }
    }
}
