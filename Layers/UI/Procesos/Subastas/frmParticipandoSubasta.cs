using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
using winShootForItAuctions.Properties;
using winShootForItAuctions.Util;

namespace winShootForItAuctions.Layers.UI.Procesos.Subastas
{
    public partial class frmParticipandoSubasta : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private IBLLCategoriaBien oBLLCategoriaBien = new BLLCategoriaBien();
        private IBLLSubasta oBLLSubasta = new BLLSubasta();
        private IBLLPuja oBLLPuja = new BLLPuja();

        private List<Subasta> oSubastaList = new List<Subasta>();
        private Bien oBienActual = new Bien();
        private Subasta oSubastaActual = new Subasta();
        private string idSubastaActual = "";
        private List<Subasta> subastasCerradas = new List<Subasta>();
        private IBLLBien oBLLBien = new BLLBien();
        private IBLLFactura oBLLFactura = new BLLFactura();
        private decimal cambio = 0;
        private IBLLParametro oBLLParametro = new BLLParametro();

        public frmParticipandoSubasta()
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
        private async void GetTipoCambio()
        {
            this.cambio = await ApiReader.GetTipoCambio();
        }
        /// <summary>
        /// Carga todos los datos necesarios.
        /// </summary>
        private void CargarDatos()
        {
            lblSubasta.Text = "SUBASTA";
            txtDuenno.Text = "*";
            txtIncrementoMinimo.Text = "*";
            txtFechaCierre.Text = "*";
            txtTotalOfertado.Text = "*";
            txtCategoria.Text = "*";
            txtBien.Text = "*";
            txtMontoCompraDirecta.Text = "*";
            txtPrecioBase.Text = "*";
            dgvFotos.Rows.Clear();
            dgvPujas.Rows.Clear();
            ptbImagen.Image = Resources.imagen_icon;
            this.CargarCombo();
            this.oSubastaList = this.oBLLSubasta.GetSubastaActivasByCliente(UsuarioLogeado.GetInstance().IdUsuario);
            for (int i = this.oSubastaList.Count - 1; i >= 0; i--)
            {
                this.oSubastaActual = this.oSubastaList[i];
                lblSubasta.Text = "SUBASTA " + this.oSubastaList[i].IdSubasta;
                this.oBienActual = this.oSubastaList[i].Bien;
                string fechaHoraCierre = this.oSubastaList[i].FechaCierre.ToString("dd/MM/yyyy") + " " + this.oSubastaList[i].HoraCierre.ToString(@"hh\:mm");
                txtDuenno.Text = this.oSubastaList[i].Duenno.ToString();
                txtIncrementoMinimo.Text = this.oSubastaList[i].Incremento.ToString();
                txtFechaCierre.Text = fechaHoraCierre;
                txtTotalOfertado.Text = this.oSubastaList[i].TotalOfertado.ToString("n2");
                txtCategoria.Text = this.oSubastaList[i].Bien.Tipo.Nombre;
                txtBien.Text = this.oSubastaList[i].Bien.Descripcion;
                txtMontoCompraDirecta.Text = this.oSubastaList[i].Bien.PrecioVentaDirectaDolares.ToString("n2");
                txtPrecioBase.Text = this.oSubastaList[i].Bien.PrecioBaseDolares.ToString();
                this.CargarDGVPujas();
                tmrRefrescar.Start();
                btnCompraDirecta.Enabled = true;
                btnPujar.Enabled = true;
                btnDejarParticipar.Enabled = true;
                break;
            }
        }


