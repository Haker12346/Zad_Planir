namespace PlanZad
{
    partial class FormStat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStat));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sotrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VuhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonYd = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewS = new System.Windows.Forms.DataGridView();
            this.zad_PlanirDataSet19 = new PlanZad.Zad_PlanirDataSet19();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new PlanZad.Zad_PlanirDataSet19TableAdapters.StatusTableAdapter();
            this.TbI = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tToolStripMenuItem.BackgroundImage")));
            this.tToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oToolStripMenuItem,
            this.sotrToolStripMenuItem,
            this.zToolStripMenuItem,
            this.rToolStripMenuItem,
            this.VuhToolStripMenuItem});
            this.tToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.tToolStripMenuItem.Text = "Таблицы";
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.BackgroundImage = global::PlanZad.Properties.Resources.icons8_отдел_96;
            this.oToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.oToolStripMenuItem.Text = "Отделы";
            this.oToolStripMenuItem.Click += new System.EventHandler(this.oToolStripMenuItem_Click);
            // 
            // sotrToolStripMenuItem
            // 
            this.sotrToolStripMenuItem.BackgroundImage = global::PlanZad.Properties.Resources.icons8_сотрудники_96;
            this.sotrToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sotrToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sotrToolStripMenuItem.Name = "sotrToolStripMenuItem";
            this.sotrToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.sotrToolStripMenuItem.Text = "Сотрудники";
            this.sotrToolStripMenuItem.Click += new System.EventHandler(this.sotrToolStripMenuItem_Click);
            // 
            // zToolStripMenuItem
            // 
            this.zToolStripMenuItem.BackgroundImage = global::PlanZad.Properties.Resources.icons8_параллельные_задачи_96;
            this.zToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zToolStripMenuItem.Name = "zToolStripMenuItem";
            this.zToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.zToolStripMenuItem.Text = "Задачи";
            this.zToolStripMenuItem.Click += new System.EventHandler(this.zToolStripMenuItem_Click);
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.BackgroundImage = global::PlanZad.Properties.Resources.icons8_расписание_96;
            this.rToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.rToolStripMenuItem.Text = "Расписание";
            this.rToolStripMenuItem.Click += new System.EventHandler(this.rToolStripMenuItem_Click);
            // 
            // VuhToolStripMenuItem
            // 
            this.VuhToolStripMenuItem.Name = "VuhToolStripMenuItem";
            this.VuhToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.VuhToolStripMenuItem.Text = "Выход";
            this.VuhToolStripMenuItem.Click += new System.EventHandler(this.VuhToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // SToolStripMenuItem
            // 
            this.SToolStripMenuItem.Name = "SToolStripMenuItem";
            this.SToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.SToolStripMenuItem.Text = "Сведенье";
            this.SToolStripMenuItem.Click += new System.EventHandler(this.SToolStripMenuItem_Click);
            // 
            // buttonYd
            // 
            this.buttonYd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonYd.Image = global::PlanZad.Properties.Resources.icons8_удалить_64;
            this.buttonYd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonYd.Location = new System.Drawing.Point(407, 116);
            this.buttonYd.Name = "buttonYd";
            this.buttonYd.Size = new System.Drawing.Size(152, 69);
            this.buttonYd.TabIndex = 9;
            this.buttonYd.Text = "Удалить";
            this.buttonYd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYd.UseVisualStyleBackColor = false;
            this.buttonYd.Click += new System.EventHandler(this.buttonYd_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRed.Image = global::PlanZad.Properties.Resources.icons8_редактировать_64;
            this.buttonRed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRed.Location = new System.Drawing.Point(214, 116);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(187, 69);
            this.buttonRed.TabIndex = 8;
            this.buttonRed.Text = "Редактировать";
            this.buttonRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Image = global::PlanZad.Properties.Resources.icons8_добавить_64;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.Location = new System.Drawing.Point(35, 116);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(173, 69);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewS
            // 
            this.dataGridViewS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewS.Location = new System.Drawing.Point(197, 194);
            this.dataGridViewS.Name = "dataGridViewS";
            this.dataGridViewS.RowHeadersWidth = 62;
            this.dataGridViewS.RowTemplate.Height = 28;
            this.dataGridViewS.Size = new System.Drawing.Size(213, 227);
            this.dataGridViewS.TabIndex = 6;
            this.dataGridViewS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Sever);
            this.dataGridViewS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Vostok);
            // 
            // zad_PlanirDataSet19
            // 
            this.zad_PlanirDataSet19.DataSetName = "Zad_PlanirDataSet19";
            this.zad_PlanirDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.zad_PlanirDataSet19;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // TbI
            // 
            this.TbI.Location = new System.Drawing.Point(714, 171);
            this.TbI.Name = "TbI";
            this.TbI.Size = new System.Drawing.Size(100, 26);
            this.TbI.TabIndex = 10;
            // 
            // FormStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 458);
            this.Controls.Add(this.TbI);
            this.Controls.Add(this.buttonYd);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewS);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStat";
            this.Text = "Статус";
            this.Load += new System.EventHandler(this.FormStat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sotrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VuhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SToolStripMenuItem;
        private System.Windows.Forms.Button buttonYd;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.DataGridView dataGridViewS;
        private Zad_PlanirDataSet19 zad_PlanirDataSet19;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private Zad_PlanirDataSet19TableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.TextBox TbI;
    }
}