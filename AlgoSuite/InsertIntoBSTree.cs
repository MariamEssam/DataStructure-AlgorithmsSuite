using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/insert-into-a-binary-search-tree/
    /// <ID>1701</ID>
    /// </summary>
    class InsertIntoBSTree
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null) return new TreeNode(val);
            TreeNode node = root;
            bool isfound = false;
            while(!isfound)
            {
                if (node.val > val)
                {
                    if (node.left == null) { node.left = new TreeNode(val); isfound = true; }
                    else node = node.left;
                }
                else
                if (node.right == null) { node.right = new TreeNode(val); isfound = true; }
                else node = node.right;
            }
            return root;
        }
    }
}
