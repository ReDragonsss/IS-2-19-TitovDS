using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB
{
    public class ConnectDB
    {

        public string Connstring = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;"; // измененная конструкция из 2 задания
        public string GetDVozrah()
        {
            return Connstring;
        }

    }
}
