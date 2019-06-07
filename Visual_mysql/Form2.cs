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
    }
}
