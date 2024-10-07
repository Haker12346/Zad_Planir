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
using MaterialSkin;
using MaterialSkin.Controls;

namespace PlanZad
{
    public partial class FormRedT : MaterialForm
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public string get_cs()
        {
            return "Data Source=sirius\\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True";
        }
        public FormRedT()
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
        public FormRedT(FormZad f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }

        private void FormRedT_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet16.Status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.zad_PlanirDataSet16.Status);
            connection = new SqlConnection(@"Data Source=sirius\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True");
            connection.Open();


            FormZad frm = (FormZad)Application.OpenForms["FormZad"];
            int row = frm.dataGridViewTas.CurrentRow.Index;
            TbI.Text = Convert.ToString(frm.dataGridViewTas[0, row].Value);
            TbN.Text = Convert.ToString(frm.dataGridViewTas[1, row].Value);
            TbO.Text = Convert.ToString(frm.dataGridViewTas[2, row].Value);
            TbNac.Text = Convert.ToString(frm.dataGridViewTas[3, row].Value);
            TbK.Text = Convert.ToString(frm.dataGridViewTas[4, row].Value);
            CbS.Text = Convert.ToString(frm.dataGridViewTas[5, row].Value);
           


        }
        private void FillDataGridViev()
        {
            FormZad formadd = (FormZad)this.Owner;

            connection = new SqlConnection("Data Source=sirius\\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(Select *\r\nfrom Tasks)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dataGridViewTas.DataSource = table;
            this.Close();
        }

        private void buttonOtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormZad main = new FormZad();
            main.ShowDialog();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormZad f1 = (FormZad)this.Owner;
            f1.PassID = TbI.Text;
            f1.PassTask = TbN.Text;
            f1.PassOpisanie = TbO.Text;
            f1.PassNach = TbNac.Text;
            f1.PassKon = TbK.Text;
            f1.PassStat = CbS.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите изменить данные в таблицу Задачи?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(TbI.Text) && !string.IsNullOrWhiteSpace(TbI.Text) &&
               !string.IsNullOrEmpty(TbN.Text) && !string.IsNullOrWhiteSpace(TbN.Text) &&
               !string.IsNullOrEmpty(TbO.Text) && !string.IsNullOrWhiteSpace(TbO.Text) &&
               !string.IsNullOrEmpty(TbNac.Text) && !string.IsNullOrWhiteSpace(TbNac.Text) &&
               !string.IsNullOrEmpty(TbK.Text) && !string.IsNullOrWhiteSpace(TbK.Text) &&
               !string.IsNullOrEmpty(CbS.Text) && !string.IsNullOrWhiteSpace(CbS.Text))
            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("Update Tasks set  TaskID=@TaskID, TaskName=@TaskName, Opisanie=@Opisanie, Nachalo=@Nachalo, Deadline= @Deadline, StatusID=@StatusID\r\nwhere TaskID=@TaskID", connection))

                    {
                        cmd.Parameters.AddWithValue("TaskID", TbI.Text);
                        cmd.Parameters.AddWithValue("TaskName", TbN.Text);
                        cmd.Parameters.AddWithValue("Opisanie", TbO.Text);
                        cmd.Parameters.AddWithValue("Nachalo", TbNac.Text);
                        cmd.Parameters.AddWithValue("Deadline", TbK.Text);
                        cmd.Parameters.AddWithValue("StatusID", CbS.SelectedIndex);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    TbI.Clear();
                    TbN.Clear();
                    TbO.Clear();
                    TbNac.Clear();


                    TbK.Clear();


                    FillDataGridViev();

                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка");
            }
                if (TbI.Text != null)
                {
                    TbI.Clear();
                }
                if (TbN.Text != null)
                {
                    TbN.Clear();
                }
                if (TbO.Text != null)
                {
                    TbO.Clear();
                }




                if (TbNac.Text != null)
                {
                    TbNac.Clear();
                }


                if (TbK.Text != null)
                {
                    TbK.Clear();
                }
               
            }
        

        private void CbS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbK_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbO_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbN_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbI_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbS_Click(object sender, EventArgs e)
        {

        }

        private void LbK_Click(object sender, EventArgs e)
        {

        }

        private void LbNac_Click(object sender, EventArgs e)
        {

        }

        private void LbO_Click(object sender, EventArgs e)
        {

        }

        private void LbN_Click(object sender, EventArgs e)
        {

        }

        private void LbI_Click(object sender, EventArgs e)
        {

        }
    }
}
