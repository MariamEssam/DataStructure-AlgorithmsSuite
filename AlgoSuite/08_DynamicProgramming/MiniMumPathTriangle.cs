using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/triangle/
    /// <ID>034</ID>
    /// </summary>
    class MiniMumPathTriangle
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int min=triangle[0][0];
            for(int i=1;i<triangle.Count;i++)
            {
                min = int.MaxValue;
                for(int j=0;j<triangle[i].Count;j++)
                {
                    if(j==0)
                    {
                        triangle[i][j] += triangle[i-1][0];
                    } 
                    else if(j==triangle[i].Count-1)
                    {
                        triangle[i][j] += triangle[i - 1][triangle[i].Count - 2];
                    }
                    else
                    {
                        triangle[i][j] += Math.Min(triangle[i - 1][j - 1], triangle[i - 1][j]);
                    }
                    min = Math.Min(triangle[i][j], min);
                }
            }
            return min;
        }
    }
}
