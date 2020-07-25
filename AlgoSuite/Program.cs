using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class Program
    {
        static TreeNode ConvertStringTree(string str)
        {
            string[] str_arr = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            TreeNode root = new TreeNode(int.Parse(str_arr[0]));
            Queue<TreeNode> que = new Queue<TreeNode>();
            que.Enqueue(root);
            for (int i=1;i<str_arr.Length;i+=2)
            {
                TreeNode node = que.Dequeue();
                if (i < str_arr.Length && str_arr[i] != "null")
                {
                    node.left = new TreeNode(int.Parse(str_arr[i]));
                    que.Enqueue(node.left);
                }
               if (i+1 < str_arr.Length && str_arr[i+1] != "null")
                {
                    node.right = new TreeNode(int.Parse(str_arr[i+1]));
                    que.Enqueue(node.right);
                }
            }
            return root;
        }
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 1, 2, 5, 10 };
            //CoinChangeC cc = new CoinChangeC();
            //int x = cc.CoinChange(arr, 18);
            //ContiguousArray cngt = new AlgoSuite.ContiguousArray();
            //cngt.findMaxLength(new int[] { 0, 0, 1, 0, 0, 0, 1, 1 });
            //GenerateParentheses par = new GenerateParentheses();
            //IList<string> str= par.GenerateParenthesis(3);
            //NumberComplement num = new NumberComplement();
            //num.FindComplement(5);
            //int[][] arr = new int[][] { new int[] { -4, -3 }, new int[] { 1, 0 }, new int[] { 3, -1 }, new int[] { 0, -1 }, new int[] { -5, 2 } };
            //StraightLine strline = new StraightLine();
            //strline.CheckStraightLine(arr);
            //RemoveKDigitsC gg = new RemoveKDigitsC();
            //gg.RemoveKdigits("1432219", 3);
            //ListNode head = new ListNode(1);
            //ListNode node = head;
            //int i = 2;
            //while(i<=7)
            //{
            //    node.next = new AlgoSuite.ListNode(i++);
            //    node = node.next;
            //}
            //OddEvenLS ss = new AlgoSuite.OddEvenLS();
            //ss.OddEvenList(head);
            //PermutationString sp = new PermutationString();
            //bool isv=sp.CheckInclusion("ab", "eidbaooo");
            //StockSpanner stk = new AlgoSuite.StockSpanner();
            //int r= stk.Next(29);
            //r = stk.Next(91);
            //r = stk.Next(62);
            //r = stk.Next(76);
            //r = stk.Next(51);
            //r = stk.Next(75);
            //r = stk.Next(85);
            //CoinChange2 c = new CoinChange2();
            //c.Change(5, new int[] { 1, 2, 5 });
            //TreeNode node = new TreeNode(10);
            //node.left = new TreeNode(5);
            //node.left.left = new TreeNode(3);
            //node.left.right = new TreeNode(7);
            //node.left.left.left = new TreeNode(1);
            //node.left.right.left = new TreeNode(8);
            //node.right = new TreeNode(15);
            //node.right.left = new TreeNode(13);
            //node.right.right = new TreeNode(8);
            //RangeSumofBST bst = new RangeSumofBST();
            //int s = bst.RangeSumBST(node, 7, 15);
            //SurroundedRegions reg = new SurroundedRegions();
            //reg.Solve(new char[][] { new char[] { 'O' } });
            //LongestDuplicateSubstring st = new LongestDuplicateSubstring();
            //st.LongestDupSubstring("banaba");
            //TreeNode node = ConvertStringTree("0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,null,0,0");
            //node.right = new TreeNode(0);
            //WidthOfBinaryTreeC wss = new AlgoSuite.WidthOfBinaryTreeC();
            //int v= wss.WidthOfBinaryTree(node);
            //SumRootLeafNumbers rootleaf = new SumRootLeafNumbers();
            //int s = rootleaf.SumNumbers(node);
            //PerfectSquares sq = new PerfectSquares();
            //int s = sq.NumSquares(12); 
            //HammingDistanceC hm = new HammingDistanceC();
            //hm.HammingDistance(1, 4);
            //PrisonCellsAfterNDays pr = new AlgoSuite.PrisonCellsAfterNDays();
            //int[] cells = new int[] { 1, 0, 0, 1, 0, 0, 1, 0 };
            //cells= pr.PrisonAfterNDays(cells, 1000000000);
            //FlattenMultilevelDoublyLinkedList.Node nn = new FlattenMultilevelDoublyLinkedList.Node();
            //nn.child = new FlattenMultilevelDoublyLinkedList.Node();
            //nn.child.child = new FlattenMultilevelDoublyLinkedList.Node();
            //nn.child.child.child = new FlattenMultilevelDoublyLinkedList.Node();
            //FlattenMultilevelDoublyLinkedList vv = new FlattenMultilevelDoublyLinkedList();
            //vv.Flatten(nn);
            //SmallerNumbersThanCurrentC cd = new SmallerNumbersThanCurrentC();
            //cd.SmallerNumbersThanCurrent(new int[] { 8, 1, 2, 2, 3 });
            ListNode nn = new ListNode(1);
            nn.next = new ListNode(2);
            nn.next.next = new ListNode(3);
            nn.next.next.next = new ListNode(4);
            nn.next.next.next.next = new ListNode(5);
            nn.next.next.next.next.next = new ListNode(6);
            RemoveLinkedListElements rr = new RemoveLinkedListElements();
            ListNode d= rr.RemoveElements(nn, 6);

        }
    }
}
