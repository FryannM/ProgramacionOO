using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOO
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vistas.frmBanco frm = new vistas.frmBanco();
            frm.MdiParent = this;
            frm.Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(datamanager.SMensajes, "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
