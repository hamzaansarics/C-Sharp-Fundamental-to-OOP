using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BinarySearch
            //int[] arr = { 1, 4, 5, 6, 8 };
            //int a = Convert.ToInt32(ReadLine());
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (a == arr[i])
            //    {
            //        Console.WriteLine("Index Value " + i);
            //        i++;
            //        Console.WriteLine("Location of Index " + i);
            //        //break;
            //    }
            //    else if (a != arr[i])
            //    {
            //        Console.WriteLine("Not present in this section");
            //        //break;
            //    }

            //}


            #endregion

            #region Sorting

            int[] arr = { 6, 4, 5, 2, 8, 1 };
            for (int i = 0; i < arr.Length-1; i++)
            {
               
                    if (arr[i] > arr[i+1])
                    {
                        int temp;
                        temp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i] = temp;
                        Console.WriteLine(arr[i+1]);

                      //  break;

                    }
                
            }
       


            #endregion






            ReadKey();
        }
    }
}
