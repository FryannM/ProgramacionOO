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
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblcuenta = new System.Windows.Forms.Label();
            this.cbtipodocBancario = new System.Windows.Forms.ComboBox();
            this.lblbanco = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtnodoc = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTipobanco = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(147, 165);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(182, 21);
            this.cbEstado.TabIndex = 30;
            // 
            // lblcuenta
            // 
            this.lblcuenta.AutoSize = true;
            this.lblcuenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuenta.Location = new System.Drawing.Point(23, 109);
            this.lblcuenta.Name = "lblcuenta";
            this.lblcuenta.Size = new System.Drawing.Size(72, 19);
            this.lblcuenta.TabIndex = 39;
            this.lblcuenta.Text = "No.cuenta";
            // 
            // cbtipodocBancario
            // 
            this.cbtipodocBancario.FormattingEnabled = true;
            this.cbtipodocBancario.Location = new System.Drawing.Point(147, 56);
            this.cbtipodocBancario.Name = "cbtipodocBancario";
            this.cbtipodocBancario.Size = new System.Drawing.Size(182, 21);
            this.cbtipodocBancario.TabIndex = 27;
            // 
            // lblbanco
            // 
            this.lblbanco.AutoSize = true;
            this.lblbanco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbanco.Location = new System.Drawing.Point(23, 82);
            this.lblbanco.Name = "lblbanco";
            this.lblbanco.Size = new System.Drawing.Size(48, 19);
            this.lblbanco.TabIndex = 34;
            this.lblbanco.Text = "Banco";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(23, 163);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 19);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "Estado";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(147, 111);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(182, 20);
            this.txtCuenta.TabIndex = 29;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(23, 136);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(51, 19);
            this.lblcliente.TabIndex = 32;
            this.lblcliente.Text = "Cliente";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(23, 28);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(54, 19);
            this.lblcodigo.TabIndex = 31;
            this.lblcodigo.Text = "Código";
            // 
            // txtnodoc
            // 
            this.txtnodoc.Location = new System.Drawing.Point(147, 84);
            this.txtnodoc.Name = "txtnodoc";
            this.txtnodoc.Size = new System.Drawing.Size(182, 20);
            this.txtnodoc.TabIndex = 28;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(147, 29);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(57, 20);
            this.txtcodigo.TabIndex = 26;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProgramacionOO.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(351, 165);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 44);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::ProgramacionOO.Properties.Resources.save;
            this.btnGuardar.Location = new System.Drawing.Point(351, 114);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 44);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ProgramacionOO.Properties.Resources.edit;
            this.btnEditar.Location = new System.Drawing.Point(351, 63);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(59, 44);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ProgramacionOO.Properties.Resources.agregar;
            this.btnNuevo.Location = new System.Drawing.Point(351, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(59, 44);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // lblTipobanco
            // 
            this.lblTipobanco.AutoSize = true;
            this.lblTipobanco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipobanco.Location = new System.Drawing.Point(23, 55);
            this.lblTipobanco.Name = "lblTipobanco";
            this.lblTipobanco.Size = new System.Drawing.Size(119, 19);
            this.lblTipobanco.TabIndex = 40;
            this.lblTipobanco.Text = "Tipo doc.bancario";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(147, 138);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(182, 20);
            this.txtCliente.TabIndex = 41;
            // 
            // frmdocbancarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 245);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblTipobanco);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblcuenta);
            this.Controls.Add(this.cbtipodocBancario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblbanco);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtnodoc);
            this.Controls.Add(this.txtcodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdocbancarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos Bancarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblcuenta;
        private System.Windows.Forms.ComboBox cbtipodocBancario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblbanco;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtnodoc;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblTipobanco;
        private System.Windows.Forms.TextBox txtCliente;
    }
}