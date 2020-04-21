using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] geo = new Student[3]
            {
                new Student()
                {
                    id = 12,
                    name = "khan",
                    email="bloggersofrever250@gmail.com",
                    adress="Faislabad"
                },
                new Student()
                {
                    id = 165,
                    name = "love",
                    email="shehzada250@gmail.com",
                    adress="Faislabad"
                },
                 new Student()
                {
                    id = 15,
                    name = "love man",
                    email="shehzada250@gmail.com",
                    adress="Kalowal"
                }
            };


            //geo[0] = new Student()
            //{
            //    id = 12,
            //    name = "khan",
            //    email="bloggersofrever250@gmail.com",
            //    adress="Faislabad",
            //};
            //geo[1] = new Student()
            //{
            //    id = 156,
            //    name = "ansari",
            //    email = "bloggersofrever25@gmail.com",
            //    adress = "kalowal",
            //};
            //geo[2] = new Student()
            //{
            //    id = 10,
            //    name = "geo",
            //    email = "geo@gmail.com",
            //    adress = "punjab",
            //};
            //geo[3] = new Student()
            //{
            //    id = 12,
            //    name = "ansari",
            //    email = "ansari250@gmail.com",
            //    adress = "haidrabad",
            //};
            //geo[4] = new Student()
            //{
            //    id = 12,
            //    name = "shehzada",
            //    email = "shezada@gmail.com",
            //    adress = "Islamabad",
            //};
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            //for (int i = 0; i < geo.Length; i++)
            //{

            //    if(name==geo[i].name)
            //    {
            //        Console.WriteLine($"{geo[i].id} , {geo[i].name} , {geo[i].email} , {geo[i].adress}");
            //    }
            //}
            foreach (var item in geo)
            {
                if(name==item.name)
                {
                    Console.WriteLine($"{item.id} , {item.name} , {item.email} , {item.adress}");
                }

            }


            //for (int i = 0; i < geo.Length; i++)
            //{
            //    Console.WriteLine($"{geo[i].id} , {geo[i].name} , {geo[i].email} , {geo[i].adress}");
            //}

            Console.ReadKey();
        }
    }
}
