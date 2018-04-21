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

namespace ProgramacionOO.vistas
{
    public partial class conectar : Form
    {
        public conectar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection ore = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.72)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));User Id=mamf;Password=numero4401;");
            //<!--192.168.1.72  System numero4401-->
            MessageBox.Show("EXITO");
        }
    }
}
