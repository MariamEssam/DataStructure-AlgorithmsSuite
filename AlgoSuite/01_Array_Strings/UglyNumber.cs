using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/ugly-number/
    /// <ID>081</ID>
    /// </summary>
    class UglyNumber
    {
        int simpify(int num,int prim)
        {
            while (num != 1 && num % prim == 0)
            {
                num = num / prim;
            }
            return num; 
        }
        public bool IsUgly(int num)
        {
            num = simpify(num, 2);
            num = simpify(num, 3);
            num = simpify(num, 5);
            return num == 1;
        }
    }
}
