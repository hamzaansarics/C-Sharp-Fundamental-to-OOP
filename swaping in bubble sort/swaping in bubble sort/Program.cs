using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace swaping_in_bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] geo = new int[5] { 4, 2, 3, 1, 6 };
            for (int i = 0; i < (5 - 1); i++)
            {
                int swap = 0;
                for (int p = 0; p < (5 - 1) - 1; p++)
                {
                    if (geo[i] > geo[p + 1])
                    {
                        int temp = geo[i];
                        geo[i] = geo[p + 1];
                        geo[p + 1] = temp;
                        swap = 1;
                    }
                }
                if (swap == 0)
                {
                    break;
                }
                WriteLine("Sorted Array: " + geo[i]);

               }
            ReadKey();
        }
    }
}
