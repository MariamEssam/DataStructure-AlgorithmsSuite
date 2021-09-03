using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ToeplitzMatrix
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
        for(int i=1;i<matrix.Length;i++)
            {
                for(int j=1;j<matrix[0].Length;j++)
                {
                    if (matrix[i][j] != matrix[i - 1][j - 1])
                        return false;
                }
            }
            return true;
        }

    }
}
