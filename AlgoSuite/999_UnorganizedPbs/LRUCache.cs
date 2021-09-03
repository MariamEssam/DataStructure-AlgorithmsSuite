using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/lru-cache/
    /// <ID>1146</ID>
    /// </summary>
    public class CachePair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }
        public CachePair(T1 f,T2 s)
        {
            First = f;
            Second = s;
        }
    }
    public class LRUCache
    {
        private int capacity;
        private Dictionary<int, CachePair<int, int>> dic;
        private LinkedList<CachePair<int, int>> cachedlst;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            dic = new Dictionary<int, CachePair<int, int>>();
            cachedlst = new LinkedList<CachePair<int, int>>();
        }
        public int Get(int key)
        {
            if (!dic.ContainsKey(key)) return -1;
            CachePair<int, int> pair = dic[key];
            cachedlst.Remove(pair);
            cachedlst.AddFirst(pair);
            return pair.Second;
        }
        public void Put(int key, int value)
        {
            if (!dic.ContainsKey(key))
            {
                dic.Add(key, new CachePair<int, int>(key,value));
                cachedlst.AddFirst(dic[key]);
            }
            else
            {
                dic[key].Second = value;
                cachedlst.Remove(dic[key]);
                cachedlst.AddFirst(dic[key]);
            }
            if(dic.Count>capacity)
            {
                dic.Remove(cachedlst.Last.Value.First);
                cachedlst.RemoveLast();
            }
        }
    }

}
