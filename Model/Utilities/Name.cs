using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model.Utilities
{
    internal class Name
    {
        private string _name;
        private string _lastName;

        public Name()
        {

        }

        public Name(string name, string lastName)
        {
            Contract.Requires(name != null && lastName != null);
            _name = name;
            _lastName = lastName;
        }

        public string fullName()
        {
            return _name + " " + _lastName;
        }
    }
}
