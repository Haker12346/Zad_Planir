namespace PlanZad
{
    partial class FormRedS
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
            this.TbN = new System.Windows.Forms.TextBox();
            this.TbI = new System.Windows.Forms.TextBox();
            this.LbN = new System.Windows.Forms.Label();
            this.LbI = new System.Windows.Forms.Label();
            this.buttoRed = new System.Windows.Forms.Button();
            this.buttonOt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbN
            // 
            this.TbN.Location = new System.Drawing.Point(217, 193);
            this.TbN.Name = "TbN";
            this.TbN.Size = new System.Drawing.Size(100, 26);
            this.TbN.TabIndex = 18;
            // 
            // TbI
            // 
            this.TbI.Location = new System.Drawing.Point(217, 130);
            this.TbI.Name = "TbI";
            this.TbI.Size = new System.Drawing.Size(100, 26);
            this.TbI.TabIndex = 17;
            // 
            // LbN
            // 
            this.LbN.AutoSize = true;
            this.LbN.Location = new System.Drawing.Point(53, 196);
            this.LbN.Name = "LbN";
            this.LbN.Size = new System.Drawing.Size(83, 20);
            this.LbN.TabIndex = 16;
            this.LbN.Text = "Название";
            // 
            // LbI
            // 
            this.LbI.AutoSize = true;
            this.LbI.Location = new System.Drawing.Point(53, 136);
            this.LbI.Name = "LbI";
            this.LbI.Size = new System.Drawing.Size(24, 20);
            this.LbI.TabIndex = 15;
            this.LbI.Text = "№";
            // 
            // buttoRed
            // 
            this.buttoRed.Location = new System.Drawing.Point(29, 261);
            this.buttoRed.Name = "buttoRed";
            this.buttoRed.Size = new System.Drawing.Size(153, 45);
            this.buttoRed.TabIndex = 19;
            this.buttoRed.Text = "Редактировать";
            this.buttoRed.UseVisualStyleBackColor = true;
            this.buttoRed.Click += new System.EventHandler(this.buttoRed_Click);
            // 
            // buttonOt
            // 
            this.buttonOt.Location = new System.Drawing.Point(205, 261);
            this.buttonOt.Name = "buttonOt";
            this.buttonOt.Size = new System.Drawing.Size(112, 45);
            this.buttonOt.TabIndex = 20;
            this.buttonOt.Text = "Отменить";
            this.buttonOt.UseVisualStyleBackColor = true;
            this.buttonOt.Click += new System.EventHandler(this.buttonOt_Click);
            // 
            // FormRedS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 326);
            this.Controls.Add(this.buttonOt);
            this.Controls.Add(this.buttoRed);
            this.Controls.Add(this.TbN);
            this.Controls.Add(this.TbI);
            this.Controls.Add(this.LbN);
            this.Controls.Add(this.LbI);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Name = "FormRedS";
            this.Text = "Редактировать запись";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbN;
        private System.Windows.Forms.TextBox TbI;
        private System.Windows.Forms.Label LbN;
        private System.Windows.Forms.Label LbI;
        private System.Windows.Forms.Button buttoRed;
        private System.Windows.Forms.Button buttonOt;
    }
}