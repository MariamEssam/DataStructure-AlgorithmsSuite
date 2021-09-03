using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    public class BSTIterator
    {
        Stack<TreeNode> node_stk;
        public BSTIterator(TreeNode root)
        {
            node_stk = new Stack<TreeNode>();
            PushNode(root);
        }

        /** @return the next smallest number */
        public int Next()
        {
            TreeNode node = node_stk.Pop();
            PushNode(node.right);
            return node.val;

        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            if (node_stk.Count != 0)
                return true;
            return false;
        }
        private void PushNode(TreeNode node)
        {
            while (node != null)
            {
                node_stk.Push(node);
                node = node.left;
            }
        }
    }

}
