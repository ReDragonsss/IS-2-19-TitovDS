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
        static class Vozrah
        {
            public static string GetDVozrah()
            {
                string host = "caseum.ru";
                string port = "33333";
                string database = "db_test";
                string username = "test_user";
                string password = "test_pass";
                string connString = $"server={host};port={port};user={username};database={database};password={password};";
                return connString;
            }
        }
        MySqlConnection conn = new MySqlConnection(Vozrah.GetDVozrah());
        public Form3()
        {
            InitializeComponent();
        } 
        private void Form3_Load(object sender, EventArgs e)
        {
        }
            private void button1_Click(object sender, EventArgs e)
            {
            try
            {
                conn.Open();
                MessageBox.Show("Подключение");
                conn.Close();
            }
            catch(Exception osh)
            {
                MessageBox.Show("Произошла ошибка"+ osh);
                conn.Close();
            }
            }
    }
}
