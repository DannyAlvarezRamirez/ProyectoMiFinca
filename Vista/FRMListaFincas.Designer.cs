namespace ProyectoMiFinca
{
    partial class FRMListaFincas
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
            this.dataGridViewFincas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFincas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFincas
            // 
            this.dataGridViewFincas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFincas.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewFincas.Name = "dataGridViewFincas";
            this.dataGridViewFincas.RowHeadersWidth = 62;
            this.dataGridViewFincas.RowTemplate.Height = 28;
            this.dataGridViewFincas.Size = new System.Drawing.Size(821, 426);
            this.dataGridViewFincas.TabIndex = 0;
            // 
            // FRMListaFincas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.dataGridViewFincas);
            this.Name = "FRMListaFincas";
            this.Text = "Modulo Lista de Fincas";
            this.Load += new System.EventHandler(this.FRMListaFincas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFincas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewFincas;
    }
}