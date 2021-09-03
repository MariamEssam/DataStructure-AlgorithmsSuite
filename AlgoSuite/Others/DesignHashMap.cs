using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class DesignHashMap
    {
        public class MyHashMap
        {
            const int SIZE = 297;
            LinkedList<Pair>[] Table;
            /** Initialize your data structure here. */
            public MyHashMap()
            {
                Table = new LinkedList<Pair>[SIZE];
                for (int i = 0; i < SIZE; i++)
                    Table[i] = new LinkedList<Pair>();
            }
            int getHashIndex(int key)
            {
                return key % SIZE;
            }
            /** value will always be non-negative. */
            public void Put(int key, int value)
            {
                if (Get(key)!=-1)
                    Table[getHashIndex(key)].AddLast(new Pair(key,value));
            }

            /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
            public int Get(int key)
            {
                Pair pair = Table[getHashIndex(key)].FirstOrDefault(item => item.val == key);
                if (pair != null)
                    return pair.index;
                return -1;
            }

            /** Removes the mapping of the specified value key if this map contains a mapping for the key */
            public void Remove(int key)
            {
                Pair pair = Table[getHashIndex(key)].FirstOrDefault(item => item.val == key);
                if(pair!=null)
                  Table[getHashIndex(key)].Remove(pair);
            }

        }
    }
}
