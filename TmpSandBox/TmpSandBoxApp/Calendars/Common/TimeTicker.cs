using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace TmpSandBoxApp.Calendars.Common
{
    public class TimeTicker : ITimeTicker
    {
        private readonly Logger mLogger = LogManager.GetCurrentClassLogger();
        private readonly object mLock = new object();
        private ulong mCurrentTicks;

        public ulong GetTicks()
        {
            lock(mLock)
            {
                return mCurrentTicks;
            }
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
