using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class RemoveKDigitsC
    {
        public string RemoveKdigits(string num, int k)
        {
            LinkedList<char> stack = new LinkedList<char>();
        
    foreach(char digit in num) {
      while(stack.Count > 0 && k > 0 && stack.Last() > digit) {
        stack.RemoveLast();
        k -= 1;
      }
    stack.AddLast(digit);
    }
        
    /* remove the remaining digits from the tail. */
    for(int i = 0; i<k; ++i) {
      stack.RemoveLast();
    }
        
    // build the final string, while removing the leading zeros.
    StringBuilder ret = new StringBuilder();
bool leadingZero = true;
    foreach(char digit in stack) {
      if(leadingZero && digit == '0') continue;
      leadingZero = false;
      ret.Append(digit);
    }
        
    /* return the final string  */
    if (ret.Length == 0) return "0";
    return ret.ToString();
  }
    }
}
