using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/most-common-word/
    /// <ID>1819</ID>
    /// </summary>
    class MostCommonWordC
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            int maxFreq = 0; string word = String.Empty;
            string[] splitted = paragraph.Split(new char[] { ' ', '!', '?', '\'', ';', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> dic = new Dictionary<string, int>();
            HashSet<string> banendSet = new HashSet<string>();
            for (int i = 0; i < banned.Length; i++)
            {
                banendSet.Add(banned[i].ToLower());
            }
            for (int i = 0; i < splitted.Length; i++)
            {
                string s = splitted[i].ToLower();
                if (banendSet.Contains(s)) continue;
                if (!dic.ContainsKey(s)) dic.Add(s, 0);
                dic[s]++;
                if (dic[s] > maxFreq) { maxFreq = dic[s]; word = s; }
            }
            return word;
        }

    }
}
