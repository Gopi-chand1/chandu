 using System;
using System.Collections.Generic;
using System.Linq;





namespace Exercise10
{
    public class priorityQueue3
    {
        class PriorityQueue3<T> where T : IEquatable<T>
        {





            private class PriorityNode
            {
                public int Priority { get; private set; }
                public T data { get; private set; }
                public PriorityNode(int priority, T data)
                {
                    this.Priority = priority;
                    this.data = data;
                }
            }
            private IList<PriorityNode> elements;
            public PriorityQueue3()
            {
                elements = new List<PriorityNode>();
            }
            public int Count()
            {
                return elements.Count();
            }





            public bool Contains(T item)
            {
                foreach (PriorityNode node in elements)
                {
                    if (node.data.Equals(item))
                    {
                        return true;
                    }
                }
                return false;
            }
            public T Dequeue()
            {
                T topElement = elements.First().data;
                elements.RemoveAt(0);
                return topElement;
            }





            public void Enqueue(int priority, T item)
            {
                if (elements.Count() == 0)
                {
                    elements.Add(new PriorityNode(priority, item));
                }
                else
                {
                    PriorityNode val = new PriorityNode(priority, item);
                    foreach (PriorityNode node in elements)
                    {
                        if (node.Priority > priority)
                        {
                            elements.Insert(elements.IndexOf(node), val);
                            break;
                        }
                    }
                    if (elements.Contains(val) == false)
                    {
                        elements.Add(val);
                    }
                }
            }





            public T Peek()
            {
                return elements.First().data;
            }





            private int GetHighestPriority()
            {
                return elements.First().Priority;
            }
        }





        public static void Main()
        {
            PriorityQueue3<int> priorityQueue3 = new PriorityQueue3<int>();
            priorityQueue3.Enqueue(37, 1);
            priorityQueue3.Enqueue(8, 6);
            priorityQueue3.Enqueue(10, 3);
            priorityQueue3.Enqueue(28, 2);
            priorityQueue3.Enqueue(90, 4);





            Console.WriteLine(priorityQueue3.Peek());
            priorityQueue3.Dequeue();
            Console.WriteLine(priorityQueue3.Peek());
        }
    }
}
