namespace winShootForItAuctions.Layers.UI.Procesos.Facturacion
{
    partial class frmCancelarFactura
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
            this.txtFactura = new System.Windows.Forms.Label();
            this.lblSubasta = new System.Windows.Forms.Label();
            this.txtSubasta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.cboBanco = new System.Windows.Forms.ComboBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.cboMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblCorro = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.clmBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcionBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.Label();
            this.lblTotalDolares = new System.Windows.Forms.Label();
            this.controlBoxEdit1 = new ReaLTaiizor.Controls.ControlBoxEdit();
            this.txtTotalDolares = new System.Windows.Forms.Label();
            this.lblTotalColones = new System.Windows.Forms.Label();
            this.txtTotalColones = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtMetodoPago = new System.Windows.Forms.Label();
            this.chkPagoRealizado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFactura
            // 
            this.txtFactura.AutoSize = true;
            this.txtFactura.BackColor = System.Drawing.Color.Transparent;
            this.txtFactura.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.ForeColor = System.Drawing.Color.White;
            this.txtFactura.Location = new System.Drawing.Point(12, 9);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(126, 30);
            this.txtFactura.TabIndex = 2;
            this.txtFactura.Text = "FACTURA ";
            // 
            // lblSubasta
            // 
            this.lblSubasta.AutoSize = true;
            this.lblSubasta.BackColor = System.Drawing.Color.Transparent;
            this.lblSubasta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubasta.ForeColor = System.Drawing.Color.White;
            this.lblSubasta.Location = new System.Drawing.Point(77, 69);
            this.lblSubasta.Name = "lblSubasta";
            this.lblSubasta.Size = new System.Drawing.Size(90, 23);
            this.lblSubasta.TabIndex = 3;
            this.lblSubasta.Text = "SUBASTA";
            // 
            // txtSubasta
            // 
            this.txtSubasta.AutoSize = true;
            this.txtSubasta.BackColor = System.Drawing.Color.Transparent;
            this.txtSubasta.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubasta.ForeColor = System.Drawing.Color.White;
            this.txtSubasta.Location = new System.Drawing.Point(282, 69);
            this.txtSubasta.Name = "txtSubasta";
            this.txtSubasta.Size = new System.Drawing.Size(18, 23);
            this.txtSubasta.TabIndex = 60;
            this.txtSubasta.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "CLIENTE";
            // 
            // txtCliente
            // 
            this.txtCliente.AutoSize = true;
            this.txtCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(282, 125);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(18, 23);
            this.txtCliente.TabIndex = 62;
            this.txtCliente.Text = "*";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.BackColor = System.Drawing.Color.Transparent;
            this.lblBanco.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.ForeColor = System.Drawing.Color.White;
            this.lblBanco.Location = new System.Drawing.Point(77, 270);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(80, 23);
            this.lblBanco.TabIndex = 63;
            this.lblBanco.Text = "BANCO";
            // 
            // cboBanco
            // 
            this.cboBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboBanco.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBanco.ForeColor = System.Drawing.Color.White;
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.Location = new System.Drawing.Point(286, 267);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(199, 31);
            this.cboBanco.TabIndex = 85;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.lblMetodoPago.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.ForeColor = System.Drawing.Color.White;
            this.lblMetodoPago.Location = new System.Drawing.Point(77, 323);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(180, 23);
            this.lblMetodoPago.TabIndex = 86;
            this.lblMetodoPago.Text = "MÉTODO DE PAGO";
            // 
            // cboMetodoPago
            // 
            this.cboMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cboMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboMetodoPago.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMetodoPago.ForeColor = System.Drawing.Color.White;
            this.cboMetodoPago.FormattingEnabled = true;
            this.cboMetodoPago.Location = new System.Drawing.Point(286, 323);
            this.cboMetodoPago.Name = "cboMetodoPago";
            this.cboMetodoPago.Size = new System.Drawing.Size(199, 31);
            this.cboMetodoPago.TabIndex = 87;
            this.cboMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cboMetodoPago_SelectedIndexChanged);
            // 
            // lblCorro
            // 
            this.lblCorro.AutoSize = true;
            this.lblCorro.BackColor = System.Drawing.Color.Transparent;
            this.lblCorro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorro.ForeColor = System.Drawing.Color.White;
            this.lblCorro.Location = new System.Drawing.Point(77, 179);
            this.lblCorro.Name = "lblCorro";
            this.lblCorro.Size = new System.Drawing.Size(89, 23);
            this.lblCorro.TabIndex = 88;
            this.lblCorro.Text = "CORREO";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.AutoSize = true;
            this.txtCorreoElectronico.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.ForeColor = System.Drawing.Color.White;
            this.txtCorreoElectronico.Location = new System.Drawing.Point(282, 179);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(18, 23);
            this.txtCorreoElectronico.TabIndex = 89;
            this.txtCorreoElectronico.Text = "*";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(78, 222);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(101, 23);
            this.lblTelefono.TabIndex = 90;
            this.lblTelefono.Text = "TELÉFONO";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(282, 222);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(18, 23);
            this.txtTelefono.TabIndex = 91;
            this.txtTelefono.Text = "*";
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBien,
            this.clmDescripcionBien,
            this.clmCantidad,
            this.clmPrecio,
            this.clmIVA,
            this.clmComision});
            this.dgvInfo.GridColor = System.Drawing.Color.Black;
            this.dgvInfo.Location = new System.Drawing.Point(286, 375);
            this.dgvInfo.MultiSelect = false;
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(826, 139);
            this.dgvInfo.TabIndex = 92;
            // 
            // clmBien
            // 
            this.clmBien.HeaderText = "Código del Bien";
            this.clmBien.Name = "clmBien";
            this.clmBien.ReadOnly = true;
            // 
            // clmDescripcionBien
            // 
            this.clmDescripcionBien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmDescripcionBien.HeaderText = "Descripción del Bien";
            this.clmDescripcionBien.Name = "clmDescripcionBien";
            this.clmDescripcionBien.ReadOnly = true;
            this.clmDescripcionBien.Width = 144;
            // 
            // clmCantidad
            // 
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            // 
            // clmPrecio
            // 
            this.clmPrecio.HeaderText = "Precio ";
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.ReadOnly = true;
            // 
            // clmIVA
            // 
            this.clmIVA.HeaderText = "IVA";
            this.clmIVA.Name = "clmIVA";
            this.clmIVA.ReadOnly = true;
            // 
            // clmComision
            // 
            this.clmComision.HeaderText = "Comisión";
            this.clmComision.Name = "clmComision";
            this.clmComision.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(192, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 93;
            this.label2.Text = "SUBTOTAL";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.AutoSize = true;
            this.txtSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.txtSubtotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.ForeColor = System.Drawing.Color.White;
            this.txtSubtotal.Location = new System.Drawing.Point(334, 534);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(18, 23);
            this.txtSubtotal.TabIndex = 94;
            this.txtSubtotal.Text = "*";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblImpuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.ForeColor = System.Drawing.Color.White;
            this.lblImpuesto.Location = new System.Drawing.Point(190, 582);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(100, 23);
            this.lblImpuesto.TabIndex = 95;
            this.lblImpuesto.Text = "IMPUESTO";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.AutoSize = true;
            this.txtImpuesto.BackColor = System.Drawing.Color.Transparent;
            this.txtImpuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.ForeColor = System.Drawing.Color.White;
            this.txtImpuesto.Location = new System.Drawing.Point(334, 582);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(18, 23);
            this.txtImpuesto.TabIndex = 96;
            this.txtImpuesto.Text = "*";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.BackColor = System.Drawing.Color.Transparent;
            this.lblComision.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComision.ForeColor = System.Drawing.Color.White;
            this.lblComision.Location = new System.Drawing.Point(182, 621);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(108, 23);
            this.lblComision.TabIndex = 97;
            this.lblComision.Text = "COMISIÓN";
            // 
            // txtComision
            // 
            this.txtComision.AutoSize = true;
            this.txtComision.BackColor = System.Drawing.Color.Transparent;
            this.txtComision.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComision.ForeColor = System.Drawing.Color.White;
            this.txtComision.Location = new System.Drawing.Point(334, 621);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(18, 23);
            this.txtComision.TabIndex = 98;
            this.txtComision.Text = "*";
            // 
            // lblTotalDolares
            // 
            this.lblTotalDolares.AutoSize = true;
            this.lblTotalDolares.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDolares.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDolares.ForeColor = System.Drawing.Color.White;
            this.lblTotalDolares.Location = new System.Drawing.Point(139, 661);
            this.lblTotalDolares.Name = "lblTotalDolares";
            this.lblTotalDolares.Size = new System.Drawing.Size(151, 23);
            this.lblTotalDolares.TabIndex = 99;
            this.lblTotalDolares.Text = "TOTAL DÓLARES";
            // 
            // controlBoxEdit1
            // 
            this.controlBoxEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBoxEdit1.BackColor = System.Drawing.Color.Transparent;
            this.controlBoxEdit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlBoxEdit1.DefaultLocation = true;
            this.controlBoxEdit1.Location = new System.Drawing.Point(1124, -1);
            this.controlBoxEdit1.Name = "controlBoxEdit1";
            this.controlBoxEdit1.Size = new System.Drawing.Size(77, 19);
            this.controlBoxEdit1.TabIndex = 100;
            this.controlBoxEdit1.Text = "controlBoxEdit1";
            // 
            // txtTotalDolares
            // 
            this.txtTotalDolares.AutoSize = true;
            this.txtTotalDolares.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalDolares.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDolares.ForeColor = System.Drawing.Color.White;
            this.txtTotalDolares.Location = new System.Drawing.Point(334, 661);
            this.txtTotalDolares.Name = "txtTotalDolares";
            this.txtTotalDolares.Size = new System.Drawing.Size(18, 23);
            this.txtTotalDolares.TabIndex = 101;
            this.txtTotalDolares.Text = "*";
            // 
            // lblTotalColones
            // 
            this.lblTotalColones.AutoSize = true;
            this.lblTotalColones.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalColones.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalColones.ForeColor = System.Drawing.Color.White;
            this.lblTotalColones.Location = new System.Drawing.Point(132, 703);
            this.lblTotalColones.Name = "lblTotalColones";
            this.lblTotalColones.Size = new System.Drawing.Size(158, 23);
            this.lblTotalColones.TabIndex = 102;
            this.lblTotalColones.Text = "TOTAL COLONES";
            // 
            // txtTotalColones
            // 
            this.txtTotalColones.AutoSize = true;
            this.txtTotalColones.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalColones.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalColones.ForeColor = System.Drawing.Color.White;
            this.txtTotalColones.Location = new System.Drawing.Point(334, 703);
            this.txtTotalColones.Name = "txtTotalColones";
            this.txtTotalColones.Size = new System.Drawing.Size(18, 23);
            this.txtTotalColones.TabIndex = 103;
            this.txtTotalColones.Text = "*";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Black;
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.Enabled = false;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(338, 807);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(104, 32);
            this.btnPagar.TabIndex = 104;
            this.btnPagar.Text = "FACTURAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1013, 807);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 32);
            this.btnSalir.TabIndex = 105;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.AutoSize = true;
            this.txtMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.txtMetodoPago.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetodoPago.ForeColor = System.Drawing.Color.White;
            this.txtMetodoPago.Location = new System.Drawing.Point(508, 331);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(18, 23);
            this.txtMetodoPago.TabIndex = 106;
            this.txtMetodoPago.Text = "*";
            // 
            // chkPagoRealizado
            // 
            this.chkPagoRealizado.BackColor = System.Drawing.Color.Transparent;
            this.chkPagoRealizado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPagoRealizado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.chkPagoRealizado.ForeColor = System.Drawing.Color.White;
            this.chkPagoRealizado.Location = new System.Drawing.Point(118, 741);
            this.chkPagoRealizado.Name = "chkPagoRealizado";
            this.chkPagoRealizado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPagoRealizado.Size = new System.Drawing.Size(231, 27);
            this.chkPagoRealizado.TabIndex = 107;
            this.chkPagoRealizado.Text = "PAGO REALIZADO";
            this.chkPagoRealizado.UseVisualStyleBackColor = false;
            this.chkPagoRealizado.CheckedChanged += new System.EventHandler(this.chkPagoRealizado_CheckedChanged);
            // 
            // frmCancelarFactura
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::winShootForItAuctions.Properties.Resources.fondo_windows_4_borroso;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1189, 905);
            this.ControlBox = false;
            this.Controls.Add(this.chkPagoRealizado);
            this.Controls.Add(this.txtMetodoPago);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtTotalColones);
            this.Controls.Add(this.lblTotalColones);
            this.Controls.Add(this.txtTotalDolares);
            this.Controls.Add(this.controlBoxEdit1);
            this.Controls.Add(this.lblTotalDolares);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.lblCorro);
            this.Controls.Add(this.cboMetodoPago);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.cboBanco);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubasta);
            this.Controls.Add(this.lblSubasta);
            this.Controls.Add(this.txtFactura);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCancelarFactura";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCancelarFactura";
            this.Load += new System.EventHandler(this.frmCancelarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtFactura;
        private System.Windows.Forms.Label lblSubasta;
        private System.Windows.Forms.Label txtSubasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.ComboBox cboBanco;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.ComboBox cboMetodoPago;
        private System.Windows.Forms.Label lblCorro;
        private System.Windows.Forms.Label txtCorreoElectronico;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtSubtotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label txtImpuesto;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label txtComision;
        private System.Windows.Forms.Label lblTotalDolares;
        private ReaLTaiizor.Controls.ControlBoxEdit controlBoxEdit1;
        private System.Windows.Forms.Label txtTotalDolares;
        private System.Windows.Forms.Label lblTotalColones;
        private System.Windows.Forms.Label txtTotalColones;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label txtMetodoPago;
        private System.Windows.Forms.CheckBox chkPagoRealizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcionBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComision;
    }
}