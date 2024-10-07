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
    public partial class FormPv : MaterialForm
    {
        public FormPv()
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
            string query = "USE Zad_Planir;\r\n\r\nSELECT \r\n    TaskName as Название, \r\n    Opisanie as Описание, \r\n    Nachalo as Начало, \r\n    Deadline as Конец, \r\n    Naimenovanie as Статус,\r\n    CASE   \r\n        WHEN Deadline < '2024-01-21' AND Naimenovanie = 'в ожидании' THEN 'просрочено'  \r\n        WHEN Deadline >= '2024-01-21' AND Naimenovanie = 'в ожидании' THEN 'активно'  \r\n        ELSE 'выполнено' \r\n    END AS Состояние \r\nFROM \r\n    Tasks \r\nINNER JOIN \r\n    Status \r\nON \r\n    Tasks.StatusID = Status.StatusID\r\nORDER BY  \r\n    CASE\r\n        WHEN Naimenovanie = 'выполнено' THEN 'в ожидании'   \r\n        WHEN Naimenovanie = 'в ожидании' AND Deadline < '2024-01-21' THEN 'выполнено'  \r\n        WHEN Naimenovanie = 'в ожидании' AND Deadline >= '2024-01-21' THEN 'в процессе'  \r\n        ELSE '' \r\n    END, \r\n    Deadline ASC;\r\n";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewZ.DataSource = dataTable;
            }
        }
    

private void Form2_Load(object sender, EventArgs e)
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
