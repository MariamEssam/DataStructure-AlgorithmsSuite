using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/number-complement/
    ///<ID>062</ID>
    /// </summary>
    class NumberComplement
    {
        public int FindComplement(int num)
        {
            uint mask = 0xFFFFFFFF;
            uint val = 0x80000000;
            while(num!=0&&(val&num)==0)
            {
                val =val>> 1;
                mask = mask>> 1;
            }
            return num ^ (int)mask;
        }
    }
}
