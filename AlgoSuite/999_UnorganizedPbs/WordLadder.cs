using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// Incomplete
    /// </summary>
    class WordLadder
    {
        int mincost = 0;
        HashSet<string> dic = new HashSet<string>();
        string endwordstr;
        void LadderHelper(char[] beginword,char[] endword,int cost)
        {
            for(int i=0;i<beginword.Length;i++)
            {
                if (endword[i] == '#'||endword[i]==beginword[i]) continue;
                char c = beginword[i];
                char c2 = endword[i];
                beginword[i] = endword[i];
                endword[i] = '#';
                string word = new string(beginword);
                if (word == endwordstr)
                {
                    if (mincost > cost + 1 || mincost == 0)
                    {
                       mincost=cost+1;
                    }
                }
                if (dic.Contains(word))
                {
                    LadderHelper(beginword, endword, cost + 1);
                }
                beginword[i] = c;
                endword[i] = c2;
            }
        }
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (beginWord.Length != endWord.Length) return 0;
            foreach (var str in wordList) dic.Add(str);
            endwordstr = endWord;
            LadderHelper(beginWord.ToCharArray(), endWord.ToCharArray(), 0);
            return mincost;
        }
    }
}
