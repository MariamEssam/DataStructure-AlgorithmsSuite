using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class VerifyingAlienDictionary
    {
        bool IsOrdered(string word1,string word2,Dictionary<char,int> dic)
        {
            for(int i=0;i<word1.Length;i++)
            {
                if (i < word2.Length && dic[word1[i]] < dic[word2[i]])
                {
                    return true;
                }
                else if (i >= word2.Length || dic[word1[i]] > dic[word2[i]])
                    return false;
            }
            return true;
        }
        public bool IsAlienSorted(string[] words, string order)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < order.Length; i++)
                dic.Add(order[i], i);
            for(int i=1;i<words.Length;i++)
            {
                if (!IsOrdered(words[i - 1], words[i], dic))
                    return false;
            }
            return true;
        }
    }
}
