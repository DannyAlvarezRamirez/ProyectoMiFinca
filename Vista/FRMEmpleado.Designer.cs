﻿namespace AgroganaderaMiFincaGui
{
    partial class FRMEmpleado
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
            this.labelIdentificacion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPrimerApellido = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.labelSegundoApellido = new System.Windows.Forms.Label();
            this.maskedTextBoxIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSalario = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxSegundoApellido = new System.Windows.Forms.TextBox();
            this.textBoxPrimerApellido = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonIrAlMenuPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIdentificacion
            // 
            this.labelIdentificacion.AutoSize = true;
            this.labelIdentificacion.Location = new System.Drawing.Point(12, 9);
            this.labelIdentificacion.Name = "labelIdentificacion";
            this.labelIdentificacion.Size = new System.Drawing.Size(103, 20);
            this.labelIdentificacion.TabIndex = 0;
            this.labelIdentificacion.Text = "Identificacion";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 51);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelPrimerApellido
            // 
            this.labelPrimerApellido.AutoSize = true;
            this.labelPrimerApellido.Location = new System.Drawing.Point(12, 96);
            this.labelPrimerApellido.Name = "labelPrimerApellido";
            this.labelPrimerApellido.Size = new System.Drawing.Size(114, 20);
            this.labelPrimerApellido.TabIndex = 2;
            this.labelPrimerApellido.Text = "Primer Apellido";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(12, 190);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(58, 20);
            this.labelSalario.TabIndex = 3;
            this.labelSalario.Text = "Salario";
            // 
            // labelSegundoApellido
            // 
            this.labelSegundoApellido.AutoSize = true;
            this.labelSegundoApellido.Location = new System.Drawing.Point(12, 144);
            this.labelSegundoApellido.Name = "labelSegundoApellido";
            this.labelSegundoApellido.Size = new System.Drawing.Size(134, 20);
            this.labelSegundoApellido.TabIndex = 4;
            this.labelSegundoApellido.Text = "Segundo Apellido";
            // 
            // maskedTextBoxIdentificacion
            // 
            this.maskedTextBoxIdentificacion.Location = new System.Drawing.Point(122, 2);
            this.maskedTextBoxIdentificacion.Mask = "000000000";
            this.maskedTextBoxIdentificacion.Name = "maskedTextBoxIdentificacion";
            this.maskedTextBoxIdentificacion.Size = new System.Drawing.Size(322, 26);
            this.maskedTextBoxIdentificacion.TabIndex = 5;
            this.maskedTextBoxIdentificacion.ValidatingType = typeof(int);
            // 
            // maskedTextBoxSalario
            // 
            this.maskedTextBoxSalario.Location = new System.Drawing.Point(76, 184);
            this.maskedTextBoxSalario.Mask = "00000000000000";
            this.maskedTextBoxSalario.Name = "maskedTextBoxSalario";
            this.maskedTextBoxSalario.Size = new System.Drawing.Size(368, 26);
            this.maskedTextBoxSalario.TabIndex = 6;
            this.maskedTextBoxSalario.ValidatingType = typeof(int);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(84, 44);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(360, 26);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxSegundoApellido
            // 
            this.textBoxSegundoApellido.Location = new System.Drawing.Point(152, 138);
            this.textBoxSegundoApellido.Name = "textBoxSegundoApellido";
            this.textBoxSegundoApellido.Size = new System.Drawing.Size(292, 26);
            this.textBoxSegundoApellido.TabIndex = 8;
            // 
            // textBoxPrimerApellido
            // 
            this.textBoxPrimerApellido.Location = new System.Drawing.Point(132, 90);
            this.textBoxPrimerApellido.Name = "textBoxPrimerApellido";
            this.textBoxPrimerApellido.Size = new System.Drawing.Size(312, 26);
            this.textBoxPrimerApellido.TabIndex = 9;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(667, 12);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(121, 60);
            this.buttonRegistrar.TabIndex = 10;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonIrAlMenuPrincipal
            // 
            this.buttonIrAlMenuPrincipal.Location = new System.Drawing.Point(635, 377);
            this.buttonIrAlMenuPrincipal.Name = "buttonIrAlMenuPrincipal";
            this.buttonIrAlMenuPrincipal.Size = new System.Drawing.Size(153, 61);
            this.buttonIrAlMenuPrincipal.TabIndex = 11;
            this.buttonIrAlMenuPrincipal.Text = "Ir al Menu Principal";
            this.buttonIrAlMenuPrincipal.UseVisualStyleBackColor = true;
            this.buttonIrAlMenuPrincipal.Click += new System.EventHandler(this.buttonIrAlMenuPrincipal_Click);
            // 
            // FRMEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIrAlMenuPrincipal);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.textBoxPrimerApellido);
            this.Controls.Add(this.textBoxSegundoApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.maskedTextBoxSalario);
            this.Controls.Add(this.maskedTextBoxIdentificacion);
            this.Controls.Add(this.labelSegundoApellido);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelPrimerApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelIdentificacion);
            this.Name = "FRMEmpleado";
            this.Text = "Modulo Registrar Empleado";
            this.Load += new System.EventHandler(this.FRMEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdentificacion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPrimerApellido;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Label labelSegundoApellido;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIdentificacion;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSalario;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxSegundoApellido;
        private System.Windows.Forms.TextBox textBoxPrimerApellido;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonIrAlMenuPrincipal;
    }
}