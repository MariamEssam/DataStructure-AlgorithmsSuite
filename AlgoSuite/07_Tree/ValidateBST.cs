using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    class ValidateBST
    {
        //       *
        //* Definition for a binary tree node.

        bool ValidatTree(TreeNode Node, int? lowerbound, int? upperbound)
        {
            bool isValid = true;
            if (Node != null)
            {
                if ((lowerbound == null || Node.val > lowerbound) && (upperbound == null || Node.val < upperbound))
                {

                    isValid = isValid && ValidatTree(Node.left, lowerbound, Node.val);
                    isValid = isValid && ValidatTree(Node.right, Node.val, upperbound);

                }
                else
                    return false;
            }
            return isValid;
        }
        public bool IsValidBST(TreeNode root)
        {
            return ValidatTree(root, null, null);
        }
    }
    }
