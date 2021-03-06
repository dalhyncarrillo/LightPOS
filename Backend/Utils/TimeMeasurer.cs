﻿//
// Copyright (c) NickAc. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System;
using System.Diagnostics;

namespace NickAc.LightPOS.Backend.Utils
{
    public static class TimeMeasurer
    {
        public static void MeasureTime(Action a)
        {
            MeasureTime("", a);
        }

        public static void MeasureTime(string action, Action a)
        {
#if DEBUG
            var sw = new Stopwatch();
            sw.Start();
#endif
            a();
#if DEBUG
            sw.Stop();
            Console.WriteLine("Action[{1}] took {0}ms to execute.", sw.ElapsedMilliseconds, action);
#endif
        }
    }
}