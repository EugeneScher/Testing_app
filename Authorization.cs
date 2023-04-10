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

namespace Тест_по_философии
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        // глобальные переменные для логина и пароля администратора
        string loginAdmin = "admin";
        string passwordAdmin = "admin";

        private void BTenter_Click(object sender, EventArgs e)
        {
            // подключение к базе данных с таблицей логинов и паролей пользователей
            SqlConnection connection = new SqlConnection(@"Data Source=192.168.10.151\SQLEXPRESS;Initial Catalog=Diplom;User ID=wsr-8;Password=#70c9E79b0281$");
            string select = "SELECT * FROM Users WHERE login= '" + tbLogin.Text + "' and password= '" + tbPassword.Text + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // проверка соответствия логина и пароля
            if (dataTable.Rows.Count ==1)
            {
                Test formTest = new Test();
                formTest.Show();
                this.Hide();
            }
            else if ( tbLogin.Text == loginAdmin && tbPassword.Text == passwordAdmin)
            {
                Administrator formAdmin = new Administrator();
                formAdmin.Show();
                this.Hide();
            }
            else if (tbLogin.Text == null && tbPassword.Text == null )
            {
                MessageBox.Show("Ошибка! Введите логин и пароль!", "Ошибка авторизации!");
            }
            else
            {
                MessageBox.Show("Ошибка! Неверный логин или пароль", "Ошибка авторизации!");
            }
        }
    }
}
