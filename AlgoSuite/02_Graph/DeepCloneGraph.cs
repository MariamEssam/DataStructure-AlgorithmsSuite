using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite.Graph
{

    // Definition for a Node.
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node() { }
        public Node(int _val, IList<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }

        class DeepCloneGraph
        {
            Dictionary<int, Node> NodeSet = new Dictionary<int, Node>();
            Node Clone(Node node, Node targetNode)
            {
                if (NodeSet.ContainsKey(node.val))
                    return NodeSet[node.val];
                targetNode.val = node.val;
                NodeSet.Add(node.val, targetNode);
                foreach (var n in node.neighbors)
                {
                    if (targetNode.neighbors == null)
                        targetNode.neighbors = new List<Node>();
                    targetNode.neighbors.Add(Clone(n, new Node()));
                }
                return targetNode;
            }
            public Node CloneGraph(Node node)
            {
                if (node == null)
                    return null;
                Node root = new Node();

                return Clone(node,root);
            }
        }
    }
}
