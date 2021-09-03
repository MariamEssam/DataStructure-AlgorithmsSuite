using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PascalTriangleII
    {
        private int getNum(int row, int col)
        {
            if (row == 0 || col == 0 || row == col)
            {
                return 1;
            }

            return getNum(row - 1, col - 1) + getNum(row - 1, col);
        }

        public IList<int> GetRow(int rowIndex)
        {
            int[] arr = new int[rowIndex + 1];
            for (int i = 0; i <= rowIndex/2; i++)
            {
                int v= getNum(rowIndex, i);
                arr[i] = v;
                arr[rowIndex - i] = v;
            }
           
            
            return arr.ToList();
        }
    }
}
