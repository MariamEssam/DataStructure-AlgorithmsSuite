using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/container-with-most-water/
    /// <ID>014</ID>
    /// </summary>
    class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int maxheight = 0;
            int high = height.Length - 1, low = 0;
            while(low<high)
            {
                maxheight = Math.Max((high - low) * Math.Min(height[high], height[low]), maxheight);
                if (height[high] < height[low]) high--;
                else low++;
            }
            return maxheight;
        }
    }
}
