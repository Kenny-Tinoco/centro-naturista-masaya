using DataAccess.DAO.DAOInterfaces;
using DataAccess.Model.DTO;
using System.Diagnostics.Contracts;

namespace Domain.Logic
{
    public class SaleLogic : TransactionLogic
    {
        public TransactionDAO<BaseDTO> sellDAO;
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
