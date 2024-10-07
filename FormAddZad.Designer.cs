namespace PlanZad
{
    partial class FormAddT
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
            this.buttonOtn = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.CbS = new System.Windows.Forms.ComboBox();
            this.statusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zad_PlanirDataSet15 = new PlanZad.Zad_PlanirDataSet15();
            this.TbK = new System.Windows.Forms.TextBox();
            this.TbNac = new System.Windows.Forms.TextBox();
            this.TbO = new System.Windows.Forms.TextBox();
            this.TbN = new System.Windows.Forms.TextBox();
            this.TbI = new System.Windows.Forms.TextBox();
            this.LbS = new System.Windows.Forms.Label();
            this.LbK = new System.Windows.Forms.Label();
            this.LbNac = new System.Windows.Forms.Label();
            this.LbO = new System.Windows.Forms.Label();
            this.LbN = new System.Windows.Forms.Label();
            this.LbI = new System.Windows.Forms.Label();
            this.zad_PlanirDataSet14 = new PlanZad.Zad_PlanirDataSet14();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new PlanZad.Zad_PlanirDataSet14TableAdapters.StatusTableAdapter();
            this.statusTableAdapter1 = new PlanZad.Zad_PlanirDataSet15TableAdapters.StatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOtn
            // 
            this.buttonOtn.Location = new System.Drawing.Point(232, 441);
            this.buttonOtn.Name = "buttonOtn";
            this.buttonOtn.Size = new System.Drawing.Size(140, 63);
            this.buttonOtn.TabIndex = 27;
            this.buttonOtn.Text = "Отменить";
            this.buttonOtn.UseVisualStyleBackColor = true;
            this.buttonOtn.Click += new System.EventHandler(this.buttonOtn_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(49, 441);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(135, 63);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // CbS
            // 
            this.CbS.DataSource = this.statusBindingSource1;
            this.CbS.DisplayMember = "StatusID";
            this.CbS.FormattingEnabled = true;
            this.CbS.Location = new System.Drawing.Point(210, 359);
            this.CbS.Name = "CbS";
            this.CbS.Size = new System.Drawing.Size(121, 28);
            this.CbS.TabIndex = 25;
            this.CbS.ValueMember = "Naimenovanie";
            // 
            // statusBindingSource1
            // 
            this.statusBindingSource1.DataMember = "Status";
            this.statusBindingSource1.DataSource = this.zad_PlanirDataSet15;
            // 
            // zad_PlanirDataSet15
            // 
            this.zad_PlanirDataSet15.DataSetName = "Zad_PlanirDataSet15";
            this.zad_PlanirDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TbK
            // 
            this.TbK.Location = new System.Drawing.Point(210, 305);
            this.TbK.Name = "TbK";
            this.TbK.Size = new System.Drawing.Size(121, 26);
            this.TbK.TabIndex = 24;
            // 
            // TbNac
            // 
            this.TbNac.Location = new System.Drawing.Point(210, 248);
            this.TbNac.Name = "TbNac";
            this.TbNac.Size = new System.Drawing.Size(121, 26);
            this.TbNac.TabIndex = 23;
            // 
            // TbO
            // 
            this.TbO.Location = new System.Drawing.Point(210, 196);
            this.TbO.Name = "TbO";
            this.TbO.Size = new System.Drawing.Size(121, 26);
            this.TbO.TabIndex = 22;
            // 
            // TbN
            // 
            this.TbN.Location = new System.Drawing.Point(210, 147);
            this.TbN.Name = "TbN";
            this.TbN.Size = new System.Drawing.Size(121, 26);
            this.TbN.TabIndex = 21;
            // 
            // TbI
            // 
            this.TbI.Location = new System.Drawing.Point(210, 106);
            this.TbI.Name = "TbI";
            this.TbI.Size = new System.Drawing.Size(121, 26);
            this.TbI.TabIndex = 20;
            // 
            // LbS
            // 
            this.LbS.AutoSize = true;
            this.LbS.Location = new System.Drawing.Point(45, 362);
            this.LbS.Name = "LbS";
            this.LbS.Size = new System.Drawing.Size(62, 20);
            this.LbS.TabIndex = 19;
            this.LbS.Text = "Статус";
            // 
            // LbK
            // 
            this.LbK.AutoSize = true;
            this.LbK.Location = new System.Drawing.Point(45, 305);
            this.LbK.Name = "LbK";
            this.LbK.Size = new System.Drawing.Size(55, 20);
            this.LbK.TabIndex = 18;
            this.LbK.Text = "Конец";
            // 
            // LbNac
            // 
            this.LbNac.AutoSize = true;
            this.LbNac.Location = new System.Drawing.Point(45, 254);
            this.LbNac.Name = "LbNac";
            this.LbNac.Size = new System.Drawing.Size(67, 20);
            this.LbNac.TabIndex = 17;
            this.LbNac.Text = "Начало";
            // 
            // LbO
            // 
            this.LbO.AutoSize = true;
            this.LbO.Location = new System.Drawing.Point(45, 202);
            this.LbO.Name = "LbO";
            this.LbO.Size = new System.Drawing.Size(83, 20);
            this.LbO.TabIndex = 16;
            this.LbO.Text = "Описание";
            // 
            // LbN
            // 
            this.LbN.AutoSize = true;
            this.LbN.Location = new System.Drawing.Point(45, 153);
            this.LbN.Name = "LbN";
            this.LbN.Size = new System.Drawing.Size(122, 20);
            this.LbN.TabIndex = 15;
            this.LbN.Text = "Наименование";
            // 
            // LbI
            // 
            this.LbI.AutoSize = true;
            this.LbI.Location = new System.Drawing.Point(45, 112);
            this.LbI.Name = "LbI";
            this.LbI.Size = new System.Drawing.Size(24, 20);
            this.LbI.TabIndex = 14;
            this.LbI.Text = "№";
            // 
            // zad_PlanirDataSet14
            // 
            this.zad_PlanirDataSet14.DataSetName = "Zad_PlanirDataSet14";
            this.zad_PlanirDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.zad_PlanirDataSet14;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter1
            // 
            this.statusTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAddT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 530);
            this.Controls.Add(this.buttonOtn);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.CbS);
            this.Controls.Add(this.TbK);
            this.Controls.Add(this.TbNac);
            this.Controls.Add(this.TbO);
            this.Controls.Add(this.TbN);
            this.Controls.Add(this.TbI);
            this.Controls.Add(this.LbS);
            this.Controls.Add(this.LbK);
            this.Controls.Add(this.LbNac);
            this.Controls.Add(this.LbO);
            this.Controls.Add(this.LbN);
            this.Controls.Add(this.LbI);
            this.ForeColor = System.Drawing.Color.Orchid;
            this.Name = "FormAddT";
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.FormAddT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOtn;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox CbS;
        private System.Windows.Forms.TextBox TbK;
        private System.Windows.Forms.TextBox TbNac;
        private System.Windows.Forms.TextBox TbO;
        private System.Windows.Forms.TextBox TbN;
        private System.Windows.Forms.TextBox TbI;
        private System.Windows.Forms.Label LbS;
        private System.Windows.Forms.Label LbK;
        private System.Windows.Forms.Label LbNac;
        private System.Windows.Forms.Label LbO;
        private System.Windows.Forms.Label LbN;
        private System.Windows.Forms.Label LbI;
        private Zad_PlanirDataSet14 zad_PlanirDataSet14;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private Zad_PlanirDataSet14TableAdapters.StatusTableAdapter statusTableAdapter;
        private Zad_PlanirDataSet15 zad_PlanirDataSet15;
        private System.Windows.Forms.BindingSource statusBindingSource1;
        private Zad_PlanirDataSet15TableAdapters.StatusTableAdapter statusTableAdapter1;
    }
}