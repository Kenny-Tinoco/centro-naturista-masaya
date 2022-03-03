namespace MasayaNaturistCenter.Model.Utilities
{
    public class DateUtilities
    {
        public Date getToday()
        {
            Date date = new Date();
            return date;
        }
        
        public string convertDateToString(Date parameter)
        {
            return parameter.day + "/" + parameter.month + "/" + parameter.year;
        }

        public Date convertStringToDate(string parameter)
        {
            return new Date();
        }
    }
}
