using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{/// <summary>
/// https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/
/// <ID>2304</ID>
/// </summary>
    class SumUniqueZero
    {
        public int[] SumZero(int n)
        {
            int[] arr = new int[n];
            int val = -n / 2;
            int i = 0;
            while(i<n)
            {
                if (val == 0 && n % 2 == 0)
                {
                    val++;continue;
                }
                arr[i++] = val++;
            }
            return arr;
        }
    }
}
