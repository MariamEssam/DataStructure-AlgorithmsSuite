using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/squares-of-a-sorted-array/
    /// <ID>078</ID>
    /// </summary>
    class SquaresofSortedArray
    {
        public int[] SortedSquares(int[] A)
        {
            int[] sortedres = new int[A.Length];
            int negptr = 0, posptr = 0, ptr = A.Length - 1;
            while(negptr<=posptr)
            {
                if(Math.Abs(A[negptr])>= Math.Abs(A[posptr]))
                {
                    sortedres[ptr++] = A[negptr] * A[negptr];
                    negptr++;
                }
                else
                {
                    sortedres[ptr++] = A[posptr] * A[posptr];
                    posptr--;
                }
            }
            return sortedres;
        }
        public int[] SortedSquares2(int[] A)
        {
            int[] sortedres = new int[A.Length];
            for(int i=0;i<A.Length;i++)
            {
                sortedres[i]=(A[i] * A[i]);
            }
            Array.Sort(sortedres);
            return sortedres;
        }
    }
}
