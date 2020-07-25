using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class Cousins
    {
        int parent_x = -1;
        int parent_y = -1;
        int depth_x = -1;
        int depth_y = -1;
        void findElement(TreeNode node,int parent,int depth,int x,int y)
        {
            if (node == null || (parent_x == -1 && parent_y == -1))
                return;
            if(node.val==x)
            {
                parent_x = parent;
                depth_x = depth + 1;
            }
            if (node.val == y)
            {
                parent_y = parent;
                depth_y = depth + 1;
            }
            findElement(node.left, node.val, depth + 1, x, y);
            findElement(node.right, node.val, depth + 1, x, y);

        }
        public bool IsCousins(TreeNode root, int x, int y)
        {
            if (root == null)
                return false;
            findElement(root.left, root.val, 0, x, y);
            findElement(root.right, root.val, 0, x, y);
            return parent_x != parent_y && depth_x == depth_y ? true : false;
        }
    }
}
