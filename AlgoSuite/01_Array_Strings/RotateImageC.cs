using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class RotateImageC
    {
        public void Rotate(int[][] matrix)
        {
            if (matrix.Length <= 1)
                return;
            int N = matrix.Length;
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    int temp = matrix[j][i];
                    matrix[j][i] = matrix[i][j];
                    matrix[i][j] = temp;
                }
            }

            for (int i=0;i<N;i++)
            {
                for(int j=0;j<N/2;j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][N-j-1];
                    matrix[i][N - j - 1] = temp;
                }
            }
          
        }
    }
}
