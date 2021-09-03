using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix/
    /// <ID>1054</ID>
    /// </summary>
    class SpiralMatrixC
    {
        enum direction { up, down, right, left };
        public IList<int> SpiralOrder(int[][] matrix)
        {
            if (matrix.Length == 0)
                return new List<int>();
            int lenghth = matrix.Length * matrix[0].Length;

            int[] row = new int[] { 0, matrix.Length - 1 };
            int[] col = new int[] { 0, matrix[0].Length - 1 };
            List<int> mylist = new List<int>();
            direction dir = direction.right;
            int i = 0, j = 0;
            while (i >= row[0] && i <= row[1]
                && j >= col[0] && j <= col[1])
            {
                mylist.Add(matrix[i][j]);
                switch (dir)
                {
                    case direction.right:
                        if (j + 1 > col[1])
                        {
                            dir = direction.down;
                            i++;
                            row[0]++;
                        }
                        else
                            j++;
                        break;
                    case direction.down:
                        if (i + 1 > row[1])
                        {
                            dir = direction.left;
                            j--;
                            col[1]--;
                        }
                        else
                            i++;
                        break;
                    case direction.left:
                        if (j - 1 < col[0])
                        {
                            dir = direction.up;
                            i--;
                            row[1]--;
                        }
                        else
                            j--;
                        break;
                    default:
                        if (i - 1 < row[0])
                        {
                            dir = direction.right;
                            col[0]++;
                            j++;
                        }
                        else
                            i--;
                        break;
                }
            }
            return mylist;
        }
    }
}
