using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/398031/
    /// </summary>
    class LongestSubs
    {
        public string LongestSubstring(string str)
        {
            int ptr = 0;
            if (String.IsNullOrEmpty(str))
                return "";
            if (str.Length == 1)
                return str;
            char c = str[0];
            int max = int.MinValue;
            int occurrence = 1;
            int startindex=0,end = 0;
            for(int i=2;i<str.Length;i++)
            {
                if(str[i]==c)
                {
                    occurrence++;
                    if(occurrence>2)
                    {
                        ptr = i;
                        occurrence = 1;
                    }
                }
                else
                {
                    occurrence = 1;
                    c = str[i];
                }
                if((i-ptr+1)>max)
                {
                    startindex = ptr;
                    max = i - ptr + 1;
                }
            }
            return str.Substring(startindex, max);
        }
    }
}
