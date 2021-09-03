using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/valid-anagram/
    /// <ID>1242</ID>
    /// </summary>
    class IsAnagramC
    {
        public bool IsAnagram(string s, string t)
        {
            if (s == null || t == null) return false;
            if (s.Length != t.Length) return false;
            char[] s_arr = s.ToCharArray();
            char[] t_arr = t.ToCharArray();
            Array.Sort(s_arr);
            Array.Sort(t_arr);
            if (new string(s_arr) != new string(t_arr)) return false;
            
            return Array.Equals(s_arr, t_arr);
        }
    }
}
