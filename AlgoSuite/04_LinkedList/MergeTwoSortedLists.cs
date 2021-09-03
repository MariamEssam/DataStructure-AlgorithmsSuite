using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists/
    /// <ID>1021</ID>
    /// </summary>
    class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode list = null;
            ListNode head = null;
            while (l1 != null || l2 != null)
            {
                int value = 0;
                if (l2 == null || (l1!=null&&l1.val < l2.val))
                {
                    value = l1.val;
                    l1 = l1.next;
                }
                else
                {
                    value = l2.val;
                    l2 = l2.next;
                }
                if (list == null)
                {
                    list = new ListNode(value);
                    head = list;
                }
                else
                {
                    list.next = new ListNode(value);
                    list = list.next;
                }

            }
            return head;
        }
    }
}
