using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LongestPalindromeC
    {
        public int LongestPalindrome(string s)
        {
            HashSet<char> charset = new HashSet<char>();
            int pairs = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (charset.Contains(s[i]))
                {
                    pairs++;
                    charset.Remove(s[i]);
                }
                else
                    charset.Add(s[i]);
            }
            return charset.Count != 0 ? 2 * pairs + 1 : 2 * pairs;
        }
        
    }
}
