using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MaxSumContiguousSubarray
    {
        /// <summary>
        /// https://www.interviewbit.com/problems/max-sum-contiguous-subarray/
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int maxSubArray(List<int> A)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;
            for(int i=0;i<A.Count;i++)

            {
                currentSum += A[i];
                maxSum = Math.Max(maxSum, currentSum);
                if (currentSum<0)
                {
                    currentSum = 0;
                }
              
            }
            return maxSum;
        }
    }
}
