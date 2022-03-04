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
            return parameter.dateString;
        }

        public Date convertStringToDate(string parameter)
        {
            if (parameter == null)
                return null;

            Date date = new Date();
            return date;
        }
    }
}
