using System;
using System.Collections.Generic;
using System.Text;

namespace TmpSandBoxApp.Calendars.Common
{
    public interface IReadOnlyTimeTicker
    {
        long GetTicks();
    }
}
