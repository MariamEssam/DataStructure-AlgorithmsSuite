using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class ValidateIPAddress
    {
        public string ValidIPAddress(string IP)
        {
            string invalid = "Neither";
            string[] splitedIP = IP.Split(new char[] { '.' });
            if(splitedIP.Length==4)
            {
                foreach(var s in splitedIP)
                {
                    if (!String.IsNullOrEmpty(s))
                    {
                        if (s[0] == '0' && s.Length > 1)
                            return invalid;
                        else
                        {
                            int val = 0;
                            bool result = int.TryParse(s, out val);
                            if (val < 0 || val > 255)
                                return invalid;
                        }
                    }
                    else
                        return invalid;
                }
                return "IPV4";
            }
            splitedIP = IP.Split(new char[] { ':' });
            if(splitedIP.Length==8)
            {
                String hexdigits = "0123456789abcdefABCDEF";
                foreach(var s in splitedIP)
                {
                    if (String.IsNullOrEmpty(s)||s.Length > 4)
                        return invalid;
                    if (s.Length > 1 && s[0] == '0' && s[1] == '0')
                        return invalid;
                    foreach (char ch in s)
                        if (!hexdigits.Contains(ch))
                            return invalid;
                }
                return "IPV6";
            }
            return invalid;
        }
    }
}
