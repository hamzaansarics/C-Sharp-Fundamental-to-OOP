using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class MyNewStack
    {
        private int size;
        int stackitem;
        private object[] item;
        public MyNewStack()
        {
            stackitem = 0;
            size = 5;
            item = new object[size];
        }

        public void push(object insert)
        {
            if(stackitem>=size)
            {
                throw new Exception("MyNewStack was overflow");
            }
            else
            {
                stackitem++;
                item[stackitem] = insert;

            }
        }

        public void pop()
        {
            if (stackitem >= 0)
            {
                stackitem--;
                Console.WriteLine(item[stackitem]);
            }
            else
            {
                stackitem = 0;
                throw new Exception("Bus putar g");
            }

        }



    }
}
