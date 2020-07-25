using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/complement-of-base-10-integer/
    /// <ID>063</ID>
    /// </summary>
    class ComplementBase10
    {
        public int BitwiseComplement(int N)
        {
            if (N == 0)
                return 1;
            uint mask = 0xFFFFFFFF;
            uint val = 0x80000000;
            while (N != 0 && (val & N) == 0)
            {
                val = val >> 1;
                mask = mask >> 1;
            }
            return N ^ (int)mask;

        }
    }
}
