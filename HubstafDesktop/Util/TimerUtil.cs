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

            string mMinute = minute.ToString();
            string mSecond = second.ToString();
            if (minute < 10) {
                mMinute = "0" + mMinute;
            }
            if (second < 10)
            {
                mSecond = "0" + mSecond;
            }

            return mMinute + " : " + mSecond;
        }
    }
}
