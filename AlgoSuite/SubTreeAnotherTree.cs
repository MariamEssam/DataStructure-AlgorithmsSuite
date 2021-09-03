using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/subtree-of-another-tree/
    /// <ID>1572</ID>
    /// </summary>
    class SubTreeAnotherTree
    {
        bool IsSame(TreeNode first, TreeNode second)
        {
            if (first == null && second == null)
                return true;
            if (first == null || second == null)
                return false;
            if (first.val != second.val)
                return false;
            return IsSame(first.left, second.left) && IsSame(first.right, second.right);
        }

        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null)
                return false;
            if (IsSame(s, t)) return true;
            return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }
    }
}
