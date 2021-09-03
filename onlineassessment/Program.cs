using CustomStringEnumerator.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineassessment
{
    class Program
    {
        static IEnumerable<int> YieldReturn()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }

        static void Main(string[] args)
        {
            //foreach (int i in YieldReturn())
            //    Console.WriteLine(i);

            var collection = new string[] {"Asse","ased","ase","Wded","dde","W","Heeeeeed"};
            var config = new EnumeratorConfig
            {
              
                MaxLength = 18,
                StartWithCapitalLetter = true
            };
            CustomStringEnumerator.Tests.CustomStringEnumerator dd = new CustomStringEnumerator.Tests.CustomStringEnumerator(collection,config);
            foreach (var ss in dd)
                Console.WriteLine(ss);
        }
    }
}
