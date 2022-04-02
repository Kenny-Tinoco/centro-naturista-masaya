using DataAccess.DAO.DAOInterfaces;
using DataAccess.Model.DTO;

namespace Domain.Logic
{
    public class StockModalLogic : BaseLogic<StockViewDTO>
    {
        private ProductDAO<ProductDTO> productDAO;
        private PresentationDAO<PresentationDTO> presentationDAO;

        public StockModalLogic( DAOFactory parameter ) : base(parameter.stockDAO)
        {
            productDAO = parameter.productDAO;
            presentationDAO = parameter.presentationDAO;
        }
    }
}
