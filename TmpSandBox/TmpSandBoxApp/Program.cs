using NLog;
using System;
using TmpSandBoxApp.Calendars;

namespace TmpSandBoxApp
{
    class Program
    {
        private static readonly Logger mLogger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            mLogger.Info("Hello World!");
            TstCalendarsHandler();
        }

        private static void TstCalendarsHandler()
        {
            mLogger.Info("Begin");
      
            var handler = new CalendarsHandler();
            handler.Run();

            mLogger.Info("End");
        }
    }
}
