using DataAccess.DAO.DAOInterfaces;
using DataAccess.SqlServerDataSource;

namespace Domain.Logic
{
    public class StockModalLogic : BaseLogic<StockView>
    {
        private ProductDAO productDAO;
        private PresentationDAO presentationDAO;

        public StockModalLogic( DAOFactory parameter ) : base(parameter.stockDAO)
        {
            productDAO = parameter.productDAO;
            presentationDAO = parameter.presentationDAO;
        }
    }
}
