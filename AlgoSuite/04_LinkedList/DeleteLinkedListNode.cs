using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/delete-node-in-a-linked-list/
    /// <ID>1237</ID>
    /// </summary>
    class DeleteLinkedListNode
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;

        }
    }
}
