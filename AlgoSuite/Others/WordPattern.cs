using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class WordPatternC
    {
        public bool WordPattern(string pattern, string str)
        {
            Dictionary<char, string> dic = new Dictionary<char, string>();
            HashSet<string> uniqueword = new HashSet<string>();
            string[] sentence = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (sentence.Length != pattern.Length) return false;
            for(int i=0;i<sentence.Length;i++)
            {
                if (!dic.ContainsKey(pattern[i]))
                {
                    if (uniqueword.Contains(sentence[i])) return false;
                    dic.Add(pattern[i], sentence[i]);
                    uniqueword.Add(sentence[i]);
                }
                if (dic[pattern[i]] != sentence[i])
                    return false;
            }
            return true;
        }
    }
}
