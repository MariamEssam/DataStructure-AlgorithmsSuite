using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-time-visiting-all-points/
    /// <ID>2266</ID>
    /// </summary>
    class MinTimeToVisitAllPointsC
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int total = 0;
            for(int i=1;i<points.Length;i++)
            {
                total+=Math.Max(Math.Abs(points[i][0] - points[i - 1][0]), Math.Abs(points[i][1] - points[i - 1][1]));
            }
            return total;
        }
    }
}
