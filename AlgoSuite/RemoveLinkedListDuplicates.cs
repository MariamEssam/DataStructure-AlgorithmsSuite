using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// <ID>1083</ID>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-list/
    /// </summary>
    class RemoveLinkedListDuplicates
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current = head;

            while(current!=null&&current.next!=null)
            {
                if(current.val==current.next.val)
                {
                    current.next = current.next.next;
                }
                else
                    current = current.next;
            }
            return head;
        }
    }
}
