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
    public partial class frmVerSucursales : Form
    { clases.bc_sucursales sucursales = new clases.bc_sucursales();

        public frmVerSucursales()
        {
            InitializeComponent();
        }

        private void tbox_buscar_TextChanged(object sender, EventArgs e)
        {
            dg_VerSucusales.DataSource = sucursales.BuscarPor(cbox_filtarPor.Text,tbox_buscar.Text);
        }

        private void frmVerSucursales_Load(object sender, EventArgs e)
        {
            dg_VerSucusales.DataSource = sucursales.verTodos();
        }

        private void dg_VerSucusales_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmSucursal sucursal = new frmSucursal(dg_VerSucusales.CurrentRow.Cells["ID_SUCURSAL"].Value.ToString(),
                                                   dg_VerSucusales.CurrentRow.Cells["ID_BANCO"].Value.ToString(),
                                                   dg_VerSucusales.CurrentRow.Cells["CODIGO"].Value.ToString(), 
                                                   dg_VerSucusales.CurrentRow.Cells["NOMBRE"].Value.ToString(), 
                                                   dg_VerSucusales.CurrentRow.Cells["DIRECCION"].Value.ToString(), 
                                                   dg_VerSucusales.CurrentRow.Cells["TELEFONO"].Value.ToString(),
                                                   dg_VerSucusales.CurrentRow.Cells["CORREO"].Value.ToString());
            sucursal.Show();
            this.Close();
        }
    }
}
