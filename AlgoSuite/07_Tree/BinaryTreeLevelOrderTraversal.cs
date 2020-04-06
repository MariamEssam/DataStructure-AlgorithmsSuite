using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class BinaryTreeLevelOrderTraversal
    {
        IList<IList<int>> finding = new List<IList<int>>();
        void AddNode(TreeNode node,int level)
        {
            if (node == null)
                return;
            if (finding.Count < (level + 1))
                finding.Add(new List<int>());
            finding[level].Add(node.val);
            AddNode(node.left, level + 1);
            AddNode(node.right, level + 1);

        }
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            AddNode(root, 0);
            return finding;
        }
    }
}
