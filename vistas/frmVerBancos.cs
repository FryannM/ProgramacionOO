using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOO.vistas
{
    public partial class frmVerBancos : Form
    {
        clases.bc_bancos bancos = new clases.bc_bancos();

        public frmVerBancos()
        {
            InitializeComponent();
        }

        private void frmVerBancos_Load(object sender, EventArgs e)
        {
            dg_VerBanco.DataSource = bancos.verTodos();
        }

        private void tbox_buscar_TextChanged(object sender, EventArgs e)
        {
            dg_VerBanco.DataSource = bancos.BuscarPor(cbox_filtarPor.Text, tbox_buscar.Text);
        }

        private void dg_VerBanco_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            frmBanco banco = new frmBanco(dg_VerBanco.CurrentRow.Cells[1].Value.ToString(),
                                          dg_VerBanco.CurrentRow.Cells[2].Value.ToString(),
                                          dg_VerBanco.CurrentRow.Cells[3].Value.ToString(),
                                          dg_VerBanco.CurrentRow.Cells[4].Value.ToString());
            banco.Show();
            this.Close();

        }
    }
}
