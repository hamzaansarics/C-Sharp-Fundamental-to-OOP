using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter NO of Length");
            int a = Convert.ToInt32(ReadLine());
            Student[] pk = new Student[a];
            for(int i=0; i<pk.Length; i++)
            {
                pk[i] = new Student(); 
                WriteLine("Enter id");
                pk[i].id = Convert.ToInt32(ReadLine());
                WriteLine("Enter name");
                pk[i].name = ReadLine();
            }
            WriteLine("Enter press 1 for getting whole output\n2-for search by name\n3-for search by keywords\n4-Out to the program");
            int b = Convert.ToInt32(ReadLine());
            if(b==1)
            {
                foreach (var item in pk)
                {
                    WriteLine("Output" + item.id + " " + item.name);
                }

            }
            else if(b==2)
            {
                WriteLine("Search By FUll Name");
                string v = ReadLine();
                for(int i=0; i<v.Length; i++)
                {
                    if(v==pk[i].name)
                    {
                        WriteLine(pk[i].id + "" + pk[i].name);
                    }
                }
            }
            else if(b==3)
            {

                WriteLine("Search by keywords");
                string g = ReadLine();
                for(int i=0; i<pk.Length; i++)
                {
                    if(pk[i].name.Contains(g))
                    {
                        WriteLine(pk[i].id + pk[i].name);
                    }
                }
            }
            else if(b==4)
            {
                WriteLine("Allah Hafiz");
               
            }
            
            ReadKey();
        }
    }
}
