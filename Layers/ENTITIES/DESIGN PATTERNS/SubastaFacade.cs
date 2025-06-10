using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS;

namespace winShootForItAuctions.Layers.ENTITIES
{
    internal class SubastaFacade
    {
        public Subasta Subasta { get; set; }
        public SubastaFacade()
        {
            this.Subasta = new Subasta();
        }

        /// <summary>
        /// Crea una nueva subasta.
        /// </summary>
        /// <param name="pIdSubasta"></param>
        /// <param name="pDuenno"></param>
        /// <param name="pBien"></param>
        /// <param name="pFechaFinal"></param>
        /// <param name="pHoraFinal"></param>
        /// <param name="pComision"></param>
        /// <param name="pIncremento"></param>
        public void CrearSubasta(string pIdSubasta,
                                        Usuario pDuenno,
                                        Bien pBien,
                                        DateTime pFechaFinal,
                                        TimeSpan pHoraFinal,
                                        decimal pComision,
                                        decimal pIncremento)
        {
            this.Subasta = SubastaFactory.CrearSubasta(pIdSubasta, pDuenno, pBien, pFechaFinal, pHoraFinal, pComision, pIncremento);
        }
    }
}
