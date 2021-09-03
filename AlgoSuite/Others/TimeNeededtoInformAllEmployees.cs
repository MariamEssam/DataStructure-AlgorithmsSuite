using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class TimeNeededtoInformAllEmployees
    {
        int findtime(int headID, Dictionary<int, List<int>> dic, int[] informTime)
        {
            int max = 0;
            if (dic.ContainsKey(headID))
            {
                for (int i = 0; i < dic[headID].Count; i++)
                {
                    max = Math.Max(max, informTime[headID] + findtime(dic[headID][i], dic,informTime));

                }
            }
            return max;
        }       
        public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            for(int i=0;i<manager.Length;i++)
            {
                if (!dic.ContainsKey(manager[i])) dic.Add(manager[i], new List<int>() { i });
                else dic[manager[i]].Add(i);
            }
            return findtime(headID, dic, informTime);
        }
    }
}
