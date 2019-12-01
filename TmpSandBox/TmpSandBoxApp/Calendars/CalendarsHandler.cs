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

            var currTicks = 1095292800L;

            mLogger.Info($"currTicks = {currTicks}");

            var secsInDay = 86400;

            var days = currTicks / secsInDay;

            mLogger.Info($"days = {days}");

            mLogger.Info("End");
        }
    }
}
