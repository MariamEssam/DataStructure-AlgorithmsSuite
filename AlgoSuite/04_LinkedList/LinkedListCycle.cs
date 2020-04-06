using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> indices = new HashSet<ListNode>();
            ListNode Node = head;
            while(Node!=null)
            {
                if(indices.Contains(Node))
                {
                    return true;
                }
                indices.Add(Node);
                Node = Node.next;
            }
            return false;
        }
    }
}
