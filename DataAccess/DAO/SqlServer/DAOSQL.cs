using DataAccess.DAO.DAOInterfaces;
using DataAccess.Model.DataSource;
using DataAccess.Model.DTO;

namespace DataAccess.DAO.SqlServer
{
    public class ConsultDAOSQL : BaseDAOSQL<Consult, ConsultDTO>, ConsultDAO<ConsultDTO>
    {
        public ConsultDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.Consult;
        }

    }

    public class EmployeeDAOSQL : BaseDAOSQL<Employee, EmployeeDTO>, EmployeeDAO<EmployeeDTO>
    {
        public EmployeeDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.Employee;
        }
    }

    public class PatientDAOSQL : BaseDAOSQL<Patient, PatientDTO>, PatientDAO<PatientDTO>
    {
        public PatientDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.Patient;
        }
    }
   
    public class PrescriptionProductDAOSQL : BaseDAOSQL<PrescriptionProduct, PrescriptionProductDTO>, PrescriptionProductDAO<PrescriptionProductDTO>
    {
        public PrescriptionProductDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.PrescriptionProduct;
        }
    }

    public class PresentationDAOSQL : BaseDAOSQL<Presentation, PresentationDTO>, PresentationDAO<PresentationDTO>
    {
        public PresentationDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.Presentation;
        }

        public override Presentation converter( PresentationDTO element )
        {
            var specificDTO = (PresentationDTO)element;
            return new Presentation
            {
                name = specificDTO.name
            };
        }

        public override PresentationDTO convertToDTO( Presentation parameter )
        {
            var element = new PresentationDTO
            {
                idPresentation = parameter.idPresentation,
                name = parameter.name
            };

            return element;
        }
    }

    public class ProductDAOSQL : BaseDAOSQL<Product, ProductDTO>, ProductDAO<ProductDTO>
    {
        public ProductDAOSQL( MasayaNaturistCenterDataBase parameter ) : base(parameter)
        {
            entity = parameter.Product;
        }

        public override ProductDTO convertToDTO( Product parameter )
        {
            var element = new ProductDTO()
            {
                idProduct = parameter.idProduct,
                name = parameter.name,
                description = parameter.description,
                quantity = parameter.quantity
            };
            return element;
        }

        public override Product converter( ProductDTO element )
        {
            var specificDTO = element;
            return new Product()
            {
                idProduct = specificDTO.idProduct,
                name = specificDTO.name,
                description = specificDTO.description,
                quantity = specificDTO.quantity
            };
        }
    }

    public class ProviderDAOSQL : BaseDAOSQL<Provider, ProviderDTO>, ProviderDAO<ProviderDTO>
    {
        public ProviderDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.Provider;
        }
    }

    public class SaleDetailDAOSQL : BaseDAOSQL<SaleDetail, TransactionDetailDTO>, TransactionDetailDAO<TransactionDetailDTO>
    {
        public SaleDetailDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.SaleDetail;
        }
    }

    public class SellDAOSQL : BaseDAOSQL<Sell, TransactionDTO>, TransactionDAO<TransactionDTO>
    {
        public SellDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.Sell;
        }

        public override Sell converter( TransactionDTO parameter )
        {
            var dateUtilities = new Model.Utilities.DateUtilities();

            var element = new Sell
            {
                idSell = parameter.idTransaction,
                idEmployee = parameter.idTransactionRelatedObjet,
                date = dateUtilities.convertDateToDateTime(parameter.date),
                total = parameter.total
            };

            return element;
        }

        public override TransactionDTO convertToDTO( Sell parameter )
        {
            var dateUtilities = new Model.Utilities.DateUtilities();
            var timeUtilities = new Model.Utilities.TimeUtilities();

            var element = new TransactionDTO
            {
                idTransaction = parameter.idSell,
                idTransactionRelatedObjet = parameter.idEmployee,
                time = timeUtilities.convertDateTimeToTime(parameter.date),
                date = dateUtilities.convertDateTimeToDate(parameter.date),
                total = parameter.total
            };

            return element;
        }
    }

    public class StockDAOSQL : BaseDAOSQL<StockView, StockViewDTO>, StockDAO<StockViewDTO>
    {
        public StockDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.StockView;
        }

        public override StockViewDTO convertToDTO( StockView parameter )
        {
            var element = new StockViewDTO
            {
                idStock = parameter.idStock,
                name = parameter.name,
                description = parameter.description,
                presentation = parameter.presentation,
                quantity = parameter.quantity,
                price = parameter.price,
                entryDate = parameter.entryDate,
                expiration = parameter.expiration
            };

            return element;
        }
    }

    public class SupplyDAOSQL : BaseDAOSQL<Supply, TransactionDTO>, TransactionDAO<TransactionDTO>
    {
        public SupplyDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.Supply;
        }
    }

    public class SupplyDetailDAOSQL : BaseDAOSQL<SupplyDetail, TransactionDetailDTO>, TransactionDetailDAO<TransactionDetailDTO>
    {
        public SupplyDetailDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.SupplyDetail;
        }
    }
}
