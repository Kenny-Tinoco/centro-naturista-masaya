using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DTO;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model.Logic
{
    public class SaleLogic : TransactionLogic
    {
        public TransactionDAO sellDAO;
        public EmployeeDTO employee;


        public SaleLogic()
        {
        }

        public SaleLogic(EmployeeDTO employee, TransactionDTO transaction) : base(transaction)
        {
            Contract.Requires(employee != null && transaction != null);
            this.employee = employee;
        }


        public void makeSale()
        {
            makeTransaction();
        }

        void reduceQuantityInProducts()
        {
        }
    }
}
