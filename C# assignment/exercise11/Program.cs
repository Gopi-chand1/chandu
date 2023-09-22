using System;


namespace exercise11
{
    public static class extension
    {
        public static bool isOdd(this int value)
        {
            return value % 2 != 0;
        }
        public static bool isEven(this int valuee)
        {
            return valuee % 2 == 0;
        }
        public static bool isPrime(this int valuee)
        {
            for (int i = 2; i <= valuee / 2; i++)
            {
                if (valuee % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
        public static bool isDivisibleBy(this int value, int i)
        {
            return value % i == 0;
        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            bool isOdd = number.isOdd();
            bool isEven = number.isEven();
            bool isPrime = number.isPrime();

            if (isOdd)
            {
                Console.WriteLine("IsOdd");
                Console.WriteLine("true\n");

            }
            else
            {
                Console.WriteLine("IsOdd");
                Console.WriteLine("false");
            }
            if (isEven)
            {
                Console.WriteLine("IsEven");
                Console.WriteLine("true\n");

            }
            else
            {
                Console.WriteLine("IsEven");
                Console.WriteLine("false");
            }
            if (isPrime)
            {
                Console.WriteLine("IsPrime");
                Console.WriteLine("true\n");
            }
            else
            {
                Console.WriteLine("IsPrime");
                Console.WriteLine("false\n");
            }
            Console.WriteLine("Enter number to check divisibilty");
            int p = Convert.ToInt32(Console.ReadLine());
            bool isDivisibleBy = number.isDivisibleBy(p);
            if (isDivisibleBy)
            {
                Console.WriteLine("{0} is divisible by {1}", number, p);
            }
            else
            {
                Console.WriteLine("{0} is not divisible by {1}", number, p);
            }
        }
    }
}
