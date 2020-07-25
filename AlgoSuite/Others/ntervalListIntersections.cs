using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ntervalListIntersections
    {
        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            List<int[]> arr_lst = new List<int[]>();
            int i = 0, j = 0;
            while(i<A.Length&&j<B.Length)
            {
                int low = Math.Max(A[i][0], B[j][0]);
                int high = Math.Min(A[i][1], B[j][1]);
                if(low<=high)
                {
                    arr_lst.Add(new int[] { low, high });
                }
                if (A[i][1] < B[j][1])
                {
                    i++;
                }
                else
                    j++;
            }

            return arr_lst.ToArray();

        }
    }
}
