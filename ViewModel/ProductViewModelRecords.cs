using MasayaNaturistCenter.DAO.SqlServer;
using MasayaNaturistCenter.Model.DTO;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.ViewModel
{
    public class ProductViewModelRecords
    {
        private ProductDAOSQL productDAO;


        public ProductViewModelRecords(ProductDAOSQL parameter)
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