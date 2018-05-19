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

    public partial class frmTipoDocBancarios : Form
    {
        clases.bc_tipo_doc_bancarios regTipoDoc;

        public frmTipoDocBancarios()
        {
            InitializeComponent();
        }

        public void Mostrar()
        {
            tboxCodigo.Text = regTipoDoc.codigoTipoDoc;
            tboxNombre.Text = regTipoDoc.nombre;
            cbOrigen.Text = Convert.ToString(regTipoDoc.origen);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tboxCodigo.Clear();
            tboxNombre.Clear();
            bool result = false;
            Disable(result);
            tboxCodigo.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool result = false;
            Disable(result);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            regTipoDoc.codigoTipoDoc = tboxCodigo.Text;
            regTipoDoc.origen = Convert.ToChar(cbOrigen.Text);
            regTipoDoc.nombre = tboxNombre.Text;

            bool lret = false;

            if (regTipoDoc.BuscarCodigo(tboxCodigo.Text) != true)
            {

                lret = regTipoDoc.CrearDatos() > 0;
            }
            else
            {

                lret = regTipoDoc.ActualizarDatos();

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

            bool lret;

            if (MessageBox.Show(datamanager.MensajeEliminar, "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lret = regTipoDoc.BorrarDatos(tboxCodigo.Text);

                if (lret)
                {
                    MessageBox.Show(datamanager.ConfirmacionEliminar, "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                }

            }
            tboxCodigo.Focus();
        }


        private void frmTipoDocBancarios_Load(object sender, EventArgs e)
        {
            regTipoDoc = new clases.bc_tipo_doc_bancarios();

            regTipoDoc.BuscarUltimo();
            Mostrar();
            bool result = true;

            Disable(result);
        }

        private bool Disable(bool result)
        {
            if (result == true)
            {
                tboxCodigo.Enabled = false;
                cbOrigen.Enabled = false;
                tboxNombre.Enabled = false;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                cbOrigen.Enabled = true;
                tboxNombre.Enabled = true;
                btnEditar.Enabled = false;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            return result;
        }


    }
}
