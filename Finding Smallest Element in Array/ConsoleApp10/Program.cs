using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 5, 7, 8, 2 };
            int small = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (small > arr[i])
                {
                    small = arr[i];
                }

            }
            Console.WriteLine(small);


            //while (true)
            //{
            //    Console.WriteLine("Enter number :");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if(num==0)
            //    {
            //       // break;
            //        throw new Exception("Stopped : ");

            //    }

            //}
            Console.ReadKey();

        }
    }
}
