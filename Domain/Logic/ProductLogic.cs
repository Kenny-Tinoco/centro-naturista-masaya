using DataAccess.DAO.DAOInterfaces;
using DataAccess.Model.DTO;
using System.Diagnostics.Contracts;

namespace Domain.Logic
{
    public class ProductLogic : BaseLogic<ProductDTO>
    {
        public ProductLogic( DAOFactory parameter ) : base(parameter.productDAO)
        {
        }

        public bool searchLogic( ProductDTO element, string parameter )
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
