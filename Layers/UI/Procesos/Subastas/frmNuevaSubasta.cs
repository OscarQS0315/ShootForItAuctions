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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS;
using winShootForItAuctions.Util;

namespace winShootForItAuctions.Layers.UI
{
    public partial class frmNuevaSubasta : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private IBLLBien oBLLBien = new BLLBien();
        private IBLLCategoriaBien oBLLCategoriaBien = new BLLCategoriaBien();
        private List<Bien> bienesActuales = new List<Bien>();
        private IBLLSubasta oBLLSubasta = new BLLSubasta();
        private IBLLParametro oBLLParametro = new BLLParametro();
        
        public frmNuevaSubasta()
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
        /// Carga el dataGridView con la información necesaria.
        /// </summary>
        private async void CargarDGV()
        {
            dgvBienes.Rows.Clear();
            this.bienesActuales = new List<Bien>();
            this.bienesActuales = await oBLLBien.GetByIdDuennoAsync(UsuarioLogeado.GetInstance().IdUsuario, frmMain.tipoCambio);

            foreach (Bien oBien in bienesActuales)
            {
                if (oBien.Estado == Enums.ETipoEstadoBien.DISPONIBLE)
                {
                    dgvBienes.Rows.Add(oBien.IdBien, oBien.Descripcion, oBien.PrecioBaseColones.ToString("n2"),
                                   oBien.PrecioBaseDolares.ToString("n2"), oBien.PrecioVentaDirectaDolares.ToString("n2"),
                                   oBien.PrecioVentaDirectaColones.ToString("n2"), oBien.Estado.ToString());
                }
            }
        }

        /// <summary>
        /// Carga los datos en el inicio.
        /// </summary>
        private void CargarDatos()
        {
            txtIncremento.Text = "";
            txtDuenno.Text = UsuarioLogeado.GetInstance().ToString().ToUpper();
            txtFechaHoraActual.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            dtpFechaCierre.MinDate = DateTime.Now;
            dtpHoraCierre.MinDate = DateTime.Now;
            this.CargarDGV();
        }
        private void frmNuevaSubasta_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                
                this.CargarDatos();
                tmrFechaHora.Start();
                this.ControlBox = false;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
        }





        private void btnIniciarSubasta_Click_1(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (!decimal.TryParse(txtIncremento.Text, out decimal i))
                {
                    MessageBox.Show("Debe proporcionar un incremento de puja válido.", "DATO NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIncremento.Focus();
                    return;
                }
                if (dgvBienes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un bien de la lista", "BIEN NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int idBien = Convert.ToInt32(dgvBienes.CurrentRow.Cells[0].Value);
                Bien oBienActual = new Bien();
                foreach (Bien oBien in this.bienesActuales)
                {
                    if (oBien.IdBien == idBien)
                    {
                        oBienActual = oBien;
                        break;
                    }
                }

                decimal comision = (decimal)this.oBLLParametro.GetPorcentajeComision();
                oBienActual.Estado = Enums.ETipoEstadoBien.SUBASTANDO;
                this.oBLLBien.Update(oBienActual, UsuarioLogeado.GetInstance().IdUsuario);
                Random oRandom = new Random();
                SubastaFacade oSubastaFacade = new SubastaFacade();
                oSubastaFacade.CrearSubasta(UsuarioLogeado.GetInstance().IdUsuario + "-" + oBienActual.IdBien.ToString() + "-" + oBienActual.Tipo.IdTipoBien + "-" + oRandom.Next(100, 10000),
                                            UsuarioLogeado.GetInstance(), oBienActual, dtpFechaCierre.Value,
                                            dtpHoraCierre.Value.TimeOfDay, comision, Convert.ToDecimal(txtIncremento.Text));

                this.oBLLSubasta.Insert(oSubastaFacade.Subasta);

                MessageBox.Show("Subasta creada con éxito" + Environment.NewLine +
                                "Para darle seguimiento puede ir a la pestaña de Subastas/Mis subastas.", "OPERACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tmrFechaHora.Stop();
                this.frmNuevaSubasta_Load(sender, e);

            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
        }

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                txtFechaHoraActual.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                dtpFechaCierre.MinDate = DateTime.Now;
                dtpHoraCierre.MinDate = DateTime.Now.AddMinutes(2);
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
        }

        private void txtIncremento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dtpFechaCierre_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
