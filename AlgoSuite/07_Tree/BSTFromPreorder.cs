using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/
    /// <ID>037</ID>
    /// </summary>
    class BSTFromPreorder
    {
        public TreeNode BstFromPreorder(int[] preorder)
        {
            if (preorder.Length == 0) return null;
            TreeNode root = new TreeNode(preorder[0]);
            for (int i = 1; i < preorder.Length; i++)
            {
                TreeNode node = new TreeNode(preorder[i]);
                TreeNode curr = root;
                while (true)
                {
                    if (curr.val <= preorder[i])
                    {
                        if (curr.left == null) { curr.left = node; break; }
                        else curr = curr.left;
                    }
                    else
                    {
                        if (curr.right == null) { curr.right = node; break; }
                        else curr = curr.right;
                    }
                }
            }
            return root;
        }
    }
}
