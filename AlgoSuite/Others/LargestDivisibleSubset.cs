using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LargestDivisibleSubsetC
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            IList<int> res = new List<int>();
            int n = nums.Length;
            if (n == 0) return res;
            Array.Sort(nums);
            List<List<int>> EDS = new List<List<int>>();
            foreach (int num in nums)
                EDS.Add(new List<int>());
            for(int i=0;i<n;i++)
            {
                List<int> maxsubset = new List<int>();
                for(int k=0;k<n;k++)
                {
                    if (nums[i] % nums[k] == 0 && maxsubset.Count < EDS[k].Count)
                        maxsubset = EDS[k];
                }
                EDS[i].AddRange(maxsubset);
                EDS[i].Add(nums[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (res.Count < EDS[i].Count)
                    res = EDS[i];
            }
            return res;

        }

    }
}
