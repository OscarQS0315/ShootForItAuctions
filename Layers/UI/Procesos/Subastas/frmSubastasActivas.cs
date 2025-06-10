using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using winShootForItAuctions.Layers.DAL;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS;
using winShootForItAuctions.Layers.UI.Procesos.Subastas;
using winShootForItAuctions.Properties;
using winShootForItAuctions.Util;

namespace winShootForItAuctions.Layers.UI
{
    public partial class frmSubastasActivas : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private IBLLSubasta oBLLSubasta = new BLLSubasta();
        private IBLLCategoriaBien oBLLCategoriaBien = new BLLCategoriaBien();
        private bool cargarImagen = true;
        private List<Subasta> subastasActivas = new List<Subasta>();
        private decimal cambio = 0;
        public frmSubastasActivas()
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
        /// Carga el combo con las categorías registradas.
        /// </summary>
        private async void CargarCombo()
        {
            cboCategoriaBien.Items.Clear();
            List<TipoBien> categorias = await oBLLCategoriaBien.GetAllCategoriasAsync();
            cboCategoriaBien.Items.Add("Todos");
            foreach (TipoBien tipoBien in categorias)
            {
                cboCategoriaBien.Items.Add(tipoBien);
            }
            cboCategoriaBien.SelectedIndex = 0;
        }
        /// <summary>
        /// Carga el DGV con todas las subastas activas.
        /// </summary>
        /// <returns></returns>
        private void CargarDGV()
        {
            
            dgvSubastas.Rows.Clear();
            dgvSubastas.Rows.Clear();
            foreach (Subasta oSubasta in subastasActivas)
            {
                if (oSubasta.Estado == Enums.ETipoEstadoSubasta.ACTIVA)
                {
                    oSubasta.Bien.PrecioVentaDirectaColones = oSubasta.Bien.PrecioVentaDirectaDolares * this.cambio;
                    oSubasta.Bien.PrecioBaseColones = oSubasta.Bien.PrecioBaseDolares * this.cambio;
                    string fechaHoraInicio = oSubasta.FechaApertura.ToString("dd/MM/yyyy") + " " + oSubasta.HoraApertura.ToString(@"hh\:mm");
                    string fechaHoraCierre = oSubasta.FechaCierre.ToString("dd/MM/yyyy") + " " + oSubasta.HoraCierre.ToString(@"hh\:mm");
                    dgvSubastas.Rows.Add(oSubasta.IdSubasta, oSubasta.Bien.Descripcion, oSubasta.Incremento.ToString("N2"), fechaHoraInicio,
                                             fechaHoraCierre, oSubasta.Bien.PrecioBaseDolares.ToString("N2"), oSubasta.Bien.PrecioVentaDirectaDolares.ToString("N2"));
                }

            }
        }
        /// <summary>
        /// Carga el DGV según el filtro por tipo.
        /// </summary>
        /// <param name="pTipo"></param>
        /// <returns></returns>
        private void CargarDGVByBien(TipoBien pTipo)
        {
            dgvSubastas.Rows.Clear();

            dgvSubastas.Rows.Clear();
            foreach (Subasta oSubasta in subastasActivas)
            {
                if (oSubasta.Estado == Enums.ETipoEstadoSubasta.ACTIVA)
                {
                    if (oSubasta.Bien.Tipo.IdTipoBien == pTipo.IdTipoBien)
                    {
                        oSubasta.Bien.PrecioVentaDirectaColones = oSubasta.Bien.PrecioVentaDirectaDolares * this.cambio;
                        oSubasta.Bien.PrecioBaseColones = oSubasta.Bien.PrecioBaseDolares * this.cambio;
                        string fechaHoraInicio = oSubasta.FechaApertura.ToString("dd/MM/yyyy") + " " + oSubasta.HoraApertura.ToString(@"hh\:mm");
                        string fechaHoraCierre = oSubasta.FechaCierre.ToString("dd/MM/yyyy") + " " + oSubasta.HoraCierre.ToString(@"hh\:mm");
                        dgvSubastas.Rows.Add(oSubasta.IdSubasta, oSubasta.Bien.Descripcion, oSubasta.Incremento.ToString("N2"), fechaHoraInicio,
                                             fechaHoraCierre, oSubasta.Bien.PrecioBaseDolares.ToString("N2"), oSubasta.Bien.PrecioVentaDirectaDolares.ToString("N2"));
                    }
                }
            }
        }
        private async void frmSubastasActivas_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                this.cambio = await ApiReader.GetTipoCambio();
                cboCategoriaBien.Enabled = false;
                btnParticipar.Enabled = false;
                tmrRefrescar.Start();
                Cursor = Cursors.WaitCursor;
                subastasActivas = this.oBLLSubasta.GetAllSubastasActivas();
                dgvSubastas.Rows.Clear();
                this.CargarCombo();
                this.CargarDGV();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnParticipar.Enabled = true;
                cboCategoriaBien.Enabled = true;
            }
        }

        private void btnParticipar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (dgvSubastas.Rows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una subasta de la lista.", "SELECCIÓN NO VÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string idSubasta = dgvSubastas.CurrentRow.Cells[0].Value.ToString();
                List<Subasta> subastasCliente = new List<Subasta>();
                subastasCliente = this.oBLLSubasta.GetSubastaByCliente(UsuarioLogeado.GetInstance().IdUsuario);
                if (subastasCliente.Count > 0)
                {
                    foreach (Subasta oSubasta in subastasCliente)
                    {
                        if (oSubasta.IdSubasta == idSubasta)
                        {
                            this.Close();
                            return;
                        }
                    }
                }

                DialogResult resupuesta = MessageBox.Show("Seguro (a) que desea participar de esta subasta.", "CONFIRMAR ACCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (resupuesta == DialogResult.No || resupuesta == DialogResult.Cancel)
                {
                    return;
                }

                this.oBLLSubasta.InsertClienteSubasta(UsuarioLogeado.GetInstance().IdUsuario, idSubasta);
                this.Close();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }

        }

        private void cboCategoriaBien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "";

            try
            {
                this.cargarImagen = false;
                dgvSubastas.Rows.Clear();
                ptbFoto.SizeMode = PictureBoxSizeMode.CenterImage;
                ptbFoto.Image = Resources.imagen_icon;
                this.cargarImagen = true;
                if (cboCategoriaBien.SelectedIndex == 0)
                {
                    dgvSubastas.Rows.Clear();
                    this.CargarDGV();
                }
                else
                {
                    dgvSubastas.Rows.Clear();
                    TipoBien oTipo = cboCategoriaBien.SelectedItem as TipoBien;
                    this.CargarDGVByBien(oTipo);
                }
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }

        private void dgvSubastas_SelectionChanged(object sender, EventArgs e)
        {
            string msg = "";

            try
            {
                Cursor = Cursors.WaitCursor;
                if (!this.cargarImagen)
                {
                    this.cargarImagen = true;
                    return;
                }
                if (dgvSubastas.Rows.Count > 0)
                {
                    string idSubasta = dgvSubastas.CurrentRow.Cells[0].Value.ToString();
                    foreach (Subasta oSubasta in subastasActivas)
                    {
                        if (oSubasta.IdSubasta == idSubasta)
                        {
                            using (MemoryStream ms = new MemoryStream(oSubasta.Bien.Fotografias[0].Imagen))
                            {
                                ptbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                                ptbFoto.Image = Image.FromStream(ms);
                            }
                            break;
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
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void tmrRefrescar_Tick(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                subastasActivas = this.oBLLSubasta.GetAllSubastas();
                cboCategoriaBien_SelectedIndexChanged(sender, e);
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
