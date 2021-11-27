using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_19_TitivDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public abstract class people<k>
        {
            public string fio;
            public string datroj;
            public long tel;
            public k kod;
            public people(string Fio, string Datroj, long Tel, k Kod)
            {
                fio = Fio;
                datroj = Datroj;
                tel = Tel;
                kod = Kod;
            }
            public abstract void Display();


        }
        public class Sotrudnik<k> : people<k>
        {
            public string dolj;
            public int zarplat;
            public Sotrudnik(string Fio, string Datroj, long Tel, string Dolj, int Zarplat, k Kod)
               : base(Fio, Datroj, Tel, Kod)
            {
                dolj = Dolj;
                zarplat = Zarplat;

            }
            public override void Display()
            {
                MessageBox.Show($" Сотрудник {fio}, дата рождения {datroj}, номер телефона {tel}, должность {dolj},с заработная плата {zarplat}, уникальный код{kod}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sotrudnik<int> st1 = new Sotrudnik<int>(Convert.ToString(textBox1.Text), Convert.ToString(textBox2.Text), Convert.ToInt64(textBox3.Text), Convert.ToString(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)); ;
            st1.Display();
        }
    }
}


    }
}
