using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
namespace AlgoSuite
{
    public class LRUCache
    {
        OrderedDictionary dic_ordered;
        int cap = 0;
        public LRUCache(int capacity)
        {
            dic_ordered = new OrderedDictionary(capacity);
            cap = capacity;
        }

        public int Get(int key)
        {
            if (!dic_ordered.Contains(key)) return -1;
            int val =  (int)dic_ordered[(object)key];
            dic_ordered.Remove(key);
            dic_ordered.Add(key, val);
            return val;
        }

        public void Put(int key, int value)
        {
            if (dic_ordered.Contains(key))
                dic_ordered.Remove(key);
            if (dic_ordered.Count == cap)
                dic_ordered.RemoveAt(0);
            
            dic_ordered.Add(key, value);
        }
    }

}
