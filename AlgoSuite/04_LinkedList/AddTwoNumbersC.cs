using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/
    /// <ID>1002</ID>
    /// </summary>
    class AddTwoNumbersC
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode LSum = null;
            ListNode head =null;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int val1 = 0;
                int val2 = 0;
                if (l1 != null)
                {
                    val1 = l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    val2 = l2.val;
                    l2 = l2.next;
                }
                int sum = val1 + val2 + carry;
                carry = sum / 10;
                if (LSum == null)
                {
                    LSum = new ListNode(sum % 10);
                    head = LSum;
                }
                else
                {
                    LSum.next = new ListNode(sum % 10);
                    LSum = LSum.next;
                }
            }
            if (carry != 0)
            {
                LSum.next = new ListNode(carry);
            }
            return head;
        }
    }
}
