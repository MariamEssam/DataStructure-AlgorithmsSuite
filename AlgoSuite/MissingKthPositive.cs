using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/kth-missing-positive-number/
    /// <ID>2539</ID>
    /// </summary>
    class MissingKthPositive
    {
        public int FindKthPositive(int[] arr, int k)
        {
            int left = 0, right = arr.Length - 1;
            while(left<=right)
            {
                int pivot = left + (right - left) / 2;
                if (arr[pivot] - pivot - 1 < k)
                    left = pivot + 1;
                else
                    right = pivot - 1;
            }
            return left + k;
        }
        /// <summary>
        /// Brute force method.
        /// </summary>
        public int FindKthPositive_BruteForce(int[] arr, int k)
        {
            int prev = 0;
            int index = 0;
            while(index<arr.Length)
            {
                int diff = arr[index] - prev - 1;
                
                    if(k - diff<=0)
                    {
                        return prev + k;
                    }
                    else
                    {
                        k = k - diff;
                    }
                prev = arr[index];
                index++;
            }
            return prev + k;
        }
    }
}
