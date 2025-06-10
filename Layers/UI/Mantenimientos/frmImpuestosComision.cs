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

namespace winShootForItAuctions.Layers.UI.Mantenimientos
{
    public partial class frmImpuestosComision : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        IBLLParametro oBLLParametro = new BLLParametro();
        public frmImpuestosComision()
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



        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtComision_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmImpuestosComision_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                txtIVA.Text = this.oBLLParametro.GetIVA().ToString();
                txtComision.Text = this.oBLLParametro.GetPorcentajeComision().ToString();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (!double.TryParse(txtIVA.Text, out double val2))
                {
                    MessageBox.Show("El valor del IVA debe ser numérico.");
                    txtIVA.Focus();
                    return;
                }
                if (!double.TryParse(txtComision.Text, out double val))
                {
                    MessageBox.Show("El valor de la comisión debe ser numérico.");
                    txtComision.Focus();
                    return;
                }

                DialogResult respuesta = MessageBox.Show("Seguro (a) que desea actualizar la información", "CONFIRMAR ACCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No || respuesta == DialogResult.Cancel)
                {
                    this.frmImpuestosComision_Load(sender, e);
                    return;
                }
                this.oBLLParametro.UpdateIVA(Convert.ToDouble(txtIVA.Text));
                this.oBLLParametro.UpdateComision(Convert.ToDouble(txtComision.Text));

                this.frmImpuestosComision_Load(sender, e);

                MessageBox.Show("Información actualizada con éxito", "ACCIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
