using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// <ID>1082</ID>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
    /// </summary>
    class RemoveLinkedListDuplicatesII
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode sentinel = new ListNode(0);
            sentinel.next = head;
            ListNode pred = sentinel;
            while(head!=null)
            {
                if(head.next!=null&&head.val==head.next.val)
                {
                    while(head.next != null && head.val == head.next.val)
                    {
                        head = head.next;
                    }
                    pred.next = head.next;
                }
                else
                {
                    pred = pred.next;
                }
                head = head.next;
            }
            return sentinel.next;
        }
    }
}
