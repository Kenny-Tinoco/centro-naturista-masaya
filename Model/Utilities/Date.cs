using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    public class Date
    {
        private int day;
        private int month;
        private int year;   


        public Date()
        {
            Date date = getToday();
            this.day = date.day;
            this.month = date.month;
            this.year = date.year;
        }

        public Date(int day, int month, int year)
        {
            Contract.Requires(validDate(day, month, year));
            this.day = day;
            this.month = month;
            this.year = year;
        }


        public string getDateString()
        {
            return day + "/" + month + "/" + year;
        }

        public Date getStringOfDate(string parameter)
        {
            var date = new Date
            {
                day = 0,
                month = 0,
                year = 0
            };

            return date;
        }

        public Date getToday()
        {
            Date date = new Date();
            return date;
        }

        private bool validDate(int day, int month, int year)
        {
            bool ok = true;
            return ok;
        }
    }
}