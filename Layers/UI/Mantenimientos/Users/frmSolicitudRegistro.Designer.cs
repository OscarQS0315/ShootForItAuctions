namespace winShootForItAuctions.Layers.UI
{
    partial class frmSolicitudRegistro
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
            this.lblSolicitudesRegistro = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAceptarSolicitud = new System.Windows.Forms.Button();
            this.btnDeclinarSolicitud = new System.Windows.Forms.Button();
            this.tlpSolicitudesRegistro = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.clmIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tlpSolicitudesRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSolicitudesRegistro
            // 
            this.lblSolicitudesRegistro.AutoSize = true;
            this.lblSolicitudesRegistro.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSolicitudesRegistro.ForeColor = System.Drawing.Color.White;
            this.lblSolicitudesRegistro.Location = new System.Drawing.Point(6, 0);
            this.lblSolicitudesRegistro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSolicitudesRegistro.Name = "lblSolicitudesRegistro";
            this.lblSolicitudesRegistro.Size = new System.Drawing.Size(273, 30);
            this.lblSolicitudesRegistro.TabIndex = 1;
            this.lblSolicitudesRegistro.Text = "Solicitudes de Registro";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdentificacion,
            this.clmNombre,
            this.clmPrimerApellido,
            this.clmSegundoApellido,
            this.clmTelefono,
            this.clmCorreo,
            this.clmRool});
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.GridColor = System.Drawing.Color.Black;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 104);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1202, 663);
            this.dgvUsuarios.TabIndex = 2;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // btnAceptarSolicitud
            // 
            this.btnAceptarSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptarSolicitud.BackColor = System.Drawing.Color.Black;
            this.btnAceptarSolicitud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarSolicitud.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnAceptarSolicitud.Location = new System.Drawing.Point(973, 773);
            this.btnAceptarSolicitud.Name = "btnAceptarSolicitud";
            this.btnAceptarSolicitud.Size = new System.Drawing.Size(232, 38);
            this.btnAceptarSolicitud.TabIndex = 3;
            this.btnAceptarSolicitud.Text = "Aceptar Solicitud";
            this.btnAceptarSolicitud.UseVisualStyleBackColor = false;
            this.btnAceptarSolicitud.Click += new System.EventHandler(this.btnAceptarSolicitud_Click);
            // 
            // btnDeclinarSolicitud
            // 
            this.btnDeclinarSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeclinarSolicitud.BackColor = System.Drawing.Color.Black;
            this.btnDeclinarSolicitud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeclinarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeclinarSolicitud.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclinarSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnDeclinarSolicitud.Location = new System.Drawing.Point(973, 850);
            this.btnDeclinarSolicitud.Name = "btnDeclinarSolicitud";
            this.btnDeclinarSolicitud.Size = new System.Drawing.Size(232, 39);
            this.btnDeclinarSolicitud.TabIndex = 4;
            this.btnDeclinarSolicitud.Text = "Declinar Solicitud";
            this.btnDeclinarSolicitud.UseVisualStyleBackColor = false;
            this.btnDeclinarSolicitud.Click += new System.EventHandler(this.btnDeclinarSolicitud_Click);
            // 
            // tlpSolicitudesRegistro
            // 
            this.tlpSolicitudesRegistro.BackColor = System.Drawing.Color.Transparent;
            this.tlpSolicitudesRegistro.ColumnCount = 3;
            this.tlpSolicitudesRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.39004F));
            this.tlpSolicitudesRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.85176F));
            this.tlpSolicitudesRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.69745F));
            this.tlpSolicitudesRegistro.Controls.Add(this.lblSolicitudesRegistro, 0, 0);
            this.tlpSolicitudesRegistro.Controls.Add(this.dgvUsuarios, 0, 1);
            this.tlpSolicitudesRegistro.Controls.Add(this.btnDeclinarSolicitud, 0, 3);
            this.tlpSolicitudesRegistro.Controls.Add(this.lblIdentificacion, 1, 0);
            this.tlpSolicitudesRegistro.Controls.Add(this.btnAceptarSolicitud, 0, 2);
            this.tlpSolicitudesRegistro.Controls.Add(this.txtIdentificacion, 2, 0);
            this.tlpSolicitudesRegistro.Controls.Add(this.btnBuscar, 2, 1);
            this.tlpSolicitudesRegistro.Controls.Add(this.btnTodos, 1, 1);
            this.tlpSolicitudesRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSolicitudesRegistro.ForeColor = System.Drawing.Color.Black;
            this.tlpSolicitudesRegistro.Location = new System.Drawing.Point(0, 0);
            this.tlpSolicitudesRegistro.Name = "tlpSolicitudesRegistro";
            this.tlpSolicitudesRegistro.RowCount = 4;
            this.tlpSolicitudesRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.815354F));
            this.tlpSolicitudesRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.01458F));
            this.tlpSolicitudesRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.482993F));
            this.tlpSolicitudesRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.68707F));
            this.tlpSolicitudesRegistro.Size = new System.Drawing.Size(1646, 1029);
            this.tlpSolicitudesRegistro.TabIndex = 5;
            this.tlpSolicitudesRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentificacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.ForeColor = System.Drawing.Color.White;
            this.lblIdentificacion.Location = new System.Drawing.Point(1211, 78);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(158, 23);
            this.lblIdentificacion.TabIndex = 5;
            this.lblIdentificacion.Text = "IDENTIFICACIÓN";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdentificacion.BackColor = System.Drawing.Color.Black;
            this.txtIdentificacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtIdentificacion.ForeColor = System.Drawing.Color.White;
            this.txtIdentificacion.Location = new System.Drawing.Point(1439, 67);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(199, 31);
            this.txtIdentificacion.TabIndex = 54;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(1439, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(199, 32);
            this.btnBuscar.TabIndex = 55;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.Black;
            this.btnTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.Color.White;
            this.btnTodos.Location = new System.Drawing.Point(1211, 104);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(199, 32);
            this.btnTodos.TabIndex = 59;
            this.btnTodos.Text = "TODOS";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // clmIdentificacion
            // 
            this.clmIdentificacion.HeaderText = "Identificación";
            this.clmIdentificacion.Name = "clmIdentificacion";
            this.clmIdentificacion.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmPrimerApellido
            // 
            this.clmPrimerApellido.HeaderText = "Primer Apellido";
            this.clmPrimerApellido.Name = "clmPrimerApellido";
            this.clmPrimerApellido.ReadOnly = true;
            // 
            // clmSegundoApellido
            // 
            this.clmSegundoApellido.HeaderText = "Segundo Apellido";
            this.clmSegundoApellido.Name = "clmSegundoApellido";
            this.clmSegundoApellido.ReadOnly = true;
            // 
            // clmTelefono
            // 
            this.clmTelefono.HeaderText = "Teléfono";
            this.clmTelefono.Name = "clmTelefono";
            this.clmTelefono.ReadOnly = true;
            // 
            // clmCorreo
            // 
            this.clmCorreo.HeaderText = "Email";
            this.clmCorreo.Name = "clmCorreo";
            this.clmCorreo.ReadOnly = true;
            // 
            // clmRool
            // 
            this.clmRool.HeaderText = "Rol";
            this.clmRool.Name = "clmRool";
            this.clmRool.ReadOnly = true;
            // 
            // frmSolicitudRegistro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::winShootForItAuctions.Properties.Resources.fondo_windows_borroso;
            this.ClientSize = new System.Drawing.Size(1646, 1029);
            this.Controls.Add(this.tlpSolicitudesRegistro);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSolicitudRegistro";
            this.ShowIcon = false;
            this.Text = "frmSolicitudRegistro";
            this.Load += new System.EventHandler(this.frmSolicitudRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tlpSolicitudesRegistro.ResumeLayout(false);
            this.tlpSolicitudesRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSolicitudesRegistro;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnAceptarSolicitud;
        private System.Windows.Forms.Button btnDeclinarSolicitud;
        private System.Windows.Forms.TableLayoutPanel tlpSolicitudesRegistro;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRool;
    }
}