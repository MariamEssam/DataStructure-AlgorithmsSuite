using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    /// <summary>
    /// https://leetcode.com/problems/angle-between-hands-of-a-clock/
    /// <ID>089</ID>
    /// </summary>
    class AngleBetweenHandsClock
    {

        public double AngleClock(int hour, int minutes)
        {
            double angleminutes = 6 * minutes;
            double anglehrs = 30 * hour + minutes / 2.0;
            return Math.Min((angleminutes - anglehrs + 360) % 360, (anglehrs - angleminutes + 360) % 360);
        }
    }
}
