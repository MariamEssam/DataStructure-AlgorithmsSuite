using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class BinaryTreeInorderTraversal
    {
        IList<int> values = new List<int>();
        void AddInorderValues(TreeNode node)
        {
            if (node == null)
                return;
            AddInorderValues(node.left);
            values.Add(node.val);
            AddInorderValues(node.right);
        }
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
                return values;
            AddInorderValues(root);
            return values;
        }
    }
}
