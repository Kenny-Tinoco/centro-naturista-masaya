using Domain.Utilities;
using System.Diagnostics.Contracts;

namespace Domain.Logic
{
    public class Employee
    {
        private PersonalInformation personalInformation;
        private Position position;

        public Employee()
        {
        }

        public Employee(PersonalInformation personalInformation, Position position)
        {
            Contract.Requires(personalInformation != null);

            this.personalInformation = personalInformation;
            this.position = position;
        }
    }
}
