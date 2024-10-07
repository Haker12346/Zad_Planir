namespace PlanZad
{
    partial class FormAddR
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.TbKtime = new System.Windows.Forms.TextBox();
            this.TbNtime = new System.Windows.Forms.TextBox();
            this.TbN = new System.Windows.Forms.TextBox();
            this.TbZ = new System.Windows.Forms.TextBox();
            this.TbS = new System.Windows.Forms.TextBox();
            this.TbI = new System.Windows.Forms.TextBox();
            this.LbKtime = new System.Windows.Forms.Label();
            this.LbNtime = new System.Windows.Forms.Label();
            this.LbND = new System.Windows.Forms.Label();
            this.LbZ = new System.Windows.Forms.Label();
            this.LbS = new System.Windows.Forms.Label();
            this.LbI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOt
            // 
            this.buttonOt.Location = new System.Drawing.Point(204, 401);
            this.buttonOt.Name = "buttonOt";
            this.buttonOt.Size = new System.Drawing.Size(116, 67);
            this.buttonOt.TabIndex = 27;
            this.buttonOt.Text = "Отменить";
            this.buttonOt.UseVisualStyleBackColor = true;
            this.buttonOt.Click += new System.EventHandler(this.buttonOt_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(20, 401);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 67);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // TbKtime
            // 
            this.TbKtime.Location = new System.Drawing.Point(199, 324);
            this.TbKtime.Name = "TbKtime";
            this.TbKtime.Size = new System.Drawing.Size(100, 26);
            this.TbKtime.TabIndex = 25;
            // 
            // TbNtime
            // 
            this.TbNtime.Location = new System.Drawing.Point(199, 290);
            this.TbNtime.Name = "TbNtime";
            this.TbNtime.Size = new System.Drawing.Size(100, 26);
            this.TbNtime.TabIndex = 24;
            // 
            // TbN
            // 
            this.TbN.Location = new System.Drawing.Point(199, 252);
            this.TbN.Name = "TbN";
            this.TbN.Size = new System.Drawing.Size(100, 26);
            this.TbN.TabIndex = 23;
            // 
            // TbZ
            // 
            this.TbZ.Location = new System.Drawing.Point(199, 211);
            this.TbZ.Name = "TbZ";
            this.TbZ.Size = new System.Drawing.Size(100, 26);
            this.TbZ.TabIndex = 22;
            // 
            // TbS
            // 
            this.TbS.Location = new System.Drawing.Point(199, 172);
            this.TbS.Name = "TbS";
            this.TbS.Size = new System.Drawing.Size(100, 26);
            this.TbS.TabIndex = 21;
            // 
            // TbI
            // 
            this.TbI.Location = new System.Drawing.Point(199, 137);
            this.TbI.Name = "TbI";
            this.TbI.Size = new System.Drawing.Size(100, 26);
            this.TbI.TabIndex = 20;
            // 
            // LbKtime
            // 
            this.LbKtime.AutoSize = true;
            this.LbKtime.Location = new System.Drawing.Point(41, 330);
            this.LbKtime.Name = "LbKtime";
            this.LbKtime.Size = new System.Drawing.Size(106, 20);
            this.LbKtime.TabIndex = 19;
            this.LbKtime.Text = "Время конца";
            // 
            // LbNtime
            // 
            this.LbNtime.AutoSize = true;
            this.LbNtime.Location = new System.Drawing.Point(41, 290);
            this.LbNtime.Name = "LbNtime";
            this.LbNtime.Size = new System.Drawing.Size(117, 20);
            this.LbNtime.TabIndex = 18;
            this.LbNtime.Text = "Время начала";
            // 
            // LbND
            // 
            this.LbND.AutoSize = true;
            this.LbND.Location = new System.Drawing.Point(41, 254);
            this.LbND.Name = "LbND";
            this.LbND.Size = new System.Drawing.Size(107, 20);
            this.LbND.TabIndex = 17;
            this.LbND.Text = "День начала";
            // 
            // LbZ
            // 
            this.LbZ.AutoSize = true;
            this.LbZ.Location = new System.Drawing.Point(41, 214);
            this.LbZ.Name = "LbZ";
            this.LbZ.Size = new System.Drawing.Size(118, 20);
            this.LbZ.TabIndex = 16;
            this.LbZ.Text = "Номер задачи";
            // 
            // LbS
            // 
            this.LbS.AutoSize = true;
            this.LbS.Location = new System.Drawing.Point(41, 178);
            this.LbS.Name = "LbS";
            this.LbS.Size = new System.Drawing.Size(151, 20);
            this.LbS.TabIndex = 15;
            this.LbS.Text = "Номер сотрудника";
            // 
            // LbI
            // 
            this.LbI.AutoSize = true;
            this.LbI.Location = new System.Drawing.Point(41, 140);
            this.LbI.Name = "LbI";
            this.LbI.Size = new System.Drawing.Size(151, 20);
            this.LbI.TabIndex = 14;
            this.LbI.Text = "Номер расписания";
            // 
            // FormAddR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 480);
            this.Controls.Add(this.buttonOt);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.TbKtime);
            this.Controls.Add(this.TbNtime);
            this.Controls.Add(this.TbN);
            this.Controls.Add(this.TbZ);
            this.Controls.Add(this.TbS);
            this.Controls.Add(this.TbI);
            this.Controls.Add(this.LbKtime);
            this.Controls.Add(this.LbNtime);
            this.Controls.Add(this.LbND);
            this.Controls.Add(this.LbZ);
            this.Controls.Add(this.LbS);
            this.Controls.Add(this.LbI);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Name = "FormAddR";
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOt;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox TbKtime;
        private System.Windows.Forms.TextBox TbNtime;
        private System.Windows.Forms.TextBox TbN;
        private System.Windows.Forms.TextBox TbZ;
        private System.Windows.Forms.TextBox TbS;
        private System.Windows.Forms.TextBox TbI;
        private System.Windows.Forms.Label LbKtime;
        private System.Windows.Forms.Label LbNtime;
        private System.Windows.Forms.Label LbND;
        private System.Windows.Forms.Label LbZ;
        private System.Windows.Forms.Label LbS;
        private System.Windows.Forms.Label LbI;
    }
}