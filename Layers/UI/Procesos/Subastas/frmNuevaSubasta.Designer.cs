namespace winShootForItAuctions.Layers.UI
{
    partial class frmNuevaSubasta
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
            this.tplNuevaSubasta = new System.Windows.Forms.TableLayoutPanel();
            this.lblNuevaSubasta = new System.Windows.Forms.Label();
            this.lblDuenno = new System.Windows.Forms.Label();
            this.lblIncremento = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblBienesDisponibles = new System.Windows.Forms.Label();
            this.lblFechFinal = new System.Windows.Forms.Label();
            this.lblHoraCierre = new System.Windows.Forms.Label();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.dgvBienes = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBaseVentaColones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioBaseDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioVentaDirecta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioVentaDirectaColones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIniciarSubasta = new System.Windows.Forms.Button();
            this.dtpHoraCierre = new System.Windows.Forms.DateTimePicker();
            this.txtDuenno = new System.Windows.Forms.Label();
            this.txtFechaHoraActual = new System.Windows.Forms.Label();
            this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.tplNuevaSubasta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienes)).BeginInit();
            this.SuspendLayout();
            // 
            // tplNuevaSubasta
            // 
            this.tplNuevaSubasta.BackColor = System.Drawing.Color.Transparent;
            this.tplNuevaSubasta.ColumnCount = 3;
            this.tplNuevaSubasta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.98299F));
            this.tplNuevaSubasta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.02551F));
            this.tplNuevaSubasta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.930741F));
            this.tplNuevaSubasta.Controls.Add(this.lblNuevaSubasta, 0, 0);
            this.tplNuevaSubasta.Controls.Add(this.lblDuenno, 0, 1);
            this.tplNuevaSubasta.Controls.Add(this.lblIncremento, 0, 2);
            this.tplNuevaSubasta.Controls.Add(this.lblFechaInicio, 0, 3);
            this.tplNuevaSubasta.Controls.Add(this.lblBienesDisponibles, 0, 7);
            this.tplNuevaSubasta.Controls.Add(this.lblFechFinal, 0, 5);
            this.tplNuevaSubasta.Controls.Add(this.lblHoraCierre, 0, 6);
            this.tplNuevaSubasta.Controls.Add(this.txtIncremento, 1, 2);
            this.tplNuevaSubasta.Controls.Add(this.dtpFechaCierre, 1, 5);
            this.tplNuevaSubasta.Controls.Add(this.dgvBienes, 1, 7);
            this.tplNuevaSubasta.Controls.Add(this.btnIniciarSubasta, 1, 8);
            this.tplNuevaSubasta.Controls.Add(this.dtpHoraCierre, 1, 6);
            this.tplNuevaSubasta.Controls.Add(this.txtDuenno, 1, 1);
            this.tplNuevaSubasta.Controls.Add(this.txtFechaHoraActual, 1, 3);
            this.tplNuevaSubasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplNuevaSubasta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tplNuevaSubasta.Location = new System.Drawing.Point(0, 0);
            this.tplNuevaSubasta.Name = "tplNuevaSubasta";
            this.tplNuevaSubasta.RowCount = 9;
            this.tplNuevaSubasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.198444F));
            this.tplNuevaSubasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.608357F));
            this.tplNuevaSubasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.329446F));
            this.tplNuevaSubasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.094266F));
            this.tplNuevaSubasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.166181F));
            this.tplNuevaSubasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.859087F));
            this.tplNuevaSubasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.426628F));
            this.tplNuevaSubasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.41497F));
            this.tplNuevaSubasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.71526F));
            this.tplNuevaSubasta.Size = new System.Drawing.Size(1646, 1029);
            this.tplNuevaSubasta.TabIndex = 0;
            // 
            // lblNuevaSubasta
            // 
            this.lblNuevaSubasta.AutoSize = true;
            this.lblNuevaSubasta.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevaSubasta.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaSubasta.ForeColor = System.Drawing.Color.White;
            this.lblNuevaSubasta.Location = new System.Drawing.Point(3, 0);
            this.lblNuevaSubasta.Name = "lblNuevaSubasta";
            this.lblNuevaSubasta.Size = new System.Drawing.Size(267, 30);
            this.lblNuevaSubasta.TabIndex = 1;
            this.lblNuevaSubasta.Text = "Iniciar Nueva Subasta";
            // 
            // lblDuenno
            // 
            this.lblDuenno.AutoSize = true;
            this.lblDuenno.BackColor = System.Drawing.Color.Transparent;
            this.lblDuenno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuenno.ForeColor = System.Drawing.Color.White;
            this.lblDuenno.Location = new System.Drawing.Point(3, 74);
            this.lblDuenno.Name = "lblDuenno";
            this.lblDuenno.Size = new System.Drawing.Size(76, 23);
            this.lblDuenno.TabIndex = 2;
            this.lblDuenno.Text = "DUEÑO";
            // 
            // lblIncremento
            // 
            this.lblIncremento.AutoSize = true;
            this.lblIncremento.BackColor = System.Drawing.Color.Transparent;
            this.lblIncremento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncremento.ForeColor = System.Drawing.Color.White;
            this.lblIncremento.Location = new System.Drawing.Point(3, 142);
            this.lblIncremento.Name = "lblIncremento";
            this.lblIncremento.Size = new System.Drawing.Size(279, 46);
            this.lblIncremento.TabIndex = 3;
            this.lblIncremento.Text = "INCREMENTO MÍNIMO DE LAS PUJAS ($)  ";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.White;
            this.lblFechaInicio.Location = new System.Drawing.Point(3, 238);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(227, 23);
            this.lblFechaInicio.TabIndex = 4;
            this.lblFechaInicio.Text = "FECHA/HORA DE INICIO";
            // 
            // lblBienesDisponibles
            // 
            this.lblBienesDisponibles.AutoSize = true;
            this.lblBienesDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.lblBienesDisponibles.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienesDisponibles.ForeColor = System.Drawing.Color.White;
            this.lblBienesDisponibles.Location = new System.Drawing.Point(3, 470);
            this.lblBienesDisponibles.Name = "lblBienesDisponibles";
            this.lblBienesDisponibles.Size = new System.Drawing.Size(188, 23);
            this.lblBienesDisponibles.TabIndex = 6;
            this.lblBienesDisponibles.Text = "BIENES DISPONIBLES";
            // 
            // lblFechFinal
            // 
            this.lblFechFinal.AutoSize = true;
            this.lblFechFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFechFinal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechFinal.ForeColor = System.Drawing.Color.White;
            this.lblFechFinal.Location = new System.Drawing.Point(3, 323);
            this.lblFechFinal.Name = "lblFechFinal";
            this.lblFechFinal.Size = new System.Drawing.Size(166, 23);
            this.lblFechFinal.TabIndex = 5;
            this.lblFechFinal.Text = "FECHA DE CIERRE";
            // 
            // lblHoraCierre
            // 
            this.lblHoraCierre.AutoSize = true;
            this.lblHoraCierre.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraCierre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraCierre.ForeColor = System.Drawing.Color.White;
            this.lblHoraCierre.Location = new System.Drawing.Point(3, 373);
            this.lblHoraCierre.Name = "lblHoraCierre";
            this.lblHoraCierre.Size = new System.Drawing.Size(159, 23);
            this.lblHoraCierre.TabIndex = 9;
            this.lblHoraCierre.Text = "HORA DE CIERRE";
            // 
            // txtIncremento
            // 
            this.txtIncremento.BackColor = System.Drawing.Color.Black;
            this.txtIncremento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncremento.ForeColor = System.Drawing.Color.White;
            this.txtIncremento.Location = new System.Drawing.Point(299, 145);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(192, 31);
            this.txtIncremento.TabIndex = 57;
            this.txtIncremento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIncremento_KeyPress);
            // 
            // dtpFechaCierre
            // 
            this.dtpFechaCierre.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFechaCierre.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaCierre.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaCierre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCierre.Location = new System.Drawing.Point(299, 326);
            this.dtpFechaCierre.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaCierre.MinDate = new System.DateTime(2024, 8, 5, 0, 0, 0, 0);
            this.dtpFechaCierre.Name = "dtpFechaCierre";
            this.dtpFechaCierre.Size = new System.Drawing.Size(237, 31);
            this.dtpFechaCierre.TabIndex = 59;
            this.dtpFechaCierre.Value = new System.DateTime(2024, 8, 5, 10, 51, 3, 0);
            this.dtpFechaCierre.ValueChanged += new System.EventHandler(this.dtpFechaCierre_ValueChanged);
            // 
            // dgvBienes
            // 
            this.dgvBienes.AllowUserToAddRows = false;
            this.dgvBienes.AllowUserToDeleteRows = false;
            this.dgvBienes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBienes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvBienes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBienes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmDescripcion,
            this.clmBaseVentaColones,
            this.clmPrecioBaseDolares,
            this.clmPrecioVentaDirecta,
            this.clmPrecioVentaDirectaColones,
            this.clmEstado});
            this.dgvBienes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBienes.GridColor = System.Drawing.Color.Black;
            this.dgvBienes.Location = new System.Drawing.Point(299, 473);
            this.dgvBienes.MultiSelect = false;
            this.dgvBienes.Name = "dgvBienes";
            this.dgvBienes.ReadOnly = true;
            this.dgvBienes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBienes.Size = new System.Drawing.Size(1196, 379);
            this.dgvBienes.TabIndex = 7;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.HeaderText = "Descripción";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            // 
            // clmBaseVentaColones
            // 
            this.clmBaseVentaColones.HeaderText = "Precio Base (₡)";
            this.clmBaseVentaColones.Name = "clmBaseVentaColones";
            this.clmBaseVentaColones.ReadOnly = true;
            // 
            // clmPrecioBaseDolares
            // 
            this.clmPrecioBaseDolares.HeaderText = "Precio Base ($)";
            this.clmPrecioBaseDolares.Name = "clmPrecioBaseDolares";
            this.clmPrecioBaseDolares.ReadOnly = true;
            // 
            // clmPrecioVentaDirecta
            // 
            this.clmPrecioVentaDirecta.HeaderText = "Precio Venta Directa ($)";
            this.clmPrecioVentaDirecta.Name = "clmPrecioVentaDirecta";
            this.clmPrecioVentaDirecta.ReadOnly = true;
            // 
            // clmPrecioVentaDirectaColones
            // 
            this.clmPrecioVentaDirectaColones.HeaderText = "Precio Venta Directa (₡)";
            this.clmPrecioVentaDirectaColones.Name = "clmPrecioVentaDirectaColones";
            this.clmPrecioVentaDirectaColones.ReadOnly = true;
            // 
            // clmEstado
            // 
            this.clmEstado.HeaderText = "Estado";
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            // 
            // btnIniciarSubasta
            // 
            this.btnIniciarSubasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarSubasta.BackColor = System.Drawing.Color.Black;
            this.btnIniciarSubasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSubasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSubasta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSubasta.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSubasta.Location = new System.Drawing.Point(1289, 858);
            this.btnIniciarSubasta.Name = "btnIniciarSubasta";
            this.btnIniciarSubasta.Size = new System.Drawing.Size(206, 32);
            this.btnIniciarSubasta.TabIndex = 72;
            this.btnIniciarSubasta.Text = "INICIAR SUBASTA";
            this.btnIniciarSubasta.UseVisualStyleBackColor = false;
            this.btnIniciarSubasta.Click += new System.EventHandler(this.btnIniciarSubasta_Click_1);
            // 
            // dtpHoraCierre
            // 
            this.dtpHoraCierre.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpHoraCierre.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpHoraCierre.CustomFormat = "HH:mm";
            this.dtpHoraCierre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraCierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraCierre.Location = new System.Drawing.Point(299, 376);
            this.dtpHoraCierre.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpHoraCierre.MinDate = new System.DateTime(2024, 8, 5, 0, 0, 0, 0);
            this.dtpHoraCierre.Name = "dtpHoraCierre";
            this.dtpHoraCierre.ShowUpDown = true;
            this.dtpHoraCierre.Size = new System.Drawing.Size(237, 31);
            this.dtpHoraCierre.TabIndex = 74;
            this.dtpHoraCierre.Value = new System.DateTime(2024, 8, 5, 16, 42, 8, 0);
            // 
            // txtDuenno
            // 
            this.txtDuenno.AutoSize = true;
            this.txtDuenno.BackColor = System.Drawing.Color.Transparent;
            this.txtDuenno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuenno.ForeColor = System.Drawing.Color.White;
            this.txtDuenno.Location = new System.Drawing.Point(299, 74);
            this.txtDuenno.Name = "txtDuenno";
            this.txtDuenno.Size = new System.Drawing.Size(18, 23);
            this.txtDuenno.TabIndex = 75;
            this.txtDuenno.Text = "*";
            // 
            // txtFechaHoraActual
            // 
            this.txtFechaHoraActual.AutoSize = true;
            this.txtFechaHoraActual.BackColor = System.Drawing.Color.Transparent;
            this.txtFechaHoraActual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaHoraActual.ForeColor = System.Drawing.Color.White;
            this.txtFechaHoraActual.Location = new System.Drawing.Point(299, 238);
            this.txtFechaHoraActual.Name = "txtFechaHoraActual";
            this.txtFechaHoraActual.Size = new System.Drawing.Size(18, 23);
            this.txtFechaHoraActual.TabIndex = 76;
            this.txtFechaHoraActual.Text = "*";
            // 
            // tmrFechaHora
            // 
            this.tmrFechaHora.Tick += new System.EventHandler(this.tmrFechaHora_Tick);
            // 
            // frmNuevaSubasta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::winShootForItAuctions.Properties.Resources.fondo_windows_4_borroso;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1646, 1029);
            this.Controls.Add(this.tplNuevaSubasta);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaSubasta";
            this.ShowIcon = false;
            this.Text = "frmNuevaSubasta";
            this.Load += new System.EventHandler(this.frmNuevaSubasta_Load);
            this.tplNuevaSubasta.ResumeLayout(false);
            this.tplNuevaSubasta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tplNuevaSubasta;
        private System.Windows.Forms.Label lblNuevaSubasta;
        private System.Windows.Forms.Label lblDuenno;
        private System.Windows.Forms.Label lblIncremento;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechFinal;
        private System.Windows.Forms.Label lblBienesDisponibles;
        private System.Windows.Forms.DataGridView dgvBienes;
        private System.Windows.Forms.Label lblHoraCierre;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.DateTimePicker dtpFechaCierre;
        private System.Windows.Forms.Button btnIniciarSubasta;
        private System.Windows.Forms.DateTimePicker dtpHoraCierre;
        private System.Windows.Forms.Timer tmrFechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBaseVentaColones;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioBaseDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioVentaDirecta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioVentaDirectaColones;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.Label txtDuenno;
        private System.Windows.Forms.Label txtFechaHoraActual;
    }
}