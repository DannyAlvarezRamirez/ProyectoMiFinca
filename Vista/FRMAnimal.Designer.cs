namespace AgroganaderaMiFincaGui
{
    partial class FRMAnimal
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
            this.labelRaza = new System.Windows.Forms.Label();
            this.labelFinca = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelMadre = new System.Windows.Forms.Label();
            this.labelPadre = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.maskedTextBoxIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxPadre = new System.Windows.Forms.TextBox();
            this.textBoxMadre = new System.Windows.Forms.TextBox();
            this.textBoxFechaNacimiento = new System.Windows.Forms.TextBox();
            this.comboBoxFincas = new System.Windows.Forms.ComboBox();
            this.comboBoxRazas = new System.Windows.Forms.ComboBox();
            this.comboBoxSexos = new System.Windows.Forms.ComboBox();
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
            this.labelNombre.Location = new System.Drawing.Point(12, 57);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelRaza
            // 
            this.labelRaza.AutoSize = true;
            this.labelRaza.Location = new System.Drawing.Point(12, 161);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.Size = new System.Drawing.Size(47, 20);
            this.labelRaza.TabIndex = 2;
            this.labelRaza.Text = "Raza";
            // 
            // labelFinca
            // 
            this.labelFinca.AutoSize = true;
            this.labelFinca.Location = new System.Drawing.Point(12, 109);
            this.labelFinca.Name = "labelFinca";
            this.labelFinca.Size = new System.Drawing.Size(48, 20);
            this.labelFinca.TabIndex = 3;
            this.labelFinca.Text = "Finca";
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(12, 218);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(137, 20);
            this.labelFechaNacimiento.TabIndex = 4;
            this.labelFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // labelMadre
            // 
            this.labelMadre.AutoSize = true;
            this.labelMadre.Location = new System.Drawing.Point(12, 319);
            this.labelMadre.Name = "labelMadre";
            this.labelMadre.Size = new System.Drawing.Size(54, 20);
            this.labelMadre.TabIndex = 5;
            this.labelMadre.Text = "Madre";
            // 
            // labelPadre
            // 
            this.labelPadre.AutoSize = true;
            this.labelPadre.Location = new System.Drawing.Point(12, 369);
            this.labelPadre.Name = "labelPadre";
            this.labelPadre.Size = new System.Drawing.Size(51, 20);
            this.labelPadre.TabIndex = 6;
            this.labelPadre.Text = "Padre";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(12, 270);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(45, 20);
            this.labelSexo.TabIndex = 7;
            this.labelSexo.Text = "Sexo";
            // 
            // maskedTextBoxIdentificacion
            // 
            this.maskedTextBoxIdentificacion.Location = new System.Drawing.Point(122, 2);
            this.maskedTextBoxIdentificacion.Mask = "0000000000";
            this.maskedTextBoxIdentificacion.Name = "maskedTextBoxIdentificacion";
            this.maskedTextBoxIdentificacion.Size = new System.Drawing.Size(306, 26);
            this.maskedTextBoxIdentificacion.TabIndex = 8;
            this.maskedTextBoxIdentificacion.ValidatingType = typeof(int);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(83, 57);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(345, 26);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxPadre
            // 
            this.textBoxPadre.Location = new System.Drawing.Point(69, 366);
            this.textBoxPadre.Name = "textBoxPadre";
            this.textBoxPadre.Size = new System.Drawing.Size(359, 26);
            this.textBoxPadre.TabIndex = 11;
            // 
            // textBoxMadre
            // 
            this.textBoxMadre.Location = new System.Drawing.Point(72, 313);
            this.textBoxMadre.Name = "textBoxMadre";
            this.textBoxMadre.Size = new System.Drawing.Size(356, 26);
            this.textBoxMadre.TabIndex = 12;
            // 
            // textBoxFechaNacimiento
            // 
            this.textBoxFechaNacimiento.Location = new System.Drawing.Point(155, 212);
            this.textBoxFechaNacimiento.Name = "textBoxFechaNacimiento";
            this.textBoxFechaNacimiento.Size = new System.Drawing.Size(273, 26);
            this.textBoxFechaNacimiento.TabIndex = 13;
            // 
            // comboBoxFincas
            // 
            this.comboBoxFincas.AllowDrop = true;
            this.comboBoxFincas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFincas.FormattingEnabled = true;
            this.comboBoxFincas.Location = new System.Drawing.Point(66, 101);
            this.comboBoxFincas.Name = "comboBoxFincas";
            this.comboBoxFincas.Size = new System.Drawing.Size(362, 28);
            this.comboBoxFincas.TabIndex = 14;
            // 
            // comboBoxRazas
            // 
            this.comboBoxRazas.AllowDrop = true;
            this.comboBoxRazas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRazas.FormattingEnabled = true;
            this.comboBoxRazas.Location = new System.Drawing.Point(65, 158);
            this.comboBoxRazas.Name = "comboBoxRazas";
            this.comboBoxRazas.Size = new System.Drawing.Size(363, 28);
            this.comboBoxRazas.TabIndex = 15;
            // 
            // comboBoxSexos
            // 
            this.comboBoxSexos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexos.FormattingEnabled = true;
            this.comboBoxSexos.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.comboBoxSexos.Location = new System.Drawing.Point(63, 262);
            this.comboBoxSexos.Name = "comboBoxSexos";
            this.comboBoxSexos.Size = new System.Drawing.Size(365, 28);
            this.comboBoxSexos.TabIndex = 16;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(651, 12);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(137, 43);
            this.buttonRegistrar.TabIndex = 17;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonIrAlMenuPrincipal
            // 
            this.buttonIrAlMenuPrincipal.Location = new System.Drawing.Point(636, 383);
            this.buttonIrAlMenuPrincipal.Name = "buttonIrAlMenuPrincipal";
            this.buttonIrAlMenuPrincipal.Size = new System.Drawing.Size(152, 55);
            this.buttonIrAlMenuPrincipal.TabIndex = 18;
            this.buttonIrAlMenuPrincipal.Text = "Ir al Menu Principal";
            this.buttonIrAlMenuPrincipal.UseVisualStyleBackColor = true;
            this.buttonIrAlMenuPrincipal.Click += new System.EventHandler(this.buttonIrAlMenuPrincipal_Click);
            // 
            // FRMAnimal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIrAlMenuPrincipal);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.comboBoxSexos);
            this.Controls.Add(this.comboBoxRazas);
            this.Controls.Add(this.comboBoxFincas);
            this.Controls.Add(this.textBoxFechaNacimiento);
            this.Controls.Add(this.textBoxMadre);
            this.Controls.Add(this.textBoxPadre);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.maskedTextBoxIdentificacion);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelPadre);
            this.Controls.Add(this.labelMadre);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.labelFinca);
            this.Controls.Add(this.labelRaza);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelIdentificacion);
            this.Name = "FRMAnimal";
            this.Text = "Modulo Registro Animal";
            this.Load += new System.EventHandler(this.FRMAnimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdentificacion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelRaza;
        private System.Windows.Forms.Label labelFinca;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelMadre;
        private System.Windows.Forms.Label labelPadre;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIdentificacion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxPadre;
        private System.Windows.Forms.TextBox textBoxMadre;
        private System.Windows.Forms.TextBox textBoxFechaNacimiento;
        private System.Windows.Forms.ComboBox comboBoxFincas;
        private System.Windows.Forms.ComboBox comboBoxRazas;
        private System.Windows.Forms.ComboBox comboBoxSexos;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonIrAlMenuPrincipal;
    }
}