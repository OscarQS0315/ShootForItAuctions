using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Enums;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Util;

namespace winShootForItAuctions.Layers.UI.Procesos.Facturacion
{
    public partial class frmCancelarFactura : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private decimal cambio;
        private Factura oFacturaActual = new Factura();
        private IBLLFactura oBLLFactura = new BLLFactura();
        internal frmCancelarFactura(Factura pFactura)
        {
            InitializeComponent();
            this.oFacturaActual = pFactura;
            this.SetCambio();
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
        /// Trae el tipo de cambio del dolar.
        /// </summary>
        private async void SetCambio()
        {
            this.cambio = await ApiReader.GetTipoCambio();
            txtTotalColones.Text = "₡" + (this.oFacturaActual.Total * this.cambio).ToString("n2");
        }

        /// <summary>
        /// Llena los Combos con sus respectiva información.
        /// </summary>
        private void LlenarCombos()
        {
            cboBanco.Items.Clear();
            cboMetodoPago.Items.Clear();

            foreach (EBancos oBanco in Enum.GetValues(typeof(EBancos)))
            {
                cboBanco.Items.Add(oBanco);
            }
            cboBanco.SelectedIndex = -1;

            foreach (ETipoMetodoPago oMetodo in Enum.GetValues(typeof(ETipoMetodoPago)))
            {
                cboMetodoPago.Items.Add(oMetodo);
            }
            cboMetodoPago.SelectedIndex = -1;
        }

        private void LlenarDGV()
        {
            dgvInfo.Rows.Clear();
            dgvInfo.Rows.Add(this.oFacturaActual.Subasta.Bien.IdBien, this.oFacturaActual.Subasta.Bien.Descripcion, "1.0", "$" + this.oFacturaActual.MontoDolares.ToString("n2"),
                             this.oFacturaActual.IVA + "%", this.oFacturaActual.Comision + "%");
        }
        /// <summary>
        /// Carga los datos necesarios de la factura.
        /// </summary>
        private void CargarDatos()
        {
            txtFactura.Text = "FACTURA No " + this.oFacturaActual.IdFactura;
            txtSubasta.Text = this.oFacturaActual.Subasta.IdSubasta.ToString();
            txtCliente.Text = this.oFacturaActual.Cliente.IdUsuario + " - " + this.oFacturaActual.Cliente.ToString();
            txtCorreoElectronico.Text = this.oFacturaActual.Cliente.Correo;
            txtTelefono.Text = this.oFacturaActual.Cliente.Telefono.ToString();
            this.LlenarCombos();
            this.LlenarDGV();
            txtSubtotal.Text = "$" + this.oFacturaActual.MontoDolares.ToString("n2");
            txtImpuesto.Text = "$" + this.oFacturaActual.CalcularImpuesto().ToString("n2");
            txtComision.Text = "$" + this.oFacturaActual.CalcularComision().ToString("n2");

            txtTotalDolares.Text = "$" + this.oFacturaActual.CalcularTotal().ToString("n2");
        }
        private void frmCancelarFactura_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {

                this.CargarDatos();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }

        private void cboMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (cboMetodoPago.SelectedIndex != -1)
                {
                    Nullable<ETipoMetodoPago> oTipo = cboMetodoPago.SelectedItem as Nullable<ETipoMetodoPago>;
                    if (oTipo != null)
                    {
                        if (oTipo.ToString() == ETipoMetodoPago.TRANSFERENCIA.ToString())
                        {
                            txtMetodoPago.Text = "Cuenta a transferir: CR 6301 0200 0095 4509 5432";
                            return;
                        }
                        else if (oTipo.ToString() == ETipoMetodoPago.SINPE.ToString())
                        {
                            txtMetodoPago.Text = "Número a transferir: 8476-2042";
                            return;
                        }
                    }
                }
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }

        private void chkPagoRealizado_CheckedChanged(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (chkPagoRealizado.Checked)
                {
                    btnPagar.Enabled = true;
                }
                else
                {
                    btnPagar.Enabled = false;
                }
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro(a) que desea concluir con la facturación.", "CONFIRMAR OPERACIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No || respuesta == DialogResult.Cancel)
                {
                    return;
                }
                if (cboBanco.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un banco de la lista", "SELECCIONAR BANCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboBanco.Focus();
                    return;
                }
                if (cboMetodoPago.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un método de pago de la lista", "SELECCIONAR MÉTODO DE PAGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMetodoPago.Focus();
                    return;
                }
                if (!chkPagoRealizado.Checked)
                {
                    MessageBox.Show("Debe indicar si ya realizó el pago.", "INDICAR PAGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chkPagoRealizado.Focus();
                    return;
                }
                Nullable<ETipoMetodoPago> oMetodoPago = cboMetodoPago.SelectedItem as Nullable<ETipoMetodoPago>;
                Nullable<EBancos> oBanco = cboBanco.SelectedItem as Nullable<EBancos>;

                this.oFacturaActual.Banco = oBanco.ToString();
                this.oFacturaActual.MetodoPago = oMetodoPago.ToString();
                this.oFacturaActual.XMLFactura = Utilitarios.CrearXML(this.oFacturaActual, this.cambio);
                this.oFacturaActual.Estado = ETipoEstadoFactura.CANCELADA;

                this.oBLLFactura.UpdateFacturaCancelada(this.oFacturaActual);

                Utilitarios.EnviarCorreoFactura(this.oFacturaActual.Cliente.Correo, Utilitarios.MensajeFacturacion(this.oFacturaActual),
                                                Utilitarios.CrearReportePDF(this.oFacturaActual, this.cambio), Utilitarios.ConvertXmlDocumentToByteArray(this.oFacturaActual.XMLFactura));
                MessageBox.Show("La factura con la información respectiva fue enviada a su correo.", "OPERACIÓN EXITOSA");
                this.Close();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }
    }
}
