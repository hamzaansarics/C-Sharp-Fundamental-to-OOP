using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class NewStack<T> where T: struct
    {
        #region Making Own Stack    
        public int Length { get; set; }


        private int size;
        private int stackitem;
        private T[] item;
        public NewStack()
        {
            size = 4;
            stackitem = 0;
            item = new T[size];
        }

        public void push(T items)
        {
            if (stackitem >= size)
            {
                throw new Exception("OverFlow");
            }
            else
            {
                item[stackitem] = items;
                stackitem++;
                // Console.WriteLine(item);
            }

        }
        public void pop()
        {
            stackitem--;
            if (stackitem >= 0)
            {

                Console.WriteLine(item[stackitem]);
            }
            else
            {
                stackitem = 0;

            }
        }
        #endregion

    }
}
