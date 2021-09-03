using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class BTAverageOfLevels
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> lst = new List<double>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root == null) return lst;
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                int n = queue.Count;
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    TreeNode node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                lst.Add(sum / n);
            }
            return lst;
        }
    }
}
