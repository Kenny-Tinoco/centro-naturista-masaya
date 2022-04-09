using DataAccess.DAO.DAOInterfaces;
using DataAccess.SqlServerDataSource;

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
        public PresentationDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) { }

        //public override Model.DataSource.Presentation converterToDTO(Entities.Presentation element)
        //{
        //    var specificDTO = element;
        //    return new Model.DataSource.Presentation
        //    {
        //        name = specificDTO.name
        //    };
        //}

        //public override Entities.Presentation convert(Model.DataSource.Presentation parameter)
        //{
        //    var element = new Entities.Presentation
        //    {
        //        idPresentation = parameter.idPresentation,
        //        name = parameter.name
        //    };

        //    return element;
        //}
        //public override string getEntityName()
        //{
        //    return "Presentation";
        //}
        //public override async Task update(Entities.Presentation element)
        //{
        //    _dataBase.sp_Presentation_TableManager((int)Operation.update, element.idPresentation, element.name);
        //}
    }

    public class ProductDAOSQL : BaseDAOSQL<Product>, ProductDAO
    {
        public ProductDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) { }

        //public override Entities.Product convert(Model.DataSource.Product parameter)
        //{
        //    var element = new Entities.Product()
        //    {
        //        idProduct = parameter.idProduct,
        //        name = parameter.name,
        //        description = parameter.description,
        //        quantity = parameter.quantity
        //    };
        //    return element;
        //}

        //public override Model.DataSource.Product converterToDTO(Entities.Product element)
        //{
        //    var specificDTO = element;
        //    return new Model.DataSource.Product()
        //    {
        //        idProduct = specificDTO.idProduct,
        //        name = specificDTO.name,
        //        description = specificDTO.description,
        //        quantity = specificDTO.quantity
        //    };
        //}
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

        //public override Sell converterToDTO(Transaction parameter)
        //{

        //    var element = new Sell
        //    {
        //        idSell = parameter.idTransaction,
        //        idEmployee = parameter.idTransactionRelatedObjet,
        //        date = parameter.date,
        //        total = parameter.total
        //    };

        //    return element;
        //}

        //public override Transaction convert(Sell parameter)
        //{

        //    var element = new Transaction
        //    {
        //        idTransaction = parameter.idSell,
        //        idTransactionRelatedObjet = parameter.idEmployee,
        //        time = parameter.date.ToString(),
        //        date = parameter.date,
        //        total = parameter.total
        //    };

        //    return element;
        //}
    }
    
    public class StockDAOSQL : BaseDAOSQL<StockView>, StockDAO
    {
        public StockDAOSQL(MasayaNaturistCenterDataBaseFactory dataBaseContext) : base(dataBaseContext) { }

        //public override Entities.StockView convert(Model.DataSource.StockView parameter)
        //{
        //    var element = new Entities.StockView
        //    {
        //        idStock = parameter.idStock,
        //        name = parameter.name,
        //        description = parameter.description,
        //        presentation = parameter.presentation,
        //        quantity = parameter.quantity,
        //        price = parameter.price,
        //        entryDate = parameter.entryDate,
        //        expiration = parameter.expiration
        //    };

        //    return element;
        //}
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
