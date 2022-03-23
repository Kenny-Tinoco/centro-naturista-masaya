using System;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model.Utilities
{
    public class Time
    {
        public int minute;
        public int hour;
        public string abbreviation;


        public Time(int hour, string abbreviation) : this(hour,0, abbreviation)
        {
        }

        public Time(int hour, int minute, string abbreviation)
        {
            Contract.Requires(validTime(hour, minute) && abbreviation != null);
            this.minute = minute;
            this.hour = hour;
            this.abbreviation = abbreviation;
        }

        private bool validTime(int hour, int minute)
        {
            bool ok = true;
            return ok;
        }

        public string stringTime
        {
            get 
            {
                return hour + ":" + minute+" "+abbreviation;
            }
        }
    }
}