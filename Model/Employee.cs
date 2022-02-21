
using CentroNaturistaMasaya.Model.Utilities;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace CentroNaturistaMasaya.Model
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
