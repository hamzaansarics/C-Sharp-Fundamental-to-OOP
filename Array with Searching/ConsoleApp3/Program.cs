using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] geo = new int[5] { 1, 4, 6, 9, 5 };
            WriteLine("Enter value");
            int loc= -1;
            int a = Convert.ToInt32(ReadLine());
            for(int i=0; i<geo.Length; i++)

            {
                if(a==geo[i])
                {
                    loc = i;
                }
               
            }
            if(loc==-1)
            {
                WriteLine("Not Found");
            }
            else
            {
                int v = loc + 1;
                WriteLine("Location is "+v);
            }
            ReadKey();
        }
    }
}
