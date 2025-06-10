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
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS;
using winShootForItAuctions.Properties;
using winShootForItAuctions.Util;

namespace winShootForItAuctions.Layers.UI.Procesos.Subastas
{
    public partial class frmMisSubastas : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private IBLLCategoriaBien oBLLCategoriaBien = new BLLCategoriaBien();
        private IBLLSubasta oBLLSubasta = new BLLSubasta();
        private bool cargarImagen = true;
        private List<Subasta> misSubastas = new List<Subasta>();
        private decimal cambio = 0;
        public frmMisSubastas()
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
        /// Carga el DGV con los datos de las Subastas.
        /// </summary>
        private void CargarDGV()
        {
            dgvSubastas.Rows.Clear();
            foreach (Subasta oSubasta in misSubastas)
            {
                    string fechaHoraInicio = oSubasta.FechaApertura.ToString("dd/MM/yyyy") + " " + oSubasta.HoraApertura.ToString(@"hh\:mm");
                    string fechaHoraCierre = oSubasta.FechaCierre.ToString("dd/MM/yyyy") + " " + oSubasta.HoraCierre.ToString(@"hh\:mm");
                    dgvSubastas.Rows.Add(oSubasta.IdSubasta, oSubasta.Bien.Descripcion, oSubasta.Incremento.ToString("N2"), fechaHoraInicio, fechaHoraCierre, oSubasta.Bien.PrecioBaseDolares, oSubasta.Estado);   
            }
        }

        /// <summary>
        /// Carga el DGV del bien con la información necesaria.
        /// </summary>
        /// <param name="pTipo"></param>
        /// <returns></returns>
        private void CargarDGVByBien(TipoBien pTipo)
        {

          
            dgvSubastas.Rows.Clear();
            foreach (Subasta oSubasta in misSubastas)
            {
                if (oSubasta.Bien.Tipo.IdTipoBien == pTipo.IdTipoBien)
                {

                    string fechaHoraInicio = oSubasta.FechaApertura.ToString("dd/MM/yyyy") + " " + oSubasta.HoraApertura.ToString(@"hh\:mm");
                    string fechaHoraCierre = oSubasta.FechaCierre.ToString("dd/MM/yyyy") + " " + oSubasta.HoraCierre.ToString(@"hh\:mm");
                    dgvSubastas.Rows.Add(oSubasta.IdSubasta, oSubasta.Bien.Descripcion, oSubasta.Incremento.ToString("N2"), fechaHoraInicio, fechaHoraCierre, oSubasta.Bien.PrecioBaseDolares, oSubasta.Estado);
                }

            }
        }
        private void btnVerEstado_Click(object sender, EventArgs e)
        {

        }

        private async void frmMisSubastas_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                this.cambio = await ApiReader.GetTipoCambio();
                Cursor = Cursors.WaitCursor;
                misSubastas = this.oBLLSubasta.GetSubastaByDuenno(UsuarioLogeado.GetInstance().IdUsuario);
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
            finally { Cursor = Cursors.Default; }
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


                    foreach (Subasta oSubasta in misSubastas)
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
    }
}
