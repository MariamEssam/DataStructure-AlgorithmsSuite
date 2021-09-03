using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class SumRootLeafNumbers
    {
        int sum = 0;
        void getSum(int currentval, TreeNode node)
        {
            if (node == null) return;
            currentval = currentval * 10 + node.val;
            if (node.left == null && node.right == null)
            {
                sum += currentval;
            }
            else
            {
                getSum(currentval, node.left);
                getSum(currentval, node.right);
            }
        }
        public int SumNumbers(TreeNode root)
        {
            getSum(0, root);
            return sum;
        }
    }
}
