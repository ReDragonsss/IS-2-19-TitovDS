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
    public partial class Задание1 : Form
    {
        public Задание1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        abstract class Accessories<k> //создание абстрак класс для послед наследования других 2 классов
        {
            protected string cena;
            protected string godvipuska;
            protected string articul;
            public Accessories(string Cena, string Godvipuska,string Articul)//конструктор для инициализации переменные
            {
                cena = Cena;
                godvipuska = Godvipuska;
                articul = Articul;
            }
            public abstract void Display(ListBox listbox1);
        }
        class Cp : Accessories<string>//1 наследник
        {
            public string chastota1;
            public string kolvoiader1;
            public string kolvopotokov1;
            public Cp(string Cena, string Godvipuska,string Articul, string Chastota, string Kolvoiader, string Kolvopotokov)//конструктор для инициализации переменные
               : base(Cena, Godvipuska,Articul)
            {
                chastota = Chastota;
                kolvoiader = Kolvoiader;
                kolvopotokov = Kolvopotokov;

            }
                  public string chastota { get { return chastota1; } set { chastota1= value;}}//доп логика
                  public string kolvoiader { get { return kolvoiader1; } set { kolvoiader1 = value; } }//доп логика
            public string kolvopotokov { get { return kolvopotokov1; } set { kolvopotokov1 = value; } }//доп логика
            public override void Display(ListBox listBox1)
                {
                listBox1.Items.Add($"-------------------------------------");
                listBox1.Items.Add($"Цена {cena}");
                listBox1.Items.Add($"Год выпуска {godvipuska}");
                listBox1.Items.Add($"Частота {chastota}");
                listBox1.Items.Add($"Количество ядер {kolvoiader}");
                listBox1.Items.Add($"Количество потоков {kolvopotokov}");
                listBox1.Items.Add($"Артикул{articul}");");
                listBox1.Items.Add("--------------------------------------");
                } 
        }
             class videocart : Accessories<string>//2 наследник
        {
                public string chastota1;
                public string proizvod1;
                public string obiempameti1;
         
                public videocart(string Cena, string Godvipuska, string Articul, string Chastota, string Proizvod, string Obiempameti)//конструктор для инициализации переменные
                   : base(Cena, Godvipuska,Articul)
                {
                    chastota = Chastota;
                    proizvod = Proizvod;
                    obiempameti = Obiempameti;

                }
                  public string chastota { get { return chastota1; } set { chastota1 = value; } }//переменная для получения текста и возращенее его
                  public string proizvod { get { return proizvod1; } set { proizvod1 = value; } }//переменная для получения текста и возращенее его
                  public string obiempameti { get { return obiempameti1; } set { obiempameti1 = value; } }//переменная для получения текста и возращенее его
            public override void Display(ListBox listBox1)
                 {
                    listBox1.Items.Add($"--------------------------------------");
                    listBox1.Items.Add($"Цена{cena}");
                    listBox1.Items.Add($"Год выпуска{godvipuska}");
                    listBox1.Items.Add($"Частота {chastota}");
                    listBox1.Items.Add($"Производитель {proizvod}");
                    listBox1.Items.Add($"Обьем памяти {obiempameti}");
                    listBox1.Items.Add($"Артикул {articul}");
                    listBox1.Items.Add($"--------------------------------------");
                 }
             }
        private void button1_Click(object sender, EventArgs e)
        {
            string cena = Convert.ToString(textBox1.Text);// заполнение переменных
            string godvipuska = Convert.ToString(textBox2.Text);// заполнение переменных
            string chastota = Convert.ToString(textBox3.Text);// заполнение переменных
            string proizvod = Convert.ToString(textBox4.Text);// заполнение переменных
            string obiempameti = Convert.ToString(textBox5.Text);// заполнение переменных
            string articul = Convert.ToString(textBox6.Text);
            videocart vd1 = new videocart(cena, godvipuska, articul, chastota, proizvod, obiempameti);
            vd1.Display(listBox1);//вызов метода
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cena = Convert.ToString(textBox1.Text);// заполнение переменных
            string godvipuska = Convert.ToString(textBox2.Text);// заполнение переменных
            string chastota = Convert.ToString(textBox3.Text);// заполнение переменных
            string kolvoiader = Convert.ToString(textBox4.Text);// заполнение переменных
            string kolvopotokov = Convert.ToString(textBox5.Text);// заполнение переменных
            string articul = Convert.ToString(textBox6.Text);// заполнение переменных
            Cp cp1 = new Cp(cena, godvipuska, articul, chastota, kolvoiader, kolvopotokov);
            cp1.Display(listBox1);//вызов метода
        }
    }
}
