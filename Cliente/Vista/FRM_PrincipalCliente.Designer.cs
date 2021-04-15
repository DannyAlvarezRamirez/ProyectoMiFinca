namespace Cliente
{
    partial class FRM_PrincipalCliente
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
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelEstadoConectadoDesconectado = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.textBoxIdentificadorDelCliente = new System.Windows.Forms.TextBox();
            this.buttonConectarAlServidor = new System.Windows.Forms.Button();
            this.buttonDesconectarDelServidor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(32, 40);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(68, 20);
            this.labelEstado.TabIndex = 0;
            this.labelEstado.Text = "Estado: ";
            // 
            // labelEstadoConectadoDesconectado
            // 
            this.labelEstadoConectadoDesconectado.AutoSize = true;
            this.labelEstadoConectadoDesconectado.Location = new System.Drawing.Point(118, 40);
            this.labelEstadoConectadoDesconectado.Name = "labelEstadoConectadoDesconectado";
            this.labelEstadoConectadoDesconectado.Size = new System.Drawing.Size(113, 20);
            this.labelEstadoConectadoDesconectado.TabIndex = 1;
            this.labelEstadoConectadoDesconectado.Text = "Desconectado";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(32, 85);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(66, 20);
            this.labelCliente.TabIndex = 2;
            this.labelCliente.Text = "Cliente: ";
            // 
            // textBoxIdentificadorDelCliente
            // 
            this.textBoxIdentificadorDelCliente.Location = new System.Drawing.Point(122, 82);
            this.textBoxIdentificadorDelCliente.Name = "textBoxIdentificadorDelCliente";
            this.textBoxIdentificadorDelCliente.Size = new System.Drawing.Size(116, 26);
            this.textBoxIdentificadorDelCliente.TabIndex = 3;
            // 
            // buttonConectarAlServidor
            // 
            this.buttonConectarAlServidor.Location = new System.Drawing.Point(36, 138);
            this.buttonConectarAlServidor.Name = "buttonConectarAlServidor";
            this.buttonConectarAlServidor.Size = new System.Drawing.Size(103, 58);
            this.buttonConectarAlServidor.TabIndex = 4;
            this.buttonConectarAlServidor.Text = "Conectar al Servidor";
            this.buttonConectarAlServidor.UseVisualStyleBackColor = true;
            this.buttonConectarAlServidor.Click += new System.EventHandler(this.buttonConectarAlServidor_Click);
            // 
            // buttonDesconectarDelServidor
            // 
            this.buttonDesconectarDelServidor.Location = new System.Drawing.Point(174, 138);
            this.buttonDesconectarDelServidor.Name = "buttonDesconectarDelServidor";
            this.buttonDesconectarDelServidor.Size = new System.Drawing.Size(109, 58);
            this.buttonDesconectarDelServidor.TabIndex = 5;
            this.buttonDesconectarDelServidor.Text = "Desconectar del Servidor";
            this.buttonDesconectarDelServidor.UseVisualStyleBackColor = true;
            this.buttonDesconectarDelServidor.Click += new System.EventHandler(this.buttonDesconectarDelServidor_Click);
            // 
            // FRM_PrincipalCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDesconectarDelServidor);
            this.Controls.Add(this.buttonConectarAlServidor);
            this.Controls.Add(this.textBoxIdentificadorDelCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelEstadoConectadoDesconectado);
            this.Controls.Add(this.labelEstado);
            this.Name = "FRM_PrincipalCliente";
            this.Text = "Modulo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelEstadoConectadoDesconectado;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox textBoxIdentificadorDelCliente;
        private System.Windows.Forms.Button buttonConectarAlServidor;
        private System.Windows.Forms.Button buttonDesconectarDelServidor;
    }
}

