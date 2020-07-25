using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/strobogrammatic-number/
    /// <ID>033</ID>
    /// </summary>
    class StrobogrammaticNumber
    {
        public bool IsStrobogrammatic(string num)
        {
            for(int i=0;i<num.Length/2;i++)
            {
                if (!"00 11 696 88".Contains(num[i] + "" + num[num.Length - 1 - i])) return false;
            }
            return true;
        }
    }
}
