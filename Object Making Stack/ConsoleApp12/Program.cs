using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNewStack Add = new MyNewStack();
            Add.push(19);
            Add.push("Ansari Sb");
            //Add.push(12.55);
            Add.push(true);
            Add.push('a');



            Add.pop();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(Add);
            //}

            Stack<int> id = new Stack<int>();
            id.Push(1);
            


            //Console.WriteLine(id);
            foreach (var item in id)
            {
                Console.WriteLine(item);
            }




            Console.ReadKey();
        }
    }
}
