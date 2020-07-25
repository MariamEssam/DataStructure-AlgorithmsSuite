using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list/
    /// <ID>087</ID>
    /// </summary>
    class FlattenMultilevelDoublyLinkedList
    {
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
        public Node Flatten(Node head)
        {
            if (head == null) return null;
            Node node = head;
            Stack<Node> node_stk = new Stack<Node>();
            while (node != null)
            {
                if (node.child != null)
                {
                    if (node.next != null)
                        node_stk.Push(node.next);
                    node.next = node.child;
                    node.child.prev = node;
                    node.child = null;
                }
                else if (node.next == null && node_stk.Count != 0)
                {
                    Node currNode = node_stk.Pop();
                    node.next = currNode;
                    currNode.prev = node;
                }
                node = node.next;
            }
            return head;
        }


    }
}
