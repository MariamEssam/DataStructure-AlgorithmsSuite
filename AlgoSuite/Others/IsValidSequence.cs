using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-a-string-is-a-valid-sequence-from-root-to-leaves-path-in-a-binary-tree/
    /// <ID>056</ID>
    /// </summary>
    class IsValidSequenceC
    {
        bool helper(TreeNode node,int[] arr, int index)
        {
            if (index >= arr.Length||node==null) return false;
            if (node.val != arr[index]) return false;
            if (node.left == null && node.right == null && index == arr.Length - 1) return true;
             return helper(node.left, arr, index + 1) | helper(node.right, arr, index + 1);
            
        }
        public bool IsValidSequence(TreeNode root, int[] arr)
        {
            return helper(root,arr,0);
        }
    }
}
