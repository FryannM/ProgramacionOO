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
    public partial class frmVerCuentas : Form
    {
        clases.bc_cuentas registro = new clases.bc_cuentas();
        
        public frmVerCuentas()
        {
            InitializeComponent();
        }
        private void tbox_buscar_TextChanged(object sender, EventArgs e)
        {
            dg_VerCuentas.DataSource = registro.BuscarPor(cbox_filtarPor.Text, tbox_buscar.Text);
        }

        private void frmVerCuentas_Load(object sender, EventArgs e)
        {
            dg_VerCuentas.DataSource = registro.verTodos();
            
        }

        private void dg_VerCuentas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmCuentas cuenta = new frmCuentas(dg_VerCuentas.CurrentRow.Cells[0].Value.ToString(),
                                            dg_VerCuentas.CurrentRow.Cells[1].Value.ToString(),
                                            dg_VerCuentas.CurrentRow.Cells[2].Value.ToString(),
                                            dg_VerCuentas.CurrentRow.Cells[3].Value.ToString());
            cuenta.Show();
            this.Close();
        }
      
    }
}
