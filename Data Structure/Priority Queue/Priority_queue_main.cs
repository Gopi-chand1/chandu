using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriortyQueue_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            PriortyQueue<string> myQueue = new PriortyQueue<string>();
            Console.WriteLine("----Implementation Of Priority_Queue----");

            Console.WriteLine(" 1)To create a Priorty Queue\n 2)To Enqueue a element in a Queue\n 3)To Dequeue a element from a Queu\n 4)To Peek the  element from the Queue\n 5)To Check if the Queue contains a particular element or not\n 6)To get the size of the Queue\n 7)To Reverse the Queue\n 8)To iterate the Queue\n 9)To Traverse the Queue\n 10)To Exit\n -----------------------------------------------------------------");
            while (true)
            {
                Console.WriteLine("Choice option:");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 10)
                {
                    break;
                }
                else
                {
                    int priorty;
                    string data;

                    switch (choice)
                    {
                        case 1:
                            int number;
                            Console.WriteLine("Enter the number of elements you want to enter in the Queue:");
                            number = int.Parse(Console.ReadLine());
                            for (int i = 0; i < number; i++)
                            {
                                Console.WriteLine("Enter the data of {0} element", i + 1);
                                data = Console.ReadLine();
                                Console.WriteLine("Enter the Priorty of {0} element", i + 1);
                                priorty = int.Parse(Console.ReadLine());
                                myQueue.Enqueue(priorty, data);
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter the data of the element you want to Enqueue: ");
                            data = Console.ReadLine();
                            Console.WriteLine("Enter the Priorty of the element: ");
                            priorty = int.Parse(Console.ReadLine());
                            myQueue.Enqueue(priorty, data);
                            break;

                        case 3:
                            Console.WriteLine("Enter the data of the element you want to Dequeue: ");
                            data = Console.ReadLine();
                            Console.WriteLine("Enter the Priorty of the element: ");
                            priorty = int.Parse(Console.ReadLine());
                            myQueue.Dequeue();
                            break;

                        case 4:
                            Console.WriteLine("Enter the data of the element you want to Peek: ");
                            data = Console.ReadLine();
                            Console.WriteLine("Enter the Priorty of the element: ");
                            priorty = int.Parse(Console.ReadLine());
                            Console.WriteLine(myQueue.Peek());
                            break;

                        case 5:
                            Console.WriteLine("Enter the value you want to check:");
                            data = Console.ReadLine();
                            Console.WriteLine(myQueue.Contains(data));
                            break;

                        case 6:
                            Console.WriteLine(myQueue.Size());
                            break;

                        case 7:
                            myQueue.Traverse();
                            myQueue.Reverse();
                            break;

                        case 8:
                            foreach (var item in myQueue)
                            {
                                Console.Write("{0} ", item);
                            }
                            Console.WriteLine();
                            break;

                        case 9:
                            myQueue.Traverse();
                            break;

                        default:
                            Console.WriteLine("Please Enter a valid choice!");
                            break;
                    }
                }
            }
            Console.WriteLine("Priory_Queue is successful!");
            Console.ReadLine();
        }
    }
}