using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-bits/
    /// <ID>084</ID>
    /// </summary>
    class ReverseBits
    {

        public uint reverseBits(uint n)
        {
            n = (n >> 16) | (n << 16);
            n = ((n & 0xFF00FF00) >> 8) | ((n & 0x00FF00FF) << 8);
            n = ((n & 0xF0F0F0F0) >> 4) | ((n & 0x0F0F0F0F) << 4);
            n = ((n & 0xCCCCCCCC) >> 2) | ((n & 0x33333333) << 2);
            n = ((n & 0xAAAAAAAA) >> 1) | ((n & 0x55555555) << 1);
            return n;
        }
        public uint reverseBits2(uint n)
        {
            int count = 0;
            uint res = 0;
            while (count < 32)
            {
                res <<= 1;
                res |= (n & 0x1);
                n >>= 1;
                count++;
            }
            return res;
        }
    }
}
