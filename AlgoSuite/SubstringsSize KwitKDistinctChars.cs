using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/877624/
    /// <ID>5008</ID>
    /// </summary>
    class SubstringsSize_KwitKDistinctChars
    {
        void RemoveChar(Dictionary<char,int> dic,char c)
        {
            dic[c]--;
            if (dic[c]==0) dic.Remove(c);
        }
        void AddChar(Dictionary<char, int> dic, char c)
        {
            if (!dic.ContainsKey(c)) dic.Add(c,0);
            dic[c]++;
        }
        public List<String> computeSubStrings(String S, int k)
        {
            HashSet<string> result = new HashSet<string>();
            if (S.Length < k) return result.ToList();
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for(int i=0;i<S.Length;i++)
            {
                if (i >= k)
                {
                    //Remove Previous Char
                    RemoveChar(dic, S[i - k]);
                }
                    //Add New Char
                    AddChar(dic, S[i]);
                    if (dic.Count == k - 1&&i>=k -1)
                        result.Add(S.Substring(i - k + 1, k));
                
            }
            return result.ToList();
        }
    }
}
