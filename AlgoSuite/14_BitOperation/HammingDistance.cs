using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/hamming-distance/
    /// <ID>080</ID>
    /// </summary>
    class HammingDistanceC
    {
        public int HammingDistance(int x, int y)
        {
            int res = x ^ y;
            int count = 0;
            while(res!=0)
            {
                count = (res & 1) == 0? count : count + 1;
                res =res >> 1;
            }
            return count;
        }
    }
}
