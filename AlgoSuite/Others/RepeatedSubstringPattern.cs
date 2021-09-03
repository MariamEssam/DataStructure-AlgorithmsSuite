using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class RepeatedSubstringPatternC
    {
        public bool RepeatedSubstringPattern(string s)
        {
            int length= s.Length;
            for(int i=length/2;i>0;i--)
            {
                if(length%i==0)
                {
                    string substr = s.Substring(0, i);
                    int m = length / i;
                    StringBuilder sb = new StringBuilder();
                    while(m!=0)
                    {
                        sb.Append(substr);
                        m--;
                    }
                    if (sb.ToString() == s) return true;
                }
            }
            return false;
        }
    }
}
