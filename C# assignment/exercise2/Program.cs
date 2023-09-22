using System;

namespace exercise2
{
    class program
    {
        static void Main(string[] args)
        {
            object obj1 = null;
            object obj2 = new object();
            string str1 = "abc";
            string str2 = "ABC";


            Console.WriteLine(obj1 == obj1); //True
            Console.WriteLine(obj2 == obj2);//True
            Console.WriteLine(obj1 == obj2);//False

            Console.WriteLine(str1 == str1); //True
            Console.WriteLine(str2 == str2);//True
            Console.WriteLine(str1 == str2);//False


            Console.WriteLine(ReferenceEquals(obj1,obj1));// True
            Console.WriteLine(ReferenceEquals(obj2, obj2));// True
            Console.WriteLine(ReferenceEquals(obj2, obj1));// False



            Console.WriteLine(ReferenceEquals(str1, str1));// True
            Console.WriteLine(ReferenceEquals(str2, str2));// True
            Console.WriteLine(ReferenceEquals(str1, str2));// False

            Console.WriteLine(obj1.Equals(obj1));//Error: System.NullReferenceException
            Console.WriteLine(obj2.Equals(obj2));//False
            Console.WriteLine(obj1.Equals(obj2));//Error: System.NullReferenceException
            Console.WriteLine(obj2.Equals(obj1));//False

            Console.WriteLine(str1.Equals(str1));//False
            Console.WriteLine(str2.Equals(str1));//False
            Console.WriteLine(str1.Equals(str2));//False






        }
    }
}
