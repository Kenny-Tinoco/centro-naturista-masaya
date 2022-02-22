using System.Data.SqlClient;

namespace CentroNaturistaMasaya.Model.DAO
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
