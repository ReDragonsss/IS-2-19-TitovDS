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

namespace IS_2_19_TitivDS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public MySqlConnection conn;
        private void Form3_Load(object sender, EventArgs e)
        {
            string connStr = "server=caseum.ru;port=33332;user=test_user;" +
               "database=db_test;password=test_pass;";
            conn = new MySqlConnection(connStr);

        }

        class mysql
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            try { conn.Open}
            catch 
            {
                MessageBox.Show("Произошла ошибка");
            }
            finally 
            {
                MessageBox.Show("Подключение");
                conn.Close();
            }
        }
    }
}
