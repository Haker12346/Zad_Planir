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


namespace PlanZad
{
    public partial class FormStat : MaterialForm

    {
        private string StatusID;
        private string Naimenovanie;
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public string PassStatusID
        {
            get { return StatusID; }
            set { StatusID = value; }
        }

        public string PassNaimenovanie
        {
            get { return Naimenovanie; }
            set { Naimenovanie = value; }
        }
        public FormStat()
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
        private void Form_Stat_Activated(object sender, EventArgs e)
        {

            int n = dataGridViewS.Rows.Add();
            dataGridViewS.Rows[n].Cells[0].Value = StatusID;
            dataGridViewS.Rows[n].Cells[1].Value = Naimenovanie;
        }
        private void Form_Activated(object sender, EventArgs e)
        {

            this.statusTableAdapter.Fill(this.zad_PlanirDataSet19.Status);




            {
                connection = new SqlConnection(@"Data Source=SIRIUS\SQLEXPRESS;Initial Catalog=Zad_Planir;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("use Zad_Planir\r\nSelect *\r\nFrom Status", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewS.RowHeadersVisible = false;
                dataGridViewS.DataSource = table;
                dataGridViewS.Columns[0].HeaderCell.Value = "№";
                dataGridViewS.Columns[0].Width = 30;
                dataGridViewS.Columns[1].HeaderCell.Value = "Номер сотрудника";
                dataGridViewS.Columns[1].Width = 100;
            }
        }
        private void FormStat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet19.Status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.zad_PlanirDataSet19.Status);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOtl frmO = new FormOtl();
            frmO.Show();
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

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRas frmR = new FormRas();
            frmR.Show();
            this.Hide();
        }

        private void VuhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sever(object sender, MouseEventArgs e)
        {
            TbI.Text = dataGridViewS.CurrentRow.Cells[0].Value.ToString();
        }

        private void Vostok(object sender, MouseEventArgs e)
        {
            FormRedS f2 = new FormRedS();
        }

        private void SToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string programInfo = "Название приложения:          Планировщик задач \n Разработчик:          Ботов С.Е. \n Версия:          1.0 \n Связь:          +79087645437";

            MessageBox.Show(programInfo, "Информация о Планировщике задач", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonYd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Status WHERE StatusID = N'{TbI.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dataGridViewS.DataSource = table;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddS fedT = new FormAddS();
            this.Hide();
            fedT.Owner = this;
            fedT.ShowDialog(this);

        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            FormRedS fedT = new FormRedS();
            this.Hide();
            fedT.Owner = this;
            fedT.ShowDialog(this);
        }
    }
}
