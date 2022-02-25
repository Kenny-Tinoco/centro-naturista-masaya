using System.Data.SqlClient;

namespace MasayaNaturistCenter.Model.DAO
{
    internal class SQLServeStrategy : Strategy
    {
        public SqlConnection connection;  

        public void getBDConnection()
        {
            connection = new SqlConnection("...");
        }
    }
}
