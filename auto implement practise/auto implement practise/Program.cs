using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace auto_implement_practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = Convert.ToInt32(ReadLine());
            string a = ReadLine();
            khan ag = new khan(v,a);
            ReadKey();
        }
    }
}
