using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/861432/
    /// <ID>5002</ID>
    /// </summary>
    class GetSongsPairs
    {
        public int getPairsCount(List<int> pairs)
        {
            int MINUTE = 60;
            int count = 0;
            Dictionary<int,int> set = new Dictionary<int, int>();
            //set.Add(0, 1);
            for (int i=0;i<pairs.Count;i++)
            {
                int val = pairs[i] % MINUTE;
                if (set.ContainsKey((MINUTE-val)%MINUTE)) count+=set[(MINUTE - val) % MINUTE];
                if (!set.ContainsKey(val)) set.Add(val, 1);
                else set[val]++;
            }
            return count;
        }
    }
}
