using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class AntiDiagonal
    {
        public List<List<int>> diagonal(List<List<int>> A)
        {
            List<List<int>> result = new List<List<int>>();
            if (A.Count == 0) return result;
            int N = A.Count -1;
            int index = 0;
           
            while(index<=2*N)
            {
                int col_index = index > N ? N : index;
                int row_index = index > N ? index - N : 0;
                int i = row_index,j=col_index;
                List<int> diag = new List<int>();
                while (true)
                {
                    diag.Add(A[i][j]);
                    if (j == row_index && i == col_index)
                        break;
                    j--;
                    i++;
                }
                result.Add(diag);
                index++;
            }
            return result;
        }
    }
}
