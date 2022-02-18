
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace CentroNaturistaMasaya.Model
{
    internal class Employee
    {
        private PersonalInformation personalInformation;
        private string position;
        private List<Sell> productsSalesRecord;

        public Employee()
        {
        }

        public Employee(PersonalInformation personalInformation, string position) : this()
        {
            Contract.Requires(personalInformation != null && position != null);
            this.personalInformation = personalInformation;
            this.position = position;
            productsSalesRecord = new List<Sell>();
        }
    }
}
