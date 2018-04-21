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
            bool result = true;
            Disable(result);
        }
        private void mostrar()
        {
            txtid.Text = Convert.ToInt16(registro.bc_bancoid).ToString();
            txtcodigo.Text = registro.bc_bancoCodigo;
            txtRnc.Text = registro.bc_bancoRnc;
            txtNombre.Text = registro.bc_bancoNombre;
            txtDireccion.Text = registro.bc_bancoDireccion;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtRnc.Clear();
            bool result = false;
            Disable(result);
            txtid.Text = "0";

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registro.bc_bancoid = Convert.ToInt16(txtid.Text);
            registro.bc_bancoCodigo = txtcodigo.Text;
            registro.bc_bancoNombre = txtNombre.Text;
            registro.bc_bancoDireccion = txtDireccion.Text;
            registro.bc_bancoRnc = txtRnc.Text;

            bool lret;
            if (txtid.Text == "0")
            {
                lret = registro.crearDatos() > 0;

            }
            else
            {
                lret = registro.actualizarDatos();
                lret = true;
            }
            if (lret)
            {

                MessageBox.Show(datamanager.MensajeGuardar, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disable(true);
            }
            else
                MessageBox.Show(registro.errormsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool result = false;
            Disable(result);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool lret = false;
            if (MessageBox.Show(datamanager.MensajeEliminar, "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lret = registro.borrarDatos(registro.bc_bancoid);

                if (lret)
                {
                    MessageBox.Show(datamanager.ConfirmacionEliminar, "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrar();
                }
            }
            txtNombre.Focus();
        }
        private bool Disable(bool result)
        {
            if (result == true)
            {
                txtcodigo.Enabled = false;
                txtNombre.Enabled = false;
                txtDireccion.Enabled = false;
                txtRnc.Enabled = false;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;

            }
            else
            {
                txtcodigo.Enabled = true;
                txtNombre.Enabled = true;
                txtDireccion.Enabled = true;
                txtRnc.Enabled = true;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }

            return result;
        }
    }
}

