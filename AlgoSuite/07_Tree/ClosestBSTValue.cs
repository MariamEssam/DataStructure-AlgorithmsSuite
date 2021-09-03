using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ClosestBSTValue
    {
        int FindCloset(TreeNode node, double target)
        {
            if (node.left == null && node.right == null)
                return node.val;
            int MinValue = 0;
            if (node.left == null)
                MinValue = FindCloset(node.right, target);
            else if (node.right == null)
                MinValue = FindCloset(node.left, target);
            else
            {
                int left = FindCloset(node.left, target);
                int right = FindCloset(node.right, target);
                if (Math.Abs(left - target) <
                    Math.Abs(right - target))
                    MinValue = left;
                else
                    MinValue = right;
            }
            if (Math.Abs(MinValue - target) < Math.Abs(node.val - target))
                return MinValue;
            else
                return node.val;
        }
        public int ClosestValue(TreeNode root, double target)
        {
            if (root == null)
                return 0;
            return FindCloset(root, target);
        }
    }
}
