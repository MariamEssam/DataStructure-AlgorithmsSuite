using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/island-perimeter/
    /// <ID>086</ID>
    /// </summary>
    class IslandPerimeterC
    {
        public int IslandPerimeter(int[][] grid)
        {
            int peirmeter = 0;
            for(int i=0;i<grid.Length;i++)
            {
                for(int j=0;j<grid[0].Length;j++)
                {
                    if(grid[i][j]==1)
                    {
                        if (i - 1 < 0||grid[i-1][j]==0) peirmeter++;
                        if (i + 1 >= grid.Length || grid[i + 1][j] == 0) peirmeter++;
                        if (j - 1 < 0 || grid[i][j-1] == 0) peirmeter++;
                        if (j + 1 >= grid[0].Length || grid[i][j+1] == 0) peirmeter++;

                    }
                }
            }
            return peirmeter;
        }
    }
}
