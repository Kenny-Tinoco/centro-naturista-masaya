using System.Diagnostics.Contracts;

namespace CentroNaturistaMasaya.Model
{
    internal class Product
    {
        private int idProduct;
        private string name;
        private string description;
        private int quantity;

        public Product()
        {
        }

        public Product(string name, string description)
        {
            Contract.Requires(name != null && description != null);
            this.name = name;
            this.description = description;
        }


    }
}
