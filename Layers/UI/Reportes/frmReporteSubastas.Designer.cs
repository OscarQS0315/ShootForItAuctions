namespace winShootForItAuctions.Layers.UI.Reportes
{
    partial class frmReporteSubastas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.subastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubastas = new System.Windows.Forms.Label();
            this.lblBienes = new System.Windows.Forms.Label();
            this.cboBienes = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.subastaBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subastaBindingSource
            // 
            this.subastaBindingSource.DataSource = typeof(winShootForItAuctions.Layers.ENTITIES.Subasta);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.01093F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.80194F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.247874F));
            this.tableLayoutPanel1.Controls.Add(this.lblSubastas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBienes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboBienes, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.774539F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.664723F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.721088F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.5724F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75899F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.41108F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1646, 1029);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblSubastas
            // 
            this.lblSubastas.AutoSize = true;
            this.lblSubastas.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSubastas.ForeColor = System.Drawing.Color.White;
            this.lblSubastas.Location = new System.Drawing.Point(6, 0);
            this.lblSubastas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSubastas.Name = "lblSubastas";
            this.lblSubastas.Size = new System.Drawing.Size(116, 30);
            this.lblSubastas.TabIndex = 4;
            this.lblSubastas.Text = "Subastas";
            // 
            // lblBienes
            // 
            this.lblBienes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienes.AutoSize = true;
            this.lblBienes.BackColor = System.Drawing.Color.Transparent;
            this.lblBienes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienes.ForeColor = System.Drawing.Color.White;
            this.lblBienes.Location = new System.Drawing.Point(206, 80);
            this.lblBienes.Name = "lblBienes";
            this.lblBienes.Size = new System.Drawing.Size(70, 23);
            this.lblBienes.TabIndex = 59;
            this.lblBienes.Text = "BIENES";
            // 
            // cboBienes
            // 
            this.cboBienes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cboBienes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBienes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboBienes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBienes.ForeColor = System.Drawing.Color.White;
            this.cboBienes.FormattingEnabled = true;
            this.cboBienes.Location = new System.Drawing.Point(282, 83);
            this.cboBienes.Name = "cboBienes";
            this.cboBienes.Size = new System.Drawing.Size(199, 31);
            this.cboBienes.TabIndex = 85;
            this.cboBienes.SelectedIndexChanged += new System.EventHandler(this.cboBienes_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dataSetSubasta";
            reportDataSource1.Value = this.subastaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "winShootForItAuctions.Layers.UI.Reportes.repSubastasByBien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(282, 159);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1323, 607);
            this.reportViewer1.TabIndex = 86;
            // 
            // frmReporteSubastas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::winShootForItAuctions.Properties.Resources.fondo_windows_2_borroso;
            this.ClientSize = new System.Drawing.Size(1646, 1029);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteSubastas";
            this.ShowIcon = false;
            this.Text = "frmReporteSubastas";
            this.Load += new System.EventHandler(this.frmReporteSubastas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subastaBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSubastas;
        private System.Windows.Forms.Label lblBienes;
        private System.Windows.Forms.ComboBox cboBienes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource subastaBindingSource;
    }
}