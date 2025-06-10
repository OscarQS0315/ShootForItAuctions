namespace winShootForItAuctions.Layers.UI.Procesos.Subastas
{
    partial class frmParticipandoSubasta
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDejarParticipar = new System.Windows.Forms.Button();
            this.lblSubasta = new System.Windows.Forms.Label();
            this.lblDuenno = new System.Windows.Forms.Label();
            this.txtDuenno = new System.Windows.Forms.Label();
            this.txtIncrementoMinimo = new System.Windows.Forms.Label();
            this.lblIncremento = new System.Windows.Forms.Label();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.txtFechaCierre = new System.Windows.Forms.Label();
            this.lblTotalOfertado = new System.Windows.Forms.Label();
            this.txtTotalOfertado = new System.Windows.Forms.Label();
            this.lblPujas = new System.Windows.Forms.Label();
            this.dgvPujas = new System.Windows.Forms.DataGridView();
            this.clmPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnPujar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.Label();
            this.lblBien = new System.Windows.Forms.Label();
            this.txtBien = new System.Windows.Forms.Label();
            this.dgvFotos = new System.Windows.Forms.DataGridView();
            this.clmFotografia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.btnCompraDirecta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoCompraDirecta = new System.Windows.Forms.Label();
            this.lblSubastasParticipando = new System.Windows.Forms.Label();
            this.cboSubastasParticipando = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioBase = new System.Windows.Forms.Label();
            this.tmrRefrescar = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPujas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.28834F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.9514F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.7254F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.67436F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.3147F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.948967F));
            this.tableLayoutPanel1.Controls.Add(this.btnDejarParticipar, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblSubasta, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDuenno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDuenno, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIncrementoMinimo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIncremento, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaCierre, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFechaCierre, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalOfertado, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalOfertado, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPujas, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dgvPujas, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblMonto, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtMonto, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnPujar, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblCategoria, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCategoria, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBien, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBien, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvFotos, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.ptbImagen, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCompraDirecta, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMontoCompraDirecta, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSubastasParticipando, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboSubastasParticipando, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPrecioBase, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.426628F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.150632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.580175F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.746356F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.46453F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.567541F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.70943F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.16035F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1646, 1029);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnDejarParticipar
            // 
            this.btnDejarParticipar.BackColor = System.Drawing.Color.Black;
            this.btnDejarParticipar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDejarParticipar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDejarParticipar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDejarParticipar.ForeColor = System.Drawing.Color.White;
            this.btnDejarParticipar.Location = new System.Drawing.Point(3, 874);
            this.btnDejarParticipar.Name = "btnDejarParticipar";
            this.btnDejarParticipar.Size = new System.Drawing.Size(229, 32);
            this.btnDejarParticipar.TabIndex = 85;
            this.btnDejarParticipar.Text = "DEJAR DE PARTICIPAR";
            this.btnDejarParticipar.UseVisualStyleBackColor = false;
            this.btnDejarParticipar.Click += new System.EventHandler(this.btnDejarParticipar_Click);
            // 
            // lblSubasta
            // 
            this.lblSubasta.AutoSize = true;
            this.lblSubasta.BackColor = System.Drawing.Color.Transparent;
            this.lblSubasta.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubasta.ForeColor = System.Drawing.Color.White;
            this.lblSubasta.Location = new System.Drawing.Point(3, 0);
            this.lblSubasta.Name = "lblSubasta";
            this.lblSubasta.Size = new System.Drawing.Size(112, 30);
            this.lblSubasta.TabIndex = 2;
            this.lblSubasta.Text = "SUBASTA";
            // 
            // lblDuenno
            // 
            this.lblDuenno.AutoSize = true;
            this.lblDuenno.BackColor = System.Drawing.Color.Transparent;
            this.lblDuenno.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuenno.ForeColor = System.Drawing.Color.White;
            this.lblDuenno.Location = new System.Drawing.Point(3, 97);
            this.lblDuenno.Name = "lblDuenno";
            this.lblDuenno.Size = new System.Drawing.Size(72, 19);
            this.lblDuenno.TabIndex = 3;
            this.lblDuenno.Text = "DUEÑO:";
            // 
            // txtDuenno
            // 
            this.txtDuenno.AutoSize = true;
            this.txtDuenno.BackColor = System.Drawing.Color.Transparent;
            this.txtDuenno.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuenno.ForeColor = System.Drawing.Color.White;
            this.txtDuenno.Location = new System.Drawing.Point(353, 97);
            this.txtDuenno.Name = "txtDuenno";
            this.txtDuenno.Size = new System.Drawing.Size(18, 23);
            this.txtDuenno.TabIndex = 59;
            this.txtDuenno.Text = "*";
            // 
            // txtIncrementoMinimo
            // 
            this.txtIncrementoMinimo.AutoSize = true;
            this.txtIncrementoMinimo.BackColor = System.Drawing.Color.Transparent;
            this.txtIncrementoMinimo.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncrementoMinimo.ForeColor = System.Drawing.Color.White;
            this.txtIncrementoMinimo.Location = new System.Drawing.Point(353, 150);
            this.txtIncrementoMinimo.Name = "txtIncrementoMinimo";
            this.txtIncrementoMinimo.Size = new System.Drawing.Size(18, 23);
            this.txtIncrementoMinimo.TabIndex = 60;
            this.txtIncrementoMinimo.Text = "*";
            // 
            // lblIncremento
            // 
            this.lblIncremento.AutoSize = true;
            this.lblIncremento.BackColor = System.Drawing.Color.Transparent;
            this.lblIncremento.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncremento.ForeColor = System.Drawing.Color.White;
            this.lblIncremento.Location = new System.Drawing.Point(3, 150);
            this.lblIncremento.Name = "lblIncremento";
            this.lblIncremento.Size = new System.Drawing.Size(341, 19);
            this.lblIncremento.TabIndex = 61;
            this.lblIncremento.Text = "INCREMENTO MÍNIMO DE LAS PUJAS ($):  ";
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaCierre.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCierre.ForeColor = System.Drawing.Color.White;
            this.lblFechaCierre.Location = new System.Drawing.Point(3, 228);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(213, 19);
            this.lblFechaCierre.TabIndex = 62;
            this.lblFechaCierre.Text = "FECHA/HORA DE CIERRE:";
            // 
            // txtFechaCierre
            // 
            this.txtFechaCierre.AutoSize = true;
            this.txtFechaCierre.BackColor = System.Drawing.Color.Transparent;
            this.txtFechaCierre.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCierre.ForeColor = System.Drawing.Color.White;
            this.txtFechaCierre.Location = new System.Drawing.Point(353, 228);
            this.txtFechaCierre.Name = "txtFechaCierre";
            this.txtFechaCierre.Size = new System.Drawing.Size(18, 23);
            this.txtFechaCierre.TabIndex = 63;
            this.txtFechaCierre.Text = "*";
            // 
            // lblTotalOfertado
            // 
            this.lblTotalOfertado.AutoSize = true;
            this.lblTotalOfertado.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalOfertado.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOfertado.ForeColor = System.Drawing.Color.White;
            this.lblTotalOfertado.Location = new System.Drawing.Point(3, 318);
            this.lblTotalOfertado.Name = "lblTotalOfertado";
            this.lblTotalOfertado.Size = new System.Drawing.Size(181, 19);
            this.lblTotalOfertado.TabIndex = 64;
            this.lblTotalOfertado.Text = "TOTAL OFERTADO ($):";
            // 
            // txtTotalOfertado
            // 
            this.txtTotalOfertado.AutoSize = true;
            this.txtTotalOfertado.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalOfertado.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOfertado.ForeColor = System.Drawing.Color.White;
            this.txtTotalOfertado.Location = new System.Drawing.Point(353, 318);
            this.txtTotalOfertado.Name = "txtTotalOfertado";
            this.txtTotalOfertado.Size = new System.Drawing.Size(18, 23);
            this.txtTotalOfertado.TabIndex = 65;
            this.txtTotalOfertado.Text = "*";
            // 
            // lblPujas
            // 
            this.lblPujas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPujas.AutoSize = true;
            this.lblPujas.BackColor = System.Drawing.Color.Transparent;
            this.lblPujas.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPujas.ForeColor = System.Drawing.Color.White;
            this.lblPujas.Location = new System.Drawing.Point(353, 536);
            this.lblPujas.Name = "lblPujas";
            this.lblPujas.Size = new System.Drawing.Size(59, 19);
            this.lblPujas.TabIndex = 66;
            this.lblPujas.Text = "PUJAS";
            // 
            // dgvPujas
            // 
            this.dgvPujas.AllowUserToAddRows = false;
            this.dgvPujas.AllowUserToDeleteRows = false;
            this.dgvPujas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPujas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvPujas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPujas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPosicion,
            this.clmUsuario,
            this.clmMonto});
            this.dgvPujas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPujas.GridColor = System.Drawing.Color.Black;
            this.dgvPujas.Location = new System.Drawing.Point(353, 558);
            this.dgvPujas.MultiSelect = false;
            this.dgvPujas.Name = "dgvPujas";
            this.dgvPujas.ReadOnly = true;
            this.dgvPujas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPujas.Size = new System.Drawing.Size(487, 310);
            this.dgvPujas.TabIndex = 67;
            // 
            // clmPosicion
            // 
            this.clmPosicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmPosicion.HeaderText = "Posición";
            this.clmPosicion.Name = "clmPosicion";
            this.clmPosicion.ReadOnly = true;
            this.clmPosicion.Width = 97;
            // 
            // clmUsuario
            // 
            this.clmUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmUsuario.HeaderText = "Usuario";
            this.clmUsuario.Name = "clmUsuario";
            this.clmUsuario.ReadOnly = true;
            this.clmUsuario.Width = 90;
            // 
            // clmMonto
            // 
            this.clmMonto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMonto.HeaderText = "Monto ($)";
            this.clmMonto.Name = "clmMonto";
            this.clmMonto.ReadOnly = true;
            // 
            // lblMonto
            // 
            this.lblMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonto.AutoSize = true;
            this.lblMonto.BackColor = System.Drawing.Color.Transparent;
            this.lblMonto.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.White;
            this.lblMonto.Location = new System.Drawing.Point(934, 852);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(99, 19);
            this.lblMonto.TabIndex = 68;
            this.lblMonto.Text = "MONTO ($)";
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMonto.BackColor = System.Drawing.Color.Black;
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.White;
            this.txtMonto.Location = new System.Drawing.Point(1039, 840);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(189, 28);
            this.txtMonto.TabIndex = 69;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // btnPujar
            // 
            this.btnPujar.BackColor = System.Drawing.Color.Black;
            this.btnPujar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPujar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPujar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPujar.ForeColor = System.Drawing.Color.White;
            this.btnPujar.Location = new System.Drawing.Point(1039, 874);
            this.btnPujar.Name = "btnPujar";
            this.btnPujar.Size = new System.Drawing.Size(80, 32);
            this.btnPujar.TabIndex = 73;
            this.btnPujar.Text = "PUJAR";
            this.btnPujar.UseVisualStyleBackColor = false;
            this.btnPujar.Click += new System.EventHandler(this.btnPujar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(846, 97);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(112, 19);
            this.lblCategoria.TabIndex = 74;
            this.lblCategoria.Text = "CATEGORÍA:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.AutoSize = true;
            this.txtCategoria.BackColor = System.Drawing.Color.Transparent;
            this.txtCategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.White;
            this.txtCategoria.Location = new System.Drawing.Point(1039, 97);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(18, 23);
            this.txtCategoria.TabIndex = 75;
            this.txtCategoria.Text = "*";
            // 
            // lblBien
            // 
            this.lblBien.AutoSize = true;
            this.lblBien.BackColor = System.Drawing.Color.Transparent;
            this.lblBien.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBien.ForeColor = System.Drawing.Color.White;
            this.lblBien.Location = new System.Drawing.Point(846, 150);
            this.lblBien.Name = "lblBien";
            this.lblBien.Size = new System.Drawing.Size(51, 19);
            this.lblBien.TabIndex = 76;
            this.lblBien.Text = "BIEN:";
            // 
            // txtBien
            // 
            this.txtBien.AutoSize = true;
            this.txtBien.BackColor = System.Drawing.Color.Transparent;
            this.txtBien.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBien.ForeColor = System.Drawing.Color.White;
            this.txtBien.Location = new System.Drawing.Point(1039, 150);
            this.txtBien.Name = "txtBien";
            this.txtBien.Size = new System.Drawing.Size(18, 23);
            this.txtBien.TabIndex = 77;
            this.txtBien.Text = "*";
            // 
            // dgvFotos
            // 
            this.dgvFotos.AllowUserToAddRows = false;
            this.dgvFotos.AllowUserToDeleteRows = false;
            this.dgvFotos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFotos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvFotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFotos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFotografia});
            this.dgvFotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFotos.Location = new System.Drawing.Point(1039, 321);
            this.dgvFotos.MultiSelect = false;
            this.dgvFotos.Name = "dgvFotos";
            this.dgvFotos.ReadOnly = true;
            this.dgvFotos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFotos.Size = new System.Drawing.Size(252, 184);
            this.dgvFotos.TabIndex = 78;
            this.dgvFotos.SelectionChanged += new System.EventHandler(this.dgvFotos_SelectionChanged);
            // 
            // clmFotografia
            // 
            this.clmFotografia.HeaderText = "Fotografía";
            this.clmFotografia.Name = "clmFotografia";
            this.clmFotografia.ReadOnly = true;
            // 
            // ptbImagen
            // 
            this.ptbImagen.BackColor = System.Drawing.Color.Transparent;
            this.ptbImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbImagen.Image = global::winShootForItAuctions.Properties.Resources.imagen_icon;
            this.ptbImagen.Location = new System.Drawing.Point(1297, 321);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(279, 184);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbImagen.TabIndex = 79;
            this.ptbImagen.TabStop = false;
            // 
            // btnCompraDirecta
            // 
            this.btnCompraDirecta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompraDirecta.BackColor = System.Drawing.Color.Black;
            this.btnCompraDirecta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompraDirecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraDirecta.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompraDirecta.ForeColor = System.Drawing.Color.White;
            this.btnCompraDirecta.Location = new System.Drawing.Point(1383, 874);
            this.btnCompraDirecta.Name = "btnCompraDirecta";
            this.btnCompraDirecta.Size = new System.Drawing.Size(193, 73);
            this.btnCompraDirecta.TabIndex = 80;
            this.btnCompraDirecta.Text = "REALIZAR COMPRA DIRECTA";
            this.btnCompraDirecta.UseVisualStyleBackColor = false;
            this.btnCompraDirecta.Click += new System.EventHandler(this.btnCompraDirecta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(846, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 38);
            this.label1.TabIndex = 81;
            this.label1.Text = "MONTO COMPRA DIRECTA ($):";
            // 
            // txtMontoCompraDirecta
            // 
            this.txtMontoCompraDirecta.AutoSize = true;
            this.txtMontoCompraDirecta.BackColor = System.Drawing.Color.Transparent;
            this.txtMontoCompraDirecta.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCompraDirecta.ForeColor = System.Drawing.Color.White;
            this.txtMontoCompraDirecta.Location = new System.Drawing.Point(1039, 228);
            this.txtMontoCompraDirecta.Name = "txtMontoCompraDirecta";
            this.txtMontoCompraDirecta.Size = new System.Drawing.Size(18, 23);
            this.txtMontoCompraDirecta.TabIndex = 82;
            this.txtMontoCompraDirecta.Text = "*";
            // 
            // lblSubastasParticipando
            // 
            this.lblSubastasParticipando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubastasParticipando.AutoSize = true;
            this.lblSubastasParticipando.BackColor = System.Drawing.Color.Transparent;
            this.lblSubastasParticipando.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubastasParticipando.ForeColor = System.Drawing.Color.White;
            this.lblSubastasParticipando.Location = new System.Drawing.Point(1157, 0);
            this.lblSubastasParticipando.Name = "lblSubastasParticipando";
            this.lblSubastasParticipando.Size = new System.Drawing.Size(134, 19);
            this.lblSubastasParticipando.TabIndex = 83;
            this.lblSubastasParticipando.Text = "PARTICIPANDO";
            // 
            // cboSubastasParticipando
            // 
            this.cboSubastasParticipando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cboSubastasParticipando.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubastasParticipando.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSubastasParticipando.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSubastasParticipando.ForeColor = System.Drawing.Color.White;
            this.cboSubastasParticipando.FormattingEnabled = true;
            this.cboSubastasParticipando.Location = new System.Drawing.Point(1297, 3);
            this.cboSubastasParticipando.Name = "cboSubastasParticipando";
            this.cboSubastasParticipando.Size = new System.Drawing.Size(199, 31);
            this.cboSubastasParticipando.TabIndex = 84;
            this.cboSubastasParticipando.SelectedIndexChanged += new System.EventHandler(this.cboSubastasParticipando_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 86;
            this.label2.Text = "PRECIO BASE ($):";
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.AutoSize = true;
            this.txtPrecioBase.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecioBase.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioBase.ForeColor = System.Drawing.Color.White;
            this.txtPrecioBase.Location = new System.Drawing.Point(3, 555);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(18, 23);
            this.txtPrecioBase.TabIndex = 87;
            this.txtPrecioBase.Text = "*";
            // 
            // tmrRefrescar
            // 
            this.tmrRefrescar.Interval = 500;
            this.tmrRefrescar.Tick += new System.EventHandler(this.tmrRefrescar_Tick);
            // 
            // frmParticipandoSubasta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::winShootForItAuctions.Properties.Resources.fondo_windows_4_borroso;
            this.ClientSize = new System.Drawing.Size(1646, 1029);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmParticipandoSubasta";
            this.ShowIcon = false;
            this.Text = "frmParticipantoSubasta";
            this.Load += new System.EventHandler(this.frmParticipandoSubasta_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPujas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSubasta;
        private System.Windows.Forms.Label lblDuenno;
        private System.Windows.Forms.Label txtDuenno;
        private System.Windows.Forms.Label txtIncrementoMinimo;
        private System.Windows.Forms.Label lblIncremento;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.Label txtFechaCierre;
        private System.Windows.Forms.Label lblTotalOfertado;
        private System.Windows.Forms.Label txtTotalOfertado;
        private System.Windows.Forms.Label lblPujas;
        private System.Windows.Forms.DataGridView dgvPujas;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnPujar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label txtCategoria;
        private System.Windows.Forms.Label lblBien;
        private System.Windows.Forms.Label txtBien;
        private System.Windows.Forms.DataGridView dgvFotos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFotografia;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Button btnCompraDirecta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMontoCompraDirecta;
        private System.Windows.Forms.Label lblSubastasParticipando;
        private System.Windows.Forms.ComboBox cboSubastasParticipando;
        private System.Windows.Forms.Button btnDejarParticipar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonto;
        private System.Windows.Forms.Timer tmrRefrescar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtPrecioBase;
    }
}