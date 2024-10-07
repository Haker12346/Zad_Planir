namespace PlanZad
{
    partial class FormAddO
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
            this.LbI = new System.Windows.Forms.Label();
            this.LbN = new System.Windows.Forms.Label();
            this.LbH = new System.Windows.Forms.Label();
            this.TbI = new System.Windows.Forms.TextBox();
            this.TbN = new System.Windows.Forms.TextBox();
            this.TbH = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonOt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbI
            // 
            this.LbI.AutoSize = true;
            this.LbI.Location = new System.Drawing.Point(12, 131);
            this.LbI.Name = "LbI";
            this.LbI.Size = new System.Drawing.Size(24, 20);
            this.LbI.TabIndex = 0;
            this.LbI.Text = "№";
            // 
            // LbN
            // 
            this.LbN.AutoSize = true;
            this.LbN.Location = new System.Drawing.Point(12, 194);
            this.LbN.Name = "LbN";
            this.LbN.Size = new System.Drawing.Size(83, 20);
            this.LbN.TabIndex = 1;
            this.LbN.Text = "Название";
            // 
            // LbH
            // 
            this.LbH.AutoSize = true;
            this.LbH.Location = new System.Drawing.Point(12, 261);
            this.LbH.Name = "LbH";
            this.LbH.Size = new System.Drawing.Size(93, 20);
            this.LbH.TabIndex = 2;
            this.LbH.Text = "Начальник";
            // 
            // TbI
            // 
            this.TbI.Location = new System.Drawing.Point(122, 125);
            this.TbI.Name = "TbI";
            this.TbI.Size = new System.Drawing.Size(177, 26);
            this.TbI.TabIndex = 3;
            // 
            // TbN
            // 
            this.TbN.Location = new System.Drawing.Point(122, 194);
            this.TbN.Name = "TbN";
            this.TbN.Size = new System.Drawing.Size(177, 26);
            this.TbN.TabIndex = 4;
            // 
            // TbH
            // 
            this.TbH.Location = new System.Drawing.Point(122, 255);
            this.TbH.Name = "TbH";
            this.TbH.Size = new System.Drawing.Size(177, 26);
            this.TbH.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 321);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 50);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonOt
            // 
            this.buttonOt.Location = new System.Drawing.Point(181, 321);
            this.buttonOt.Name = "buttonOt";
            this.buttonOt.Size = new System.Drawing.Size(131, 50);
            this.buttonOt.TabIndex = 7;
            this.buttonOt.Text = "Отменить";
            this.buttonOt.UseVisualStyleBackColor = true;
            this.buttonOt.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAddO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 405);
            this.Controls.Add(this.buttonOt);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.TbH);
            this.Controls.Add(this.TbN);
            this.Controls.Add(this.TbI);
            this.Controls.Add(this.LbH);
            this.Controls.Add(this.LbN);
            this.Controls.Add(this.LbI);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "FormAddO";
            this.Text = "Добавить запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbI;
        private System.Windows.Forms.Label LbN;
        private System.Windows.Forms.Label LbH;
        private System.Windows.Forms.TextBox TbI;
        private System.Windows.Forms.TextBox TbN;
        private System.Windows.Forms.TextBox TbH;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonOt;
    }
}