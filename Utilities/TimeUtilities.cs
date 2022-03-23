using System;
using System.Globalization;

namespace MasayaNaturistCenter.Model.Utilities
{
    public class TimeUtilities
    {
        private string timeFormat = "hh:mm tt";


        public Time actualTime()
        {
            return convertStringToTime(DateTime.Now.ToString(timeFormat));
        }

        public string convertTimeToString(Time paremeter)
        {
            return paremeter.stringTime;
        }

        public Time convertStringToTime(string parameter)
        {
            if (parameter == null)
                return null;

            var timeObject = DateTime.ParseExact(parameter, timeFormat, CultureInfo.InvariantCulture);

            var time = timeObject.ToString(timeFormat);
            var abbreviation = time.Substring(time.Length-2,2);

            return new Time(timeObject.Hour, timeObject.Minute, abbreviation);
        }
    }
}
