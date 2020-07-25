using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class QueueReconstructionbyHeight
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            var result = new List<int[]>();

            Array.Sort(people,(a, b) => a[0] != b[0] ? b[0] - a[0] : a[1] - b[1]);
            foreach (var p in people)
                result.Insert(p[1], p);
            return result.ToArray();
        }
    }
}
