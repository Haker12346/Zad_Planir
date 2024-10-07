using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PlanZad
{
    public partial class FormOtl : MaterialForm
    {
        private string DeportamentID;
        private string DeportamentName;
        private string NachalnikDeportament;
      
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public string PassDeportamentID
        {
            get { return DeportamentID; }
            set { DeportamentID = value; }
        }

        public string PassDeportamentName
        {
            get { return DeportamentName; }
            set { DeportamentName = value; }
        }
        public string PassNachalnikDeportament
        {
            get { return NachalnikDeportament; }
            set { DeportamentName = value; }
        }
        public FormOtl()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;


            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo300, Primary.LightBlue300,
                Primary.LightBlue300, Accent.LightBlue200,
                TextShade.BLACK
                 );
        }
        private void Form_Ot_Activated(object sender, EventArgs e)
        {

            int n = dataGridViewOt.Rows.Add();
            dataGridViewOt.Rows[n].Cells[0].Value = DeportamentID;
            dataGridViewOt.Rows[n].Cells[1].Value = DeportamentName;
            dataGridViewOt.Rows[n].Cells[2].Value = NachalnikDeportament;
        }
        private void Form_Activated(object sender, EventArgs e)
        {

            this.deportamentTableAdapter.Fill(this.zad_PlanirDataSet20.Deportament);




            {
                connection = new SqlConnection(@"Data Source=SIRIUS\SQLEXPRESS;Initial Catalog=Zad_Planir;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("use Zad_Planir\r\nSelect *\r\nFrom Deportament", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewOt.RowHeadersVisible = false;
                dataGridViewOt.DataSource = table;
                dataGridViewOt.Columns[0].HeaderCell.Value = "№";
                dataGridViewOt.Columns[0].Width = 30;
                dataGridViewOt.Columns[1].HeaderCell.Value = "Название";
                dataGridViewOt.Columns[1].Width = 100;
                dataGridViewOt.Columns[2].HeaderCell.Value = "Начальник";
                dataGridViewOt.Columns[2].Width = 100;
            }
        }

        private void FormOtl_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet20.Deportament". При необходимости она может быть перемещена или удалена.
            this.deportamentTableAdapter.Fill(this.zad_PlanirDataSet20.Deportament);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRas frmR = new FormRas();
            frmR.Show();
            this.Hide();
        }

        private void sotrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSotry frmStut = new FormSotry();
            frmStut.Show();
            this.Hide();
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZad frmZ = new FormZad();
            frmZ.Show();
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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddO fedT = new FormAddO();
            this.Hide();
            fedT.Owner = this;
            fedT.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRedO fedT = new FormRedO();
            this.Hide();
            fedT.Owner = this;
            fedT.ShowDialog(this);
        }

        private void buttonYd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Deportament WHERE DepartmentID = N'{Tb.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dataGridViewOt.DataSource = table;
            }
        }

        private void сведеньеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string programInfo = "Название приложения:          Планировщик задач \n Разработчик:          Ботов С.Е. \n Версия:          1.0 \n Связь:          +79087645437";

            MessageBox.Show(programInfo, "Информация о Планировщике задач", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Yg(object sender, MouseEventArgs e)
        {
            Tb.Text = dataGridViewOt.CurrentRow.Cells[0].Value.ToString();
        }

        private void Mag(object sender, MouseEventArgs e)
        {
            FormRedO f2 = new FormRedO();
        }
    }
}
