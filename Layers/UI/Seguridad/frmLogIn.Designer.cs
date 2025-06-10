namespace winShootForItAuctions.Layers.UI
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbBarraArriba = new System.Windows.Forms.PictureBox();
            this.ptbBarraAbajo = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenna = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.lklRegistrarse = new System.Windows.Forms.LinkLabel();
            this.ptbMostrarContrasenna = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarraArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarraAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMostrarContrasenna)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 330);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winShootForItAuctions.Properties.Resources.SHOOT_FOR_IT_AUCTIONS_HD;
            this.pictureBox1.Location = new System.Drawing.Point(-88, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ptbBarraArriba
            // 
            this.ptbBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbBarraArriba.Location = new System.Drawing.Point(335, 97);
            this.ptbBarraArriba.Name = "ptbBarraArriba";
            this.ptbBarraArriba.Size = new System.Drawing.Size(410, 1);
            this.ptbBarraArriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBarraArriba.TabIndex = 1;
            this.ptbBarraArriba.TabStop = false;
            // 
            // ptbBarraAbajo
            // 
            this.ptbBarraAbajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbBarraAbajo.Location = new System.Drawing.Point(335, 166);
            this.ptbBarraAbajo.Name = "ptbBarraAbajo";
            this.ptbBarraAbajo.Size = new System.Drawing.Size(410, 1);
            this.ptbBarraAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBarraAbajo.TabIndex = 2;
            this.ptbBarraAbajo.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(335, 73);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(410, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "IDENTIFICACIÓN";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtContrasenna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenna.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenna.ForeColor = System.Drawing.Color.Silver;
            this.txtContrasenna.Location = new System.Drawing.Point(335, 143);
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.Size = new System.Drawing.Size(410, 20);
            this.txtContrasenna.TabIndex = 2;
            this.txtContrasenna.Text = "CONTRASEÑA";
            this.txtContrasenna.Enter += new System.EventHandler(this.txtContrasenna_Enter);
            this.txtContrasenna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasenna_KeyPress);
            this.txtContrasenna.Leave += new System.EventHandler(this.txtContrasenna_Leave);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Silver;
            this.lblLogin.Location = new System.Drawing.Point(487, 8);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(100, 33);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "LOGIN";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Silver;
            this.btnIngresar.Location = new System.Drawing.Point(335, 209);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(410, 40);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = false;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(684, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 8;
            // 
            // lklRegistrarse
            // 
            this.lklRegistrarse.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lklRegistrarse.AutoSize = true;
            this.lklRegistrarse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklRegistrarse.LinkColor = System.Drawing.Color.DimGray;
            this.lklRegistrarse.Location = new System.Drawing.Point(499, 283);
            this.lklRegistrarse.Name = "lklRegistrarse";
            this.lklRegistrarse.Size = new System.Drawing.Size(76, 17);
            this.lklRegistrarse.TabIndex = 0;
            this.lklRegistrarse.TabStop = true;
            this.lklRegistrarse.Text = "Registrarse";
            this.lklRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ptbMostrarContrasenna
            // 
            this.ptbMostrarContrasenna.BackColor = System.Drawing.Color.Transparent;
            this.ptbMostrarContrasenna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMostrarContrasenna.Image = global::winShootForItAuctions.Properties.Resources.mostrar_contrasenna_icon;
            this.ptbMostrarContrasenna.Location = new System.Drawing.Point(751, 137);
            this.ptbMostrarContrasenna.Name = "ptbMostrarContrasenna";
            this.ptbMostrarContrasenna.Size = new System.Drawing.Size(35, 30);
            this.ptbMostrarContrasenna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbMostrarContrasenna.TabIndex = 67;
            this.ptbMostrarContrasenna.TabStop = false;
            this.ptbMostrarContrasenna.Click += new System.EventHandler(this.ptbMostrarContrasenna_Click);
            // 
            // frmLogIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(807, 330);
            this.Controls.Add(this.ptbMostrarContrasenna);
            this.Controls.Add(this.lklRegistrarse);
            this.Controls.Add(this.nightControlBox1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtContrasenna);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.ptbBarraAbajo);
            this.Controls.Add(this.ptbBarraArriba);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogIn";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogIn_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarraArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarraAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMostrarContrasenna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbBarraArriba;
        private System.Windows.Forms.PictureBox ptbBarraAbajo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenna;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnIngresar;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lklRegistrarse;
        private System.Windows.Forms.PictureBox ptbMostrarContrasenna;
    }
}