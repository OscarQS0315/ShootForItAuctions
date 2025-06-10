using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Properties;
using winShootForItAuctions.Util;

namespace winShootForItAuctions.Layers.UI
{
    public partial class frmRegistro : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        private IBLLUsuario oBLLUsuario = new BLLUsuario();
        public frmRegistro()
        {
            InitializeComponent();
            this.LlenarCombos();

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
        /// Llena los comboBox con la información correspondiente.
        /// </summary>
        private async void LlenarCombos()
        {
            cboCanton.Items.Clear();
            cboProvincia.Items.Clear();
            cboDistrito.Items.Clear();
            cboNacionalidad.Items.Clear();
            cboTipoIdentificacion.Items.Clear();
            cboTipoIdentificacion.Items.Add("NACIONAL");
            cboTipoIdentificacion.Items.Add("PASAPORTE");
            cboTipoIdentificacion.Items.Add("DIMEX");
            await ApiReader.LoadProvincia(cboProvincia);
            cboNacionalidad.DataSource = Nacionalidad.Nacionalidades;
            cboNacionalidad.SelectedIndex = -1;
        }
        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void frmRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtIdentificacion_Enter(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text == "IDENTIFICACIÓN")
            {
                txtIdentificacion.Text = "";
                txtIdentificacion.ForeColor = Color.White;
            }
        }

