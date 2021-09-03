using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/833164/
    /// <ID>5014</ID>
    /// </summary>
    class DivideStringPrime
    {
        Dictionary<int, bool> primeDic;
        Dictionary<string, int> substringDic;
        
        public DivideStringPrime()
        {
            primeDic = new Dictionary<int, bool>();
            substringDic = new Dictionary<string, int>();
        }
        bool validatePrime(int num)
        {
            bool isprime = true;
            if (num <= 1||num>10e6)
                return false;
            if (primeDic.ContainsKey(num)) return primeDic[num];
            for(int i=2;i<=Math.Sqrt(num);i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            primeDic.Add(num, isprime);
            return isprime;
        }
        public int Divide(string str)
        {
            int count = 0;
            int mod = (int)1e9 + 7;
            if (substringDic.ContainsKey(str))
                return substringDic[str];
            if (str == "") return 1;
            for(int i=1;i<=str.Length;i++)
            {
                if(validatePrime(int.Parse(str.Substring(0,i))))
                {
                    count = (count+ Divide(str.Substring(i)))%mod;
                }
            }
            return count;
        }
    }
}
