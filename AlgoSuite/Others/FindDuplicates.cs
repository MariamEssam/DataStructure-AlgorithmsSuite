using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class FindDuplicatesC
    {
        public IList<int> FindDuplicates(int[] nums)
        {

            Array.Sort(nums);
            IList<int> result = new List<int>();
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i-1]==nums[i])
                    result.Add(nums[i]);
            }
            return result;
        }
        public IList<int> FindDuplicates2(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            IList<int> result = new List<int>();
            for(int i=0;i<nums.Length;i++)
            {
                if (set.Contains(nums[i]))
                    result.Add(nums[i]);
                else
                    set.Add(nums[i]);
            }
            return result;
        }
    }
}
