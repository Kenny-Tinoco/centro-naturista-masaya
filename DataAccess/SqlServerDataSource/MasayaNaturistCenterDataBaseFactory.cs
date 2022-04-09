using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace DataAccess.SqlServerDataSource
{
    public class MasayaNaturistCenterDataBaseFactory
    {
        private readonly Action<DbContextOptionsBuilder> _configureDbContext;

        public MasayaNaturistCenterDataBaseFactory(Action<DbContextOptionsBuilder> configureDbContext)
        {
            _configureDbContext = configureDbContext;
        }
        public MasayaNaturistCenterDataBaseFactory()
        { 
        }
        public MasayaNaturistCenterDataBase CreateDbContext()
        {
            DbContextOptionsBuilder<MasayaNaturistCenterDataBase> options = new DbContextOptionsBuilder<MasayaNaturistCenterDataBase>();

            _configureDbContext(options);

            return new MasayaNaturistCenterDataBase(options.Options);
        }
        public Action<DbContextOptionsBuilder> getConfigureDbContext()
        {

            Action<DbContextOptionsBuilder> configureDbContext = o => o.UseSqlServer("Data Source=DESKTOP-IHM40D4\\SQLEXPRESS;initial catalog=MasayaNaturistCenter;integrated security=True");

            return configureDbContext;
        }
    }
}
