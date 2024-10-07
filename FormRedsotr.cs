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

namespace PlanZad
{
    public partial class FormRedsotr : MaterialForm
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public FormRedsotr()
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
        public string get_cs()
        {
            return "Data Source=sirius\\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True";
        }
        public FormRedsotr(FormSotry f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }

        private void FormRedsotr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet12.Deportament". При необходимости она может быть перемещена или удалена.
            this.deportamentTableAdapter2.Fill(this.zad_PlanirDataSet12.Deportament);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet9.Deportament". При необходимости она может быть перемещена или удалена.
            //  this.deportamentTableAdapter1.Fill(this.zad_PlanirDataSet9.Deportament);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet5.Kladr". При необходимости она может быть перемещена или удалена.
            this.kladrTableAdapter.Fill(this.zad_PlanirDataSet5.Kladr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet4.Deportament". При необходимости она может быть перемещена или удалена.
        //  this.deportamentTableAdapter.Fill(this.zad_PlanirDataSet4.Deportament);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet.Sotrud". При необходимости она может быть перемещена или удалена.
            //this.sotrudTableAdapter.Fill(this.zad_PlanirDataSet1.Sotrud);
            connection = new SqlConnection(@"Data Source=sirius\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True");
            connection.Open();


            FormSotry frm = (FormSotry)Application.OpenForms["FormSotry"];
            int row = frm.dataGridViewSot.CurrentRow.Index;
            TbI.Text = Convert.ToString(frm.dataGridViewSot[0, row].Value);
            TbF.Text = Convert.ToString(frm.dataGridViewSot[1, row].Value);
            TbN.Text = Convert.ToString(frm.dataGridViewSot[2, row].Value);
            CbO.Text = Convert.ToString(frm.dataGridViewSot[3, row].Value);
            TbR.Text = Convert.ToString(frm.dataGridViewSot[4, row].Value);
            TbL.Text = Convert.ToString(frm.dataGridViewSot[5, row].Value);
            TbP.Text = Convert.ToString(frm.dataGridViewSot[6, row].Value);
            CbOb.Text = Convert.ToString(frm.dataGridViewSot[7, row].Value);
            CbG.Text = Convert.ToString(frm.dataGridViewSot[8, row].Value);
            CbY.Text = Convert.ToString(frm.dataGridViewSot[9, row].Value);
           CbD.Text = Convert.ToString(frm.dataGridViewSot[10, row].Value);
        }



       
        
        private void FillDataGridViev()
        {
            FormSotry formeditfac = (FormSotry)this.Owner;

            connection = new SqlConnection("Data Source=sirius\\sqlexpress;Initial Catalog=Zad_Planir;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(SELECT Sotrud.SotrudID, Sotrud.FirstName, Sotrud.LastName, Deportament.DepartmentName, Sotrud.rol, Sotrud.login,Sotrud.password, Kladr.Oblasti, Kladr.City, Kladr.Street, Kladr.House FROM Sotrud INNER JOIN Kladr ON Sotrud.Kladr = Kladr.Kladr INNER JOIN Deportament ON Sotrud.DepartmentID = Deportament.DepartmentID)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formeditfac.dataGridViewSot.DataSource = table;
            this.Close();
        }

   

        private void ButtonR_Click_1(object sender, EventArgs e)
        {
            FormSotry f1 = (FormSotry)this.Owner;

            int id = 0;
           
            id = Convert.ToInt32(f1.dataGridViewSot.Rows[f1.dataGridViewSot.SelectedCells[0].RowIndex].Cells[0].Value);

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



            MessageBox.Show("Вы точно хотите изменить данные таблицы Сотрудники?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

                    using (var cmd = new SqlCommand("UPDATE Sotrud SET  FirstName = @FirstName, LastName =@LastName, DepartmentID = @DepartmentID, rol = @rol, login = @login, password = @password Where SotrudID = @SotrudID SELECT Sotrud.SotrudID,Sotrud.FirstName, Sotrud.LastName, Sotrud.DepartmentID, Sotrud.rol, Sotrud.login, Sotrud.password, Kladr.Oblasti, Kladr.City, Kladr.Street, Kladr.House  FROM Sotrud INNER JOIN Kladr ON Sotrud.Kladr = Kladr.Kladr INNER JOIN Deportament ON Sotrud.DepartmentID = Deportament.DepartmentID", connection))

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
            if (TbF.Text != null)
            {
                TbF.Clear();
            }
            if (TbN.Text != null)
            {
                TbN.Clear();
            }




            if (TbR.Text != null)
            {
                TbR.Clear();
            }


            if (TbL.Text != null)
            {
                TbL.Clear();
            }
            if (TbP.Text != null)
            {
                TbP.Clear();
            }
        }

        private void ButtonOt_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormSotry main = new FormSotry();
            main.ShowDialog();
            connection.Close();
        }

        private void LbD_Click(object sender, EventArgs e)
        {

        }

        private void CbD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbY_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbOb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbR_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbL_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbP_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbY_Click(object sender, EventArgs e)
        {

        }

        private void LbG_Click(object sender, EventArgs e)
        {

        }

        private void LbOb_Click(object sender, EventArgs e)
        {

        }

        private void LbP_Click(object sender, EventArgs e)
        {

        }

        private void LbL_Click(object sender, EventArgs e)
        {

        }

        private void LbR_Click(object sender, EventArgs e)
        {

        }
    }
    }


