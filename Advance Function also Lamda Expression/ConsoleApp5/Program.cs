using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            var s = student.Data();
            Console.WriteLine(s);


            Console.ReadKey();
        }
    }
}
