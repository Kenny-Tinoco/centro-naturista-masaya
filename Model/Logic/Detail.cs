using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    internal class Detail
    {
        private int idDetail;
        private Stock product;
        private int quantity;
        private float price;
        private float subTota = -1;

        public Detail()
        {
            getId();
        }

        public Detail(int idDetail, Stock product, int quantity) : this(product, quantity)
        {
            Contract.Requires(idDetail >= 0);
            this.idDetail = idDetail;
        }

        public Detail(Stock product, int quantity) : this()
        {
            Contract.Requires(product != null && quantity >= 1);
            addDetail(product, quantity);
        }


        public void addDetail(Stock product, int quantity)
        {
            this.product = product;
            this.price = product.Price;
            Quantity = quantity;
        }

        public Stock Product
        {
            set { product = value; }
            get { return product; }
        }

        public int Quantity
        {
            set { quantity = value; }
            get { return quantity; }
        }
         
        private void getId()
        {
            idDetail = 0;
        }

        public float getTotal()
        {
            if(subTota == -1)
            {
                subTota = price * quantity;
            }
            return subTota;
        }
    }
}