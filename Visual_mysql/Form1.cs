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
           // DataGridView1CellClick();
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
        private void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox14.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox15.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] number = Encoding.UTF8.GetBytes(textBox5.Text);
            byte[] date = Encoding.UTF8.GetBytes(textBox6.Text);
            byte[] frequency = Encoding.UTF8.GetBytes(textBox7.Text);
            byte[] post = Encoding.UTF8.GetBytes(textBox8.Text);
            byte[] coordinates = Encoding.UTF8.GetBytes(textBox9.Text);
            byte[] locate = Encoding.UTF8.GetBytes(textBox10.Text);
            byte[] modulation = Encoding.UTF8.GetBytes(textBox11.Text);
            byte[] type = Encoding.UTF8.GetBytes(textBox12.Text);
            byte[] vidom = Encoding.UTF8.GetBytes(textBox13.Text);
            byte[] udcr = Encoding.UTF8.GetBytes(textBox14.Text);
            byte[] ta = Encoding.UTF8.GetBytes(textBox15.Text);


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
            string query = "UPDATE radio SET date = @date, frequency =@frequency , post =@post , coordinates =@coordinates , locate =@locate , modulation =@modulation , vidom =@vidom , udcr =@udcr , ta =@ta  WHERE number = @number";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("number", number);
            command.Parameters.AddWithValue("date", date);
            command.Parameters.AddWithValue("frequency", frequency);
            command.Parameters.AddWithValue("post", post);
            command.Parameters.AddWithValue("coordinates", coordinates);
            command.Parameters.AddWithValue("locate", locate);
            command.Parameters.AddWithValue("modulation", modulation);
            command.Parameters.AddWithValue("type", type);
            command.Parameters.AddWithValue("vidom", vidom);
            command.Parameters.AddWithValue("udcr", udcr);
            command.Parameters.AddWithValue("ta", ta);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Close();
            dataGridView1.Rows.Clear();
            string query1 = "SELECT * FROM radio";

            MySqlCommand command1 = new MySqlCommand(query1, conn);

            MySqlDataReader reader1 = command1.ExecuteReader();
            MessageBox.Show("Картка змінена");

            List<string[]> data = new List<string[]>();

            while (reader1.Read())
            {
                data.Add(new string[11]);

                data[data.Count - 1][0] = reader1[0].ToString();
                data[data.Count - 1][1] = reader1[1].ToString();
                data[data.Count - 1][2] = reader1[2].ToString();
                data[data.Count - 1][3] = reader1[3].ToString();
                data[data.Count - 1][4] = reader1[4].ToString();
                data[data.Count - 1][5] = reader1[5].ToString();
                data[data.Count - 1][6] = reader1[6].ToString();
                data[data.Count - 1][7] = reader1[7].ToString();
                data[data.Count - 1][8] = reader1[8].ToString();
                data[data.Count - 1][9] = reader1[9].ToString();
                data[data.Count - 1][10] =reader1[10].ToString();

            }

            reader1.Close();

            conn.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        
    }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] number = Encoding.UTF8.GetBytes(textBox5.Text);
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
            string query = "DELETE FROM radio WHERE number = @number";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("number", number);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Close();
            MessageBox.Show("Картка видалена");
            dataGridView1.Rows.Clear();
            string query2 = "SELECT * FROM radio";

            MySqlCommand command2 = new MySqlCommand(query2, conn);

            MySqlDataReader reader2 = command2.ExecuteReader();
            

            List<string[]> data = new List<string[]>();

            while (reader2.Read())
            {
                data.Add(new string[11]);

                data[data.Count - 1][0] = reader2[0].ToString();
                data[data.Count - 1][1] = reader2[1].ToString();
                data[data.Count - 1][2] = reader2[2].ToString();
                data[data.Count - 1][3] = reader2[3].ToString();
                data[data.Count - 1][4] = reader2[4].ToString();
                data[data.Count - 1][5] = reader2[5].ToString();
                data[data.Count - 1][6] = reader2[6].ToString();
                data[data.Count - 1][7] = reader2[7].ToString();
                data[data.Count - 1][8] = reader2[8].ToString();
                data[data.Count - 1][9] = reader2[9].ToString();
                data[data.Count - 1][10] = reader2[10].ToString();

            }

            reader2.Close();

            conn.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
    }
}
