using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/373202
    /// <ID>5007</ID>
    /// </summary>
    class OptimalUtilization
    {
        public List<List<int>> aircraftUtilization(int maxTravelDist, int[][] forwardRouteList, int[][] returnRouteList)
        {
            List<List<int>> res = new List<List<int>>();
            Dictionary<int, List<List<int>>> dic = new Dictionary<int, List<List<int>>>(); 
            int len1 = forwardRouteList.Length, len2 = returnRouteList.Length;
            if (len1 == 0 || len2 == 0) return res;
            forwardRouteList = forwardRouteList.OrderBy(x => x[1]).ToArray();
            returnRouteList = returnRouteList.OrderBy(x => x[1]).ToArray();
            int left = 0, right = len2 - 1, max=-1;
            while(left<len1&&right>=0)
            {
                int sum = forwardRouteList[left][1] + returnRouteList[right][1];
                if (sum > maxTravelDist) { right--;continue; }
                if(sum>=max)
                {
                    int r = right;
                    max = sum;
                    while(r>=0&&returnRouteList[right][1]== returnRouteList[r][1])
                    {
                        List<int> lst = new List<int>();
                        lst.Add(forwardRouteList[left][0]);
                        lst.Add(returnRouteList[right][0]);
                        r--;
                        if (!dic.ContainsKey(sum)) dic.Add(sum, new List<List<int>>());
                        dic[sum].Add(lst);
                    }
                }
                left++;
            }
            return dic.ContainsKey(max)?dic[max]:new List<List<int>>();
        }
    }
}
