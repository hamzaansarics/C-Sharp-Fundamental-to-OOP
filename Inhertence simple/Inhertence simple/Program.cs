using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inhertence_simple
{
    class Program
    {
        static void Main(string[] args)
        {
           
            #region Practice
            Student[] ge = new Student[2];

            //ge[0] = new Student();
            //ge[0].id = 12;
            //ge[0].name = "love";

            //ge[0].id1 = 13;
            //ge[0].name1 = "Love Mashup";


            WriteLine("Enter Data");
            for (int i = 1; i < ge.Length; i++)
            {
                ge[i] = new Student();
                WriteLine("Enter ID: ");
                ge[i].id = Convert.ToInt32(ReadLine());
                Console.WriteLine("Enter Name: ");
                ge[i].name = ReadLine();


                Console.WriteLine("Enter SID: ");
                ge[i].id = Convert.ToInt32(ReadLine());
                Console.WriteLine("Enter SName: ");
                ge[i].name = ReadLine();
            }

            //Console.WriteLine(ge[i].id+ge[i].name+ge[i].sid+ge[i].sname);

            Console.WriteLine("1-For SHow ALl Data\n2-search by name");
            int a = Convert.ToInt32(ReadLine());
            if (a == 1)
            {
                for (int i = 0; i < ge.Length; i++)
                {
                    ge[i] = new Student();
                    Console.WriteLine(ge[i].id1 + ge[i].name1+ge[i].id +ge[i].name);
                }
            }

            //  int b = Convert.ToInt32(ReadLine());
            if (a == 2)
            {

                WriteLine("Enter name");
                string name = ReadLine();

                for (int i = 0; i < ge.Length; i++)
                {
                     ge[i] = new Student();
                    if (name == ge[i].name)
                    {
                        Console.WriteLine(ge[i].id + ge[i].name);
                    }



                }



                //  }
                #endregion

                ReadKey();


            }
        }
    }
}
