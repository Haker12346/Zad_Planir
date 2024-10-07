namespace PlanZad
{
    partial class FormRedT
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
            this.LbI = new System.Windows.Forms.Label();
            this.LbN = new System.Windows.Forms.Label();
            this.LbO = new System.Windows.Forms.Label();
            this.LbNac = new System.Windows.Forms.Label();
            this.LbK = new System.Windows.Forms.Label();
            this.LbS = new System.Windows.Forms.Label();
            this.TbI = new System.Windows.Forms.TextBox();
            this.TbN = new System.Windows.Forms.TextBox();
            this.TbO = new System.Windows.Forms.TextBox();
            this.TbNac = new System.Windows.Forms.TextBox();
            this.TbK = new System.Windows.Forms.TextBox();
            this.CbS = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zad_PlanirDataSet16 = new PlanZad.Zad_PlanirDataSet16();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonOtn = new System.Windows.Forms.Button();
            this.statusTableAdapter = new PlanZad.Zad_PlanirDataSet16TableAdapters.StatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // LbI
            // 
            this.LbI.AutoSize = true;
            this.LbI.Location = new System.Drawing.Point(44, 147);
            this.LbI.Name = "LbI";
            this.LbI.Size = new System.Drawing.Size(24, 20);
            this.LbI.TabIndex = 0;
            this.LbI.Text = "№";
            this.LbI.Click += new System.EventHandler(this.LbI_Click);
            // 
            // LbN
            // 
            this.LbN.AutoSize = true;
            this.LbN.Location = new System.Drawing.Point(44, 188);
            this.LbN.Name = "LbN";
            this.LbN.Size = new System.Drawing.Size(122, 20);
            this.LbN.TabIndex = 1;
            this.LbN.Text = "Наименование";
            this.LbN.Click += new System.EventHandler(this.LbN_Click);
            // 
            // LbO
            // 
            this.LbO.AutoSize = true;
            this.LbO.Location = new System.Drawing.Point(44, 237);
            this.LbO.Name = "LbO";
            this.LbO.Size = new System.Drawing.Size(83, 20);
            this.LbO.TabIndex = 2;
            this.LbO.Text = "Описание";
            this.LbO.Click += new System.EventHandler(this.LbO_Click);
            // 
            // LbNac
            // 
            this.LbNac.AutoSize = true;
            this.LbNac.Location = new System.Drawing.Point(44, 289);
            this.LbNac.Name = "LbNac";
            this.LbNac.Size = new System.Drawing.Size(67, 20);
            this.LbNac.TabIndex = 3;
            this.LbNac.Text = "Начало";
            this.LbNac.Click += new System.EventHandler(this.LbNac_Click);
            // 
            // LbK
            // 
            this.LbK.AutoSize = true;
            this.LbK.Location = new System.Drawing.Point(44, 340);
            this.LbK.Name = "LbK";
            this.LbK.Size = new System.Drawing.Size(55, 20);
            this.LbK.TabIndex = 4;
            this.LbK.Text = "Конец";
            this.LbK.Click += new System.EventHandler(this.LbK_Click);
            // 
            // LbS
            // 
            this.LbS.AutoSize = true;
            this.LbS.Location = new System.Drawing.Point(44, 397);
            this.LbS.Name = "LbS";
            this.LbS.Size = new System.Drawing.Size(62, 20);
            this.LbS.TabIndex = 5;
            this.LbS.Text = "Статус";
            this.LbS.Click += new System.EventHandler(this.LbS_Click);
            // 
            // TbI
            // 
            this.TbI.Location = new System.Drawing.Point(209, 141);
            this.TbI.Name = "TbI";
            this.TbI.Size = new System.Drawing.Size(146, 26);
            this.TbI.TabIndex = 6;
            this.TbI.TextChanged += new System.EventHandler(this.TbI_TextChanged);
            // 
            // TbN
            // 
            this.TbN.Location = new System.Drawing.Point(209, 182);
            this.TbN.Name = "TbN";
            this.TbN.Size = new System.Drawing.Size(146, 26);
            this.TbN.TabIndex = 7;
            this.TbN.TextChanged += new System.EventHandler(this.TbN_TextChanged);
            // 
            // TbO
            // 
            this.TbO.Location = new System.Drawing.Point(209, 231);
            this.TbO.Name = "TbO";
            this.TbO.Size = new System.Drawing.Size(146, 26);
            this.TbO.TabIndex = 8;
            this.TbO.TextChanged += new System.EventHandler(this.TbO_TextChanged);
            // 
            // TbNac
            // 
            this.TbNac.Location = new System.Drawing.Point(209, 283);
            this.TbNac.Name = "TbNac";
            this.TbNac.Size = new System.Drawing.Size(146, 26);
            this.TbNac.TabIndex = 9;
            this.TbNac.TextChanged += new System.EventHandler(this.TbNac_TextChanged);
            // 
            // TbK
            // 
            this.TbK.Location = new System.Drawing.Point(209, 340);
            this.TbK.Name = "TbK";
            this.TbK.Size = new System.Drawing.Size(146, 26);
            this.TbK.TabIndex = 10;
            this.TbK.TextChanged += new System.EventHandler(this.TbK_TextChanged);
            // 
            // CbS
            // 
            this.CbS.DataSource = this.statusBindingSource;
            this.CbS.DisplayMember = "StatusID";
            this.CbS.FormattingEnabled = true;
            this.CbS.Location = new System.Drawing.Point(209, 394);
            this.CbS.Name = "CbS";
            this.CbS.Size = new System.Drawing.Size(146, 28);
            this.CbS.TabIndex = 11;
            this.CbS.ValueMember = "Naimenovanie";
            this.CbS.SelectedIndexChanged += new System.EventHandler(this.CbS_SelectedIndexChanged);
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.zad_PlanirDataSet16;
            // 
            // zad_PlanirDataSet16
            // 
            this.zad_PlanirDataSet16.DataSetName = "Zad_PlanirDataSet16";
            this.zad_PlanirDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonRed
            // 
            this.buttonRed.Location = new System.Drawing.Point(12, 477);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(160, 63);
            this.buttonRed.TabIndex = 12;
            this.buttonRed.Text = "Редактировать";
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOtn
            // 
            this.buttonOtn.Location = new System.Drawing.Point(210, 477);
            this.buttonOtn.Name = "buttonOtn";
            this.buttonOtn.Size = new System.Drawing.Size(165, 63);
            this.buttonOtn.TabIndex = 13;
            this.buttonOtn.Text = "Отменить";
            this.buttonOtn.UseVisualStyleBackColor = true;
            this.buttonOtn.Click += new System.EventHandler(this.buttonOtn_Click);
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // FormRedT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 552);
            this.Controls.Add(this.buttonOtn);
            this.Controls.Add(this.buttonRed);
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
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "FormRedT";
            this.Text = "Редактировать запись";
            this.Load += new System.EventHandler(this.FormRedT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbI;
        private System.Windows.Forms.Label LbN;
        private System.Windows.Forms.Label LbO;
        private System.Windows.Forms.Label LbNac;
        private System.Windows.Forms.Label LbK;
        private System.Windows.Forms.Label LbS;
        private System.Windows.Forms.TextBox TbI;
        private System.Windows.Forms.TextBox TbN;
        private System.Windows.Forms.TextBox TbO;
        private System.Windows.Forms.TextBox TbNac;
        private System.Windows.Forms.TextBox TbK;
        private System.Windows.Forms.ComboBox CbS;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonOtn;
        private Zad_PlanirDataSet16 zad_PlanirDataSet16;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private Zad_PlanirDataSet16TableAdapters.StatusTableAdapter statusTableAdapter;
    }
}