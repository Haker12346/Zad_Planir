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
    public partial class FormSr : MaterialForm
    {
        public FormSr()
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
            DisplaySQLResults();
        }
        private void DisplaySQLResults()
        {
            string connectionString = @"Data Source=SIRIUS\SQLEXPRESS;Initial Catalog=Zad_Planir;Integrated Security=True";
            string query = "SELECT TaskName as \"Название\", AVG(DATEDIFF(day,Nachalo,Deadline)) as Срок_сдачи FROM Tasks GROUP BY TaskName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewZ.DataSource = dataTable;
            }
        }
    

private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonzad_Click(object sender, EventArgs e)
        {
            FormZad faddt = new FormZad();
            this.Hide();
            faddt.Owner = this;
            faddt.ShowDialog(this);
        }
    }
}
