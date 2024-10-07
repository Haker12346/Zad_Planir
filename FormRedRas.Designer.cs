namespace PlanZad
{
    partial class FormRedZ
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
            this.LbS = new System.Windows.Forms.Label();
            this.LbZ = new System.Windows.Forms.Label();
            this.LbND = new System.Windows.Forms.Label();
            this.LbNtime = new System.Windows.Forms.Label();
            this.LbKtime = new System.Windows.Forms.Label();
            this.TbI = new System.Windows.Forms.TextBox();
            this.TbS = new System.Windows.Forms.TextBox();
            this.TbZ = new System.Windows.Forms.TextBox();
            this.TbN = new System.Windows.Forms.TextBox();
            this.TbNtime = new System.Windows.Forms.TextBox();
            this.TbKtime = new System.Windows.Forms.TextBox();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonOt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbI
            // 
            this.LbI.AutoSize = true;
            this.LbI.Location = new System.Drawing.Point(50, 141);
            this.LbI.Name = "LbI";
            this.LbI.Size = new System.Drawing.Size(151, 20);
            this.LbI.TabIndex = 0;
            this.LbI.Text = "Номер расписания";
            // 
            // LbS
            // 
            this.LbS.AutoSize = true;
            this.LbS.Location = new System.Drawing.Point(50, 179);
            this.LbS.Name = "LbS";
            this.LbS.Size = new System.Drawing.Size(151, 20);
            this.LbS.TabIndex = 1;
            this.LbS.Text = "Номер сотрудника";
            // 
            // LbZ
            // 
            this.LbZ.AutoSize = true;
            this.LbZ.Location = new System.Drawing.Point(50, 215);
            this.LbZ.Name = "LbZ";
            this.LbZ.Size = new System.Drawing.Size(118, 20);
            this.LbZ.TabIndex = 2;
            this.LbZ.Text = "Номер задачи";
            // 
            // LbND
            // 
            this.LbND.AutoSize = true;
            this.LbND.Location = new System.Drawing.Point(50, 255);
            this.LbND.Name = "LbND";
            this.LbND.Size = new System.Drawing.Size(107, 20);
            this.LbND.TabIndex = 3;
            this.LbND.Text = "День начала";
            // 
            // LbNtime
            // 
            this.LbNtime.AutoSize = true;
            this.LbNtime.Location = new System.Drawing.Point(50, 291);
            this.LbNtime.Name = "LbNtime";
            this.LbNtime.Size = new System.Drawing.Size(117, 20);
            this.LbNtime.TabIndex = 4;
            this.LbNtime.Text = "Время начала";
            // 
            // LbKtime
            // 
            this.LbKtime.AutoSize = true;
            this.LbKtime.Location = new System.Drawing.Point(50, 331);
            this.LbKtime.Name = "LbKtime";
            this.LbKtime.Size = new System.Drawing.Size(106, 20);
            this.LbKtime.TabIndex = 5;
            this.LbKtime.Text = "Время конца";
            // 
            // TbI
            // 
            this.TbI.Location = new System.Drawing.Point(208, 138);
            this.TbI.Name = "TbI";
            this.TbI.Size = new System.Drawing.Size(100, 26);
            this.TbI.TabIndex = 6;
            // 
            // TbS
            // 
            this.TbS.Location = new System.Drawing.Point(208, 173);
            this.TbS.Name = "TbS";
            this.TbS.Size = new System.Drawing.Size(100, 26);
            this.TbS.TabIndex = 7;
            // 
            // TbZ
            // 
            this.TbZ.Location = new System.Drawing.Point(208, 212);
            this.TbZ.Name = "TbZ";
            this.TbZ.Size = new System.Drawing.Size(100, 26);
            this.TbZ.TabIndex = 8;
            // 
            // TbN
            // 
            this.TbN.Location = new System.Drawing.Point(208, 253);
            this.TbN.Name = "TbN";
            this.TbN.Size = new System.Drawing.Size(100, 26);
            this.TbN.TabIndex = 9;
            // 
            // TbNtime
            // 
            this.TbNtime.Location = new System.Drawing.Point(208, 291);
            this.TbNtime.Name = "TbNtime";
            this.TbNtime.Size = new System.Drawing.Size(100, 26);
            this.TbNtime.TabIndex = 10;
            // 
            // TbKtime
            // 
            this.TbKtime.Location = new System.Drawing.Point(208, 325);
            this.TbKtime.Name = "TbKtime";
            this.TbKtime.Size = new System.Drawing.Size(100, 26);
            this.TbKtime.TabIndex = 11;
            // 
            // buttonRed
            // 
            this.buttonRed.Location = new System.Drawing.Point(27, 393);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(136, 67);
            this.buttonRed.TabIndex = 12;
            this.buttonRed.Text = "Редактировать";
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonOt
            // 
            this.buttonOt.Location = new System.Drawing.Point(215, 393);
            this.buttonOt.Name = "buttonOt";
            this.buttonOt.Size = new System.Drawing.Size(116, 67);
            this.buttonOt.TabIndex = 13;
            this.buttonOt.Text = "Отменить";
            this.buttonOt.UseVisualStyleBackColor = true;
            this.buttonOt.Click += new System.EventHandler(this.buttonOt_Click);
            // 
            // FormRedZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 502);
            this.Controls.Add(this.buttonOt);
            this.Controls.Add(this.buttonRed);
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
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Name = "FormRedZ";
            this.Text = "Редактировать запись";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbI;
        private System.Windows.Forms.Label LbS;
        private System.Windows.Forms.Label LbZ;
        private System.Windows.Forms.Label LbND;
        private System.Windows.Forms.Label LbNtime;
        private System.Windows.Forms.Label LbKtime;
        private System.Windows.Forms.TextBox TbI;
        private System.Windows.Forms.TextBox TbS;
        private System.Windows.Forms.TextBox TbZ;
        private System.Windows.Forms.TextBox TbN;
        private System.Windows.Forms.TextBox TbNtime;
        private System.Windows.Forms.TextBox TbKtime;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonOt;
    }
}