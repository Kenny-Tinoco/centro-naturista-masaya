using DataAccess.DAO.DAOInterfaces;
using DataAccess.SqlServerDataSource;
using System.Diagnostics.Contracts;

namespace Domain.Logic
{
    public class ProductLogic : BaseLogic<Product>
    {
        public ProductLogic( DAOFactory parameter ) : base(parameter.productDAO)
        {
        }

        public bool searchLogic( Product element, string parameter )
        {
            Contract.Requires(parameter != null && element != null);
            bool ok = false;

            if
            (
                element.idProduct.ToString().Contains(parameter.Trim()) ||
                element.name.ToLower().StartsWith(parameter.Trim().ToLower())
            )
            {
                ok = true;
            }

            return ok;
        }
    }
}
