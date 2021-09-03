using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class PackagingAutomation
    {
        public int maxItems(int numGroups, int[] arr)
        {
            if (arr.Length == 0) return 0;
            Array.Sort(arr);
            arr[0] = 1;
            for (int i = 1; i < arr.Length; i++)
                if ((arr[i] - arr[i - 1]) > 1)
                    arr[i] = arr[i - 1] + 1;
            return arr[numGroups - 1];
        }
    }
}
