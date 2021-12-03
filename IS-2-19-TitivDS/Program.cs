using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_19_TitivDS
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Меню());
        }
        public class Vozrah
        {
            public string Connstring = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;"; // измененная конструкция из 2 задания
            public string GetDVozrah()
            {
                return Connstring;
            }
        }
    }
}

