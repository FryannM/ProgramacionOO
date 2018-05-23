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
    public partial class frmTitularesCuentas : Form
    {

        private clases.bc_Titulares_Cuentas registro { get; set; }

        public frmTitularesCuentas()
        {
            InitializeComponent();
        }

        private void frmTitularesCuentas_Load(object sender, EventArgs e)
        {
            registro = new clases.bc_Titulares_Cuentas();


            registro.BuscarUltimo();
            Mostrar();

            bool result = true;
            Disable(result);
        }

        private void Mostrar()
        {

            txtTitularCuenta.Text = Convert.ToInt16(registro.bc_Titular_Cuentaid).ToString();
            txtCuenta.Text = registro.bc_codigoCuenta;
            TxtidCliente.Text = registro.bc_nombreCliente;

        }
        private bool Disable(bool result)
        {
            if (result == true)
            {
                txtTitularCuenta.Enabled = false;
                txtCuenta.Enabled = false;
                TxtidCliente.Enabled = false;


            }
            else
            {
                //txtTitularCuenta.Enabled = true;
                txtCuenta.Enabled = true;
                TxtidCliente.Enabled = true;
                btnGuardar.Enabled = true;
                btnVerTitular.Enabled = true;
            }
            return result;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtTitularCuenta.Clear();
            txtCuenta.Clear();
            TxtidCliente.Clear();

            bool result = false;
            Disable(result);
            txtTitularCuenta.Text = "0";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool result = false;
            Disable(result);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registro.bc_Titular_Cuentaid = Convert.ToInt16(txtTitularCuenta.Text);
            registro.bc_Cuenta_id = Convert.ToInt32(txtCuenta.Text);
            registro.bc_Cliente_id = Convert.ToInt32(TxtidCliente.Text);


            bool lret;
            if (registro.BuscarCodigo(registro.bc_Titular_Cuentaid.ToString()) == false)
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

        private void btnVerTitular_Click(object sender, EventArgs e)
        {

        }

        private void TxtidCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloLetra(e);
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloNumero(e);
        }
    }
    }

