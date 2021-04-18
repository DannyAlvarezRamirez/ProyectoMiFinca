namespace Cliente
{
    partial class FRMTratamientoAnimal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDiagnostico = new System.Windows.Forms.TextBox();
            this.textBoxObservaciones = new System.Windows.Forms.TextBox();
            this.maskedTextBoxIdentificacionAnimal = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDiasTratamiento = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFecha = new System.Windows.Forms.MaskedTextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonIrAlMenuPrincipal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMedicamentos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion Animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dias Tratamiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diagnostico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observaciones";
            // 
            // textBoxDiagnostico
            // 
            this.textBoxDiagnostico.Location = new System.Drawing.Point(115, 79);
            this.textBoxDiagnostico.Name = "textBoxDiagnostico";
            this.textBoxDiagnostico.Size = new System.Drawing.Size(296, 26);
            this.textBoxDiagnostico.TabIndex = 5;
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Location = new System.Drawing.Point(132, 193);
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(279, 87);
            this.textBoxObservaciones.TabIndex = 6;
            // 
            // maskedTextBoxIdentificacionAnimal
            // 
            this.maskedTextBoxIdentificacionAnimal.Location = new System.Drawing.Point(173, 9);
            this.maskedTextBoxIdentificacionAnimal.Mask = "00000000000";
            this.maskedTextBoxIdentificacionAnimal.Name = "maskedTextBoxIdentificacionAnimal";
            this.maskedTextBoxIdentificacionAnimal.Size = new System.Drawing.Size(238, 26);
            this.maskedTextBoxIdentificacionAnimal.TabIndex = 7;
            this.maskedTextBoxIdentificacionAnimal.ValidatingType = typeof(int);
            // 
            // maskedTextBoxDiasTratamiento
            // 
            this.maskedTextBoxDiasTratamiento.Location = new System.Drawing.Point(147, 150);
            this.maskedTextBoxDiasTratamiento.Mask = "00000000000";
            this.maskedTextBoxDiasTratamiento.Name = "maskedTextBoxDiasTratamiento";
            this.maskedTextBoxDiasTratamiento.Size = new System.Drawing.Size(264, 26);
            this.maskedTextBoxDiasTratamiento.TabIndex = 8;
            this.maskedTextBoxDiasTratamiento.ValidatingType = typeof(int);
            // 
            // maskedTextBoxFecha
            // 
            this.maskedTextBoxFecha.Location = new System.Drawing.Point(72, 41);
            this.maskedTextBoxFecha.Mask = "0000-00-00";
            this.maskedTextBoxFecha.Name = "maskedTextBoxFecha";
            this.maskedTextBoxFecha.Size = new System.Drawing.Size(339, 26);
            this.maskedTextBoxFecha.TabIndex = 9;
            this.maskedTextBoxFecha.ValidatingType = typeof(System.DateTime);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(648, 9);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(140, 50);
            this.buttonRegistrar.TabIndex = 18;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonIrAlMenuPrincipal
            // 
            this.buttonIrAlMenuPrincipal.Location = new System.Drawing.Point(634, 375);
            this.buttonIrAlMenuPrincipal.Name = "buttonIrAlMenuPrincipal";
            this.buttonIrAlMenuPrincipal.Size = new System.Drawing.Size(154, 59);
            this.buttonIrAlMenuPrincipal.TabIndex = 17;
            this.buttonIrAlMenuPrincipal.Text = "Ir al Menu Principal";
            this.buttonIrAlMenuPrincipal.UseVisualStyleBackColor = true;
            this.buttonIrAlMenuPrincipal.Click += new System.EventHandler(this.buttonIrAlMenuPrincipal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Medicamentos";
            // 
            // textBoxMedicamentos
            // 
            this.textBoxMedicamentos.Location = new System.Drawing.Point(131, 115);
            this.textBoxMedicamentos.Name = "textBoxMedicamentos";
            this.textBoxMedicamentos.Size = new System.Drawing.Size(280, 26);
            this.textBoxMedicamentos.TabIndex = 20;
            // 
            // FRMTratamientoAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMedicamentos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.buttonIrAlMenuPrincipal);
            this.Controls.Add(this.maskedTextBoxFecha);
            this.Controls.Add(this.maskedTextBoxDiasTratamiento);
            this.Controls.Add(this.maskedTextBoxIdentificacionAnimal);
            this.Controls.Add(this.textBoxObservaciones);
            this.Controls.Add(this.textBoxDiagnostico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMTratamientoAnimal";
            this.Text = "Modulo Tratamiento Animal";
            this.Load += new System.EventHandler(this.FRMVacunaAnimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDiagnostico;
        private System.Windows.Forms.TextBox textBoxObservaciones;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIdentificacionAnimal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDiasTratamiento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFecha;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonIrAlMenuPrincipal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMedicamentos;
    }
}