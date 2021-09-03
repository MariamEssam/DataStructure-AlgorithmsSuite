using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class FindKthLargestC
    {
        void Swap(int[] nums,int first,int second)
        {
            int temp = nums[first];
            nums[first] = nums[second];
            nums[second] = temp;
        }
        int Partion(int[] nums,int low,int high)
        {
            int ptr1 = low, small_ptr = low;
            for(int i=ptr1;i<high - 1;i++)
            {
                if(nums[i]<nums[high-1])
                {
                    Swap(nums, small_ptr, i);
                    small_ptr++;
                }
            }
            Swap(nums, small_ptr, high - 1);
            return small_ptr;
        }
        int QuickSelect(int[] nums,int low,int high,int k)
        {
            if(low<=high)
            {
                Random ran = new Random();
                int pivot = ran.Next(low, high);
                Swap(nums, pivot, high - 1);
                int index = Partion(nums, low, high);
                if(index==k)
                {
                    return nums[index];
                }
                else if(index>k)
                {
                    return QuickSelect(nums, low, index, k);
                }
                else
                {
                    return QuickSelect(nums, index + 1, high, k - index);
                }
            }
            return -1;
        }
        public int FindKthLargest(int[] nums, int k)
        {
            int index = nums.Length - k;
            return QuickSelect(nums, 0, nums.Length, index);

        }
    }
}
