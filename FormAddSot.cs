using MaterialSkin.Controls;
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
using System.Data.SqlClient;

namespace PlanZad
{
    public partial class FormAddSot : MaterialForm
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public string get_cs()
        {
            return "Data Source=sirius\\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True";
        }
        public FormAddSot()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;


            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo200, Primary.LightBlue200,
                Primary.LightBlue200, Accent.LightBlue200,
                TextShade.BLACK
                 );
        }
        private void FillDataGridViev()
        {
            FormSotry formadd = (FormSotry)this.Owner;

            connection = new SqlConnection("Data Source=sirius\\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(SELECT Sotrud.SotrudID, Sotrud.FirstName, Sotrud.LastName, Deportament.DepartmentName, Sotrud.rol, Sotrud.login,Sotrud.password, Kladr.Oblasti, Kladr.City, Kladr.Street, Kladr.House FROM Sotrud INNER JOIN Kladr ON Sotrud.Kladr = Kladr.Kladr INNER JOIN Deportament ON Sotrud.DepartmentID = Deportament.DepartmentID)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dataGridViewSot.DataSource = table;
            this.Close();
        }




        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet10.Deportament". При необходимости она может быть перемещена или удалена.
            this.deportamentTableAdapter2.Fill(this.zad_PlanirDataSet10.Deportament);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet8.Deportament". При необходимости она может быть перемещена или удалена.
            //  this.deportamentTableAdapter1.Fill(this.zad_PlanirDataSet8.Deportament);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet3.Kladr". При необходимости она может быть перемещена или удалена.
            this.kladrTableAdapter.Fill(this.zad_PlanirDataSet3.Kladr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet2.Deportament". При необходимости она может быть перемещена или удалена.
         //  this.deportamentTableAdapter.Fill(this.zad_PlanirDataSet2.Deportament);

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSotry main = new FormSotry();
            main.ShowDialog();
            connection.Close();
        }

        private void ButtonAdd_Click_1(object sender, EventArgs e)
        {
            FormSotry f1 = (FormSotry)this.Owner;
            f1.PassID = TbI.Text;
            f1.PassFamilia = TbF.Text;
            f1.PassImia = TbN.Text;
            f1.PassDepartmentID = CbO.Text;
            f1.Passrol = TbR.Text;
            f1.Passlogin = TbL.Text;
            f1.Passpassword = TbP.Text;
            f1.PassOblasti = CbOb.Text;
            f1.PassCity = CbG.Text;
            f1.PassStreet = CbY.Text;
            f1.PassHouse = CbD.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите добавить данные в таблицу Сотрудники?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(TbI.Text) && !string.IsNullOrWhiteSpace(TbI.Text) &&
               !string.IsNullOrEmpty(TbF.Text) && !string.IsNullOrWhiteSpace(TbF.Text) &&
               !string.IsNullOrEmpty(TbN.Text) && !string.IsNullOrWhiteSpace(TbN.Text) &&
               !string.IsNullOrEmpty(CbO.Text) && !string.IsNullOrWhiteSpace(CbO.Text) &&
               !string.IsNullOrEmpty(TbR.Text) && !string.IsNullOrWhiteSpace(TbR.Text) &&
               !string.IsNullOrEmpty(TbL.Text) && !string.IsNullOrWhiteSpace(TbL.Text) &&
               !string.IsNullOrEmpty(TbP.Text) && !string.IsNullOrWhiteSpace(TbP.Text) &&
               !string.IsNullOrEmpty(CbOb.Text) && !string.IsNullOrWhiteSpace(CbOb.Text) &&
               !string.IsNullOrEmpty(CbG.Text) && !string.IsNullOrWhiteSpace(CbG.Text) &&
               !string.IsNullOrEmpty(CbY.Text) && !string.IsNullOrWhiteSpace(CbY.Text) &&
               !string.IsNullOrEmpty(CbD.Text) && !string.IsNullOrWhiteSpace(CbD.Text))
            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("INSERT INTO Sotrud(SotrudID, FirstName, LastName, DepartmentID, rol, login, password) VALUES(@SotrudID, @FirstName, @LastName, @DepartmentID, @rol, @login, @password); SELECT Sotrud.SotrudID, Sotrud.FirstName, Sotrud.LastName, Sotrud.DepartmentID,Sotrud.rol, Sotrud.login, Sotrud.password, Kladr.Oblasti, Kladr.City, Kladr.Street, Kladr.House FROM Sotrud INNER JOIN Kladr ON Sotrud.Kladr = Kladr.Kladr INNER JOIN Deportament ON Sotrud.DepartmentID = Deportament.DepartmentID", connection))

                    {
                        cmd.Parameters.AddWithValue("SotrudID", TbI.Text);
                        cmd.Parameters.AddWithValue("FirstName", TbF.Text);
                        cmd.Parameters.AddWithValue("LastName", TbN.Text);
                        cmd.Parameters.AddWithValue("DepartmentID", CbO.SelectedIndex);
                        cmd.Parameters.AddWithValue("rol", TbR.Text);
                        cmd.Parameters.AddWithValue("login", TbL.Text);
                        cmd.Parameters.AddWithValue("password", TbP.Text);
                        cmd.Parameters.AddWithValue("Oblasti", CbOb.SelectedIndex);
                        cmd.Parameters.AddWithValue("City", CbG.SelectedIndex);
                        cmd.Parameters.AddWithValue("Street", CbY.SelectedIndex);
                        cmd.Parameters.AddWithValue("House", CbD.SelectedIndex);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    TbI.Clear();
                    TbF.Clear();
                    TbN.Clear();
                    TbR.Clear();


                    TbL.Clear();

                    TbP.Clear();
                    FillDataGridViev();

                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!!!", "Предупреждение");
            }
        }

        private void LbO_Click(object sender, EventArgs e)
        {

        }
    }
}
