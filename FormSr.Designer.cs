namespace PlanZad
{
    partial class FormSr
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
            this.buttonzad = new System.Windows.Forms.Button();
            this.dataGridViewZ = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZ)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonzad
            // 
            this.buttonzad.Location = new System.Drawing.Point(198, 460);
            this.buttonzad.Name = "buttonzad";
            this.buttonzad.Size = new System.Drawing.Size(178, 58);
            this.buttonzad.TabIndex = 3;
            this.buttonzad.Text = "Назад";
            this.buttonzad.UseVisualStyleBackColor = true;
            this.buttonzad.Click += new System.EventHandler(this.buttonzad_Click);
            // 
            // dataGridViewZ
            // 
            this.dataGridViewZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZ.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewZ.Name = "dataGridViewZ";
            this.dataGridViewZ.RowHeadersWidth = 62;
            this.dataGridViewZ.RowTemplate.Height = 28;
            this.dataGridViewZ.Size = new System.Drawing.Size(563, 356);
            this.dataGridViewZ.TabIndex = 2;
            // 
            // FormSr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 530);
            this.Controls.Add(this.buttonzad);
            this.Controls.Add(this.dataGridViewZ);
            this.Name = "FormSr";
            this.Text = "Срок сдачи";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonzad;
        private System.Windows.Forms.DataGridView dataGridViewZ;
    }
}