using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ReorderLinkedList
    {
        public ListNode RevertList(ListNode head)
        {
            ListNode prev = null,curr=head,next=null;
            while(curr!=null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
        public void ReorderList(ListNode head)
        {
            //Find Mid
            ListNode head_LL = head;
            ListNode mid_LL = head;
            ListNode fastptr = head;
            while(fastptr!=null&&fastptr.next!=null)
            {
                mid_LL = mid_LL.next;
                fastptr = fastptr.next.next;
            }
            //Revert the second half 
            ListNode mid_reverted = RevertList(mid_LL);
            while(mid_reverted.next != null)
            {
                ListNode temp = head_LL.next;
                head_LL.next = mid_reverted;
                head_LL = temp;

                temp = mid_reverted.next;
                mid_reverted.next = head_LL;
                mid_reverted = temp;
            }
            //head_LL.next = null;
        }
    }
}
