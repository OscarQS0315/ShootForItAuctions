using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winShootForItAuctions.Layers.UI;
using System.Runtime.InteropServices;
using winShootForItAuctions.Util;
using winShootForItAuctions.Layers.DAL;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS;
using System.Runtime.Serialization.Formatters;
using System.Reflection;
using log4net;
using winShootForItAuctions.Extensions;
using winShootForItAuctions.Layers.UI.Mantenimientos;
using winShootForItAuctions.Layers.UI.Procesos.Subastas;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.BLL;
using System.Text.RegularExpressions;
using winShootForItAuctions.Layers.UI.Procesos.Facturacion;
using winShootForItAuctions.Layers.UI.Reportes;
using winShootForItAuctions.Layers.UI.Seguridad;

namespace winShootForItAuctions
{
    public partial class frmMain : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        private IBLLSubasta oBLLSubasta = new BLLSubasta();
        private List<Subasta> misSubastas = new List<Subasta>();
        private bool expandirUsuario = false;
        private bool expandirBien = false;
        private bool expandirSubastas = false;
        private bool expandirFacturas = false;
        private bool expandirReportes = false;
        private bool expandirConfiguracion = false;
        private IBLLBien oBLLBien = new BLLBien();
        private List<Subasta> correoEnviado = new List<Subasta>();
        private IBLLFactura oBLLFactura = new BLLFactura();
        
        private IBLLParametro oBLLParametro = new BLLParametro();

        public static decimal tipoCambio;

        public frmMain()
        {
            InitializeComponent();
            this.mdiProp();
            tmrValidarSubastas.Start();
        }
        
        /// <summary>
        /// Muestra lo necesario si se inicia sesión solo con el rol cliente
        /// </summary>
        private  void InterfazCliente()
        {
            this.misSubastas = this.oBLLSubasta.GetSubastaActivasByCliente(UsuarioLogeado.GetInstance().IdUsuario);
            if (this.misSubastas.Count == 0)
            {
                btnParticipando.Enabled = false;
            }
            btnRegistrarNuevoUsuario.Enabled = false;
            btnSolicitudRegistro.Enabled = false;
            btnBienes.Enabled = false;
            btnNuevaSubasta.Enabled = false;
            btnMisSubastas.Enabled = false;
            btnEstadoSubastas.Enabled = false;
            btnConfiguracion.Enabled = false;
            btnReporteBienesMuebles.Enabled = false;
            btnImpustos.Enabled = false;
            btnReportes.Enabled = false;
        }
        /// <summary>
        /// Trae el tipo de cambio de dolar actual.
        /// </summary>
        private async void GetTipoCambio()
        {
            tipoCambio = await ApiReader.GetTipoCambio();
        }
        /// <summary>
        /// Muestra lo necesario si se inicia sesión solo con el rol Duenno
        /// </summary>
        private void InterfazDuenno()
        {
            btnRegistrarNuevoUsuario.Enabled = false;
            btnSolicitudRegistro.Enabled = false;
            btnRegistrarCategoriaBienes.Enabled = false;

            btnSubastasActivas.Enabled = false;
            btnParticipando.Enabled = false;
            btnConfiguracion.Enabled = false;
            btnFacturacion.Enabled = false;
            btnReporteFacturacion.Enabled = false;
            btnReportes.Enabled = false;
            btnImpustos.Enabled = false;
        }

        /// <summary>
        /// Muestra lo necesario si se inicia sesión solo con el rol Admin
        /// </summary>
        private void InterfazAdmin()
        {
            btnRegistrarNuevoUsuario.Enabled = true;
            btnSolicitudRegistro.Enabled = true;
            btnBienes.Enabled = true;
            btnNuevaSubasta.Enabled = true;
            btnMisSubastas.Enabled = true;
            btnEstadoSubastas.Enabled = true;
            btnReporteBienesMuebles.Enabled = true;
            btnImpustos.Enabled = true;
            btnRegistrarCategoriaBienes.Enabled = true;
            btnSubastasActivas.Enabled = true;
            btnParticipando.Enabled = true;
            btnFacturacion.Enabled = true;
            btnReporteFacturacion.Enabled = true;
            btnConfiguracion.Enabled = true;
            btnReportes.Enabled = true;
        }

