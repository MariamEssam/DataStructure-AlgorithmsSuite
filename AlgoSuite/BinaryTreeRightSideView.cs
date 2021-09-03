using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-right-side-view/
    /// <ID>1199</ID>
    /// </summary>
    class BinaryTreeRightSideView
    {
        void helper(TreeNode node,IList<int> resList,int level)
        {
            if(node!=null)
            {
                if(resList.Count==level)
                   resList.Add(node.val);
                helper(node.right, resList, level + 1);
                helper(node.left, resList, level + 1);
            }
        }
        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> resList = new List<int>();
            helper(root, resList,0);
            return resList;
        }
    }
}
