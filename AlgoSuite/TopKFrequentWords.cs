using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/top-k-frequent-words/
    /// <ID>1692</ID>
    /// </summary>
    class TopKFrequentWords
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for(int i=0;i<words.Length;i++)
            {
                if (!dic.ContainsKey(words[i])) dic.Add(words[i], 0);
                dic[words[i]]++;
            }
            var lst = dic.ToList();
            lst.Sort((item1, item2) => item2.Value==item1.Value?item1.Key.CompareTo(item2.Key):item2.Value.CompareTo(item1.Value));
            IList<string> result = new List<string>();
            for (int i = 0; i < k; i++)
                result.Add(lst[i].Key);
            return result;
        }
    }
}
