using System;
using System.Collections.Generic;
using System.Text;

namespace Linklist
{
    public class linklist
    {
        Node head = null;
        public void insert(object data)
        {
            Node item = new Node();
            item.data = data;
            if (head == null)
            {
                head = item;
                head.next = null;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = item;
                current.next.next = null;
            }
        }

        public void insertAtPosition(int position, object data)
        {
            Node current = head;
            Node ptr = new Node();
            ptr.data = data;
            position--;
            while (position != 1)
            {

                position--;
            }
            ptr.next = current.next;
            current.next = ptr;
        }

        public void Delete()
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.data = null;
        }

        public void DeleteAtPositon(int position)
        {
            Node current = head;
            position--;
            while (position != 1)
            {

                position--;
            }
            current.next = current.next.next;
        }

        public void center()
        {
            Node fast = head;
            Node slow = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            Console.WriteLine(slow.data);
        }

        public void Reverse()
        {
            Node current = head;
            Node prev = new Node();
            Node temp = new Node();
            prev = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }

        public void size()
        {
            Node current = head;
            int size = 0;
            while (current != null)
            {
                size++;
                current = current.next;
            }
            Console.WriteLine(size);
        }

        public void sort()
        {
            Node current = head;
            Node index = new Node();
            index = null;
            if (current == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    index = current.next;
                    while (index != null)
                    {
                        if (Convert.ToInt32(current.data) > Convert.ToInt32(index.data))
                        {
                            var temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }
        public void print()
        {
            Node current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }


    }
}
