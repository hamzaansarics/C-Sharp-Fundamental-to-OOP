using System;
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
            //,,,,,,,,,,

            //WriteLine("Enter your marks in c#");
            //int num = Convert.ToInt32(ReadLine());
            //if(num>=70)
            //{
            //    WriteLine("your grade is 'A'");
            //}
            //else if(num>=50)
            //{
            //    WriteLine("your grade is 'B'");
            //}
            //else if(num>=33)
            //{
            //    WriteLine("your grade is 'C'");
            //}
            //else
            //{
            //    WriteLine("your are fail");
            //}
            //..............
            //WriteLine("Enter your marks");
            //int marks = Convert.ToInt32(ReadLine());
            //string result = marks >= 40 ? "paas" : "fail";
            //WriteLine("your result is {0}", result);
            //''''''''''
            //WriteLine("Enter your grade");
            //char ch=Convert.ToChar(ReadLine());
            //switch(ch)
            //{
            //    case 'A':
            //    case 'a':
            //        WriteLine("your garde is A");
            //        break;
            //    case 'B':
            //    case 'b':
            //        WriteLine("Your grade is B");
            //        break;
            //    case 'C':
            //    case 'c':
            //        WriteLine("your grade is c");
            //        break;
            //    default:
            //        WriteLine("Invalid choices");
            //        break;

            //}
            //,,,,,,,,,,,,,

            //,,,,,,,

            WriteLine("Enter your Cnic number");
            string num = ReadLine();
            string first = "";
            string second = "";
            string third = "";
            int rb = 0;
            int gb = 0;
            for (int i = 0; i < 15; i++)
            {
               if(num[i] != '-')
               {
                    first = first + num[i];
               }
               else
               {
                    rb = i;
                    break;
               } 
            }
            for (int i = rb + 1; i < 15; i++)
            {
                if (num[i] != '-')
                {
                    second = second + num[i];
                }   
                else
                {
                    gb = i;
                    break;
                }
            }
            for (int i = gb + 1; i < 15; i++)
            {
                third = third + num[i];
            }

            WriteLine("first code :  {0}", first);
            WriteLine("second code : {0}", second);
            WriteLine("third code : {0}", third);

            ReadKey();



 
        }
    }
}
