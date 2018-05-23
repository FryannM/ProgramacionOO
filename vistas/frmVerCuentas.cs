﻿using System;
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
    public partial class frmVerCuentas : Form
    {
        clases.bc_cuentas registro = new clases.bc_cuentas();
        

        public frmVerCuentas()
        {
            InitializeComponent();
        }

        private void tbox_buscar_TextChanged(object sender, EventArgs e)
        {
            dg_VerCuentas.DataSource = registro.BuscarCuentas(cbox_filtarPor.Text, tbox_buscar.Text);
        }

        private void bt_Salir_Click(object sender, EventArgs e)
        {
        this.Close();
        }

        

        private void frmVerCuentas_Load(object sender, EventArgs e)
        {
            dg_VerCuentas.DataSource = registro.verTodasCuentas();
            
        }

        private void bt_selecionCuenta_Click(object sender, EventArgs e)
        {
            frmCuentas cuenta = new frmCuentas(dg_VerCuentas.CurrentRow.Cells[1].Value.ToString(),
                                               dg_VerCuentas.CurrentRow.Cells[2].Value.ToString(),
                                               dg_VerCuentas.CurrentRow.Cells[3].Value.ToString(),
                                               dg_VerCuentas.CurrentRow.Cells[4].Value.ToString());
            cuenta.Show();
            this.Close();

        }
    }
}
