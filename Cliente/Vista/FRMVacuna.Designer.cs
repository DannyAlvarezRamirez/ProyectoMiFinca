namespace Cliente
{
    partial class FRMVacuna
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
            this.buttonIrAlMenuPrincipal = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxDescripcionVacuna = new System.Windows.Forms.TextBox();
            this.maskedTextBoxIdentificacionVacuna = new System.Windows.Forms.MaskedTextBox();
            this.labelDescripcionVacuna = new System.Windows.Forms.Label();
            this.labelIdentificacionVacuna = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIrAlMenuPrincipal
            // 
            this.buttonIrAlMenuPrincipal.Location = new System.Drawing.Point(636, 383);
            this.buttonIrAlMenuPrincipal.Name = "buttonIrAlMenuPrincipal";
            this.buttonIrAlMenuPrincipal.Size = new System.Drawing.Size(152, 55);
            this.buttonIrAlMenuPrincipal.TabIndex = 20;
            this.buttonIrAlMenuPrincipal.Text = "Ir al Menu Principal";
            this.buttonIrAlMenuPrincipal.UseVisualStyleBackColor = true;
            this.buttonIrAlMenuPrincipal.Click += new System.EventHandler(this.buttonIrAlMenuPrincipal_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(651, 12);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(137, 43);
            this.buttonRegistrar.TabIndex = 19;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textBoxDescripcionVacuna
            // 
            this.textBoxDescripcionVacuna.Location = new System.Drawing.Point(169, 47);
            this.textBoxDescripcionVacuna.Name = "textBoxDescripcionVacuna";
            this.textBoxDescripcionVacuna.Size = new System.Drawing.Size(284, 26);
            this.textBoxDescripcionVacuna.TabIndex = 24;
            // 
            // maskedTextBoxIdentificacionVacuna
            // 
            this.maskedTextBoxIdentificacionVacuna.Location = new System.Drawing.Point(180, 6);
            this.maskedTextBoxIdentificacionVacuna.Mask = "00000000000";
            this.maskedTextBoxIdentificacionVacuna.Name = "maskedTextBoxIdentificacionVacuna";
            this.maskedTextBoxIdentificacionVacuna.Size = new System.Drawing.Size(273, 26);
            this.maskedTextBoxIdentificacionVacuna.TabIndex = 23;
            this.maskedTextBoxIdentificacionVacuna.ValidatingType = typeof(int);
            // 
            // labelDescripcionVacuna
            // 
            this.labelDescripcionVacuna.AutoSize = true;
            this.labelDescripcionVacuna.Location = new System.Drawing.Point(12, 53);
            this.labelDescripcionVacuna.Name = "labelDescripcionVacuna";
            this.labelDescripcionVacuna.Size = new System.Drawing.Size(151, 20);
            this.labelDescripcionVacuna.TabIndex = 22;
            this.labelDescripcionVacuna.Text = "Descripcion Vacuna";
            // 
            // labelIdentificacionVacuna
            // 
            this.labelIdentificacionVacuna.AutoSize = true;
            this.labelIdentificacionVacuna.Location = new System.Drawing.Point(12, 12);
            this.labelIdentificacionVacuna.Name = "labelIdentificacionVacuna";
            this.labelIdentificacionVacuna.Size = new System.Drawing.Size(162, 20);
            this.labelIdentificacionVacuna.TabIndex = 21;
            this.labelIdentificacionVacuna.Text = "Identificacion Vacuna";
            // 
            // FRMVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDescripcionVacuna);
            this.Controls.Add(this.maskedTextBoxIdentificacionVacuna);
            this.Controls.Add(this.labelDescripcionVacuna);
            this.Controls.Add(this.labelIdentificacionVacuna);
            this.Controls.Add(this.buttonIrAlMenuPrincipal);
            this.Controls.Add(this.buttonRegistrar);
            this.Name = "FRMVacuna";
            this.Text = "Modulo Vacuna";
            this.Load += new System.EventHandler(this.FRMVacuna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIrAlMenuPrincipal;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textBoxDescripcionVacuna;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIdentificacionVacuna;
        private System.Windows.Forms.Label labelDescripcionVacuna;
        private System.Windows.Forms.Label labelIdentificacionVacuna;
    }
}