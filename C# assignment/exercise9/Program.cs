using System;
using System.Collections.Generic;


namespace exercise9
{
    class PriorityQueues2Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBegin Priority Queue demo");

            Console.WriteLine("\nCreating priority queue of Employee items\n");
            PriorityQueue2<Employee> pq = new PriorityQueue2<Employee>();

            Employee e1 = new Employee("Aiden", 1.0);
            Employee e2 = new Employee("Baker", 2.0);
            Employee e3 = new Employee("Chung", 3.0);
            Employee e4 = new Employee("Dunne", 4.0);
            Employee e5 = new Employee("Eason", 5.0);
            Employee e6 = new Employee("Flynn", 6.0);

            Console.WriteLine("Adding " + e5.ToString() + " to priority queue");
            pq.Enqueue(e5);
            Console.WriteLine("Adding " + e3.ToString() + " to priority queue");
            pq.Enqueue(e3);
            Console.WriteLine("Adding " + e6.ToString() + " to priority queue");
            pq.Enqueue(e6);
            Console.WriteLine("Adding " + e4.ToString() + " to priority queue");
            pq.Enqueue(e4);
            Console.WriteLine("Adding " + e1.ToString() + " to priority queue");
            pq.Enqueue(e1);
            Console.WriteLine("Adding " + e2.ToString() + " to priority queue");
            pq.Enqueue(e2);

            Console.WriteLine("\nPriory queue is: ");
            Console.WriteLine(pq.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Removing an employee from priority queue");
            Employee e = pq.Dequeue();
            Console.WriteLine("Removed employee is " + e.ToString());
            Console.WriteLine("\nPriory queue is now: ");
            Console.WriteLine(pq.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Removing a second employee from queue");
            e = pq.Dequeue();
            Console.WriteLine("\nPriory queue is now: ");
            Console.WriteLine(pq.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Testing the priority queue");
            TestPriorityQueue2(50000);


            Console.WriteLine("\nEnd Priority Queue demo");
            Console.ReadLine();
        }
        static void TestPriorityQueue2(int numOperations)
        {
            Random rand = new Random(0);
            PriorityQueue2<Employee> pq = new PriorityQueue2<Employee>();
            for (int op = 0; op < numOperations; ++op)
            {
                int opType = rand.Next(0, 2);

                if (opType == 0) 
                {
                    string lastName = op + "man";
                    double priority = (100.0 - 1.0) * rand.NextDouble() + 1.0;
                    pq.Enqueue(new Employee(lastName, priority));
                    if (pq.IsConsistent() == false)
                    {
                        Console.WriteLine("Test fails after enqueue operation # " + op);
                    }
                }
                else 
                {
                    if (pq.Count() > 0)
                    {
                        Employee e = pq.Dequeue();
                        if (pq.IsConsistent() == false)
                        {
                            Console.WriteLine("Test fails after dequeue operation # " + op);
                        }
                    }
                }
            } 
            Console.WriteLine("\nAll tests passed");
        } 

    }
    public class Employee : IComparable<Employee>
    {
        public string lastName;
        public double priority; 

        public Employee(string lastName, double priority)
        {
            this.lastName = lastName;
            this.priority = priority;
        }

        public override string ToString()
        {
            return "(" + lastName + ", " + priority.ToString("F1") + ")";
        }

        public int CompareTo(Employee other)
        {
            if (this.priority < other.priority) return -1;
            else if (this.priority > other.priority) return 1;
            else return 0;
        }

    } 

    

    public class PriorityQueue2<T> where T : IComparable<T>
    {
        private List<T> data;

        public PriorityQueue2()
        {
            this.data = new List<T>();
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            int ci = data.Count - 1;
            while (ci > 0)
            {
                int pi = (ci - 1) / 2; 
                if (data[ci].CompareTo(data[pi]) >= 0) break;
                T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
                ci = pi;
            }
        }

        public T Dequeue()
        {
            
            int li = data.Count - 1; 
            T frontItem = data[0];   
            data[0] = data[li];
            data.RemoveAt(li);

            --li; 
            int pi = 0; 
            while (true)
            {
                int ci = pi * 2 + 1; 
                if (ci > li) break;  
                int rc = ci + 1;     
                if (rc <= li && data[rc].CompareTo(data[ci]) < 0) 
                    ci = rc;
                if (data[pi].CompareTo(data[ci]) <= 0) break; 
                T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp; 
                pi = ci;
            }
            return frontItem;
        }

        public T Peek()
        {
            T frontItem = data[0];
            return frontItem;
        }

        public int Count()
        {
            return data.Count;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < data.Count; ++i)
                s += data[i].ToString() + " ";
            s += "count = " + data.Count;
            return s;
        }

        public bool IsConsistent()
        {
            
            if (data.Count == 0) return true;
            int li = data.Count - 1; 
            for (int pi = 0; pi < data.Count; ++pi) 
            {
                int lci = 2 * pi + 1; 
                int rci = 2 * pi + 2; 

                if (lci <= li && data[pi].CompareTo(data[lci]) > 0) return false; 
                if (rci <= li && data[pi].CompareTo(data[rci]) > 0) return false; 
            }
            return true; 
        } 
    }
} 
