using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/k-closest-points-to-origin/
    /// <ID>1973</ID>
    /// </summary>
    class KClosestPoint
    {
        public int[][] KClosest(int[][] points, int K)
        {
            List<int[]> Closetlst = new List<int[]>();
            long[][] arr = new long[points.Length][];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = new long[2];
                arr[i][0] = Math.Abs(points[i][0])* Math.Abs(points[i][0]) + Math.Abs(points[i][1])* Math.Abs(points[i][1]);
                arr[i][1] = i;
            }
            var sorted = arr.OrderBy(x => x[0]).ToArray();
            for(int i=0;i<K;i++) 
            {
                Closetlst.Add(points[sorted[i][1]]);
            }
            return  Closetlst.ToArray();
        }
    }
}
