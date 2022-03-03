using System;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model.Utilities
{
    public class Time
    {
        public int second;
        public int minute;
        public int hour;

        public Time()
        {
            var element = new TimeUtilities().actualTime();
            this.second = element.second;
            this.minute = element.minute;
            this.hour = element.hour;
        }

        public Time(int hour, int minute)
        {
            Contract.Requires(validTime(hour, minute, 0));
            this.second = second;
            this.minute = minute;
            this.hour = hour;
        }

        private bool validTime(int hour, int minute, int second)
        {
            bool ok = true;
            return ok;
        }
    }
}