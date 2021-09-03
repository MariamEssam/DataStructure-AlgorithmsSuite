using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/855839/
    /// <ID>5016</ID>
    /// </summary>
    class LRUCacheMisses
    {
       public int lruCacheMisses(int num, List<int> pages, int maxCacheSize)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int ptr0 = 0, ptr1 = 0;
            int totalMissies = 0;
            while(ptr0<num&&ptr1<num)
            {
                if (dic.ContainsKey(pages[ptr1]))
                    dic[pages[ptr1]]++;
                else
                {
                    totalMissies++;
                    dic.Add(pages[ptr1], 1);
                    while(dic.Count>maxCacheSize)
                    {
                        dic[pages[ptr0]]--;
                        if (dic[pages[ptr0]] == 0)
                            dic.Remove(pages[ptr0]);
                        ptr0++;
                    }
                }
                ptr1++;
            }
            return totalMissies;
        }
    }
}
