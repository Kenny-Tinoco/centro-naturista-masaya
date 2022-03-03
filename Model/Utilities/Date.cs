using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model.Utilities
{
    public class Date
    {
        public int day;
        public int month;
        public int year;   


        public Date()
        {
            var date = new DateUtilities().getToday();
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

        private bool validDate(int day, int month, int year)
        {
            bool ok = true;
            return ok;
        }
    }
}