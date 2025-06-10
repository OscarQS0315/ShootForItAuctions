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

namespace winShootForItAuctions.Layers.UI.Reportes
{
    public partial class frmReporteBien : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private IBLLBien oBLLBien = new BLLBien();
        private IBLLCategoriaBien oBLLCategoriaBien = new BLLCategoriaBien();
        public frmReporteBien()
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
        /// Carga el cbo con las categorías actuales.
        /// </summary>
        private async void CargarCBO()
        {
            cboCategoria.Items.Clear();
            List<TipoBien> tipos = new List<TipoBien>();
            tipos = await this.oBLLCategoriaBien.GetAllCategoriasAsync();
            cboCategoria.Items.Clear();
            cboCategoria.Items.Add("TODAS");
            foreach (TipoBien tipo in tipos)
            {
                cboCategoria.Items.Add(tipo);
            }
            cboCategoria.SelectedIndex = 0;
        }
        private void frmReporteBien_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                this.CargarCBO();
                bienBindingSource.DataSource = this.oBLLBien.GetAll();
                this.reportViewer1.RefreshReport();
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

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (cboCategoria.SelectedIndex == 0)
                {
                    bienBindingSource.DataSource = this.oBLLBien.GetAll();
                }
                else
                {
                    TipoBien tipo = cboCategoria.SelectedItem as TipoBien;
                    bienBindingSource.DataSource = this.oBLLBien.GetByIdTipo(tipo.IdTipoBien);
                }

                this.reportViewer1.RefreshReport();
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
