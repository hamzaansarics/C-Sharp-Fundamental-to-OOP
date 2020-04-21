using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace simple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person ge = new Person();
            //ge.id = 12;
            //Child k = new Child();
            //k.email = "khan";
            //Console.WriteLine("Id: "+ge.id+"Email: "+k.email);

            Child ge = new Child();
            ge.Safe = new Person();
            ge.Safe.id = 12;
            Console.WriteLine(ge.Safe.id);

            ReadKey();

        }
    }
}
