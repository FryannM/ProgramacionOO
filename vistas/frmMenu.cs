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
       public frmMenu(/*string nombre, string Estado*/)
        {

           // llbNombre.Text = nombre;
           // lblUsuario.Text = Estado;
         

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
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vistas.frmClientes frm = new vistas.frmClientes();
            frm.MdiParent = this;
            frm.Show();
        }
        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vistas.frmCuentas frm = new vistas.frmCuentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
