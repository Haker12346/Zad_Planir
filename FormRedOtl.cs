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
    public partial class FormRedO : MaterialForm
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public string get_cs()
        {
            return "Data Source=sirius\\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True";
        }
        public FormRedO()
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
            FormOtl formadd = (FormOtl)this.Owner;

            connection = new SqlConnection("Data Source=sirius\\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(Select *\r\nfrom Deportament)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dataGridViewOt.DataSource = table;
            this.Close();
        }
        public FormRedO(FormOtl f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }

        private void FormRedO_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=sirius\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True");
            connection.Open();


            FormOtl frm = (FormOtl)Application.OpenForms["FormOtl"];
            int row = frm.dataGridViewOt.CurrentRow.Index;
            TbI.Text = Convert.ToString(frm.dataGridViewOt[0, row].Value);
            TbN.Text = Convert.ToString(frm.dataGridViewOt[1, row].Value);
            TbH.Text = Convert.ToString(frm.dataGridViewOt[2, row].Value);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            FormOtl f1 = (FormOtl)this.Owner;
            f1.PassDeportamentID = TbI.Text;
            f1.PassDeportamentName = TbN.Text;
            f1.PassNachalnikDeportament = TbH.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите изменить данные в таблицу Отдел?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(TbI.Text) && !string.IsNullOrWhiteSpace(TbI.Text) &&
               !string.IsNullOrEmpty(TbN.Text) && !string.IsNullOrWhiteSpace(TbN.Text) &&
               !string.IsNullOrEmpty(TbH.Text) && !string.IsNullOrWhiteSpace(TbH.Text))

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("Update Deportament set DepartmentID = @DepartmentID,DepartmentName = @DepartmentName,NachalnikDepartment=@NachalnikDepartment where DepartmentID = @DepartmentID", connection))

                    {
                        cmd.Parameters.AddWithValue("DepartmentID", TbI.Text);
                        cmd.Parameters.AddWithValue("DepartmentName", TbN.Text);
                        cmd.Parameters.AddWithValue("NachalnikDepartment", TbH.Text);

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
            if (TbH.Text != null)
            {
                TbH.Clear();
            }
        }
        private void buttonOt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOtl main = new FormOtl();
            main.ShowDialog();
            connection.Close();
        }
    }
}
