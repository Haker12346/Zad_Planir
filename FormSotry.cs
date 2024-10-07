using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using PlanZad.Zad_PlanirDataSetTableAdapters;

namespace PlanZad
{
    public partial class FormSotry : MaterialForm
    {
        private string SotrudID;
        private string FirstName;
        private string LastName;
        private string DepartmentID;
        private string rol;
        private string login;
        private string password;
        private string Oblasti;
        private string City;
        private string Street;
        private string House;

        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public string PassID
        {
            get { return SotrudID; }
            set { SotrudID = value; }
        }

        public string PassFamilia
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string PassImia
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public string PassDepartmentID
        {
            get { return DepartmentID; }
            set { DepartmentID = value; }
        }
       
        public string Passrol
        {
            get { return rol; }
            set { rol = value; }
        }

        public string Passlogin
        {
            get { return login; }
            set { login = value; }
        }
        public string Passpassword
        {
            get { return password; }
            set { password = value; }
        }
        public string PassOblasti
        {
            get { return Oblasti; }
            set { Oblasti = value; }
        }
        public string PassCity
        {
            get { return City; }
            set { City = value; }
        }

        public string PassStreet
        {
            get { return Street; }
            set { Street = value; }
        }

        public string PassHouse
        {
            get { return House; }
            set { House = value; }
        }
        public FormSotry()

        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo200, Primary.LightBlue200,
                Primary.LightBlue200, Accent.LightBlue200,
                TextShade.BLACK
                 );
        }

       

  

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOtl frmO = new FormOtl();
            frmO.Show();
            this.Hide();
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZad frmZ = new FormZad();
            frmZ.Show();
            this.Hide();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRas frmR = new FormRas();
            frmR.Show();
            this.Hide();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStat frmSt = new FormStat();
            frmSt.Show();
            this.Hide();
        }

        private void VuhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAV frmAV = new FormAV();
            frmAV.Show();
            this.Hide();
        }
        private void SvedToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string programInfo = "Название приложения:          Планировщик задач \n Разработчик:          Ботов С.Е. \n Версия:          1.0 \n Связь:          +79087645437";

            MessageBox.Show(programInfo, "Информация о Планировщике задач", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddsort_Click(object sender, EventArgs e)
        {
            FormAddSot fadds = new FormAddSot();
            this.Hide();
            fadds.Owner = this;
            fadds.ShowDialog(this);
        }

        private void buttonRedsotr_Click(object sender, EventArgs e)
        {

            FormRedsotr fedsotr = new FormRedsotr();
            this.Hide();
            fedsotr.Owner = this;
            fedsotr.ShowDialog(this);
        }
        private void Form_Sotry_Activated(object sender, EventArgs e)
        {

            int n = dataGridViewSot.Rows.Add();
            dataGridViewSot.Rows[n].Cells[0].Value = SotrudID;
            dataGridViewSot.Rows[n].Cells[1].Value = FirstName;
            dataGridViewSot.Rows[n].Cells[2].Value = LastName;
            dataGridViewSot.Rows[n].Cells[3].Value = DepartmentID;
            dataGridViewSot.Rows[n].Cells[4].Value = rol;
            dataGridViewSot.Rows[n].Cells[5].Value = login;
            dataGridViewSot.Rows[n].Cells[6].Value = password;
            dataGridViewSot.Rows[n].Cells[7].Value = Oblasti;
            dataGridViewSot.Rows[n].Cells[8].Value = City;
            dataGridViewSot.Rows[n].Cells[9].Value = Street;
            dataGridViewSot.Rows[n].Cells[10].Value = House;
        }
        private void Form_Activated(object sender, EventArgs e)
        {

            this.sotrudTableAdapter.Fill(this.zad_PlanirDataSet1.Sotrud);



            {
                connection = new SqlConnection(@"Data Source=SIRIUS\SQLEXPRESS;Initial Catalog=Zad_Planir;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("(SELECT Sotrud.SotrudID, Sotrud.FirstName, Sotrud.LastName, Deportament.DepartmentName, Sotrud.rol, Sotrud.login,Sotrud.password, Kladr.Oblasti, Kladr.City, Kladr.Street, Kladr.House FROM Sotrud INNER JOIN Kladr ON Sotrud.Kladr = Kladr.Kladr INNER JOIN Deportament ON Sotrud.DepartmentID = Deportament.DepartmentID)", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewSot.RowHeadersVisible = false;
                dataGridViewSot.DataSource = table;
                dataGridViewSot.Columns[0].HeaderCell.Value = "№";
                dataGridViewSot.Columns[0].Width = 30;
                dataGridViewSot.Columns[1].HeaderCell.Value = "Фамилия";
                dataGridViewSot.Columns[1].Width = 150;
                dataGridViewSot.Columns[2].HeaderCell.Value = "Имя";
                dataGridViewSot.Columns[2].Width = 70;
                dataGridViewSot.Columns[3].HeaderCell.Value = "Отдел";
                dataGridViewSot.Columns[3].Width = 200;
                dataGridViewSot.Columns[4].HeaderCell.Value = "Роль";
                dataGridViewSot.Columns[4].Width = 120;
                dataGridViewSot.Columns[5].HeaderCell.Value = "Логин";
                dataGridViewSot.Columns[5].Width = 100;
                dataGridViewSot.Columns[6].HeaderCell.Value = "Пароль";
                dataGridViewSot.Columns[6].Width = 90;
                dataGridViewSot.Columns[7].HeaderCell.Value = "Область";
               dataGridViewSot.Columns[7].Width = 100;
                dataGridViewSot.Columns[8].HeaderCell.Value = "Город";
                dataGridViewSot.Columns[8].Width = 100;
                dataGridViewSot.Columns[9].HeaderCell.Value = "Улица";
                dataGridViewSot.Columns[9].Width = 120;
               dataGridViewSot.Columns[10].HeaderCell.Value = "Дом";
               dataGridViewSot.Columns[10].Width = 50;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Sotrud WHERE SotrudID = N'{tbDelSotr.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dataGridViewSot.DataSource = table;
            }
        }

        private void dataGridViewSotrud_MouseClick(object sender, MouseEventArgs e)
        {
            tbDelSotr.Text = dataGridViewSot.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridViewSotrud_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormRedsotr f2 = new FormRedsotr();
        }

        private void FormSotry_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet7.Sotrud2". При необходимости она может быть перемещена или удалена.
           // this.sotrud2TableAdapter1.Fill(this.zad_PlanirDataSet7.Sotrud2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet6.Sotrud2". При необходимости она может быть перемещена или удалена.
            //this.sotrud2TableAdapter.Fill(this.zad_PlanirDataSet6.Sotrud2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet1.Sotrud". При необходимости она может быть перемещена или удалена.
          this.sotrudTableAdapter.Fill(this.zad_PlanirDataSet1.Sotrud);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }

        private void tbDelSotr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

