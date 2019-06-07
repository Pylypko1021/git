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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
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
            conn.Open();

            string query = "SELECT * FROM radio";

            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[14]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                
            }

            reader.Close();

            conn.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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
            conn.Open();
            String id1 = Convert.ToString(textBox1.Text);
            String id2 = Convert.ToString(textBox2.Text);
            String date1 = Convert.ToString(textBox3.Text);
            String date2 = Convert.ToString(textBox4.Text);

            string query = "";
            if (textBox3.Text == "" && textBox4.Text == "")
            {
                query = "SELECT * FROM radio WHERE frequency BETWEEN @id1 AND @id2 ORDER BY frequency ASC";
            }
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                query = "SELECT * FROM radio WHERE date BETWEEN @date1 AND @date2 ORDER BY frequency ASC";
            }
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                query = "SELECT * FROM radio WHERE frequency BETWEEN @id1 AND @id2 AND date BETWEEN @date1 AND @date2 ORDER BY frequency ASC";
            }
           
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("id1", id1);
            command.Parameters.AddWithValue("id2", id2);
            command.Parameters.AddWithValue("date1", date1);
            command.Parameters.AddWithValue("date2", date2);

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[14]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                
            }

            reader.Close();

            conn.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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
            conn.Open();

            string query = "SELECT * FROM radio";

            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[11]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
              
            }

            reader.Close();

            conn.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form2 Form212 = new Form2();
            Form212.Text = "My Form";
            // Set the opacity to 75%.
            // Form212.Opacity = .75;
            // Size the form to be 300 pixels in height and width.
            Form212.Size = new Size(1980, 1080);
            // Display the form in the center of the screen.
            Form212.StartPosition = FormStartPosition.CenterScreen;
            Form212.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form3 Form312 = new Form3();
            Form312.Text = "My Form";
            // Set the opacity to 75%.
            // Form212.Opacity = .75;
            // Size the form to be 300 pixels in height and width.
            Form312.Size = new Size(1980, 1080);
            // Display the form in the center of the screen.
            Form312.StartPosition = FormStartPosition.CenterScreen;
            Form312.ShowDialog();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
