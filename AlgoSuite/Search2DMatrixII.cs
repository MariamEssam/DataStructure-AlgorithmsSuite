using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/search-a-2d-matrix-ii/
    /// <ID>1240</ID>
    /// </summary>
    class Search2DMatrixII
    {
        bool BinarySearch(int start, int end, int fixeddimension, int[,] matrix, int target,bool isHorizontal)
        {
            int l = start, h = end;
            while (l <= h)
            {
                int mid = (l + h) / 2;
                int row = isHorizontal ? fixeddimension : mid;
                int column = isHorizontal ? mid : fixeddimension;
                if (target < matrix[row, column])
                {
                    h = mid - 1;
                }
                else if (target > matrix[row, column])
                {
                    l = mid + 1;
                }
                else
                    return true;
            }
            return false;
        }
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0) return false;
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int length = Math.Min(m, n);
            for (int i = 0; i < length; i++)
            {
                if (BinarySearch(i, m - 1, i, matrix, target,false) || BinarySearch(i, n - 1, i, matrix, target,true))
                    return true;
            }
            return false;
        }
    }
}
