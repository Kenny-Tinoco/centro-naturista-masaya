using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    public class Sell : Transaction
    {
        private Employee employee;
       

        public Sell()
        {
        }

        public Sell(Employee employee)
        {
            Contract.Requires(employee != null);
            this.employee = employee;
        }


        public void makeSale()
        {
            getTotal();
            reduceQuantityInProducts();
            saveChange();
        }

        void reduceQuantityInProducts()
        {
            foreach (Detail i in detail)
            {
                for (int j = 1; j <= i.Quantity; j++)
                    i.Product.reduceQuantity();
            }
        }

        public Employee Employee
        {
            set { employee = value; }
            get { return employee; }
        }
    }
}
