using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class TrappingRainWater
    {
        /// <summary>
        /// Brute Force Solution
        /// </summary>
        public int Trap_BruteForce(int[] height)
        {
            if (height.Length < 2) return 0;
            int totalSpace = 0;

            for (int i = 1; i < height.Length; i++)
            {
                int maxheightLeft = -1, maxheightRight = -1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (height[i] < height[j])
                        maxheightLeft = Math.Max(maxheightLeft, height[j]);
                }
                for (int j = i + 1; j < height.Length; j++)
                {
                    if (height[i] < height[j])
                        maxheightRight = Math.Max(maxheightRight, height[j]);
                }
                int minheight = Math.Min(maxheightRight, maxheightLeft);
                if (minheight != -1)
                    totalSpace += (minheight - height[i]);
            }
            return totalSpace;
        }
        /// <summary>
        /// Using dynamic programming
        /// </summary>
        public int Trap_dynamicProgramming(int[] height)
        {
            if (height.Length < 2) return 0;
            int sum = 0;
            int[] leftMaxHeight = new int[height.Length];
            int[] RightMaxHeight = new int[height.Length];
            leftMaxHeight[0] = height[0];
            RightMaxHeight[height.Length - 1] = height[height.Length - 1];
            for (int i = 1; i < height.Length; i++)
                leftMaxHeight[i] = Math.Max(height[i], leftMaxHeight[i - 1]);
            for (int i = height.Length - 2; i >= 0; i--)
                RightMaxHeight[i] = Math.Max(height[i], RightMaxHeight[i + 1]);
            for (int i = 1; i < height.Length - 1; i++)
            {
                int h = Math.Min(RightMaxHeight[i], leftMaxHeight[i]);
                if (h > height[i])
                    sum += (h - height[i]);
            }
            return sum;
        }
        public int Trap_Stk(int[] height)
        {
            Stack<int> stk = new Stack<int>();
            int sum = 0;
            for (int i = 0; i < height.Length; i++)
            {
                while (stk.Count > 0 && height[i] > height[stk.Peek()])
                {
                    int top = stk.Pop();
                    if (stk.Count == 0)
                        break;
                    int distance = i - stk.Peek() - 1;
                    int bounded_height = Math.Min(height[i], height[stk.Peek()]) - height[top];
                    sum += bounded_height * distance;
                }
                stk.Push(i);

            }
            return sum;
        }
        public int Trap(int[] height)
        {
            int sum = 0;
            int left_max = 0, right_max = 0;
            int left_ptr = 0, right_ptr = height.Length - 1;
            while(left_ptr<right_ptr)
            {
                if(height[left_ptr]<height[right_ptr])
                {
                    if(left_max<height[left_ptr])
                    {
                        left_max = height[left_ptr++];
                    }
                    else
                    {
                        sum += left_max - height[left_ptr++];
                    }
                }
                else
                {
                    if (right_max < height[right_ptr])
                    {
                        right_max = height[right_ptr--];
                    }
                    else
                    {
                        sum += right_max - height[right_ptr--];
                    }
                }
            }
            return sum;
        }
    }
}
