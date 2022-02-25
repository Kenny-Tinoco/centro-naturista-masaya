using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    internal class Provider
    {
        private int idProvider;
        private string name;
        private string address;
        private string RUC;
        private List<string> telephones;


        public Provider()
        {
            telephones = new List<string>();
        }

        public Provider(string name, string address, string RUC) : this(0, name, address, RUC)
        {
            idProvider = getId();
        }

        public Provider(int idProvider, string name, string address, string RUC) : this()
        {
            Contract.Requires(name != null);
            this.idProvider = idProvider;
            this.name = name;
            this.address = address;
            this.RUC = RUC;
        }


        public void addTelephone(string telephone)
        {
            Contract.Requires(telephone != null);
            telephones.Add(telephone);
        }

        public void deleteTelephone(string telephone)
        {
            Contract.Requires(telephone != null);
            telephones.Remove(telephone);
        }

        public int getId()
        {
            return 0;
        }
    }
}