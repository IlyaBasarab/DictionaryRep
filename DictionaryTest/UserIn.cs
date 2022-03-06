using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest
{
    class UserIn
    {

        public int UserEnterNumber()
        {
            return Convert.ToInt32(Console.ReadLine());

        }

        public string UserEnterString()
        {
            return Console.ReadLine();
        }



    }
}
