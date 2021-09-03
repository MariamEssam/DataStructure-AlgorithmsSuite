using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode temphead = head;
            ListNode currentnode = head;
            ListNode previousnode = null;
            while(currentnode!=null)
            {
                if(currentnode.val==val)
                {
                    if (previousnode == null) head = head.next;
                    else previousnode.next = currentnode.next;
                    return head;
                }
                previousnode=currentnode;
                currentnode = currentnode.next;
            }
            return null;
        }
    }
}
