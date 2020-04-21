using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Class1
    {


        public string[] id;

        public void data()
        {
            Console.WriteLine("Enter CNIC");
            id[16] = Console.ReadLine();
            for (int i = 0; i < 16; i++)
            {
                
                if (id[i] =="-" && id[i]=="-")
                {
                    Console.WriteLine("Good");
                }
                else
                {
                    Console.WriteLine("it's not cnic id");
                }

            }
        }


    }
}
