namespace PlanZad
{
    partial class FormAddSot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSot));
            this.deportamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zad_PlanirDataSet2 = new PlanZad.Zad_PlanirDataSet2();
            this.kladrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zad_PlanirDataSet3 = new PlanZad.Zad_PlanirDataSet3();
            this.deportamentTableAdapter = new PlanZad.Zad_PlanirDataSet2TableAdapters.DeportamentTableAdapter();
            this.kladrTableAdapter = new PlanZad.Zad_PlanirDataSet3TableAdapters.KladrTableAdapter();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonOt = new System.Windows.Forms.Button();
            this.LbI = new System.Windows.Forms.Label();
            this.LbF = new System.Windows.Forms.Label();
            this.LbN = new System.Windows.Forms.Label();
            this.LbO = new System.Windows.Forms.Label();
            this.LbR = new System.Windows.Forms.Label();
            this.LbL = new System.Windows.Forms.Label();
            this.LbP = new System.Windows.Forms.Label();
            this.LbOb = new System.Windows.Forms.Label();
            this.LbG = new System.Windows.Forms.Label();
            this.LbY = new System.Windows.Forms.Label();
            this.LbD = new System.Windows.Forms.Label();
            this.TbP = new System.Windows.Forms.TextBox();
            this.TbL = new System.Windows.Forms.TextBox();
            this.TbR = new System.Windows.Forms.TextBox();
            this.TbN = new System.Windows.Forms.TextBox();
            this.TbF = new System.Windows.Forms.TextBox();
            this.TbI = new System.Windows.Forms.TextBox();
            this.CbOb = new System.Windows.Forms.ComboBox();
            this.CbO = new System.Windows.Forms.ComboBox();
            this.deportamentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.zad_PlanirDataSet10 = new PlanZad.Zad_PlanirDataSet10();
            this.CbY = new System.Windows.Forms.ComboBox();
            this.CbG = new System.Windows.Forms.ComboBox();
            this.CbD = new System.Windows.Forms.ComboBox();
            this.zad_PlanirDataSet8 = new PlanZad.Zad_PlanirDataSet8();
            this.deportamentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deportamentTableAdapter1 = new PlanZad.Zad_PlanirDataSet8TableAdapters.DeportamentTableAdapter();
            this.deportamentTableAdapter2 = new PlanZad.Zad_PlanirDataSet10TableAdapters.DeportamentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.deportamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kladrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deportamentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deportamentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // deportamentBindingSource
            // 
            this.deportamentBindingSource.DataMember = "Deportament";
            this.deportamentBindingSource.DataSource = this.zad_PlanirDataSet2;
            // 
            // zad_PlanirDataSet2
            // 
            this.zad_PlanirDataSet2.DataSetName = "Zad_PlanirDataSet2";
            this.zad_PlanirDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kladrBindingSource
            // 
            this.kladrBindingSource.DataMember = "Kladr";
            this.kladrBindingSource.DataSource = this.zad_PlanirDataSet3;
            // 
            // zad_PlanirDataSet3
            // 
            this.zad_PlanirDataSet3.DataSetName = "Zad_PlanirDataSet3";
            this.zad_PlanirDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deportamentTableAdapter
            // 
            this.deportamentTableAdapter.ClearBeforeFill = true;
            // 
            // kladrTableAdapter
            // 
            this.kladrTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(12, 568);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(184, 67);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click_1);
            // 
            // ButtonOt
            // 
            this.ButtonOt.Location = new System.Drawing.Point(239, 568);
            this.ButtonOt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonOt.Name = "ButtonOt";
            this.ButtonOt.Size = new System.Drawing.Size(188, 67);
            this.ButtonOt.TabIndex = 1;
            this.ButtonOt.Text = "Отмена";
            this.ButtonOt.UseVisualStyleBackColor = true;
            this.ButtonOt.Click += new System.EventHandler(this.button2_Click);
            // 
            // LbI
            // 
            this.LbI.AutoSize = true;
            this.LbI.Location = new System.Drawing.Point(53, 125);
            this.LbI.Name = "LbI";
            this.LbI.Size = new System.Drawing.Size(28, 22);
            this.LbI.TabIndex = 2;
            this.LbI.Text = "№";
            // 
            // LbF
            // 
            this.LbF.AutoSize = true;
            this.LbF.Location = new System.Drawing.Point(53, 162);
            this.LbF.Name = "LbF";
            this.LbF.Size = new System.Drawing.Size(88, 22);
            this.LbF.TabIndex = 3;
            this.LbF.Text = "Фамилия";
            // 
            // LbN
            // 
            this.LbN.AutoSize = true;
            this.LbN.Location = new System.Drawing.Point(56, 199);
            this.LbN.Name = "LbN";
            this.LbN.Size = new System.Drawing.Size(45, 22);
            this.LbN.TabIndex = 4;
            this.LbN.Text = "Имя";
            // 
            // LbO
            // 
            this.LbO.AutoSize = true;
            this.LbO.Location = new System.Drawing.Point(55, 236);
            this.LbO.Name = "LbO";
            this.LbO.Size = new System.Drawing.Size(59, 22);
            this.LbO.TabIndex = 5;
            this.LbO.Text = "Отдел";
            this.LbO.Click += new System.EventHandler(this.LbO_Click);
            // 
            // LbR
            // 
            this.LbR.AutoSize = true;
            this.LbR.Location = new System.Drawing.Point(56, 274);
            this.LbR.Name = "LbR";
            this.LbR.Size = new System.Drawing.Size(48, 22);
            this.LbR.TabIndex = 7;
            this.LbR.Text = "Роль";
            // 
            // LbL
            // 
            this.LbL.AutoSize = true;
            this.LbL.Location = new System.Drawing.Point(53, 311);
            this.LbL.Name = "LbL";
            this.LbL.Size = new System.Drawing.Size(61, 22);
            this.LbL.TabIndex = 8;
            this.LbL.Text = "Логин";
            // 
            // LbP
            // 
            this.LbP.AutoSize = true;
            this.LbP.Location = new System.Drawing.Point(53, 348);
            this.LbP.Name = "LbP";
            this.LbP.Size = new System.Drawing.Size(70, 22);
            this.LbP.TabIndex = 9;
            this.LbP.Text = "Пароль";
            // 
            // LbOb
            // 
            this.LbOb.AutoSize = true;
            this.LbOb.Location = new System.Drawing.Point(56, 385);
            this.LbOb.Name = "LbOb";
            this.LbOb.Size = new System.Drawing.Size(77, 22);
            this.LbOb.TabIndex = 10;
            this.LbOb.Text = "Область";
            // 
            // LbG
            // 
            this.LbG.AutoSize = true;
            this.LbG.Location = new System.Drawing.Point(56, 423);
            this.LbG.Name = "LbG";
            this.LbG.Size = new System.Drawing.Size(58, 22);
            this.LbG.TabIndex = 11;
            this.LbG.Text = "Город";
            // 
            // LbY
            // 
            this.LbY.AutoSize = true;
            this.LbY.Location = new System.Drawing.Point(53, 461);
            this.LbY.Name = "LbY";
            this.LbY.Size = new System.Drawing.Size(61, 22);
            this.LbY.TabIndex = 12;
            this.LbY.Text = "Улица";
            // 
            // LbD
            // 
            this.LbD.AutoSize = true;
            this.LbD.Location = new System.Drawing.Point(55, 499);
            this.LbD.Name = "LbD";
            this.LbD.Size = new System.Drawing.Size(45, 22);
            this.LbD.TabIndex = 13;
            this.LbD.Text = "Дом";
            // 
            // TbP
            // 
            this.TbP.Location = new System.Drawing.Point(192, 348);
            this.TbP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbP.Name = "TbP";
            this.TbP.Size = new System.Drawing.Size(134, 29);
            this.TbP.TabIndex = 14;
            // 
            // TbL
            // 
            this.TbL.Location = new System.Drawing.Point(192, 311);
            this.TbL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbL.Name = "TbL";
            this.TbL.Size = new System.Drawing.Size(134, 29);
            this.TbL.TabIndex = 15;
            // 
            // TbR
            // 
            this.TbR.Location = new System.Drawing.Point(192, 274);
            this.TbR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbR.Name = "TbR";
            this.TbR.Size = new System.Drawing.Size(134, 29);
            this.TbR.TabIndex = 16;
            // 
            // TbN
            // 
            this.TbN.Location = new System.Drawing.Point(192, 199);
            this.TbN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbN.Name = "TbN";
            this.TbN.Size = new System.Drawing.Size(134, 29);
            this.TbN.TabIndex = 17;
            // 
            // TbF
            // 
            this.TbF.Location = new System.Drawing.Point(192, 162);
            this.TbF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbF.Name = "TbF";
            this.TbF.Size = new System.Drawing.Size(134, 29);
            this.TbF.TabIndex = 18;
            // 
            // TbI
            // 
            this.TbI.Location = new System.Drawing.Point(192, 125);
            this.TbI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbI.Name = "TbI";
            this.TbI.Size = new System.Drawing.Size(134, 29);
            this.TbI.TabIndex = 19;
            // 
            // CbOb
            // 
            this.CbOb.FormattingEnabled = true;
            this.CbOb.Items.AddRange(new object[] {
            "Нижегородская"});
            this.CbOb.Location = new System.Drawing.Point(192, 385);
            this.CbOb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbOb.Name = "CbOb";
            this.CbOb.Size = new System.Drawing.Size(134, 30);
            this.CbOb.TabIndex = 20;
            // 
            // CbO
            // 
            this.CbO.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deportamentBindingSource, "DepartmentName", true));
            this.CbO.DataSource = this.deportamentBindingSource2;
            this.CbO.DisplayMember = "DepartmentName";
            this.CbO.FormattingEnabled = true;
            this.CbO.Location = new System.Drawing.Point(192, 233);
            this.CbO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbO.Name = "CbO";
            this.CbO.Size = new System.Drawing.Size(134, 30);
            this.CbO.TabIndex = 22;
            // 
            // deportamentBindingSource2
            // 
            this.deportamentBindingSource2.DataMember = "Deportament";
            this.deportamentBindingSource2.DataSource = this.zad_PlanirDataSet10;
            // 
            // zad_PlanirDataSet10
            // 
            this.zad_PlanirDataSet10.DataSetName = "Zad_PlanirDataSet10";
            this.zad_PlanirDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CbY
            // 
            this.CbY.FormattingEnabled = true;
            this.CbY.Items.AddRange(new object[] {
            "Street",
            " 2ая Максима Горького улица",
            " 2ой Ручей переулок",
            " 2ой Солнечный переулок",
            " 40 лет Октября улица",
            " 50 лет Октября улица",
            " 60 лет ВЛКСМ улица",
            " 8 Марта улица",
            " АдмиралаМакарова улица",
            " Академика Курчатова площадь",
            " Академика Павлова улица",
            " Аксакова переулок",
            " Алебастровая улица",
            " Апрельская улица",
            " Артезианская улица",
            " Артема улица",
            " Бабушкина улица",
            " Бандажников улица",
            " Бандажников переулок",
            " Баумана улица",
            " Белинского улица",
            " Белорусская площадь",
            " Береговая улица",
            " Березовый переулок",
            " Блока переулок",
            " Богдана Хмельницкого улица",
            " Бунтарская улица",
            " Бурденко улица",
            " Бутова улица",
            " Бухвалова улица",
            " Ватутина улица",
            " Войкова улица",
            " Володарского улица",
            " Воровского улица",
            " Восстания улица",
            " Гагарина улица",
            " Гайдара улица",
            " Галанина переулок",
            " Гастелло улица",
            " Герцена улица",
            " Глинки улица",
            " Гоголя улица",
            " Гогрэс улица",
            " Гончарова улица",
            " Грибоедова улица",
            " Дальняя улица",
            " Дачная улица",
            " Дежнева переулок",
            " Декабристов улица",
            " Демократическая улица",
            " Дзержинского улица",
            " Догадина улица",
            " Достоевского улица",
            " Ежкова улица",
            " Ежкова площадь",
            " Елузгинская улица",
            " Ермака улица",
            " Есенина улица",
            " Есина улица",
            " Железнодорожная улица",
            " Жуковского улица",
            " Западная улица",
            " Западный микрорайон",
            " Запрудная улица",
            " Зеленая улица",
            " Зои Космодемьянской улица",
            " Интернациональная улица",
            " Исакова улица",
            " Кавалерийская улица",
            " Калинина улица",
            " Карамзина переулок",
            " Карла Маркса улица",
            " Квартал Народной стройки улица",
            " Киевская площадь",
            " Кирова улица",
            " Кирюхина улица",
            " Коллективный переулок",
            " Колхозная улица",
            " Коминтерна улица",
            " Коммунальная улица",
            " Коммунистическая улица",
            " Комсомольская улица",
            " Космонавта Комарова улица",
            " Котовского улица",
            " Кочубея переулок",
            " Красноармейская улица",
            " Краснодонцев улица",
            " Крестьянская улица",
            " Крисанова переулок",
            " Крисанова улица",
            "Маяковская",
            "Ульянова",
            "Мичурина",
            "Щорса",
            "Степана-Разина"});
            this.CbY.Location = new System.Drawing.Point(192, 461);
            this.CbY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbY.Name = "CbY";
            this.CbY.Size = new System.Drawing.Size(134, 30);
            this.CbY.TabIndex = 23;
            // 
            // CbG
            // 
            this.CbG.FormattingEnabled = true;
            this.CbG.Items.AddRange(new object[] {
            "Кулебаки"});
            this.CbG.Location = new System.Drawing.Point(192, 423);
            this.CbG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbG.Name = "CbG";
            this.CbG.Size = new System.Drawing.Size(134, 30);
            this.CbG.TabIndex = 24;
            // 
            // CbD
            // 
            this.CbD.FormattingEnabled = true;
            this.CbD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.CbD.Location = new System.Drawing.Point(192, 499);
            this.CbD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbD.Name = "CbD";
            this.CbD.Size = new System.Drawing.Size(134, 30);
            this.CbD.TabIndex = 25;
            // 
            // zad_PlanirDataSet8
            // 
            this.zad_PlanirDataSet8.DataSetName = "Zad_PlanirDataSet8";
            this.zad_PlanirDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deportamentBindingSource1
            // 
            this.deportamentBindingSource1.DataMember = "Deportament";
            this.deportamentBindingSource1.DataSource = this.zad_PlanirDataSet8;
            // 
            // deportamentTableAdapter1
            // 
            this.deportamentTableAdapter1.ClearBeforeFill = true;
            // 
            // deportamentTableAdapter2
            // 
            this.deportamentTableAdapter2.ClearBeforeFill = true;
            // 
            // FormAddSot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 648);
            this.Controls.Add(this.CbD);
            this.Controls.Add(this.CbG);
            this.Controls.Add(this.CbY);
            this.Controls.Add(this.CbO);
            this.Controls.Add(this.CbOb);
            this.Controls.Add(this.TbI);
            this.Controls.Add(this.TbF);
            this.Controls.Add(this.TbN);
            this.Controls.Add(this.TbR);
            this.Controls.Add(this.TbL);
            this.Controls.Add(this.TbP);
            this.Controls.Add(this.LbD);
            this.Controls.Add(this.LbY);
            this.Controls.Add(this.LbG);
            this.Controls.Add(this.LbOb);
            this.Controls.Add(this.LbP);
            this.Controls.Add(this.LbL);
            this.Controls.Add(this.LbR);
            this.Controls.Add(this.LbO);
            this.Controls.Add(this.LbN);
            this.Controls.Add(this.LbF);
            this.Controls.Add(this.LbI);
            this.Controls.Add(this.ButtonOt);
            this.Controls.Add(this.ButtonAdd);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddSot";
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deportamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kladrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deportamentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zad_PlanirDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deportamentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Zad_PlanirDataSet2 zad_PlanirDataSet2;
        private System.Windows.Forms.BindingSource deportamentBindingSource;
        private Zad_PlanirDataSet2TableAdapters.DeportamentTableAdapter deportamentTableAdapter;
        private Zad_PlanirDataSet3 zad_PlanirDataSet3;
        private System.Windows.Forms.BindingSource kladrBindingSource;
        private Zad_PlanirDataSet3TableAdapters.KladrTableAdapter kladrTableAdapter;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonOt;
        private System.Windows.Forms.Label LbI;
        private System.Windows.Forms.Label LbF;
        private System.Windows.Forms.Label LbN;
        private System.Windows.Forms.Label LbO;
        private System.Windows.Forms.Label LbR;
        private System.Windows.Forms.Label LbL;
        private System.Windows.Forms.Label LbP;
        private System.Windows.Forms.Label LbOb;
        private System.Windows.Forms.Label LbG;
        private System.Windows.Forms.Label LbY;
        private System.Windows.Forms.Label LbD;
        private System.Windows.Forms.TextBox TbP;
        private System.Windows.Forms.TextBox TbL;
        private System.Windows.Forms.TextBox TbR;
        private System.Windows.Forms.TextBox TbN;
        private System.Windows.Forms.TextBox TbF;
        private System.Windows.Forms.TextBox TbI;
        private System.Windows.Forms.ComboBox CbOb;
        private System.Windows.Forms.ComboBox CbO;
        private System.Windows.Forms.ComboBox CbY;
        private System.Windows.Forms.ComboBox CbG;
        private System.Windows.Forms.ComboBox CbD;
        private Zad_PlanirDataSet8 zad_PlanirDataSet8;
        private System.Windows.Forms.BindingSource deportamentBindingSource1;
        private Zad_PlanirDataSet8TableAdapters.DeportamentTableAdapter deportamentTableAdapter1;
        private Zad_PlanirDataSet10 zad_PlanirDataSet10;
        private System.Windows.Forms.BindingSource deportamentBindingSource2;
        private Zad_PlanirDataSet10TableAdapters.DeportamentTableAdapter deportamentTableAdapter2;
    }
}