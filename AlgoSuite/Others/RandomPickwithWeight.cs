using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class RandomPickwithWeight
    {
        private int[] prefixSums;
        private int totalSum;

        public RandomPickwithWeight(int[] w)
        {
            this.prefixSums = new int[w.Length];

            int prefixSum = 0;
            for (int i = 0; i < w.Length; ++i)
            {
                prefixSum += w[i];
                this.prefixSums[i] = prefixSum;
            }
            this.totalSum = prefixSum;
        }

        public int PickIndex()
        {
            Random random = new Random();
            double target = this.totalSum * random.Next();
            int i = 0;
            // run a linear search to find the target zone
            for (; i < this.prefixSums.Length; ++i)
            {
                if (target < this.prefixSums[i])
                    return i;
            }
            // to have a return statement, though this should never happen.
            return i - 1;
        }
    }
}
