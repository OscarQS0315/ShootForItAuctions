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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS;
using winShootForItAuctions.Properties;
using winShootForItAuctions.Util;

namespace winShootForItAuctions.Layers.UI
{
    public partial class frmBienesDisponibles : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        IBLLBien oBLLBien = new BLLBien();
        IBLLCategoriaBien oBLLCategoriaBien = new BLLCategoriaBien();
        private List<Bien> bienesActuales = new List<Bien>();
    
        public frmBienesDisponibles()
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
        /// Carga el DGV con la información de los bienes necesaria
        /// </summary>
        private async Task CargarDGV()
        {
            Cursor = Cursors.WaitCursor;
            var bienes = await oBLLBien.GetByIdDuennoAsync(UsuarioLogeado.GetInstance().IdUsuario, frmMain.tipoCambio);
            this.bienesActuales = bienes;
            dgvBienes.Rows.Clear();
            foreach (Bien oBien in bienes)
            {
                if(oBien.Estado == Enums.ETipoEstadoBien.DISPONIBLE)
                {
                    dgvBienes.Rows.Add(oBien.IdBien, oBien.Descripcion, oBien.PrecioBaseColones.ToString("n2"),
                                   oBien.PrecioBaseDolares.ToString("n2"), oBien.PrecioVentaDirectaDolares.ToString("n2"),
                                   oBien.PrecioVentaDirectaColones.ToString("n2"), oBien.Estado.ToString());
                }
            }
            Cursor = Cursors.Default;
        }
        private void frmBienesDisponibles_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                this.ControlBox = false;
                this.CargarCombo();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }

        }

        private async void btnModificarBien_Click_1(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (dgvBienes.SelectedRows.Count > 0)
                {
                    int idBien = Convert.ToInt32(dgvBienes.CurrentRow.Cells[0].Value);
                    foreach (Bien oBien in this.bienesActuales)
                    {
                        if (oBien.IdBien == idBien)
                        {
                            frmModificarBien oFrmModificarBien = new frmModificarBien(oBien);
                            oFrmModificarBien.ShowDialog();
                            break;
                        }
                    }
                    await this.CargarDGV();
                }
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }

        }

        private async void btnHabilitarDehabilitarBien_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (dgvBienes.SelectedRows.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show("Desea actualizar el estado del Bien.", "CONFIRMAR ACCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.No || respuesta == DialogResult.Cancel)
                    {
                        return;
                    }

                    int idBien = Convert.ToInt32(dgvBienes.CurrentRow.Cells[0].Value);
                    foreach (Bien oBien in this.bienesActuales)
                    {
                        if (oBien.IdBien == idBien)
                        {
                            if (oBien.Estado == Enums.ETipoEstadoBien.DISPONIBLE)
                            {
                                oBien.Estado = Enums.ETipoEstadoBien.DESHABILITADO;
                            }
                            else if (oBien.Estado == Enums.ETipoEstadoBien.DESHABILITADO)
                            {
                                oBien.Estado = Enums.ETipoEstadoBien.DISPONIBLE;
                            }
                            this.oBLLBien.Update(oBien, UsuarioLogeado.GetInstance().IdUsuario);
                            break;
                        }
                    }
                    await this.CargarDGV();
                }
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
        }

        private void btnIniciarSubasta_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                dgvBienes.Rows.Clear();
                if (!Regex.IsMatch(txtCódigo.Text, @"^\d+$"))
                {
                    MessageBox.Show("El código del Bien debe ser numérico", "CÓDIGO NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int idBien = Convert.ToInt32(txtCódigo.Text);
                foreach (Bien oBien in this.bienesActuales)
                {
                    if (idBien == oBien.IdBien)
                    {
                        dgvBienes.Rows.Add(oBien.IdBien, oBien.Descripcion, oBien.PrecioBaseColones.ToString("n2"),
                                   oBien.PrecioBaseDolares.ToString("n2"), oBien.PrecioVentaDirectaDolares.ToString("n2"),
                                   oBien.PrecioVentaDirectaColones.ToString("n2"), oBien.Estado.ToString());
                        break;
                    }
                }
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
        }



        private void dgvBienes_SelectionChanged(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (dgvBienes.SelectedRows.Count > 0)
                {
                    int idBien = Convert.ToInt32(dgvBienes.CurrentRow.Cells[0].Value);
                    txtCódigo.Text = idBien.ToString();
                    foreach (Bien oBien in this.bienesActuales)
                    {
                        if (oBien.IdBien == idBien)
                        {
                            using (MemoryStream ms = new MemoryStream(oBien.Fotografias[0].Imagen))
                            {
                                ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                                ptbImagen.Image = Image.FromStream(ms);
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
                return;
            }
        }

        private void txtCódigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private async void cboCategoriaBien_SelectedIndexChanged(object sender, EventArgs e)
        {
            String msg = "";
            try
            {
                if (cboCategoriaBien.SelectedIndex == 0)
                {
                    await this.CargarDGV();
                }
                else
                {
                    ptbImagen.Image = Resources.imagen_icon;
                    dgvBienes.Rows.Clear();
                    TipoBien oTipo = cboCategoriaBien.SelectedItem as TipoBien;
                    foreach (Bien oBien in this.bienesActuales)
                    {
                        if (oBien.Tipo.Nombre == oTipo.Nombre)
                        {
                            dgvBienes.Rows.Add(oBien.IdBien, oBien.Descripcion, oBien.PrecioBaseColones.ToString("n2"),
                                               oBien.PrecioBaseDolares.ToString("n2"), oBien.PrecioVentaDirectaDolares.ToString("n2"),
                                               oBien.PrecioVentaDirectaColones.ToString("n2"), oBien.Estado.ToString());
                        }
                    }
                }

            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
        }

        private async void btnTodos_Click(object sender, EventArgs e)
        {
            string msg = "";

            try
            {
                cboCategoriaBien.SelectedIndex = 0;
                await this.CargarDGV();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
        }

        private void tlpBienesDisponibles_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
