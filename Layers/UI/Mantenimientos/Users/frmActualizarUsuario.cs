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
using System.Web.Security;
using System.Windows.Forms;
using winShootForItAuctions.Enums;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Util;

namespace winShootForItAuctions.Layers.UI
{
    internal partial class frmActualizarUsuario : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private Usuario oUsuarioActual = new Usuario();
        private IBLLUsuario oBLLUsuario = new BLLUsuario();

        public frmActualizarUsuario(Usuario pUsuario)
        {
            InitializeComponent();
            this.oUsuarioActual = pUsuario;

        }

        /// <summary>
        /// Llena los combos.
        /// </summary>
        private async void LlenarCombos()
        {
            cboCanton.Items.Clear();
            cboDistrito.Items.Clear();
            cboProvincia.Items.Clear();

            await ApiReader.LoadProvincia(cboProvincia);

            cboNacionalidad.DataSource = Nacionalidad.Nacionalidades;
            cboNacionalidad.SelectedIndex = -1;
        }

        /// <summary>
        /// Carga la información del usuario actual que se vaya a actualizar.
        /// </summary>
        private void CargarUsuarioActual()
        {
            string sexo = "Masculino";
            if (this.oUsuarioActual.Sexo == 'F')
            {
                sexo = "Femenino";
            }
            string roles = "";
            foreach (ETipoUsuario oRol in this.oUsuarioActual.Roles)
            {
                if (oRol == ETipoUsuario.ADMIN)
                {
                    chkCliente.Checked = true;
                    chkCliente.Enabled = false;
                    chkDuenno.Checked = true;
                    chkDuenno.Enabled = false;
                }
                else if (oRol == ETipoUsuario.DUENNO)
                {
                    chkDuenno.Checked = true;
                    chkDuenno.Enabled = false;
                }
                else if (oRol == ETipoUsuario.CLIENTE)
                {
                    chkCliente.Checked = true;
                    chkCliente.Enabled = false;
                }
                roles += oRol.ToString() + "-";
            }
            roles = roles.Remove(roles.Length - 1);


            txtIdentificacion.Text = this.oUsuarioActual.IdUsuario.ToString();
            txtNombre.Text = this.oUsuarioActual.Nombre;
            txtPrimerApellido.Text = this.oUsuarioActual.Apellido_1;
            txtSegundoApellido.Text = this.oUsuarioActual.Apellido_2;
            txtSexo.Text = sexo;
            txtNacionalidadActual.Text = this.oUsuarioActual.Nacionalidad;
            txtRolActual.Text = roles;
            txtCorreoElectronico.Text = this.oUsuarioActual.Correo;
            txtTelefono.Text = this.oUsuarioActual.Telefono.ToString();
            txtCodigoPostal.Text = this.oUsuarioActual.CodigoPostal.ToString();
            txtDireccion.Text = this.oUsuarioActual.Sennas;
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

        private void frmActualizarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                this.ControlBox = false;
                this.CargarUsuarioActual();
            }
            catch (Exception er)
            {
                string msg = "";
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmActualizarUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tlpRegistrarNuevoUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro (a) que desea reestablecer la información", "CONFIRMAR ACCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    this.CargarUsuarioActual();
                }
            }
            catch (Exception er)
            {
                string msg = "";
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                Usuario oUsuarioNuevo = this.oUsuarioActual;
                if (cboProvincia.SelectedIndex != -1)
                {
                    if (cboCanton.SelectedIndex != -1)
                    {
                        if (cboDistrito.SelectedIndex != -1)
                        {
                            Distrito oDistrito = cboDistrito.SelectedItem as Distrito;
                            oUsuarioNuevo.CodigoPostal = oDistrito.IdDistrito;
                        }
                        else
                        {
                            MessageBox.Show("Debe proporcionar la información del distrito.",
                                            "INFORMACIÓN INCOMPLETA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe proporcionar la información del cantón.",
                                        "INFORMACIÓN INCOMPLETA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                DialogResult respuesta = MessageBox.Show("Seguro(a) que desea actualizar la información del usuario" + Environment.NewLine +
                                                         "Solo se actualizará la información que modificó.",
                                "CONFIRMAR OPRERACIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (respuesta == DialogResult.No || respuesta == DialogResult.Cancel)
                {
                    return;
                }

                
                if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z]+$") || txtNombre.Text.ToUpper() == "NOMBRE")
                {
                    MessageBox.Show("Nombre inválido.", "NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                    return;
                }
                if (!Regex.IsMatch(txtPrimerApellido.Text, @"^[a-zA-Z]+$") || txtPrimerApellido.Text.ToUpper() == "PRIMER APELLIDO")
                {
                    MessageBox.Show("Primer Apellido inválido.", "PRIMER APELLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrimerApellido.Focus();
                    return;
                }
                if (!Regex.IsMatch(txtSegundoApellido.Text, @"^[a-zA-Z]+$") || txtSegundoApellido.Text.ToUpper() == "SEGUNDO APELLIDO")
                {
                    MessageBox.Show("Segundo Apellido inválido.", "SEGUNDO APELLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSegundoApellido.Focus();
                    return;
                }
                if (cboNacionalidad.SelectedIndex != -1)
                {
                    oUsuarioNuevo.Nacionalidad = cboNacionalidad.SelectedItem.ToString();
                }
                if (chkCliente.Checked)
                {
                    if (!oUsuarioNuevo.Roles.Contains(ETipoUsuario.CLIENTE))
                    {
                        oUsuarioNuevo.Roles.Add(ETipoUsuario.CLIENTE);
                    }
                }
                if (chkDuenno.Checked)
                {
                    if (!oUsuarioNuevo.Roles.Contains(ETipoUsuario.DUENNO))
                    {
                        oUsuarioNuevo.Roles.Add(ETipoUsuario.DUENNO);
                    }
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


                if (txtDireccion.Text.Length == 0 || txtDireccion.Text == "DIRECCIÓN")
                {
                    MessageBox.Show("Debe suministrar al menos alguna indicación", "DIRECCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDireccion.Focus();
                    return;
                }



                oUsuarioNuevo.IdUsuario = txtIdentificacion.Text.ToUpper();
                oUsuarioNuevo.Nombre = txtNombre.Text.ToUpper();
                oUsuarioNuevo.Apellido_1 = txtPrimerApellido.Text.ToUpper();
                oUsuarioNuevo.Apellido_2 = txtSegundoApellido.Text.ToUpper();
                oUsuarioNuevo.Correo = txtCorreoElectronico.Text;
                oUsuarioNuevo.Telefono = Convert.ToInt32(txtTelefono.Text);
                oUsuarioNuevo.Sennas = txtDireccion.Text;


                this.oBLLUsuario.Update(oUsuarioNuevo);


                MessageBox.Show("Usuario Actualizado correctamente ",
                                "OPRERACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);



                this.Close();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
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

        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNacionalidadActual_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRolActual_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
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

        private async void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCanton.Items.Clear();
            cboDistrito.Items.Clear();
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
