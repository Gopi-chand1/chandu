using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTable
{
    class LinkedList<Tkey, Tvalue> : IEnumerable<Tvalue>
    {
        class Node
        {
            public Tvalue info;
            public Tkey key;
            public Node link;

            public Node(Tkey key, Tvalue info, Node link = null)
            {
                this.info = info;
                this.key = key;
            }
        }

        Node start;
        int count;

        public LinkedList()
        {
            start = null;
            count = 0;
        }

        public void Insert(Tkey key, Tvalue data)
        {
            Node temp = new Node(key, data);
            if (start == null)
            {
                start = temp;
            }
            else
            {
                Node pointer = start;
                while (pointer.link != null)
                {
                    pointer = pointer.link;
                }
                pointer.link = temp;
            }
            count++;
        }

        public void Display()
        {
            if (start == null)
            {
                Console.WriteLine();
            }
            else
            {
                Node pointer = start;
                while (pointer != null)
                {
                    Console.Write("{0} ", pointer.info);
                    pointer = pointer.link;
                }
                Console.WriteLine();
            }
        }

        public bool Delete(Tkey key)
        {
            if (start == null)
            {
                return false;
            }
            else
            {
                if (key.Equals(start.key))
                {
                    start = start.link;
                    count--;
                    return true;
                }
                Node pointer = start;
                while (pointer.link != null)
                {
                    if (key.Equals(pointer.link.key))
                    {
                        pointer.link = pointer.link.link;
                        count--;
                        return true;
                    }
                    pointer = pointer.link;
                }
                return false;
            }
        }

        public bool Contains(Tkey key)
        {
            if (start == null)
            {
                return false;
            }
            else
            {
                Node pointer = start;
                while (pointer != null)
                {
                    if (key.Equals(pointer.key))
                    {
                        return true;
                    }
                    pointer = pointer.link;
                }
                return false;
            }
        }

        public Tvalue GetValueByKey(Tkey key)
        {
            int invalid = -1;
            if (start == null)
            {
                return (Tvalue)Convert.ChangeType(invalid, typeof(Tvalue));
            }
            else
            {
                Node pointer = start;
                while (pointer != null)
                {
                    if (key.Equals(pointer.key))
                    {
                        return pointer.info;
                    }
                    pointer = pointer.link;
                }
                return (Tvalue)Convert.ChangeType(invalid, typeof(Tvalue));
            }
        }

        public int Size()
        {
            return count;
        }

        public IEnumerator<Tvalue> GetEnumerator()
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