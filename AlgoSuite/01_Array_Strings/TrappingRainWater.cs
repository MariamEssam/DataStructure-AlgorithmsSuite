using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            int sum = 0;
            
            for(int i=0;i<height.Length-2;i++)
            {
                if (height[i] < height[i + 1])
                    continue;
                int ptr1 = i;
                int ptr2 = i+1;
                while(ptr2<height.Length&&height[ptr2]<=height[i])
                {
                    ptr2++;
                }
               if(ptr2<height.Length)
                {
                    int h = height[ptr1] < height[ptr2] ? height[ptr1] : height[ptr2];
                    for(int j=ptr1+1;j<ptr2;j++)
                    {
                        sum += (h - height[j]);
                    }
                }
                i = ptr2-1;

            }
            return sum;
        }
    }
}
