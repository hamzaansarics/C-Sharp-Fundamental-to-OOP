using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("User Name Should Be Contain Least one Digit");
            song geo = new song();
            geo.Name = ReadLine();
            WriteLine(geo.Name);
            ReadKey();
        }
    }
}
