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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunaAnimaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunasAnimalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.buttonConectarAlServidor.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonConectarAlServidor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConectarAlServidor.Location = new System.Drawing.Point(36, 138);
            this.buttonConectarAlServidor.Name = "buttonConectarAlServidor";
            this.buttonConectarAlServidor.Size = new System.Drawing.Size(172, 58);
            this.buttonConectarAlServidor.TabIndex = 4;
            this.buttonConectarAlServidor.Text = "Conectar al Servidor";
            this.buttonConectarAlServidor.UseVisualStyleBackColor = false;
            this.buttonConectarAlServidor.Click += new System.EventHandler(this.buttonConectarAlServidor_Click);
            // 
            // buttonDesconectarDelServidor
            // 
            this.buttonDesconectarDelServidor.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonDesconectarDelServidor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDesconectarDelServidor.Location = new System.Drawing.Point(237, 138);
            this.buttonDesconectarDelServidor.Name = "buttonDesconectarDelServidor";
            this.buttonDesconectarDelServidor.Size = new System.Drawing.Size(233, 58);
            this.buttonDesconectarDelServidor.TabIndex = 5;
            this.buttonDesconectarDelServidor.Text = "Desconectar del Servidor";
            this.buttonDesconectarDelServidor.UseVisualStyleBackColor = false;
            this.buttonDesconectarDelServidor.Click += new System.EventHandler(this.buttonDesconectarDelServidor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.mostrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem,
            this.vacunaToolStripMenuItem,
            this.vacunaAnimaleToolStripMenuItem});
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.empleadoToolStripMenuItem.Text = "Empleados";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // vacunaToolStripMenuItem
            // 
            this.vacunaToolStripMenuItem.Name = "vacunaToolStripMenuItem";
            this.vacunaToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.vacunaToolStripMenuItem.Text = "Vacunas";
            this.vacunaToolStripMenuItem.Click += new System.EventHandler(this.vacunaToolStripMenuItem_Click);
            // 
            // vacunaAnimaleToolStripMenuItem
            // 
            this.vacunaAnimaleToolStripMenuItem.Name = "vacunaAnimaleToolStripMenuItem";
            this.vacunaAnimaleToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.vacunaAnimaleToolStripMenuItem.Text = "Vacunas Animales";
            this.vacunaAnimaleToolStripMenuItem.Click += new System.EventHandler(this.vacunaAnimaleToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.vacunasToolStripMenuItem,
            this.vacunasAnimalesToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(173, 29);
            this.mostrarToolStripMenuItem.Text = "Mostrar la Lista de";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // vacunasToolStripMenuItem
            // 
            this.vacunasToolStripMenuItem.Name = "vacunasToolStripMenuItem";
            this.vacunasToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.vacunasToolStripMenuItem.Text = "Vacunas";
            this.vacunasToolStripMenuItem.Click += new System.EventHandler(this.vacunasToolStripMenuItem_Click);
            // 
            // vacunasAnimalesToolStripMenuItem
            // 
            this.vacunasAnimalesToolStripMenuItem.Name = "vacunasAnimalesToolStripMenuItem";
            this.vacunasAnimalesToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.vacunasAnimalesToolStripMenuItem.Text = "Vacunas Animales";
            this.vacunasAnimalesToolStripMenuItem.Click += new System.EventHandler(this.vacunasAnimalesToolStripMenuItem_Click);
            // 
            // FRM_PrincipalCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonDesconectarDelServidor);
            this.Controls.Add(this.buttonConectarAlServidor);
            this.Controls.Add(this.textBoxIdentificadorDelCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelEstadoConectadoDesconectado);
            this.Controls.Add(this.labelEstado);
            this.Name = "FRM_PrincipalCliente";
            this.Text = "Modulo Cliente";
            this.Load += new System.EventHandler(this.FRM_PrincipalCliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunaAnimaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunasAnimalesToolStripMenuItem;
    }
}

