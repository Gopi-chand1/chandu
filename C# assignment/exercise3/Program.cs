using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, w, flag;
            Console.WriteLine("Enter lower bound of the interval: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter upper bound- of the interval: ");
            y = int.Parse(Console.ReadLine());
            if (x > y)
                Console.WriteLine("re-enter both the nembers.");

            else
            Console.WriteLine("\nPrime nembers between {0} and {1} are:", x, y);
            for (z = x;z< y;z++)
            {
                if ( z == 1 || z == 0)
                    continue;
                flag = 1;
                for(y=2;y<=x/2;++y)
                {
                    if(x%y==0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    Console.WriteLine(x);
            }
        }

    }
}
