using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using winShootForItAuctions.Properties;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Util;
using winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS;
using log4net;
using Microsoft.VisualBasic;
using System.Reflection;
using winShootForItAuctions.Extensions;

namespace winShootForItAuctions.Layers.UI
{
    public partial class frmLogIn : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        IBLLUsuario oBLLUsuario = new BLLUsuario();

        public frmLogIn()
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

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "IDENTIFICACIÓN")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "IDENTIFICACIÓN";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContrasenna_Enter(object sender, EventArgs e)
        {
            if (txtContrasenna.Text == "CONTRASEÑA")
            {
                txtContrasenna.Text = "";
                txtContrasenna.ForeColor = Color.White;
                txtContrasenna.UseSystemPasswordChar = false;
            }
            ptbMostrarContrasenna_Click(sender, e);
        }

        private void txtContrasenna_Leave(object sender, EventArgs e)
        {
            if (txtContrasenna.Text == "")
            {
                txtContrasenna.Text = "CONTRASEÑA";
                txtContrasenna.ForeColor = Color.Silver;
                txtContrasenna.UseSystemPasswordChar = false;
                ptbMostrarContrasenna.Image = Resources.mostrar_contrasenna_icon;
            }
        }

        private void frmLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var frmRegistro = new frmRegistro();
            frmRegistro.ShowDialog();
            this.Show();
        }

        

        private void ptbMostrarContrasenna_Click(object sender, EventArgs e)
        {

            txtContrasenna.UseSystemPasswordChar = !txtContrasenna.UseSystemPasswordChar;

            if (txtContrasenna.UseSystemPasswordChar == true)
            {
                ptbMostrarContrasenna.Image = Resources.ocultar_contrasenna_icon;
            }
            else
            {
                ptbMostrarContrasenna.Image = Resources.mostrar_contrasenna_icon;
            }
        }

        private async void frmLogIn_Load(object sender, EventArgs e)
        {
            await ApiReader.LoadNacionalidades();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                bool credencialesCorrectas = this.oBLLUsuario.LogIn(txtUsuario.Text, txtContrasenna.Text);
                if (!credencialesCorrectas)
                {
                    MessageBox.Show("Las credenciales no son correctas.", "CREDENCIALES INCORRECTAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (UsuarioLogeado.GetInstance().Estado == Enums.ETipoEstadoCliente.PENDIENTE)
                {
                    MessageBox.Show("Su registro de cuenta se encuentra pendiente. " +
                        "Pronto un administrador aceptará su solicitud.", "USUARIO PENDIENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (UsuarioLogeado.GetInstance().Estado == Enums.ETipoEstadoCliente.DECLINADO)
                {
                    MessageBox.Show("Un administrador ha declinado su Solicitud de Registro.", "USUARIO DECLINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.Close();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtContrasenna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                bool credencialesCorrectas = this.oBLLUsuario.LogIn(txtUsuario.Text, txtContrasenna.Text);
                if (!credencialesCorrectas)
                {
                    MessageBox.Show("Las credenciales no son correctas.", "CREDENCIALES INCORRECTAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (UsuarioLogeado.GetInstance().Estado == Enums.ETipoEstadoCliente.PENDIENTE)
                {
                    MessageBox.Show("Su registro de cuenta se encuentra pendiente. " +
                        "Pronto un administrador aceptará su solicitud.", "USUARIO PENDIENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (UsuarioLogeado.GetInstance().Estado == Enums.ETipoEstadoCliente.DECLINADO)
                {
                    MessageBox.Show("Un administrador ha declinado su Solicitud de Registro.", "USUARIO DECLINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.Close();
            }

            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
