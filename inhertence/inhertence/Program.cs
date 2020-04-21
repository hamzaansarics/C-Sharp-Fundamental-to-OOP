using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace inhertence
{
    class Program
    {
        static void Main(string[] args)
        {
            Child aa = new Child();
            aa.Id = 12;
            aa.name = "hamza ansai";
            Console.WriteLine(aa.Id + " " + aa.name);

            Console.ReadKey();  
        }
    }

}
