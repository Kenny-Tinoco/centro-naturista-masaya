namespace Domain.Logic
{
    public class PersonalInformation
    {
        private bool validAge(int age)
        {
            return age > 17 && age < 100;
        }
    }
}
