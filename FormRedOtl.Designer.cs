namespace PlanZad
{
    partial class FormRedO
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
            this.buttonOt = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.TbH = new System.Windows.Forms.TextBox();
            this.TbN = new System.Windows.Forms.TextBox();
            this.TbI = new System.Windows.Forms.TextBox();
            this.LbH = new System.Windows.Forms.Label();
            this.LbN = new System.Windows.Forms.Label();
            this.LbI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOt
            // 
            this.buttonOt.Location = new System.Drawing.Point(204, 317);
            this.buttonOt.Name = "buttonOt";
            this.buttonOt.Size = new System.Drawing.Size(131, 50);
            this.buttonOt.TabIndex = 15;
            this.buttonOt.Text = "Отменить";
            this.buttonOt.UseVisualStyleBackColor = true;
            this.buttonOt.Click += new System.EventHandler(this.buttonOt_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.Location = new System.Drawing.Point(39, 317);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(141, 50);
            this.buttonRed.TabIndex = 14;
            this.buttonRed.Text = "Редактировать";
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // TbH
            // 
            this.TbH.Location = new System.Drawing.Point(145, 249);
            this.TbH.Name = "TbH";
            this.TbH.Size = new System.Drawing.Size(177, 26);
            this.TbH.TabIndex = 13;
            // 
            // TbN
            // 
            this.TbN.Location = new System.Drawing.Point(145, 188);
            this.TbN.Name = "TbN";
            this.TbN.Size = new System.Drawing.Size(177, 26);
            this.TbN.TabIndex = 12;
            // 
            // TbI
            // 
            this.TbI.Location = new System.Drawing.Point(145, 119);
            this.TbI.Name = "TbI";
            this.TbI.Size = new System.Drawing.Size(177, 26);
            this.TbI.TabIndex = 11;
            // 
            // LbH
            // 
            this.LbH.AutoSize = true;
            this.LbH.Location = new System.Drawing.Point(35, 255);
            this.LbH.Name = "LbH";
            this.LbH.Size = new System.Drawing.Size(93, 20);
            this.LbH.TabIndex = 10;
            this.LbH.Text = "Начальник";
            // 
            // LbN
            // 
            this.LbN.AutoSize = true;
            this.LbN.Location = new System.Drawing.Point(35, 188);
            this.LbN.Name = "LbN";
            this.LbN.Size = new System.Drawing.Size(83, 20);
            this.LbN.TabIndex = 9;
            this.LbN.Text = "Название";
            // 
            // LbI
            // 
            this.LbI.AutoSize = true;
            this.LbI.Location = new System.Drawing.Point(35, 125);
            this.LbI.Name = "LbI";
            this.LbI.Size = new System.Drawing.Size(24, 20);
            this.LbI.TabIndex = 8;
            this.LbI.Text = "№";
            // 
            // FormRedO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 396);
            this.Controls.Add(this.buttonOt);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.TbH);
            this.Controls.Add(this.TbN);
            this.Controls.Add(this.TbI);
            this.Controls.Add(this.LbH);
            this.Controls.Add(this.LbN);
            this.Controls.Add(this.LbI);
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.Name = "FormRedO";
            this.Text = "Редактировать запись";
            this.Load += new System.EventHandler(this.FormRedO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOt;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.TextBox TbH;
        private System.Windows.Forms.TextBox TbN;
        private System.Windows.Forms.TextBox TbI;
        private System.Windows.Forms.Label LbH;
        private System.Windows.Forms.Label LbN;
        private System.Windows.Forms.Label LbI;
    }
}