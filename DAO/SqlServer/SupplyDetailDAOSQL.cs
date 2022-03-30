using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DataSource;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class SupplyDetailDAOSQL : BaseDAOSQL<SupplyDetail>, TransactionDetailDAO
    {
        public SupplyDetailDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.SupplyDetail;
        }
    }
}
