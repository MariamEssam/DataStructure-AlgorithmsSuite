using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class RemoveNthFromEndC
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int size = 0;
            ListNode node = head;
            while(node!=null)
            {
                size++;
                node = head.next;
            }
            int index = size - n;
            if (index < 0) return head;
            ListNode prev = null;
            ListNode curr = head;
            while(index>=0)
            {
                if (index == 0)
                {
                    if (prev == null) head = head.next;
                    prev.next = curr.next;
                }
                prev = curr;
                curr = curr.next;
                index--;
            }
            return head;
        }
    }
}
