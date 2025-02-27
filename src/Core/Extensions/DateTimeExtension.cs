﻿using System;

namespace Core.Extensions
{
    internal static class DateTimeExtension
    {
        public static long ToTimestamp(this DateTime dateTime)
        {
            var centuryBegin = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var expectedDate = dateTime.Subtract(new TimeSpan(centuryBegin.Ticks));
            return expectedDate.Ticks / 10000;
        }
    }
}