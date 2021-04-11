namespace Principal
{
    partial class FRM_PrincipalAplicacion
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
            this.buttonServidor = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonServidor
            // 
            this.buttonServidor.Location = new System.Drawing.Point(183, 142);
            this.buttonServidor.Name = "buttonServidor";
            this.buttonServidor.Size = new System.Drawing.Size(142, 64);
            this.buttonServidor.TabIndex = 0;
            this.buttonServidor.Text = "Servidor";
            this.buttonServidor.UseVisualStyleBackColor = true;
            // 
            // buttonCliente
            // 
            this.buttonCliente.Location = new System.Drawing.Point(501, 142);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(151, 64);
            this.buttonCliente.TabIndex = 1;
            this.buttonCliente.Text = "Cliente";
            this.buttonCliente.UseVisualStyleBackColor = true;
            // 
            // FRM_PrincipalAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.buttonServidor);
            this.Name = "FRM_PrincipalAplicacion";
            this.Text = "Modulo Principal Aplicacion Proyecto UNED ";
            this.Load += new System.EventHandler(this.FRM_PrincipalAplicacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonServidor;
        private System.Windows.Forms.Button buttonCliente;
    }
}

