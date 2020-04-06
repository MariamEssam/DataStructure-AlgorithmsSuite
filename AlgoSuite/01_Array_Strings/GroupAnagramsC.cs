using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class GroupAnagramsC
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dics = new Dictionary<string, IList<string>>();
            for(int i=0;i<strs.Length;i++)
            {
                string sorted_str = String.Concat(strs[i].OrderBy(c => c));
                if (dics.ContainsKey(sorted_str))
                    dics[sorted_str].Add(strs[i]);
                else
                {
                    dics.Add(sorted_str, new List<string> { strs[i] });
                }

            }
            return dics.Values.ToList();
        }
        public IList<IList<string>> GroupAnagrams2(string[] strs)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                char[] arr = strs[i].ToCharArray();
                Array.Sort(arr);
                string str = String.Join("", arr);
                if (dic.ContainsKey(str))
                {
                    dic[str].Add(strs[i]);
                }
                else
                    dic.Add(str, new List<string>() { strs[i] });
            }

            return new List<IList<string>>(dic.Values);
        }
    }
}
