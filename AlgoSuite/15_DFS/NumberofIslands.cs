using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class NumberofIslands
    {
        void ExposeIslands(char[][] grid, int i, int j)
        {
            if (i >= 0 && i < grid.Length && j >= 0 && j < grid[0].Length && grid[i][j] == '1')
            {
                grid[i][j] = '#';
                ExposeIslands(grid, i + 1, j);
                ExposeIslands(grid, i - 1, j);
                ExposeIslands(grid, i, j + 1);
                ExposeIslands(grid, i, j - 1);
            }
        }
        public int NumIslands(char[][] grid)
        {
            int Num = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        grid[i][j] = '#';
                        ExposeIslands(grid, i + 1, j);
                        ExposeIslands(grid, i - 1, j);
                        ExposeIslands(grid, i, j + 1);
                        ExposeIslands(grid, i, j - 1);
                        Num++;
                    }
                }
            }
            return Num;
        }
    }
}
