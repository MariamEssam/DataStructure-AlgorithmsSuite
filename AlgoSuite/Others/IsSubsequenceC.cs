using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/is-subsequence/
    /// <ID></ID>
    /// </summary>
    class IsSubsequenceC
    {
        public bool IsSubsequence(string s, string t)
        {
            if (String.IsNullOrEmpty(s))
                return true;
            int ptr = 0;
            foreach (char c in t)
            {
                if (s[ptr] == c)
                    ptr++;
                if (ptr == s.Length)
                    return true;
            }
            return false;
        }
    }
}
