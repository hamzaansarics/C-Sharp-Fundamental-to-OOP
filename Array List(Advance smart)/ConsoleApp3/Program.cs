using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = { 1, 4, 5, 66, 6 };
            //ArrayList list = new ArrayList(arr1);
            //list.Insert(4,"hamza");
            //list.Add("geo pakistan");
            //list.Add('a');
            //WriteLine("Total value is" + list.Count);
            //ReadKey();
            //int a = 3;
            //string b = "geo to aise";

            //WriteLine(a +" "+ b);

            int[] a = new int[3];
            WriteLine("Enter the students id");
            for(int i=0; i<a.Length; i++)
            {
                a[i] = Convert.ToInt32(ReadLine());
                if(a[i]==1)
                {
                    WriteLine("you are a good man");
                }
                else
                {
                    WriteLine("Not good man");
                }
            }
            ReadKey();
        }
    }
}
