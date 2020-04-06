using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class Search2DMatrix
    {
        int geti(int mid,int l)
        {
            return mid / l;
        }
        int getj(int mid, int l)
        {
            return mid%l;
        }
        bool helper(int[][]matrix,int start,int end,int target)
        {
            if (start <= end)
            {
                int mid = (start + end) / 2;
                int i = geti(mid, matrix[0].Length);
                int j = getj(mid, matrix[0].Length);
                if (matrix[i][j]==target)
                {
                    return true;
                }
                else if(matrix[i][j]>target)
                {
                    return helper(matrix, start, mid - 1, target);
                }
                else
                {
                    return helper(matrix, mid + 1, end, target);
                }
            }
            return false;
        }
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0)
                return false;

            return helper(matrix, 0, (matrix[0].Length * matrix.Length) - 1, target);
        }
    }
}
