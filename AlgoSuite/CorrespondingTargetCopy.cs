using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// <ID>2379</ID>
    /// https://leetcode.com/problems/find-a-corresponding-node-of-a-binary-tree-in-a-clone-of-that-tree/
    /// </summary>
    class CorrespondingTargetCopy
    {
        TreeNode Node;
        void findTarget(TreeNode orginal,TreeNode Cloned, TreeNode target)
        {
            if (orginal == null || Cloned == null||target==null)
                return;

            if(orginal==target)
            {
                Node = Cloned;
            }
            else
            {
                findTarget(orginal.left, Cloned.left, target);
                findTarget(orginal.right, Cloned.right, target);
            }
        }
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            findTarget(original, cloned, target);
            return Node;
        }
    }
}
