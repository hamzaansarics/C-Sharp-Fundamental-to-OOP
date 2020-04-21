using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter Length");
            int b = Convert.ToInt32(ReadLine());
            
            Ansari[] geo = new Ansari[b];
            for(int i=0; i < geo.Length; i++)
            {
                geo[i] = new Ansari();
                WriteLine("Enter the Id");
                geo[i].id = Convert.ToInt32(ReadLine());
                WriteLine("Enter Name");
                geo[i].name = ReadLine();
                WriteLine("Enter Roll NO.");
                geo[i].roln = Convert.ToInt32(ReadLine());
                WriteLine("Enter Phone No.");
                geo[i].pn = Convert.ToInt64(ReadLine());
                WriteLine("Enter Email");
                geo[i].email = ReadLine();
                WriteLine("Enter Adress");
                geo[i].adrs = ReadLine();
            }

            
            while (true)
            {
                WriteLine("1-Show All Record \n2-Search by Roll No:\n3-search by keyword\n4 for Exit");
                int a = Convert.ToInt32(ReadLine());
                if (a == 1)
                {
                    for (int i = 0; i < geo.Length; i++)
                    {
                        WriteLine("Name: " + geo[i].name);
                        WriteLine("ID:" + geo[i].id);
                        WriteLine("Roll NO: " + geo[i].roln);
                        WriteLine("Phone NO: " + geo[i].pn);                       
                        WriteLine("Email: " + geo[i].email);
                        WriteLine("Address: "+geo[i].adrs);
                       
                    }
                }
                if (a == 2)
                {
                    WriteLine("Enter Roll NO:");
                    int c = Convert.ToInt32(ReadLine());
                    for (int i = 0; i < geo.Length; i++)
                    {
                        if (c == geo[i].roln)
                        {
                            WriteLine("Name: " + geo[i].name);
                            WriteLine("ID:" + geo[i].id);
                            WriteLine("Roll NO: " + geo[i].roln);
                            WriteLine("Phone NO: " + geo[i].pn);
                            WriteLine("Email: " + geo[i].email);
                            WriteLine("Address: " + geo[i].adrs);
                        }
                    }
                }
                if (a == 3)
                {
                    WriteLine("Enter Keyword");
                    string keyword = ReadLine();
                    for (int i = 0; i < geo.Length; i++)
                    {
                        if (geo[i].name.Contains(keyword))
                        {
                            WriteLine("Name: " + geo[i].name);
                            WriteLine("ID:" + geo[i].id);
                            WriteLine("Roll NO: " + geo[i].roln);
                            WriteLine("Phone NO: " + geo[i].pn);
                            WriteLine("Email: " + geo[i].email);
                            WriteLine("Address: " + geo[i].adrs);
                        }
                    }
                }
            }
            ReadKey();
        }
    }
}
