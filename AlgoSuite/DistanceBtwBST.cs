using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/376375/
    /// <ID>5010</ID>
    /// </summary>
    class DistanceBtwBST
    {
        public int bstDistance(int[] nums, int node1, int node2)
        {
            if (nums.Length == 0) return -1;
            if (node1 == node2) return 0;
            TreeNode node = BuildBST(nums);
            int[] dist = new int[3];
            FindLCA(0, node, node1, node2,dist);
            return dist[2];

        }
        int FindLCA(int level,TreeNode node,int p,int q,int[] dist)
        {
            int isfind = 0;
            if (node == null) return 0;
            level++;
            if (node.val == p)
            {
                dist[0] = level;
                isfind |= 1;
            }
            if (node.val == q)
            {
                dist[1] = level;
                isfind |= 1 << 1;
            }
            if (p < node.val || q < node.val) isfind |= FindLCA(level, node.left, p, q, dist);
            if (p > node.val || q > node.val) isfind |= FindLCA(level, node.right, p, q, dist);
            if(isfind==3&&dist[2]==0)
            {
                dist[2] = dist[0]+ dist[1] - 2*level;
            }
            return isfind;
        }
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null) return new TreeNode(val);
            TreeNode node = root;
            bool isfound = false;
            while (!isfound)
            {
                if (node.val > val)
                {
                    if (node.left == null) { node.left = new TreeNode(val); isfound = true; }
                    else node = node.left;
                }
                else
                if (node.right == null) { node.right = new TreeNode(val); isfound = true; }
                else node = node.right;
            }
            return root;
        }
        TreeNode BuildBST(int[] nums)
        {
            TreeNode head = new TreeNode(nums[0]);
            TreeNode node = head;
            for(int i=1;i<nums.Length;i++)
            {
                InsertIntoBST(node, nums[i]);
            }
            return head;
        }
    }
}
