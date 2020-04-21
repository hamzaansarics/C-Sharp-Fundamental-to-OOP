using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pk = { "hassaan", "love", "pak", "Moon" };
            WriteLine("Enter word");
            string g = ReadLine();
            for(int i=0; i<pk.Length; i++)
            {
                if(g==pk[i])
                {
                    WriteLine("Amazing");
                }
            }
            ReadKey();
        }
    }
}
