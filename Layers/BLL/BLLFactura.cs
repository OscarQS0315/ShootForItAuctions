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
    internal class BLLFactura : IBLLFactura
    {
        IDALFactura oDALFactura = new DALFactura();

        public List<Factura> GetAll()
        {
            List<Factura> facturas = new List<Factura>();
            facturas = this.oDALFactura.GetAll();
            return facturas;
        }

        public List<Factura> GetAllFacturasByFecha(DateTime pFechaInicio, DateTime pFechaFinal)
        {
            List<Factura> facturas = new List<Factura>();
            facturas = this.oDALFactura.GetAllFacturasByFecha(pFechaInicio, pFechaFinal);
            return facturas;
        }

        public List<Factura> GetFacturasPendientesByCliente(string pIdCliente)
        {
            List<Factura> facturas = new List<Factura>();
            facturas = this.oDALFactura.GetFacturasPendientesByCliente(pIdCliente);
            return facturas;
        }

        public List<Factura> GetFacturasPendientesByFecha(DateTime pFechaInicio, DateTime pFechaFinal, string pIdCliente)
        {
            List<Factura> facturas = new List<Factura>();
            facturas = this.oDALFactura.GetFacturasPendientesByFecha(pFechaInicio, pFechaFinal, pIdCliente);
            return facturas;
        }

        public void InsertFacturaPendiente(Factura pFactura)
        {
            if(pFactura == null)
            {
                MessageBox.Show("Debe presentar una factura válida.", "FACTURA NO VÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(pFactura.IdFactura == "")
            {
                MessageBox.Show("Debe presentar un número de factura válido.", "NÚMERO DE FACTURA NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(pFactura.Cliente == null)
            {
                MessageBox.Show("Debe presentar una cliente válido.", "CLIENTE NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(pFactura.Subasta == null)
            {
                MessageBox.Show("Debe presentar una subasta válida.", "SUBASTA NO VÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(pFactura.Duenno == null)
            {
                MessageBox.Show("Debe presentar una dueño válido.", "DUEÑO NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(pFactura.Fecha == null)
            {
                MessageBox.Show("Debe presentar una fecha válida.", "FECHA NO VÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(pFactura.MontoDolares.ToString() == "")
            {
                MessageBox.Show("Debe presentar un monto en dólares válido.", "MONTO DÓLARES NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pFactura.MontoColones.ToString() == "")
            {
                MessageBox.Show("Debe presentar un monto en colones válido.", "MONTO COLONES NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(pFactura.Total.ToString() == "")
            {
                MessageBox.Show("Debe presentar un monto total válido.", "MONTO COLONES NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(pFactura.Comision.ToString() == "")
            {
                MessageBox.Show("Debe presentar una comisión válida.", "COMISIÓN NO VÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pFactura.IVA.ToString() == "")
            {
                MessageBox.Show("Debe presentar un IVA válido.", "IVA NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.oDALFactura.InsertFacturaPendiente(pFactura);
        }

        public void UpdateFacturaCancelada(Factura pFactura)
        {
            if (pFactura == null)
            {
                MessageBox.Show("Debe presentar una factura válida.", "FACTURA NO VÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pFactura.IdFactura == "")
            {
                MessageBox.Show("Debe presentar un número de factura válido.", "NÚMERO DE FACTURA NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pFactura.Cliente == null)
            {
                MessageBox.Show("Debe presentar una cliente válido.", "CLIENTE NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pFactura.Subasta == null)
            {
                MessageBox.Show("Debe presentar una subasta válida.", "SUBASTA NO VÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pFactura.Duenno == null)
            {
                MessageBox.Show("Debe presentar una dueño válido.", "DUEÑO NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pFactura.Fecha == null)
            {
                MessageBox.Show("Debe presentar una fecha válida.", "FECHA NO VÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pFactura.MontoDolares.ToString() == "")
            {
                MessageBox.Show("Debe presentar un monto en dólares válido.", "MONTO DÓLARES NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pFactura.MontoColones.ToString() == "")
            {
                MessageBox.Show("Debe presentar un monto en colones válido.", "MONTO COLONES NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pFactura.Total.ToString() == "")
            {
                MessageBox.Show("Debe presentar un monto total válido.", "MONTO COLONES NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pFactura.Comision.ToString() == "")
            {
                MessageBox.Show("Debe presentar una comisión válida.", "COMISIÓN NO VÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pFactura.IVA.ToString() == "")
            {
                MessageBox.Show("Debe presentar un IVA válido.", "IVA NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(pFactura.Banco == "")
            {
                MessageBox.Show("Debe presentar un banco válido.", "BANCO NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(pFactura.MetodoPago == "")
            {
                MessageBox.Show("Debe presentar un método de pago válido.", "MÉTODO DE PAGO NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pFactura.XMLFactura == null)
            {
                MessageBox.Show("Debe presentar un XML válido.", "XML NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.oDALFactura.UpdateFacturaCancelada(pFactura);
        }
    }
}
