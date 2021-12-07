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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            ConnectDB conn = new ConnectDB();// подключ класс из длл
            MySqlConnection connn = new MySqlConnection(conn.Connstring);
            string sql = $"SELECT idStud, fioStud, drStud FROM t_datetime";// запрос на вынос данных ида фио и дне рожд
            try
            {
                connn.Open();
                MessageBox.Show("Подключение");
                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(sql, connn);
                DataSet dataset = new DataSet();
                IDataAdapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
                connn.Close();
            }
            catch (Exception osh)
            {
                MessageBox.Show("Произошла ошибка" + osh);
                connn.Close();
            }       
        }
        string id_rows5 = "0";
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))// код срабат на лкм
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];// определение  строки

                dataGridView1.CurrentRow.Selected = true;

                string index_rows5;

                index_rows5 = dataGridView1.SelectedCells[0].RowIndex.ToString();

                id_rows5 = dataGridView1.Rows[Convert.ToInt32(index_rows5)].Cells[2].Value.ToString();
                DateTime x = DateTime.Today;
                DateTime y = Convert.ToDateTime(dataGridView1.Rows[Convert.ToInt32(index_rows5)].Cells[2].Value.ToString());// Переменной  присваевается значение выбранной строки
                string DayR = (x - y).ToString(); 
                MessageBox.Show("дней с рождения " + DayR.Substring(0, DayR.Length - 9)); 
            }
        }
    }
}
