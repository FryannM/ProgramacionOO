using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProgramacionOO.vistas
{
    public partial class frmBanco : Form
    {
        private clases.bc_bancos registro { get; set; } = new clases.bc_bancos();


        public frmBanco()
        {
            InitializeComponent();
            Mostrar();
        }
        public frmBanco(string CODIGO,string NOMBRE,string DIRECCION,string RNC)
        {
            InitializeComponent();
            tboxcodigo.Text = CODIGO;
            txtNombre.Text = NOMBRE;
            txtDireccion.Text = DIRECCION;
            txtRnc.Text = RNC;
        }

        private void frmBanco_Load(object sender, EventArgs e)
        {
            bool result = true;
            Disable(result);
        }
        private void Mostrar()
        {
            registro.BuscarUltimo();
            txtid.Text = Convert.ToInt16(registro.bc_bancoid).ToString();
            tboxcodigo.Text = registro.bc_bancoCodigo;
            txtRnc.Text = registro.bc_bancoRnc;
            txtNombre.Text = registro.bc_bancoNombre;
            txtDireccion.Text = registro.bc_bancoDireccion;        
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tboxcodigo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtRnc.Clear();
            bool result = false;
            Disable(result);
            txtid.Text = "0";

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (util.ValidacionDocumentos.Validar(txtRnc.Text.ToArray()))
            {
                registro.bc_bancoRnc = txtRnc.Text;
                registro.bc_bancoid = Convert.ToInt16(txtid.Text);
                registro.bc_bancoCodigo = tboxcodigo.Text;
                registro.bc_bancoNombre = txtNombre.Text;
                registro.bc_bancoDireccion = txtDireccion.Text;

                bool lret;
                if (txtid.Text == "0")
                {

                    lret = registro.CrearDatos() > 0;
                }
                else
                {
                    lret = registro.ActualizarDatos();
                    lret = true;
                }
                if (lret)
                {
                    MessageBox.Show(datamanager.MensajeGuardar, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Disable(true);
                }
                else
                    MessageBox.Show(clases.Exepciones.ExepcionGuardar, "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else { MessageBox.Show("No es un Cedula Valida"); }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool result = false;
            Disable(result);
        }
        private void btnVerBanco_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerBancos verBancos = new frmVerBancos();
            verBancos.Show();
        }
        private bool Disable(bool result)
        {
            if (result == true)
            {
                tboxcodigo.Enabled = false;
                txtNombre.Enabled = false;
                txtDireccion.Enabled = false;
                txtRnc.Enabled = false;
                btnGuardar.Enabled = false;
                btnVerBanco.Enabled = true;

            }
            else
            {
                tboxcodigo.Enabled = true;
                txtNombre.Enabled = true;
                txtDireccion.Enabled = true;
                txtRnc.Enabled = true;
                btnGuardar.Enabled = true;
                btnVerBanco.Enabled = true;
            }

            return result;
        }

        private void txtRnc_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloNumero(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloLetra(e);
        }
    }
}