        private async void txtIdentificacion_Leave(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text.Trim() == "")
            {
                txtIdentificacion.Text = "IDENTIFICACIÓN";
                txtIdentificacion.ForeColor = Color.Silver;
            }
            else
            {
                if (cboTipoIdentificacion.SelectedIndex == 0)
                {
                    if (Regex.IsMatch(txtIdentificacion.Text, @"^\d{9}$"))
                    {
                        await ApiReader.LoadIdentificacionNacional(Convert.ToInt32(txtIdentificacion.Text), txtNombre, txtPrimerApellido, txtSegundoApellido);
                    }
                }
            }
        }

        private void txtPrimerApellido_Enter(object sender, EventArgs e)
        {
            if (txtPrimerApellido.Text == "PRIMER APELLIDO")
            {
                txtPrimerApellido.Text = "";
                txtPrimerApellido.ForeColor = Color.White;
            }
        }

        private void txtPrimerApellido_Leave(object sender, EventArgs e)
        {
            if (txtPrimerApellido.Text.Trim() == "")
            {
                txtPrimerApellido.Text = "PRIMER APELLIDO";
                txtPrimerApellido.ForeColor = Color.Silver;
            }
        }

        private void txtSegundoApellido_Enter(object sender, EventArgs e)
        {
            if (txtSegundoApellido.Text == "SEGUNDO APELLIDO")
            {
                txtSegundoApellido.Text = "";
                txtSegundoApellido.ForeColor = Color.White;
            }
        }

        private void txtSegundoApellido_Leave(object sender, EventArgs e)
        {
            if (txtSegundoApellido.Text.Trim() == "")
            {
                txtSegundoApellido.Text = "SEGUNDO APELLIDO";
                txtSegundoApellido.ForeColor = Color.Silver;
            }
        }

        private void rdbFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "TELÉFONO")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.White;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Trim() == "")
            {
                txtTelefono.Text = "TELÉFONO";
                txtTelefono.ForeColor = Color.Silver;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {

                if (cboTipoIdentificacion.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de indetificación válido", "IDENTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTipoIdentificacion.Focus();
                    return;
                }
                if (cboTipoIdentificacion.SelectedIndex == 0)
                {
                    if (!Regex.IsMatch(txtIdentificacion.Text, @"^\d{9}$"))
                    {
                        MessageBox.Show("La identificación debe contener 9 números", "IDENTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdentificacion.Focus();
                        return;
                    }
                }
                else if (cboTipoIdentificacion.SelectedIndex == 2)
                {
                    if (!Regex.IsMatch(txtIdentificacion.Text, @"^\d{12}$"))
                    {
                        MessageBox.Show("La identificación debe contener 12 números", "IDENTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdentificacion.Focus();
                        return;
                    }
                }
                Usuario oUsuarioExistente = this.oBLLUsuario.GetById(txtIdentificacion.Text);
                if (oUsuarioExistente != null)
                {
                    MessageBox.Show("Ya existe un usuario registrado con el número de identificación indicado.", "USUARIO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdentificacion.Focus();
                    return;
                }
                if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z]+$") || txtNombre.Text == "NOMBRE")
                {
                    MessageBox.Show("Nombre inválido.", "NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                    return;
                }
                if (!Regex.IsMatch(txtPrimerApellido.Text, @"^[a-zA-Z]+$") || txtPrimerApellido.Text == "PRIMER APELLIDO")
                {
                    MessageBox.Show("Primer Apellido inválido.", "PRIMER APELLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrimerApellido.Focus();
                    return;
                }
                if (!Regex.IsMatch(txtSegundoApellido.Text, @"^[a-zA-Z]+$") || txtSegundoApellido.Text == "SEGUNDO APELLIDO")
                {
                    MessageBox.Show("Segundo Apellido inválido.", "SEGUNDO APELLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSegundoApellido.Focus();
                    return;
                }
                if (cboNacionalidad.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una nacionalidad válida.", "NACIONALIDAD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboNacionalidad.Focus();
                    return;
                }
                if (!chkCliente.Checked && !chkDuenno.Checked)
                {
                    MessageBox.Show("Debe seleccionar al menos un rol de usuario.", "ROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chkDuenno.Focus();
                    return;
                }
                if (!Utilitarios.ValidarCorreo(txtCorreoElectronico.Text))
                {
                    MessageBox.Show("El correo electrónico no posee el formato correcto.", "CORREO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCorreoElectronico.Focus();
                    return;
                }

                if (!Regex.IsMatch(txtTelefono.Text, @"^\d{8}$"))
                {
                    MessageBox.Show("El número telefónico debe ser numérico y tiene que tener la longitud necesaria.", "NÚMERO TELEFÓNICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefono.Focus();
                    return;
                }
                if (cboProvincia.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una Provincia válida", "DIRECCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboProvincia.Focus();
                    return;
                }
                if (cboCanton.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un Cantón válido", "DIRECCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboCanton.Focus();
                    return;
                }
                if (cboDistrito.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un Distrito válido", "DIRECCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboDistrito.Focus();
                    return;
                }
                if (txtDireccion.Text.Length == 0 || txtDireccion.Text == "DIRECCIÓN")
                {
                    MessageBox.Show("Debe suministrar al menos alguna indicación", "DIRECCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDireccion.Focus();
                    return;
                }
                if (txtContrasenna.Text != txtConfirmarContrasenna.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "CONTRASEÑA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtConfirmarContrasenna.Focus();
                    return;
                }

                Usuario oUsuario = new Usuario();
                oUsuario.IdUsuario = txtIdentificacion.Text.ToUpper();
                oUsuario.Nombre = txtNombre.Text.ToUpper();
                oUsuario.Apellido_1 = txtPrimerApellido.Text.ToUpper();
                oUsuario.Apellido_2 = txtSegundoApellido.Text.ToUpper();
                oUsuario.AgregarSexo(rdbMasculino.Checked, rdbFemenino.Checked);
                oUsuario.Nacionalidad = cboNacionalidad.SelectedItem.ToString();
                oUsuario.AgregarRoles(chkDuenno.Checked, chkCliente.Checked);
                oUsuario.Correo = txtCorreoElectronico.Text;
                oUsuario.Telefono = Convert.ToInt32(txtTelefono.Text);
                Distrito oDistrito = cboDistrito.SelectedItem as Distrito;
                oUsuario.CodigoPostal = oDistrito.IdDistrito;
                oUsuario.Sennas = txtDireccion.Text;
                oUsuario.Contrasenna = txtContrasenna.Text;

                this.oBLLUsuario.Insert(oUsuario);
                if (oUsuario.Roles.Contains(Enums.ETipoUsuario.CLIENTE))
                {
                    MessageBox.Show("Solicitud de Registro exitosa. " + Environment.NewLine +
                                    "Notamos que el usuario solicitó el rol de Cliente, pronto un Administrador aceptará su Solicitud de Registro.",
                                    "OPRERACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Solicitud de Registro exitosa. " + Environment.NewLine +
                                    "Puede proceder a realizar su Inicio de Sesión.",
                                    "OPRERACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                throw;
            }

        }





        private void txtCorreoElectronico_Enter(object sender, EventArgs e)
        {
            if (txtCorreoElectronico.Text == "CORREO ELECTRÓNICO")
            {
                txtCorreoElectronico.Text = "";
                txtCorreoElectronico.ForeColor = Color.White;
            }
        }

        private void txtCorreoElectronico_Leave(object sender, EventArgs e)
        {
            if (txtCorreoElectronico.Text.Trim() == "")
            {
                txtCorreoElectronico.Text = "CORREO ELECTRÓNICO";
                txtCorreoElectronico.ForeColor = Color.Silver;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "DIRECCIÓN")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.White;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Trim() == "")
            {
                txtDireccion.Text = "DIRECCIÓN";
                txtDireccion.ForeColor = Color.Silver;
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
        }

        private void txtContrasenna_Leave(object sender, EventArgs e)
        {
            if (txtContrasenna.Text.Trim() == "")
            {
                txtContrasenna.Text = "CONTRASEÑA";
                txtContrasenna.ForeColor = Color.Silver;
                txtContrasenna.UseSystemPasswordChar = false;
            }
        }

        private void lklRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void txtConfirmarContrasenna_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarContrasenna.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtConfirmarContrasenna.Text = "";
                txtConfirmarContrasenna.ForeColor = Color.White;
                txtConfirmarContrasenna.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmarContrasenna_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarContrasenna.Text.Trim() == "")
            {
                txtConfirmarContrasenna.Text = "CONFIRMAR CONTRASEÑA";
                txtConfirmarContrasenna.ForeColor = Color.Silver;
                txtConfirmarContrasenna.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            txtConfirmarContrasenna.UseSystemPasswordChar = !txtConfirmarContrasenna.UseSystemPasswordChar;
            txtContrasenna.UseSystemPasswordChar = !txtContrasenna.UseSystemPasswordChar;

            if (txtConfirmarContrasenna.UseSystemPasswordChar == true)
            {
                ptbMostrarContrasenna.Image = Resources.ocultar_contrasenna_icon;
            }
            else
            {
                ptbMostrarContrasenna.Image = Resources.mostrar_contrasenna_icon;
            }
        }

        private async void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

            cboCanton.Items.Clear();
            cboDistrito.Items.Clear();
            lblCodigoPostal.Text = "CÓDIGO POSTAL";
            lblCodigoPostal.ForeColor = Color.Silver;
            Provincia oProvinciaSeleccionada = cboProvincia.SelectedItem as Provincia;

            await ApiReader.LoadCantones(cboCanton, oProvinciaSeleccionada.IdProvincia);

        }

        private async void cboCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDistrito.Items.Clear();
            Canton oCantonSeleccionado = cboCanton.SelectedItem as Canton;

            await ApiReader.LoadDistritos(cboDistrito, oCantonSeleccionado.IdCanton);
        }

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            Distrito oDistritoSeleccionado = cboDistrito.SelectedItem as Distrito;
            lblCodigoPostal.Text = oDistritoSeleccionado.IdDistrito.ToString();
            lblCodigoPostal.ForeColor = Color.White;
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCorreoElectronico_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
