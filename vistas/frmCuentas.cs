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
    public partial class frmCuentas : Form
    {
        public frmCuentas()
        {
            InitializeComponent();
        }

        clases.bc_cuentas registro { get; set; }

        private void frmCuentas_Load(object sender, EventArgs e)
        {
            registro = new clases.bc_cuentas();

            registro.BuscarUltimo();
            Mostrar();
            bool result = true;

            Disable(result);
        }

        public void Mostrar()
        {

            txtcodigo.Text = registro.CodigoCuenta;
            cbEstado.Text = Convert.ToString(registro.Estado);
            txt_mskDebito.Text = (registro.BalanceDB).ToString();
            txt_mskCredito.Text = (registro.BalanceCR).ToString();
        }

        public bool Disable(bool result)
        {
            if (result == true)
            {
                txtcodigo.Enabled = false;
                cbEstado.Enabled = false;
                txt_mskDebito.Enabled = false;
                txt_mskCredito.Enabled = false;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
               
                cbEstado.Enabled = true;
                txt_mskDebito.Enabled = true;
                txt_mskCredito.Enabled = true;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }

            return result;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txt_mskCredito.Clear();
            txt_mskDebito.Clear();
            txtcodigo.Enabled = true;
            bool result = false;
            Disable(result);
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool result = false;
            Disable(result);
            txtcodigo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registro.CodigoCuenta = txtcodigo.Text;
            registro.Estado = Convert.ToChar(cbEstado.Text);
            registro.BalanceDB = Convert.ToDouble(txt_mskDebito.Text); 
            registro.BalanceCR = Convert.ToDouble(txt_mskCredito.Text);
            
            bool lret=false;
            if (registro.BuscarCodigo(txtcodigo.Text) == false)
            {
                lret = registro.CrearDatos() > 0;
            }
            else
            {

                lret = registro.ActualizarDatos();

            }
            if (lret)
            {

                MessageBox.Show(datamanager.MensajeGuardar, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disable(true);
            }
            else
                MessageBox.Show(clases.Exepciones.ExepcionGuardar, "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool lret = false;

            if (MessageBox.Show(datamanager.MensajeEliminar, "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lret = registro.BorrarDatos(txtcodigo.Text);
               
                if (lret)
                {
                    MessageBox.Show(datamanager.ConfirmacionEliminar, "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                }
            }
            txtcodigo.Focus();
        }

        private void bt_VerCuentas_Click(object sender, EventArgs e)
        {
            frmVerCuentas nuevoVerCuentas = new frmVerCuentas();
            nuevoVerCuentas.Show();

        }

        private void txt_mskDebito_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloNumero(e);
        }

        private void txt_mskCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloNumero(e);
        }
    }
}
