using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/398037/
    /// </summary>
    class LongestSemiAlternating
    {
        public int LongestSemiAlternatingSub(string str)
        {
            if (str.Length == 0)
                return 0;
            int start = 0;
            int size = 1;
            int charcount = 1;
            for(int i=1;i<str.Length;i++)
            {
                if(str[i-1]==str[i])
                {
                    charcount++;
                    if(charcount>2)
                    {
                        start = i - 1;
                    }
                    else
                    {
                        size = Math.Max(size, i - start + 1);
                    }
                }
                else
                {
                    charcount = 1;
                    size = Math.Max(size, i - start + 1);
                }
            }
            return size;
        }
    }
}
