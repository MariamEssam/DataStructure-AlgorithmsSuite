using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ImageOverlap
    {

        int ShiftAndCount(int[][]A,int[][] B,int yShift,int xShift)
        {
            int count = 0;
            int brow = 0;
            for (int arow = yShift;arow < A.Length;arow++)
            {
                int bcol = 0;
                for(int acol=xShift;acol<A.Length;acol++)
                {
                    if (A[arow][acol] == 1 && A[arow][acol] == B[brow][bcol]) count++;
                    bcol++;
                }
                brow++;
            }
            return count;
        }
        /// <summary>
        /// Trying all possible shifts exisiting
        /// </summary>
        public int LargestOverlap(int[][] A, int[][] B)
        {
            int maxoverlaps = 0;
            for(int yShift=0;yShift<A.Length;yShift++)
            {
                for(int xShift=0;xShift<B.Length;xShift++)
                {
                    maxoverlaps = Math.Max(maxoverlaps, ShiftAndCount(A, B, yShift, xShift));
                    maxoverlaps = Math.Max(maxoverlaps, ShiftAndCount(B, A, yShift, xShift));

                }
            }
            return maxoverlaps;
        }

    }
}
