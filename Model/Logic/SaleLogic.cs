using MasayaNaturistCenter.Model.DAO;
using MasayaNaturistCenter.Model.DTO;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model.Logic
{
    public class SaleLogic : TransactionLogic
    {
        public TransactionLogic sellDAO;
        public EmployeeDTO employee;

        public SaleLogic()
        {
        }

        public SaleLogic(EmployeeDTO employee)
        {
            Contract.Requires(employee != null);
            this.employee = employee;
        }


        public void makeSale()
        {
            sellDAO.makeTransaction();
        }

        void reduceQuantityInProducts()
        {
        }
    }
}
