using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class CopyRandomLS
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node() { }
            public Node(int _val, Node _next, Node _random)
            {
                val = _val;
                next = _next;
                random = _random;
            }
            Dictionary<Node, Node> NodeDic = new Dictionary<Node, Node>();
            public Node CopyRandomList(Node head)
            {
                if (head == null) return null;
                Node headcopy = new Node(head.val, null, null);
                NodeDic.Add(head, headcopy);
                Node nodetemp = head.next;
                Node curr = headcopy.next;

                while (nodetemp != null)
                {
                    Node n = new AlgoSuite.CopyRandomLS.Node(nodetemp.val, curr, null);
                    NodeDic.Add(nodetemp, n);
                    curr.next = n;
                    curr = curr.next;
                    nodetemp = nodetemp.next;
                }
                nodetemp = head;
                curr = head;
                while (nodetemp != null)
                {
                    curr.random = NodeDic[nodetemp];
                    curr = curr.next;
                    nodetemp = nodetemp.next;
                }
                return headcopy;
            }
        }
    }
}
