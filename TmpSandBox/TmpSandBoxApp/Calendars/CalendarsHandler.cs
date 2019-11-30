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

            var timeTicker = TimeTickerManager.GetTimeTicker();

            mLogger.Info($"timeTicker.GetTicks() = {timeTicker.GetTicks()}");

            timeTicker.Start();

            Thread.Sleep(1000);

            mLogger.Info($"timeTicker.GetTicks() = {timeTicker.GetTicks()}");

            timeTicker.Stop();

            mLogger.Info("End");
        }
    }
}
