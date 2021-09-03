using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/copy-list-with-random-pointer/
    /// <ID>1138</ID>
    /// </summary>
    class CopyRandomLS
    {
        // Definition for a Node.
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }

        Dictionary<Node, Node> dic = new Dictionary<Node, Node>();

        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;

            if (dic.ContainsKey(head)) return dic[head];
            Node node = new Node(head.val);
            dic.Add(head, node);
            node.next = CopyRandomList(head.next);
            node.random = CopyRandomList(head.random);
            return node;
        }
    }
    
}
