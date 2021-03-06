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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Program.Vozrah conn = new Program.Vozrah();// использование метода из program
            MySqlConnection connn = new MySqlConnection(conn.Connstring);
            string sql = $"SELECT id, fio, theme_kurs FROM t_stud";// запрос на вынос из бд ида фио и темы курс
            try// правильность подключ
            {
                connn.Open();
                MessageBox.Show("Подключение");
                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(sql, connn);
                DataSet dataset = new DataSet();
                IDataAdapter.Fill(dataset);// заполнение датагрида
                dataGridView1.DataSource = dataset.Tables[0];
                connn.Close();
            }
            catch (Exception osh)
            {
                MessageBox.Show("Произошла ошибка" + osh);
                connn.Close();
            }

        }
        string id_rows = "0";
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))// срабатывает при нажатии на лкм
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];// отвечает за то куда нажали

                dataGridView1.CurrentRow.Selected = true;

                string index_rows;

                index_rows = dataGridView1.SelectedCells[0].RowIndex.ToString();

                id_rows = dataGridView1.Rows[Convert.ToInt32(index_rows)].Cells[1].Value.ToString(); // Переменной  присваевается значение выбранной строки
                MessageBox.Show(id_rows);
            }
        }
    }
}
