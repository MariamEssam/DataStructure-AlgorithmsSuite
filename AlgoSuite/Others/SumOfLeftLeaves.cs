using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SumOfLeftLeavesC
    {
        int FindSum(TreeNode node, bool isleft)
        {
            int sum = 0;
            if (node == null) return 0;
            if (node.left == null && node.right == null) return isleft ? node.val : 0;
            sum += FindSum(node.left, true);
            sum += FindSum(node.right, false);
            return sum;

        }
        public int SumOfLeftLeaves(TreeNode root)
        {
            return FindSum(root, false);
        }
    }
}
