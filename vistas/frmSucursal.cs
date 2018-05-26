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
    public partial class frmSucursal : Form
    {
      private clases.bc_sucursales registro { get; set; } = new clases.bc_sucursales();


        public frmSucursal()
        {   
            InitializeComponent();
            Mostrar();
        }

        public frmSucursal(string ID_SUCURSAL,string ID_BANCO, string CODIGO,
        string NOMBRE, string DIRECCION, string TELEFONO,string CORREO)
        {
            InitializeComponent();
            txtid.Text = ID_SUCURSAL.ToString();
            cbBanco.Text = ID_BANCO.ToString();
            txtcodigo.Text = CODIGO.ToString();
            txtNombre.Text = NOMBRE.ToString();
            txtDireccion.Text = DIRECCION.ToString();
            txtTelefono.Text = TELEFONO.ToString();
            txtCorreo.Text = CORREO.ToString();
        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            registro.SelectComboBox(cbBanco);
            bool result = true;
            Disable(result);
        }
        private void Mostrar()
        {
            registro.BuscarUltimo();
            txtid.Text = Convert.ToInt16(registro.bc_id_Sucursal).ToString();
            cbBanco.Text =registro.bc_id_Banco+" -"+ registro.bc_NombreBanco;

           
            txtcodigo.Text = registro.bc_Codigo;
            txtNombre.Text = registro.bc_Nombre;
            txtDireccion.Text = registro.bc_Direccion;
            txtTelefono.Text = registro.bc_Telefono;
            txtCorreo.Text = registro.bc_Correo;

        }
        private bool Disable(bool result)
        {
            if (result == true)
            {
                cbBanco.Enabled = false;
                txtcodigo.Enabled = false;
                txtNombre.Enabled = false;
                txtDireccion.Enabled = false;
                txtCorreo.Enabled = false;
                txtTelefono.Enabled = false;
                btnGuardar.Enabled = false;
                btnVerSucursal.Enabled = true;

            }
            else
            {
                cbBanco.Enabled = true;
                txtcodigo.Enabled = true;
                txtNombre.Enabled = true;
                txtDireccion.Enabled = true;
                txtCorreo.Enabled = true;
                txtTelefono.Enabled = true;
                btnGuardar.Enabled = true;
                btnVerSucursal.Enabled = true;
            }

            return result;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cbBanco.Text = "";
            txtcodigo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtcodigo.Clear();
            txtTelefono.Clear();
            bool result = false;
            Disable(result);
            txtid.Text = "0";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool result = false;
            Disable(result);
        }

        private void btnVerSucursales_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerSucursales sucursales = new frmVerSucursales();
            sucursales.Show();
                
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //registro.bc_id_Banco = Convert.ToInt16(txtidBanco.Text);
            registro.bc_id_Banco = Convert.ToInt16(cbBanco.Text.Substring(0, 3));
            registro.bc_Codigo = txtcodigo.Text;
            registro.bc_Nombre = txtNombre.Text;
            registro.bc_Direccion = txtDireccion.Text;
            registro.bc_Telefono = txtTelefono.Text;
            registro.bc_Correo = txtCorreo.Text;

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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloNumero(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            datamanager.ValidarSoloLetra(e);
        }
    }
}
