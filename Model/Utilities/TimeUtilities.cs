namespace MasayaNaturistCenter.Model.Utilities
{
    public class TimeUtilities
    {
        public TimeUtilities()
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
        
        public Time actualTime()
        {
            Time time = new Time();
            return time;
        }
    }
}
