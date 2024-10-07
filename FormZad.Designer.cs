namespace PlanZad
{
    partial class FormZad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VuhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительныеФункцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SvedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTask = new System.Windows.Forms.TextBox();
            this.buttonYd = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewTas = new System.Windows.Forms.DataGridView();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zad_PlanirDataSet13 = new PlanZad.Zad_PlanirDataSet13();
            this.tasksTableAdapter = new PlanZad.Zad_PlanirDataSet13TableAdapters.TasksTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tToolStripMenuItem,
            this.дополнительныеФункцииToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tToolStripMenuItem.BackgroundImage")));
            this.tToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rToolStripMenuItem,
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
            this.rToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.rToolStripMenuItem.Text = "Расписание";
            this.rToolStripMenuItem.Click += new System.EventHandler(this.rToolStripMenuItem_Click);
            // 
            // VuhToolStripMenuItem
            // 
            this.VuhToolStripMenuItem.Name = "VuhToolStripMenuItem";
            this.VuhToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.VuhToolStripMenuItem.Text = "Выход";
            this.VuhToolStripMenuItem.Click += new System.EventHandler(this.VuhToolStripMenuItem_Click);
            // 
            // дополнительныеФункцииToolStripMenuItem
            // 
            this.дополнительныеФункцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZdToolStripMenuItem,
            this.PvToolStripMenuItem});
            this.дополнительныеФункцииToolStripMenuItem.Name = "дополнительныеФункцииToolStripMenuItem";
            this.дополнительныеФункцииToolStripMenuItem.Size = new System.Drawing.Size(243, 29);
            this.дополнительныеФункцииToolStripMenuItem.Text = "Дополнительные функции";
            // 
            // ZdToolStripMenuItem
            // 
            this.ZdToolStripMenuItem.Name = "ZdToolStripMenuItem";
            this.ZdToolStripMenuItem.Size = new System.Drawing.Size(327, 34);
            this.ZdToolStripMenuItem.Text = "Срок задачи";
            this.ZdToolStripMenuItem.Click += new System.EventHandler(this.ZdToolStripMenuItem_Click);
            // 
            // PvToolStripMenuItem
            // 
            this.PvToolStripMenuItem.Name = "PvToolStripMenuItem";
            this.PvToolStripMenuItem.Size = new System.Drawing.Size(327, 34);
            this.PvToolStripMenuItem.Text = "Проверка на выполнение";
            this.PvToolStripMenuItem.Click += new System.EventHandler(this.PvToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SvedToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // SvedToolStripMenuItem
            // 
            this.SvedToolStripMenuItem.Name = "SvedToolStripMenuItem";
            this.SvedToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.SvedToolStripMenuItem.Text = "Сведенье";
            this.SvedToolStripMenuItem.Click += new System.EventHandler(this.SvedToolStripMenuItem_Click);
            // 
            // tbTask
            // 
            this.tbTask.Location = new System.Drawing.Point(1241, 112);
            this.tbTask.Name = "tbTask";
            this.tbTask.Size = new System.Drawing.Size(100, 26);
            this.tbTask.TabIndex = 10;
            // 
            // buttonYd
            // 
            this.buttonYd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonYd.Image = global::PlanZad.Properties.Resources.icons8_удалить_64;
            this.buttonYd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonYd.Location = new System.Drawing.Point(403, 115);
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
            this.buttonRed.Location = new System.Drawing.Point(210, 115);
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
            this.buttonAdd.Location = new System.Drawing.Point(31, 115);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(173, 69);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTas
            // 
            this.dataGridViewTas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTas.Location = new System.Drawing.Point(31, 190);
            this.dataGridViewTas.Name = "dataGridViewTas";
            this.dataGridViewTas.RowHeadersWidth = 62;
            this.dataGridViewTas.RowTemplate.Height = 28;
            this.dataGridViewTas.Size = new System.Drawing.Size(774, 430);
            this.dataGridViewTas.TabIndex = 6;
            this.dataGridViewTas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgVtas);
            this.dataGridViewTas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgVtask);
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.zad_PlanirDataSet13;
            // 
            // zad_PlanirDataSet13
            // 
            this.zad_PlanirDataSet13.DataSetName = "Zad_PlanirDataSet13";
            this.zad_PlanirDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // FormZad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 667);
            this.Controls.Add(this.tbTask);
            this.Controls.Add(this.buttonYd);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewTas);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormZad";
            this.Text = "Задачи";
            this.Load += new System.EventHandler(this.FormZad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VuhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительныеФункцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SvedToolStripMenuItem;
        private System.Windows.Forms.TextBox tbTask;
        private System.Windows.Forms.Button buttonYd;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.DataGridView dataGridViewTas;
        private Zad_PlanirDataSet13 zad_PlanirDataSet13;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private Zad_PlanirDataSet13TableAdapters.TasksTableAdapter tasksTableAdapter;
    }
}