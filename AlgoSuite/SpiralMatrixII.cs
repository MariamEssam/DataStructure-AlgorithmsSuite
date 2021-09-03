using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix-ii/
    /// <ID>1059</ID>
    /// </summary>
    class SpiralMatrixII
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] generatedmatrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                generatedmatrix[i] = new int[n];
            }
            if (n == 0) return generatedmatrix;
            int index = 0, max = n * n;
            int endrow = n - 1, endcol = n - 1;
            int startrow = 0, startcol = 0;
            while (index < max)
            {
                for (int i = startcol; i <= endcol; i++)
                    generatedmatrix[startrow][i] = ++index;
                startrow++;
                for (int i = startrow; i <= endrow; i++)
                    generatedmatrix[i][endcol] = ++index;
                endcol--;
                for (int i = endcol; i >= startcol; i--)
                    generatedmatrix[endrow][i] = ++index;
                endrow--;
                for (int i = endrow; i >= startrow; i--)
                    generatedmatrix[i][startcol] = ++index;
                startcol++;
            }
            return generatedmatrix;
        }
    }
}
