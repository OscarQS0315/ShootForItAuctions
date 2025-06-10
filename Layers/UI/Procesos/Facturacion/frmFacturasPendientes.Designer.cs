namespace winShootForItAuctions.Layers.UI.Procesos.Facturacion
{
    partial class frmFacturasPendientes
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFacturasPendientes = new System.Windows.Forms.Label();
            this.lblRangoFechas = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFinal = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.clmIdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigoSubasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTodas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9271F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.53949F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.472661F));
            this.tableLayoutPanel1.Controls.Add(this.lblFacturasPendientes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRangoFechas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaInicio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaInicio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFinal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaFinal, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelarFactura, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.dgvFacturas, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnTodas, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.094266F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.887269F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.275996F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.081633F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.63654F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.721088F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.4966F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.80661F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1646, 1029);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblFacturasPendientes
            // 
            this.lblFacturasPendientes.AutoSize = true;
            this.lblFacturasPendientes.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFacturasPendientes.ForeColor = System.Drawing.Color.White;
            this.lblFacturasPendientes.Location = new System.Drawing.Point(6, 0);
            this.lblFacturasPendientes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFacturasPendientes.Name = "lblFacturasPendientes";
            this.lblFacturasPendientes.Size = new System.Drawing.Size(252, 30);
            this.lblFacturasPendientes.TabIndex = 4;
            this.lblFacturasPendientes.Text = "Facturas Disponibles";
            // 
            // lblRangoFechas
            // 
            this.lblRangoFechas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRangoFechas.AutoSize = true;
            this.lblRangoFechas.BackColor = System.Drawing.Color.Transparent;
            this.lblRangoFechas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangoFechas.ForeColor = System.Drawing.Color.White;
            this.lblRangoFechas.Location = new System.Drawing.Point(150, 88);
            this.lblRangoFechas.Name = "lblRangoFechas";
            this.lblRangoFechas.Size = new System.Drawing.Size(175, 23);
            this.lblRangoFechas.TabIndex = 59;
            this.lblRangoFechas.Text = "Rango de Fechas:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.White;
            this.lblFechaInicio.Location = new System.Drawing.Point(331, 88);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(60, 23);
            this.lblFechaInicio.TabIndex = 60;
            this.lblFechaInicio.Text = "Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFechaInicio.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFechaInicio.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(331, 121);
            this.dtpFechaInicio.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaInicio.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(154, 31);
            this.dtpFechaInicio.TabIndex = 62;
            this.dtpFechaInicio.Value = new System.DateTime(2024, 8, 5, 10, 51, 3, 0);
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaCierre_ValueChanged);
            // 
            // lblFinal
            // 
            this.lblFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFinal.AutoSize = true;
            this.lblFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFinal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.ForeColor = System.Drawing.Color.White;
            this.lblFinal.Location = new System.Drawing.Point(331, 174);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(53, 23);
            this.lblFinal.TabIndex = 61;
            this.lblFinal.Text = "Final";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFechaFinal.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaFinal.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFinal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(331, 200);
            this.dtpFechaFinal.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFinal.MinDate = new System.DateTime(2024, 8, 5, 0, 0, 0, 0);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(154, 31);
            this.dtpFechaFinal.TabIndex = 63;
            this.dtpFechaFinal.Value = new System.DateTime(2024, 8, 5, 10, 51, 3, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(223, 200);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 32);
            this.btnBuscar.TabIndex = 64;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelarFactura
            // 
            this.btnCancelarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarFactura.BackColor = System.Drawing.Color.Black;
            this.btnCancelarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFactura.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFactura.ForeColor = System.Drawing.Color.White;
            this.btnCancelarFactura.Location = new System.Drawing.Point(1305, 711);
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(214, 32);
            this.btnCancelarFactura.TabIndex = 65;
            this.btnCancelarFactura.Text = "CANCELAR FACTURA";
            this.btnCancelarFactura.UseVisualStyleBackColor = false;
            this.btnCancelarFactura.Click += new System.EventHandler(this.btnCancelarFactura_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdFactura,
            this.clmFecha,
            this.clmCodigoSubasta,
            this.clmBien,
            this.clmSubtotal,
            this.clmTotal});
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturas.GridColor = System.Drawing.Color.Black;
            this.dgvFacturas.Location = new System.Drawing.Point(331, 284);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(1188, 421);
            this.dgvFacturas.TabIndex = 5;
            // 
            // clmIdFactura
            // 
            this.clmIdFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmIdFactura.HeaderText = "No de Factura";
            this.clmIdFactura.Name = "clmIdFactura";
            this.clmIdFactura.ReadOnly = true;
            this.clmIdFactura.Width = 132;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // clmCodigoSubasta
            // 
            this.clmCodigoSubasta.HeaderText = "Subasta";
            this.clmCodigoSubasta.Name = "clmCodigoSubasta";
            this.clmCodigoSubasta.ReadOnly = true;
            // 
            // clmBien
            // 
            this.clmBien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmBien.HeaderText = "Bien";
            this.clmBien.Name = "clmBien";
            this.clmBien.ReadOnly = true;
            this.clmBien.Width = 67;
            // 
            // clmSubtotal
            // 
            this.clmSubtotal.HeaderText = "SubTotal ($)";
            this.clmSubtotal.Name = "clmSubtotal";
            this.clmSubtotal.ReadOnly = true;
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "Total ($)";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            // 
            // btnTodas
            // 
            this.btnTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodas.BackColor = System.Drawing.Color.Black;
            this.btnTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodas.ForeColor = System.Drawing.Color.White;
            this.btnTodas.Location = new System.Drawing.Point(223, 284);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(102, 32);
            this.btnTodas.TabIndex = 66;
            this.btnTodas.Text = "TODAS";
            this.btnTodas.UseVisualStyleBackColor = false;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // frmFacturasPendientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::winShootForItAuctions.Properties.Resources.fondo_windows_3_borroso;
            this.ClientSize = new System.Drawing.Size(1646, 1029);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturasPendientes";
            this.ShowIcon = false;
            this.Text = "frmFacturasPendientes";
            this.Load += new System.EventHandler(this.frmFacturasPendientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFacturasPendientes;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Label lblRangoFechas;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelarFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoSubasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.Button btnTodas;
    }
}