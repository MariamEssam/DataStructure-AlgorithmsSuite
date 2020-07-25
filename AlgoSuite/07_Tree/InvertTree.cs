using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/invert-binary-tree/
    /// <ID>069</ID>
    /// </summary>
    class InvertTreeC
    {
        void helper(TreeNode node)
        {
            if (node==null||node.left == null && node.right == null)
                return;
            TreeNode temp = node.left;
            node.left = node.right;
            node.right = temp;
            helper(node.left);
            helper(node.right);
        }
        public TreeNode InvertTree(TreeNode root)
        {
            helper(root);
            return root;
        }
    }
}
