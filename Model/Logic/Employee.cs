
using MasayaNaturistCenter.Model.Utilities;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    internal class Employee
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
