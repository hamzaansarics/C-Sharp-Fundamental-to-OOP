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
            #region NewStackData
            NewStack<int> d = new NewStack<int>();
            d.push(12);
            d.push(42);
            d.push(120);
            d.push(182);

            for (int i = 0; i < 4; i++)
            {
                d.pop();
            }
            #endregion


            Console.ReadKey();
        }
    }
}
