﻿namespace ProgramacionOO.vistas
{
    partial class frmVerTitulares
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_selecionCuenta = new System.Windows.Forms.Button();
            this.bt_Salir = new System.Windows.Forms.Button();
            this.tbox_buscar = new System.Windows.Forms.TextBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.cbox_filtarPor = new System.Windows.Forms.ComboBox();
            this.lbl_filtrarPor = new System.Windows.Forms.Label();
            this.dg_VerCuentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_VerCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_selecionCuenta
            // 
            this.bt_selecionCuenta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_selecionCuenta.Location = new System.Drawing.Point(603, 101);
            this.bt_selecionCuenta.Name = "bt_selecionCuenta";
            this.bt_selecionCuenta.Size = new System.Drawing.Size(165, 68);
            this.bt_selecionCuenta.TabIndex = 15;
            this.bt_selecionCuenta.Text = "Seleccionar Cuenta";
            this.bt_selecionCuenta.UseVisualStyleBackColor = true;
            // 
            // bt_Salir
            // 
            this.bt_Salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_Salir.Location = new System.Drawing.Point(603, 252);
            this.bt_Salir.Name = "bt_Salir";
            this.bt_Salir.Size = new System.Drawing.Size(165, 58);
            this.bt_Salir.TabIndex = 14;
            this.bt_Salir.Text = "Salir";
            this.bt_Salir.UseVisualStyleBackColor = true;
            // 
            // tbox_buscar
            // 
            this.tbox_buscar.Location = new System.Drawing.Point(333, 17);
            this.tbox_buscar.Name = "tbox_buscar";
            this.tbox_buscar.Size = new System.Drawing.Size(245, 20);
            this.tbox_buscar.TabIndex = 13;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(266, 18);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(61, 17);
            this.lbl_Buscar.TabIndex = 12;
            this.lbl_Buscar.Text = "Buscar:";
            // 
            // cbox_filtarPor
            // 
            this.cbox_filtarPor.FormattingEnabled = true;
            this.cbox_filtarPor.Items.AddRange(new object[] {
            "Codigo",
            "Estado",
            "Balance_DB",
            "Balance_CR"});
            this.cbox_filtarPor.Location = new System.Drawing.Point(111, 16);
            this.cbox_filtarPor.Name = "cbox_filtarPor";
            this.cbox_filtarPor.Size = new System.Drawing.Size(144, 21);
            this.cbox_filtarPor.TabIndex = 11;
            // 
            // lbl_filtrarPor
            // 
            this.lbl_filtrarPor.AutoSize = true;
            this.lbl_filtrarPor.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtrarPor.Location = new System.Drawing.Point(24, 18);
            this.lbl_filtrarPor.Name = "lbl_filtrarPor";
            this.lbl_filtrarPor.Size = new System.Drawing.Size(85, 17);
            this.lbl_filtrarPor.TabIndex = 10;
            this.lbl_filtrarPor.Text = "Filtrar por:";
            // 
            // dg_VerCuentas
            // 
            this.dg_VerCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_VerCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_VerCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_VerCuentas.Location = new System.Drawing.Point(27, 45);
            this.dg_VerCuentas.Name = "dg_VerCuentas";
            this.dg_VerCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_VerCuentas.Size = new System.Drawing.Size(551, 390);
            this.dg_VerCuentas.TabIndex = 9;
            // 
            // frmVerTitulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.bt_selecionCuenta);
            this.Controls.Add(this.bt_Salir);
            this.Controls.Add(this.tbox_buscar);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.cbox_filtarPor);
            this.Controls.Add(this.lbl_filtrarPor);
            this.Controls.Add(this.dg_VerCuentas);
            this.Name = "frmVerTitulares";
            this.Text = "frmVerTitulares";
            ((System.ComponentModel.ISupportInitialize)(this.dg_VerCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_selecionCuenta;
        private System.Windows.Forms.Button bt_Salir;
        private System.Windows.Forms.TextBox tbox_buscar;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.ComboBox cbox_filtarPor;
        private System.Windows.Forms.Label lbl_filtrarPor;
        private System.Windows.Forms.DataGridView dg_VerCuentas;
    }
}