        /// <summary>
        /// Refresca las pujas.
        /// </summary>
        private async void CargarDGVPujas()
        {

            int posicion = 1;
            List<Puja> pujas = await this.oBLLPuja.GetAllPujasAsync(this.idSubastaActual);

            dgvPujas.Rows.Clear();

            for (int i = pujas.Count - 1; i >= 0; i--)
            {
                dgvPujas.Rows.Add(posicion, pujas[i].Cliente.Nombre + " " + pujas[i].Cliente.Apellido_1, pujas[i].Monto.ToString("n2"));
                posicion++;
            }




        }
        /// <summary>
        /// Carga el DGV de la imagenes y el pictureBox.
        /// </summary>
        private void CargarDGVFotos()
        {
            dgvFotos.Rows.Clear();
            if (this.oBienActual.Fotografias.Count == 0)
            {
                ptbImagen.Image = Resources.imagen_icon;
            }
            for (int i = 0; i < this.oBienActual.Fotografias.Count; i++)
            {
                dgvFotos.Rows.Add(this.oBienActual.Fotografias[i].ToString() + " " + i);
            }
            int indice = dgvFotos.CurrentCell.RowIndex;
            using (MemoryStream ms = new MemoryStream(this.oBienActual.Fotografias[indice].Imagen))
            {
                ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbImagen.Image = Image.FromStream(ms);
            }
        }
        /// <summary>
        /// Carga el comboBox con las subasta en las que el cliente participa.
        /// </summary>
        private void CargarCombo()
        {
            cboSubastasParticipando.Items.Clear();
            this.oSubastaList = this.oBLLSubasta.GetSubastaActivasByCliente(UsuarioLogeado.GetInstance().IdUsuario);
            for (int i = this.oSubastaList.Count - 1; i >= 0; i--)
            {
                cboSubastasParticipando.Items.Add(this.oSubastaList[i].IdSubasta);
                cboSubastasParticipando.SelectedIndex = 0;
            }

        }
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void btnPujar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (!decimal.TryParse(txtMonto.Text, out decimal monto))
                {
                    MessageBox.Show("Debe proporcionar un monto de puja válido", "MONTO NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMonto.Focus();
                    return;
                }
                if (this.oBLLPuja.Insert(this.oSubastaActual, UsuarioLogeado.GetInstance(), monto, DateTime.Now))
                {
                    this.oSubastaActual = this.oBLLSubasta.GetByIdSubasta(this.idSubastaActual);
                    this.CargarDGVPujas();
                    txtTotalOfertado.Text = this.oSubastaActual.TotalOfertado.ToString("n2");

                    foreach (Usuario oCliente in this.oSubastaActual.Clientes)
                    {
                        if (oCliente.IdUsuario == UsuarioLogeado.GetInstance().IdUsuario)
                        {
                            continue;
                        }
                        MensajeCorreo oMensaje = Utilitarios.MensajeNuevaPuja(this.oSubastaActual, UsuarioLogeado.GetInstance(), oCliente);
                        Utilitarios.EnviarCorreo(oCliente.Correo, oMensaje);
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

        private void frmParticipandoSubasta_Load(object sender, EventArgs e)
        {
            string msg = "";
            Cursor = Cursors.WaitCursor;
            try
            {
                this.GetTipoCambio();
                this.CargarDatos();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
            finally { Cursor = Cursors.Default; }
        }


        private void tmrRefrescar_Tick(object sender, EventArgs e)
        {
            string msg = "";
            try
            {

                this.oSubastaActual = this.oBLLSubasta.GetByIdSubasta(this.idSubastaActual);

                if (this.oSubastaActual.Estado == Enums.ETipoEstadoSubasta.ACTIVA)
                {
                    this.CargarDGVPujas();
                    if (this.oSubastaActual != null)
                    {
                        txtTotalOfertado.Text = this.oSubastaActual.TotalOfertado.ToString("n2");
                        if (this.oSubastaActual.TotalOfertado > this.oSubastaActual.Bien.PrecioVentaDirectaDolares)
                        {
                            btnCompraDirecta.Enabled = false;
                        }
                    }
                }
                else
                {
                    tmrRefrescar.Stop();
                   
                    if (!this.subastasCerradas.Contains(this.oSubastaActual))
                    {
                        this.subastasCerradas.Add(this.oSubastaActual);
                        string fechaHoraCierre = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        this.oSubastaActual = this.oBLLSubasta.GetByIdSubasta(this.idSubastaActual);
                        MessageBox.Show("Subasta Finalizada. " + "\n" +
                                        "Esta subasta finalizó el día: " + fechaHoraCierre, "SUBASTA FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.oSubastaActual.Ganador != null)
                        {
                            if (this.oSubastaActual.Ganador.IdUsuario == UsuarioLogeado.GetInstance().IdUsuario)
                            {
                                MessageBox.Show("Felicidades. Ha sido el ganador de la subasta :" + this.oSubastaActual.IdSubasta + "\n" +
                                                "Puede dirigirse al apartado de Facturación para conocer los detalles.", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        this.CargarDatos();
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

        private void dgvFotos_SelectionChanged(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (dgvFotos.SelectedRows.Count > 0)
                {
                    int indice = dgvFotos.CurrentCell.RowIndex;
                    using (MemoryStream ms = new MemoryStream(this.oBienActual.Fotografias[indice].Imagen))
                    {
                        ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                        ptbImagen.Image = Image.FromStream(ms);
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

        private void cboSubastasParticipando_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                string idSubasta = cboSubastasParticipando.SelectedItem as string;
                foreach (Subasta oSubasta in this.oSubastaList)
                {
                    if (oSubasta.IdSubasta == idSubasta)
                    {
                        dgvPujas.Rows.Clear();
                        this.oSubastaActual = oSubasta;
                        this.idSubastaActual = idSubasta;
                        lblSubasta.Text = "SUBASTA " + oSubasta.IdSubasta;
                        this.oBienActual = oSubasta.Bien;
                        string fechaHoraCierre = oSubasta.FechaCierre.ToString("dd/MM/yyyy") + " " + oSubasta.HoraCierre.ToString(@"hh\:mm");
                        txtDuenno.Text = oSubasta.Duenno.ToString();
                        txtIncrementoMinimo.Text = oSubasta.Incremento.ToString();
                        txtFechaCierre.Text = fechaHoraCierre;
                        txtTotalOfertado.Text = oSubasta.TotalOfertado.ToString("n2");
                        txtCategoria.Text = oSubasta.Bien.Tipo.Nombre;
                        txtBien.Text = oSubasta.Bien.Descripcion;
                        txtMontoCompraDirecta.Text = oSubasta.Bien.PrecioVentaDirectaDolares.ToString("n2");
                        txtPrecioBase.Text = oSubasta.Bien.PrecioBaseDolares.ToString();
                        btnCompraDirecta.Enabled = true;
                        this.CargarDGVFotos();
                        tmrRefrescar.Stop();
                        this.CargarDGVPujas();
                        tmrRefrescar.Start();
                        break;
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

        private void btnDejarParticipar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (this.oSubastaList.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show("Seguro(a) que desea dejar de participar en esta subasta.", "CONFIRMAR ACCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        this.oBLLSubasta.DeleteSubastaCliente(UsuarioLogeado.GetInstance().IdUsuario, this.oSubastaActual.IdSubasta);
                        this.CargarDatos();
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

        private void btnCompraDirecta_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro(a) que desea realizar la compra directa", "CONFIRMAR ACCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No || respuesta == DialogResult.Cancel)
                {
                    return;
                }
                frmMain.tmrValidarSubastas.Stop();
                this.oSubastaActual.Estado = Enums.ETipoEstadoSubasta.CERRADA;
                this.oSubastaActual.Bien.Estado = Enums.ETipoEstadoBien.VENDIDO;
                this.oSubastaActual.Ganador = UsuarioLogeado.GetInstance();
                this.oSubastaActual.TotalOfertado = this.oSubastaActual.Bien.PrecioVentaDirectaDolares;
                this.oBLLSubasta.Update(this.oSubastaActual);
                double IVA = this.oBLLParametro.GetIVA();
                this.oBLLBien.Update(this.oSubastaActual.Bien, this.oSubastaActual.Duenno.IdUsuario);

                Factura oNuevaFactura = FacturaFactory.CrearFactura(this.oSubastaActual.IdSubasta + "-" + this.oSubastaActual.Ganador.IdUsuario, this.oSubastaActual, this.oSubastaActual.Ganador,
                                            this.oSubastaActual.Duenno, DateTime.Now, this.oSubastaActual.Bien.PrecioVentaDirectaDolares, this.oSubastaActual.Bien.PrecioVentaDirectaDolares * this.cambio,
                                            (double)this.oSubastaActual.Comision, IVA);
                this.oBLLFactura.InsertFacturaPendiente(oNuevaFactura);
                for (int i = this.oSubastaActual.Clientes.Count - 1; i >= 0; i--)
                {
                    Utilitarios.EnviarCorreo(this.oSubastaActual.Clientes[i].Correo, Utilitarios.MensajeSubastaFinalizada(this.oSubastaActual, this.oSubastaActual.Clientes[i]));
                }
                Utilitarios.EnviarCorreo(this.oSubastaActual.Duenno.Correo, Utilitarios.MensajeSubastaFinalizada(this.oSubastaActual, this.oSubastaActual.Duenno));
                frmMain.tmrValidarSubastas.Start();
                this.Close();
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
