using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/347457
    /// https://leetcode.com/discuss/interview-question/356150
    /// <ID>5011</ID>
    /// </summary>
    class TreasureIsland
    {
        #region DFS
        int min = int.MaxValue;
        void DFS(char[][] grid, int r, int c, int StepsCount)
        {
            if (r >= 0 && r < grid.Length && c >= 0 && c < grid[0].Length && grid[r][c] != 'V' && grid[r][c] != 'D')
            {
                if (grid[r][c] == 'X')
                    min = Math.Min(min, StepsCount);
                else if (grid[r][c] == 'O' || grid[r][c] == 'S')
                {
                    char ch = grid[r][c];
                    grid[r][c] = 'V';
                    DFS(grid, r - 1, c, StepsCount + 1);
                    DFS(grid, r + 1, c, StepsCount + 1);
                    DFS(grid, r, c - 1, StepsCount + 1);
                    DFS(grid, r, c + 1, StepsCount + 1);
                    grid[r][c] = ch;
                }
            }
        }
        public int minSteps1(char[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[0].Length; j++)
                    if (grid[i][j] == 'S')
                        DFS(grid, i, j, 0);
            return min == int.MaxValue ? 0 : min;
        }
        #endregion
        public int minSteps(char[][] grid)
        {
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            queue.Enqueue(new Tuple<int, int>(0, 0));
            grid[0][0] = 'D';
            int steps = 0;
            int[] dir1 = new int[] { -1, 0, 1, 0 };
            int[] dir2 = new int[] {  0, 1, 0,-1 };

            while (queue.Count!=0)
            {
                steps++;

                for(int sz=queue.Count - 1;sz>=0;sz--)
                {
                    Tuple<int, int> tp = queue.Dequeue();
                    for (int i = 0; i < 4; i++)
                    {
                        int r = tp.Item1 + dir1[i];
                        int c = tp.Item2 + dir2[i];
                        if (r >= 0 && r < grid.Length && c >= 0 && c < grid[0].Length && grid[r][c] != 'D')
                        {
                            if (grid[r][c] == 'X')
                                return steps;
                            queue.Enqueue(new Tuple<int, int>(r, c));
                        }
                    }
                }
            }
            return -1;
        }
    }
}
