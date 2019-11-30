using System;
using System.Collections.Generic;
using System.Text;

namespace TmpSandBoxApp.Calendars.Common
{
    public static class TimeTickerManager
    {
        private static TimeTicker mTimeTickerInstace = new TimeTicker();

        public static ITimeTicker GetTimeTicker()
        {
            return mTimeTickerInstace;
        }
    }
}
