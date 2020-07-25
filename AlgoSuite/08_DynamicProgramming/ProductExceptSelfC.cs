using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/product-of-array-except-self/
    /// <ID>032</ID>
    /// </summary>
    class ProductExceptSelfC
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] product = new int[nums.Length];
            product[0] = 1;
            int product_val = 1;
            for(int i=1;i<nums.Length;i++)
            {
                product[i] = product_val * nums[i - 1];
                product_val = product[i];
            }
            product_val = nums[nums.Length - 1];
            for(int i=nums.Length-2;i>=0;i--)
            {
                product[i] *= product_val;
                product_val *= nums[i];
            }
            return product;
        }
    }
}
