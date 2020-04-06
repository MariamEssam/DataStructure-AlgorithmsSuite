using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{

    class LargestNum
    {
        List<int> getnumList(int num)
        {
            if (num == 0) return new List<int>() { 0 };
            List<int> numlst = new List<int>();
            while (num!=0)
            {
                numlst.Add(num % 10);
                num = num / 10;
            }
            numlst.Reverse();
            return numlst;
        }
        class SetNum
        {
            public List<int> numlst = new List<int>();
            public int index = 0;
        }
        /// <summary>
        /// https://leetcode.com/problems/largest-number/
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public string LargestNumber(List<int> A)
        {
            A.Sort((a, b) => (b + "" + a).CompareTo(a + "" + b));
            if (A[0] == 0) return "0";
            StringBuilder str = new StringBuilder();
            foreach (var c in A)
                str.Append(c);
            return str.ToString();
        }
       

    }
}
