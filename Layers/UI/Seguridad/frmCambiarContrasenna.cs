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
using winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS;
using winShootForItAuctions.Util;

namespace winShootForItAuctions.Layers.UI.Seguridad
{
    public partial class frmCambiarContrasenna : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private IBLLUsuario oBLLUsuario = new BLLUsuario();
        public frmCambiarContrasenna()
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro (a) que desea actualizar su contraseña", "CONFIRMAR ACCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No || respuesta == DialogResult.Cancel)
                {
                    return;
                }
                if (txtContrasennaActual.Text.Trim() == "" || Utilitarios.EncriptarContrasenna(txtContrasennaActual.Text.Trim()) != UsuarioLogeado.GetInstance().Contrasenna)
                {
                    MessageBox.Show("La contraseña indicada no coincide con la contraseña actual.", "CONTRASEÑA INCORRECTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContrasennaActual.Focus();
                    return;
                }
                if (txtNuevaContrasenna.Text.Trim() == "")
                {
                    MessageBox.Show("La nueva contraseña indicada no puede estar en blanco.", "CONTRASEÑA INCORRECTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNuevaContrasenna.Focus();
                    return;
                }
                if (txtConfirmarContrasenna.Text.Trim() == "")
                {
                    MessageBox.Show("La confirmaciób de la nueva contraseña indicada no puede estar en blanco.", "CONTRASEÑA INCORRECTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtConfirmarContrasenna.Focus();
                    return;
                }
                if (txtNuevaContrasenna.Text != txtConfirmarContrasenna.Text)
                {
                    MessageBox.Show("La nueva contraseña y la confirmación no coinciden.", "CONTRASEÑA INCORRECTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtConfirmarContrasenna.Focus();
                    return;
                }
                UsuarioLogeado.GetInstance().Contrasenna = Utilitarios.EncriptarContrasenna(txtConfirmarContrasenna.Text);
                this.oBLLUsuario.Update(UsuarioLogeado.GetInstance());
                MessageBox.Show("Contraseña actualizada con éxito.", "ACCIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmarContrasenna.Text = "";
                txtContrasennaActual.Text = "";
                txtNuevaContrasenna.Text = "";
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }

        private void txtContrasennaActual_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNuevaContrasenna_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtConfirmarContrasenna_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
