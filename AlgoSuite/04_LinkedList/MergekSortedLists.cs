using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MergekSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode list = null;
            ListNode head = null;
            bool found = true;
            while(found)
            {
                int val = 0;
                int min = int.MaxValue;
                found = false;
                int tempIndex = -1;
                ListNode tempNode = null;
                for(int k=0;k<lists.Length;k++)
                {
                    if(lists[k]!=null)
                    {
                        found |= true;
                        if(lists[k].val<min)
                        {
                            if(tempIndex!=-1)
                            {
                                lists[tempIndex] = tempNode;
                            }
                            min = lists[k].val;
                            tempIndex = k;
                            tempNode = lists[k];
                            lists[k] = lists[k].next;
                        }
                    }
                }
                if(list==null&&found)
                {
                    list = new ListNode(min);
                    head = list;
                }
                else
                {
                    list.next = new ListNode(min);
                    list = list.next;
                }
            }
            return head;
        }
    }
}
