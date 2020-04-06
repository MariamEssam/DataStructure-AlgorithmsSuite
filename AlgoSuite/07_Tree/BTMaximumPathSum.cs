using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class BTMaximumPathSum
    {
        int maxSum = int.MinValue;
        int MaxSumHelper(TreeNode node)
        {
            if (node == null) return 0;
            int L = Math.Max(MaxSumHelper(node.left),0);
            int R = Math.Max(MaxSumHelper(node.right),0);
            
            maxSum = Math.Max(L+R+node.val,maxSum);

            return node.val+Math.Max(L,R);

        }
        public int MaxPathSum(TreeNode root)
        {
            if (root == null) return 0;
            MaxSumHelper(root);
            return maxSum;
        }
    }
}
