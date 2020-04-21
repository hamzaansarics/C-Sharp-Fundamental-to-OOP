using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] geo = { 12, 3, 4, 5, 77,22 };
         for(int i=0; i<geo.Length; i++)
            {
                Array.Sort(geo);
                WriteLine(geo[i]);

            }
            ReadKey();
        }
    }
}
