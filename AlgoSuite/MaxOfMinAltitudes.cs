using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/383669/
    /// <ID>5012</ID>
    /// </summary>
    class MaxOfMinAltitudes
    {
        //Using DFS
        int FindMin(int[][] grid, int r, int c, int min)
        {
            if (r < grid.Length && c < grid[0].Length)
            {
                if (r == grid.Length - 1 && c == grid[0].Length - 1)
                    return min==int.MaxValue?-1:min;
                int val1 = FindMin(grid, r + 1, c, Math.Min(min, grid[r][c]));
                int val2 = FindMin(grid, r, c + 1, Math.Min(min, grid[r][c]));
                return Math.Max(val1, val2);
            }
            return -1;
        }
        //Using DFS
        public int FinMaxofMin(int[][] grid)
        {
            if (grid.Length == 0) return -1;
            return Math.Max(FindMin(grid, 0, 1, int.MaxValue), FindMin(grid, 1, 0, int.MaxValue));
        }
        public int FinMaxofMin2(int[][] grid)
        {
            int ans = -1;
            int m = grid.Length;
            if (m == 0) return ans;
            int n = grid[0].Length;
            for (int i = 2; i < n; i++)
                grid[0][i] = Math.Min(grid[0][i - 1], grid[0][i]);
            for (int i = 2; i < m; i++)
                grid[i][0] = Math.Min(grid[i - 1][0], grid[i][0]);
            for(int i=1;i<m;i++)
            {
                for(int j=1;j<n;j++)
                {
                    if(i==m-1&&j==n-1)
                    {
                        ans = Math.Max(grid[i - 1][j], grid[i][j - 1]);
                    }
                    else
                    {
                        int l = Math.Min(grid[i][j], grid[i][j - 1]);
                        int r = Math.Min(grid[i-1][j], grid[i][j]);
                        grid[i][j] = Math.Max(l, r);
                    }
                }
            }
            return ans;
        }
    }
}
