using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winShootForItAuctions.Layers.UI
{
    public partial class frmFondo : Form
    {
        public frmFondo()
        {
            InitializeComponent();
        }
        
        private void frmFondo_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
