using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    internal class Stock
    {
        private int idProductStock;
        private int idProduct;
        private Presentations presentation;
        private Date expiration;
        private int quantity;
        private float price;
        private Date entryDate;


        public Stock()
        {
            getId();
        }

        public Stock(Presentations presentation) : this()
        {
           
        }

        public Stock(Presentations presentation, Date expiration, int quantity, float price) : this(presentation, new Date().getToday(), expiration, quantity, price)
        { 
        }

        public Stock(Presentations presentation, Date entryDate, Date expiration, int quantity, float price)
        {
            Contract.Requires(entryDate != null && expiration != null);
            
            this.presentation = presentation;
            this.entryDate = entryDate;
            this.expiration = expiration;
            this.quantity = quantity;
            this.price = price;
        }

        
        public int IdProductStock
        {
            set { idProductStock = value; }
            get { return idProductStock; }
        }

        public float Price
        {
            set { price = value; }
            get { return price; }
        }

        public void reduceQuantity()
        {
            if(quantity > 0)
            quantity--;
        }

        public void increaseQuantity()
        {
            quantity++;
        }

        private void getId()
        {
            IdProductStock = 0;
        }

    }
}
