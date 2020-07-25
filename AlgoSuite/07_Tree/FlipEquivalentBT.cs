using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/flip-equivalent-binary-trees/
    /// <ID>42</ID>
    /// </summary>
    class FlipEquivalentBT
    {
        bool helper(TreeNode node1,TreeNode node2)
        {
            if (node1 == null && node2 == null)
                return true;
            if (node1 == null || node2 == null)
                return false;
            if (node1.val != node2.val)
                return false;
            bool flipped_case1 = true;
            flipped_case1 &= helper(node1.left, node2.left);
            flipped_case1 &= helper(node1.right, node2.right);
            bool flipped_case2 = true;
            flipped_case2 &= helper(node1.left, node2.right);
            flipped_case2 &= helper(node1.right, node2.left);
            return flipped_case1 | flipped_case2;

        }
        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            return helper(root1, root2);
        }
    }
}
