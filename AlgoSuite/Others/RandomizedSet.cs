using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class RandomizedSet
    {
        Dictionary<int,int> dic;
        List<int> lst;
        Random rand;
        /** Initialize your data structure here. */
        public RandomizedSet()
        {
            dic = new Dictionary<int, int>();
            lst = new List<int>();
            rand = new Random();
            
        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (dic.ContainsKey(val)) { return false; }
            dic.Add(val, lst.Count);
            lst.Add(val);
            return true;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            if (!dic.ContainsKey(val)) return false;
            int lastelement = lst[lst.Count - 1];
            int index = dic[val];
            lst[index] = lastelement;
            dic[lastelement] = index;
            lst.RemoveAt(lst.Count - 1);
            dic.Remove(val);
            return true;
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            if (lst.Count == 0)
                return -1;
            return lst[rand.Next(0, lst.Count)];
        }
    }
}
