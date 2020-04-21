using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());

                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a/b);

            }
            catch (Exception af)
            {

                Console.WriteLine(af.Message);
            }


            Console.ReadKey();
        }
    }
}
