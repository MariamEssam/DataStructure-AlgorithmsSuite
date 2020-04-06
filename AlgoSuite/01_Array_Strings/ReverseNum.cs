using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ReverseNum
    {
        /// <summary>
        /// https://leetcode.com/problems/reverse-integer/
        /// <ID>011</ID>
        /// </summary>
        public int Reverse(int x)
        {
            if (x == 0) return x;
            bool sign = x >= 0 ? true : false;
            x = Math.Abs(x);
            int val = 0;
            while(x!=0)
            {
                if (val > int.MaxValue / 10) return 0;
                val = val * 10 + x % 10;
                x /= 10;
            }
            return sign ? val : -val;
        }
    }
}
