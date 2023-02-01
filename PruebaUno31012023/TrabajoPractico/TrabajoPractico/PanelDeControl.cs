using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class PanelDeControl : Form
    {
        private lblmontorequerido sp;
        public PanelDeControl()
        {
            InitializeComponent();
        }

        private void sistemaDePrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sp == null)
            {
                sp = new lblmontorequerido();
                sp.MdiParent = this;
                sp.FormClosed += new FormClosedEventHandler(cerrarsp);
                sp.Show();
            }
            else {
                sp.Activate();
            }
        }
        void cerrarsp(object sender, FormClosedEventArgs e)
        {
            sp = null;
        }

        private void sistemaDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemaDeFactura sf = new SistemaDeFactura();
            sf.MdiParent = this;
            sf.Show();
        }

        private void sistemaDeDepreciaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemaDeDepreciacion sd = new SistemaDeDepreciacion();
            sd.MdiParent = this;
            sd.Show();
        }
    }
}
