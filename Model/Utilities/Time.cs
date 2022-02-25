using System;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model.Utilities
{
    public class Time
    {
        private int second;
        private int minute;
        private int hour;

        public Time()
        {
            Time time = actualTime();
            this.second = time.second;
            this.minute = time.minute;
            this.hour = time.hour;
        }

        public Time(int second, int minute, int hour)
        {
            Contract.Requires(validTime(second, minute, hour));
            this.second = second;
            this.minute = minute;
            this.hour = hour;
        }

        private bool validTime(int second, int minute, int hour)
        {
            bool ok = true;
            return ok;
        }

        public Time actualTime()
        {
            Time time = new Time();
            return time;
        }
    }
}