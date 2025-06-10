using log4net;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
    public partial class frmRegistrarNuevoUsuario : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        IBLLUsuario oBLLUsuario = new BLLUsuario();
        public frmRegistrarNuevoUsuario()
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
        /// Llena los combos con su respectiva información.
        /// </summary>
        private async void LlenarCombos()
        {
            cboCanton.Items.Clear();
            cboDistrito.Items.Clear();
            cboProvincia.Items.Clear();
            cboTipoIdentificacion.Items.Clear();

            cboTipoIdentificacion.Items.Add("NACIONAL");
            cboTipoIdentificacion.Items.Add("PASAPORTE");
            cboTipoIdentificacion.Items.Add("DIMEX");

            await ApiReader.LoadProvincia(cboProvincia);
            cboNacionalidad.DataSource = Nacionalidad.Nacionalidades;
            cboNacionalidad.SelectedIndex = -1;
        }

        private async void LimpiarCampos()
        {
            
            cboProvincia.Items.Clear();
            

            txtIdentificacion.Text = "";
            cboTipoIdentificacion.SelectedIndex = -1;
            txtNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            cboNacionalidad.SelectedIndex = -1;
            txtCorreoElectronico.Text = "";
            txtTelefono.Text = "";
            cboProvincia.Items.Clear();
            await ApiReader.LoadProvincia(cboProvincia);
            cboCanton.Items.Clear();
            cboDistrito.Items.Clear();
            txtCodigoPostal.Text = "";
            txtDireccion.Text = "";
            txtContrasenna.Text = "";
            txtConfirmarContrasenna.Text = "";

        }
        private void frmRegistrarNuevoUsuario_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.LimpiarCampos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tlpRegistrarNuevoUsuario_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtContrasenna.UseSystemPasswordChar = !txtContrasenna.UseSystemPasswordChar;
            txtConfirmarContrasenna.UseSystemPasswordChar = !txtConfirmarContrasenna.UseSystemPasswordChar;

            if (txtConfirmarContrasenna.UseSystemPasswordChar)
            {
                ptbMostrarContrasenna.Image = Resources.ocultar_contrasenna_icon;
            }
            else
            {
                ptbMostrarContrasenna.Image = Resources.mostrar_contrasenna_icon;
            }
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

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {

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

        private void txtContrasenna_TextChanged(object sender, EventArgs e)
        {

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

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                this.LimpiarCampos();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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
                oUsuario.AgregarRoles(chkDuenno.Checked, chkCliente.Checked, chkAdmin.Checked);
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

                this.LimpiarCampos();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }

        }

        private async void txtIdentificacion_Leave(object sender, EventArgs e)
        {
            if (cboTipoIdentificacion.SelectedIndex == 0)
            {
                if (Regex.IsMatch(txtIdentificacion.Text, @"^\d{9}$"))
                {
                    await ApiReader.LoadIdentificacionNacional(Convert.ToInt32(txtIdentificacion.Text), txtNombre, txtPrimerApellido, txtSegundoApellido);
                    
                }
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
            txtCodigoPostal.Text = oDistritoSeleccionado.IdDistrito.ToString();
            txtCodigoPostal.ForeColor = Color.White;
        }
    }
}
