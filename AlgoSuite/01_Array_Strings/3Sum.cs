using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/3sum/
    /// <ID>1015</ID>
    /// </summary>
    class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> results = new List<IList<int>>();
            Array.Sort(nums);
            int low = 0, high = 0;
            for (int i=0;i<nums.Length;i++)
            {
                if(i==0||nums[i]!=nums[i-1])
                {
                    low = i + 1;
                    high = nums.Length - 1;
                    int sum = -nums[i];
                    while(low<high)
                    {
                        int l_sum = nums[low] + nums[high];
                        if (sum==l_sum)
                        {
                            results.Add(new List<int>() { nums[i], nums[low], nums[high] });
                            while (low + 1 < nums.Length && nums[low] == nums[low + 1]) low++;
                            while (high - 1 >= 0 && nums[high] == nums[high - 1]) high--;
                            low++;
                            high--;
                        }
                        else if(l_sum<sum)
                        {
                            low++;
                        }
                        else
                        {
                            high--;
                        }
                    }


                }
            }
            return results;
        }
    }
}
