using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/398035/
    /// </summary>
    class MinDeletions
    {
        public int findMinDeletion(string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic.Add(str[i], 1);
                }
            }

            Dictionary<int, char> countSet = new Dictionary<int, char>();
            int deletion = 0;
            StringBuilder build = new StringBuilder();
            foreach (var c in str)
            {
                if (countSet.ContainsKey(dic[c]) && countSet[dic[c]] != c)
                {
                    dic[c]--;
                    deletion++;
                }
                else
                {
                    if (!countSet.ContainsKey(dic[c])) countSet.Add(dic[c], c);
                   
                }
            }
            return deletion;
        }
    }
}
