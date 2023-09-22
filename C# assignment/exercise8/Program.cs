
using System;
using System.Collections.Generic;


namespace PriorityQueue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Creating priority queue of students");
            var pq = new PriorityQueue<Student>();


            var s1 = new Student("Aiden", 1.0);
            var s2 = new Student("Baker", 2.0);
            var s3 = new Student("Chung", 3.0);
            var s4 = new Student("Dunne", 4.0);
            var s5 = new Student("Eason", 5.0);
            var s6 = new Student("Flynn", 6.0);


            Console.WriteLine($"Adding {s5} to priority queue");
            pq.Enqueue(s5);
            Console.WriteLine($"Adding {s3} to priority queue");
            pq.Enqueue(s3);
            Console.WriteLine($"Adding {s6} to priority queue");
            pq.Enqueue(s6);
            Console.WriteLine($"Adding {s4} to priority queue");
            pq.Enqueue(s4);
            Console.WriteLine($"Adding {s1} to priority queue");
            pq.Enqueue(s1);
            Console.WriteLine($"Adding {s2} to priority queue");
            pq.Enqueue(s2);


            Console.WriteLine("\nPriority queue elements are:");
            Console.WriteLine(pq.ToString());
            Console.WriteLine($"Priority queue size is: {pq.Count()}");
            Console.WriteLine();


            Console.WriteLine($"Peeking a student from queue: {pq.Peek()}");


            Console.WriteLine("Removing a student from priority queue");
            var s = pq.Dequeue();
            Console.WriteLine($"Removed student is {s}");
            Console.WriteLine("\nPriority queue is now:");
            Console.WriteLine(pq.ToString());
            Console.WriteLine();


            Console.WriteLine("Removing a second student from queue");
            s = pq.Dequeue();
            Console.WriteLine($"Removed student is {s}");
            Console.WriteLine("\nPriority queue is now:");
            Console.WriteLine(pq.ToString());
            Console.WriteLine();


            Console.ReadLine();
        }
    }


    public class Student : IComparable<Student>
    {
        public string LastName { get; }
        public double Priority { get; set; } 


        public Student(string lastName, double priority)
        {
            LastName = lastName;
            Priority = priority;
        }


        public override string ToString() => "(" + LastName + ", " + Priority.ToString("F1") + ")";


        public int CompareTo(Student other)
        {
            if (Priority < other.Priority) return -1;
            if (Priority > other.Priority) return 1;
            return 0;
        }
    }


    public class PriorityQueue<T> where T : IComparable<T>
    {
        private readonly List<T> data;


        public PriorityQueue()
        {
            data = new List<T>();
        }


        public void Enqueue(T item)
        {
            data.Add(item);


            var ci = data.Count - 1; // child index; start at end
            while (ci > 0)
            {
                var pi = (ci - 1) / 2; 


                if (data[ci].CompareTo(data[pi]) >= 0)
                    break; 


                Swap(ci, pi);


                ci = pi;
            }
        }


        public T Dequeue()
        {
            
            var li = data.Count - 1; 
            var frontItem = data[0]; 
            data[0] = data[li];
            data.RemoveAt(li);


            li--; 
            var pi = 0;
            while (true)
            {
                var ci = pi * 2 + 1;
                if (ci > li) break; 


                var rc = ci + 1; 
                if (rc <= li && data[rc].CompareTo(data[ci]) < 0) 
                    ci = rc;


                if (data[pi].CompareTo(data[ci]) <= 0)
                    break; 


                Swap(pi, ci); 


                pi = ci;
            }


            return frontItem;
        }


        public T Peek() => data[0];


        public int Count() => data.Count;


        public override string ToString()
        {
            var s = default(string);


            foreach (var elem in data)
                s += elem + " ";


            return s;
        }


        private void Swap(int firstIndex, int secondIndex)
        {
            var tmp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = tmp;
        }
    }
}
    
