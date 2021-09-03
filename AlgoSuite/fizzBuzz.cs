using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/fizz-buzz/
    /// <ID>1412</ID>
    /// </summary>
    class fizzBuzzC
    {
        public IList<string> FizzBuzz(int n)
        {
            IList<string> reslst = new List<string>();
            for(int i=1;i<=n;i++)
            {
                StringBuilder build = new StringBuilder();
                if (i % 3 == 0)
                    build.Append("Fizz");
                if (i % 5 == 0)
                    build.Append("Buzz");
                if(build.ToString()=="")
                    build.Append(i.ToString());
                reslst.Add(build.ToString());

            }
            return reslst;
        }
    }
}
