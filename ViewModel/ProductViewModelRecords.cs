using MasayaNaturistCenter.Model.DAO;
using MasayaNaturistCenter.Model.DTO;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.ViewModel
{
    public class ProductViewModelRecords
    {
        private IProductDAO productDAO;


        public ProductViewModelRecords(IProductDAO parameter)
        {
            Contract.Requires(parameter != null);
            productDAO = parameter;
        }


        public List<ProductDTO> getAll()
        {
            return productDAO.getAll();
        }
    }
}