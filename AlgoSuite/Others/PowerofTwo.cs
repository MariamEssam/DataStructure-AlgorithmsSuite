using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/power-of-two/
    /// <ID></ID>
    /// </summary>
    class PowerofTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n == 0) return false;
            while (n % 2 == 0) n /= 2;
            return n == 1 ? true : false;

        }
    }
}
