using System;
using System.Diagnostics;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubLogMessage : ILogMessage
    {
        public void Information()
        {
            Debug.WriteLine("Logging");
        }
    }
}