        /// <summary>
        /// Muestra lo necesario si se inicia sesión solo con los roles duenno y cliente.
        /// </summary>
        private void InterfazDuennoCliente()
        {
            this.misSubastas = this.oBLLSubasta.GetSubastaActivasByCliente(UsuarioLogeado.GetInstance().IdUsuario);
            if (this.misSubastas.Count == 0)
            {
                btnParticipando.Enabled = false;
            }
            btnRegistrarNuevoUsuario.Enabled = false;
            btnSolicitudRegistro.Enabled = false;
            btnReportes.Enabled = false;
            btnConfiguracion.Enabled = false;
            btnRegistrarCategoriaBienes.Enabled = false;

            btnImpustos.Enabled = false;

        }

        /// <summary>
        /// Reinicia los paneles a su posición inciail.
        /// </summary>
        private void ReiniciarPaneles()
        {
            flpUsuariosContainer.Height = 49;
            flpBienesContainer.Height = 49;
            flpConfiguracionContainer.Height = 49;
            flpFacturacionContainer.Height = 49;
            flpSubastaContainer.Height = 49;
            flpReportesContainer.Height = 49;

        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void usuarioTransition_Tick(object sender, EventArgs e)
        {
            if (!expandirUsuario)
            {
                flpUsuariosContainer.Height += 10;
                if (flpUsuariosContainer.Height >= 217)
                {
                    usuarioTransition.Stop();
                    expandirUsuario = true;
                }
            }
            else
            {
                flpUsuariosContainer.Height -= 10;
                if (flpUsuariosContainer.Height <= 49)
                {
                    usuarioTransition.Stop();
                    expandirUsuario = false;
                }
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            usuarioTransition.Start();
        }

        private void bienesTransition_Tick(object sender, EventArgs e)
        {
            if (!expandirBien)
            {
                flpBienesContainer.Height += 10;
                if (flpBienesContainer.Height >= 212)
                {
                    bienesTransition.Stop();
                    expandirBien = true;
                }
            }
            else
            {
                flpBienesContainer.Height -= 10;
                if (flpBienesContainer.Height <= 49)
                {
                    bienesTransition.Stop();
                    expandirBien = false;
                }
            }
        }

        private void btnBienes_Click(object sender, EventArgs e)
        {
            bienesTransition.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                this.GetTipoCambio();
                this.ReiniciarPaneles();
                frmLogIn frm = new frmLogIn();
                frm.ShowDialog();
                frmFondo oFrmFondo = null;

                if (oFrmFondo == null)
                {
                    oFrmFondo = new frmFondo();
                    oFrmFondo.FormClosed += OFrmFondo_FormClosed;
                    oFrmFondo.MdiParent = this;
                    oFrmFondo.Dock = DockStyle.Fill;
                    oFrmFondo.Show();
                }
                else
                {
                    oFrmFondo.Activate();
                }
                Usuario oUsuario = UsuarioLogeado.GetInstance();
                this.InterfazAdmin();
                if (oUsuario.Roles.Count == 1)
                {
                    if (oUsuario.Roles.Contains(Enums.ETipoUsuario.DUENNO))
                    {
                        this.InterfazDuenno();
                    }
                    else if (oUsuario.Roles.Contains(Enums.ETipoUsuario.CLIENTE))
                    {
                        this.InterfazCliente();
                    }
                }
                else if (oUsuario.Roles.Count == 2)
                {
                    this.InterfazDuennoCliente();
                }
                else
                {
                    this.InterfazAdmin();
                }

                Utilitarios.EnviarCorreo(UsuarioLogeado.GetInstance().Correo, Utilitarios.MensajeInicioSesion(UsuarioLogeado.GetInstance()));
                
                
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }

        }

        private void OFrmFondo_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void subastasTransition_Tick(object sender, EventArgs e)
        {
            if (!expandirSubastas)
            {
                flpSubastaContainer.Height += 10;
                if (flpSubastaContainer.Height >= 268)
                {
                    subastasTransition.Stop();
                    expandirSubastas = true;
                }
            }
            else
            {
                flpSubastaContainer.Height -= 10;
                if (flpSubastaContainer.Height <= 49)
                {
                    subastasTransition.Stop();
                    expandirSubastas = false;
                }
            }
        }

        private void btnSubasta_Click(object sender, EventArgs e)
        {
            subastasTransition.Start();
        }

        private void facturacionTransition_Tick(object sender, EventArgs e)
        {
            if (!expandirFacturas)
            {
                flpFacturacionContainer.Height += 10;
                if (flpFacturacionContainer.Height >= 108)
                {
                    facturacionTransition.Stop();
                    expandirFacturas = true;
                }
            }
            else
            {
                flpFacturacionContainer.Height -= 10;
                if (flpFacturacionContainer.Height <= 49)
                {
                    facturacionTransition.Stop();
                    expandirFacturas = false;
                }
            }
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            facturacionTransition.Start();
        }

        private void reportesTransition_Tick(object sender, EventArgs e)
        {
            if (!expandirReportes)
            {
                flpReportesContainer.Height += 10;
                if (flpReportesContainer.Height >= 200)
                {
                    reportesTransition.Stop();
                    expandirReportes = true;
                }
            }
            else
            {
                flpReportesContainer.Height -= 10;
                if (flpReportesContainer.Height <= 49)
                {
                    reportesTransition.Stop();
                    expandirReportes = false;
                }
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            reportesTransition.Start();
        }

        private void configuracionTransition_Tick(object sender, EventArgs e)
        {
            if (!expandirConfiguracion)
            {
                flpConfiguracionContainer.Height += 10;
                if (flpConfiguracionContainer.Height >= 108)
                {
                    configuracionTransition.Stop();
                    expandirConfiguracion = true;
                }
            }
            else
            {
                flpConfiguracionContainer.Height -= 10;
                if (flpConfiguracionContainer.Height <= 49)
                {
                    configuracionTransition.Stop();
                    expandirConfiguracion = false;
                }
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            configuracionTransition.Start();
        }



        private void ptbMenu_Click(object sender, EventArgs e)
        {
            frmFondo oFrmFondo = null;
            if (oFrmFondo == null)
            {
                oFrmFondo = new frmFondo();
                oFrmFondo.FormClosed += OFrmFondo_FormClosed;
                oFrmFondo.MdiParent = this;
                oFrmFondo.Dock = DockStyle.Fill;
                oFrmFondo.Show();
            }
            else
            {
                oFrmFondo.Activate();
            }
        }

        private void pnlArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            frmFondo oFrmFondo = null;

            if (oFrmFondo == null)
            {
                oFrmFondo = new frmFondo();
                oFrmFondo.FormClosed += OFrmFondo_FormClosed;
                oFrmFondo.MdiParent = this;
                oFrmFondo.Dock = DockStyle.Fill;
                oFrmFondo.Show();
            }
            else
            {
                oFrmFondo.Activate();
            }
            this.Hide();
            frmMain_Load(sender, e);
            this.Show();
        }

        private void btnRegistrarNuevoUsuario_Click(object sender, EventArgs e)
        {
            frmRegistrarNuevoUsuario oFrmRegistrarNuevoUsuario = null;
            if (oFrmRegistrarNuevoUsuario == null)
            {
                oFrmRegistrarNuevoUsuario = new frmRegistrarNuevoUsuario();
                oFrmRegistrarNuevoUsuario.FormClosed += OFrmRegistrarNuevoUsuario_FormClosed;
                oFrmRegistrarNuevoUsuario.MdiParent = this;
                oFrmRegistrarNuevoUsuario.Dock = DockStyle.Fill;
                oFrmRegistrarNuevoUsuario.Show();
            }
            else
            {
                oFrmRegistrarNuevoUsuario.Activate();
            }
        }

        private void OFrmRegistrarNuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnSolicitudRegistro_Click(object sender, EventArgs e)
        {
            frmSolicitudRegistro oFrmSolicitudRegistro = null;
            if (oFrmSolicitudRegistro == null)
            {
                oFrmSolicitudRegistro = new frmSolicitudRegistro();
                oFrmSolicitudRegistro.FormClosed += OFrmSolicitudRegistro_FormClosed;
                oFrmSolicitudRegistro.MdiParent = this;
                oFrmSolicitudRegistro.Dock = DockStyle.Fill;
                oFrmSolicitudRegistro.Show();
            }
            else
            {
                oFrmSolicitudRegistro.Activate();
            }
        }

        private void OFrmSolicitudRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {

        }



        private void OFrmHabilitarDeshabilitarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            frmListaParaActualizarUsuario oFrmListaParaActualizarUsuario = null;
            if (oFrmListaParaActualizarUsuario == null)
            {
                oFrmListaParaActualizarUsuario = new frmListaParaActualizarUsuario();
                oFrmListaParaActualizarUsuario.FormClosed += OFrmListaParaActualizarUsuario_FormClosed;
                oFrmListaParaActualizarUsuario.MdiParent = this;
                oFrmListaParaActualizarUsuario.Dock = DockStyle.Fill;
                oFrmListaParaActualizarUsuario.Show();
            }
            else
            {
                oFrmListaParaActualizarUsuario.Activate();
            }
        }

        private void OFrmListaParaActualizarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnRegistrarCategoriaBienes_Click(object sender, EventArgs e)
        {
            frmRegistrarCategoriaBien oFrmRegistrarCategoriaBien = null;
            if (oFrmRegistrarCategoriaBien == null)
            {
                oFrmRegistrarCategoriaBien = new frmRegistrarCategoriaBien();
                oFrmRegistrarCategoriaBien.FormClosed += OFrmRegistrarCategoriaBien_FormClosed;
                oFrmRegistrarCategoriaBien.MdiParent = this;
                oFrmRegistrarCategoriaBien.Dock = DockStyle.Fill;
                oFrmRegistrarCategoriaBien.Show();
            }
            else
            {
                oFrmRegistrarCategoriaBien.Activate();
            }
        }

        private void OFrmRegistrarCategoriaBien_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnInscribirNuevo_Click(object sender, EventArgs e)
        {
            frmRegistrarNuevoBien oFrmRegistrarNuevoBien = null;
            if (oFrmRegistrarNuevoBien == null)
            {
                oFrmRegistrarNuevoBien = new frmRegistrarNuevoBien();
                oFrmRegistrarNuevoBien.FormClosed += OFrmRegistrarNuevoBien_FormClosed;
                oFrmRegistrarNuevoBien.MdiParent = this;
                oFrmRegistrarNuevoBien.Dock = DockStyle.Fill;
                oFrmRegistrarNuevoBien.Show();
            }
            else
            {
                oFrmRegistrarNuevoBien.Activate();
            }
        }

        private void OFrmRegistrarNuevoBien_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnBienesDisponibles_Click(object sender, EventArgs e)
        {
            frmBienesDisponibles oFrmBienesDisponibles = null;
            if (oFrmBienesDisponibles == null)
            {
                oFrmBienesDisponibles = new frmBienesDisponibles();
                oFrmBienesDisponibles.FormClosed += OFrmBienesDisponibles_FormClosed;
                oFrmBienesDisponibles.MdiParent = this;
                oFrmBienesDisponibles.Dock = DockStyle.Fill;
                oFrmBienesDisponibles.Show();
            }
            else
            {
                oFrmBienesDisponibles.Activate();
            }
        }

        private void OFrmBienesDisponibles_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        

        private void OFrmBienesSubastados_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnNuevaSubasta_Click(object sender, EventArgs e)
        {
            frmNuevaSubasta oFrmNuevaSubasta = null;
            if (oFrmNuevaSubasta == null)
            {

                oFrmNuevaSubasta = new frmNuevaSubasta();
                oFrmNuevaSubasta.FormClosed += OFrmNuevaSubasta_FormClosed;
                oFrmNuevaSubasta.MdiParent = this;
                oFrmNuevaSubasta.Dock = DockStyle.Fill;
                oFrmNuevaSubasta.Show();
            }
            else
            {
                oFrmNuevaSubasta.Activate();
            }
        }

        private void OFrmNuevaSubasta_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnSubastasActivas_Click(object sender, EventArgs e)
        {
            frmSubastasActivas oFrmSubastasActivas = null;
            if (oFrmSubastasActivas == null)
            {
                oFrmSubastasActivas = new frmSubastasActivas();
                oFrmSubastasActivas.FormClosed += OFrmSubastasActivas_FormClosed;
                oFrmSubastasActivas.MdiParent = this;
                oFrmSubastasActivas.Dock = DockStyle.Fill;
                oFrmSubastasActivas.Show();
            }
            else
            {
                oFrmSubastasActivas.Activate();
            }
        }

        private void OFrmSubastasActivas_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnParticipando.Enabled = true;
            frmParticipandoSubasta oFrmParticipantoSubasta = null;
            if (oFrmParticipantoSubasta == null)
            {
                oFrmParticipantoSubasta = new frmParticipandoSubasta();
                oFrmParticipantoSubasta.FormClosed += OFrmParticipantoSubasta_FormClosed;
                oFrmParticipantoSubasta.MdiParent = this;
                oFrmParticipantoSubasta.Dock = DockStyle.Fill;
                oFrmParticipantoSubasta.Show();
            }
            else
            {
                oFrmParticipantoSubasta.Activate();
            }
        }

      

