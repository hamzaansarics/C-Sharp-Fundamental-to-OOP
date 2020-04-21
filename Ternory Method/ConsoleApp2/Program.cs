using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ternary or Conditional Operator 

            // exp.
            
            // Syntax: condition ? true_statement : fals_statement;

            Console.Write("Enter Marks : ");
            int marks = Convert.ToInt32(Console.ReadLine());

            char grade = (marks >= 90) ? 'A' : (marks >= 80) ? 'B' : (marks >= 95) ? 'C' : 'F';

            //................
            //string result = "";
            //if(marks >= 40)
            //{
            //    result = result + "Pass";
            //}
            //else
            //{
            //    result += "Fail";
            //}

            Console.WriteLine("Result is : " + grade);

        }
    }
}
