using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/bitwise-and-of-numbers-range/
    /// <ID>043</ID>
    /// </summary>
    class BitwiseANDnumberrange
    {
        public int RangeBitwiseAnd(int m, int n)
        {
            
            int count = 0;
            while (m<n)
            {
                m >>= 1;
                n >>= 1;
                count++;
            }
            return m<<count;
        }
    }
}
