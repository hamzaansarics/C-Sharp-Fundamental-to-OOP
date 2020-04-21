using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// MyStack is Generic Class
    /// </summary>
    /// <typeparam name="T">is a struct</typeparam>
    public class MyStack<T> where T : struct
    {
        private int size;
        private int stackPointer;
        private T[] items;
        public MyStack()
        {
            size = 4;
            stackPointer = 0;
            items = new T[size];
        }
        public void Push(T item)
        {
            if(stackPointer >= size)
            {
                throw new StackOverflowException();
                //Console.WriteLine("Stack Overflow");
                //return;
            }
            else
            {
                items[stackPointer] = item;
                stackPointer++;
            }
        }
        public T Pop()
        {
            stackPointer--;
            if(stackPointer >= 0)
            {
                return items[stackPointer];
            }
            else
            {
                stackPointer = 0;
                throw new InvalidOperationException("Stack is Empty");
            }
        }

    }
}
