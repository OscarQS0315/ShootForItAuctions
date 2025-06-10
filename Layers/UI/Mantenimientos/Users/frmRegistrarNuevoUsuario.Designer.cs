namespace winShootForItAuctions.Layers.UI
{
    partial class frmRegistrarNuevoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.lblRegistrarNuevoUsuario = new System.Windows.Forms.Label();
            this.tlpRegistrarNuevoUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.lblRoles = new System.Windows.Forms.Label();
            this.chkDuenno = new System.Windows.Forms.CheckBox();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lvlProvincia = new System.Windows.Forms.Label();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.lblCanton = new System.Windows.Forms.Label();
            this.cboCanton = new System.Windows.Forms.ComboBox();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblContrasenna = new System.Windows.Forms.Label();
            this.txtContrasenna = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasenna = new System.Windows.Forms.Label();
            this.txtConfirmarContrasenna = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.ptbMostrarContrasenna = new System.Windows.Forms.PictureBox();
            this.cboNacionalidad = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tlpRegistrarNuevoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMostrarContrasenna)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipoIdentificacion
            // 
            this.cboTipoIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cboTipoIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoIdentificacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboTipoIdentificacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoIdentificacion.ForeColor = System.Drawing.Color.White;
            this.cboTipoIdentificacion.FormattingEnabled = true;
            this.cboTipoIdentificacion.Location = new System.Drawing.Point(398, 131);
            this.cboTipoIdentificacion.Name = "cboTipoIdentificacion";
            this.cboTipoIdentificacion.Size = new System.Drawing.Size(199, 31);
            this.cboTipoIdentificacion.TabIndex = 51;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentificacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.ForeColor = System.Drawing.Color.White;
            this.lblIdentificacion.Location = new System.Drawing.Point(861, 128);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(158, 23);
            this.lblIdentificacion.TabIndex = 52;
            this.lblIdentificacion.Text = "IDENTIFICACIÓN";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.Color.Black;
            this.txtIdentificacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtIdentificacion.ForeColor = System.Drawing.Color.White;
            this.txtIdentificacion.Location = new System.Drawing.Point(1090, 131);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(199, 31);
            this.txtIdentificacion.TabIndex = 53;
            this.txtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
            this.txtIdentificacion.Leave += new System.EventHandler(this.txtIdentificacion_Leave);
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoIdentificacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoIdentificacion.ForeColor = System.Drawing.Color.White;
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(3, 128);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(231, 23);
            this.lblTipoIdentificacion.TabIndex = 0;
            this.lblTipoIdentificacion.Text = "TIPO DE IDENTIFICACIÓN";
            // 
            // lblRegistrarNuevoUsuario
            // 
            this.lblRegistrarNuevoUsuario.AutoSize = true;
            this.lblRegistrarNuevoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrarNuevoUsuario.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarNuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.lblRegistrarNuevoUsuario.Location = new System.Drawing.Point(3, 0);
            this.lblRegistrarNuevoUsuario.Name = "lblRegistrarNuevoUsuario";
            this.lblRegistrarNuevoUsuario.Size = new System.Drawing.Size(288, 30);
            this.lblRegistrarNuevoUsuario.TabIndex = 0;
            this.lblRegistrarNuevoUsuario.Text = "Registrar Nuevo Usuario";
            // 
            // tlpRegistrarNuevoUsuario
            // 
            this.tlpRegistrarNuevoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.tlpRegistrarNuevoUsuario.ColumnCount = 5;
            this.tlpRegistrarNuevoUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.99757F));
            this.tlpRegistrarNuevoUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.1288F));
            this.tlpRegistrarNuevoUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.91252F));
            this.tlpRegistrarNuevoUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.34265F));
            this.tlpRegistrarNuevoUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.55772F));
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblNacionalidad, 0, 5);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblRegistrarNuevoUsuario, 0, 0);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblTipoIdentificacion, 0, 1);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.cboTipoIdentificacion, 1, 1);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblIdentificacion, 2, 1);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.txtIdentificacion, 3, 1);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblNombre, 0, 2);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblPrimerApellido, 2, 2);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.txtPrimerApellido, 3, 2);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblSegundoApellido, 0, 3);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.txtSegundoApellido, 1, 3);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblSexo, 2, 3);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.rdbMasculino, 3, 3);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.rdbFemenino, 3, 4);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblRoles, 2, 5);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.chkDuenno, 3, 5);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.chkCliente, 3, 6);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.chkAdmin, 3, 7);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblCorreoElectronico, 0, 8);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.txtCorreoElectronico, 1, 8);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblTelefono, 2, 8);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.txtTelefono, 3, 8);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lvlProvincia, 0, 9);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.cboProvincia, 1, 9);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblCanton, 2, 9);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.cboCanton, 3, 9);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblDistrito, 0, 10);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.cboDistrito, 1, 10);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblCodigoPostal, 2, 10);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.txtCodigoPostal, 3, 10);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblDireccion, 0, 11);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.txtDireccion, 1, 11);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblContrasenna, 0, 12);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.txtContrasenna, 1, 12);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.lblConfirmarContrasenna, 2, 12);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.txtConfirmarContrasenna, 3, 12);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.btnRegistrar, 2, 13);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.btnLimpiarCampos, 1, 13);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.ptbMostrarContrasenna, 4, 12);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.cboNacionalidad, 1, 5);
            this.tlpRegistrarNuevoUsuario.Controls.Add(this.txtNombre, 1, 2);
            this.tlpRegistrarNuevoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRegistrarNuevoUsuario.Location = new System.Drawing.Point(0, 0);
            this.tlpRegistrarNuevoUsuario.Name = "tlpRegistrarNuevoUsuario";
            this.tlpRegistrarNuevoUsuario.RowCount = 14;
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43952F));
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.706201F));
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.191448F));
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.595724F));
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.442177F));
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.424555F));
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.135997F));
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.482601F));
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.674973F));
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.771159F));
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.867345F));
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.502507F));
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.502507F));
            this.tlpRegistrarNuevoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.14101F));
            this.tlpRegistrarNuevoUsuario.Size = new System.Drawing.Size(1646, 1029);
            this.tlpRegistrarNuevoUsuario.TabIndex = 0;
            this.tlpRegistrarNuevoUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpRegistrarNuevoUsuario_Paint);
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblNacionalidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.ForeColor = System.Drawing.Color.White;
            this.lblNacionalidad.Location = new System.Drawing.Point(3, 353);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(155, 23);
            this.lblNacionalidad.TabIndex = 63;
            this.lblNacionalidad.Text = "NACIONALIDAD";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(3, 186);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 23);
            this.lblNombre.TabIndex = 54;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.ForeColor = System.Drawing.Color.White;
            this.lblPrimerApellido.Location = new System.Drawing.Point(861, 186);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(165, 23);
            this.lblPrimerApellido.TabIndex = 56;
            this.lblPrimerApellido.Text = "PRIMER APELLIDO";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.Color.Black;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPrimerApellido.ForeColor = System.Drawing.Color.White;
            this.txtPrimerApellido.Location = new System.Drawing.Point(1090, 189);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(199, 31);
            this.txtPrimerApellido.TabIndex = 57;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerApellido_KeyPress);
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.ForeColor = System.Drawing.Color.White;
            this.lblSegundoApellido.Location = new System.Drawing.Point(3, 260);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(310, 23);
            this.lblSegundoApellido.TabIndex = 58;
            this.lblSegundoApellido.Text = "SEGUNDO APELLIDO (OPCIONAL)";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BackColor = System.Drawing.Color.Black;
            this.txtSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtSegundoApellido.ForeColor = System.Drawing.Color.White;
            this.txtSegundoApellido.Location = new System.Drawing.Point(398, 263);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(199, 31);
            this.txtSegundoApellido.TabIndex = 59;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(861, 260);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(59, 23);
            this.lblSexo.TabIndex = 60;
            this.lblSexo.Text = "SEXO";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.BackColor = System.Drawing.Color.Transparent;
            this.rdbMasculino.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdbMasculino.ForeColor = System.Drawing.Color.White;
            this.rdbMasculino.Location = new System.Drawing.Point(1090, 263);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(140, 27);
            this.rdbMasculino.TabIndex = 62;
            this.rdbMasculino.Text = "MASCULINO";
            this.rdbMasculino.UseVisualStyleBackColor = false;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.BackColor = System.Drawing.Color.Transparent;
            this.rdbFemenino.Checked = true;
            this.rdbFemenino.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdbFemenino.ForeColor = System.Drawing.Color.White;
            this.rdbFemenino.Location = new System.Drawing.Point(1090, 300);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(123, 27);
            this.rdbFemenino.TabIndex = 61;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "FEMENINO";
            this.rdbFemenino.UseVisualStyleBackColor = false;
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.BackColor = System.Drawing.Color.Transparent;
            this.lblRoles.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoles.ForeColor = System.Drawing.Color.White;
            this.lblRoles.Location = new System.Drawing.Point(861, 353);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(65, 23);
            this.lblRoles.TabIndex = 65;
            this.lblRoles.Text = "ROLES";
            // 
            // chkDuenno
            // 
            this.chkDuenno.AutoSize = true;
            this.chkDuenno.BackColor = System.Drawing.Color.Transparent;
            this.chkDuenno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.chkDuenno.ForeColor = System.Drawing.Color.White;
            this.chkDuenno.Location = new System.Drawing.Point(1090, 356);
            this.chkDuenno.Name = "chkDuenno";
            this.chkDuenno.Size = new System.Drawing.Size(95, 27);
            this.chkDuenno.TabIndex = 66;
            this.chkDuenno.Text = "DUEÑO";
            this.chkDuenno.UseVisualStyleBackColor = false;
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.BackColor = System.Drawing.Color.Transparent;
            this.chkCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.chkCliente.ForeColor = System.Drawing.Color.White;
            this.chkCliente.Location = new System.Drawing.Point(1090, 401);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(99, 27);
            this.chkCliente.TabIndex = 67;
            this.chkCliente.Text = "CLIENTE";
            this.chkCliente.UseVisualStyleBackColor = false;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.BackColor = System.Drawing.Color.Transparent;
            this.chkAdmin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.chkAdmin.ForeColor = System.Drawing.Color.White;
            this.chkAdmin.Location = new System.Drawing.Point(1090, 443);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(92, 27);
            this.chkAdmin.TabIndex = 68;
            this.chkAdmin.Text = "ADMIN";
            this.chkAdmin.UseVisualStyleBackColor = false;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectronico.ForeColor = System.Drawing.Color.White;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(3, 496);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(222, 23);
            this.lblCorreoElectronico.TabIndex = 69;
            this.lblCorreoElectronico.Text = "CORREO ELECTRÓNICO";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.BackColor = System.Drawing.Color.Black;
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCorreoElectronico.ForeColor = System.Drawing.Color.White;
            this.txtCorreoElectronico.Location = new System.Drawing.Point(398, 499);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(291, 31);
            this.txtCorreoElectronico.TabIndex = 70;
            this.txtCorreoElectronico.TextChanged += new System.EventHandler(this.txtCorreoElectronico_TextChanged);
            this.txtCorreoElectronico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreoElectronico_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(861, 496);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(101, 23);
            this.lblTelefono.TabIndex = 71;
            this.lblTelefono.Text = "TELÉFONO";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Black;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(1090, 499);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(199, 31);
            this.txtTelefono.TabIndex = 72;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lvlProvincia
            // 
            this.lvlProvincia.AutoSize = true;
            this.lvlProvincia.BackColor = System.Drawing.Color.Transparent;
            this.lvlProvincia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlProvincia.ForeColor = System.Drawing.Color.White;
            this.lvlProvincia.Location = new System.Drawing.Point(3, 554);
            this.lvlProvincia.Name = "lvlProvincia";
            this.lvlProvincia.Size = new System.Drawing.Size(114, 23);
            this.lvlProvincia.TabIndex = 73;
            this.lvlProvincia.Text = "PROVINCIA";
            // 
            // cboProvincia
            // 
            this.cboProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboProvincia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProvincia.ForeColor = System.Drawing.Color.White;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(398, 557);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(199, 31);
            this.cboProvincia.TabIndex = 74;
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // lblCanton
            // 
            this.lblCanton.AutoSize = true;
            this.lblCanton.BackColor = System.Drawing.Color.Transparent;
            this.lblCanton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanton.ForeColor = System.Drawing.Color.White;
            this.lblCanton.Location = new System.Drawing.Point(861, 554);
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(91, 23);
            this.lblCanton.TabIndex = 75;
            this.lblCanton.Text = "CANTÓN";
            // 
            // cboCanton
            // 
            this.cboCanton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cboCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCanton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCanton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCanton.ForeColor = System.Drawing.Color.White;
            this.cboCanton.FormattingEnabled = true;
            this.cboCanton.Location = new System.Drawing.Point(1090, 557);
            this.cboCanton.Name = "cboCanton";
            this.cboCanton.Size = new System.Drawing.Size(199, 31);
            this.cboCanton.TabIndex = 76;
            this.cboCanton.SelectedIndexChanged += new System.EventHandler(this.cboCanton_SelectedIndexChanged);
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.BackColor = System.Drawing.Color.Transparent;
            this.lblDistrito.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrito.ForeColor = System.Drawing.Color.White;
            this.lblDistrito.Location = new System.Drawing.Point(3, 613);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(86, 23);
            this.lblDistrito.TabIndex = 77;
            this.lblDistrito.Text = "DISTRITO";
            // 
            // cboDistrito
            // 
            this.cboDistrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboDistrito.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDistrito.ForeColor = System.Drawing.Color.White;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(398, 616);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(199, 31);
            this.cboDistrito.TabIndex = 78;
            this.cboDistrito.SelectedIndexChanged += new System.EventHandler(this.cboDistrito_SelectedIndexChanged);
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.ForeColor = System.Drawing.Color.White;
            this.lblCodigoPostal.Location = new System.Drawing.Point(861, 613);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(163, 23);
            this.lblCodigoPostal.TabIndex = 79;
            this.lblCodigoPostal.Text = "CÓDIGO POSTAL";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.BackColor = System.Drawing.Color.Black;
            this.txtCodigoPostal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCodigoPostal.ForeColor = System.Drawing.Color.White;
            this.txtCodigoPostal.Location = new System.Drawing.Point(1090, 616);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.ReadOnly = true;
            this.txtCodigoPostal.Size = new System.Drawing.Size(199, 31);
            this.txtCodigoPostal.TabIndex = 80;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(3, 673);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(114, 23);
            this.lblDireccion.TabIndex = 81;
            this.lblDireccion.Text = "DIRECCIÓN";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Black;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(398, 676);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(199, 31);
            this.txtDireccion.TabIndex = 82;
            // 
            // lblContrasenna
            // 
            this.lblContrasenna.AutoSize = true;
            this.lblContrasenna.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenna.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenna.ForeColor = System.Drawing.Color.White;
            this.lblContrasenna.Location = new System.Drawing.Point(3, 750);
            this.lblContrasenna.Name = "lblContrasenna";
            this.lblContrasenna.Size = new System.Drawing.Size(136, 23);
            this.lblContrasenna.TabIndex = 83;
            this.lblContrasenna.Text = "CONTRASEÑA";
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.BackColor = System.Drawing.Color.Black;
            this.txtContrasenna.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtContrasenna.ForeColor = System.Drawing.Color.White;
            this.txtContrasenna.Location = new System.Drawing.Point(398, 753);
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.Size = new System.Drawing.Size(199, 31);
            this.txtContrasenna.TabIndex = 84;
            this.txtContrasenna.UseSystemPasswordChar = true;
            this.txtContrasenna.TextChanged += new System.EventHandler(this.txtContrasenna_TextChanged);
            this.txtContrasenna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasenna_KeyPress);
            // 
            // lblConfirmarContrasenna
            // 
            this.lblConfirmarContrasenna.AutoSize = true;
            this.lblConfirmarContrasenna.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmarContrasenna.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContrasenna.ForeColor = System.Drawing.Color.White;
            this.lblConfirmarContrasenna.Location = new System.Drawing.Point(861, 750);
            this.lblConfirmarContrasenna.Name = "lblConfirmarContrasenna";
            this.lblConfirmarContrasenna.Size = new System.Drawing.Size(136, 46);
            this.lblConfirmarContrasenna.TabIndex = 85;
            this.lblConfirmarContrasenna.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // txtConfirmarContrasenna
            // 
            this.txtConfirmarContrasenna.BackColor = System.Drawing.Color.Black;
            this.txtConfirmarContrasenna.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtConfirmarContrasenna.ForeColor = System.Drawing.Color.White;
            this.txtConfirmarContrasenna.Location = new System.Drawing.Point(1090, 753);
            this.txtConfirmarContrasenna.Name = "txtConfirmarContrasenna";
            this.txtConfirmarContrasenna.Size = new System.Drawing.Size(199, 31);
            this.txtConfirmarContrasenna.TabIndex = 86;
            this.txtConfirmarContrasenna.UseSystemPasswordChar = true;
            this.txtConfirmarContrasenna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarContrasenna_KeyPress);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Location = new System.Drawing.Point(861, 830);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(199, 43);
            this.btnRegistrar.TabIndex = 87;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.Black;
            this.btnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarCampos.Location = new System.Drawing.Point(398, 830);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(199, 43);
            this.btnLimpiarCampos.TabIndex = 88;
            this.btnLimpiarCampos.Text = "LIMPIAR CAMPOS";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // ptbMostrarContrasenna
            // 
            this.ptbMostrarContrasenna.Image = global::winShootForItAuctions.Properties.Resources.ocultar_contrasenna_icon;
            this.ptbMostrarContrasenna.Location = new System.Drawing.Point(1359, 753);
            this.ptbMostrarContrasenna.Name = "ptbMostrarContrasenna";
            this.ptbMostrarContrasenna.Size = new System.Drawing.Size(30, 30);
            this.ptbMostrarContrasenna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbMostrarContrasenna.TabIndex = 89;
            this.ptbMostrarContrasenna.TabStop = false;
            this.ptbMostrarContrasenna.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboNacionalidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNacionalidad.ForeColor = System.Drawing.Color.White;
            this.cboNacionalidad.FormattingEnabled = true;
            this.cboNacionalidad.Location = new System.Drawing.Point(398, 356);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(199, 31);
            this.cboNacionalidad.TabIndex = 90;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Black;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(398, 189);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 31);
            this.txtNombre.TabIndex = 55;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // frmRegistrarNuevoUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::winShootForItAuctions.Properties.Resources.fondo_windows_borroso;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1646, 1029);
            this.ControlBox = false;
            this.Controls.Add(this.tlpRegistrarNuevoUsuario);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmRegistrarNuevoUsuario";
            this.ShowIcon = false;
            this.Text = "frmRegistrarNuevoUsuario";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmRegistrarNuevoUsuario_Load);
            this.tlpRegistrarNuevoUsuario.ResumeLayout(false);
            this.tlpRegistrarNuevoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMostrarContrasenna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblTipoIdentificacion;
        private System.Windows.Forms.Label lblRegistrarNuevoUsuario;
        private System.Windows.Forms.TableLayoutPanel tlpRegistrarNuevoUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.CheckBox chkDuenno;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Label lblCorreoElectronico;
        public System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblTelefono;
        public System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lvlProvincia;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.Label lblCanton;
        private System.Windows.Forms.ComboBox cboCanton;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.Label lblCodigoPostal;
        public System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label lblDireccion;
        public System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblContrasenna;
        private System.Windows.Forms.TextBox txtContrasenna;
        private System.Windows.Forms.Label lblConfirmarContrasenna;
        private System.Windows.Forms.TextBox txtConfirmarContrasenna;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.PictureBox ptbMostrarContrasenna;
        private System.Windows.Forms.ComboBox cboNacionalidad;
    }
}