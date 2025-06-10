using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS;

namespace winShootForItAuctions.Layers.UI.Procesos.Facturacion
{
    public partial class frmFacturasPendientes : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private List<Factura> misFacturas = new List<Factura>();
        private IBLLFactura oBLLFactura = new BLLFactura();
        public frmFacturasPendientes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evita el parpadeo a la hora de abrir un form.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        /// <summary>
        /// Carga el DGV con todas las facturas pendientes.
        /// </summary>
        private void CargarDGV()
        {
            dgvFacturas.Rows.Clear();
            if (this.misFacturas.Count > 0)
            {
                foreach (Factura oFactura in this.misFacturas)
                {
                    if (oFactura.Estado == Enums.ETipoEstadoFactura.PENDIENTE)
                    {
                        oFactura.CalcularTotal();
                        dgvFacturas.Rows.Add(oFactura.IdFactura, oFactura.Fecha.ToString("dd/MM/yyyy"), oFactura.Subasta.IdSubasta, oFactura.Subasta.Bien.Descripcion,
                                             oFactura.MontoDolares.ToString("n2"), oFactura.Total.ToString("n2"));
                    }
                }
            }
        }
        /// <summary>
        /// Carga el DGV por fechas.
        /// </summary>
        private void CargarDGVFechas()
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFinal = dtpFechaFinal.Value;
            List<Factura> facturasPorFecha = new List<Factura>();
            facturasPorFecha = this.oBLLFactura.GetFacturasPendientesByFecha(fechaInicio, fechaFinal, UsuarioLogeado.GetInstance().IdUsuario);
            dgvFacturas.Rows.Clear();
            if (facturasPorFecha.Count > 0)
            {
                foreach (Factura oFactura in facturasPorFecha)
                {
                    if (oFactura.Estado == Enums.ETipoEstadoFactura.PENDIENTE)
                    {
                        oFactura.CalcularTotal();
                        dgvFacturas.Rows.Add(oFactura.IdFactura, oFactura.Fecha.ToString("dd/MM/yyyy"), oFactura.Subasta.IdSubasta, oFactura.Subasta.Bien.Descripcion,
                                             oFactura.MontoDolares.ToString("n2"), oFactura.Total.ToString("n2"));
                    }
                }
            }
        }

        private void frmFacturasPendientes_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                dtpFechaInicio.Value = DateTime.Now;
                dtpFechaFinal.Value = DateTime.Now.AddDays(1);
                this.misFacturas = this.oBLLFactura.GetFacturasPendientesByCliente(UsuarioLogeado.GetInstance().IdUsuario);
                this.CargarDGV();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }

        private void dtpFechaCierre_ValueChanged(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                dtpFechaFinal.MinDate = dtpFechaInicio.Value.AddDays(1);
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                this.CargarDGVFechas();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                this.frmFacturasPendientes_Load(sender, e);
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }

        private void btnCancelarFactura_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (this.misFacturas.Count > 0)
                {
                    string idFactura = dgvFacturas.CurrentRow.Cells[0].Value.ToString();
                    Factura oFacturaPagar = new Factura();
                    foreach (Factura oFac in this.misFacturas)
                    {
                        if (oFac.IdFactura == idFactura)
                        {
                            oFacturaPagar = oFac;
                            break;
                        }
                    }
                    frmCancelarFactura oFrmCancelarFactura = new frmCancelarFactura(oFacturaPagar);
                    oFrmCancelarFactura.ShowDialog();
                    this.frmFacturasPendientes_Load(sender, e);
                }
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
