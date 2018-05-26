namespace ProgramacionOO.vistas
{
    partial class frmVerSucursales
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
            this.tbox_buscar = new System.Windows.Forms.TextBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.cbox_filtarPor = new System.Windows.Forms.ComboBox();
            this.lbl_filtrarPor = new System.Windows.Forms.Label();
            this.dg_VerSucusales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_VerSucusales)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_buscar
            // 
            this.tbox_buscar.Location = new System.Drawing.Point(523, 18);
            this.tbox_buscar.Name = "tbox_buscar";
            this.tbox_buscar.Size = new System.Drawing.Size(245, 20);
            this.tbox_buscar.TabIndex = 18;
            this.tbox_buscar.TextChanged += new System.EventHandler(this.tbox_buscar_TextChanged);
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(456, 21);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(61, 17);
            this.lbl_Buscar.TabIndex = 17;
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
            this.cbox_filtarPor.Location = new System.Drawing.Point(120, 16);
            this.cbox_filtarPor.Name = "cbox_filtarPor";
            this.cbox_filtarPor.Size = new System.Drawing.Size(144, 21);
            this.cbox_filtarPor.TabIndex = 16;
            // 
            // lbl_filtrarPor
            // 
            this.lbl_filtrarPor.AutoSize = true;
            this.lbl_filtrarPor.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtrarPor.Location = new System.Drawing.Point(33, 18);
            this.lbl_filtrarPor.Name = "lbl_filtrarPor";
            this.lbl_filtrarPor.Size = new System.Drawing.Size(85, 17);
            this.lbl_filtrarPor.TabIndex = 15;
            this.lbl_filtrarPor.Text = "Filtrar por:";
            // 
            // dg_VerSucusales
            // 
            this.dg_VerSucusales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_VerSucusales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_VerSucusales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_VerSucusales.Location = new System.Drawing.Point(36, 45);
            this.dg_VerSucusales.Name = "dg_VerSucusales";
            this.dg_VerSucusales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_VerSucusales.Size = new System.Drawing.Size(732, 390);
            this.dg_VerSucusales.TabIndex = 14;
            this.dg_VerSucusales.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_VerSucusales_CellMouseDoubleClick);
            // 
            // frmVerSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbox_buscar);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.cbox_filtarPor);
            this.Controls.Add(this.lbl_filtrarPor);
            this.Controls.Add(this.dg_VerSucusales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVerSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUCURSALES";
            this.Load += new System.EventHandler(this.frmVerSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_VerSucusales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_buscar;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.ComboBox cbox_filtarPor;
        private System.Windows.Forms.Label lbl_filtrarPor;
        private System.Windows.Forms.DataGridView dg_VerSucusales;
    }
}