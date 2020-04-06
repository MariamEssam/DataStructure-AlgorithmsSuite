using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class DecodeStringC
    {
        int extractnumber(Stack<string> stk)
        {
            string num = "";
            while(stk.Count!=0)
            {
                string st = stk.Pop();
                if (st.Length == 1 && st[0] >= '0' && st[0] <= '9')
                {
                    num = st + num;
                }
                else
                {
                    stk.Push(st);
                    break;
                }
            }
            return int.Parse(num);
        }
        public string DecodeString(string s)
        {
            string builderchar = "";
            //string builderNum = "";
            StringBuilder builder = new StringBuilder();
            int numberofsquarebrackets = 0;
            Stack<string> stk = new Stack<string>();
            foreach(char c in s)
            {
                if(c==']')
                {
                    numberofsquarebrackets--;
                    string char_stack = "";
                    while(stk.Count!=0)
                    {
                        char_stack = stk.Pop();
                        if (char_stack == "[")
                        {
                            int num = extractnumber(stk);
                            StringBuilder b = new StringBuilder();
                            while (num-- != 0)
                                b.Append(builderchar.ToString());
                            stk.Push(b.ToString());
                            builderchar = "";
                            break;
                        }
                        else
                        {
                            builderchar = char_stack + builderchar;
                        }
                    }
                }
                else 
                {
                    
                    stk.Push(c.ToString());
                }
                
            }
            while (stk.Count != 0)
            {
                string char_stack = stk.Pop();
                builderchar = char_stack + builderchar;
            }
            return builderchar;
        }
    }
}
