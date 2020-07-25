using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class OddEvenLS
    {
        /// <summary>
        /// https://leetcode.com/problems/odd-even-linked-list/
        /// <ID>068</ID>
        /// </summary>
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null||head.next==null)
                return head;
            ListNode head_odd = head;
            ListNode head_even = head.next;
            ListNode oddNode = head_odd;
            ListNode evenNode = head_even;
            while(evenNode!=null&&evenNode.next!=null)
            {
                oddNode.next = evenNode.next;
                oddNode = oddNode.next;
                evenNode.next = oddNode.next;
                evenNode = evenNode.next;
            }
            oddNode.next = head_even;
            return head_odd;
        }
    }
}
