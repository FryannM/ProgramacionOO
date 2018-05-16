namespace ProgramacionOO.vistas
{
    partial class frmCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuentas));
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblbalances = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblbalancecd = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txt_mskDebito = new System.Windows.Forms.MaskedTextBox();
            this.txt_mskCredito = new System.Windows.Forms.MaskedTextBox();
            this.bt_VerCuentas = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cbEstado.Location = new System.Drawing.Point(129, 71);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(182, 21);
            this.cbEstado.TabIndex = 30;
            // 
            // lblbalances
            // 
            this.lblbalances.AutoSize = true;
            this.lblbalances.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalances.Location = new System.Drawing.Point(21, 96);
            this.lblbalances.Name = "lblbalances";
            this.lblbalances.Size = new System.Drawing.Size(101, 19);
            this.lblbalances.TabIndex = 39;
            this.lblbalances.Text = "Balance-debito";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(21, 71);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 19);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "Estado";
            // 
            // lblbalancecd
            // 
            this.lblbalancecd.AutoSize = true;
            this.lblbalancecd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalancecd.Location = new System.Drawing.Point(21, 121);
            this.lblbalancecd.Name = "lblbalancecd";
            this.lblbalancecd.Size = new System.Drawing.Size(105, 19);
            this.lblbalancecd.TabIndex = 32;
            this.lblbalancecd.Text = "Balance-credito";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(21, 46);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(54, 19);
            this.lblcodigo.TabIndex = 31;
            this.lblcodigo.Text = "Código";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(129, 46);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(57, 20);
            this.txtcodigo.TabIndex = 26;
            // 
            // txt_mskDebito
            // 
            this.txt_mskDebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mskDebito.Location = new System.Drawing.Point(129, 97);
            this.txt_mskDebito.Name = "txt_mskDebito";
            this.txt_mskDebito.Size = new System.Drawing.Size(182, 20);
            this.txt_mskDebito.TabIndex = 45;
            // 
            // txt_mskCredito
            // 
            this.txt_mskCredito.Location = new System.Drawing.Point(129, 122);
            this.txt_mskCredito.Name = "txt_mskCredito";
            this.txt_mskCredito.Size = new System.Drawing.Size(182, 20);
            this.txt_mskCredito.TabIndex = 46;
            // 
            // bt_VerCuentas
            // 
            this.bt_VerCuentas.Location = new System.Drawing.Point(21, 219);
            this.bt_VerCuentas.Name = "bt_VerCuentas";
            this.bt_VerCuentas.Size = new System.Drawing.Size(108, 54);
            this.bt_VerCuentas.TabIndex = 47;
            this.bt_VerCuentas.Text = "Ver Cuentas";
            this.bt_VerCuentas.UseVisualStyleBackColor = true;
            this.bt_VerCuentas.Click += new System.EventHandler(this.bt_VerCuentas_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProgramacionOO.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(361, 177);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 44);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::ProgramacionOO.Properties.Resources.save;
            this.btnGuardar.Location = new System.Drawing.Point(361, 125);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 44);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ProgramacionOO.Properties.Resources.edit;
            this.btnEditar.Location = new System.Drawing.Point(361, 73);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(59, 44);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ProgramacionOO.Properties.Resources.agregar;
            this.btnNuevo.Location = new System.Drawing.Point(361, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(59, 44);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 281);
            this.Controls.Add(this.bt_VerCuentas);
            this.Controls.Add(this.txt_mskCredito);
            this.Controls.Add(this.txt_mskDebito);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblbalances);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblbalancecd);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtcodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.frmCuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblbalances;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblbalancecd;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.MaskedTextBox txt_mskDebito;
        private System.Windows.Forms.MaskedTextBox txt_mskCredito;
        private System.Windows.Forms.Button bt_VerCuentas;
    }
}