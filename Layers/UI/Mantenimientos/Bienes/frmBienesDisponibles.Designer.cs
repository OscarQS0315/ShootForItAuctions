namespace winShootForItAuctions.Layers.UI
{
    partial class frmBienesDisponibles
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
            this.tlpBienesDisponibles = new System.Windows.Forms.TableLayoutPanel();
            this.lblBienesDisponibles = new System.Windows.Forms.Label();
            this.dgvBienes = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBaseVentaColones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioBaseDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioVentaDirecta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioVentaDirectaColones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarBien = new System.Windows.Forms.Button();
            this.btnHabilitarDehabilitarBien = new System.Windows.Forms.Button();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoriaBien = new System.Windows.Forms.ComboBox();
            this.tlpBienesDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBienesDisponibles
            // 
            this.tlpBienesDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.tlpBienesDisponibles.ColumnCount = 3;
            this.tlpBienesDisponibles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.73026F));
            this.tlpBienesDisponibles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.13244F));
            this.tlpBienesDisponibles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.1373F));
            this.tlpBienesDisponibles.Controls.Add(this.lblBienesDisponibles, 0, 0);
            this.tlpBienesDisponibles.Controls.Add(this.dgvBienes, 0, 1);
            this.tlpBienesDisponibles.Controls.Add(this.btnModificarBien, 0, 2);
            this.tlpBienesDisponibles.Controls.Add(this.btnHabilitarDehabilitarBien, 0, 3);
            this.tlpBienesDisponibles.Controls.Add(this.ptbImagen, 1, 1);
            this.tlpBienesDisponibles.Controls.Add(this.btnTodos, 1, 3);
            this.tlpBienesDisponibles.Controls.Add(this.lblCódigo, 1, 2);
            this.tlpBienesDisponibles.Controls.Add(this.txtCódigo, 2, 2);
            this.tlpBienesDisponibles.Controls.Add(this.btnBuscar, 2, 3);
            this.tlpBienesDisponibles.Controls.Add(this.lblCategoria, 1, 0);
            this.tlpBienesDisponibles.Controls.Add(this.cboCategoriaBien, 2, 0);
            this.tlpBienesDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBienesDisponibles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpBienesDisponibles.ForeColor = System.Drawing.Color.Black;
            this.tlpBienesDisponibles.Location = new System.Drawing.Point(0, 0);
            this.tlpBienesDisponibles.Name = "tlpBienesDisponibles";
            this.tlpBienesDisponibles.RowCount = 6;
            this.tlpBienesDisponibles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpBienesDisponibles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.2206F));
            this.tlpBienesDisponibles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.316813F));
            this.tlpBienesDisponibles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.64626F));
            this.tlpBienesDisponibles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.28863F));
            this.tlpBienesDisponibles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpBienesDisponibles.Size = new System.Drawing.Size(1646, 1029);
            this.tlpBienesDisponibles.TabIndex = 0;
            this.tlpBienesDisponibles.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpBienesDisponibles_Paint);
            // 
            // lblBienesDisponibles
            // 
            this.lblBienesDisponibles.AutoSize = true;
            this.lblBienesDisponibles.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBienesDisponibles.ForeColor = System.Drawing.Color.White;
            this.lblBienesDisponibles.Location = new System.Drawing.Point(6, 0);
            this.lblBienesDisponibles.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBienesDisponibles.Name = "lblBienesDisponibles";
            this.lblBienesDisponibles.Size = new System.Drawing.Size(228, 30);
            this.lblBienesDisponibles.TabIndex = 3;
            this.lblBienesDisponibles.Text = "Bienes Disponibles";
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
            this.dgvBienes.Location = new System.Drawing.Point(3, 174);
            this.dgvBienes.MultiSelect = false;
            this.dgvBienes.Name = "dgvBienes";
            this.dgvBienes.ReadOnly = true;
            this.dgvBienes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBienes.Size = new System.Drawing.Size(1043, 377);
            this.dgvBienes.TabIndex = 4;
            this.dgvBienes.SelectionChanged += new System.EventHandler(this.dgvBienes_SelectionChanged);
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
            this.clmBaseVentaColones.HeaderText = "Precio Base Colones";
            this.clmBaseVentaColones.Name = "clmBaseVentaColones";
            this.clmBaseVentaColones.ReadOnly = true;
            // 
            // clmPrecioBaseDolares
            // 
            this.clmPrecioBaseDolares.HeaderText = "Precio Base Dólares";
            this.clmPrecioBaseDolares.Name = "clmPrecioBaseDolares";
            this.clmPrecioBaseDolares.ReadOnly = true;
            // 
            // clmPrecioVentaDirecta
            // 
            this.clmPrecioVentaDirecta.HeaderText = "Precio Venta Directa Dólares";
            this.clmPrecioVentaDirecta.Name = "clmPrecioVentaDirecta";
            this.clmPrecioVentaDirecta.ReadOnly = true;
            // 
            // clmPrecioVentaDirectaColones
            // 
            this.clmPrecioVentaDirectaColones.HeaderText = "Precio Venta Directa Colones";
            this.clmPrecioVentaDirectaColones.Name = "clmPrecioVentaDirectaColones";
            this.clmPrecioVentaDirectaColones.ReadOnly = true;
            // 
            // clmEstado
            // 
            this.clmEstado.HeaderText = "Estado";
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            // 
            // btnModificarBien
            // 
            this.btnModificarBien.BackColor = System.Drawing.Color.Black;
            this.btnModificarBien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarBien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarBien.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarBien.ForeColor = System.Drawing.Color.White;
            this.btnModificarBien.Location = new System.Drawing.Point(3, 557);
            this.btnModificarBien.Name = "btnModificarBien";
            this.btnModificarBien.Size = new System.Drawing.Size(163, 32);
            this.btnModificarBien.TabIndex = 69;
            this.btnModificarBien.Text = "MODIFICAR";
            this.btnModificarBien.UseVisualStyleBackColor = false;
            this.btnModificarBien.Click += new System.EventHandler(this.btnModificarBien_Click_1);
            // 
            // btnHabilitarDehabilitarBien
            // 
            this.btnHabilitarDehabilitarBien.BackColor = System.Drawing.Color.Black;
            this.btnHabilitarDehabilitarBien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHabilitarDehabilitarBien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitarDehabilitarBien.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarDehabilitarBien.ForeColor = System.Drawing.Color.White;
            this.btnHabilitarDehabilitarBien.Location = new System.Drawing.Point(3, 622);
            this.btnHabilitarDehabilitarBien.Name = "btnHabilitarDehabilitarBien";
            this.btnHabilitarDehabilitarBien.Size = new System.Drawing.Size(208, 32);
            this.btnHabilitarDehabilitarBien.TabIndex = 70;
            this.btnHabilitarDehabilitarBien.Text = "DEHABILITAR BIEN";
            this.btnHabilitarDehabilitarBien.UseVisualStyleBackColor = false;
            this.btnHabilitarDehabilitarBien.Click += new System.EventHandler(this.btnHabilitarDehabilitarBien_Click);
            // 
            // ptbImagen
            // 
            this.ptbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbImagen.Location = new System.Drawing.Point(1052, 281);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(275, 162);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbImagen.TabIndex = 72;
            this.ptbImagen.TabStop = false;
            // 
            // btnTodos
            // 
            this.btnTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodos.BackColor = System.Drawing.Color.Black;
            this.btnTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.Color.White;
            this.btnTodos.Location = new System.Drawing.Point(1225, 622);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(102, 32);
            this.btnTodos.TabIndex = 73;
            this.btnTodos.Text = "TODOS";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // lblCódigo
            // 
            this.lblCódigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCódigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.ForeColor = System.Drawing.Color.White;
            this.lblCódigo.Location = new System.Drawing.Point(1236, 596);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(91, 23);
            this.lblCódigo.TabIndex = 7;
            this.lblCódigo.Text = "CÓDIGO";
            // 
            // txtCódigo
            // 
            this.txtCódigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCódigo.BackColor = System.Drawing.Color.Black;
            this.txtCódigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCódigo.ForeColor = System.Drawing.Color.White;
            this.txtCódigo.Location = new System.Drawing.Point(1333, 585);
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(199, 31);
            this.txtCódigo.TabIndex = 56;
            this.txtCódigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCódigo_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(1333, 622);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 32);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(1208, 148);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(119, 23);
            this.lblCategoria.TabIndex = 58;
            this.lblCategoria.Text = "CATEGORÍA";
            // 
            // cboCategoriaBien
            // 
            this.cboCategoriaBien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCategoriaBien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cboCategoriaBien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaBien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCategoriaBien.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoriaBien.ForeColor = System.Drawing.Color.White;
            this.cboCategoriaBien.FormattingEnabled = true;
            this.cboCategoriaBien.Location = new System.Drawing.Point(1333, 137);
            this.cboCategoriaBien.Name = "cboCategoriaBien";
            this.cboCategoriaBien.Size = new System.Drawing.Size(199, 31);
            this.cboCategoriaBien.TabIndex = 68;
            this.cboCategoriaBien.SelectedIndexChanged += new System.EventHandler(this.cboCategoriaBien_SelectedIndexChanged);
            // 
            // frmBienesDisponibles
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::winShootForItAuctions.Properties.Resources.fondo_windows_3_borroso;
            this.ClientSize = new System.Drawing.Size(1646, 1029);
            this.Controls.Add(this.tlpBienesDisponibles);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBienesDisponibles";
            this.ShowIcon = false;
            this.Text = "frmBienesDisponibles";
            this.Load += new System.EventHandler(this.frmBienesDisponibles_Load);
            this.tlpBienesDisponibles.ResumeLayout(false);
            this.tlpBienesDisponibles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBienesDisponibles;
        private System.Windows.Forms.Label lblBienesDisponibles;
        private System.Windows.Forms.DataGridView dgvBienes;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoriaBien;
        private System.Windows.Forms.Button btnModificarBien;
        private System.Windows.Forms.Button btnHabilitarDehabilitarBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBaseVentaColones;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioBaseDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioVentaDirecta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioVentaDirectaColones;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Button btnTodos;
    }
}