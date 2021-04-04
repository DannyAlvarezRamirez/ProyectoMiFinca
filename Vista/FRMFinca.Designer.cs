namespace ProyectoMiFinca
{
    partial class FRMFinca
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
            this.lblNumeroFinca = new System.Windows.Forms.Label();
            this.lblNombreFinca = new System.Windows.Forms.Label();
            this.lblTamanoFinca = new System.Windows.Forms.Label();
            this.lblDireccionFinca = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnIrAMenuPrincipal = new System.Windows.Forms.Button();
            this.maskedTextBoxNumeroFinca = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNombreFinca = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTamanoFinca = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDireccionFinca = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroFinca
            // 
            this.lblNumeroFinca.AutoSize = true;
            this.lblNumeroFinca.Location = new System.Drawing.Point(12, 51);
            this.lblNumeroFinca.Name = "lblNumeroFinca";
            this.lblNumeroFinca.Size = new System.Drawing.Size(130, 20);
            this.lblNumeroFinca.TabIndex = 0;
            this.lblNumeroFinca.Text = "Número de Finca";
            // 
            // lblNombreFinca
            // 
            this.lblNombreFinca.AutoSize = true;
            this.lblNombreFinca.Location = new System.Drawing.Point(12, 87);
            this.lblNombreFinca.Name = "lblNombreFinca";
            this.lblNombreFinca.Size = new System.Drawing.Size(141, 20);
            this.lblNombreFinca.TabIndex = 1;
            this.lblNombreFinca.Text = "Nombre de la finca";
            // 
            // lblTamanoFinca
            // 
            this.lblTamanoFinca.AutoSize = true;
            this.lblTamanoFinca.Location = new System.Drawing.Point(12, 122);
            this.lblTamanoFinca.Name = "lblTamanoFinca";
            this.lblTamanoFinca.Size = new System.Drawing.Size(308, 20);
            this.lblTamanoFinca.TabIndex = 2;
            this.lblTamanoFinca.Text = "Tamaño de la finca (número de hectáreas)";
            // 
            // lblDireccionFinca
            // 
            this.lblDireccionFinca.AutoSize = true;
            this.lblDireccionFinca.Location = new System.Drawing.Point(12, 156);
            this.lblDireccionFinca.Name = "lblDireccionFinca";
            this.lblDireccionFinca.Size = new System.Drawing.Size(151, 20);
            this.lblDireccionFinca.TabIndex = 3;
            this.lblDireccionFinca.Text = "Dirección de la finca";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 190);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            // 
            // btnIrAMenuPrincipal
            // 
            this.btnIrAMenuPrincipal.Location = new System.Drawing.Point(638, 385);
            this.btnIrAMenuPrincipal.Name = "btnIrAMenuPrincipal";
            this.btnIrAMenuPrincipal.Size = new System.Drawing.Size(150, 53);
            this.btnIrAMenuPrincipal.TabIndex = 5;
            this.btnIrAMenuPrincipal.Text = "Ir a Menu Principal";
            this.btnIrAMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnIrAMenuPrincipal.Click += new System.EventHandler(this.btnIrAMenuPrincipal_Click);
            // 
            // maskedTextBoxNumeroFinca
            // 
            this.maskedTextBoxNumeroFinca.Location = new System.Drawing.Point(149, 44);
            this.maskedTextBoxNumeroFinca.Mask = "00000";
            this.maskedTextBoxNumeroFinca.Name = "maskedTextBoxNumeroFinca";
            this.maskedTextBoxNumeroFinca.Size = new System.Drawing.Size(335, 26);
            this.maskedTextBoxNumeroFinca.TabIndex = 6;
            // 
            // textBoxNombreFinca
            // 
            this.textBoxNombreFinca.Location = new System.Drawing.Point(160, 80);
            this.textBoxNombreFinca.Name = "textBoxNombreFinca";
            this.textBoxNombreFinca.Size = new System.Drawing.Size(324, 26);
            this.textBoxNombreFinca.TabIndex = 7;
            // 
            // maskedTextBoxTamanoFinca
            // 
            this.maskedTextBoxTamanoFinca.Location = new System.Drawing.Point(327, 115);
            this.maskedTextBoxTamanoFinca.Mask = "000000000000";
            this.maskedTextBoxTamanoFinca.Name = "maskedTextBoxTamanoFinca";
            this.maskedTextBoxTamanoFinca.Size = new System.Drawing.Size(157, 26);
            this.maskedTextBoxTamanoFinca.TabIndex = 8;
            // 
            // textBoxDireccionFinca
            // 
            this.textBoxDireccionFinca.Location = new System.Drawing.Point(170, 149);
            this.textBoxDireccionFinca.Name = "textBoxDireccionFinca";
            this.textBoxDireccionFinca.Size = new System.Drawing.Size(314, 26);
            this.textBoxDireccionFinca.TabIndex = 9;
            // 
            // maskedTextBoxTelefono
            // 
            this.maskedTextBoxTelefono.Location = new System.Drawing.Point(90, 190);
            this.maskedTextBoxTelefono.Mask = "00000000000";
            this.maskedTextBoxTelefono.Name = "maskedTextBoxTelefono";
            this.maskedTextBoxTelefono.Size = new System.Drawing.Size(394, 26);
            this.maskedTextBoxTelefono.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(638, 47);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 59);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FRMFinca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.maskedTextBoxTelefono);
            this.Controls.Add(this.textBoxDireccionFinca);
            this.Controls.Add(this.maskedTextBoxTamanoFinca);
            this.Controls.Add(this.textBoxNombreFinca);
            this.Controls.Add(this.maskedTextBoxNumeroFinca);
            this.Controls.Add(this.btnIrAMenuPrincipal);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccionFinca);
            this.Controls.Add(this.lblTamanoFinca);
            this.Controls.Add(this.lblNombreFinca);
            this.Controls.Add(this.lblNumeroFinca);
            this.Name = "FRMFinca";
            this.Text = "Modulo Registrar Finca";
            this.Load += new System.EventHandler(this.FRMFinca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroFinca;
        private System.Windows.Forms.Label lblNombreFinca;
        private System.Windows.Forms.Label lblTamanoFinca;
        private System.Windows.Forms.Label lblDireccionFinca;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnIrAMenuPrincipal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumeroFinca;
        private System.Windows.Forms.TextBox textBoxNombreFinca;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTamanoFinca;
        private System.Windows.Forms.TextBox textBoxDireccionFinca;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefono;
        private System.Windows.Forms.Button btnRegistrar;
    }
}