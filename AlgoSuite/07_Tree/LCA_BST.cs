using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LCA_BST
    {
       
        TreeNode CommonAnsector = null;
        uint SeachLCA(TreeNode node,TreeNode p,TreeNode q)
        {
            if (node == null||CommonAnsector!=null) return 0;
            uint isfound = 0;
            if (node.val == p.val) isfound = isfound|(1<<1);
            if (node.val == q.val) isfound = isfound | 1;
            if(isfound<3)
            {
                if (node.val > p.val||node.val>q.val) isfound |=  SeachLCA(node.left, p, q);
                if (node.val < p.val||node.val<q.val) isfound |= SeachLCA(node.right, p, q);
            }

            if (isfound==3&&CommonAnsector==null)
            {
                CommonAnsector = node;
                
            }
            return isfound;
        }
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            SeachLCA(root, p, q);
            return CommonAnsector;
        }
    }
}
