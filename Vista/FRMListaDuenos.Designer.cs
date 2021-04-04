namespace AgroganaderaMiFincaGui
{
    partial class FRMListaDuenos
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
            this.dataGridViewDuenos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuenos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDuenos
            // 
            this.dataGridViewDuenos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDuenos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDuenos.Name = "dataGridViewDuenos";
            this.dataGridViewDuenos.RowHeadersWidth = 62;
            this.dataGridViewDuenos.RowTemplate.Height = 28;
            this.dataGridViewDuenos.Size = new System.Drawing.Size(833, 426);
            this.dataGridViewDuenos.TabIndex = 0;
            // 
            // FRMListaDuenos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.dataGridViewDuenos);
            this.Name = "FRMListaDuenos";
            this.Text = "Modulo Lista de Duenos";
            this.Load += new System.EventHandler(this.FRMListaDuenos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuenos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDuenos;
    }
}