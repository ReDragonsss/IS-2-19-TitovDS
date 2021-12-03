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
using ClassLibrary1;

namespace IS_2_19_TitivDS
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB conn = new ConnectDB();
            MySqlConnection connn = new MySqlConnection(conn.Connstring);
            string fio = textBox1.Text;
            string vremia = textBox2.Text;
            string sql = $"INSERT INTO t_PraktStud (fioStud, datetimeStud)  VALUES ('{fio}','{vremia}');";
            int perem = 0;
            try
            {
                connn.Open();
                MySqlCommand command1 = new MySqlCommand(sql, connn);
                perem = command1.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("непофиксил");
            }
            finally
            {
                connn.Close();
                if (perem != 0)
                {
                    MessageBox.Show("пофиксил");
                }
            }
        }
    }
}
   

