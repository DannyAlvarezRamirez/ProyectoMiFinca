namespace ProyectoMiFinca
{
    partial class FRMListaRazas
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
            this.dataGridViewRazas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRazas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRazas
            // 
            this.dataGridViewRazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRazas.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRazas.Name = "dataGridViewRazas";
            this.dataGridViewRazas.RowHeadersWidth = 62;
            this.dataGridViewRazas.RowTemplate.Height = 28;
            this.dataGridViewRazas.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewRazas.TabIndex = 0;
            // 
            // FRMListaRazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRazas);
            this.Name = "FRMListaRazas";
            this.Text = "Modulo Lista de Razas";
            this.Load += new System.EventHandler(this.FRMListaRazas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRazas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRazas;
    }
}