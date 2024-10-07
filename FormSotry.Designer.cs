namespace PlanZad
{
    partial class FormSotry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSotry));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VuhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SvedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewSot = new System.Windows.Forms.DataGridView();
            this.sotrud2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zad_PlanirDataSet7 = new PlanZad.Zad_PlanirDataSet7();
            this.sotrud2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zad_PlanirDataSet6 = new PlanZad.Zad_PlanirDataSet6();
            this.sotrudBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zad_PlanirDataSet1 = new PlanZad.Zad_PlanirDataSet1();
            this.tbDelSotr = new System.Windows.Forms.TextBox();
            this.zad_PlanirDataSet = new PlanZad.Zad_PlanirDataSet();
            this.sotrudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelsotr = new System.Windows.Forms.Button();
            this.buttonRedsotr = new System.Windows.Forms.Button();
            this.buttonAddsort = new System.Windows.Forms.Button();
            this.sotrudTableAdapter = new PlanZad.Zad_PlanirDataSet1TableAdapters.SotrudTableAdapter();
            this.sotrud2TableAdapter = new PlanZad.Zad_PlanirDataSet6TableAdapters.Sotrud2TableAdapter();
            this.sotrud2TableAdapter1 = new PlanZad.Zad_PlanirDataSet7TableAdapters.Sotrud2TableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrud2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrud2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tToolStripMenuItem,
            this.ProgToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1742, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tToolStripMenuItem.BackgroundImage")));
            this.tToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oToolStripMenuItem,
            this.zToolStripMenuItem,
            this.rToolStripMenuItem,
            this.sToolStripMenuItem,
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
            this.oToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.oToolStripMenuItem.Text = "Отделы";
            this.oToolStripMenuItem.Click += new System.EventHandler(this.oToolStripMenuItem_Click);
            // 
            // zToolStripMenuItem
            // 
            this.zToolStripMenuItem.BackgroundImage = global::PlanZad.Properties.Resources.icons8_параллельные_задачи_96;
            this.zToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zToolStripMenuItem.Name = "zToolStripMenuItem";
            this.zToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.zToolStripMenuItem.Text = "Задачи";
            this.zToolStripMenuItem.Click += new System.EventHandler(this.zToolStripMenuItem_Click);
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.BackgroundImage = global::PlanZad.Properties.Resources.icons8_расписание_96;
            this.rToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.rToolStripMenuItem.Text = "Расписание";
            this.rToolStripMenuItem.Click += new System.EventHandler(this.rToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.BackgroundImage = global::PlanZad.Properties.Resources.icons8_ok_80;
            this.sToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.sToolStripMenuItem.Text = "Статус";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // VuhToolStripMenuItem
            // 
            this.VuhToolStripMenuItem.Name = "VuhToolStripMenuItem";
            this.VuhToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.VuhToolStripMenuItem.Text = "Выход";
            this.VuhToolStripMenuItem.Click += new System.EventHandler(this.VuhToolStripMenuItem_Click);
            // 
            // ProgToolStripMenuItem
            // 
            this.ProgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SvedToolStripMenuItem});
            this.ProgToolStripMenuItem.Name = "ProgToolStripMenuItem";
            this.ProgToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.ProgToolStripMenuItem.Text = "О программе";
            // 
            // SvedToolStripMenuItem
            // 
            this.SvedToolStripMenuItem.Name = "SvedToolStripMenuItem";
            this.SvedToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.SvedToolStripMenuItem.Text = "Сведенье";
            this.SvedToolStripMenuItem.Click += new System.EventHandler(this.SvedToolStripMenuItem_Click);
            // 
            // dataGridViewSot
            // 
            this.dataGridViewSot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSot.Location = new System.Drawing.Point(12, 204);
            this.dataGridViewSot.Name = "dataGridViewSot";
            this.dataGridViewSot.RowHeadersWidth = 62;
            this.dataGridViewSot.RowTemplate.Height = 28;
            this.dataGridViewSot.Size = new System.Drawing.Size(1718, 286);
            this.dataGridViewSot.TabIndex = 1;
            this.dataGridViewSot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewSotrud_MouseClick);
            this.dataGridViewSot.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewSotrud_MouseDoubleClick);
            // 
            // sotrud2BindingSource1
            // 
            this.sotrud2BindingSource1.DataMember = "Sotrud2";
            this.sotrud2BindingSource1.DataSource = this.zad_PlanirDataSet7;
            // 
            // zad_PlanirDataSet7
            // 
            this.zad_PlanirDataSet7.DataSetName = "Zad_PlanirDataSet7";
            this.zad_PlanirDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrud2BindingSource
            // 
            this.sotrud2BindingSource.DataMember = "Sotrud2";
            this.sotrud2BindingSource.DataSource = this.zad_PlanirDataSet6;
            // 
            // zad_PlanirDataSet6
            // 
            this.zad_PlanirDataSet6.DataSetName = "Zad_PlanirDataSet6";
            this.zad_PlanirDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudBindingSource1
            // 
            this.sotrudBindingSource1.DataMember = "Sotrud";
            this.sotrudBindingSource1.DataSource = this.zad_PlanirDataSet1;
            // 
            // zad_PlanirDataSet1
            // 
            this.zad_PlanirDataSet1.DataSetName = "Zad_PlanirDataSet1";
            this.zad_PlanirDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbDelSotr
            // 
            this.tbDelSotr.Location = new System.Drawing.Point(1884, 89);
            this.tbDelSotr.Name = "tbDelSotr";
            this.tbDelSotr.Size = new System.Drawing.Size(100, 26);
            this.tbDelSotr.TabIndex = 5;
            this.tbDelSotr.TextChanged += new System.EventHandler(this.tbDelSotr_TextChanged);
            // 
            // zad_PlanirDataSet
            // 
            this.zad_PlanirDataSet.DataSetName = "Zad_PlanirDataSet";
            this.zad_PlanirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudBindingSource
            // 
            this.sotrudBindingSource.DataMember = "Sotrud";
            this.sotrudBindingSource.DataSource = this.zad_PlanirDataSet;
            // 
            // buttonDelsotr
            // 
            this.buttonDelsotr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelsotr.Image = global::PlanZad.Properties.Resources.icons8_удалить_64;
            this.buttonDelsotr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelsotr.Location = new System.Drawing.Point(404, 104);
            this.buttonDelsotr.Name = "buttonDelsotr";
            this.buttonDelsotr.Size = new System.Drawing.Size(152, 69);
            this.buttonDelsotr.TabIndex = 4;
            this.buttonDelsotr.Text = "Удалить";
            this.buttonDelsotr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelsotr.UseVisualStyleBackColor = false;
            this.buttonDelsotr.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonRedsotr
            // 
            this.buttonRedsotr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRedsotr.Image = global::PlanZad.Properties.Resources.icons8_редактировать_64;
            this.buttonRedsotr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRedsotr.Location = new System.Drawing.Point(211, 104);
            this.buttonRedsotr.Name = "buttonRedsotr";
            this.buttonRedsotr.Size = new System.Drawing.Size(187, 69);
            this.buttonRedsotr.TabIndex = 3;
            this.buttonRedsotr.Text = "Редактировать";
            this.buttonRedsotr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRedsotr.UseVisualStyleBackColor = false;
            this.buttonRedsotr.Click += new System.EventHandler(this.buttonRedsotr_Click);
            // 
            // buttonAddsort
            // 
            this.buttonAddsort.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddsort.Image = global::PlanZad.Properties.Resources.icons8_добавить_64;
            this.buttonAddsort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddsort.Location = new System.Drawing.Point(32, 104);
            this.buttonAddsort.Name = "buttonAddsort";
            this.buttonAddsort.Size = new System.Drawing.Size(173, 69);
            this.buttonAddsort.TabIndex = 2;
            this.buttonAddsort.Text = "Добавить";
            this.buttonAddsort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddsort.UseVisualStyleBackColor = false;
            this.buttonAddsort.Click += new System.EventHandler(this.buttonAddsort_Click);
            // 
            // sotrudTableAdapter
            // 
            this.sotrudTableAdapter.ClearBeforeFill = true;
            // 
            // sotrud2TableAdapter
            // 
            this.sotrud2TableAdapter.ClearBeforeFill = true;
            // 
            // sotrud2TableAdapter1
            // 
            this.sotrud2TableAdapter1.ClearBeforeFill = true;
            // 
            // FormSotry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 579);
            this.Controls.Add(this.tbDelSotr);
            this.Controls.Add(this.buttonDelsotr);
            this.Controls.Add(this.buttonRedsotr);
            this.Controls.Add(this.buttonAddsort);
            this.Controls.Add(this.dataGridViewSot);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSotry";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.FormSotry_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrud2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrud2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SvedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VuhToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridViewSot;
        private System.Windows.Forms.Button buttonAddsort;
        private System.Windows.Forms.Button buttonRedsotr;
        private System.Windows.Forms.Button buttonDelsotr;
        private System.Windows.Forms.TextBox tbDelSotr;
        private System.Windows.Forms.BindingSource sotrudBindingSource;
        public Zad_PlanirDataSet zad_PlanirDataSet;
        private Zad_PlanirDataSet1 zad_PlanirDataSet1;
        private System.Windows.Forms.BindingSource sotrudBindingSource1;
        private Zad_PlanirDataSet1TableAdapters.SotrudTableAdapter sotrudTableAdapter;
        private Zad_PlanirDataSet6 zad_PlanirDataSet6;
        private System.Windows.Forms.BindingSource sotrud2BindingSource;
        private Zad_PlanirDataSet6TableAdapters.Sotrud2TableAdapter sotrud2TableAdapter;
        private Zad_PlanirDataSet7 zad_PlanirDataSet7;
        private System.Windows.Forms.BindingSource sotrud2BindingSource1;
        private Zad_PlanirDataSet7TableAdapters.Sotrud2TableAdapter sotrud2TableAdapter1;
    }
}