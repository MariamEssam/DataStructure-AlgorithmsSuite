using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/411357/
    /// <ID>5017</ID>
    /// </summary>
    class ZombieInMatrix
    {
        public int minHours(int rows, int columns, int[][] grid)
        {
            Queue<int[]> queue = new Queue<int[]>();
            int cnt = 0, res = 0;
            int[][] dir = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };

            int target = rows * columns;
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<columns;j++)
                {
                    if (grid[i][j] == 1)
                    {
                        queue.Enqueue(new int[] { i, j });
                        cnt++;
                    }
                }
            }
            while(queue.Count!=0)
            {
                if (cnt == target)
                    return res;
                
                int size = queue.Count;
                for (int k = 0; k < size; k++)
                {
                    int[] item = queue.Dequeue();
                    foreach (int[] d in dir)
                    {
                        int r = d[0] + item[0];
                        int c = d[1] + item[1];
                        if (r >= 0 && r < rows && c >= 0 && c < columns && grid[r][c] == 0)
                        {
                            cnt++;
                            grid[r][c] = 1;
                            queue.Enqueue(new int[] { r, c });
                        }
                    }
                    
                }
                res++;

            }
            return -1;
        }
    }
}
