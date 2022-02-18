using System.Diagnostics.Contracts;

namespace CentroNaturistaMasaya.Model
{
    internal class PersonalInformation
    {
        private int id;
        private Name name;
        private int age;
        private string dni;
        private string address;

        public PersonalInformation()
        {
            this.id = getId();
        }

        public PersonalInformation(Name name, int age, string dni, string address) : this()
        {
            Contract.Requires(name != null && dni != null && address != null && validAge(age));
            this.name = name;
            this.age = age;
            this.dni = dni;
            this.address = address;
        }

        private int getId()
        {
            int id = 0;
            return id;
        }

        private bool validAge(int age)
        {
            return age > 17 && age < 100;
        }
    }
}
