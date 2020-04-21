using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student std = new Student();
            //Console.WriteLine(std.Email);

            //.........


            //Student std = new Student("ali@gmail.com");

            //.....

            //Student std = new Student();
            //std.Name = "Rizwan";
            //std.Data();


            //.........................................

            //Student std = new Student(5, "Ali");

            //............

            //Student std = new Student();
            //Console.Write("Enter Id : ");
            //std.Id = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Name : ");
            //std.Name = Console.ReadLine();
            //Console.Write("Enter Email : ");
            //std.Email = Console.ReadLine();

            //std.Method1();

            //...........

            //Student std = new Student();
            //Console.Write("Enter Id : ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Name : ");
            //string name = Console.ReadLine();
            //Console.Write("Enter Email : ");
            //string email = Console.ReadLine();

            ////std.Method1(id, name, email);

            ////string d = std.Method1(name, id, email);

            //Console.WriteLine(std.Method1(name, id, email));

            //.....

            Student std = new Student();
            Console.Write("Enter Id : ");
            std.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name : ");
            std.Name = Console.ReadLine();
            Console.Write("Enter Email : ");
            std.Email = Console.ReadLine();

            string d = std.Method();

            Console.WriteLine("Data : {0}", d);

            //........

            //Console.Write("Enter Amount : ");
            //decimal amount = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Amount is : {0:C}", amount);

            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Today : {0:y}", dateTime);

        }
    }
}
