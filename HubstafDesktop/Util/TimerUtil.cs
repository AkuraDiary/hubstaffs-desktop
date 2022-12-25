using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubstafDesktop.Util
{
   public static class TimerUtil
    {
        public static int getMinuteOf(int value)
        {
            return value / 60;
        }
        public static int getSecondOf(int value)
        {
            return value - (getMinuteOf(value) * 60);
        }

        public static string formatTime(int timeValue)
        {
            int minute = getMinuteOf(timeValue);
            int second = getSecondOf(timeValue);
            return minute.ToString() + " : " + second.ToString();
        }
    }
}
