using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class DayofWeek_OA
    {
        public string DayofWeek(string day, int k)
        {
            string[] days = new string[] { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
            int dayindex = -1;
            for(int i=0;i<7;i++)
            {
                if(days[i]==day) { dayindex = i;break; }
            }
            return dayindex == -1 ? "" : days[(dayindex + k) % 7];
        }
    }
}
