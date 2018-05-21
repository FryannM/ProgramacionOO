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
    public partial class frmdocbancarios : Form
    {
        public frmdocbancarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloNumero(e);
        }

        private void txtnodoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloLetra(e);
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloLetra(e);
        }
    }
}
