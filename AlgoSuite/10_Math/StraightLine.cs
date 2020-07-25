using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-it-is-a-straight-line/
    /// <ID>065</ID>
    /// </summary>
    class StraightLine
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length == 1)
                return false;
            bool isvertical = coordinates[1][0]-coordinates[0][0]==0?true:false;
            double slope = 0; 
            if (!isvertical)
                slope= (double)(coordinates[1][1] - coordinates[0][1]) / (double)(coordinates[1][0] - coordinates[0][0]);
            for(int i=2;i<coordinates.Length;i++)
            {
                if(!isvertical)
                {
                    if ((coordinates[i - 1][0] - coordinates[i][0]) == 0) return false;
                    double l_slope = (double)(coordinates[i-1][1] - coordinates[i][1]) / (double)(coordinates[i-1][0] - coordinates[i][0]);

                    if (slope != l_slope)
                        return false;
                }
                else
                {
                    if ((coordinates[i - 1][0] - coordinates[i][0]) != 0)
                        return false;
                }
            }

            return true;
        }
    }
}
