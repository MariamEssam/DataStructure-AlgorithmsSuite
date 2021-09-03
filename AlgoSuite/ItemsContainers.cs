using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/861453/
    /// <ID>5003</ID>
    /// </summary>
    class ItemsContainers
    {
        public int numberOfItems(String s, List<int> startIndices, List<int> endIndices)
        {
            int[] counter = new int[s.Length + 1];
            int starscount = 0;
            int lastcount = 0;
            int result = 0;
            bool IsFound = false;
            for(int i=0;i<s.Length;i++)
            {
                if (IsFound&&s[i] == '*') starscount++;
                else if(s[i] == '|') { lastcount = starscount; IsFound = true; }
                counter[i + 1] = lastcount;
            }
            for(int i=0;i<startIndices.Count;i++)
            {
                result+=(counter[endIndices[i]] - counter[startIndices[i]]);
            }
            return result;
        }
    }
}
