using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class TwoCityScheduling
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            int cost = 0;
            int[][] sorted_costs = costs.OrderByDescending(x => (x[0] - x[1])).ToArray();
            int N = costs.Length / 2;
            for (int i = 0; i < N; i++)
                cost += sorted_costs[i][1];
            for (int i = N; i < 2*N; i++)
                cost += sorted_costs[i][1];
            return cost;
        }
    }
}
