using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-linked-lists/
    /// <ID>1160</ID>
    /// </summary>
    class IntersectionofTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;
            int sizeA = 1, sizeB = 1;
            ListNode headNodeA = headA;
            ListNode headNodeB = headB;
            while(headNodeA.next!=null)
            {
                sizeA++;
                headNodeA = headNodeA.next;
            }
            while (headNodeB.next != null)
            {
                sizeB++;
                headNodeB = headNodeB.next;
            }
            //If the last two nodes are not equal that's mean that there's
            //no intersection between  the two lists
            if (headNodeA != headNodeB)
                return null;
            ListNode longer = null;
            ListNode shorter = null;
            int diff = Math.Abs(sizeA - sizeB);
            if(sizeA>=sizeB)
            {
                longer = headA;
                shorter = headB;
            }
            else
            {
                longer = headB;
                shorter = headA;
            }
            //Move the longer with diff
            while(diff!=0)
            {
                longer = longer.next;
                diff--;
            }
            while(longer!=shorter)
            {
                longer = longer.next;
                shorter = shorter.next;
            }
            return longer;
        }
    }
}
