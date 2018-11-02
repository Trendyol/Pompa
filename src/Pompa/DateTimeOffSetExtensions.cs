using System;

namespace Pompa
{
    public static class DateTimeOffSetExtensions
    {
        public static long ToUnixTimeSeconds(this DateTimeOffset dateTimeOffset)
        {
            return dateTimeOffset.UtcDateTime.Ticks / 10000000L - 62135596800L;
        }
    }
}