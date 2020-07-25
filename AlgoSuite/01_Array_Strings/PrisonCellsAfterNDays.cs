using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/prison-cells-after-n-days/
    /// <ID>083</ID>
    /// </summary>
    class PrisonCellsAfterNDays
    {
        void NextState(int[] cells)
        {
            int prev = cells[0];
            cells[0] = 0;
            for(int i=1;i<cells.Length-1;i++)
            {
                int temp = cells[i];
                cells[i] = prev == cells[i + 1]?1:0;
                prev = temp;
            }
            cells[cells.Length - 1] = 0;
        }
        int ConvertToInt(int[] cells)
        {
            int val = cells[0];
            for(int i=1;i<cells.Length;i++)
            {
                val = val << 1;
                val = val | cells[i];
            }
            return val;
        }
        void UpdateCells(int state,int[] cells)
        {
            for(int i= cells.Length-1; i>=0;i--)
            {
                int val = state & 1;
                state = state >> 1;
                cells[i] = val;
            }
        }
        public int[] PrisonAfterNDays(int[] cells, int N)
        {
            List<int> states = new List<int>();
            Dictionary<int,int> dic = new Dictionary<int, int>();
            int i = 0;
            while(i<N)
            {
                int state = ConvertToInt(cells);
                if(dic.ContainsKey(state))
                {
                    int startindex = dic[state];
                    int nextstate = startindex + (N - i) % (cells.Length - startindex);
                    UpdateCells(states[nextstate], cells);
                    return cells; 
                }
                else
                {
                    dic.Add(state,i);
                    states.Add(state);
                    NextState(cells);
                }
                i++;
            }
            return cells;
        }
    }
}
