using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/233724
    /// <ID>5005</ID>
    /// </summary>
    class LongestStringOnlyVowels
    {
        bool IsVowel(char c)
        {
           return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
        public int longestString(String s)
        {
            int length = s.Length;
            int start = 0, end = length - 1;
            while (start < length && IsVowel(s[start])) start++;
            while (end >= 0 && IsVowel(s[end])) end--;
            if (start >= length) return length;
            int cornervowels = start + length - 1 - end;
            int max = 0, sum = 0;
            for(int i=start;i<=end;i++)
            {
                if (IsVowel(s[i]))
                {
                    sum++;
                }
                else
                    sum = 0;
                max = Math.Max(sum, max);
            }
            return max + cornervowels;
        }
    }
}
