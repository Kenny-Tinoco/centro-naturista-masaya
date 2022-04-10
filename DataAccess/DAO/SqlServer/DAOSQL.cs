using DataAccess.DAO.DAOInterfaces;
using DataAccess.Entities;
using DataAccess.SqlServerDataSource;
using DataAccess.SqlServerDataSource.Views;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAO.SqlServer
{
    public class ConsultDAOSQL : BaseDAOSQL<Consult>, ConsultDAO
    {
        public ConsultDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext){}
    }

    public class EmployeeDAOSQL : BaseDAOSQL<Employee>, EmployeeDAO
    {
        public EmployeeDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) { }
    }

    public class PatientDAOSQL : BaseDAOSQL<Patient>, PatientDAO
    {
        public PatientDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) { }
    }

    public class PrescriptionProductDAOSQL : BaseDAOSQL<PrescriptionProduct>, PrescriptionProductDAO
    {
        public PrescriptionProductDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) { }
    }

    public class PresentationDAOSQL : BaseDAOSQL<Presentation>, PresentationDAO
    {
        public PresentationDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) {}

        protected override bool validateEntity(Presentation item, object id)
        {
            if(item.idPresentation == (int)id)
                return true;

            return false;
        }
        protected override async Task<Presentation> getEntityById(object id, MasayaNaturistCenterDataBase context)
        {
            return await context.Set<Presentation>().FirstOrDefaultAsync((e) => e.idPresentation == (int)id);
        }
    }

    public class ProductDAOSQL : BaseDAOSQL<Product>, ProductDAO
    {
        public ProductDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) { }
    }

    public class ProviderDAOSQL : BaseDAOSQL<Provider>, ProviderDAO
    {
        public ProviderDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) { }
    }

    public class SaleDetailDAOSQL : BaseDAOSQL<TransactionDetail>, TransactionDetailDAO
    {
        public SaleDetailDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) { }
    }

    public class SellDAOSQL : BaseDAOSQL<Transaction>, TransactionDAO
    {
        public SellDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) { }
    }
    
    public class StockDAOSQL : BaseDAOSQL<StockView>, StockDAO
    {
        public StockDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) { }
    }

    public class SupplyDAOSQL : BaseDAOSQL<Transaction>, TransactionDAO
    {
        public SupplyDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) { }
    }

    public class SupplyDetailDAOSQL : BaseDAOSQL<TransactionDetail>, TransactionDetailDAO
    {
        public SupplyDetailDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) { }
    }
}
