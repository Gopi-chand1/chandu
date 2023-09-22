using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable<int, string> myHashtable = new Hashtable<int, string>();
            Console.WriteLine("..........Hash Table Implementation..........");
            Console.WriteLine(" 1)To Insert a element in Hashtable\n 2)To Delete a element from the Hashtable\n 3)To Check if the Hashtable contains a particular key or not\n 4)To Get the value of the element using Key\n 5)To get the size of the Hashtable\n 6)To iterate the Hashtable\n 7)To Traverse the Hashtable\n 8)To Exit\n *******************************************************");
            while (true)
            {
                Console.WriteLine("Enter one of the choices(1-8) to perform related action:");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 8)
                {
                    break;
                }
                else
                {
                    int key;
                    string value;

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the key:");
                            key = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the value:");
                            value = Console.ReadLine();
                            myHashtable.Insert(key, value);
                            break;

                        case 2:
                            Console.WriteLine("Enter the Key you want to delete:");
                            key = int.Parse(Console.ReadLine());
                            myHashtable.Delete(key);
                            break;

                        case 3:
                            Console.WriteLine("Enter the Key you want check:");
                            key = int.Parse(Console.ReadLine());
                            Console.WriteLine(myHashtable.Contains(key));
                            break;

                        case 4:
                            Console.WriteLine("Enter the Key:");
                            key = int.Parse(Console.ReadLine());
                            Console.WriteLine(myHashtable.GetValueByKey(key));
                            break;

                        case 5:
                            Console.WriteLine(myHashtable.Size());
                            break;

                        case 6:
                            foreach (var item in myHashtable)
                            {
                                Console.Write("{0} ", item);
                            }
                            Console.WriteLine();
                            break;

                        case 7:
                            myHashtable.Traverse();
                            break;

                        default:
                            Console.WriteLine("Please Enter a valid choice!");
                            break;
                    }
                }
            }

            Console.WriteLine("Thanks!!");
            Console.ReadLine();
        }
    }
}