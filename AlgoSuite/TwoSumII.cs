using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    /// <ID>1167</ID>
    /// </summary>
    class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int low = 0, high = numbers.Length - 1;
            while(low<high)
            {
                int sum = numbers[low] + numbers[high];
                if(sum==target)
                {
                    return new int[] { low + 1, high + 1 };
                }
                else if(sum>target)
                {
                    high--;
                }
                else
                {
                    low++;
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
