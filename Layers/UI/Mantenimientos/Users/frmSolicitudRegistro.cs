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
using winShootForItAuctions.Enums;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Layers.UI
{
    public partial class frmSolicitudRegistro : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private List<Usuario> totalUsuarios = new List<Usuario>();
        IBLLUsuario oBLLUsuario = new BLLUsuario();
        public frmSolicitudRegistro()
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
        /// Carga el datGridView con la información necesaria.
        /// </summary>
        private void CargarDGV()
        {
            dgvUsuarios.Rows.Clear();
            List<Usuario> usuarios = oBLLUsuario.GetAll();
            string roles = "";

            foreach (Usuario oUsuario in usuarios)
            {
                if (oUsuario.Estado == ETipoEstadoCliente.PENDIENTE)
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
        private void frmSolicitudRegistro_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                this.ControlBox = false;
                this.CargarDGV();
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                string idUsuario = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                txtIdentificacion.Text = idUsuario;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
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
                    if (oUsuario.Estado == ETipoEstadoCliente.PENDIENTE)
                    {
                        dgvUsuarios.Rows.Add(oUsuario.IdUsuario, oUsuario.Nombre, oUsuario.Apellido_1, oUsuario.Apellido_2, oUsuario.Telefono, oUsuario.Correo, roles);
                    }
                }
                else
                {
                    MessageBox.Show("No existe un usuario Pendiente con la identificación suministrada", "USUARIO INEXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdentificacion.Text = "";
                    this.totalUsuarios = oBLLUsuario.GetAll();
                    this.CargarDGV();
                }
            }
            catch (Exception er)
            {
                string msg = "";
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptarSolicitud_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                string idUsuario = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                Usuario oUsuario = oBLLUsuario.GetById(idUsuario);
                if (oUsuario != null)
                {
                    oUsuario.Estado = ETipoEstadoCliente.APROBADO;
                    oBLLUsuario.Update(oUsuario);
                    this.CargarDGV();
                    MessageBox.Show("Solicitud de registro Aprovada con éxito", "OPERACIÓN EXISTOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario Pendiente de la lista.", "SELECCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvUsuarios.Focus();
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            try
            {
                this.CargarDGV();
            }
            catch (Exception er)
            {
                string msg = "";
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnDeclinarSolicitud_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                string idUsuario = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                Usuario oUsuario = oBLLUsuario.GetById(idUsuario);
                if (oUsuario != null)
                {
                    oUsuario.Estado = ETipoEstadoCliente.DECLINADO;
                    oBLLUsuario.Update(oUsuario);
                    this.CargarDGV();
                    MessageBox.Show("Solicitud de registro Declinada con éxito", "OPERACIÓN EXISTOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario Pendiente de la lista.", "SELECCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvUsuarios.Focus();
            }
        }
    }
}
