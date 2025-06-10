using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace winShootForItAuctions.Layers.UI
{
    internal partial class frmModificarBien : Form
    {
        private Bien oBienActual = new Bien();
        private IBLLCategoriaBien oBLLCategoriaBien = new BLLCategoriaBien();
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private IBLLBien oBLLBien = new BLLBien();
        private List<Fotografia> fotosBorrar = new List<Fotografia>();
        private List<Fotografia> fotosInsertar = new List<Fotografia>();
        public frmModificarBien(Bien pBien)
        {
            this.oBienActual = pBien;
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

        private void CargarDGV()
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
        }
        /// <summary>
        /// Carga los datos del Bien.
        /// </summary>
        private void CargarDatos()
        {
            txtDuenno.Text = UsuarioLogeado.GetInstance().ToString();
            txtCodigo.Text = oBienActual.IdBien.ToString();
            txtCategoriaActual.Text = oBienActual.Tipo.ToString();

            txtDescripcion.Text = oBienActual.Descripcion;
            txtPrecioBase.Text = oBienActual.PrecioBaseDolares.ToString();
            txtPrecioVentaDirecta.Text = oBienActual.PrecioVentaDirectaDolares.ToString();

            this.CargarDGV();
        }
        private async void frmModificarBien_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                this.ControlBox = false;
                await this.CargarCombo();
                this.CargarDatos();

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

        private void txtPrecioVentDirecta_KeyPress(object sender, KeyPressEventArgs e)
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
                opt.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
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
                    this.oBienActual.Fotografias.Add(oFoto);
                    this.fotosInsertar.Add(oFoto);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (dgvFotos.SelectedRows.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show("Seguro (a) que desea eliminar la imagen.", "CONFIRMAR ACCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        int indice = dgvFotos.CurrentCell.RowIndex;
                        this.fotosBorrar.Add(this.oBienActual.Fotografias[indice]);
                        this.oBienActual.Fotografias.Remove(this.oBienActual.Fotografias[indice]);
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

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            if (this.fotosBorrar.Count > 0)
            {
                foreach (Fotografia oFoto in this.fotosBorrar)
                {
                    this.oBienActual.Fotografias.Add(oFoto);
                }
            }
            if (this.fotosInsertar.Count > 0)
            {
                foreach(Fotografia oFoto in this.fotosInsertar)
                {
                    this.oBienActual.Fotografias.Remove(oFoto);
                }
            }
            this.CargarDatos();


            this.fotosBorrar = new List<Fotografia>();
            this.fotosInsertar = new List<Fotografia>();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro (a) que desea modificar la información.", "CONFIRMAR ACCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No || respuesta == DialogResult.Cancel)
                {
                    return;
                }

                if (cboCategoriaBien.SelectedIndex != -1)
                {
                    this.oBienActual.Tipo = cboCategoriaBien.SelectedItem as TipoBien;
                }
                if (txtDescripcion.Text.Trim() == null)
                {
                    MessageBox.Show("Debe proporcionar una descripción válida", "DESCRIPCIÓN NO VÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!decimal.TryParse(txtPrecioBase.Text, out decimal i))
                {
                    MessageBox.Show("Debe proporcionar una precio base válido", "PRECIO BASE NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!decimal.TryParse(txtPrecioVentaDirecta.Text, out decimal j))
                {
                    MessageBox.Show("Debe proporcionar una precio de venta directa válido", "PRECIO DE VENTA DIRECTA NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                this.oBienActual.Descripcion = txtDescripcion.Text;
                this.oBienActual.PrecioBaseDolares = Convert.ToDecimal(txtPrecioBase.Text);
                this.oBienActual.PrecioVentaDirectaDolares = Convert.ToDecimal((txtPrecioVentaDirecta.Text));

                oBLLBien.Update(this.oBienActual, UsuarioLogeado.GetInstance().IdUsuario, this.fotosBorrar, this.fotosInsertar);

                MessageBox.Show("Bien Actualizado éxito.", "OPERACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
        }
    }
}
