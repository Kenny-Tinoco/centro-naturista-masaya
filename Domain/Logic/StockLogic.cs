using DataAccess.DAO.DAOInterfaces;
using DataAccess.SqlServerDataSource.Views;
using System.Diagnostics.Contracts;

namespace Domain.Logic
{
    public class StockLogic : BaseLogic<StockView>
    {
        public StockLogic(DAOFactory parameter) : base(parameter.stockDAO)
        {
        }

       
        public bool searchLogic(StockView element, string parameter)
        {
            Contract.Requires(parameter != null && element != null);
            bool ok = false;

            if
            (
                element.idStock.ToString().Contains(parameter.Trim()) ||
                element.name.ToLower().StartsWith(parameter.Trim().ToLower()) ||
                element.presentation.ToLower().StartsWith(parameter.Trim().ToLower())
            )
            {
                ok = true;
            }

            return ok;
        }
    }
}
