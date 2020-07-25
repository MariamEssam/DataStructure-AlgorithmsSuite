using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LengthOfLongestSubstringC
    {
        /// <summary>
        /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
        /// <ID>013</ID>
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> set_char = new HashSet<char>();
            int i = 0, j = 0;
            int max = 0;
            while(j<s.Length)
            {
                if(set_char.Contains(s[j]))
                 set_char.Remove(s[i++]);
                else
                set_char.Add(s[j++]);
                
                max = Math.Max(set_char.Count, max);
            }
            return max;
        }
    }
}
