using System;
using System.Collections;

namespace HashTable
{
    /// <summary>
    /// Hashtable class
    /// </summary>
    /// <typeparam name="Tkey"></typeparam>
    /// <typeparam name="Tvalue"></typeparam>

    class Hashtable<Tkey, Tvalue> : IEnumerable
    {
        public int hashtableSize;
        public LinkedList<Tkey, Tvalue>[] hashChain;

        public Hashtable(int size = 7)
        {
            hashtableSize = size;
            hashChain = new LinkedList<Tkey, Tvalue>[hashtableSize];
            for (int i = 0; i < hashtableSize; i++)
            {
                hashChain[i] = new LinkedList<Tkey, Tvalue>();
            }
        }

        /// <summary>
        /// Generate the Hashcode 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>

        public int HashCode(Tkey key)
        {
            return key.GetHashCode();
        }

        /// <summary>
        /// Insert key value pair in Hashtable
        /// </summary>
        /// <param name="key"></param>
        /// <param name="element"></param>

        public void Insert(Tkey key, Tvalue element)
        {
            int index = Math.Abs(HashCode(key) % hashtableSize);
            hashChain[index].Insert(key, element);
        }

        /// <summary>
        /// returns True if the specified key is present in the Hashtable
        /// otherwise returns false.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>

        public bool Contains(Tkey key)
        {
            int index = Math.Abs(HashCode(key) % hashtableSize);
            return hashChain[index].Contains(key);
        }

        /// <summary>
        /// Delete the key value pair 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>

        public bool Delete(Tkey key)
        {
            int index = Math.Abs(HashCode(key) % hashtableSize);
            bool value = hashChain[index].Delete(key);
            if (value == false)
            {
                Console.WriteLine("Key is not Present!!");
            }
            return value;
        }

        /// <summary>
        /// Display all the elements present in the Hashtable
        /// </summary>

        public void Traverse()
        {
            for (int i = 0; i < hashtableSize; i++)
            {
                Console.Write("[{0}]--> ", i);
                hashChain[i].Display();
            }
        }

        /// <summary>
        ///  returns the value of the specified Key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>

        public Tvalue GetValueByKey(Tkey key)
        {
            int index = Math.Abs(HashCode(key) % hashtableSize);
            Tvalue value = hashChain[index].GetValueByKey(key);
            int check = Convert.ToInt32(value);
            if (check == -1)
            {
                Console.WriteLine("Key is not Present!!");
                return value;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Returns the total count of the values present in the Hashtable.
        /// </summary>
        /// <returns></returns>

        public int Size()
        {
            int size = 0;
            for (int i = 0; i < hashtableSize; i++)
            {
                size = size + hashChain[i].Size();
            }
            return size;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < hashtableSize; i++)
            {
                foreach (var item in hashChain[i])
                {
                    yield return item;
                }
            }
        }
    }
}