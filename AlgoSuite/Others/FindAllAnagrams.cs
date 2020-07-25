using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class FindAllAnagrams
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            IList<int> results = new List<int>();
            Dictionary<char, int> p_dic = new Dictionary<char, int>();
            Dictionary<char, int> window_dic = new Dictionary<char, int>();

            int ptr1 = 0, ptr2 = 0;
            if (s.Length < p.Length)
                return results;
            foreach(var c in p)
            {
                if (!p_dic.ContainsKey(c))
                {
                    p_dic.Add(c, 0);
                }
                p_dic[c]++;
            }

            for (int i = 0; i < s.Length; ++i)
            {
                // add one more letter 
                // on the right side of the window
                
                if (window_dic.ContainsKey(s[i]))
                {
                    window_dic[s[i]]++;
                }
                else
                {
                    window_dic.Add(s[i], 1);
                }
                // remove one letter 
                // from the left side of the window
                if (i >= p.Length)
                {
                    char ch = s[i - p.Length];
                    if (window_dic[ch] == 1)
                    {
                        window_dic.Remove(ch);
                    }
                    else
                    {
                        window_dic[ch]--;
                    }
                }
                // compare hashmap in the sliding window
                // with the reference hashmap
                //if (equal(p_)
                //{
                //    output.add(i - np + 1);
                //}
            }
                return results;
        }
        bool equal(Dictionary<char,int> dic1,Dictionary<char,int> dic2)
        {
            if (dic1.Keys.Count != dic2.Keys.Count)
                return false;
            foreach(var item in dic1)
            {
                if (dic2.ContainsKey(item.Key) && dic2[item.Key] == dic1[item.Key])
                    continue;
                return false;
            }
            return true;
        }
    }
}
