namespace PlanZad
{
    partial class FormOtl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOtl));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sotrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VuhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tb = new System.Windows.Forms.TextBox();
            this.buttonYd = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewOt = new System.Windows.Forms.DataGridView();
            this.deportamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zad_PlanirDataSet20 = new PlanZad.Zad_PlanirDataSet20();
            this.deportamentTableAdapter = new PlanZad.Zad_PlanirDataSet20TableAdapters.DeportamentTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deportamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet20)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(618, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tToolStripMenuItem.BackgroundImage")));
            this.tToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rToolStripMenuItem,
            this.sotrToolStripMenuItem,
            this.zToolStripMenuItem,
            this.sToolStripMenuItem,
            this.VuhToolStripMenuItem});
            this.tToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.tToolStripMenuItem.Text = "Таблицы";
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
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.BackgroundImage = global::PlanZad.Properties.Resources.icons8_ok_80;
            this.sToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.sToolStripMenuItem.Text = "Статус";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
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
            this.SvToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // SvToolStripMenuItem
            // 
            this.SvToolStripMenuItem.Name = "SvToolStripMenuItem";
            this.SvToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.SvToolStripMenuItem.Text = "Сведенье";
            this.SvToolStripMenuItem.Click += new System.EventHandler(this.сведеньеToolStripMenuItem_Click);
            // 
            // Tb
            // 
            this.Tb.Location = new System.Drawing.Point(1257, 117);
            this.Tb.Name = "Tb";
            this.Tb.Size = new System.Drawing.Size(100, 26);
            this.Tb.TabIndex = 10;
            // 
            // buttonYd
            // 
            this.buttonYd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonYd.Image = global::PlanZad.Properties.Resources.icons8_удалить_64;
            this.buttonYd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonYd.Location = new System.Drawing.Point(384, 103);
            this.buttonYd.Name = "buttonYd";
            this.buttonYd.Size = new System.Drawing.Size(176, 69);
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
            this.buttonRed.Location = new System.Drawing.Point(191, 103);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(187, 69);
            this.buttonRed.TabIndex = 8;
            this.buttonRed.Text = "Редактировать";
            this.buttonRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Image = global::PlanZad.Properties.Resources.icons8_добавить_64;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.Location = new System.Drawing.Point(12, 103);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(173, 69);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewOt
            // 
            this.dataGridViewOt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOt.Location = new System.Drawing.Point(142, 200);
            this.dataGridViewOt.Name = "dataGridViewOt";
            this.dataGridViewOt.RowHeadersWidth = 62;
            this.dataGridViewOt.RowTemplate.Height = 28;
            this.dataGridViewOt.Size = new System.Drawing.Size(339, 171);
            this.dataGridViewOt.TabIndex = 6;
            this.dataGridViewOt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Yg);
            this.dataGridViewOt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mag);
            // 
            // deportamentBindingSource
            // 
            this.deportamentBindingSource.DataMember = "Deportament";
            this.deportamentBindingSource.DataSource = this.zad_PlanirDataSet20;
            // 
            // zad_PlanirDataSet20
            // 
            this.zad_PlanirDataSet20.DataSetName = "Zad_PlanirDataSet20";
            this.zad_PlanirDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deportamentTableAdapter
            // 
            this.deportamentTableAdapter.ClearBeforeFill = true;
            // 
            // FormOtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 413);
            this.Controls.Add(this.Tb);
            this.Controls.Add(this.buttonYd);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewOt);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOtl";
            this.Text = "Отделы";
            this.Load += new System.EventHandler(this.FormOtl_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deportamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sotrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VuhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SvToolStripMenuItem;
        private System.Windows.Forms.TextBox Tb;
        private System.Windows.Forms.Button buttonYd;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.DataGridView dataGridViewOt;
        private Zad_PlanirDataSet20 zad_PlanirDataSet20;
        private System.Windows.Forms.BindingSource deportamentBindingSource;
        private Zad_PlanirDataSet20TableAdapters.DeportamentTableAdapter deportamentTableAdapter;
    }
}