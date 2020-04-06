using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SetMatrixZeroes
    {
        public void SetZeroes(int[][] matrix)
        {
            if (matrix.Length == 0)
                return;
            int M = matrix.Length;
            int N = matrix[0].Length;
            for (int i=0;i<M;i++)
            {
                for(int j=0;j<N;j++)
                {
                    if (matrix[i][j] == 0)
                        TagZeros(matrix, i, j);
                }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i][j] == -1)
                        matrix[i][j] =0;
                }
            }
        }
        void TagZeros(int[][] matrix,int row,int col)
        {
            for(int i=0;i<matrix.Length;i++)
            {
                matrix[i][col] = -1;
            }
            for (int i = 0; i < matrix[0].Length; i++)
            {
                matrix[row][i] = -1;
            }
        }
    }
}
