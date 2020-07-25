using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/jump-game/
    /// <ID>044</ID>
    /// </summary>
    class JumpGame
    {
        bool helper_dp_tp(int[] jump_index,int[] nums,int index)
        {
            if (jump_index[index] != 0)
                return jump_index[index] == 1 ? true : false;
            int val = Math.Min(nums[index],nums.Length);
            if (val + index >= nums.Length - 1)
                return true;
           
          while(val!=0)
            {
                if (helper_dp_tp(jump_index, nums, index + val))
                {
                    jump_index[index] = 1;
                    return true;
                }
                val--;
            }
            jump_index[index] = -1;
            return false;
        }
        public bool CanJump_dp_tp(int[] nums)
        {
            int[] jump_index = new int[nums.Length];
            jump_index[nums.Length - 1] = 1;
            return helper_dp_tp(jump_index, nums, 0);
        }
        public bool CanJump_dp_bt(int[] nums)
        {
            int[] memo = new int[nums.Length];
            memo[nums.Length - 1] = 1;
            for(int i=nums.Length - 2;i>=0;i--)
            {
                int max = Math.Min(nums.Length - 1, i + nums[i]);
                for (int j = i + 1; j <= max; j++)
                {
                    if (memo[j] == 1) { memo[i] = 1; break; }
                }
            }
            return memo[0] == 1 ? true : false;
        }
        public bool CanJump(int[] nums)
        {
            int lastPos = nums.Length - 1;
            for(int i=nums.Length-2;i>=0;i--)
            {
                if(i+nums[i]>=lastPos)
                {
                    lastPos = i;
                }
            }
            return lastPos == 0 ? true : false;
        }

        }
}
