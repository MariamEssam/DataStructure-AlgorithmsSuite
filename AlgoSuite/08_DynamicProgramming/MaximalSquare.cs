using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/maximal-square/
    /// <ID>053</ID>
    /// </summary>
    class MaximalSquareC
    {
        public int MaximalSquare_BruteForce(char[][] matrix)
        {
            if (matrix.Length == 0) return 0;
            int row = matrix.Length;
            int col = matrix[0].Length;
            int maxseqlen = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i][j] == '1')
                    {
                        int seqlen = 1;
                        bool flag = true;
                        while (i + seqlen < row && j + seqlen < col && matrix[i + seqlen][j + seqlen] == '1' && flag)
                        {
                            for (int k = seqlen + i; k >= i; k--)
                            {
                                if (matrix[k][j + seqlen] != '1')
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            for (int k = seqlen + j; k >= j; k--)
                            {
                                if (matrix[i + seqlen][k] != '1')
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            if (flag)
                                seqlen++;
                        }
                        maxseqlen = Math.Max(maxseqlen, seqlen);
                    }
                }
            }
            return maxseqlen * maxseqlen;
        }
        public int MaximalSquare_dp(char[][] matrix)
        {
            if (matrix.Length == 0) return 0;
            int row = matrix.Length;
            int col = matrix[0].Length;
            int[][] dp = new int[row + 1][];
            for (int i = 0; i < dp.Length; i++)
                dp[i] = new int[col + 1];
            int maxseqlen = 0;
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    if(matrix[i][j]=='1')
                    {
                        dp[i + 1][j + 1] = Math.Min(Math.Min(dp[i + 1][j], dp[i][j + 1]), dp[i][j]) + 1;
                        maxseqlen= Math.Max(maxseqlen, dp[i + 1][j + 1]);
                    }
                }
            }
            return maxseqlen * maxseqlen;
        }
        public int MaximalSquare_optimumdp(char[][] matrix)
        {
            if (matrix.Length == 0) return 0;
            int row = matrix.Length;
            int col = matrix[0].Length;
            int[] dp;
            int maxseqlen = 0;
            for (int i = 0; i < row; i++)
            {
                dp = new int[col + 1];
                int prev = 0;
                for (int j = 0; j < col; j++)
                {
                    int temp = dp[j + 1];
                    if (matrix[i][j] == '1')
                    {
                        
                        dp[j + 1] = Math.Min(Math.Min(dp[j], dp[j + 1]), prev) + 1;
                        maxseqlen = Math.Max(maxseqlen, dp[j + 1]);
                        
                    }
                    prev = temp;
                }
            }
            return maxseqlen * maxseqlen;
        }
    }
}
