using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using System.IO;

namespace PlanZad
{
    public partial class FormZad : MaterialForm
    {
        private string TaskID;
        private string TaskName;
        private string Opisanie;
        private string Nachalo;
        private string Diadline;
        private string StatusID;
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public string PassID
        {
            get { return TaskID; }
            set { TaskID = value; }
        }

        public string PassTask
        {
            get { return TaskName; }
            set { TaskName = value; }
        }

        public string PassOpisanie
        {
            get { return Opisanie; }
            set { Opisanie = value; }
        }

        public string PassNach
        {
            get { return Nachalo; }
            set { Nachalo = value; }
        }
        public string PassKon
        {
            get { return Diadline; }
            set { Diadline = value; }
        }
        public string PassStat
        {
            get { return StatusID; }
            set { StatusID = value; }
        }

        public FormZad()
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
        private void Form_Task_Activated(object sender, EventArgs e)
        {

            int n = dataGridViewTas.Rows.Add();
            dataGridViewTas.Rows[n].Cells[0].Value = TaskID;
            dataGridViewTas.Rows[n].Cells[1].Value = TaskName;
            dataGridViewTas.Rows[n].Cells[2].Value = Opisanie;
            dataGridViewTas.Rows[n].Cells[3].Value = Nachalo;
            dataGridViewTas.Rows[n].Cells[4].Value = Diadline;
            dataGridViewTas.Rows[n].Cells[5].Value = StatusID;
         
        }
        private void Form_Activated(object sender, EventArgs e)
        {

            this.tasksTableAdapter.Fill(this.zad_PlanirDataSet13.Tasks);



            {
                connection = new SqlConnection(@"Data Source=SIRIUS\SQLEXPRESS;Initial Catalog=Zad_Planir;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("(Select *\r\nfrom Tasks)", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewTas.RowHeadersVisible = false;
                dataGridViewTas.DataSource = table;
                dataGridViewTas.Columns[0].HeaderCell.Value = "№";
                dataGridViewTas.Columns[0].Width = 30;
                dataGridViewTas.Columns[1].HeaderCell.Value = "Наименование";
                dataGridViewTas.Columns[1].Width = 150;
                dataGridViewTas.Columns[2].HeaderCell.Value = "Описание";
                dataGridViewTas.Columns[2].Width = 70;
                dataGridViewTas.Columns[3].HeaderCell.Value = "Начало";
                dataGridViewTas.Columns[3].Width = 70;
                dataGridViewTas.Columns[4].HeaderCell.Value = "Конец";
                dataGridViewTas.Columns[4].Width = 70;
                dataGridViewTas.Columns[5].HeaderCell.Value = "Статус";
                dataGridViewTas.Columns[5].Width = 120;
           
            }
        }

        private void FormZad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet13.Tasks". При необходимости она может быть перемещена или удалена.
            this.tasksTableAdapter.Fill(this.zad_PlanirDataSet13.Tasks);
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
            this.Close();
        }

        private void SvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string programInfo = "Название приложения:          Планировщик задач \n Разработчик:          Ботов С.Е. \n Версия:          1.0 \n Связь:          +79087645437";

            MessageBox.Show(programInfo, "Информация о Планировщике задач", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddT faddt = new FormAddT();
            this.Hide();
            faddt.Owner = this;
            faddt.ShowDialog(this);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            FormRedT fedT = new FormRedT();
            this.Hide();
            fedT.Owner = this;
            fedT.ShowDialog(this);
        }

        private void buttonYd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Tasks WHERE TaskID = N'{tbTask.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dataGridViewTas.DataSource = table;
            }
        }

        private void DgVtas(object sender, MouseEventArgs e)
        {
            tbTask.Text = dataGridViewTas.CurrentRow.Cells[0].Value.ToString();
        }

        private void DgVtask(object sender, MouseEventArgs e)
        {
            FormRedsotr f2 = new FormRedsotr();
        }

        private void ZdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSr frmSt = new FormSr();
            frmSt.Show();
            this.Hide();
        }

        private void PvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPv frmSt = new FormPv();
            frmSt.Show();
            this.Hide();
        }
    }
}
