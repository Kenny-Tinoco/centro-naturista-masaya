using System;

namespace MasayaNaturistCenter.Model.Utilities
{
    public class DateUtilities
    {
        private string dateFormat = "d/M/yyyy";

        public Date getToday()
        {
            return convertStringToDate(DateTime.Now.ToString(dateFormat));
        }
        
        public string convertDateToString(Date parameter)
        {
            return parameter.dateString;
        }

        public Date convertStringToDate(string parameter)
        {
            if (parameter == null)
            {
                return null;
            }

            var dateTime = DateTime.ParseExact(parameter, dateFormat, null);

            return new Date(dateTime.Day, dateTime.Month, dateTime.Year);
        }
    }
}
