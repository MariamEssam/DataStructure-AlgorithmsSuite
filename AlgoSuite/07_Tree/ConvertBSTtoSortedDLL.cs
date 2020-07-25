using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/convert-binary-search-tree-to-sorted-doubly-linked-list/
    /// <ID>050</ID>
    /// </summary>
    class ConvertBSTtoSortedDLL
    {
        Node first = null;
        Node last = null;
        //Definition for a Node.
        public class Node
        {
            public int val;
            public Node left;
            public Node right;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
                left = null;
                right = null;
            }

            public Node(int _val, Node _left, Node _right)
            {
                val = _val;
                left = _left;
                right = _right;
            }
        }
        void helper(Node node)
        {
            if (node == null) return;
            helper(node.left);
            if(first==null)
            {
                first = node;
            }
            else
            {
                last.right = node;
                node.left = last;
            }
            last = node;
            helper(node.right);
        }
        public Node TreeToDoublyList(Node root)
        {
            if (root == null) return null;
            helper(root);
            first.left = last;
            last.right = first;
            return first;
        }
    }
}
