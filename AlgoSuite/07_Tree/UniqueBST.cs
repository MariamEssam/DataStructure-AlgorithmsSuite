using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class UniqueBST
    {
        public int NumTrees(int n)
        {
            int C = 1;
            for(int i=0;i<n;i++)
            {
                C = C * 2 * (2 * i + 1) / (i + 2);
            }
            return C;
        }
    }
}
