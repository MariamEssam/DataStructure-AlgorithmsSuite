using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum-less-than-k/
    /// <ID>2099</ID>
    /// </summary>
    class TwoSumLessThanKC
    {
        public int TwoSumLessThanK(int[] A, int K)
        {
            Array.Sort(A);
            int ptr2 = A.Length - 1, ptr1 = 0;
            int max = int.MinValue;
            while(ptr1<ptr2)
            {
                int sum = A[ptr1] + A[ptr2];
                if (sum>max&&sum<=K)
                {
                    sum = max;
                }
                if (sum > K)
                {
                    ptr2--;
                }
                else
                    ptr1++;
            }
            return max;
        }
    }
}
