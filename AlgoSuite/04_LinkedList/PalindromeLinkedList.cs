using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
                return false;

            ListNode fast = head;
            ListNode slow = head;
            //Find the half of Linked list
            while(fast.next!=null&&fast.next.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            //Revert
            ListNode mid = slow;
            if (slow.next != null && slow.next.next != null)
            {
                ListNode prev =null;
                ListNode curr = slow.next;
                while(curr!=null)
                {
                    ListNode temp = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = temp;
                }

                mid.next = prev;
                
            }
            mid = mid.next;
            while(mid!=null)
            {
                if (head.val != mid.val)
                    return false;
                mid = mid.next;
                head = head.next;
            }
            return true;
        }
    }
}
