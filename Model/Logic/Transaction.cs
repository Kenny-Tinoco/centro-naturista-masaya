using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    internal class Transaction
    {
        protected int id;
        private Date date;
        private Time time;
        private float total = -1;
        protected List<Detail> detail;


        public Transaction()
        {
        }

        public Transaction(Time time, Date date)
        {
            Contract.Requires(time != null && date != null);
            this.time = time;
            this.date = date;
        }

        public Transaction(Time time, Date date, List<Detail> detail)
        {
            Contract.Requires(time != null && date != null);
            this.time = time;
            this.date = date;
            this.detail = detail;
        }


        public void addProductDetail(Stock product, int quantity)
        {            
            detail.Add(new Detail(product, quantity));
        }

        public void deleteProductDetail(Stock product)
        {
            this.detail.Remove(findDetail(product));
        }

        private Detail findDetail(Stock product)
        {
            Contract.Requires(product != null);
            
            Detail detail = new Detail();

            foreach (Detail i in this.detail)
            {
                if (i.Product == product)
                {
                    detail = i;
                    break;
                }
            }

            return detail;
        }

        public void editQuantity(Stock product, int quantity)
        {
            Contract.Requires(product != null && quantity >= 1);
            findDetail(product).Quantity = quantity;
        }

        public void calculateTotal()
        {
            total = 0;
            foreach (Detail detail in detail)
            {
                total += detail.getTotal();
            }
        }

        public float getTotal()
        {
            if (total == -1)
                calculateTotal();

            return total;
        }

        protected void saveChange()
        {
            throw new NotImplementedException();
        }

    }
}
