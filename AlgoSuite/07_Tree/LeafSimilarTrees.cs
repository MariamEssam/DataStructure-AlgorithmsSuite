using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LeafSimilarTrees
    {
        void ComposeLeafQueue(Queue<int> queue,TreeNode node)
        {
            if (node == null)
                return;
            if (node.left == null && node.right == null)
            {
                queue.Enqueue(node.val);
                return;
            }
            ComposeLeafQueue(queue, node.left);
            ComposeLeafQueue(queue, node.right);
            
        }
        bool ValidateLeafQueue(Queue<int> queue, TreeNode node)
        {
            if (node == null)
                return true;
            if (node.left == null && node.right == null)
            {
                if (queue.Count == 0) return false;
                return queue.Dequeue() == node.val;
            }
            return ValidateLeafQueue(queue, node.left) && ValidateLeafQueue(queue, node.right);
        }
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            Queue<int> queue = new Queue<int>();
            ComposeLeafQueue(queue, root1);
            return ValidateLeafQueue(queue, root2);
        }
    }
}
