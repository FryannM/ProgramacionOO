using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProgramacionOO.vistas
{
    public partial class frmLogin : Form
    {


        int intentos = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            intentos += 1;

            if (datamanager.ValidarUsuario(txtUser.Text, txtpassword.Text))
            {

                frmMenu frm = new frmMenu();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario O Contraseña no son validas \n" +
                                "Intento " + intentos.ToString().Trim() + "/3",
                "Error al inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (intentos == 3)
                {
                    this.Hide();
                }
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
