using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Encapsulation_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            khan geo = new khan();
            WriteLine("Enter Name");
            geo.Name = ReadLine();
            WriteLine("Name:" + geo.Name);

            WriteLine("Enter Email");
            geo.Email = ReadLine();
            WriteLine("Email:" + geo.Email);

            WriteLine("Enter Roll No:");
            geo.Rno = Convert.ToInt32(ReadLine());
            WriteLine("Roll NO:" + geo.Rno);

            WriteLine("Enter Phone No:");
            geo.Pn = Convert.ToInt64(ReadLine());
            WriteLine("Phone NO:" + geo.Pn);

            WriteLine("Enter CGPA:");
            geo.CGPA = Convert.ToInt32(ReadLine());
            WriteLine("CGPA:" + geo.CGPA);

            ReadKey();
        }
    }
}
