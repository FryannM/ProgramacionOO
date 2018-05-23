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
    public partial class VerClientes : Form
    {
        clases.bc_clientes clientes = new clases.bc_clientes();
        public VerClientes()
        {
            InitializeComponent();
        }

        private void tbox_buscar_TextChanged(object sender, EventArgs e)
        {
            dg_VerClientes.DataSource = clientes.BuscarClientes(cbox_filtarPor.Text, tbox_buscar.Text);
        }

        private void bt_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerClientes_Load(object sender, EventArgs e)
        {
            dg_VerClientes.DataSource= clientes.verTodosCliente();
        }

        private void bt_selecionCuenta_Click(object sender, EventArgs e)
        {
            frmClientes cuenta = new frmClientes(dg_VerClientes.CurrentRow.Cells[2].Value.ToString(),
                                                 dg_VerClientes.CurrentRow.Cells[3].Value.ToString(),
                                                 dg_VerClientes.CurrentRow.Cells[4].Value.ToString(),
                                                 dg_VerClientes.CurrentRow.Cells[5].Value.ToString());
            cuenta.Show();
            this.Close();
        }
    }
}
