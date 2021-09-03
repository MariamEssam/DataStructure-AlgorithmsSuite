using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MoveZeros
    {
        /// <summary>
        /// <ID>1283</ID>
        /// <Link>https://leetcode.com/problems/move-zeroes/</Link>
        /// </summary>
        public void MoveZeroes(int[] nums)
        {
            for(int lastNonZeroFound=0,curr=0;curr<nums.Length;curr++)
            {
                if (nums[curr] != 0)
                    swap(nums, curr, lastNonZeroFound++);
            }
        }
        private void swap(int[] arr,int index1,int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
        }
    }
