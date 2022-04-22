using System.Diagnostics.Contracts;
using System.Transactions;

namespace Domain.Logic
{
    public abstract class TransactionLogic
    {
        public Entities.Transaction transaction { get; set; }


        public TransactionLogic() : this(new Entities.Transaction())
        {
        }

        public TransactionLogic(Entities.Transaction parameter)
        {
            Contract.Requires(parameter != null);
            this.transaction = parameter;
        }


        //public void addDetail(Stock parameter, int quantity)
        //{
        //    Contract.Requires(parameter != null && quantity >= 1);

        //    var detail = stockToDetail(parameter, quantity);

        //    transaction.details.Add(detail);
        //}

        //public void removeDetail(Stock parameter)
        //{
        //    var element = findDetailByStockId(parameter.idStock);
        //    transaction.details.Remove(element);
        //}

        //public void editDetail(Stock parameter, int quantity)
        //{
        //    var element = findDetailByStockId(parameter.idProduct);
        //    element.quantity = quantity;
        //    calculateTotalDetail(element);
        //}
        
        //public Detail findDetail(Stock parameter)
        //{
        //    return findDetailByStockId(parameter.idStock);
        //}
    
        //protected void makeTransaction()
        //{

        //}

        //public void calculateTotal()
        //{
        //    transaction.total = 0;

        //    foreach(var item in transaction.details)
        //    {
        //        transaction.total += item.total;
        //    }
        //}


        //private Detail stockToDetail(Stock parameter, int quantity)
        //{
        //    var element = new Detail();

        //    element.idTransaction = transaction.idTransaction;
        //    element.idStock = parameter.idStock;
        //    element.price = parameter.price;
        //    element.quantity = quantity;
        //    calculateTotalDetail(element);

        //    return element;
        //}

        //private void calculateTotalDetail(Detail parameter)
        //{
        //    parameter.total = parameter.price * parameter.quantity;
        //}
       
        //private Detail findDetailByStockId(int parameter)
        //{
        //    Contract.Requires(parameter >= 0);

        //    var foundElement = new Detail();

        //    foreach(var item in transaction.details)
        //    {
        //        if (item.idStock == parameter)
        //        {
        //            foundElement = item;
        //            break;
        //        }
        //    }

        //    return foundElement;
        //}
        
    }
}
