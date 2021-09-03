using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class NumberofEnclaves
    {
        void findboundaries(int[][] A,int i,int j)
        {
            if(i>=0&&i<A.Length&&j>=0&&j<A[0].Length&&A[i][j]==1)
            {
                A[i][j] = 0;
                findboundaries(A, i + 1, j);
                findboundaries(A, i - 1, j);
                findboundaries(A, i, j + 1);
                findboundaries(A, i, j - 1);

            }
        }
        public int NumEnclaves(int[][] A)
        {
            for(int i=0;i<A.Length;i++)
            {
                if (A[i][0] == 1)
                    findboundaries(A, i, 0);
                if (A[i][A[0].Length - 1] == 1)
                    findboundaries(A, i, A[0].Length - 1);
            }
            for (int j = 0; j < A[0].Length; j++)
            {
                if (A[0][j] == 1)
                    findboundaries(A,0,j);
                if (A[A.Length - 1][j] == 1)
                    findboundaries(A, A.Length - 1, j);
            }
            int count = 0;
            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < A[0].Length; j++) if (A[i][j] == 1) count++;
            return count;
        }
    }
}
