using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-dice-rolls-with-target-sum/
    /// <ID>2155</ID>
    /// </summary>
    class NumRollsToTargetSum
    {
        int[][] dp;
        public int NumRollsToTarget_BruteForce(int d, int f, int target)
        {
            if (d == 0 || target <= 0) return d == target ? 1 : 0;
            int res = 0;
            for (int i = 1; i <= f; i++)
                res = (res + NumRollsToTarget_BruteForce(d - 1, f, target - i)) % 1000000007;
            return res;
        }
        public int NumRollsToTarget_Helper(int d, int f, int target)
        {
            if (d == 0 || target <= 0) return d == target ? 1 : 0;
            if (dp[d][target] != 0)
                return dp[d][target] - 1;
            int res = 0;
            for (int i = 1; i <= f; i++)
                res = (res + NumRollsToTarget_Helper(d - 1, f, target - i)) % 1000000007;
            dp[d][target] = res + 1;
            return res;
        }
        public int NumRollsToTarget(int d, int f, int target)
        {
            dp = new int[4][];
            for(int i=0;i<dp.Length;i++)
            {
                dp[i] = new int[20];
            }
            
            return NumRollsToTarget_Helper(d, f, target);
        }
    }
}
