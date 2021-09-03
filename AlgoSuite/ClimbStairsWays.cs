using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/climbing-stairs/
    /// <ID>1070</ID>
    /// </summary>
    class ClimbStairsWays
    {
        /// <summary>
        /// Using dynamic programing
        /// </summary>
        public int ClimbStairs(int n)
        {
            if (n == 1) return n;
            int first = 1, second = 2;
            for (int i = 3; i <= n; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }
            return second;
        }
            int findNumOfWays(int n,int[] nums)
        {
            if(n>0)
            {
                if (nums[n]>0) return nums[n];
                nums[n] = findNumOfWays(n - 1,nums) + findNumOfWays(n - 2,nums);
                return nums[n];
            }
            return 0;
        }
        public int ClimbStairs_withMemorization(int n)
        {
            int[] nums = new int[n + 1];
            nums[1]= 1;
            nums[2]= 2;
            return findNumOfWays(n,nums);
        }
    }
}
