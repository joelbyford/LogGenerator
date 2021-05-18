using System;
using System.Diagnostics.Tracing;
using System.Diagnostics;

namespace LogGenerator
{
    [EventSource(Name = "MyCustomSource")]
    public class Logger : EventSource
    {
        public static Logger Log = new Logger();

        [Event(1, Message = "LogError: {0}", Level = EventLevel.Error)]
        public void LogError(string message)
        {
            WriteEvent(1, message);
        }

        [Event(2, Message = "LogWarning: {0}", Level = EventLevel.Warning)]
        public void LogWarning(string message)
        {
            WriteEvent(2, message);
        }
    }
}