namespace MasayaNaturistCenter.Model.Utilities
{
    public class DateUtilities
    {
        public DateUtilities()
        {

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
