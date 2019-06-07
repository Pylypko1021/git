using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Visual_mysql
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
            string userName = "root"; // Имя пользователя
            string dbName = "ranok"; //Имя базы данных
            string port = "3306"; // Порт для подключения
            string password = "gegyhegut619"; // Пароль для подключения
            string connStr = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";port=" + port +
                ";password=" + password + ";";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand com = new MySqlCommand();
            conn.Open();

            string login = "";
           login = textBox9.Text;
            
            string passwd = "";
            passwd = textBox7.Text;
            com.Connection = conn;
            com.CommandText = string.Format("Select login,password from users where login='{0}' AND password='{1}'", login, passwd);
            string rezultat = (string)com.ExecuteScalar();
            if (rezultat == login)
            {
                MessageBox.Show("Найден");
            }
            else
            {

                MessageBox.Show("Комбинация логина и пароля не найдена!");
                conn.Close();
            }

            Form3.ActiveForm.Hide();
            Form1 Form112 = new Form1();
            Form112.Size = new Size(1920, 1080);
            // Display the form in the center of the screen.
            Form112.StartPosition = FormStartPosition.CenterScreen;

            Form112.ShowDialog();
            Close();

        }
        }
    }


