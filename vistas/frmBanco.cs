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
    public partial class frmBanco : Form
    {
        // private entidades.dmCargo registro { get; set; }
        private clases.bc_bancos registro { get; set; }
        public frmBanco()
        {
            InitializeComponent();
        }

        private void frmBanco_Load(object sender, EventArgs e)
        {
            registro = new clases.bc_bancos();
            registro.buscarUltimo();

        
            mostrar();
        }
        private void mostrar()
        {
            //Convert.ToInt16(registro.bc_bancoid).ToString();


            txtcodigo.Text = registro.bc_bancoCodigo;
            txtRnc.Text = registro.bc_bancoRnc;
            txtNombre.Text = registro.bc_bancoNombre;
            txtDireccion.Text = registro.bc_bancoDireccion;
            
           
        }

    }
}