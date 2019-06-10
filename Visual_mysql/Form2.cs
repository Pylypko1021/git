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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form1 Form112 = new Form1();
            Form112.Size = new Size(1920, 1080);
            // Display the form in the center of the screen.saadas
            Form112.StartPosition = FormStartPosition.CenterScreen;

            Form112.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] number = Encoding.UTF8.GetBytes(textBox1.Text);
            byte[] date = Encoding.UTF8.GetBytes(dateTimePicker1.Text);
            byte[] frequency = Encoding.UTF8.GetBytes(textBox3.Text);
            byte[] post = Encoding.UTF8.GetBytes(textBox4.Text);
            byte[] coordinates = Encoding.UTF8.GetBytes(textBox5.Text);
            byte[] locate = Encoding.UTF8.GetBytes(comboBox1.Text);
            byte[] modulation = Encoding.UTF8.GetBytes(textBox7.Text);
            byte[] type = Encoding.UTF8.GetBytes(textBox8.Text);
            byte[] vidom = Encoding.UTF8.GetBytes(textBox9.Text);
            byte[] udcr = Encoding.UTF8.GetBytes(textBox10.Text);
            byte[] ta = Encoding.UTF8.GetBytes(textBox11.Text);


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
            string query = "INSERT INTO radio (number, date, frequency, post, coordinates, locate, modulation, type, vidom, udcr, ta) VALUES(@number, @date, @frequency, @post, @coordinates, @locate, @modulation, @type, @vidom, @udcr, ta)";
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
            conn.Close();
            MessageBox.Show("Картка додана");
        }
    }
}
