using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/leftmost-column-with-at-least-a-one/
    /// <ID>058</ID>
    /// </summary>
    class LeftMostColumnWithOneC
    {
        public class BinaryMatrix
        {
            public int Get(int x, int y) { return 0; }
            public IList<int> Dimensions() { return null; }
        }
        public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
        {
            IList<int> dim = binaryMatrix.Dimensions();
            int mincol = int.MaxValue;
            for (int i = 0; i < dim[0]; i++)
            {
                int low = 0, high = dim[1] - 1;
                while (low < high)
                {
                    int mid = (low + high) / 2;
                    int mid_val = binaryMatrix.Get(i, mid);


                    if (mid_val == 0)
                        low = mid + 1;
                    if (mid_val == 1)
                        high = mid;
                }
                if (binaryMatrix.Get(i, low) == 1)
                {
                    mincol = Math.Min(mincol, low);
                }
            }
            return mincol == int.MaxValue ? -1 : mincol;
        }
    }
}
