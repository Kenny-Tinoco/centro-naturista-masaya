using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DataSource;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class EmployeeDAOSQL : BaseDAOSQL<Employee>, EmployeeDAO
    {
        public EmployeeDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.Employee;
        }
    }
}
