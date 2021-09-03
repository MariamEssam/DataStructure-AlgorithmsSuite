using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-average-subtree/
    /// <ID>2120</ID>
    /// </summary>
    class MaximumAverageSubtreeC
    {
        double Max;
        class AveragePairs
        {
            public double sum { get; set; }
            public int SumChild { get; set; }
        }
        AveragePairs FindAverage(TreeNode node)
        {
            if (node == null) return new AveragePairs();
            AveragePairs ChildLeft = FindAverage(node.left);
            AveragePairs ChildRight = FindAverage(node.right);
            AveragePairs Parent = new AveragePairs();
            Parent.sum = (ChildLeft.sum + ChildRight.sum + node.val);
            Parent.SumChild = ChildLeft.SumChild + ChildRight.SumChild + 1;
            double averge =  Parent.sum/Parent.SumChild;
            Max= Math.Max(Max, averge);
            
           
            return Parent;
        }
        public double MaximumAverageSubtree(TreeNode root)
        {
            Max = double.MinValue;
            FindAverage(root);
            return Max;
        }
    }
}
