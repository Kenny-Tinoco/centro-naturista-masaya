using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DataSource;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class PrescriptionProductDAOSQL : BaseDAOSQL, PrescriptionProductDAO
    {
        public PrescriptionProductDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.PrescriptionProduct;
        }
    }
}
