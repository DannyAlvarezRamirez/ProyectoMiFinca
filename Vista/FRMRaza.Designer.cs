namespace AgroganaderaMiFincaGui
{
    partial class FRMRaza
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
            this.labelCodigoRaza = new System.Windows.Forms.Label();
            this.labelDescripcionRaza = new System.Windows.Forms.Label();
            this.maskedTextBoxCodigoRaza = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDescripcionRaza = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonIrAMenuPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCodigoRaza
            // 
            this.labelCodigoRaza.AutoSize = true;
            this.labelCodigoRaza.Location = new System.Drawing.Point(12, 9);
            this.labelCodigoRaza.Name = "labelCodigoRaza";
            this.labelCodigoRaza.Size = new System.Drawing.Size(101, 20);
            this.labelCodigoRaza.TabIndex = 0;
            this.labelCodigoRaza.Text = "Codigo Raza";
            // 
            // labelDescripcionRaza
            // 
            this.labelDescripcionRaza.AutoSize = true;
            this.labelDescripcionRaza.Location = new System.Drawing.Point(12, 59);
            this.labelDescripcionRaza.Name = "labelDescripcionRaza";
            this.labelDescripcionRaza.Size = new System.Drawing.Size(134, 20);
            this.labelDescripcionRaza.TabIndex = 1;
            this.labelDescripcionRaza.Text = "Descripcion Raza";
            // 
            // maskedTextBoxCodigoRaza
            // 
            this.maskedTextBoxCodigoRaza.Location = new System.Drawing.Point(120, 2);
            this.maskedTextBoxCodigoRaza.Mask = "00000000000";
            this.maskedTextBoxCodigoRaza.Name = "maskedTextBoxCodigoRaza";
            this.maskedTextBoxCodigoRaza.Size = new System.Drawing.Size(273, 26);
            this.maskedTextBoxCodigoRaza.TabIndex = 2;
            this.maskedTextBoxCodigoRaza.ValidatingType = typeof(int);
            // 
            // textBoxDescripcionRaza
            // 
            this.textBoxDescripcionRaza.Location = new System.Drawing.Point(152, 53);
            this.textBoxDescripcionRaza.Name = "textBoxDescripcionRaza";
            this.textBoxDescripcionRaza.Size = new System.Drawing.Size(241, 26);
            this.textBoxDescripcionRaza.TabIndex = 3;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(659, 12);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(129, 42);
            this.buttonRegistrar.TabIndex = 4;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonIrAMenuPrincipal
            // 
            this.buttonIrAMenuPrincipal.Location = new System.Drawing.Point(637, 383);
            this.buttonIrAMenuPrincipal.Name = "buttonIrAMenuPrincipal";
            this.buttonIrAMenuPrincipal.Size = new System.Drawing.Size(151, 55);
            this.buttonIrAMenuPrincipal.TabIndex = 5;
            this.buttonIrAMenuPrincipal.Text = "Ir a Menu Principal";
            this.buttonIrAMenuPrincipal.UseVisualStyleBackColor = true;
            this.buttonIrAMenuPrincipal.Click += new System.EventHandler(this.buttonIrAMenuPrincipal_Click);
            // 
            // FRMRaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIrAMenuPrincipal);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.textBoxDescripcionRaza);
            this.Controls.Add(this.maskedTextBoxCodigoRaza);
            this.Controls.Add(this.labelDescripcionRaza);
            this.Controls.Add(this.labelCodigoRaza);
            this.Name = "FRMRaza";
            this.Text = "FRMRaza";
            this.Load += new System.EventHandler(this.FRMRaza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigoRaza;
        private System.Windows.Forms.Label labelDescripcionRaza;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodigoRaza;
        private System.Windows.Forms.TextBox textBoxDescripcionRaza;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonIrAMenuPrincipal;
    }
}