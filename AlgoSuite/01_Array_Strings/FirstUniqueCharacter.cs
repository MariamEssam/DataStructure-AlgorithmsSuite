using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/first-unique-character-in-a-string/
    /// <ID>064</ID>
    /// </summary>
    class FirstUniqueCharacter
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> uniquechar = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!uniquechar.ContainsKey(s[i]))
                    uniquechar.Add(s[i], 0);
                uniquechar[s[i]]++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (uniquechar[s[i]] == 1)
                    return i;
            }
            return -1;
        }
    }
}
