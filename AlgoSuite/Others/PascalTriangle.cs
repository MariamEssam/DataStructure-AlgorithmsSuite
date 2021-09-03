using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (numRows < 1) return result;
            for(int i=0;i<numRows;i++)
            {
                IList<int> generatedrow = new List<int>();
                for(int j=0;j<=i;j++)
                {
                    if (j == 0 || j == i) generatedrow.Add(1);
                    else generatedrow.Add(result[result.Count - 1][j] + result[result.Count - 1][j - 1]);
                }
                result.Add(generatedrow);
            }
            return result;
        }
    }
}
