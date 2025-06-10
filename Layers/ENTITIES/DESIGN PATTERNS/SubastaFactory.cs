using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS
{
    internal class SubastaFactory
    {

        /// <summary>
        /// Utilizado para crear una nueva subasta.
        /// </summary>
        /// <param name="pIdSubasta"></param>
        /// <param name="pDuenno"></param>
        /// <param name="pBien"></param>
        /// <param name="pFechaFinal"></param>
        /// <param name="pHoraFinal"></param>
        /// <param name="pComision"></param>
        /// <param name="pIncremento"></param>
        /// <returns></returns>
        public static Subasta CrearSubasta(string pIdSubasta,
                                        Usuario pDuenno,
                                        Bien pBien,
                                        DateTime pFechaFinal,
                                        TimeSpan pHoraFinal,
                                        decimal pComision,
                                        decimal pIncremento)
        {
            Subasta oSubasta = new Subasta();
            oSubasta.IdSubasta = pIdSubasta;
            oSubasta.Duenno = pDuenno;
            oSubasta.Bien = pBien;
            oSubasta.FechaCierre = pFechaFinal;
            oSubasta.HoraCierre = pHoraFinal;
            oSubasta.Comision = pComision;
            oSubasta.Incremento = pIncremento;
            oSubasta.PrecioBase = pBien.PrecioBaseDolares;

            return oSubasta;
        }
    }
}
