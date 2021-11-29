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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        abstract class Accessories<k>
        {
            protected string cena;
            protected string godvipuska;
            protected string articul;
            public Accessories(string Cena, string Godvipuska,string Articul)
            {
                cena = Cena;
                godvipuska = Godvipuska;
                articul = Articul;
            }
            public abstract void Display(ListBox listbox1);
        }
        class Cp : Accessories<string>
        {
            public string chastota1;
            public string kolvoiader1;
            public string kolvopotokov1;
            public Cp(string Cena, string Godvipuska,string Articul, string Chastota, string Kolvoiader, string Kolvopotokov)
               : base(Cena, Godvipuska,Articul)
            {
                chastota = Chastota;
                kolvoiader = Kolvoiader;
                kolvopotokov = Kolvopotokov;

            }
                  public string chastota { get { return chastota1; } set { chastota1= value;}}
                  public string kolvoiader { get { return kolvoiader1; } set { kolvoiader1 = value; } }
                  public string kolvopotokov { get { return kolvopotokov1; } set { kolvopotokov1 = value; } }
                public override void Display(ListBox listBox1)
                {
                listBox1.Items.Add($"{cena},{godvipuska},{chastota},{kolvoiader},{kolvopotokov},");
                } 
        }
             class videocart : Accessories<string>
            {
                public string chastota1;
                public string proizvod1;
                public string obiempameti1;
         
                public videocart(string Cena, string Godvipuska, string Articul, string Chastota, string Proizvod, string Obiempameti)
                   : base(Cena, Godvipuska,Articul)
                {
                    chastota = Chastota;
                    proizvod = Proizvod;
                    obiempameti = Obiempameti;

                }
                 public string chastota { get { return chastota1; } set { chastota1 = value; } }
                  public string proizvod { get { return proizvod1; } set { proizvod1 = value; } }
                  public string obiempameti { get { return obiempameti1; } set { obiempameti1 = value; } }
                 public override void Display(ListBox listBox1)
                 {
                    listBox1.Items.Add($"{cena},{godvipuska},{chastota},{proizvod},{obiempameti},");
                 }

             }
        

        private void button1_Click(object sender, EventArgs e)
        {
          string cena = Convert.ToString(textBox1.Text);
          string godvipuska = Convert.ToString(textBox2.Text);
          string chastota = Convert.ToString(textBox3.Text);
          string kolvoiader = Convert.ToString(textBox4.Text);
          string kolvopotokov = Convert.ToString(textBox5.Text);
          string Articul = Convert.ToString(textBox6.Text);
            Cp cp1 = new Cp(cena, godvipuska, Articul, chastota, kolvoiader, kolvopotokov);
            cp1.Display(listBox1);
        }
    }
}
