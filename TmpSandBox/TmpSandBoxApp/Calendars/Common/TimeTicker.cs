using NLog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TmpSandBoxApp.Calendars.Common
{
    public class TimeTicker : ITimeTicker
    {
        private readonly Logger mLogger = LogManager.GetCurrentClassLogger();
        private readonly object mLock = new object();
        private long mCurrentTicks;
        private Thread mThread;
        private bool mRun;

        public long GetTicks()
        {
            lock(mLock)
            {
                return mCurrentTicks;
            }
        }

        public void Start()
        {
            lock(mLock)
            {
                if(mRun)
                {
                    return;
                }

                mRun = true;
                mThread = new Thread(UpdateTicks);
                mThread.IsBackground = true;
                mThread.Start();
            }
        }

        public void Stop()
        {
            lock(mLock)
            {
                if(!mRun)
                {
                    return;
                }
                mRun = false;
                mThread = null;
            }
        }

        private void UpdateTicks()
        {
            while(true)
            {
                lock(mLock)
                {
                    if(!mRun)
                    {
                        return;
                    }
                    mCurrentTicks++;
                }
                Thread.Sleep(1000);
            }
        }
    }
}
