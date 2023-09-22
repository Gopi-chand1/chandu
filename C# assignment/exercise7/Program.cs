 using System;
using System.Collections.Generic;

namespace Exercise_5
{

    enum DuckType
    {
        Rubber,
        Mallard,
        Redhead
    }
    class Duck
    {
        private double weight;
        private int numberOfWings;
        private DuckType typeOfDuck;

        public Duck() { }

        public Duck(double weight, int numberOfWings, DuckType typeOfDuck)
        {
            this.weight = weight;
            this.numberOfWings = numberOfWings;
            this.typeOfDuck = typeOfDuck;
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int NumberOfWings
        {
            get { return numberOfWings; }
            set { numberOfWings = value; }
        }
        public DuckType TypeOfDuck
        {
            get { return typeOfDuck; }
            set { typeOfDuck = value; }
        }

    }

    class RubberDuck : Duck
    {
        private string fly;
        private string quack;

        public RubberDuck(double weight, int numberOfWings) : base(weight, numberOfWings, DuckType.Rubber)
        {
            this.fly = "don’t fly";
            this.quack = "squeak";
        }

        public string Fly
        {
            get { return fly; }
            set { fly = value; }
        }
        public string Quack
        {
            get { return quack; }
            set { quack = value; }
        }
    }
    class MallardDuck : Duck
    {
        private string fly;
        private string quack;

        public MallardDuck(double weight, int numberOfWings) : base(weight, numberOfWings, DuckType.Mallard)
        {
            this.fly = "fly fast";
            this.quack = "quack loud";
        }
        public string Fly
        {
            get { return fly; }
            set { fly = value; }
        }
        public string Quack
        {
            get { return quack; }
            set { quack = value; }
        }
    }
    class RedheadDuck : Duck
    {
        private string fly;
        private string quack;

        public RedheadDuck(double weight, int numberOfWings) : base(weight, numberOfWings, DuckType.Redhead)
        {
            this.fly = "fly slow";
            this.quack = "quack mild";
        }
        public string Fly
        {
            get { return fly; }
            set { fly = value; }
        }
        public string Quack
        {
            get { return quack; }
            set { quack = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>();
            int choice = -1;
            while (choice != 12)
            {
                Console.WriteLine("1. Create a duck");
                Console.WriteLine("2. Show details");
                Console.WriteLine("3. Exit");
                Console.Write("Enter option: ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("\nSelect correct menu item.\n");
                }
                else
                {
                    switch (choice)
                    {
                        case 1://Create an equipment – mobile and immobile
                            createDuck(ducks);
                            break;
                        case 2:
                            showDetails(ducks);
                            break;
                        case 3:
                            //exit
                            break;
                        default:
                            Console.WriteLine("\nSelect correct menu item.\n");
                            break;
                    }
                }
            }

            static void createDuck(List<Duck> ducks)
            {
                double weight;
                int numberOfWings;
                int choice;
                Console.WriteLine("1. Rubber duck");
                Console.WriteLine("2. Mallard  duck");
                Console.WriteLine("3. Redhead  duck");
                Console.Write("Enter Option: ");
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
                {
                    Console.WriteLine("\nSelect correct menu item.\n");
                }
                else
                {
                    while (true)
                    {
                        Console.Write("Enter the Weight: ");
                        if (!double.TryParse(Console.ReadLine(), out weight) || weight < 1)
                        {
                            Console.WriteLine("\nEnter valid number.\n");
                        }
                        else { break; }
                    }
                    while (true)
                    {
                        Console.Write("Enter the number of wings: ");
                        if (!int.TryParse(Console.ReadLine(), out numberOfWings) || numberOfWings < 1)
                        {
                            Console.WriteLine("\nEnter valid number.\n");
                        }
                        else { break; }
                    }

                    switch (choice)
                    {
                        case 1:
                            ducks.Add(new RubberDuck(weight, numberOfWings));
                            break;
                        case 2:
                            ducks.Add(new MallardDuck(weight, numberOfWings));
                            break;
                        case 3:
                            ducks.Add(new RedheadDuck(weight, numberOfWings));
                            break;
                        default:
                            Console.WriteLine("\nInvalid Option.\n");
                            break;
                    }
                }
            }
            static void showDetails(List<Duck> ducks)
            {
                if (ducks.Count > 0)
                {
                    int i = 0;
                    Console.WriteLine("\n{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}\n", "No", "Weight", "No of wings", "Type of Duck", "Fly", "Quack");
                    foreach (Duck duck in ducks)
                    {
                        if (duck is RubberDuck)
                        { Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", (i + 1), duck.Weight, duck.NumberOfWings, duck.TypeOfDuck, (((RubberDuck)duck).Fly), (((RubberDuck)duck).Quack)); }
                        if (duck is MallardDuck)
                        { Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", (i + 1), duck.Weight, duck.NumberOfWings, duck.TypeOfDuck, (((MallardDuck)duck).Fly), (((MallardDuck)duck).Quack)); }
                        if (duck is RedheadDuck)
                        { Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", (i + 1), duck.Weight, duck.NumberOfWings, duck.TypeOfDuck, (((RedheadDuck)duck).Fly), (((RedheadDuck)duck).Quack)); }
                        i++;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("\nYou have not added ducks yet.");
                }
            }
        }
    }
}
