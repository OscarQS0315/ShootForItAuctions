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
using System.Web.Security;
using System.Windows.Forms;
using winShootForItAuctions.Enums;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS;

namespace winShootForItAuctions.Layers.UI
{
    public partial class frmListaParaActualizarUsuario : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private IBLLUsuario oBLLUsuario = new BLLUsuario();
        public frmListaParaActualizarUsuario()
        {
            InitializeComponent();
            this.CargarCombo();
        }

        /// <summary>
        /// Carga el comboBox de los roles
        /// </summary>
        private void CargarCombo()
        {
            cboRol.Items.Clear();
            cboRol.Items.Add("TODOS");
            cboRol.Items.Add("ADMIN");
            cboRol.Items.Add("CLIENTE");
            cboRol.Items.Add("DUEÑO");
            cboRol.SelectedIndex = 0;
        }


        private void CargarDGVUsuario()
        {
            string roles = "";
            dgvUsuarios.Rows.Clear();
            Usuario oUsuario = oBLLUsuario.GetById(UsuarioLogeado.GetInstance().IdUsuario);
            foreach (ETipoUsuario oRol in oUsuario.Roles)
            {
                roles += oRol.ToString() + "-";
            }
            roles = roles.Remove(roles.Length - 1);
            dgvUsuarios.Rows.Add(oUsuario.IdUsuario, oUsuario.Nombre, oUsuario.Apellido_1, oUsuario.Apellido_2, oUsuario.Telefono, oUsuario.Correo, roles);
        }
        /// <summary>
        /// Carga el datGridView con la información necesaria.
        /// </summary>
        private void CargarDGV()
        {
            dgvUsuarios.Rows.Clear();
            List<Usuario> usuarios = oBLLUsuario.GetAll();
            string roles = "";

            foreach (Usuario oUsuario in usuarios)
            {
                if (oUsuario.Estado == ETipoEstadoCliente.APROBADO)
                {
                    foreach (ETipoUsuario oRol in oUsuario.Roles)
                    {
                        roles += oRol.ToString() + "-";
                    }
                    roles = roles.Remove(roles.Length - 1);
                    dgvUsuarios.Rows.Add(oUsuario.IdUsuario, oUsuario.Nombre, oUsuario.Apellido_1, oUsuario.Apellido_2, oUsuario.Telefono, oUsuario.Correo, roles);
                    roles = "";
                }

            }
        }

        /// <summary>
        /// Carga el datGridView pero solo los usuarios que poseen el rol de cliente
        /// </summary>
        private void CargarDGVRolCliente()
        {
            dgvUsuarios.Rows.Clear();
            List<Usuario> usuarios = oBLLUsuario.GetAll();
            string roles = "";

            foreach (Usuario oUsuario in usuarios)
            {
                if (oUsuario.Estado == ETipoEstadoCliente.APROBADO)
                {
                    if (oUsuario.Roles.Contains(ETipoUsuario.CLIENTE))
                    {
                        foreach (ETipoUsuario oRol in oUsuario.Roles)
                        {
                            roles += oRol.ToString() + "-";
                        }
                        roles = roles.Remove(roles.Length - 1);
                        dgvUsuarios.Rows.Add(oUsuario.IdUsuario, oUsuario.Nombre, oUsuario.Apellido_1, oUsuario.Apellido_2, oUsuario.Telefono, oUsuario.Correo, roles);
                        roles = "";
                    }
                }

            }
        }

        /// <summary>
        /// Carga el datGridView pero solo los usuarios que poseen el rol de Dueño
        /// </summary>
        private void CargarDGVRolDuenno()
        {
            dgvUsuarios.Rows.Clear();
            List<Usuario> usuarios = oBLLUsuario.GetAll();
            string roles = "";

            foreach (Usuario oUsuario in usuarios)
            {
                if (oUsuario.Estado == ETipoEstadoCliente.APROBADO)
                {
                    if (oUsuario.Roles.Contains(ETipoUsuario.DUENNO))
                    {
                        foreach (ETipoUsuario oRol in oUsuario.Roles)
                        {
                            roles += oRol.ToString() + "-";
                        }
                        roles = roles.Remove(roles.Length - 1);
                        dgvUsuarios.Rows.Add(oUsuario.IdUsuario, oUsuario.Nombre, oUsuario.Apellido_1, oUsuario.Apellido_2, oUsuario.Telefono, oUsuario.Correo, roles);
                        roles = "";
                    }
                }

            }
        }

