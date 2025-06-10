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
    public partial class frmReporteFacturacion : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private IBLLFactura oBLLFactura = new BLLFactura();
        public frmReporteFacturacion()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Evita el parpadeo del frame.
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
        private void frmReporteFacturacion_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                dtpFechaInicio.Value = dtpFechaInicio.MinDate;
                dtpFechaFinal.MinDate = dtpFechaInicio.Value.AddDays(1);
                dtpFechaFinal.Value = DateTime.Now.AddDays(1);
                facturaBindingSource.DataSource = this.oBLLFactura.GetAll();
                this.reportViewer1.RefreshReport();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);

            }


            
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                dtpFechaInicio.Value = dtpFechaInicio.MinDate;
                dtpFechaFinal.Value = DateTime.Now.AddDays(1);
                facturaBindingSource.DataSource = this.oBLLFactura.GetAll();
                this.reportViewer1.RefreshReport();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);

            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                dtpFechaFinal.MinDate = dtpFechaInicio.Value.AddDays(1);
                
                facturaBindingSource.DataSource = this.oBLLFactura.GetAllFacturasByFecha(dtpFechaInicio.Value, dtpFechaFinal.Value);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);

            }
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                facturaBindingSource.DataSource = this.oBLLFactura.GetAllFacturasByFecha(dtpFechaInicio.Value, dtpFechaFinal.Value);
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
