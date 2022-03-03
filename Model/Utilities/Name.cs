using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model.Utilities
{
    public class Name
    {
        private string name;
        private string lastName;

        public Name()
        {
        }

        public Name(string name, string lastName)
        {
            Contract.Requires(name != null && lastName != null);
            this.name = name;
            this.lastName = lastName;
        }

        public string fullName()
        {
            return name + " " + lastName;
        }
    }
}
