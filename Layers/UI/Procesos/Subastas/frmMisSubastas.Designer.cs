namespace winShootForItAuctions.Layers.UI.Procesos.Subastas
{
    partial class frmMisSubastas
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
            this.lblMisSubastas = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoriaBien = new System.Windows.Forms.ComboBox();
            this.dgvSubastas = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIncrementoMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaHoraCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubastas = new System.Windows.Forms.Label();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubastas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.09816F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.37423F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.527607F));
            this.tableLayoutPanel1.Controls.Add(this.lblMisSubastas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCategoria, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboCategoriaBien, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvSubastas, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSubastas, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ptbFoto, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.600102F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.224856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.95959F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.848485F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.27273F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1630, 990);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMisSubastas
            // 
            this.lblMisSubastas.AutoSize = true;
            this.lblMisSubastas.BackColor = System.Drawing.Color.Transparent;
            this.lblMisSubastas.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisSubastas.ForeColor = System.Drawing.Color.White;
            this.lblMisSubastas.Location = new System.Drawing.Point(3, 0);
            this.lblMisSubastas.Name = "lblMisSubastas";
            this.lblMisSubastas.Size = new System.Drawing.Size(162, 30);
            this.lblMisSubastas.TabIndex = 2;
            this.lblMisSubastas.Text = "Mis Subastas";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(173, 65);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(119, 23);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "CATEGORÍA";
            // 
            // cboCategoriaBien
            // 
            this.cboCategoriaBien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cboCategoriaBien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaBien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCategoriaBien.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoriaBien.ForeColor = System.Drawing.Color.White;
            this.cboCategoriaBien.FormattingEnabled = true;
            this.cboCategoriaBien.Location = new System.Drawing.Point(298, 68);
            this.cboCategoriaBien.Name = "cboCategoriaBien";
            this.cboCategoriaBien.Size = new System.Drawing.Size(199, 31);
            this.cboCategoriaBien.TabIndex = 68;
            this.cboCategoriaBien.SelectedIndexChanged += new System.EventHandler(this.cboCategoriaBien_SelectedIndexChanged);
            // 
            // dgvSubastas
            // 
            this.dgvSubastas.AllowUserToAddRows = false;
            this.dgvSubastas.AllowUserToDeleteRows = false;
            this.dgvSubastas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubastas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvSubastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubastas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmBien,
            this.clmIncrementoMinimo,
            this.clmFechaHoraInicio,
            this.clmFechaHoraCierre,
            this.clmPrecioBase,
            this.clmEstado});
            this.dgvSubastas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubastas.Location = new System.Drawing.Point(298, 222);
            this.dgvSubastas.MultiSelect = false;
            this.dgvSubastas.Name = "dgvSubastas";
            this.dgvSubastas.ReadOnly = true;
            this.dgvSubastas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubastas.Size = new System.Drawing.Size(1189, 348);
            this.dgvSubastas.TabIndex = 79;
            this.dgvSubastas.SelectionChanged += new System.EventHandler(this.dgvSubastas_SelectionChanged);
            // 
            // clmCodigo
            // 
            this.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 89;
            // 
            // clmBien
            // 
            this.clmBien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmBien.HeaderText = "Bien";
            this.clmBien.Name = "clmBien";
            this.clmBien.ReadOnly = true;
            this.clmBien.Width = 65;
            // 
            // clmIncrementoMinimo
            // 
            this.clmIncrementoMinimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmIncrementoMinimo.HeaderText = "Incremento Mímino ($)";
            this.clmIncrementoMinimo.Name = "clmIncrementoMinimo";
            this.clmIncrementoMinimo.ReadOnly = true;
            // 
            // clmFechaHoraInicio
            // 
            this.clmFechaHoraInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmFechaHoraInicio.HeaderText = "Fecha / Hora Inicio";
            this.clmFechaHoraInicio.Name = "clmFechaHoraInicio";
            this.clmFechaHoraInicio.ReadOnly = true;
            this.clmFechaHoraInicio.Width = 87;
            // 
            // clmFechaHoraCierre
            // 
            this.clmFechaHoraCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmFechaHoraCierre.HeaderText = "Fecha / Hora Cierre";
            this.clmFechaHoraCierre.Name = "clmFechaHoraCierre";
            this.clmFechaHoraCierre.ReadOnly = true;
            this.clmFechaHoraCierre.Width = 87;
            // 
            // clmPrecioBase
            // 
            this.clmPrecioBase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmPrecioBase.HeaderText = "Precio Base ($)";
            this.clmPrecioBase.Name = "clmPrecioBase";
            this.clmPrecioBase.ReadOnly = true;
            this.clmPrecioBase.Width = 85;
            // 
            // clmEstado
            // 
            this.clmEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmEstado.HeaderText = "Estado";
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            this.clmEstado.Width = 81;
            // 
            // lblSubastas
            // 
            this.lblSubastas.AutoSize = true;
            this.lblSubastas.BackColor = System.Drawing.Color.Transparent;
            this.lblSubastas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubastas.ForeColor = System.Drawing.Color.White;
            this.lblSubastas.Location = new System.Drawing.Point(298, 188);
            this.lblSubastas.Name = "lblSubastas";
            this.lblSubastas.Size = new System.Drawing.Size(100, 23);
            this.lblSubastas.TabIndex = 80;
            this.lblSubastas.Text = "SUBASTAS";
            // 
            // ptbFoto
            // 
            this.ptbFoto.Image = global::winShootForItAuctions.Properties.Resources.imagen_icon;
            this.ptbFoto.Location = new System.Drawing.Point(298, 623);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(553, 284);
            this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbFoto.TabIndex = 83;
            this.ptbFoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 84;
            this.label1.Text = "FOTOGRAFÍA";
            // 
            // frmMisSubastas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::winShootForItAuctions.Properties.Resources.fondo_windows_4_borroso;
            this.ClientSize = new System.Drawing.Size(1630, 990);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMisSubastas";
            this.ShowIcon = false;
            this.Text = "frmMisSubastas";
            this.Load += new System.EventHandler(this.frmMisSubastas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubastas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMisSubastas;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoriaBien;
        private System.Windows.Forms.DataGridView dgvSubastas;
        private System.Windows.Forms.Label lblSubastas;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIncrementoMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaHoraCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.Label label1;
    }
}