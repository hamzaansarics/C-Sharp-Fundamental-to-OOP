using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Class1
    {
        string[] arr = { "Khan","Pakistan","Hamza" };
        public object this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {

            }
        }

    }
}
