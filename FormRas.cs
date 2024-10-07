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
    public partial class FormRas : MaterialForm
    {
        private string RaspisanieID;
        private string SotrudID;
        private string TaskID;
        private string NachaloDate;
        private string StartTime;
        private string EndTime;
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public string PassRaspisanieID
        {
            get { return RaspisanieID; }
            set { RaspisanieID = value; }
        }

        public string PassSotrudID
        {
            get { return SotrudID; }
            set { SotrudID = value; }
        }

        public string PassTaskID
        {
            get { return TaskID; }
            set { TaskID = value; }
        }

        public string PassNach
        {
            get { return NachaloDate; }
            set { NachaloDate = value; }
        }
        public string PassNtime
        {
            get { return StartTime; }
            set { StartTime = value; }
        }
        public string PassKtime
        {
            get { return EndTime; }
            set { EndTime = value; }
        }
        public FormRas()
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
        private void Form_Raspisan_Activated(object sender, EventArgs e)
        {

            int n = dataGridViewRas.Rows.Add();
            dataGridViewRas.Rows[n].Cells[0].Value = RaspisanieID;
            dataGridViewRas.Rows[n].Cells[1].Value = SotrudID;
            dataGridViewRas.Rows[n].Cells[2].Value = TaskID;
            dataGridViewRas.Rows[n].Cells[3].Value = NachaloDate;
            dataGridViewRas.Rows[n].Cells[4].Value = StartTime;
            dataGridViewRas.Rows[n].Cells[5].Value = EndTime;

        }
        private void Form_Activated(object sender, EventArgs e)
        {

            this.raspisanieTableAdapter.Fill(this.zad_PlanirDataSet18.Raspisanie);
           



            {
                connection = new SqlConnection(@"Data Source=SIRIUS\SQLEXPRESS;Initial Catalog=Zad_Planir;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("use Zad_Planir\r\nSelect *\r\nFrom Raspisanie", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewRas.RowHeadersVisible = false;
                dataGridViewRas.DataSource = table;
                dataGridViewRas.Columns[0].HeaderCell.Value = "№";
                dataGridViewRas.Columns[0].Width = 30;
                dataGridViewRas.Columns[1].HeaderCell.Value = "Номер сотрудника";
                dataGridViewRas.Columns[1].Width = 150;
                dataGridViewRas.Columns[2].HeaderCell.Value = "Номер задачи";
                dataGridViewRas.Columns[2].Width = 70;
                dataGridViewRas.Columns[3].HeaderCell.Value = "День начала";
                dataGridViewRas.Columns[3].Width = 70;
                dataGridViewRas.Columns[4].HeaderCell.Value = "Время начала";
                dataGridViewRas.Columns[4].Width = 70;
                dataGridViewRas.Columns[5].HeaderCell.Value = "Время завершения";
                dataGridViewRas.Columns[5].Width = 120;

            }
        }
        private void FormRas_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet18.Raspisanie". При необходимости она может быть перемещена или удалена.
            this.raspisanieTableAdapter.Fill(this.zad_PlanirDataSet18.Raspisanie);
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
            FormAddR faddt = new FormAddR();
            this.Hide();
            faddt.Owner = this;
            faddt.ShowDialog(this);
        }

        private void buttonReR_Click(object sender, EventArgs e)
        {
            FormRedZ fedT = new FormRedZ();
            this.Hide();
            fedT.Owner = this;
            fedT.ShowDialog(this);
        }

        private void buttonYR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Raspisanie WHERE RaspisanieID = N'{TbRas.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dataGridViewRas.DataSource = table;
            }
        }

        private void сведеньеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string programInfo = "Название приложения:          Планировщик задач \n Разработчик:          Ботов С.Е. \n Версия:          1.0 \n Связь:          +79087645437";

            MessageBox.Show(programInfo, "Информация о Планировщике задач", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DatagridZ(object sender, MouseEventArgs e)
        {
            TbRas.Text = dataGridViewRas.CurrentRow.Cells[0].Value.ToString();
        }

        private void DatagridZ1(object sender, MouseEventArgs e)
        {
            FormRedZ f2 = new FormRedZ();
        }
    }
}
