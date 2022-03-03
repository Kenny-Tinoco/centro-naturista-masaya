namespace MasayaNaturistCenter.Model.Utilities
{
    public class TimeUtilites
    {
        public TimeUtilites()
        {

        }


        public string convertTimeToString(Time paremeter)
        {
            return paremeter.hour + ":" + paremeter.minute;
        }

        public Time convertStringToTime(string parameter)
        {
            return new Time();
        }
    }
}
