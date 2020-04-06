using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MaximumProduct
    {
        public int MaxProduct(int[] nums)
        {
            int maxProduct = nums[0];
            int cuurminProduct = nums[0];
            int currProduct = nums[0];
            for(int i=1;i<nums.Length;i++)
            {
                if(nums[i]<0)
                {
                    int temp = currProduct;
                    currProduct = cuurminProduct;
                    cuurminProduct = temp;
                }
                currProduct = Math.Max(nums[i], nums[i] * currProduct);
                cuurminProduct = Math.Min(nums[i], nums[i] * cuurminProduct);
                maxProduct = Math.Max(maxProduct, currProduct);
            }
            return maxProduct;
        }
        
    }
}
