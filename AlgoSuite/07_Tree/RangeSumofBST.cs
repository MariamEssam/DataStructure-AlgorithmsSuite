using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/range-sum-of-bst/
    /// <ID>076</ID>
    /// </summary>
    class RangeSumofBST
    {
        
        int findSum(TreeNode node,int L,int R)
        {
            int sum = 0;
            if (node == null)
                return 0;

            if (node.val>=L&&node.val<=R)
            {
                sum += node.val;
            }
           if(node.val>L)
            {
                findSum(node.left, L, R);
            }
            if(node.val<R)
            {
                findSum(node.right, L, R);
            }
            return sum;
        }
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            
            int s = findSum(root,L,R);
            return s;
        }
    }
}
