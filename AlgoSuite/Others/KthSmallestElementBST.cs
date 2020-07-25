using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class KthSmallestElementBST
    {
        int k_res = 0;
        int node_val = 0;
        void helper(TreeNode node,int k)
        {
            if (node == null)
                return;
            helper(node.left, k);
            k_res++;
            if (k_res == k) node_val = node.val;

            if (k_res >= k) return;
            
            helper(node.right, k);
        }
        public int KthSmallest(TreeNode root, int k)
        {
            helper(root, k);
            return node_val;
        }
    }
}
