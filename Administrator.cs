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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        DataSet dataSet;

        void GetList()
        {
            // подключение к базе данных для вывода таблицы в dataGridView1
            connection = new SqlConnection(@"Data Source=192.168.10.151\SQLEXPRESS;Initial Catalog=Diplom;User ID=wsr-8;Password=#70c9E79b0281$");
            dataAdapter = new SqlDataAdapter("SELECT * FROM Users", connection);
            connection.Open();
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Users");
            dataGridView1.DataSource = dataSet.Tables["Users"];
            connection.Close();
        }
        private async void Administrator_Load(object sender, EventArgs e)
        {
            GetList();
            // вывод таблицы с результатами
            String connectionString = @"Data Source=192.168.10.151\SQLEXPRESS;Initial Catalog=Diplom;User ID=wsr-8;Password=#70c9E79b0281$";
            connection = new SqlConnection(connectionString);
            await connection.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Result]", connection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["name"]) + " - " + Convert.ToString(sqlReader["result"]) + " % ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
            connection.Close();
        }
        
        // добавление новых пользователей в таблицу
        private void BTinsert_Click(object sender, EventArgs e)
        {
            command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = "INSERT INTO Users(id, login, password) values (" + tbId.Text + ",'" + tbLogin.Text + "','" + tbPassword.Text + "')";
            command.ExecuteNonQuery();
            connection.Close();
            GetList();

            tbId.Text = null;
            tbLogin.Text = null;
            tbPassword.Text = null;
        }

        // открытие файла с инструкцией
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.txt");
        }

        // выход из окна администратора
        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Authorization formAuthorization = new Authorization();
            formAuthorization.Show();
            this.Hide();
        }

    }
    
    
}
