using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/missing-ranges/
    /// <ID>045</ID>
    /// </summary>
    class MissingRanges
    {
        public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            IList<string> result = new List<string>();
            if (nums.Length == 0)
            {
                result.Add(formRange(lower, upper));
                return result;
            }
            if (lower != nums[0])
                result.Add(formRange(lower, nums[0] - 1));

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1] && nums[i] < nums[i + 1] - 1)
                {
                    result.Add(formRange(nums[i] + 1, nums[i + 1] - 1));
                }
            }
            if (nums[nums.Length - 1] != upper)
            {
                result.Add(formRange(nums[nums.Length - 1] + 1, upper));
            }
            return result;
        }
        string formRange(int lower, int upper)
        {
            StringBuilder build = new StringBuilder();
            build.Append(lower);
            if (upper != lower)
                build.Append("->").Append(upper);
            return build.ToString();
        }
    }
}
