namespace ProyectoMiFinca
{
    partial class FRMListaVacunas
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
            this.dataGridViewVacunas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacunas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVacunas
            // 
            this.dataGridViewVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacunas.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVacunas.Name = "dataGridViewVacunas";
            this.dataGridViewVacunas.RowHeadersWidth = 62;
            this.dataGridViewVacunas.RowTemplate.Height = 28;
            this.dataGridViewVacunas.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewVacunas.TabIndex = 1;
            // 
            // FRMListaVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewVacunas);
            this.Name = "FRMListaVacunas";
            this.Text = "FRMListaVacunas";
            this.Load += new System.EventHandler(this.FRMListaVacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacunas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVacunas;
    }
}