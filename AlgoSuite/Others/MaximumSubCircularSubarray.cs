using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MaximumSubCircularSubarray
    {
        public int MaxSubarraySumCircular(int[] A)
        {
            int N = A.Length;
            int maxSum = A[0], curr = A[0];
            for(int i=1;i<N;i++)
            {
                curr = A[i] + Math.Max(curr, 0);
                maxSum = Math.Max(maxSum, curr);
            }
            int[] rightsums = new int[N];
            rightsums[N - 1] = A[N - 1];
            for (int i = N - 2; i >= 0; i--)
                rightsums[i] = rightsums[i + 1] + A[i];
            int[] maxright = new int[N];
            maxright[N - 1] = A[N - 1];
            for(int i=N-2;i>=0 ;i--)
            {
                maxright[i] = Math.Max(maxright[i + 1], rightsums[i]);
            }
            int leftsum = 0;
            for(int i=0;i<N-2;i++)
            {
                leftsum += A[i];
                maxSum = Math.Max(maxSum, leftsum + maxright[i + 2]);
            }
            return maxSum;
        }
    }
}
