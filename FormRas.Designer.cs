namespace PlanZad
{
    partial class FormRas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRas));
            this.TbRas = new System.Windows.Forms.TextBox();
            this.dataGridViewRas = new System.Windows.Forms.DataGridView();
            this.raspisanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zad_PlanirDataSet17 = new PlanZad.Zad_PlanirDataSet17();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.materialContextMenuStrip2 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сведеньеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VuhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zad_PlanirDataSet18 = new PlanZad.Zad_PlanirDataSet18();
            this.raspisanieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.raspisanieTableAdapter = new PlanZad.Zad_PlanirDataSet18TableAdapters.RaspisanieTableAdapter();
            this.buttonYR = new System.Windows.Forms.Button();
            this.buttonReR = new System.Windows.Forms.Button();
            this.buttonAdR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet17)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbRas
            // 
            this.TbRas.Location = new System.Drawing.Point(1257, 119);
            this.TbRas.Name = "TbRas";
            this.TbRas.Size = new System.Drawing.Size(100, 26);
            this.TbRas.TabIndex = 10;
            // 
            // dataGridViewRas
            // 
            this.dataGridViewRas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRas.Location = new System.Drawing.Point(12, 194);
            this.dataGridViewRas.Name = "dataGridViewRas";
            this.dataGridViewRas.RowHeadersWidth = 62;
            this.dataGridViewRas.RowTemplate.Height = 28;
            this.dataGridViewRas.Size = new System.Drawing.Size(787, 152);
            this.dataGridViewRas.TabIndex = 6;
            this.dataGridViewRas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DatagridZ);
            this.dataGridViewRas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DatagridZ1);
            // 
            // raspisanieBindingSource
            // 
            this.raspisanieBindingSource.DataMember = "Raspisanie";
            this.raspisanieBindingSource.DataSource = this.zad_PlanirDataSet17;
            // 
            // zad_PlanirDataSet17
            // 
            this.zad_PlanirDataSet17.DataSetName = "Zad_PlanirDataSet17";
            this.zad_PlanirDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // materialContextMenuStrip2
            // 
            this.materialContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip2.Depth = 0;
            this.materialContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.materialContextMenuStrip2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip2.Name = "materialContextMenuStrip2";
            this.materialContextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сведеньеToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // сведеньеToolStripMenuItem
            // 
            this.сведеньеToolStripMenuItem.Name = "сведеньеToolStripMenuItem";
            this.сведеньеToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.сведеньеToolStripMenuItem.Text = "Сведенье";
            this.сведеньеToolStripMenuItem.Click += new System.EventHandler(this.сведеньеToolStripMenuItem_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(868, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tToolStripMenuItem.BackgroundImage")));
            this.tToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zToolStripMenuItem,
            this.VuhToolStripMenuItem});
            this.tToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.tToolStripMenuItem.Text = "Таблицы";
            // 
            // zToolStripMenuItem
            // 
            this.zToolStripMenuItem.BackgroundImage = global::PlanZad.Properties.Resources.icons8_параллельные_задачи_96;
            this.zToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zToolStripMenuItem.Name = "zToolStripMenuItem";
            this.zToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.zToolStripMenuItem.Text = "Задачи";
            this.zToolStripMenuItem.Click += new System.EventHandler(this.zToolStripMenuItem_Click);
            // 
            // VuhToolStripMenuItem
            // 
            this.VuhToolStripMenuItem.Name = "VuhToolStripMenuItem";
            this.VuhToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.VuhToolStripMenuItem.Text = "Выход";
            this.VuhToolStripMenuItem.Click += new System.EventHandler(this.VuhToolStripMenuItem_Click);
            // 
            // zad_PlanirDataSet18
            // 
            this.zad_PlanirDataSet18.DataSetName = "Zad_PlanirDataSet18";
            this.zad_PlanirDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raspisanieBindingSource1
            // 
            this.raspisanieBindingSource1.DataMember = "Raspisanie";
            this.raspisanieBindingSource1.DataSource = this.zad_PlanirDataSet18;
            // 
            // raspisanieTableAdapter
            // 
            this.raspisanieTableAdapter.ClearBeforeFill = true;
            // 
            // buttonYR
            // 
            this.buttonYR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonYR.Image = global::PlanZad.Properties.Resources.icons8_удалить_64;
            this.buttonYR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonYR.Location = new System.Drawing.Point(384, 119);
            this.buttonYR.Name = "buttonYR";
            this.buttonYR.Size = new System.Drawing.Size(152, 69);
            this.buttonYR.TabIndex = 9;
            this.buttonYR.Text = "Удалить";
            this.buttonYR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYR.UseVisualStyleBackColor = false;
            this.buttonYR.Click += new System.EventHandler(this.buttonYR_Click);
            // 
            // buttonReR
            // 
            this.buttonReR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReR.Image = global::PlanZad.Properties.Resources.icons8_редактировать_64;
            this.buttonReR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReR.Location = new System.Drawing.Point(191, 119);
            this.buttonReR.Name = "buttonReR";
            this.buttonReR.Size = new System.Drawing.Size(187, 69);
            this.buttonReR.TabIndex = 8;
            this.buttonReR.Text = "Редактировать";
            this.buttonReR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReR.UseVisualStyleBackColor = false;
            this.buttonReR.Click += new System.EventHandler(this.buttonReR_Click);
            // 
            // buttonAdR
            // 
            this.buttonAdR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdR.Image = global::PlanZad.Properties.Resources.icons8_добавить_64;
            this.buttonAdR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdR.Location = new System.Drawing.Point(12, 119);
            this.buttonAdR.Name = "buttonAdR";
            this.buttonAdR.Size = new System.Drawing.Size(173, 69);
            this.buttonAdR.TabIndex = 7;
            this.buttonAdR.Text = "Добавить";
            this.buttonAdR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdR.UseVisualStyleBackColor = false;
            this.buttonAdR.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 378);
            this.Controls.Add(this.TbRas);
            this.Controls.Add(this.buttonYR);
            this.Controls.Add(this.buttonReR);
            this.Controls.Add(this.buttonAdR);
            this.Controls.Add(this.dataGridViewRas);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRas";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.FormRas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet17)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbRas;
        private System.Windows.Forms.Button buttonYR;
        private System.Windows.Forms.Button buttonReR;
        private System.Windows.Forms.Button buttonAdR;
        public System.Windows.Forms.DataGridView dataGridViewRas;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VuhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сведеньеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource raspisanieBindingSource;
        private Zad_PlanirDataSet17 zad_PlanirDataSet17;
        private Zad_PlanirDataSet18 zad_PlanirDataSet18;
        private System.Windows.Forms.BindingSource raspisanieBindingSource1;
        private Zad_PlanirDataSet18TableAdapters.RaspisanieTableAdapter raspisanieTableAdapter;
    }
}