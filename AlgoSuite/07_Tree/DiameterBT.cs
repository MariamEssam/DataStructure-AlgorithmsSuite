using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/diameter-of-binary-tree/
    /// <ID>028</ID>
    /// </summary>
    class DiameterBT
    {
        int maxsum = 0;
        int getLevel(TreeNode node)
        {
            if (node == null) return 0;

            int l = getLevel(node.left);
            int r = getLevel(node.right);
            maxsum = Math.Max((l + r), maxsum);
            return Math.Max(l, r) + 1;
        }
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;
            getLevel(root);
            return maxsum;
        }
    }
}
