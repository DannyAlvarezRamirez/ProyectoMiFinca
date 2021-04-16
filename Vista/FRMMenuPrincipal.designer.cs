namespace ProyectoMiFinca
{
    partial class FRMMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fincaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razaDeAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fincasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duenosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.razasDeAnimalesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.animalesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxAccionesClientes = new System.Windows.Forms.TextBox();
            this.labelCantidadClientesConectados = new System.Windows.Forms.Label();
            this.labelAccionesClientes = new System.Windows.Forms.Label();
            this.textBoxCantidadClientesConectados = new System.Windows.Forms.TextBox();
            this.buttonIniciarServidor = new System.Windows.Forms.Button();
            this.labelIniciarApagarServidor = new System.Windows.Forms.Label();
            this.buttonApagarServidor = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(945, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fincaToolStripMenuItem,
            this.duenoToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.razaDeAnimalToolStripMenuItem,
            this.animalToolStripMenuItem,
            this.vacunaToolStripMenuItem});
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // fincaToolStripMenuItem
            // 
            this.fincaToolStripMenuItem.Name = "fincaToolStripMenuItem";
            this.fincaToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.fincaToolStripMenuItem.Text = "Fincas";
            this.fincaToolStripMenuItem.Click += new System.EventHandler(this.fincaToolStripMenuItem_Click);
            // 
            // duenoToolStripMenuItem
            // 
            this.duenoToolStripMenuItem.Name = "duenoToolStripMenuItem";
            this.duenoToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.duenoToolStripMenuItem.Text = "Dueños";
            this.duenoToolStripMenuItem.Click += new System.EventHandler(this.duenoToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.empleadoToolStripMenuItem.Text = "Empleados";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // razaDeAnimalToolStripMenuItem
            // 
            this.razaDeAnimalToolStripMenuItem.Name = "razaDeAnimalToolStripMenuItem";
            this.razaDeAnimalToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.razaDeAnimalToolStripMenuItem.Text = "Razas de animales";
            this.razaDeAnimalToolStripMenuItem.Click += new System.EventHandler(this.razaDeAnimalToolStripMenuItem_Click);
            // 
            // animalToolStripMenuItem
            // 
            this.animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            this.animalToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.animalToolStripMenuItem.Text = "Animales";
            this.animalToolStripMenuItem.Click += new System.EventHandler(this.animalToolStripMenuItem_Click);
            // 
            // vacunaToolStripMenuItem
            // 
            this.vacunaToolStripMenuItem.Name = "vacunaToolStripMenuItem";
            this.vacunaToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.vacunaToolStripMenuItem.Text = "Vacunas";
            this.vacunaToolStripMenuItem.Click += new System.EventHandler(this.vacunaToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fincasToolStripMenuItem,
            this.duenosToolStripMenuItem,
            this.empleadosToolStripMenuItem1,
            this.razasDeAnimalesToolStripMenuItem1,
            this.animalesToolStripMenuItem1,
            this.vacunasToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(173, 29);
            this.mostrarToolStripMenuItem.Text = "Mostrar la Lista de";
            // 
            // fincasToolStripMenuItem
            // 
            this.fincasToolStripMenuItem.Name = "fincasToolStripMenuItem";
            this.fincasToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.fincasToolStripMenuItem.Text = "Fincas";
            this.fincasToolStripMenuItem.Click += new System.EventHandler(this.fincasToolStripMenuItem_Click);
            // 
            // duenosToolStripMenuItem
            // 
            this.duenosToolStripMenuItem.Name = "duenosToolStripMenuItem";
            this.duenosToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.duenosToolStripMenuItem.Text = "Duenos";
            this.duenosToolStripMenuItem.Click += new System.EventHandler(this.duenosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(261, 34);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // razasDeAnimalesToolStripMenuItem1
            // 
            this.razasDeAnimalesToolStripMenuItem1.Name = "razasDeAnimalesToolStripMenuItem1";
            this.razasDeAnimalesToolStripMenuItem1.Size = new System.Drawing.Size(261, 34);
            this.razasDeAnimalesToolStripMenuItem1.Text = "Razas de Animales";
            this.razasDeAnimalesToolStripMenuItem1.Click += new System.EventHandler(this.razasDeAnimalesToolStripMenuItem_Click);
            // 
            // animalesToolStripMenuItem1
            // 
            this.animalesToolStripMenuItem1.Name = "animalesToolStripMenuItem1";
            this.animalesToolStripMenuItem1.Size = new System.Drawing.Size(261, 34);
            this.animalesToolStripMenuItem1.Text = "Animales";
            this.animalesToolStripMenuItem1.Click += new System.EventHandler(this.animalesToolStripMenuItem_Click);
            // 
            // vacunasToolStripMenuItem
            // 
            this.vacunasToolStripMenuItem.Name = "vacunasToolStripMenuItem";
            this.vacunasToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.vacunasToolStripMenuItem.Text = "Vacunas";
            this.vacunasToolStripMenuItem.Click += new System.EventHandler(this.vacunasToolStripMenuItem_Click);
            // 
            // textBoxAccionesClientes
            // 
            this.textBoxAccionesClientes.Location = new System.Drawing.Point(16, 245);
            this.textBoxAccionesClientes.Multiline = true;
            this.textBoxAccionesClientes.Name = "textBoxAccionesClientes";
            this.textBoxAccionesClientes.Size = new System.Drawing.Size(917, 237);
            this.textBoxAccionesClientes.TabIndex = 1;
            // 
            // labelCantidadClientesConectados
            // 
            this.labelCantidadClientesConectados.AutoSize = true;
            this.labelCantidadClientesConectados.Location = new System.Drawing.Point(12, 60);
            this.labelCantidadClientesConectados.Name = "labelCantidadClientesConectados";
            this.labelCantidadClientesConectados.Size = new System.Drawing.Size(246, 20);
            this.labelCantidadClientesConectados.TabIndex = 2;
            this.labelCantidadClientesConectados.Text = "Cantidad de Clientes Conectados";
            // 
            // labelAccionesClientes
            // 
            this.labelAccionesClientes.AutoSize = true;
            this.labelAccionesClientes.Location = new System.Drawing.Point(12, 222);
            this.labelAccionesClientes.Name = "labelAccionesClientes";
            this.labelAccionesClientes.Size = new System.Drawing.Size(181, 20);
            this.labelAccionesClientes.TabIndex = 3;
            this.labelAccionesClientes.Text = "Acciones de los Clientes";
            // 
            // textBoxCantidadClientesConectados
            // 
            this.textBoxCantidadClientesConectados.Location = new System.Drawing.Point(16, 83);
            this.textBoxCantidadClientesConectados.Multiline = true;
            this.textBoxCantidadClientesConectados.Name = "textBoxCantidadClientesConectados";
            this.textBoxCantidadClientesConectados.Size = new System.Drawing.Size(352, 136);
            this.textBoxCantidadClientesConectados.TabIndex = 4;
            // 
            // buttonIniciarServidor
            // 
            this.buttonIniciarServidor.BackColor = System.Drawing.Color.Lime;
            this.buttonIniciarServidor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIniciarServidor.Location = new System.Drawing.Point(482, 83);
            this.buttonIniciarServidor.Name = "buttonIniciarServidor";
            this.buttonIniciarServidor.Size = new System.Drawing.Size(152, 49);
            this.buttonIniciarServidor.TabIndex = 6;
            this.buttonIniciarServidor.Text = "Iniciar Servidor";
            this.buttonIniciarServidor.UseVisualStyleBackColor = false;
            this.buttonIniciarServidor.Click += new System.EventHandler(this.buttonIniciarServidor_Click);
            // 
            // labelIniciarApagarServidor
            // 
            this.labelIniciarApagarServidor.AutoSize = true;
            this.labelIniciarApagarServidor.Location = new System.Drawing.Point(396, 44);
            this.labelIniciarApagarServidor.Name = "labelIniciarApagarServidor";
            this.labelIniciarApagarServidor.Size = new System.Drawing.Size(74, 20);
            this.labelIniciarApagarServidor.TabIndex = 8;
            this.labelIniciarApagarServidor.Text = "Apagado";
            // 
            // buttonApagarServidor
            // 
            this.buttonApagarServidor.BackColor = System.Drawing.Color.Red;
            this.buttonApagarServidor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonApagarServidor.Location = new System.Drawing.Point(640, 83);
            this.buttonApagarServidor.Name = "buttonApagarServidor";
            this.buttonApagarServidor.Size = new System.Drawing.Size(152, 49);
            this.buttonApagarServidor.TabIndex = 9;
            this.buttonApagarServidor.Text = "Apagar Servidor";
            this.buttonApagarServidor.UseVisualStyleBackColor = false;
            this.buttonApagarServidor.Click += new System.EventHandler(this.buttonApagarServidor_Click);
            // 
            // FRMMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 494);
            this.Controls.Add(this.buttonApagarServidor);
            this.Controls.Add(this.labelIniciarApagarServidor);
            this.Controls.Add(this.buttonIniciarServidor);
            this.Controls.Add(this.textBoxCantidadClientesConectados);
            this.Controls.Add(this.labelAccionesClientes);
            this.Controls.Add(this.labelCantidadClientesConectados);
            this.Controls.Add(this.textBoxAccionesClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMMenuPrincipal";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.FRMMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fincaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem razaDeAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fincasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duenosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem razasDeAnimalesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem animalesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vacunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunasToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxAccionesClientes;
        private System.Windows.Forms.Label labelCantidadClientesConectados;
        private System.Windows.Forms.Label labelAccionesClientes;
        private System.Windows.Forms.TextBox textBoxCantidadClientesConectados;
        private System.Windows.Forms.Button buttonIniciarServidor;
        private System.Windows.Forms.Label labelIniciarApagarServidor;
        private System.Windows.Forms.Button buttonApagarServidor;
    }
}