        /// <summary>
        /// Carga el datGridView pero solo los usuarios que poseen el rol de Admin
        /// </summary>
        private void CargarDGVRolAdmin()
        {
            dgvUsuarios.Rows.Clear();
            List<Usuario> usuarios = oBLLUsuario.GetAll();
            string roles = "";

            foreach (Usuario oUsuario in usuarios)
            {
                if (oUsuario.Estado == ETipoEstadoCliente.APROBADO)
                {
                    if (oUsuario.Roles.Contains(ETipoUsuario.ADMIN))
                    {
                        foreach (ETipoUsuario oRol in oUsuario.Roles)
                        {
                            roles += oRol.ToString() + "-";
                        }
                        roles = roles.Remove(roles.Length - 1);
                        dgvUsuarios.Rows.Add(oUsuario.IdUsuario, oUsuario.Nombre, oUsuario.Apellido_1, oUsuario.Apellido_2, oUsuario.Telefono, oUsuario.Correo, roles);
                        roles = "";
                    }
                }

            }
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
        private void frmListaParaActualizarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                this.ControlBox = false;
                if (UsuarioLogeado.GetInstance().Roles.Contains(ETipoUsuario.ADMIN))
                {
                    this.CargarDGV();
                    btnBuscar.Enabled = true;
                    cboRol.Enabled = true;
                    btnTodos.Enabled = true;
                    lblRol.Visible = true;
                    btnBuscar.Visible = true;
                    cboRol.Visible = true;
                    btnTodos.Visible = true;
                }
                else
                {
                    this.CargarDGVUsuario();
                    btnBuscar.Enabled = false;
                    cboRol.Enabled = false;
                    btnTodos.Enabled = false;
                    lblRol.Visible = false;
                    btnBuscar.Visible = false;
                    cboRol.Visible = false;
                    btnTodos.Visible = false;
                }
            }
            catch (Exception er)
            {
                string msg = "";
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string idUsuario = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                Usuario oUsuario = oBLLUsuario.GetById(idUsuario);
                if (oUsuario != null)
                {
                    frmActualizarUsuario oFrmActualizarUsuario = new frmActualizarUsuario(oUsuario);
                    oFrmActualizarUsuario.ShowDialog();
                }
                if (UsuarioLogeado.GetInstance().Roles.Contains(ETipoUsuario.ADMIN))
                {
                    this.CargarDGV();
                    btnBuscar.Enabled = true;
                    cboRol.Enabled = true;
                    btnTodos.Enabled = true;
                    lblRol.Visible = true;
                    btnBuscar.Visible = true;
                    cboRol.Visible = true;
                    btnTodos.Visible = true;
                }
                else
                {
                    this.CargarDGVUsuario();
                    btnBuscar.Enabled = false;
                    cboRol.Enabled = false;
                    btnTodos.Enabled = false;
                    lblRol.Visible = false;
                    btnBuscar.Visible = false;
                    cboRol.Visible = false;
                    btnTodos.Visible = false;
                }
            }
            catch (Exception er)
            {
                string msg = "";
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogeado.GetInstance().Roles.Contains(ETipoUsuario.ADMIN))
                {
                    string roles = "";
                    string idUsuario = txtIdentificacion.Text.Trim();
                    Usuario oUsuario = null;
                    oUsuario = oBLLUsuario.GetById(idUsuario);
                    if (oUsuario != null)
                    {
                        foreach (ETipoUsuario oRol in oUsuario.Roles)
                        {
                            roles += oRol.ToString() + "-";
                        }
                        dgvUsuarios.Rows.Clear();
                        if (oUsuario.Estado == ETipoEstadoCliente.APROBADO)
                        {
                            dgvUsuarios.Rows.Add(oUsuario.IdUsuario, oUsuario.Nombre, oUsuario.Apellido_1, oUsuario.Apellido_2, oUsuario.Telefono, oUsuario.Correo, roles);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe un usuario con la identificación suministrada", "USUARIO INEXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdentificacion.Text = "";
                        this.CargarDGV();
                    }
                }

            }
            catch (Exception er)
            {
                string msg = "";
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                string idUsuario = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                txtIdentificacion.Text = idUsuario;
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            try
            {

                if (UsuarioLogeado.GetInstance().Roles.Contains(ETipoUsuario.ADMIN))
                {
                    this.CargarDGV();
                    cboRol.SelectedIndex = 0;
                }
                else
                {
                    this.CargarDGVUsuario();
                    cboRol.SelectedIndex = 0;
                }
            }
            catch (Exception er)
            {
                string msg = "";
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tlpSolicitudesRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboRol.SelectedIndex == 0)
                {
                    if (UsuarioLogeado.GetInstance().Roles.Contains(ETipoUsuario.ADMIN))
                    {
                        this.CargarDGV();
                    }
                    else
                    {
                        this.CargarDGVUsuario();
                    }
                }else if(cboRol.SelectedIndex == 1)
                {
                    this.CargarDGVRolAdmin();
                }else if (cboRol.SelectedIndex == 2)
                {
                    this.CargarDGVRolCliente();
                }else if (cboRol.SelectedIndex == 3)
                {
                    this.CargarDGVRolDuenno();
                }
            }
            catch (Exception er)
            {
                string msg = "";
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
