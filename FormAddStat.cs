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
    public partial class FormAddS : MaterialForm
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public string get_cs()
        {
            return "Data Source=sirius\\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True";
        }
        public FormAddS()
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
        private void FillDataGridViev()
        {
            FormStat formadd = (FormStat)this.Owner;

            connection = new SqlConnection("Data Source=sirius\\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(Select *\r\nfrom Status)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dataGridViewS.DataSource = table;
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormStat f1 = (FormStat)this.Owner;
            f1.PassStatusID = TbI.Text;
            f1.PassNaimenovanie = TbN.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите изменить данные в таблицу Статус?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(TbI.Text) && !string.IsNullOrWhiteSpace(TbI.Text) &&
               !string.IsNullOrEmpty(TbN.Text) && !string.IsNullOrWhiteSpace(TbN.Text))

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("Insert Into Status (StatusID,Naimenovanie ) values (@StatusID,@Naimenovanie)", connection))

                    {
                        cmd.Parameters.AddWithValue("StatusID", TbI.Text);
                        cmd.Parameters.AddWithValue("Naimenovanie", TbN.Text);

                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    TbI.Clear();
                    TbN.Clear();



                    FillDataGridViev();

                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!!!", "Предупреждение");
            }
        }

        private void buttonOt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStat main = new FormStat();
            main.ShowDialog();
            connection.Close();
        }
    }
}