        private void OFrmHistorialSubastas_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }

        private void btnImpustos_Click(object sender, EventArgs e)
        {
            frmImpuestosComision oFrmHistorialSubastas = null;
            if (oFrmHistorialSubastas == null)
            {
                oFrmHistorialSubastas = new frmImpuestosComision();
                oFrmHistorialSubastas.FormClosed += OFrmHistorialSubastas_FormClosed1;
                oFrmHistorialSubastas.MdiParent = this;
                oFrmHistorialSubastas.Dock = DockStyle.Fill;
                oFrmHistorialSubastas.Show();
            }
            else
            {
                oFrmHistorialSubastas.Activate();
            }
        }

        private void OFrmHistorialSubastas_FormClosed1(object sender, FormClosedEventArgs e)
        {

        }

        private void btnParticipando_Click(object sender, EventArgs e)
        {

            frmParticipandoSubasta oFrmParticipantoSubasta = null;
            if (oFrmParticipantoSubasta == null)
            {
                oFrmParticipantoSubasta = new frmParticipandoSubasta();
                oFrmParticipantoSubasta.FormClosed += OFrmParticipantoSubasta_FormClosed;
                oFrmParticipantoSubasta.MdiParent = this;
                oFrmParticipantoSubasta.Dock = DockStyle.Fill;
                oFrmParticipantoSubasta.Show();
            }
            else
            {
                oFrmParticipantoSubasta.Activate();
            }
        }

        private void OFrmParticipantoSubasta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.subastasTransition_Tick(sender, e);
            this.facturacionTransition_Tick(sender, e);
            frmFacturasPendientes oFrmFacturasPendientes = null;
            if (oFrmFacturasPendientes == null)
            {
                oFrmFacturasPendientes = new frmFacturasPendientes();
                oFrmFacturasPendientes.FormClosed += OFrmMisSubastas_FormClosed;
                oFrmFacturasPendientes.MdiParent = this;
                oFrmFacturasPendientes.Dock = DockStyle.Fill;
                oFrmFacturasPendientes.Show();
            }
            else
            {
                oFrmFacturasPendientes.Activate();
            }
        }

        private void btnMisSubastas_Click(object sender, EventArgs e)
        {
            frmMisSubastas oFrmMisSubastas = null;
            if (oFrmMisSubastas == null)
            {
                oFrmMisSubastas = new frmMisSubastas();
                oFrmMisSubastas.FormClosed += OFrmMisSubastas_FormClosed;
                oFrmMisSubastas.MdiParent = this;
                oFrmMisSubastas.Dock = DockStyle.Fill;
                oFrmMisSubastas.Show();
            }
            else
            {
                oFrmMisSubastas.Activate();
            }
        }

        private void OFrmMisSubastas_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void pnlArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmrValidarSubastas_Tick(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                double IVA = this.oBLLParametro.GetIVA();
                List<Subasta> subastasActivas = new List<Subasta>();
                subastasActivas = this.oBLLSubasta.GetAllSubastas();
                if (subastasActivas.Count > 0)
                {
                    for (int j = subastasActivas.Count - 1; j >= 0; j--)
                    {
                        if (subastasActivas[j].Estado == Enums.ETipoEstadoSubasta.ACTIVA)
                        {
                            var encontrada = this.correoEnviado.Find((Subasta) => Subasta.IdSubasta == subastasActivas[j].IdSubasta);
                            if (encontrada == null)
                            {
                                DateTime fechaActual = DateTime.Now;
                                DateTime fechaHoraCierre = subastasActivas[j].FechaCierre + subastasActivas[j].HoraCierre;
                                if (fechaActual > fechaHoraCierre)
                                {
                                    if (subastasActivas[j].Ganador != null)
                                    {
                                        subastasActivas[j].Estado = Enums.ETipoEstadoSubasta.CERRADA;
                                        subastasActivas[j].Bien.Estado = Enums.ETipoEstadoBien.VENDIDO;
                                        this.oBLLSubasta.Update(subastasActivas[j]);

                                        this.oBLLBien.Update(subastasActivas[j].Bien, subastasActivas[j].Duenno.IdUsuario);

                                        Factura oNuevaFactura = FacturaFactory.CrearFactura(subastasActivas[j].IdSubasta + "-" + subastasActivas[j].Ganador.IdUsuario, subastasActivas[j], subastasActivas[j].Ganador,
                                                                    subastasActivas[j].Duenno, DateTime.Now, subastasActivas[j].TotalOfertado, subastasActivas[j].TotalOfertado * tipoCambio,
                                                                    (double)subastasActivas[j].Comision, IVA);
                                        this.oBLLFactura.InsertFacturaPendiente(oNuevaFactura);
                                        this.correoEnviado.Add(subastasActivas[j]);
                                        for (int i = subastasActivas[j].Clientes.Count - 1; i >= 0; i--)
                                        {
                                            Utilitarios.EnviarCorreo(subastasActivas[j].Clientes[i].Correo, Utilitarios.MensajeSubastaFinalizada(subastasActivas[j], subastasActivas[j].Clientes[i]));
                                        }
                                        Utilitarios.EnviarCorreo(subastasActivas[j].Duenno.Correo, Utilitarios.MensajeSubastaFinalizada(subastasActivas[j], subastasActivas[j].Duenno));
                                    }
                                    else
                                    {
                                        subastasActivas[j].Estado = Enums.ETipoEstadoSubasta.CERRADA;
                                        subastasActivas[j].Bien.Estado = Enums.ETipoEstadoBien.DISPONIBLE;
                                        this.oBLLSubasta.Update(subastasActivas[j]);

                                        this.oBLLBien.Update(subastasActivas[j].Bien, subastasActivas[j].Duenno.IdUsuario);
                                        this.correoEnviado.Add(subastasActivas[j]);
                                    }
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }

        

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            frmFacturasPendientes oFrmFacturasPendientes = null;
            if (oFrmFacturasPendientes == null)
            {
                oFrmFacturasPendientes = new frmFacturasPendientes();
                oFrmFacturasPendientes.FormClosed += OFrmMisSubastas_FormClosed;
                oFrmFacturasPendientes.MdiParent = this;
                oFrmFacturasPendientes.Dock = DockStyle.Fill;
                oFrmFacturasPendientes.Show();
            }
            else
            {
                oFrmFacturasPendientes.Activate();
            }
        }

        private void btnReporteFacturacion_Click(object sender, EventArgs e)
        {
            frmReporteFacturacion oFrmReporteFacturacion = null;
            if (oFrmReporteFacturacion == null)
            {
                oFrmReporteFacturacion = new frmReporteFacturacion();
                oFrmReporteFacturacion.FormClosed += OFrmMisSubastas_FormClosed;
                oFrmReporteFacturacion.MdiParent = this;
                oFrmReporteFacturacion.Dock = DockStyle.Fill;
                oFrmReporteFacturacion.Show();
            }
            else
            {
                oFrmReporteFacturacion.Activate();
            }
        }

        private void btnEstadoSubastas_Click(object sender, EventArgs e)
        {
            frmReporteSubastas oFrmReporteSubastas = null;
            if (oFrmReporteSubastas == null)
            {
                oFrmReporteSubastas = new frmReporteSubastas();
                oFrmReporteSubastas.FormClosed += OFrmMisSubastas_FormClosed;
                oFrmReporteSubastas.MdiParent = this;
                oFrmReporteSubastas.Dock = DockStyle.Fill;
                oFrmReporteSubastas.Show();
            }
            else
            {
                oFrmReporteSubastas.Activate();
            }
        }

        private void btnReporteBienesMuebles_Click(object sender, EventArgs e)
        {
            frmReporteBien oFrmReporteBienes = null;
            if (oFrmReporteBienes == null)
            {
                oFrmReporteBienes = new frmReporteBien();
                oFrmReporteBienes.FormClosed += OFrmMisSubastas_FormClosed;
                oFrmReporteBienes.MdiParent = this;
                oFrmReporteBienes.Dock = DockStyle.Fill;
                oFrmReporteBienes.Show();
            }
            else
            {
                oFrmReporteBienes.Activate();
            }
        }

        private void btnCambiarContrasenna_Click(object sender, EventArgs e)
        {
            frmCambiarContrasenna oFrmCambiarContrasenna = null;
            if (oFrmCambiarContrasenna == null)
            {
                oFrmCambiarContrasenna = new frmCambiarContrasenna();
                oFrmCambiarContrasenna.FormClosed += OFrmMisSubastas_FormClosed;
                oFrmCambiarContrasenna.MdiParent = this;
                oFrmCambiarContrasenna.Dock = DockStyle.Fill;
                oFrmCambiarContrasenna.Show();
            }
            else
            {
                oFrmCambiarContrasenna.Activate();
            }
        }
    }
}
