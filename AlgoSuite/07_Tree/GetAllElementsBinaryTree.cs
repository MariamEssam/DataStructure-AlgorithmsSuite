using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class GetAllElementsBinaryTree
    {
        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            IList<int> result = new List<int>();
            Stack<TreeNode> stk1 = new Stack<TreeNode>();
            TreeNode node1 = root1;
            Stack<TreeNode> stk2 = new Stack<TreeNode>();
            TreeNode node2 = root2;
           
            while (node1!=null||node2!=null||stk1.Count != 0 || stk2.Count != 0)
            {
                while (node1 != null)
                {
                    stk1.Push(node1);
                    node1 = node1.left;
                }
                while (node2 != null)
                {
                    stk2.Push(node2);
                    node2 = node2.left;
                }

                if (stk2.Count == 0 || (stk1.Count != 0 && stk1.Peek().val < stk2.Peek().val))
                {
                    TreeNode curr = stk1.Pop();
                    result.Add(curr.val);
                    node1 = curr.right;

                }
                else
                {
                    TreeNode curr = stk2.Pop();
                    result.Add(curr.val);
                    node2 = curr.right;
                }
            }
            return result;
        }
    }
}
