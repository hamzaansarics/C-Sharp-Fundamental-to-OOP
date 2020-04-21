using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter Name : ");
            //string name = Console.ReadLine();

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //Nullable<int> a = 10;

            int? a = 10;
            int b = a ?? 5;
            Console.WriteLine(b);


        }
    }
}
