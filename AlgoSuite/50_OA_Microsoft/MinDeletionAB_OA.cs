using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MinDeletionAB_OA
    {
        public int MinDeletion(string str)
        {
            int rhs = 0;int lhs = 0;
            foreach (var c in str) if (c == 'A') rhs++;
            int MinCost = rhs;
            foreach(var c in str)
            {
                if (c == 'A') rhs--;
                else lhs++;
                MinCost = Math.Min(MinCost, lhs + rhs);
            }
            return MinCost;
        }
    }
}
