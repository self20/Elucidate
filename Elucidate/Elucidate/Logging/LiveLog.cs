﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elucidate.Controls;

namespace Elucidate.Logging
{
    public static class LiveLog
    {
        public static Queue<LogString> LogQueueCommon { get; } = new Queue<LogString>();
        public static Queue<LogString> LogQueueRecover { get; } = new Queue<LogString>();

        public class LogString
        {
            public string LevelUppercase;
            public string Message;
        };

        // ReSharper disable UnusedMember.Global
        // This is used by the logging to force all to the output window
        public static void LogMethod(string levelUppercase, string message)
        {
            LogQueueCommon.Enqueue(new LogString
            {
                LevelUppercase = levelUppercase,
                Message = message
            });
            LogQueueRecover.Enqueue(new LogString
            {
                LevelUppercase = levelUppercase,
                Message = message
            });
        }

    }
}
