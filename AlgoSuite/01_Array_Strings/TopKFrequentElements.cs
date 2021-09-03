using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/top-k-frequent-elements/
    /// <ID>1347</ID>
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
        class KeyValueCompare : IComparer<KeyValuePair<int, int>>
        {
            public int Compare(KeyValuePair<int, int> x, KeyValuePair<int, int> y)
            {
                return x.Value.CompareTo(y.Value);
            }
        }
        public int[] TopKFrequent2(int[] nums, int k)
        {
            int[] res = new int[k];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i])) dic.Add(nums[i], 0);
                dic[nums[i]]++;
            }
            KeyValueCompare cmp = new KeyValueCompare();
            MaxHeap<KeyValuePair<int, int>> maxHeap = new MaxHeap<KeyValuePair<int, int>>(cmp);
            foreach (var pain in dic)
                maxHeap.add(pain);
            for (int i = 0; i < k; i++)
                res[i] = maxHeap.Poll().Key;
            return res;
        }
    }

}
