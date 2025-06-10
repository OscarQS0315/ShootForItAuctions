namespace winShootForItAuctions.Layers.UI
{
    partial class frmRegistrarCategoriaBien
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
            this.controlBoxEdit1 = new ReaLTaiizor.Controls.ControlBoxEdit();
            this.tlpRegistrarCategoriaBien = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegistrarNuevaCategoría = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCategoriasActuales = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpRegistrarCategoriaBien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBoxEdit1
            // 
            this.controlBoxEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBoxEdit1.BackColor = System.Drawing.Color.Transparent;
            this.controlBoxEdit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlBoxEdit1.DefaultLocation = false;
            this.controlBoxEdit1.Location = new System.Drawing.Point(1570, 0);
            this.controlBoxEdit1.Name = "controlBoxEdit1";
            this.controlBoxEdit1.Size = new System.Drawing.Size(77, 19);
            this.controlBoxEdit1.TabIndex = 26;
            this.controlBoxEdit1.Text = "ncbRegistrarNuevaCategoria";
            // 
            // tlpRegistrarCategoriaBien
            // 
            this.tlpRegistrarCategoriaBien.BackColor = System.Drawing.Color.Transparent;
            this.tlpRegistrarCategoriaBien.ColumnCount = 3;
            this.tlpRegistrarCategoriaBien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.94168F));
            this.tlpRegistrarCategoriaBien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.69745F));
            this.tlpRegistrarCategoriaBien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.42163F));
            this.tlpRegistrarCategoriaBien.Controls.Add(this.lblRegistrarNuevaCategoría, 0, 0);
            this.tlpRegistrarCategoriaBien.Controls.Add(this.btnAgregar, 1, 4);
            this.tlpRegistrarCategoriaBien.Controls.Add(this.lblCategoriasActuales, 1, 5);
            this.tlpRegistrarCategoriaBien.Controls.Add(this.dgvCategorias, 1, 6);
            this.tlpRegistrarCategoriaBien.Controls.Add(this.btnEliminar, 1, 7);
            this.tlpRegistrarCategoriaBien.Controls.Add(this.lblNombre, 0, 1);
            this.tlpRegistrarCategoriaBien.Controls.Add(this.txtNombre, 1, 1);
            this.tlpRegistrarCategoriaBien.Controls.Add(this.lblDescripcion, 0, 2);
            this.tlpRegistrarCategoriaBien.Controls.Add(this.txtDescripcion, 1, 2);
            this.tlpRegistrarCategoriaBien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRegistrarCategoriaBien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpRegistrarCategoriaBien.ForeColor = System.Drawing.Color.Black;
            this.tlpRegistrarCategoriaBien.Location = new System.Drawing.Point(0, 0);
            this.tlpRegistrarCategoriaBien.Name = "tlpRegistrarCategoriaBien";
            this.tlpRegistrarCategoriaBien.RowCount = 8;
            this.tlpRegistrarCategoriaBien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRegistrarCategoriaBien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.677357F));
            this.tlpRegistrarCategoriaBien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.968902F));
            this.tlpRegistrarCategoriaBien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.28863F));
            this.tlpRegistrarCategoriaBien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.45481F));
            this.tlpRegistrarCategoriaBien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.426628F));
            this.tlpRegistrarCategoriaBien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.91642F));
            this.tlpRegistrarCategoriaBien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRegistrarCategoriaBien.Size = new System.Drawing.Size(1646, 1029);
            this.tlpRegistrarCategoriaBien.TabIndex = 27;
            this.tlpRegistrarCategoriaBien.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpRegistrarCategoriaBien_Paint);
            // 
            // lblRegistrarNuevaCategoría
            // 
            this.lblRegistrarNuevaCategoría.AutoSize = true;
            this.lblRegistrarNuevaCategoría.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblRegistrarNuevaCategoría.ForeColor = System.Drawing.Color.White;
            this.lblRegistrarNuevaCategoría.Location = new System.Drawing.Point(6, 0);
            this.lblRegistrarNuevaCategoría.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegistrarNuevaCategoría.Name = "lblRegistrarNuevaCategoría";
            this.lblRegistrarNuevaCategoría.Size = new System.Drawing.Size(322, 30);
            this.lblRegistrarNuevaCategoría.TabIndex = 4;
            this.lblRegistrarNuevaCategoría.Text = "Registrar Nueva Categoría";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(429, 367);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(199, 32);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCategoriasActuales
            // 
            this.lblCategoriasActuales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategoriasActuales.AutoSize = true;
            this.lblCategoriasActuales.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriasActuales.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriasActuales.ForeColor = System.Drawing.Color.White;
            this.lblCategoriasActuales.Location = new System.Drawing.Point(429, 525);
            this.lblCategoriasActuales.Name = "lblCategoriasActuales";
            this.lblCategoriasActuales.Size = new System.Drawing.Size(226, 23);
            this.lblCategoriasActuales.TabIndex = 64;
            this.lblCategoriasActuales.Text = "CATEGORÍAS ACTUALES";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmDescripcion});
            this.dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategorias.GridColor = System.Drawing.Color.Black;
            this.dgvCategorias.Location = new System.Drawing.Point(429, 551);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(1025, 343);
            this.dgvCategorias.TabIndex = 65;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(1255, 900);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(199, 32);
            this.btnEliminar.TabIndex = 66;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(3, 128);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Black;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(429, 131);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(308, 31);
            this.txtNombre.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 207);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(135, 23);
            this.lblDescripcion.TabIndex = 57;
            this.lblDescripcion.Text = "DESCRIPCIÓN";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Black;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(429, 210);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(761, 31);
            this.txtDescripcion.TabIndex = 3;
            // 
            // clmCodigo
            // 
            this.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 92;
            // 
            // clmNombre
            // 
            this.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmDescripcion.HeaderText = "Descripción";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            this.clmDescripcion.Width = 125;
            // 
            // frmRegistrarCategoriaBien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::winShootForItAuctions.Properties.Resources.fondo_windows_3_borroso;
            this.ClientSize = new System.Drawing.Size(1646, 1029);
            this.Controls.Add(this.tlpRegistrarCategoriaBien);
            this.Controls.Add(this.controlBoxEdit1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrarCategoriaBien";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarCategoriaBien";
            this.Load += new System.EventHandler(this.frmRegistrarCategoriaBien_Load);
            this.tlpRegistrarCategoriaBien.ResumeLayout(false);
            this.tlpRegistrarCategoriaBien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.ControlBoxEdit controlBoxEdit1;
        private System.Windows.Forms.TableLayoutPanel tlpRegistrarCategoriaBien;
        private System.Windows.Forms.Label lblRegistrarNuevaCategoría;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCategoriasActuales;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
    }
}