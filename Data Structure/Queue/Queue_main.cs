using System;

namespace Queue_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();

            Console.WriteLine("**** Queue implementation ****");


            Console.WriteLine(" 1)create a Queue\n 2)Enqueue a element in a Queue\n 3)Dequeue a element from a Queue\n 4)Peek the  element from the Queue\n 5)Check if the Queue contains a particular element or not\n 6) get the size of the Queue\n 7)Reverse the Queue\n 8)iterate the Queue\n 9)Traverse the Queue\n 10)Exit");

            while (true)
            {
                Console.WriteLine("Enter one of the choices(1-10) to perform related action:");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 10)
                {
                    break;
                }
                else
                {
                    string data;

                    switch (choice)
                    {
                        case 1:
                            int number;
                            Console.WriteLine("Enter the number of elements you want to enter in the queue:");
                            number = int.Parse(Console.ReadLine());
                            for (int i = 0; i < number; i++)
                            {
                                Console.WriteLine("Enter the value of {0} element:", i + 1);
                                data = Console.ReadLine();
                                myQueue.Enqueue(data);
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter the data you want to Enqueue: ");
                            data = Console.ReadLine();
                            myQueue.Enqueue(data);
                            break;

                        case 3:
                            Console.WriteLine("Enter the data you want to Dequeue: ");
                            data = Console.ReadLine();
                            myQueue.Dequeue();
                            break;

                        case 4:
                            Console.WriteLine("Enter the data you want to Peek: ");
                            data = Console.ReadLine();
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
                            myQueue.Reverse();
                            myQueue.Traverse();

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

            Console.WriteLine("Succussful!");
            Console.ReadLine();
        }
    }
}