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
            this.bt_VerCuentas = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxCuentas = new System.Windows.Forms.GroupBox();
            this.txt_mskCredito = new System.Windows.Forms.MaskedTextBox();
            this.txt_mskDebito = new System.Windows.Forms.MaskedTextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblbalances = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblbalancecd = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gboxCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_VerCuentas
            // 
            this.bt_VerCuentas.Image = global::ProgramacionOO.Properties.Resources.Search;
            this.bt_VerCuentas.Location = new System.Drawing.Point(429, 205);
            this.bt_VerCuentas.Name = "bt_VerCuentas";
            this.bt_VerCuentas.Size = new System.Drawing.Size(59, 47);
            this.bt_VerCuentas.TabIndex = 47;
            this.bt_VerCuentas.UseVisualStyleBackColor = true;
            this.bt_VerCuentas.Click += new System.EventHandler(this.bt_VerCuentas_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProgramacionOO.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(429, 208);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 44);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::ProgramacionOO.Properties.Resources.save;
            this.btnGuardar.Location = new System.Drawing.Point(429, 157);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 44);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ProgramacionOO.Properties.Resources.edit;
            this.btnEditar.Location = new System.Drawing.Point(429, 106);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(59, 44);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ProgramacionOO.Properties.Resources.agregar;
            this.btnNuevo.Location = new System.Drawing.Point(429, 53);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(59, 46);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "MANTENIMIENTO CUENTAS";
            // 
            // gboxCuentas
            // 
            this.gboxCuentas.Controls.Add(this.txt_mskCredito);
            this.gboxCuentas.Controls.Add(this.txt_mskDebito);
            this.gboxCuentas.Controls.Add(this.cbEstado);
            this.gboxCuentas.Controls.Add(this.lblbalances);
            this.gboxCuentas.Controls.Add(this.lblEstado);
            this.gboxCuentas.Controls.Add(this.lblbalancecd);
            this.gboxCuentas.Controls.Add(this.lblcodigo);
            this.gboxCuentas.Controls.Add(this.txtcodigo);
            this.gboxCuentas.Location = new System.Drawing.Point(16, 55);
            this.gboxCuentas.Name = "gboxCuentas";
            this.gboxCuentas.Size = new System.Drawing.Size(391, 207);
            this.gboxCuentas.TabIndex = 50;
            this.gboxCuentas.TabStop = false;
            this.gboxCuentas.Text = "Cuentas";
            // 
            // txt_mskCredito
            // 
            this.txt_mskCredito.Location = new System.Drawing.Point(148, 150);
            this.txt_mskCredito.Name = "txt_mskCredito";
            this.txt_mskCredito.Size = new System.Drawing.Size(182, 20);
            this.txt_mskCredito.TabIndex = 54;
            this.txt_mskCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mskCredito_KeyPress);
            // 
            // txt_mskDebito
            // 
            this.txt_mskDebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mskDebito.Location = new System.Drawing.Point(148, 109);
            this.txt_mskDebito.Name = "txt_mskDebito";
            this.txt_mskDebito.Size = new System.Drawing.Size(182, 20);
            this.txt_mskDebito.TabIndex = 53;
            this.txt_mskDebito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mskDebito_KeyPress);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cbEstado.Location = new System.Drawing.Point(90, 67);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(166, 21);
            this.cbEstado.TabIndex = 48;
            // 
            // lblbalances
            // 
            this.lblbalances.AutoSize = true;
            this.lblbalances.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalances.Location = new System.Drawing.Point(12, 108);
            this.lblbalances.Name = "lblbalances";
            this.lblbalances.Size = new System.Drawing.Size(128, 20);
            this.lblbalances.TabIndex = 52;
            this.lblbalances.Text = "Balance-debito:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(12, 66);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(65, 20);
            this.lblEstado.TabIndex = 51;
            this.lblEstado.Text = "Estado:";
            // 
            // lblbalancecd
            // 
            this.lblbalancecd.AutoSize = true;
            this.lblbalancecd.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalancecd.Location = new System.Drawing.Point(12, 150);
            this.lblbalancecd.Name = "lblbalancecd";
            this.lblbalancecd.Size = new System.Drawing.Size(133, 20);
            this.lblbalancecd.TabIndex = 50;
            this.lblbalancecd.Text = "Balance-credito:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(9, 24);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(68, 20);
            this.lblcodigo.TabIndex = 49;
            this.lblcodigo.Text = "Código:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(90, 26);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(166, 20);
            this.txtcodigo.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Ver Cuentas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Editar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Guardar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Agregar";
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 277);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_VerCuentas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gboxCuentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.frmCuentas_Load);
            this.gboxCuentas.ResumeLayout(false);
            this.gboxCuentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button bt_VerCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox gboxCuentas;
        public System.Windows.Forms.MaskedTextBox txt_mskCredito;
        public System.Windows.Forms.MaskedTextBox txt_mskDebito;
        public System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblbalances;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblbalancecd;
        private System.Windows.Forms.Label lblcodigo;
        public System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}