using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/364618/Microsoft-or-OA-2019-or-Min-Steps-to-Make-Piles-Equal-Height/329604
    /// </summary>
    class MinStepsEqualPiles
    {
        public int minSteps(int[] piles)
        {
            
            int distinct = 0, result = 0;
            Array.Sort(piles);
            for(int i=1;i<piles.Length;i++)
            {
                if (piles[i - 1] != piles[i]) distinct++;
                result += distinct;
            }
            return result;
        }
    }
}
