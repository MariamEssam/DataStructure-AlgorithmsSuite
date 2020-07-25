using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class BinaryTreeLevelOrderTraversalII
    {
        IList<IList<int>> levels = new List<IList<int>>();
        private void helper(TreeNode node,int lvl)
        {
            if (node == null)
                return;
            if (levels.Count < lvl + 1)
                levels.Add(new List<int>());
            levels[lvl].Add(node.val);
            helper(node.left,lvl+1);
            helper(node.right,lvl+1);

        }

        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            helper(root, 0);
            ((List<IList<int>>)levels).Reverse();
            return levels;
        }
    }
}
