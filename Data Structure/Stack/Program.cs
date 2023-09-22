using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class stack
    {

        int[] arr = new int[10];
        int top = -1;
        public bool isEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }
        bool isfull()
        {
            if (top == 10)
                return true;
            else
                return false;
        }

        public void push(int value)
        {
            if (isfull())
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                top++;
                arr[top] = value;
            }
        }

        public void pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                arr[top] = 0;
                top--;
            }
        }
        public void peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty...");
            }
            else
            {
                Console.WriteLine(arr[top]);
            }
        }

        public void center()
        {
            int ans = top + 1;
            Console.WriteLine(arr[ans / 2]);
        }
        public void contains()
        {
            if (arr.Contains(160))
            {
                Console.WriteLine("true");
            }




            else
                Console.WriteLine("false");

        }

        public void reverse()
        {
            Array.Reverse(arr);
        }

        public void size()
        {
            Console.WriteLine(top + 1);
        }

        public void print()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void sort()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty...");
            }
            else
            {
                Array.Sort(arr);
            }
        }
    }
}
