
using System;
using System.Collections.Generic;
using Linklist;


namespace Linklist
{
    class Program
    {
        static void Main(string[] args)
        {
            linklist Link = new linklist();
            Link.insert(93);
            Link.insert(53);
            Link.insert(83);
            Link.insert(43);
            Link.insertAtPosition(73, 63);
            //Link.Delete();
            //Link.DeleteAtPositon(73);
            Console.WriteLine("Linklist element :");
            Link.print();
            Console.WriteLine("The center element is : ");
            Link.center();
            Console.WriteLine("After the reverse: ");
            Link.Reverse();
            Link.print();
            Console.WriteLine("Size of the linklist :");
            Link.size();
            Console.WriteLine("After sorting : ");
            Link.sort();
            Link.print();

        }
    }
}