using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/break-a-palindrome/
    /// <ID>2328</ID>
    /// </summary>
    class BreakPalindromeC
    {
        public string BreakPalindrome(string palindrome)
        {
            int length = palindrome.Length;
            StringBuilder build = new StringBuilder(palindrome);
            if (length <= 1) return String.Empty;
            for(int i=0;i<length;i++)
            {
                if (length % 2 != 0 && i == length / 2) continue;
                if(palindrome[i]!='a')
                {
                    build[i] = 'a';
                    return build.ToString();
                }
            }
            build[length - 1] = 'b';
            return build.ToString();
        }
    }
}
