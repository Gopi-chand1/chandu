using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            stack st = new stack();
            st.push(99);
            st.push(88);
            st.push(77);

            st.push(66);
            st.push(55);
            st.push(44);
            st.push(33);
            st.push(22);
            st.push(11);
            st.push(9);
            Console.WriteLine("My stack is : ");
            st.print();
            Console.WriteLine("My stack after pop:");
            st.pop();
            st.print();
            Console.WriteLine("My stack after sort: ");
            st.sort();
            st.print();
            Console.WriteLine("Center of the stack:");
            st.center();
            Console.WriteLine("Reverse: ");
            st.reverse();
            st.print();
            Console.WriteLine("Peek:");
            st.peek();
            Console.WriteLine("size");
            st.size();
            Console.WriteLine("stack contains");
            st.contains();
        }
    }
}