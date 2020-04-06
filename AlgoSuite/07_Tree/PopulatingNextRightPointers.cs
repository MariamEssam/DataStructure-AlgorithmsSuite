using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite.Tree
{

    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    class PopulatingNextRightPointers
    {
        Node NextNode;
        int Findheight(Node node,int h)
        {
            if (node == null)
                return h;
            return Math.Max(Findheight(node.left, h + 1), Findheight(node.right, h + 1));
        }
        void connectlevel(Node node,int level)
        {
            if(level==1)
            {
                if(NextNode!=null)
                NextNode.next = node;
                NextNode = node;
                return;
            }
            else
            {
                connectlevel(node.left, level - 1);
                connectlevel(node.right, level - 1);
            }
        }
        public Node Connect(Node root)
        {
            int height = Findheight(root,0);
            for(int i=2;i<=height;i++)
            {
                NextNode = null;
                connectlevel(root, i);
            }
            return root;
        }
    }
}
