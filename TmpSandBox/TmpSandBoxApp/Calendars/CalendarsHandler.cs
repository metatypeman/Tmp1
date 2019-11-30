using NLog;
using System;
using System.Collections.Generic;
using System.Text;
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

            mLogger.Info("End");
        }
    }
}
