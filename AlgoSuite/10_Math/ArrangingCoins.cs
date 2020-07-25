using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/arranging-coins/
    /// <ID>079</ID>
    /// </summary>
    class ArrangingCoinsC
    {
        public int ArrangeCoins(int n)
        {
            int x = (int)(-0.5 + (Math.Sqrt(0.25 + 2.0 * n)));
            return x;
        }
    }
}
