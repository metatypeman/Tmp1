using NLog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TmpSandBoxApp.Calendars.Common;

namespace TmpSandBoxApp.Calendars
{
    public class CalendarsHandler
    {
        private readonly Logger mLogger = LogManager.GetCurrentClassLogger();

        public void Run()
        {
            mLogger.Info("Begin");

            //var timeTicker = TimeTickerManager.GetTimeTicker();

            //mLogger.Info($"timeTicker.GetTicks() = {timeTicker.GetTicks()}");

            //timeTicker.Start();

            //Thread.Sleep(1000);

            //mLogger.Info($"timeTicker.GetTicks() = {timeTicker.GetTicks()}");

            //Thread.Sleep(1000);

            //mLogger.Info($"timeTicker.GetTicks() = {timeTicker.GetTicks()}");

            //timeTicker.Stop();

            var tmpDt = new DateTime(2000, 2, 29, 0, 0, 0, DateTimeKind.Utc);

            mLogger.Info($"tmpDt = {tmpDt}");

            var currTicks = tmpDt.Ticks;
            //var currTicks = 1095292800L;

            mLogger.Info($"currTicks = {currTicks}");

            var unixTicks = currTicks / 10000000;

            var secsInDay = 86400;

            var totalDays = unixTicks / secsInDay;

            mLogger.Info($"totalDays = {totalDays}");

            var secsInMonth = 2629743;

            var totalMonths = unixTicks / secsInMonth;

            mLogger.Info($"totalMonths = {totalMonths}");

            var secsInYear = 31556926;

            var totalYears = unixTicks / secsInYear;

            mLogger.Info($"totalYears = {totalYears}");

            var realYears = totalYears + 1;

            mLogger.Info($"realYears = {realYears}");

            var lastSeconds = unixTicks - (totalYears * secsInYear);

            mLogger.Info($"lastSeconds = {lastSeconds}");

            var lastMonths = lastSeconds / secsInMonth;

            mLogger.Info($"lastMonths = {lastMonths}");

            var lastSecondsAfterMonths = lastSeconds - (lastMonths * secsInMonth);

            mLogger.Info($"lastSecondsAfterMonths = {lastSecondsAfterMonths}");

            var lastDays = lastSecondsAfterMonths / secsInDay;

            mLogger.Info($"lastDays = {lastDays}");

            var lastSecondsAfterDays = lastSecondsAfterMonths - (lastDays * secsInDay);

            mLogger.Info($"lastSecondsAfterDays = {lastSecondsAfterDays}");

            var secsInHours = 3600;

            var lastTotalHours = lastSecondsAfterDays / secsInHours;

            mLogger.Info($"lastTotalHours = {lastTotalHours}");

            mLogger.Info("End");
        }
    }
}
