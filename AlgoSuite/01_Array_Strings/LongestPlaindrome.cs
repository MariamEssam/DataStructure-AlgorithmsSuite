using System;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindromic-substring/
    /// <ID>1005</ID>
    /// </summary>
    class LongestPlaindromeC
    {

        public string LongestPalindrome(string s)
        {
            int start = 0, length = 1;

            for (int i = 0; i < s.Length; i++)
            {
                int len1 = getlength(i, i + 1, s);
                int len2 = getlength(i - 1, i + 1, s) + 1;
                int len = Math.Max(len1, len2);
                if (len > length)
                {
                    start = i - (len - 1) / 2;
                    length = len;
                }
            }
            return s.Substring(start, length);
        }
        int getlength(int ptr1, int ptr2, string s)
        {
            int length = 0;
            while (ptr1 >= 0 && ptr2 < s.Length)
            {
                if (s[ptr1--] != s[ptr2++]) break;
                length++;
            }
            return 2 * length;
        }
    }
}
