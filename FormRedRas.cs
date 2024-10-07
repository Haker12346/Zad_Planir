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
    public partial class FormRedZ : MaterialForm
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public string get_cs()
        {
            return "Data Source=sirius\\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True";
        }
        public FormRedZ()
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
        public FormRedZ(FormRas f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=sirius\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True");
            connection.Open();


            FormRas frm = (FormRas)Application.OpenForms["FormRas"];
            int row = frm.dataGridViewRas.CurrentRow.Index;
            TbI.Text = Convert.ToString(frm.dataGridViewRas[0, row].Value);
            TbS.Text = Convert.ToString(frm.dataGridViewRas[1, row].Value);
            TbZ.Text = Convert.ToString(frm.dataGridViewRas[2, row].Value);
            TbN.Text = Convert.ToString(frm.dataGridViewRas[3, row].Value);
            TbNtime.Text = Convert.ToString(frm.dataGridViewRas[4, row].Value);
            TbKtime.Text = Convert.ToString(frm.dataGridViewRas[5, row].Value);


        }
        private void FillDataGridViev()
        {
            FormRas formadd = (FormRas)this.Owner;

            connection = new SqlConnection("Data Source=sirius\\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(Select *\r\nfrom Raspisanie)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dataGridViewRas.DataSource = table;
            this.Close();
        }

        private void buttonOt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRas main = new FormRas();
            main.ShowDialog();
            connection.Close();
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            FormRas f1 = (FormRas)this.Owner;
            f1.PassRaspisanieID = TbI.Text;
            f1.PassSotrudID = TbS.Text;
            f1.PassTaskID = TbZ.Text;
            f1.PassNach = TbN.Text;
            f1.PassNtime = TbNtime.Text;
            f1.PassKtime = TbKtime.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите изменить данные в таблицу Расписание?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(TbI.Text) && !string.IsNullOrWhiteSpace(TbI.Text) &&
               !string.IsNullOrEmpty(TbS.Text) && !string.IsNullOrWhiteSpace(TbS.Text) &&
               !string.IsNullOrEmpty(TbZ.Text) && !string.IsNullOrWhiteSpace(TbZ.Text) &&
               !string.IsNullOrEmpty(TbN.Text) && !string.IsNullOrWhiteSpace(TbN.Text) &&
               !string.IsNullOrEmpty(TbNtime.Text) && !string.IsNullOrWhiteSpace(TbNtime.Text) &&
               !string.IsNullOrEmpty(TbKtime.Text) && !string.IsNullOrWhiteSpace(TbKtime.Text))
            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("Update Raspisanie set RaspisanieID = @RaspisanieID, SotrudID = @SotrudID, TaskID = @TaskID, NachaloDate = @NachaloDate, StartTime = @StartTime, EndTime = @EndTime  where RaspisanieID = @RaspisanieID", connection))
                        
                    {
                        cmd.Parameters.AddWithValue("RaspisanieID", TbI.Text);
                        cmd.Parameters.AddWithValue("SotrudID", TbS.Text);
                        cmd.Parameters.AddWithValue("TaskID", TbZ.Text);
                        cmd.Parameters.AddWithValue("NachaloDate", TbN.Text);
                        cmd.Parameters.AddWithValue("StartTime", TbNtime.Text);
                        cmd.Parameters.AddWithValue("EndTime", TbKtime.Text);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    TbI.Clear();
                    TbS.Clear();
                    TbZ.Clear();
                    TbN.Clear();

                    TbNtime.Clear();
                    TbKtime.Clear();


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
                if (TbS.Text != null)
                {
                    TbS.Clear();
                }
                if (TbZ.Text != null)
                {
                    TbZ.Clear();
                }




                if (TbN.Text != null)
                {
                    TbN.Clear();
                }
                if (TbNtime.Text != null)
                {
                    TbNtime.Clear();
                }


                if (TbKtime.Text != null)
                {
                    TbKtime.Clear();
                }
            }
        }
    }
    

