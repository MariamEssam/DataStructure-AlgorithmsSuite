using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/531/week-4/3313/
    /// <ID>054</ID>
    /// </summary>
    public class FirstUnique
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        List<int> lst = new List<int>();
        public FirstUnique(int[] nums)
        {
            for(int i=0;i<nums.Length;i++)
            {
                Add(nums[i]);
            }
        }

        public int ShowFirstUnique()
        {
            for(int i=0;i<lst.Count;i++)
            {
                if (dic[lst[i]] == 1) return lst[i];
            }
            return -1;
        }

        public void Add(int value)
        {
            if (!dic.ContainsKey(value))
            {
                dic.Add(value, 1);
                lst.Add(value);
            }
            else
                dic[value]++;
        }
    }
}
