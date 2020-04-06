using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SplitArrayLargestSum
    {
        public int SplitArray(int[] nums, int m)
        {
            int n = nums.Length;
            int[][] f = new int[n + 1][];
            int[] sub = new int[n + 1];
            for(int i=0;i<=n;i++)
            {
                f[i] = new int[m + 1];
                for(int j=0;j<=m;j++)
                {
                    f[i][j] = int.MaxValue;
                }
            }
            for(int i=0;i<n;i++)
            {
                sub[i + 1] = sub[i] + nums[i];
            }
            f[0][0] = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    for (int k = 0; k < i; k++)
                    {
                        f[i][j] = Math.Min(f[i][j], Math.Max(f[k][j - 1], sub[i] - sub[k]));
                    }
                }
            }
           return f[n][m];
        }
    }
}
