using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-string/
    /// <ID>1344</ID>
    /// </summary>
    class ReverseStringC
    {
        public void ReverseString(char[] s)
        {
            int i = 0, j = s.Length - 1;
            while(i<j)
            {
                char c = s[i];
                s[i++] = s[j];
                s[j--] = c;
            }
        }
    }
}
