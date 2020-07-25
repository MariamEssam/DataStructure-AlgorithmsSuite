using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class NextPermutation
    {
        /// <summary>
        /// https://leetcode.com/problems/next-permutation/
        /// <ID>029</ID>
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public List<int> nextPermutation(List<int> nums)
        {
            if (nums.Count <= 1) return nums;
            int index = nums.Count - 2;
            while(index>=0&& nums[index]>=nums[index+1])
            {
                index--;
            }
            if(index>=0)
            {
                int ptr = index;
                while(ptr<nums.Count -1&&nums[index]<nums[ptr+1])
                {
                    ptr++;
                }
                swap(nums, index, ptr);
            }
            reverse(nums, index + 1);
            return nums;
        }
        void swap(List<int> A,int i,int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
        void reverse(List<int> A,int startindex)
        {
            int endindex = A.Count - 1;
            while(startindex<endindex)
            {
                swap(A, startindex, endindex);
                startindex++;
                endindex--;
            }
        }
        public string GetPermutation(int n, int k)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < n; i++)
                res.Add(i + 1);
            for(int i=0;i<k;i++)
            {
                res = nextPermutation(res);
            }
            return string.Join("",res);
        }
    }
}
