using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{

    public class ListNode
    {
          public int val;
          public ListNode next;
          public ListNode(int x) { val = x; }
      }

    class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode Node = head;
            if (head == null)
                return null;
            ListNode prevNode=null;
            while(Node!=null)
            {
                ListNode tempNode = Node.next;
                Node.next = prevNode;
                prevNode = Node;
                Node = tempNode;
            }
            head = prevNode;
            return head;
        }
    }
}
