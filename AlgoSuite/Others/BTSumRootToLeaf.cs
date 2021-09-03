using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class BTSumRootToLeaf
    {
        int Sum = 0;
        void FindSum(TreeNode node, StringBuilder build)
        {
            if (node == null) return;
            build.Append(node.val);
            if (node.left == null && node.right == null)
                Sum += Convert.ToInt32(build.ToString(), 2);
            if (node.left != null)
                FindSum(node.left, build);
            if (node.right != null)
                FindSum(node.right, build);
            build = build.Remove(build.Length - 1, 1);
        }
        public int SumRootToLeaf(TreeNode root)
        {
            FindSum(root, new StringBuilder());
            return Sum;
        }
    }
}
