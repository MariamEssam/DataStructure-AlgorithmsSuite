using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/valid-palindrome/
    /// <ID>1125</ID>
    /// </summary>
    class ValidPlaindrom
    {
        public bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;
            s = s.ToLower();
            while (i < j)
            {
                if (!IsValid(s[i]))
                {
                    i++;
                    continue;
                }
                if (!IsValid(s[j]))
                {
                    j--;
                    continue;
                }
                if (s[i++] != s[j--])
                    return false;

            }
            return true;
        }
        private bool IsValid(char c)
        {
            if ((c >= 'a' && c <= 'z')||(c>='0'&&c<='9'))
            {
                return true;
            }
            return false;
        }
    }
}
