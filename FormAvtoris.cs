using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace PlanZad
{
    public partial class FormAV : MaterialForm
    {
        //public TextBox textBoxLogin { get; set; }
      //  public TextBox textBoxPassword { get; set; }

        public FormAV()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo300, Primary.LightBlue300,
                Primary.LightBlue300, Accent.LightBlue200,
                TextShade.BLACK
                 );

        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            string rol;
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=sirius\sqlexpress; Initial Catalog= Zad_Planir; Integrated Security=True"))
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("SELECT [rol] From Sotrud where login = @login and password = @password", sqlcon);
                command.Parameters.AddWithValue("@login", textBoxL.Text);
                command.Parameters.AddWithValue("@password", textBoxP.Text);
                rol = (string)command.ExecuteScalar();

            }
            if (rol == "Администратор")

            {
                this.Hide();
                FormSotry adm = new FormSotry(); adm.ShowDialog();
            }
            else if (rol == "Начальник")
            {
                this.Hide();
                FormOtl nach = new FormOtl(); nach.Show();
            }
            else if (rol == "Сотрудник")
            {
                this.Hide();
                FormZad nach = new FormZad(); nach.Show();
            }
            else
            {
                MessageBox.Show("Неправильно введен логин/пароль", "Ошибка!");
            }
        

    }

    private void buttonZ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAV_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zad_PlanirDataSet17.Raspisanie". При необходимости она может быть перемещена или удалена.
          //  this.raspisanieTableAdapter.Fill(this.zad_PlanirDataSet18.Raspisanie);

        }

        private void SVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string programInfo = "Название приложения:          Планировщик задач \n Разработчик:          Ботов С.Е. \n Версия:          1.0 \n Связь:          +79087645437";

            MessageBox.Show(programInfo, "Информация о Планировщике задач", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //   private void textBoxLogin_TextChanged(object sender, EventArgs e)
        //  {
        //  string textBoxL=textBoxLogin.Text;
        //  textBoxLogin.Text = textBoxL;

        //   }

        // private void textBoxPassword_TextChanged(object sender, EventArgs e)
        //  {
        //   string textBoxP = textBoxPassword.Text;
        //    textBoxPassword.Text = textBoxP;

        //  }

        //  private void label2_Click(object sender, EventArgs e)
        // {
        // }
        // private void FormAV_Load(object sender, EventArgs e)
        // {
        // }
        //  private void labelL_Click(object sender, EventArgs e)
        //  {
        //  }
    }
}
