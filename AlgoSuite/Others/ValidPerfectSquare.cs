using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/valid-perfect-square/
    /// <ID>067</ID>
    /// </summary>
    class ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            int l = 0, h = num / 2;
            while(l<=h)
            {
                int mid = l + (h - l) / 2;
                if (mid * mid == num)
                    return true;
                if (mid * mid < num)
                {
                    l = mid + 1;
                }
                else
                    h = mid - 1;
            }
            return false;
        }
    }
}
