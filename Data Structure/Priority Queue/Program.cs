using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PriortyQueue_implementation
{
    /// <summary>
    /// Priorty Queue
    /// </summary>
    /// <typeparam name="T"></typeparam>

    class PriortyQueue<T> : IEnumerable<T>
    {
        class Node
        {
            public int priorty;
            public T info;
            public Node link;


            public Node(int priorty, T info)
            {
                this.priorty = priorty;
                this.info = info;
            }

        }

        Node start;
        int count;

        public PriortyQueue()
        {
            start = null;
        }
        /// <summary>
        /// Insert the element in the queue according to its priorty.
        /// </summary>
        /// <param name="priorty"></param>
        /// <param name="data"></param>

        public void Enqueue(int priorty, T data)
        {
            Node temp = new Node(priorty, data);
            if (start == null || temp.priorty < start.priorty)
            {
                temp.link = start;
                start = temp;
            }

            else
            {
                Node pointer = start;
                while (pointer.link != null && temp.priorty >= pointer.link.priorty)
                {
                    pointer = pointer.link;
                }
                temp.link = pointer.link;
                pointer.link = temp;
            }
            count++;
        }
        /// <summary>
        /// Delete the element having highest priorty
        /// </summary>
        /// <returns></returns>

        public T Dequeue()
        {

            if (start == null)
            {
                int invalid = -1;
                Constants.EmptyQueueMessage();
                return (T)Convert.ChangeType(invalid, typeof(T));
            }

            else
            {
                T dequeuedItem = start.info;
                start = start.link;
                count--;
                return dequeuedItem;
            }
        }
        /// <summary>
        /// Display the element having highest priorty.
        /// </summary>

        public T Peek()
        {
            if (start == null)
            {
                int invalid = -1;
                Constants.EmptyQueueMessage();
                return (T)Convert.ChangeType(invalid, typeof(T));
            }

            else
            {
                return start.info;
            }
        }
        /// <summary>
        /// Return true if the specified element is present in the queue
        /// otherwise return false.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>

        public bool Contains(T data)
        {
            if (start == null)
            {
                Constants.EmptyQueueMessage();
                return false;
            }

            else
            {
                Node pointer = start;
                while (pointer != null)
                {
                    if (data.Equals(pointer.info))
                    {
                        return true;
                    }
                    pointer = pointer.link;
                }

                return false;
            }
        }
        /// <summary>
        /// Returns the size of the Queue.
        /// </summary>
        /// <returns></returns>

        public int Size()
        {
            return count;
        }
        /// <summary>
        /// Reverse the position of the elements in the Queue.
        /// </summary>

        public void Reverse()
        {
            if (start == null)
            {
                Constants.EmptyQueueMessage();
            }

            else
            {
                if (start.link == null)
                {
                    return;
                }

                else
                {
                    Node pointer = start;
                    Node next = null;
                    Node previous = null;
                    while (pointer != null)
                    {
                        next = pointer.link;
                        pointer.link = previous;
                        previous = pointer;
                        pointer = next;
                    }
                    start = previous;
                }
            }
        }
        /// <summary>
        /// Display all th elements present in the Queue.
        /// </summary>

        public void Traverse()
        {
            if (start == null)
            {
                Constants.EmptyQueueMessage();
            }

            else
            {
                Node pointer = start;
                while (pointer != null)
                {
                    Console.Write("[{0}] ", pointer.priorty, pointer.info);
                    pointer = pointer.link;
                }
                Console.WriteLine();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node pointer = start;
            while (pointer != null)
            {
                yield return pointer.info;
                pointer = pointer.link;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}