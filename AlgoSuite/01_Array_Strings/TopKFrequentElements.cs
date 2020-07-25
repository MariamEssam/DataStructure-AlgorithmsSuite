using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/top-k-frequent-elements/
    /// <ID>061</ID>
    /// </summary>
    class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            List<int> res = new List<int>();
            int maxfreq = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach(var n in nums)
            {
                if (!dic.ContainsKey(n))
                    dic.Add(n, 0);
                dic[n]++;
                maxfreq = Math.Max(maxfreq, dic[n]);
            }
            List<int>[] numlst = new List<int>[maxfreq+1];
            foreach(var key in dic.Keys)
            {
                if (numlst[dic[key]] == null) numlst[dic[key]] = new List<int>();
                numlst[dic[key]].Add(key);
            }
            for(int i=numlst.Length-1;i>=0;i--)
            {
                if(numlst[i]!=null)
                {
                    res.AddRange(numlst[i]);
                    k -= numlst[i].Count;
                }
                if (k <= 0)
                    break;
            }
            return res.ToArray();
        }
    }
}
