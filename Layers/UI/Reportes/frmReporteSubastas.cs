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

namespace winShootForItAuctions.Layers.UI.Reportes
{
    public partial class frmReporteSubastas : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private IBLLBien oBLLBien = new BLLBien();
        private IBLLSubasta oBLLSubasta = new BLLSubasta();
        public frmReporteSubastas()
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
        /// Carga el cbo con los bienes.
        /// </summary>
        private void CargarCombo()
        {
            cboBienes.Items.Clear();
            List<int> bienes = this.oBLLBien.GetIdsBien();
            cboBienes.Items.Add("TODOS");
            foreach (int id in bienes)
            {
                cboBienes.Items.Add(id);
            }
            cboBienes.SelectedIndex = 0;
        }
        private void frmReporteSubastas_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                this.CargarCombo();
                subastaBindingSource.DataSource = this.oBLLSubasta.GetAllSubastas();
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

        private void cboBienes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (cboBienes.SelectedIndex == 0)
                {
                    subastaBindingSource.DataSource = this.oBLLSubasta.GetAllSubastas();
                }
                else
                {
                    int id = Convert.ToInt32(cboBienes.SelectedItem);
                    subastaBindingSource.DataSource = this.oBLLSubasta.GetSubastaByBien(id);
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
