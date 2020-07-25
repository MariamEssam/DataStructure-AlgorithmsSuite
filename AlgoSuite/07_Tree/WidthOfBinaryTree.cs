using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-width-of-binary-tree/
    /// <ID>085</ID>
    /// </summary>
    class WidthOfBinaryTreeC
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            int MaxWidth = int.MinValue;

            Queue<KeyValuePair<int, TreeNode>> queue = new Queue<KeyValuePair<int, TreeNode>>();
            queue.Enqueue(new KeyValuePair<int, TreeNode>(0, root));
            while (queue.Count != 0)
            {
                KeyValuePair<int, TreeNode> left = new KeyValuePair<int, TreeNode>();
                KeyValuePair<int, TreeNode> right = new KeyValuePair<int, TreeNode>();
                left = queue.Peek();
                int size = queue.Count;
                while (size != 0)
                {
                    var item = queue.Dequeue();
                    right = item;
                    if (item.Value.left != null)
                        queue.Enqueue(new KeyValuePair<int, TreeNode>(item.Key * 2 + 1, item.Value.left));
                    if (item.Value.right != null)
                        queue.Enqueue(new KeyValuePair<int, TreeNode>(item.Key * 2 + 2, item.Value.right));
                    size--;
                }
                //if (left.Value!=null&&right.Value!=null)
                MaxWidth = Math.Max(MaxWidth, right.Key - left.Key + 1);
            }
            return MaxWidth;
        }
    }
}
