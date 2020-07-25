using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ValidParenthesisString
    {
      
        public bool CheckValidString(string s)
        {
            int low = 0, high = 0;
            for(int i=0;i<s.Length;i++)
            {
                low += s[i] == '(' ? 1 : -1;
                high += s[i] == ')' ? 1 : -1;
                if (high < 0) return false;
            }
            return low == 0;
        }
    }
}
