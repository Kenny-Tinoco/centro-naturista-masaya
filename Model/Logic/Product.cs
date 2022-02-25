using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    public class Product
    {
        private int idProduct;
        private string name;
        private string description;
        private int quantity;

        public Product()
        {
        }

        public Product(string name, string description) : this(0, name, description, 0)
        {
        }

        public Product(int idProduct, string name, string description) : this(idProduct, name, description, 0)
        {

        }

        public Product(int idProduct, string name, string description, int quantity)
        {
            Contract.Requires(idProduct >= 0 && name != null && description != null && quantity >= 0);
            this.idProduct = idProduct;
            this.name = name;
            this.description = description;
            this.quantity = quantity;
        }
    }
}
