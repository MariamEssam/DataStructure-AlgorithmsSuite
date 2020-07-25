using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class CountSquareSubmatrices
    {
        public int CountSquares(int[][] matrix)
        {
            int res = 0;
            for(int i=0;i<matrix.Length;i++)
            {
                for(int j=0;j<matrix[0].Length;j++)
                {
                    if (i > 0 && j > 0 && matrix[i][j] > 0)
                        matrix[i][j] = Math.Min(matrix[i - 1][j - 1], Math.Min(matrix[i - 1][j], matrix[i][j - 1]))+1;
                    res += matrix[i][j];
                }
            }
            return res;
        }
    }
}
