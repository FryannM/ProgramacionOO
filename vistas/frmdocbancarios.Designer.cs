namespace ProgramacionOO.vistas
{
    partial class frmdocbancarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdocbancarios));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxCuentas = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblTipobanco = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblcuenta = new System.Windows.Forms.Label();
            this.cbtipodocBancario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblbanco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtnodoc = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gboxCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProgramacionOO.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(407, 243);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 44);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::ProgramacionOO.Properties.Resources.save;
            this.btnGuardar.Location = new System.Drawing.Point(407, 181);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 44);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ProgramacionOO.Properties.Resources.edit;
            this.btnEditar.Location = new System.Drawing.Point(407, 119);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(59, 44);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ProgramacionOO.Properties.Resources.agregar;
            this.btnNuevo.Location = new System.Drawing.Point(407, 57);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(59, 44);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "DOC. BANCARIOS";
            // 
            // gboxCuentas
            // 
            this.gboxCuentas.BackColor = System.Drawing.SystemColors.Menu;
            this.gboxCuentas.Controls.Add(this.label7);
            this.gboxCuentas.Controls.Add(this.txtCliente);
            this.gboxCuentas.Controls.Add(this.lblTipobanco);
            this.gboxCuentas.Controls.Add(this.label6);
            this.gboxCuentas.Controls.Add(this.lblcuenta);
            this.gboxCuentas.Controls.Add(this.cbtipodocBancario);
            this.gboxCuentas.Controls.Add(this.label5);
            this.gboxCuentas.Controls.Add(this.lblbanco);
            this.gboxCuentas.Controls.Add(this.label3);
            this.gboxCuentas.Controls.Add(this.txtCuenta);
            this.gboxCuentas.Controls.Add(this.label1);
            this.gboxCuentas.Controls.Add(this.lblcliente);
            this.gboxCuentas.Controls.Add(this.lblcodigo);
            this.gboxCuentas.Controls.Add(this.txtnodoc);
            this.gboxCuentas.Controls.Add(this.txtcodigo);
            this.gboxCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxCuentas.Location = new System.Drawing.Point(12, 51);
            this.gboxCuentas.Name = "gboxCuentas";
            this.gboxCuentas.Size = new System.Drawing.Size(389, 258);
            this.gboxCuentas.TabIndex = 51;
            this.gboxCuentas.TabStop = false;
            this.gboxCuentas.Text = "Cuentas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Tipo doc.bancario:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(118, 179);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(235, 20);
            this.txtCliente.TabIndex = 64;
            // 
            // lblTipobanco
            // 
            this.lblTipobanco.AutoSize = true;
            this.lblTipobanco.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipobanco.Location = new System.Drawing.Point(16, 65);
            this.lblTipobanco.Name = "lblTipobanco";
            this.lblTipobanco.Size = new System.Drawing.Size(152, 20);
            this.lblTipobanco.TabIndex = 62;
            this.lblTipobanco.Text = "Tipo doc.bancario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "No.cuenta:";
            // 
            // lblcuenta
            // 
            this.lblcuenta.AutoSize = true;
            this.lblcuenta.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuenta.Location = new System.Drawing.Point(16, 137);
            this.lblcuenta.Name = "lblcuenta";
            this.lblcuenta.Size = new System.Drawing.Size(89, 20);
            this.lblcuenta.TabIndex = 60;
            this.lblcuenta.Text = "No.cuenta:";
            // 
            // cbtipodocBancario
            // 
            this.cbtipodocBancario.FormattingEnabled = true;
            this.cbtipodocBancario.Location = new System.Drawing.Point(171, 67);
            this.cbtipodocBancario.Name = "cbtipodocBancario";
            this.cbtipodocBancario.Size = new System.Drawing.Size(182, 21);
            this.cbtipodocBancario.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Banco:";
            // 
            // lblbanco
            // 
            this.lblbanco.AutoSize = true;
            this.lblbanco.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbanco.Location = new System.Drawing.Point(16, 105);
            this.lblbanco.Name = "lblbanco";
            this.lblbanco.Size = new System.Drawing.Size(59, 20);
            this.lblbanco.TabIndex = 58;
            this.lblbanco.Text = "Banco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Cliente:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(118, 142);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(235, 20);
            this.txtCuenta.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Código:";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(16, 180);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(66, 20);
            this.lblcliente.TabIndex = 54;
            this.lblcliente.Text = "Cliente:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(16, 28);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(68, 20);
            this.lblcodigo.TabIndex = 52;
            this.lblcodigo.Text = "Código:";
            // 
            // txtnodoc
            // 
            this.txtnodoc.Location = new System.Drawing.Point(118, 105);
            this.txtnodoc.Name = "txtnodoc";
            this.txtnodoc.Size = new System.Drawing.Size(235, 20);
            this.txtnodoc.TabIndex = 47;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(104, 30);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(124, 20);
            this.txtcodigo.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(472, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "Eliminar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(472, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Editar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(472, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Guardar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(472, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 55;
            this.label11.Text = "Agregar";
            // 
            // frmdocbancarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 321);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gboxCuentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdocbancarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos Bancarios";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxCuentas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblTipobanco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblcuenta;
        private System.Windows.Forms.ComboBox cbtipodocBancario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblbanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtnodoc;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}