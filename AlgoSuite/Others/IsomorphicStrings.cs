using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            int[] s_map = new int[256];
            int[] t_map = new int[256];
            for(int i=0;i<s.Length;i++)
            {
                if (s_map[s[i]] != t_map[t[i]]) return false;
                s_map[s[i]] = i + 1;
                t_map[t[i]] = i + 1;
            }
            return true;
        }
    }
}
