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

namespace ProgramacionOO.vistas
{
    public partial class frmLogin : Form
    {
        public object MessageBoxButton { get; private set; }
        public Nullable<bool> DialogResult { get; set; }
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
               
                //   DialogResult = true;
            }
            else
            {
                frmMenu frm = new frmMenu();
                frm.Show();
                this.Hide();
                //MessageBox.Show("Usuario O Contraseña no son validas \n" +
                //                "Intento " + intentos.ToString().Trim() + "/3",
                //"Error al inicio de Sesion", MessageBoxButton.OK, MessageBoxImage.Error);
                //if (intentos == 3) DialogResult = false;
                
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
