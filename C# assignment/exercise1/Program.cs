using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            Console.WriteLine("Int");
            Console.WriteLine(int.Parse(userInput));
            int number;
            int.TryParse(userInput, out number);
            Console.WriteLine(number);
            Console.WriteLine(Convert.ToInt32(userInput));

            Console.WriteLine("Float");
            Console.WriteLine(float.Parse(userInput));
            Console.WriteLine(Convert.ToDouble(userInput));

            Console.WriteLine("Boolean");
            Console.WriteLine(userInput.ToLower() == "true");
            Console.WriteLine(Convert.ToBoolean(userInput));
        }
    }
}
