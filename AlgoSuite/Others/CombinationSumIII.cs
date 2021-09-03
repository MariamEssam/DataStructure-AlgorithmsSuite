using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class CombinationSumIII
    {
        protected void backtrack(int remain, int k,
            LinkedList<int> comb, int next_start,
            IList<IList<int>> results)
        {

            if (remain == 0 && comb.Count == k)
            {
                // Note: it's important to make a deep copy here.
                results.Add(new List<int>(comb));
                return;
            }
            else if (remain < 0 || comb.Count == k)
            {
                // Exceed the scope, no need to explore further.
                return;
            }

            // Iterate through the reduced list of candidates.
            for (int i = next_start; i < 9; ++i)
            {
                comb.AddLast(i + 1);
                this.backtrack(remain - i - 1, k, comb, i + 1, results);
                comb.RemoveLast();
            }
        }


        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            IList<IList<int>> results = new List<IList<int>>();
            LinkedList<int> comb = new LinkedList<int>();

            this.backtrack(n, k, comb, 0, results);
            return results;
        }
    }
}
