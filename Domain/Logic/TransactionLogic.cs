using DataAccess.Model.DTO;
using System.Diagnostics.Contracts;

namespace Domain.Logic
{
    public abstract class TransactionLogic
    {
        public TransactionDTO transaction { get; set; }


        public TransactionLogic() : this(new TransactionDTO())
        {
        }

        public TransactionLogic(TransactionDTO parameter)
        {
            Contract.Requires(parameter != null);
            this.transaction = parameter;
        }


        public void addDetail(StockDTO parameter, int quantity)
        {
            Contract.Requires(parameter != null && quantity >= 1);

            var detail = stockToDetail(parameter, quantity);

            transaction.details.Add(detail);
        }

        public void removeDetail(StockDTO parameter)
        {
            var element = findDetailByStockId(parameter.idStock);
            transaction.details.Remove(element);
        }

        public void editDetail(StockDTO parameter, int quantity)
        {
            var element = findDetailByStockId(parameter.idProduct);
            element.quantity = quantity;
            calculateTotalDetail(element);
        }
        
        public DetailDTO findDetail(StockDTO parameter)
        {
            return findDetailByStockId(parameter.idStock);
        }
    
        protected void makeTransaction()
        {

        }

        public void calculateTotal()
        {
            transaction.total = 0;

            foreach(var item in transaction.details)
            {
                transaction.total += item.total;
            }
        }


        private DetailDTO stockToDetail(StockDTO parameter, int quantity)
        {
            var element = new DetailDTO();

            element.idTransaction = transaction.idTransaction;
            element.idStock = parameter.idStock;
            element.price = parameter.price;
            element.quantity = quantity;
            calculateTotalDetail(element);

            return element;
        }

        private void calculateTotalDetail(DetailDTO parameter)
        {
            parameter.total = parameter.price * parameter.quantity;
        }
       
        private DetailDTO findDetailByStockId(int parameter)
        {
            Contract.Requires(parameter >= 0);

            var foundElement = new DetailDTO();

            foreach(var item in transaction.details)
            {
                if (item.idStock == parameter)
                {
                    foundElement = item;
                    break;
                }
            }

            return foundElement;
        }
        
    }
}
