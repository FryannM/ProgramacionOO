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
    public partial class frmClientes : Form
    {
        private clases.bc_clientes registro { get; set; }

        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            registro = new clases.bc_clientes();
            registro.SelectComboBox(cbtipoDoc);
            registro.BuscarUltimo();
            Mostrar();

            bool result = true;
            Disable(result);
        }
        private void Mostrar()
        {

            TxtidCliente.Text = Convert.ToInt16(registro.bc_Clienteid).ToString();
            cbtipoDoc.Text = registro.bc_TipoDocumento;
            txtnodoc.Text = registro.bc_NumeroDocumento;
            txtnombre.Text = registro.bc_Nombre;
            cbEstado.Text = registro.bc_Estado;

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TxtidCliente.Clear();
            txtnombre.Clear();
            txtnodoc.Clear();
            bool result = false;
            Disable(result);
            TxtidCliente.Text = "0";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool result = false;
            Disable(result);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registro.bc_Clienteid = Convert.ToInt16(TxtidCliente.Text);
            registro.bc_TipoDocumento = cbtipoDoc.Text.Substring(0,3);
            registro.bc_NumeroDocumento = txtnodoc.Text;
            registro.bc_Nombre = txtnombre.Text;
            registro.bc_Estado = cbEstado.Text;

            bool lret;
            if (TxtidCliente.Text == "0")
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
        private bool Disable(bool result)
        {
            if (result == true)
            {
                txtnombre.Enabled = false;
                txtnodoc.Enabled = false;
                cbtipoDoc.Enabled = false;
                cbEstado.Enabled = false;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;

            }
            else
            {
                txtnombre.Enabled = true;
                txtnodoc.Enabled = true;
                cbtipoDoc.Enabled = true;
                cbEstado.Enabled = true;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            return result;
        }

        private void txtnodoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloNumero(e);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloLetra(e);
        }

        private void cbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloLetra(e); datamanager.ValidarSoloNumero(e);
        }
    }
}
