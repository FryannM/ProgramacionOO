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
            cbEstado.Text = registro.bc_estado;

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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registro.bc_Clienteid = Convert.ToInt16(TxtidCliente.Text);
            registro.bc_TipoDocumento = cbtipoDoc.Text;
            registro.bc_NumeroDocumento = txtnodoc.Text;
            registro.bc_Nombre = txtnombre.Text;
            registro.bc_estado = cbEstado.Text;

            bool lret;
            if (TxtidCliente.Text == "0")
            {
                // registro.ValidarCamposRequeridos();
                lret = registro.CrearDatos() > 0;
            }
            else
            {
                // registro.ValidarCamposRequeridos();
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
                txtcodigo.Enabled = false;
                txtnombre.Enabled = false;
                txtnodoc.Enabled = false;
                cbtipoDoc.Enabled = false;
                cbEstado.Enabled = false;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;

            }
            else
            {
                txtcodigo.Enabled = true;
                txtnombre.Enabled = true;
                txtnodoc.Enabled = true;
                cbtipoDoc.Enabled = true;
                cbEstado.Enabled = true;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            return result;
        }
    }
}
