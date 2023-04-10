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
using System.IO;

namespace Тест_по_философии
{
    public partial class Test : Form
    {
        string fileName = "philosophytest.txt";
        string[,] massiv;
        int linesTest, numQuestions, trueAnswer, falseAnswer;
        static Random rand = new Random();
        public int result;

        SqlConnection connection;
        SqlCommand command;

        public Test()
        {
            InitializeComponent();
            InitTest();
        }

        private void BTstart_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("пожалуйста введите свое имя!", "Ошибка!");
            }
            else
            {
                labelQuestion.Visible = true;
                RBanswer1.Visible = true;
                RBanswer2.Visible = true;
                RBanswer3.Visible = true;
                BTnext.Visible = true;
                labelResult.Visible = true;

                labelName.Visible = false;
                tbName.Visible = false;
                BTstart.Visible = false;
            }
        }

        private void InitTest()
        {
            numQuestions = 10;
            trueAnswer = 0;
            falseAnswer = 0;
            LoadFile();
            RadioChecked();
            labelResult.Text = "";
            numQuestions--;
            ShowQuestion();
        }

        // создание массива с вопросами
        private void LoadFile()
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);
                linesTest = lines.Length / 4;
                massiv = new string[numQuestions, 4];

                int[] temp = new int[numQuestions];
                int j;
                int k = 0;
                do
                {
                    j = rand.Next(0, linesTest) * 4;
                    if (!temp.Contains(j))
                    {
                        massiv[k, 0] = lines[j];
                        for (int i = 1; i < 4; i++)
                            massiv[k, i] = lines[j + i];
                        temp[k] = j;
                        k++;
                    }
                } while (!(k == numQuestions));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // вывод вопросов
        private void ShowQuestion()
        {
            RadioChecked();
            labelQuestion.Text = massiv[numQuestions, 0];
            RadioTags(rand.Next(1, 7));
            RBanswer1.Text = massiv[numQuestions, Convert.ToInt16(RBanswer1.Tag)];
            RBanswer2.Text = massiv[numQuestions, Convert.ToInt16(RBanswer2.Tag)];
            RBanswer3.Text = massiv[numQuestions, Convert.ToInt16(RBanswer3.Tag)];
        }

        // обработка ответа
        private void BTnext_Click(object sender, EventArgs e)
        {
            if (numQuestions < 0) { InitTest(); return; }

            if (!(RBanswer1.Checked || RBanswer2.Checked || RBanswer3.Checked))
            {
                MessageBox.Show("Выберите вариант ответа");
                return;
            }
            if ((RBanswer1.Checked & Convert.ToInt16(RBanswer1.Tag) == 1) ||
                (RBanswer2.Checked & Convert.ToInt16(RBanswer2.Tag) == 1) ||
                (RBanswer3.Checked & Convert.ToInt16(RBanswer3.Tag) == 1))
            {
                trueAnswer++;
                numQuestions--;
            }
            else
            {
                MessageBox.Show("Правильный вариант ответа: " + massiv[numQuestions, 1]);
                falseAnswer++;
                numQuestions--;
            }
            if (numQuestions < 0)
            {
                ShowResult();
                labelQuestion.Text = "Результат теста:";
                RBanswer1.Visible = false;
                RBanswer2.Visible = false;
                RBanswer3.Visible = false;
                return;
            }
            ShowQuestion();
        }

        private void RadioChecked()
        {
            RBanswer1.Checked = false;
            RBanswer2.Checked = false;
            RBanswer3.Checked = false;
        }


        private void RadioTags(int i)
        {
            switch (i)
            {
                case 1: RBanswer1.Tag = 1; RBanswer2.Tag = 2; RBanswer3.Tag = 3; break;
                case 2: RBanswer1.Tag = 1; RBanswer2.Tag = 3; RBanswer3.Tag = 2; break;
                case 3: RBanswer1.Tag = 2; RBanswer2.Tag = 1; RBanswer3.Tag = 3; break;
                case 4: RBanswer1.Tag = 2; RBanswer2.Tag = 3; RBanswer3.Tag = 1; break;
                case 5: RBanswer1.Tag = 3; RBanswer2.Tag = 1; RBanswer3.Tag = 2; break;
                case 6: RBanswer1.Tag = 3; RBanswer2.Tag = 2; RBanswer3.Tag = 1; break;
            }
        }


        // вывод результата
        private void ShowResult()
        {
            result = (trueAnswer * 100) / 10;
            labelResult.Text = "Правильных ответов: " + trueAnswer.ToString() + "\n" +
                               "Неправильных ответов: " + falseAnswer.ToString() + "\n" +
                               result.ToString() + " %";
            BTnext.Visible = false;
            BTexit.Visible = true;
        }

        // сохранение результатов в таблицу и выход в окно авторизации
        private void BTexit_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=192.168.10.151\SQLEXPRESS;Initial Catalog=Diplom;Integrated Security=true;User ID=wsr-8;Password=#70c9E79b0281$");
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "insert into Result (result, name) values (" + result.ToString() + ",'" + tbName.Text + "')";
            command.ExecuteNonQuery();
            connection.Close();

            Authorization formAuthorization = new Authorization();
            formAuthorization.Show();
            this.Hide();
        }

        // открытие файла с инструкцией
        private void HelpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "helpUser.txt");
        }

    }
}
