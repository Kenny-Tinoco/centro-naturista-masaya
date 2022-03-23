using MasayaNaturistCenter.Model.Utilities;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    public class PersonalInformation
    {
        private int id;
        private Name name;
        private int age;
        private string dni;
        private string address;

        public PersonalInformation()
        {
        }

        public PersonalInformation(Name name, int age, string dni, string address) : this(0, name, age, dni, address)
        {
            id = getId();
        }

        public PersonalInformation(int id, Name name, int age, string dni, string address)
        {
            Contract.Requires(name != null && dni != null && address != null && validAge(age) && id >= 0);
            this.id = id;
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
