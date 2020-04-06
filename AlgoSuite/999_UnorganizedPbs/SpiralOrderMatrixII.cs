using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://www.interviewbit.com/problems/spiral-order-matrix-ii/
    /// </summary>
    class SpiralOrderMatrixII
    {
        public List<List<int>> generateMatrix(int A)
        {
            List<List<int>> res = new List<List<int>>();
            if (A == 0) return res;
            int[][] arr = new int[A][];
            for (int i = 0; i < A; i++)
                arr[i] = new int[A];
            int index = 0;
            int[] dir_r = new int[] { 0, 1, 0, -1 };
            int[] dir_col=new int[] { 1, 0, -1, 0 };
            int[] bound_r = new int[] { 0, A };
            int[] bound_col = new int[] { 0, A };
            int r = 0, c = 0;
            int k = 0;
            arr[0][0] = 1;
            while (index<A*A-1)
            {
               
               while((r+dir_r[k])>=bound_r[0]&& (r + dir_r[k])<bound_r[1]
                    &&(c+dir_col[k]>=bound_col[0])&& (c + dir_col[k] < bound_col[1]))
                {
                    r += dir_r[k];
                    c += dir_col[k];
                    arr[r][c] = ++index+1;
                }
                k++;
                k = k % 4;
                bound_r[0] = dir_r[k] > 0 ? bound_r[0]+1 : bound_r[0];
                bound_r[1] = dir_r[k] < 0 ? bound_r[1]-1 : bound_r[1];
                bound_col[0] = dir_col[k] > 0 ? bound_col[0]+1 : bound_col[0];
                bound_col[1] = dir_col[k] < 0 ? bound_col[1]-1 : bound_col[1];
              
               
            }
            for (int i = 0; i < A; i++)
                res.Add(arr[i].ToList());
            return res;
        }
    }
}
