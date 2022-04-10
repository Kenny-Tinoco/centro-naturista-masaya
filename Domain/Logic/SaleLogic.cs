using DataAccess.Entities;
using System.Diagnostics.Contracts;

namespace Domain.Logic
{
    public class SaleLogic : TransactionLogic
    {
        //public TransactionDAO<BaseEntity> sellDAO;
        public Employee employee;


        public SaleLogic()
        {
        }

        public SaleLogic(Employee employee, Transaction transaction) : base(transaction)
        {
            Contract.Requires(employee != null && transaction != null);
            this.employee = employee;
        }


        public void makeSale()
        {
            //makeTransaction();
        }

        void reduceQuantityInProducts()
        {
        }
    }
}
