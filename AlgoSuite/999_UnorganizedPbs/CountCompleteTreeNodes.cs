using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/count-complete-tree-nodes/
    /// </summary>
    class CountCompleteTreeNodes
    {
       
        public int CountNodes(TreeNode root)
        {
            if (root == null) return 0;
            return 1+CountNodes(root.left)+CountNodes(root.right);
        }

        int getdepth(TreeNode node)
        {
            int d = 0;
            while(node.left!=null)
            {
                node = node.left;
                d++;
            }
            return d;
        }
        bool exisit(int index,int d,TreeNode node)
        {
            int left = 0, right = (int)Math.Pow(2, d) - 1;
            while(left<=right)
            {
                int pivot = (left + right) / 2;
                if (index <= pivot)
                {
                    right = pivot;
                    node = node.left;
                }
                else
                {
                    left = pivot + 1;
                    node = node.right;
                }
                
            }
            return node != null;
        }
        public int CountNodes2(TreeNode root)
        {
            if (root == null) return 0;
            int d = getdepth(root);

            int left = 1, right = (int)Math.Pow(2, d) - 1;
            while(left<=right)
            {
                int pivot = (left + right) / 2;
                if(exisit(pivot,d,root))
                {
                    left = pivot + 1;
                }
                else
                {
                    right = pivot - 1;
                }
            }
            return (int)Math.Pow(2, d) - 1 + left;
        }
    }
}
