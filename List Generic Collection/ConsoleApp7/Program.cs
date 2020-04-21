using System;
using System.Collections;       
using System.Collections.Generic;  // Generic Collections 
using static System.Console;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> aa = new List<int>()
            {

                12,55,77,88

            };
            List<int> aaf = new List<int>()
            {

              14,  12,77,88,44,6

            };



            aa.InsertRange(2, aaf);
            foreach (var item in aa)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();



            //int a = 5;
            //object b = a;  // Boxing 
            //int c = (int)b;   // Unboxing

            //// ArrayList

            //ArrayList array = new ArrayList();
            //array.Add("bilal");        // Boxing
            //array.Add("txt");
            //array.Add("ali");

            ////int value = (int)array[0];   // Unboxing

            //array.Sort();
            //foreach (var item in array)
            //{
            //    WriteLine(item);
                //}

                //....... Generic Collections

                //List<int> list = new List<int>();
                //list.Add(5);
                //list.Add(10);

                ////int value = list[0];

                //foreach (var item in list)
                //{
                //    Console.WriteLine(item);
                //}


                //List<int> list = new List<int>();
                //list.Add(5);
                //list.Add(10);

                //list.Insert(1, 50);

                //list.ForEach(item => WriteLine(item));

                //for (int i = 0; i < list.Count; i++)
                //{
                //    WriteLine(list[i]);
                //}

                //var stack = new Stack<string>();
                //stack.Push("abc");

                //var dictionary = new Dictionary<int, string>();
                //dictionary.Add(5, "txt");




                ReadKey();
        }
    }
}
