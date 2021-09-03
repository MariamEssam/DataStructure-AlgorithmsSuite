using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/search-suggestions-system/
    /// <ID>2268</ID>
    /// </summary>
    class SearchSuggestedProducts
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            IList<IList<string>> res = new List<IList<string>>();
            //Sort products
            Array.Sort(products);
            var matches = products.ToList();

            for(int i=0;i<searchWord.Length;i++)
            {
                filterProducts(i, searchWord[i], matches);
                res.Add(new List<string>());
                for (int j = 0; j < 3 && j < matches.Count; j++)
                    res[i].Add(matches[j]);
            }
            return res;
        }
        void filterProducts(int index,char c,List<string> products)
        {
            for(int i=products.Count-1;i>=0;i--)
            {
                if (index >= products[i].Length || products[i][index] != c)
                    products.RemoveAt(i);
            }
        }
    }
}
