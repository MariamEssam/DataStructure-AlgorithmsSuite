using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/sliding-window-maximum/
    /// <ID>1239</ID>
    /// </summary>
    class SlidingWindowMaximum
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (k > nums.Length)
                return null;
            int[] res = new int[nums.Length - k + 1];
            CompareInt cmp = new CompareInt();
            MaxHeap<int> maxheap = new MaxHeap<int>(cmp);
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i=0;i<k;i++)
            {
                maxheap.add(nums[i]);
                if (!dic.ContainsKey(nums[i])) dic.Add(nums[i], 0);
                dic[nums[i]]++;
            }
            res[0] = maxheap.Peek();
            for(int i=k;i<nums.Length;i++)
            {
                dic[nums[i - k]]--;
                if (dic[nums[i - k]] == 0) dic.Remove(nums[i - k]);
                maxheap.add(nums[i]);
                if (!dic.ContainsKey(nums[i])) dic.Add(nums[i], 0);
                dic[nums[i]]++;
                while (!dic.ContainsKey(maxheap.Peek()))
                    maxheap.Poll();
                res[i - k + 1] = maxheap.Peek();
            }
            return res;
        }
    }
}
