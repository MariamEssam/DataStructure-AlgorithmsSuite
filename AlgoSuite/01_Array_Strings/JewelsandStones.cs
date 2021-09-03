using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/jewels-and-stones/
    /// <ID>1771</ID>
    /// </summary>
    class JewelsandStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            int count = 0;
            HashSet<char> J_set = new HashSet<char>();
            foreach (char c in J)
                J_set.Add(c);
            foreach(char c in S)
            {
                if (J_set.Contains(c)) count++;
            }
            return count;
        }
    }
}
