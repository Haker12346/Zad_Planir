namespace PlanZad
{
    partial class FormAV
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAV));
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.labelL = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.raspisanieTableAdapter = new PlanZad.Zad_PlanirDataSet17TableAdapters.RaspisanieTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(150, 140);
            this.textBoxL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(180, 36);
            this.textBoxL.TabIndex = 0;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(150, 208);
            this.textBoxP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.PasswordChar = '*';
            this.textBoxP.Size = new System.Drawing.Size(180, 36);
            this.textBoxP.TabIndex = 1;
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Location = new System.Drawing.Point(71, 140);
            this.labelL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(62, 28);
            this.labelL.TabIndex = 2;
            this.labelL.Text = "Логин";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(62, 216);
            this.labelP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(71, 28);
            this.labelP.TabIndex = 3;
            this.labelP.Text = "Пароль";
            // 
            // buttonV
            // 
            this.buttonV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonV.Location = new System.Drawing.Point(39, 341);
            this.buttonV.Margin = new System.Windows.Forms.Padding(4);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(145, 62);
            this.buttonV.TabIndex = 4;
            this.buttonV.Text = "Войти";
            this.buttonV.UseVisualStyleBackColor = false;
            this.buttonV.Click += new System.EventHandler(this.buttonV_Click);
            // 
            // buttonZ
            // 
            this.buttonZ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonZ.Location = new System.Drawing.Point(223, 341);
            this.buttonZ.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(150, 62);
            this.buttonZ.TabIndex = 5;
            this.buttonZ.Text = "Закрыть";
            this.buttonZ.UseVisualStyleBackColor = false;
            this.buttonZ.Click += new System.EventHandler(this.buttonZ_Click);
            // 
            // raspisanieTableAdapter
            // 
            this.raspisanieTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SVToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(22, 84);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(388, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SVToolStripMenuItem
            // 
            this.SVToolStripMenuItem.Name = "SVToolStripMenuItem";
            this.SVToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.SVToolStripMenuItem.Text = "Сведенье";
            this.SVToolStripMenuItem.Click += new System.EventHandler(this.SVToolStripMenuItem_Click);
            // 
            // FormAV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::PlanZad.Properties.Resources._251783;
            this.ClientSize = new System.Drawing.Size(432, 431);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAV";
            this.Padding = new System.Windows.Forms.Padding(22, 84, 22, 28);
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormAV_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxL;
        public System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonZ;
        private Zad_PlanirDataSet17TableAdapters.RaspisanieTableAdapter raspisanieTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SVToolStripMenuItem;
    }
}

