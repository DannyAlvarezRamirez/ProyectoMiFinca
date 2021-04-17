namespace Cliente
{
    partial class FRMLogin
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.buttonIrAlMenuPrincipal = new System.Windows.Forms.Button();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.labelIngresarYNoIngresar = new System.Windows.Forms.Label();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(12, 44);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(64, 20);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Location = new System.Drawing.Point(12, 90);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(92, 20);
            this.labelContrasena.TabIndex = 1;
            this.labelContrasena.Text = "Contrasena";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(82, 38);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(179, 26);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Location = new System.Drawing.Point(110, 84);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(151, 26);
            this.textBoxContrasena.TabIndex = 3;
            // 
            // buttonIrAlMenuPrincipal
            // 
            this.buttonIrAlMenuPrincipal.Location = new System.Drawing.Point(335, 281);
            this.buttonIrAlMenuPrincipal.Name = "buttonIrAlMenuPrincipal";
            this.buttonIrAlMenuPrincipal.Size = new System.Drawing.Size(152, 55);
            this.buttonIrAlMenuPrincipal.TabIndex = 22;
            this.buttonIrAlMenuPrincipal.Text = "Ir al Menu Principal";
            this.buttonIrAlMenuPrincipal.UseVisualStyleBackColor = true;
            this.buttonIrAlMenuPrincipal.Click += new System.EventHandler(this.buttonIrAlMenuPrincipal_Click);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(350, 21);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(137, 43);
            this.buttonIngresar.TabIndex = 21;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // labelIngresarYNoIngresar
            // 
            this.labelIngresarYNoIngresar.AutoSize = true;
            this.labelIngresarYNoIngresar.Location = new System.Drawing.Point(12, 9);
            this.labelIngresarYNoIngresar.Name = "labelIngresarYNoIngresar";
            this.labelIngresarYNoIngresar.Size = new System.Drawing.Size(93, 20);
            this.labelIngresarYNoIngresar.TabIndex = 23;
            this.labelIngresarYNoIngresar.Text = "Sin ingresar";
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.Location = new System.Drawing.Point(40, 281);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(155, 55);
            this.buttonRegistrarse.TabIndex = 24;
            this.buttonRegistrarse.Text = "Registrarme";
            this.buttonRegistrarse.UseVisualStyleBackColor = true;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // FRMLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 348);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.labelIngresarYNoIngresar);
            this.Controls.Add(this.buttonIrAlMenuPrincipal);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelContrasena);
            this.Controls.Add(this.labelUsuario);
            this.Name = "FRMLogin";
            this.Text = "Modulo Ingresar al Sistema Cliente";
            this.Load += new System.EventHandler(this.FRMLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Button buttonIrAlMenuPrincipal;
        private System.Windows.Forms.Button buttonIngresar;
        public System.Windows.Forms.Label labelIngresarYNoIngresar;
        private System.Windows.Forms.Button buttonRegistrarse;
    }
}