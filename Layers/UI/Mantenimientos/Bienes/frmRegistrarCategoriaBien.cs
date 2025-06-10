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
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Layers.UI
{
    public partial class frmRegistrarCategoriaBien : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        IBLLCategoriaBien oBLLCategoriaBien = new BLLCategoriaBien();
        public frmRegistrarCategoriaBien()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
        }
        /// <summary>
        /// Carga el dataGridView con las categorias actuales.
        /// 
        /// </summary>
        private async Task CargarDGV()
        {
            dgvCategorias.Rows.Clear();
            List<TipoBien> categorias = new List<TipoBien>();
            categorias = await this.oBLLCategoriaBien.GetAllCategoriasAsync();

            foreach (var categoria in categorias)
            {
                dgvCategorias.Rows.Add(categoria.IdTipoBien, categoria.Nombre, categoria.Descripcion);
            }
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
        private async void frmRegistrarCategoriaBien_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                this.ControlBox = false;
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

        private void lblTipoIdentificacion_Click(object sender, EventArgs e)
        {

        }

        private void tlpRegistrarCategoriaBien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (txtNombre.Text.Trim() == "")
                {
                    MessageBox.Show("El nombre de la categoría es requerido.", "NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                    return;
                }
                if (txtDescripcion.Text.Trim() == "")
                {
                    MessageBox.Show("La decripción de la categoría es requerida.", "DESCRIPCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcion.Focus();
                    return;
                }

                TipoBien oNuevaCategoria = new TipoBien()
                {
                    Descripcion = txtDescripcion.Text,
                    Nombre = txtNombre.Text
                };

                this.oBLLCategoriaBien.InsertarCategoriaBien(oNuevaCategoria);
                MessageBox.Show("Categoría registrada con éxito", "OPERACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await this.CargarDGV();
                this.LimpiarCampos();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (dgvCategorias.Rows.Count > 0)
                {

                    int idCategoria = Convert.ToInt32(dgvCategorias.CurrentRow.Cells[0].Value);
                    DialogResult respuesta = MessageBox.Show("Seguro(a) que desea eliminar esta categoría", "CONFIRMAR ACCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if(respuesta == DialogResult.No || respuesta == DialogResult.Cancel)
                    {
                        return;
                    }
                    this.oBLLCategoriaBien.DeleteById(idCategoria);
                    await this.CargarDGV();
                    MessageBox.Show("Categoría eliminada con éxito", "ACCIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
