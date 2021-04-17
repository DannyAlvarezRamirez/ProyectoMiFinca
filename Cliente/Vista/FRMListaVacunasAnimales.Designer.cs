namespace Cliente
{
    partial class FRMListaVacunasAnimales
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
            this.dataGridViewVacunasAnimales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacunasAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVacunasAnimales
            // 
            this.dataGridViewVacunasAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacunasAnimales.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVacunasAnimales.Name = "dataGridViewVacunasAnimales";
            this.dataGridViewVacunasAnimales.RowHeadersWidth = 62;
            this.dataGridViewVacunasAnimales.RowTemplate.Height = 28;
            this.dataGridViewVacunasAnimales.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewVacunasAnimales.TabIndex = 1;
            // 
            // FRMListaVacunasAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewVacunasAnimales);
            this.Name = "FRMListaVacunasAnimales";
            this.Text = "Modulo Lista Vacunas de Animales";
            this.Load += new System.EventHandler(this.FRMListaVacunasAnimales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacunasAnimales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVacunasAnimales;
    }
}