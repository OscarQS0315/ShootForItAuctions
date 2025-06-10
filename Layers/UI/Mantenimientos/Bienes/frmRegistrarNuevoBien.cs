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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Enums;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS;
using winShootForItAuctions.Properties;

namespace winShootForItAuctions.Layers.UI
{
    public partial class frmRegistrarNuevoBien : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private IBLLBien oBLLBien = new BLLBien();
        private IBLLCategoriaBien oBLLCategoriaBien = new BLLCategoriaBien();

        private List<Fotografia> fotos = new List<Fotografia>();
        public frmRegistrarNuevoBien()
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
        private async Task CargarCombo()
        {
            cboCategoriaBien.Items.Clear();
            List<TipoBien> categorias = await oBLLCategoriaBien.GetAllCategoriasAsync();
            foreach (TipoBien tipoBien in categorias)
            {
                cboCategoriaBien.Items.Add(tipoBien);
            }
        }

        /// <summary>
        /// Limpia todos los controles.
        /// </summary>
        private async void LimpiarCampos()
        {
            await this.CargarCombo();
            this.fotos = new List<Fotografia>();
            txtDescripcion.Text = "";
            txtPrecioBase.Text = "";
            txtPrecioVentaDirecta.Text = "";
            txtDescripcionCategoria.Text = "";
            dgvFotografias.Rows.Clear();
            ptbImagen.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbImagen.Image = Resources.imagen_icon;
        }

        private void CargarDGV()
        {
            dgvFotografias.Rows.Clear();
            for (int i = 0; i < this.fotos.Count; i++)
            {
                dgvFotografias.Rows.Add(this.fotos[i].ToString() + " " + (i + 1));
            }
        }
        private async void frmRegistrarNuevoBien_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                this.ControlBox = false;
                await this.CargarCombo();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
        }



        private void btnInscribir_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (cboCategoriaBien.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una categoría de bien", "CATEGORÍA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtDescripcion.Text.Trim() == null)
                {
                    MessageBox.Show("Debe proporcionar una descripción válida", "DESCRIPCIÓN NO VÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!Regex.IsMatch(txtPrecioBase.Text, @"^\d+$"))
                {
                    MessageBox.Show("Debe proporcionar una precio base válido", "PRECIO BASE NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!Regex.IsMatch(txtPrecioVentaDirecta.Text, @"^\d+$"))
                {
                    MessageBox.Show("Debe proporcionar una precio de venta directa válido", "PRECIO DE VENTA DIRECTA NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (this.fotos.Count == 0)
                {
                    MessageBox.Show("Debe proporcionar almenos una imagen del bien", "IMAGEN NECESARIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Bien oNuevoBien = new Bien()
                {
                    Descripcion = txtDescripcion.Text,
                    Estado = Enums.ETipoEstadoBien.DISPONIBLE,
                    PrecioBaseDolares = Convert.ToInt32(txtPrecioBase.Text),
                    PrecioVentaDirectaDolares = Convert.ToDecimal(txtPrecioVentaDirecta.Text),
                    Tipo = cboCategoriaBien.SelectedItem as TipoBien,
                    Fotografias = this.fotos
                };

                oBLLBien.Insert(oNuevoBien, UsuarioLogeado.GetInstance().IdUsuario);

                MessageBox.Show("Bien registrado a su nombre con éxito." + Environment.NewLine +
                                "Puede verlos en el apartado de Mis Bienes / Disponibles.", "OPERACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LimpiarCampos();

            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
        }

        private void txtPrecioBase_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecioVentaDirecta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro (a) que desea limpiar los campos." + Environment.NewLine +
                                                         "Los datos proporcionados como las imágenes se eliminarán.", "CONFIRMAR ACCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (respuesta == DialogResult.No || respuesta == DialogResult.Cancel)
                {
                    return;
                }
                this.LimpiarCampos();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
        }

        private void cboCategoriaBien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                TipoBien oTipo = cboCategoriaBien.SelectedItem as TipoBien;
                txtDescripcionCategoria.Text = oTipo.Descripcion.ToString();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
        }

        private void btnAnnadir_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                OpenFileDialog opt = new OpenFileDialog();
                opt.Title = "Seleccione la Imagen ";
                opt.SupportMultiDottedExtensions = true;
                opt.DefaultExt = "*.jpg";
                opt.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| Archivos PNG (*.png)|*.png| Archivos JEPG (*.jpeg)|*.jpeg";
                opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                opt.FileName = "";

                if (opt.ShowDialog(this) == DialogResult.OK)
                {

                    ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);
                    Fotografia oFoto = new Fotografia()
                    {
                        Imagen = cadenaBytes
                    };
                    this.fotos.Add(oFoto);
                    this.CargarDGV();
                }
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
        }
        private void dgvFotografias_SelectionChanged(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (dgvFotografias.SelectedRows.Count > 0)
                {
                    int indice = dgvFotografias.CurrentCell.RowIndex;
                    using (MemoryStream ms = new MemoryStream(this.fotos[indice].Imagen))
                    {
                        ptbImagen.Image = Image.FromStream(ms);
                    }

                }
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (dgvFotografias.SelectedRows.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show("Seguro (a) que desea eliminar la imagen.", "CONFIRMAR ACCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        int indice = dgvFotografias.CurrentCell.RowIndex;
                        this.fotos.Remove(fotos[indice]);
                        this.CargarDGV();
                    }
                }
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
        }

        private void tlpRegistrarNuevoBien_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
