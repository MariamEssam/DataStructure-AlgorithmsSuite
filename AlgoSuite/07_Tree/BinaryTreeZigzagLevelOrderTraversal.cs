using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class BinaryTreeZigzagLevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> findinglist = new List<IList<int>>();
            if (root == null)
                return findinglist;
            Stack<TreeNode> NodeStk = new Stack<TreeNode>();
            NodeStk.Push(root);
            int level = 0;
            while(NodeStk.Count>0)
            {
                if(level%2==0)
                {
                    List<int> list = new List<int>();
                    int sizestack = NodeStk.Count;
                    Stack<TreeNode> stktemp = new Stack<TreeNode>();
                    while(NodeStk.Count!=0)
                    {
                        TreeNode node=NodeStk.Pop();
                        list.Add(node.val);
                        if(node.left!=null)
                            stktemp.Push(node.left);
                        if (node.right != null)
                            stktemp.Push(node.right);
                        sizestack--;
                    }
                    NodeStk = stktemp;
                    findinglist.Add(list);
                }
                else
                {
                    List<int> list = new List<int>();
                    int sizestack = NodeStk.Count;
                    Stack<TreeNode> stktemp = new Stack<TreeNode>();
                    while (NodeStk.Count != 0)
                    {
                        TreeNode node = NodeStk.Pop();
                        list.Add(node.val);
                        if (node.right != null)
                            stktemp.Push(node.right);
                        if (node.left != null)
                            stktemp.Push(node.left);
                        sizestack--;
                    }
                    NodeStk = stktemp;
                    findinglist.Add(list);
                }
              
            }
            return findinglist;
        }
    }
}
