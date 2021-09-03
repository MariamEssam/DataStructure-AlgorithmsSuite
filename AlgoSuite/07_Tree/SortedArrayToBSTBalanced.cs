using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SortedArrayToBSTBalanced
    {
        TreeNode AddSlibbing(int[] nums,int low,int high)
        {
            if(low<=high)
            {
                int mid = (int)Math.Ceiling((low + high) / 2.0);
                TreeNode new_node = new TreeNode(nums[mid]);
                new_node.left=AddSlibbing(nums, low, mid - 1);
                new_node.right= AddSlibbing(nums, mid + 1,high);
                return new_node;
            }
            return null;
        }
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return AddSlibbing(nums,0,nums.Length-1);
        }
    }
}
