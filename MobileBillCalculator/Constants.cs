using System;

namespace MobileBillCalculator
{
    public static class Constants
    {
        public static int Purse { get; private set; } = 20;

        private static DateTime PeekHourStartTime => Convert.ToDateTime("9.00.00 am");
        private static DateTime PeekHourEndTime => Convert.ToDateTime("10.59.59 pm");

        public static bool IsPeekHour(this DateTime dateTime)
        {
            return dateTime.Ticks >= PeekHourStartTime.Ticks && dateTime.Ticks <= PeekHourEndTime.Ticks;
        }
    }
}
