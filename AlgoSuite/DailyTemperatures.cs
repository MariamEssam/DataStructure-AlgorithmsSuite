using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/daily-temperatures/
    /// <ID>1739</ID>
    /// </summary>
    class DailyTemperaturesC
    {
        public int[] DailyTemperatures(int[] T)
        {
            int[] ans = new int[T.Length];
            Stack<int> IndicesStk = new Stack<int>();
            for(int i=T.Length-1;i>=0;i--)
            {
                while (IndicesStk.Count > 0 && T[IndicesStk.Peek()] <= T[i]) IndicesStk.Pop();
                ans[i] = IndicesStk.Count > 0 ? IndicesStk.Peek() - i : 0;
                IndicesStk.Push(i);
            }
            return ans;
        }
        public int[] DailyTemperatures2(int[] T)
        {
            int START = 30, END = 100;
            int[] ans = new int[T.Length];
            int[] TemperatureIndices = new int[END - START + 1];
            for (int i = 0; i < TemperatureIndices.Length; i++)
                TemperatureIndices[i] = int.MaxValue;
            for(int i=T.Length-1;i>=0;i--)
            {
                int warmTempIndex = int.MaxValue;
                for(int index=T[i]+1;index<=END;index++)
                {
                    if (TemperatureIndices[index-START] < warmTempIndex) warmTempIndex = TemperatureIndices[index - START];
                }
                if (warmTempIndex < int.MaxValue)
                    ans[i] = warmTempIndex - i;
                TemperatureIndices[T[i]-START] = i;
            }
            return ans;
        }
    
    }
}
