using System;
using static System.Console;

namespace OOPConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student obj = new Student();
            //obj.id = 5;
            //obj.name = "xyz";

            //Write("Enter Total Length : ");
            //int total = Convert.ToInt32(ReadLine());
            //Student[] student = new Student[total];
            //for (int i = 0; i < student.Length; i++)
            //{
            //    student[i] = new Student();
            //    Write("Enter Id : ");
            //    student[i].id = Convert.ToInt32(ReadLine());
            //    Write("Enter Name : ");
            //    student[i].name = ReadLine();
            //}

            //foreach (Student item in student)
            //{
            //    WriteLine($"{item.id} , {item.name}");
            //}



            //..........


            //Student obj = new Student();
            //obj.Id = Convert.ToInt32(ReadLine());
            ////obj.name = "";


            //    WriteLine($"{obj.Id} ");
            WriteLine("\t\t\tZiadti Checker Program 2018!!\n\n");
            WriteLine("Enter Name");
            Student obj = new Student();
            obj.Id =ReadLine();
            WriteLine(obj.Id+ " Ap k sath to bhut ziadti howi hy Bachpan me... kis kis ne ki bande dhondho?");


            WriteLine("Kya ap janna chahte hain k ap k sath kis kis ne ziadti ki\n For checking Z else N");
                while (true)
            {
                char z = Convert.ToChar(ReadLine());
                if (z == 'N' || z == 'n')

                {
                    WriteLine("Lagta a apko sharm a gai a...koi bat nh check kar lo ziadti bhi to karwa e li thi");
                }
                else if(z == 'Z' || z == 'z') 
                {
                    WriteLine("Hamsaye v keti,Patho Mussali,cement Khan,Gama Nai");
                }
               
            }
            ReadKey();


            //....

            //Student std = new Student();
            //std.SetId(-5);  //Set Id


            //WriteLine(std.GetId());   // Get Id

            //...

            //Student std = new Student();
            //std.Id = -5;   // Set 

            //WriteLine(std.Id);


            //..........

            Student std = new Student();
            //std.Address = "SA";  // Error

            ReadKey();
        }
    }
}
