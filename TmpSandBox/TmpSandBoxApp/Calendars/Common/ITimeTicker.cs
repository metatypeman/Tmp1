using System;
using System.Collections.Generic;
using System.Text;

namespace TmpSandBoxApp.Calendars.Common
{
    public interface ITimeTicker
    {
        void Start();
        void Stop();
        ulong GetTicks();
    }
}
