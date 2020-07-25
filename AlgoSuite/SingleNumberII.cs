using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SingleNumberII
    {
        public int SingleNumber(int[] nums)
        {
            int SINGLE = 3;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                    if (dic[nums[i]] == SINGLE)
                        dic.Remove(nums[i]);
                }
                else
                    dic.Add(nums[i], 1);
            }
            return dic.ElementAt(0).Key;
        }
    }
}
