using System;
using static System.Console;
using System.Linq;  // LINQ --- Language INtegrated Query

namespace OOPLecture07
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3]
            {
                new Student()
                {
                    Id = 1,
                    Name = "Hammad"
                },
                new Student()
                {
                    Id = 2,
                    Name = "Bilal"
                },
                new Student()
                {
                    Id = 3,
                    Name = "Ahmad"
                }
            };

            //
            Write("Enter Name : ");
            string name = ReadLine();

            //var search = students.Where(m => m.Name.Equals(name)); // LINQ Method

            var search = from d in students
                         where d.Name == name
                         select d;

            foreach (var item in search)
            {
                WriteLine($"{item.Id} , {item.Name}");
            }

            ReadKey();
        }
    }
}
