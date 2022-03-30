using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DataSource;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class ProviderDAOSQL : BaseDAOSQL<Provider>, ProviderDAO
    {
        public ProviderDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.Provider;
        }
    }
}
