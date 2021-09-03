using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class DesignHashSet
    {
        public class MyHashSet
        {
            const int SIZE = 297;
            LinkedList<int>[] Table; 
            /** Initialize your data structure here. */
            public MyHashSet()
            {
                Table = new LinkedList<int>[SIZE];
                for(int i= 0;i< SIZE;i++)
                    Table[i] = new LinkedList<int>();
            }
            int getHashIndex(int key)
            {
                return key % SIZE;
            }
            public void Add(int key)
            {
                if(!Contains(key))
                Table[getHashIndex(key)].AddLast(key);
            }

            public void Remove(int key)
            {
                Table[getHashIndex(key)].Remove(key);
            }

            /** Returns true if this set contains the specified element */
            public bool Contains(int key)
            {
                return Table[getHashIndex(key)].Contains(key);
            }
        }

        public class MyHashSet2
        {
            List<int> set;
            /** Initialize your data structure here. */
            public MyHashSet2()
            {
                set = new List<int>();
            }

            public void Add(int key)
            {
                foreach(int val in set)
                {
                    if (val == key)
                        return;
                }
                set.Add(key);
            }

            public void Remove(int key)
            {
                for (int i = 0; i < set.Count; i++)
                {
                    if (set[i] == key)
                    {
                        set.RemoveAt(i);
                        return;
                    }
                }
            }

            /** Returns true if this set contains the specified element */
            public bool Contains(int key)
            {
                foreach (int val in set)
                {
                    if (val == key)
                        return true;
                }
                return false;
            }
        }
    }
}
