using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class AddTwoNumbersII
    {
        int getsize(ListNode lst)
        {
            int size = 0;
            while(lst!=null)
            {
                lst = lst.next;
                size++;
            }
            return size;
        }
        ListNode padd(ListNode lst,int diff)
        {
            ListNode head = lst;
            while(diff>0)
            {
                head = InsertFront(head,0);
                diff--;
            }
            return head;
        }
        ListNode InsertFront(ListNode lst,int val)
        {
            ListNode node = new ListNode(val);
            node.next = lst;
            return node;
        }
        public class PartialSum
        {
            public ListNode node;
            public int carry = 0;
        }
        void getsum(ListNode l1,ListNode l2,PartialSum sumpartial)
        {
            if (l1 == null && l2 == null)
                return;
            getsum(l1.next, l2.next, sumpartial);
            int sum = l1.val + l2.val + sumpartial.carry;
            sumpartial.node = InsertFront(sumpartial.node, sum % 10);
            sumpartial.carry = sum / 10;
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int sizel1 = getsize(l1);
            int sizel2 = getsize(l2);
            int diff = Math.Abs(sizel1 - sizel2);
            if(diff!=0)
            {
                if(sizel1<sizel2)
                {
                    l1 = padd(l1, diff);
                }
                else
                {
                    l2 = padd(l2, diff);
                }
            }
            PartialSum sumpartial = new PartialSum();
            getsum(l1, l2, sumpartial);
            if (sumpartial.carry > 0)
                return InsertFront(sumpartial.node, sumpartial.carry);
            return sumpartial.node;
        }
    }
}
