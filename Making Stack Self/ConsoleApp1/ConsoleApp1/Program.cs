using System;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(5);
            //list.Add(15);
            //list.Add(20);
            //list.Add(25);

            //foreach (var item in list)
            //{
            //    WriteLine(item);
            //}

            //...................

            MyStack stack = new MyStack();
            stack.Push(5);
            stack.Push(5.5);
            stack.Push("ali");
            stack.Push(true);
            //stack.Push(10);

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(stack.Pop());
            //}


            //..............

            MyStack<int> stack = new MyStack<int>();
            stack.Push(5);
            stack.Push(10);
            stack.Push(20);
            stack.Pop();

            //..........

            //MyClass obj = null;
            //obj.Value1 = 5;

            //int[] arr = new int[2];
            //arr[0] = 5;
            //arr[1] = 10;
            //arr[2] = 15;
            //arr[3] = 20;

            //..................


            //try
            //{
            //    int[] arr = new int[2];
            //    arr[0] = 5;
            //    arr[1] = 10;
            //    arr[2] = 15;
            //    arr[3] = 20;
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    WriteLine(ex.StackTrace);
            //}



            //try
            //{
            //    int[] arr = new int[4];
            //    arr[0] = 5;
            //    arr[1] = 10;
            //    arr[2] = 15;
            //    arr[3] = 20;
            //    foreach (var item in arr)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Must Run");
            //}

            //..............


            //try
            //{
            //    Write("Enter Value 1  : ");
            //    int v1 = Convert.ToInt32(ReadLine());
            //    Write("Enter Value 2  : ");
            //    int v2 = Convert.ToInt32(ReadLine());
            //    WriteLine(v1 / v2);
            //}
            //catch (Exception ex)
            //{
            //    WriteLine(ex.Message);
            //}

            ReadKey();
        }
    }
}
