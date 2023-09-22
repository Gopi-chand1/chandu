using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue_implementation
{
    /// <summary>
    /// Queue class
    /// </summary>
    /// <typeparam name="T"></typeparam>

    class Queue<T> : IEnumerable<T> // Use circular linklist to implement the Queue.
    {
        class Node
        {
            public T info;
            public Node link;

            public Node(T info)
            {
                this.info = info;
                link = null;
            }
        }

        Node last;
        int count = 0;

        public Queue()
        {
            last = null;
        }

        /// <summary>
        /// Insert element at the end of the Queue.
        /// </summary>
        /// <param name="data"></param>

        public void Enqueue(T data)
        {
            Node temp = new Node(data);
            if (last == null)
            {
                last = temp;
                temp.link = temp;
            }
            else
            {
                temp.link = last.link;
                last.link = temp;
                last = temp;
            }
            count++;
        }

        /// <summary>
        /// Delete element from the beginning of the Queue.
        /// </summary>
        /// <returns></returns>

        public T Dequeue()
        {
            if (last == null)
            {
                int invalid = -1;
                Constants.EmptyQueueMessage();
                return (T)Convert.ChangeType(invalid, typeof(T));
            }
            else
            {
                T dequeuedElement;
                dequeuedElement = last.link.info;
                if (count == 1)
                {
                    last = null;
                }

                else
                {
                    last.link = last.link.link;
                }
                count--;
                return dequeuedElement;
            }
        }

        /// <summary>
        /// Display the element present in the front of the Queue.
        /// </summary>

        public T Peek()
        {
            if (last == null)
            {
                int invalid = -1;
                Constants.EmptyQueueMessage();
                return (T)Convert.ChangeType(invalid, typeof(T));
            }
            else
            {
                return last.link.info;
            }
        }

        /// <summary>
        /// Return True if the specified element is present in the Queue
        /// otherwise return false.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>

        public bool Contains(T data)
        {
            if (last == null)
            {
                Constants.EmptyQueueMessage();
                return false;
            }
            else
            {
                Node pointer = last.link;
                while (true)
                {
                    if (data.Equals(pointer.info))
                    {
                        return true;
                    }

                    pointer = pointer.link;
                    if (pointer == last.link)
                    {
                        break;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Return the size of the Queue.
        /// </summary>
        /// <returns></returns>

        public int Size()
        {
            return count;
        }

        /// <summary>
        /// Reverse the position of the elements present in the Queue.
        /// </summary>

        public void Reverse()
        {
            Node pointer = last.link;
            Node prev = last;
            Node next = null;
            while (true)
            {
                Node pointerToFirstElement = last.link; // variable to keep the refrence of first Node
                next = pointer.link;
                pointer.link = prev;
                prev = pointer;
                pointer = next;
                if (pointer == pointerToFirstElement)
                {
                    break;
                }
            }
            last = pointer;
        }

        /// <summary>
        /// Display all the present elements in the Queue.
        /// </summary>

        public void Traverse()
        {

            if (last == null)
            {
                Constants.EmptyQueueMessage();
            }
            else
            {
                Node pointer = last.link;
                while (true)
                {

                    Console.Write("{0} ", pointer.info);
                    pointer = pointer.link;
                    if (pointer == last.link)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node pointer = last.link;
            while (true)
            {
                yield return pointer.info;
                pointer = pointer.link;
                if (pointer == last.link)
                {
                    break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
