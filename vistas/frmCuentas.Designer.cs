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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtcredito = new System.Windows.Forms.TextBox();
            this.lblbalancecd = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtdebito = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(114, 71);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(182, 21);
            this.cbEstado.TabIndex = 30;
            // 
            // lblbalances
            // 
            this.lblbalances.AutoSize = true;
            this.lblbalances.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalances.Location = new System.Drawing.Point(25, 103);
            this.lblbalances.Name = "lblbalances";
            this.lblbalances.Size = new System.Drawing.Size(87, 15);
            this.lblbalances.TabIndex = 39;
            this.lblbalances.Text = "Balance-debito";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProgramacionOO.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(305, 112);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(49, 29);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::ProgramacionOO.Properties.Resources.save;
            this.btnGuardar.Location = new System.Drawing.Point(305, 77);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(49, 29);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ProgramacionOO.Properties.Resources.edit;
            this.btnEditar.Location = new System.Drawing.Point(305, 47);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(49, 29);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ProgramacionOO.Properties.Resources.agregar;
            this.btnNuevo.Location = new System.Drawing.Point(305, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(49, 29);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(27, 73);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(44, 15);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "Estado";
            // 
            // txtcredito
            // 
            this.txtcredito.Location = new System.Drawing.Point(114, 124);
            this.txtcredito.Name = "txtcredito";
            this.txtcredito.Size = new System.Drawing.Size(182, 20);
            this.txtcredito.TabIndex = 29;
            // 
            // lblbalancecd
            // 
            this.lblbalancecd.AutoSize = true;
            this.lblbalancecd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalancecd.Location = new System.Drawing.Point(25, 124);
            this.lblbalancecd.Name = "lblbalancecd";
            this.lblbalancecd.Size = new System.Drawing.Size(90, 15);
            this.lblbalancecd.TabIndex = 32;
            this.lblbalancecd.Text = "Balance-credito";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(27, 46);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(46, 15);
            this.lblcodigo.TabIndex = 31;
            this.lblcodigo.Text = "Código";
            // 
            // txtdebito
            // 
            this.txtdebito.Location = new System.Drawing.Point(114, 98);
            this.txtdebito.Name = "txtdebito";
            this.txtdebito.Size = new System.Drawing.Size(182, 20);
            this.txtdebito.TabIndex = 28;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(114, 47);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(57, 20);
            this.txtcodigo.TabIndex = 26;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 173);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(398, 141);
            this.listView1.TabIndex = 44;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 339);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblbalances);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtcredito);
            this.Controls.Add(this.lblbalancecd);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtdebito);
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
        private System.Windows.Forms.TextBox txtcredito;
        private System.Windows.Forms.Label lblbalancecd;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtdebito;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.ListView listView1;
    }
}