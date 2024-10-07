namespace PlanZad
{
    partial class FormPv
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
            this.dataGridViewZ = new System.Windows.Forms.DataGridView();
            this.buttonzad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZ)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZ
            // 
            this.dataGridViewZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZ.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewZ.Name = "dataGridViewZ";
            this.dataGridViewZ.RowHeadersWidth = 62;
            this.dataGridViewZ.RowTemplate.Height = 28;
            this.dataGridViewZ.Size = new System.Drawing.Size(1007, 355);
            this.dataGridViewZ.TabIndex = 0;
            // 
            // buttonzad
            // 
            this.buttonzad.Location = new System.Drawing.Point(410, 441);
            this.buttonzad.Name = "buttonzad";
            this.buttonzad.Size = new System.Drawing.Size(178, 58);
            this.buttonzad.TabIndex = 1;
            this.buttonzad.Text = "Назад";
            this.buttonzad.UseVisualStyleBackColor = true;
            this.buttonzad.Click += new System.EventHandler(this.buttonzad_Click);
            // 
            // FormPv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 526);
            this.Controls.Add(this.buttonzad);
            this.Controls.Add(this.dataGridViewZ);
            this.Name = "FormPv";
            this.Text = "Проверка на выполнения";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZ;
        private System.Windows.Forms.Button buttonzad;
    }
}