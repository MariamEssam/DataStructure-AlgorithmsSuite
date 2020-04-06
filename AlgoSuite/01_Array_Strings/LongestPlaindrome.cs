using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LongestPlaindromeC
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length == 0)
                return s;
            int maxlength = 1;
            int startIndex = 0;
            string longestplaindromestr = s[0].ToString();
            
            for(int i=0;i<s.Length-1;i++)
            {
                
                int tup1 = getlength(i - 1, i + 1,s);
                int tup2 = getlength(i, i + 1, s);
                if(tup1>tup2&&tup1>maxlength)
                {
                    maxlength = tup1;
                    startIndex = i-(maxlength)/2;
                }
                else if(tup2>tup1&&tup2>maxlength)
                {
                    maxlength = tup2;
                    startIndex = i-(maxlength-1)/2;
                }
                
            }
            return s.Substring(startIndex,maxlength);
        }
        int getlength(int ptr1,int ptr2,string s)
        {
            int maxlength = 0;
            if (ptr1 < 0 || ptr2 >= s.Length) return 0;
            while (ptr1 >= 0 && ptr2 < s.Length && s[ptr1] == s[ptr2])
            {
                maxlength = Math.Max(maxlength, ptr2 - ptr1 + 1);
                ptr1--;
                ptr2++;
            }
            return maxlength;
        }
    }
}
