using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class CompareLong : IComparer<long>
    {
        public int Compare(long x, long y)
        {
            if (x > y)
                return 1;
            else if (x < y)
                return -1;
            else
                return 0;
        }
    }
    class Program
    {
        static TreeNode ConvertStringTree(string str)
        {
            string[] str_arr = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            TreeNode root = new TreeNode(int.Parse(str_arr[0]));
            Queue<TreeNode> que = new Queue<TreeNode>();
            que.Enqueue(root);
            for (int i = 1; i < str_arr.Length; i += 2)
            {
                TreeNode node = que.Dequeue();
                if (i < str_arr.Length && str_arr[i] != "null")
                {
                    node.left = new TreeNode(int.Parse(str_arr[i]));
                    que.Enqueue(node.left);
                }
                if (i + 1 < str_arr.Length && str_arr[i + 1] != "null")
                {
                    node.right = new TreeNode(int.Parse(str_arr[i + 1]));
                    que.Enqueue(node.right);
                }
            }
            return root;
        }
        static void Main(string[] args)
        {
            TestAnything tt = new TestAnything();
            int l = tt.LengthOfLIS(new int[] { 2, 3, 7, 5, 6 });
        }

    }
}
