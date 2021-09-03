using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/762546/
    ///<ID>5001</ID>
    /// </summary>
    class FreshPromotionCode
    {
        public int isCustomerWinner(List<String> shoppingList, List<List<String>> codeList)
        {
            if (codeList.Count == 0) return 1;
            if (shoppingList.Count == 0) return 0;
            int shoppingIndex = 0;
            int codeIndex = 0;
            int codeInnerIndex = 0;
            while(shoppingIndex<shoppingList.Count&&codeIndex<codeList.Count)
            {
                if(codeList[codeIndex].Count==0)
                {
                    codeIndex++;
                    continue;
                }
                if(shoppingList[shoppingIndex]==codeList[codeIndex][codeInnerIndex]|| codeList[codeIndex][codeInnerIndex] == "anything")
                {
                    codeInnerIndex++;
                }
                else 
                {
                    shoppingIndex -= codeInnerIndex;
                    codeInnerIndex = 0;
                }
                shoppingIndex++;
                if (codeInnerIndex == codeList[codeIndex].Count)
                {
                    codeInnerIndex = 0;
                    codeIndex++;
                }
            }
            if (codeIndex >= codeList.Count) return 1;
            return 0;
        }
    }
}
